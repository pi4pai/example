import tkinter as tk
from tkinter import messagebox
from PIL import Image, ImageTk
import pandas as pd
from sklearn.feature_extraction.text import TfidfVectorizer
from scipy.spatial.distance import jaccard
import re
import spacy
import os
import textwrap
import numpy as np

class BookRecommenderApp:
    def __init__(self, root):
        self.root = root
        self.root.title("Підбір твору за текстовим описом користувача")
        self.root.geometry("1000x600")
        self.setup_main_window()

    def setup_main_window(self):
        self.canvas = tk.Canvas(self.root, width=1000, height=600)
        self.canvas.pack()
        image_path = "w.png"
        original_image = Image.open(image_path)
        resized_image = original_image.resize((1000, 600), Image.LANCZOS)
        self.photo = ImageTk.PhotoImage(resized_image)
        self.canvas.create_image(0, 0, anchor=tk.NW, image=self.photo)

        self.button = tk.Button(self.root, text="Почати", command=self.open_new_window,
                                bg="#faddc2", fg="#433831",
                                font=("Times New Roman", 25, "bold"),
                                padx=50, pady=5,
                                borderwidth=0)
        self.button.bind("<Enter>", self.on_enter)
        self.button.bind("<Leave>", self.on_leave)
        self.button.place(x=380, y=480)

        self.root.protocol("WM_DELETE_WINDOW", self.on_closing_main_window)

    def on_enter(self, event):
        self.button.config(bg="#faddc2", fg="#745e4d", activebackground="#faddc2")
        self.button.config(text="Почати")

    def on_leave(self, event):
        self.button.config(bg="#faddc2", fg="#433831", activebackground="#faddc2")
        self.button.config(text="Почати")

    def on_closing_main_window(self):
        if messagebox.askokcancel("Вихід", "Ви впевнені, що хочете закрити програму?"):
            self.root.destroy()

    def open_new_window(self):
        self.root.withdraw()
        self.new_window = NewWindow(self)
        self.new_window.protocol("WM_DELETE_WINDOW", self.on_closing_new_window)

    def return_to_main_window(self):
        self.new_window.destroy()
        self.root.deiconify()

    def open_wishlist_window(self):
        self.new_window.withdraw()
        self.wishlist_window = WishlistWindow(self)

    def on_closing_new_window(self):
        if messagebox.askokcancel("Вихід", "Ви впевнені, що хочете закрити програму?"):
            self.root.destroy()

    def set_window_geometry(self, window, width, height):
        if self.root.winfo_x() >= 0 and self.root.winfo_y() >= 0:
            window.geometry(f"{width}x{height}+{self.root.winfo_x()}+{self.root.winfo_y()}")

    @staticmethod
    def preprocess_text(text):
        nlp = spacy.load("uk_core_news_md")
        doc = nlp(text)
        processed_phrases = []
        for sent in doc.sents:
            phrase = []
            for token in sent:
                if not token.is_stop and not token.is_punct and not token.is_space:
                    phrase.append(token.lemma_.lower())
            if phrase:
                processed_phrases.append(" ".join(phrase))
        return ' '.join(processed_phrases)


class NewWindow(tk.Toplevel):
    def __init__(self, app):
        super().__init__(app.root)
        self.app = app
        self.title("Підбір твору за текстовим описом користувача")
        self.geometry("1000x600")
        self.setup_window()

    def setup_window(self):
        self.app.set_window_geometry(self, 1000, 600)
        menu_bar = tk.Menu(self)
        file_menu = tk.Menu(menu_bar, tearoff=0)
        file_menu.add_command(label="Повернутися до головного вікна", command=self.app.return_to_main_window)
        file_menu.add_command(label="Список бажаних творів", command=self.app.open_wishlist_window)
        file_menu.add_command(label="Вихід", command=self.app.on_closing_new_window)
        menu_bar.add_cascade(label="Меню", menu=file_menu)
        self.config(menu=menu_bar)

        image_path = "w_2.png"
        original_image = Image.open(image_path)
        resized_image = original_image.resize((1000, 600), Image.LANCZOS)
        photo = ImageTk.PhotoImage(resized_image)

        background_label = tk.Label(self, image=photo)
        background_label.image = photo
        background_label.place(x=0, y=0, relwidth=1, relheight=1)

        self.text = tk.Text(self, font=("Times New Roman", 12), width=50, height=15, fg="#433831")
        self.text.pack(pady=20, padx=20)
        self.text.place(x=280, y=180)

        self.button = tk.Button(self, text="Далі", command=self.search_book_by_description,
                                bg="#faddc2", fg="#433831",
                                font=("Times New Roman", 25, "bold"),
                                padx=50, pady=5,
                                borderwidth=0)
        self.button.place(x=380, y=480)

    def search_book_by_description(self):
        dataset = pd.read_excel("books_det.xlsx")
        user_input = self.app.preprocess_text(self.text.get("1.0", "end").strip())
        year_keywords = re.findall(r'\b\d{4}\b', user_input)
        for year in year_keywords:
            user_input += ' ' + year

        tfidf_vectorizer = TfidfVectorizer(min_df=2, max_df=0.8, ngram_range=(1, 2))
        text_fields = dataset['Автор'] + " " + dataset['Рік'].astype(str) + " " + dataset['Жанр'] + " " + dataset[
            'Анотація'] + " " + dataset['Формат'] + " " + dataset['Видавництво'] + " " + dataset['Стан'] + " " + \
                      dataset['Рейтинг_2']
        tfidf_matrix = tfidf_vectorizer.fit_transform(text_fields)
        user_tfidf = tfidf_vectorizer.transform([user_input])

        # Compute Jaccard distances
        jaccard_distances = []
        for book_tfidf in tfidf_matrix:
            jaccard_distances.append(jaccard(user_tfidf.toarray().flatten(), book_tfidf.toarray().flatten()))

        sorted_indices = np.argsort(jaccard_distances)
        top_books = dataset.iloc[sorted_indices[:3]]

        RecommendationWindow(self, top_books)

class WishlistWindow(tk.Toplevel):
    def __init__(self, app):
        super().__init__(app.new_window)
        self.app = app
        self.title("Список бажаних творів")
        self.geometry("1000x600")
        self.setup_window()

    def setup_window(self):
        self.app.set_window_geometry(self, 1000, 600)
        image_path = "w_4.png"
        original_image = Image.open(image_path)
        resized_image = original_image.resize((1000, 600), Image.LANCZOS)
        photo = ImageTk.PhotoImage(resized_image)

        background_label = tk.Label(self, image=photo)
        background_label.image = photo
        background_label.place(x=0, y=0, relwidth=1, relheight=1)

        self.canvas = tk.Canvas(self, bg='white', highlightbackground='white')
        self.canvas.place(relx=0.18, rely=0.15, relwidth=0.62, relheight=0.72)

        scrollbar = tk.Scrollbar(self, orient="vertical", command=self.canvas.yview)
        scrollbar.place(relx=0.80, rely=0.12, relheight=0.72)

        self.canvas.config(yscrollcommand=scrollbar.set)
        self.canvas.bind('<Configure>', self.update_scrollregion)

        self.wishlist_frame = tk.Frame(self.canvas, bg='white')
        self.canvas.create_window((0, 0), window=self.wishlist_frame, anchor='nw')

        if os.path.exists("wishlist.txt"):
            with open("wishlist.txt", "r") as file:
                row_counter = 0
                book_title = None
                book_author = None
                year = None
                rating = None
                genre = None
                annotation = None
                format_ = None
                publisher = None
                condition = None

                for line in file:
                    line = line.strip()
                    if len(line.split(":")) == 2:
                        key, value = line.split(":", 1)
                        key = key.strip()
                        value = value.strip()

                        if key == 'ID':
                            photo_id = value
                            photo_path = f"photos/{photo_id}.jpg"
                            if os.path.exists(photo_path):
                                photo = Image.open(photo_path)
                                width, height = photo.size
                                new_height = min(height, 200)
                                new_width = int(width * (new_height / height))
                                resized_photo = photo.resize((new_width, new_height), Image.LANCZOS)
                                tk_photo = ImageTk.PhotoImage(resized_photo)
                                photo_label = tk.Label(self.wishlist_frame, image=tk_photo)
                                photo_label.image = tk_photo
                                photo_label.grid(row=row_counter, column=0, padx=15, sticky="w")

                        if key == 'Назва':
                            book_title = f"Назва: {value}"
                        elif key == 'Автор':
                            book_author = f"Автор: {value}"
                        elif key == 'Рік':
                            year = f"Рік: {value}"
                        elif key == 'Рейтинг':
                            rating = f"Рейтинг: {value}"
                        elif key == 'Жанр':
                            genre = f"Жанр: {value}"
                        elif key == 'Анотація':
                            annotation_lines = textwrap.wrap(value, width=60)
                            annotation = "\n".join(annotation_lines)
                        elif key == 'Формат':
                            format_ = f"Формат: {value}"
                        elif key == 'Видавництво':
                            publisher = f"Видавництво: {value}"
                        elif key == 'Стан':
                            condition = f"Стан: {value}"

                        if all([book_title, book_author, year, rating, genre, annotation, format_, publisher, condition]):
                            book_info = f"{book_title}\n{book_author}\n{year}\n{rating}\n{genre}\n{annotation}\n{format_}\n{publisher}\n{condition}"

                            book_label = tk.Label(self.wishlist_frame, text=book_info, font=("Times New Roman", 10),
                                                justify="left", bg='white', pady=20)
                            book_label.grid(row=row_counter, column=1, columnspan=2, sticky="w")
                            row_counter += 1

                            book_title = None
                            book_author = None
                            year = None
                            rating = None
                            genre = None
                            annotation = None
                            format_ = None
                            publisher = None
                            condition = None

        self.clear_button = tk.Button(self, text="Очистити", command=self.clear_wishlist,
                                      bg="#DAB7A0", fg="#433831",
                                      font=("Times New Roman", 13, "bold"),
                                      borderwidth=0)
        self.clear_button.bind("<Enter>", self.clear_enter)
        self.clear_button.bind("<Leave>", self.clear_leave)
        self.clear_button.place(x=32, y=68)

        self.back_button = tk.Button(self, text="Назад", command=self.back_to_new_window,
                                     bg="#AD8B73", fg="#433831",
                                     font=("Times New Roman", 13, "bold"),
                                     borderwidth=0)
        self.back_button.bind("<Enter>", self.back_enter)
        self.back_button.bind("<Leave>", self.back_leave)
        self.back_button.place(x=46, y=29)

    def update_scrollregion(self, event=None):
        self.canvas.configure(scrollregion=self.canvas.bbox("all"))

    def clear_wishlist(self):
        if os.path.exists("wishlist.txt"):
            os.remove("wishlist.txt")
            self.destroy()
            self.app.open_wishlist_window()
            messagebox.showinfo("Повідомлення", "Список бажаних творів успішно очищено!")
        else:
            messagebox.showinfo("Повідомлення", "Список бажаних творів порожній.")

    def clear_enter(self, event):
        event.widget.config(bg="#DAB7A0", fg="#745e4d", activebackground="#DAB7A0")
        event.widget.config(text="Очистити")

    def clear_leave(self, event):
        event.widget.config(bg="#DAB7A0", fg="#433831", activebackground="#DAB7A0")
        event.widget.config(text="Очистити")

    def back_enter(self, event):
        event.widget.config(bg="#AD8B73", fg="#745e4d", activebackground="#AD8B73")
        event.widget.config(text="Назад")

    def back_leave(self, event):
        event.widget.config(bg="#AD8B73", fg="#433831", activebackground="#AD8B73")
        event.widget.config(text="Назад")

    def back_to_new_window(self):
        self.destroy()
        self.app.new_window.deiconify()

class RecommendationWindow(tk.Toplevel):
    def __init__(self, new_window, recommended_books):
        super().__init__(new_window)
        self.new_window = new_window
        self.recommended_books = recommended_books
        self.setup_window()

    def setup_window(self):
        self.title("Рекомендовані твори")
        self.geometry("1000x600")
        self.new_window.app.set_window_geometry(self, 1000, 600)

        image_path = "w_3.png"
        original_image = Image.open(image_path)
        resized_image = original_image.resize((1000, 600), Image.LANCZOS)
        photo = ImageTk.PhotoImage(resized_image)

        background_label = tk.Label(self, image=photo)
        background_label.image = photo
        background_label.place(x=0, y=0, relwidth=1, relheight=1)

        canvas = tk.Canvas(self, bg='white', highlightbackground='white')
        canvas.place(relx=0.18, rely=0.15, relwidth=0.62, relheight=0.72)

        scrollbar = tk.Scrollbar(self, orient="vertical", command=canvas.yview, bd=2, takefocus=True, width=20)
        scrollbar.place(relx=0.80, rely=0.12, relheight=0.72)
        canvas.config(yscrollcommand=scrollbar.set)
        canvas.bind('<Configure>', lambda e: canvas.configure(scrollregion=canvas.bbox("all")))
        inner_frame = tk.Frame(canvas, bg='white')
        canvas.create_window((0, 0), window=inner_frame, anchor="nw")

        for index, book in self.recommended_books.iterrows():
            book_frame = tk.Frame(inner_frame, pady=10, bg='white')
            book_frame.pack(fill=tk.X)

            book_info = (
                f"Назва: {book['Назва']}\n"
                f"Автор: {book['Автор']}\n"
                f"Рік: {book['Рік']}\n"
                f"Рейтинг: {book['Рейтинг']}\n"
                f"Жанр: {book['Жанр']}\n"
                f"Анотація: {book['Анотація']}\n"
                f"Формат: {book['Формат']}\n"
                f"Видавництво: {book['Видавництво']}\n"
                f"Стан: {book['Стан']}\n\n"
            )
            book_label = tk.Label(book_frame, text=book_info, font=("Times New Roman", 12), wraplength=350, justify="left", bg='white')
            book_label.pack(side=tk.LEFT)

            photo_frame = tk.Frame(book_frame, bg='white')
            photo_frame.pack(side=tk.RIGHT, padx=20)

            photo_id = book['ID']
            photo_path = f"photos/{photo_id}.jpg"
            if os.path.exists(photo_path):
                photo = Image.open(photo_path)
                width, height = photo.size
                new_height = min(height, 200)
                new_width = int(width * (new_height / height))
                resized_photo = photo.resize((new_width, new_height), Image.LANCZOS)
                tk_photo = ImageTk.PhotoImage(resized_photo)
                photo_label = tk.Label(photo_frame, image=tk_photo)
                photo_label.image = tk_photo
                photo_label.pack(padx=10, pady=10)

            add_to_wishlist_button = tk.Button(photo_frame, text="Додати до списку бажаних",
                                               command=lambda b=book: self.add_to_wishlist(b),
                                               bg="#8B694F", fg="#F8F7F4",
                                               font=("Times New Roman", 12),
                                               padx=10,pady=3)
            add_to_wishlist_button.pack(side=tk.BOTTOM)

        button = tk.Button(self, text="Назад", command=self.back_to_new_window,
                           bg="#745E4D", fg="#F8F7F4",
                           font=("Times New Roman", 13, "bold"),
                           borderwidth=0)
        button.bind("<Enter>", self.b_enter)
        button.bind("<Leave>", self.b_leave)
        button.place(x=46, y=29)

        wish_button = tk.Button(self, text="Бажанки", command=self.open_wishlist_window,
                                bg="#AD8B73", fg="#F8F7F4",
                                font=("Times New Roman", 13, "bold"),
                                borderwidth=0)
        wish_button.bind("<Enter>", self.wish_enter)
        wish_button.bind("<Leave>", self.wish_leave)
        wish_button.place(x=42, y=70)

    def add_to_wishlist(self, book):
        if not os.path.exists("wishlist.txt"):
            with open("wishlist.txt", "w") as file:
                file.write("")

        book_info = (
            f"ID: {book['ID']}\n"
            f"Назва: {book['Назва']}\n"
            f"Автор: {book['Автор']}\n"
            f"Рік: {book['Рік']}\n"
            f"Рейтинг: {book['Рейтинг']}\n"
            f"Жанр: {book['Жанр']}\n"
            f"Анотація: {book['Анотація']}\n"
            f"Формат: {book['Формат']}\n"
            f"Видавництво: {book['Видавництво']}\n"
            f"Стан: {book['Стан']}\n\n"
        )

        with open("wishlist.txt", "a") as file:
            file.write(str(book_info) + "\n")

        messagebox.showinfo("Повідомлення", f"Твір '{book['Назва']}' доданий до списку бажаних книг!")

    def back_to_new_window(self):
        self.destroy()
        self.new_window.deiconify()

    def open_wishlist_window(self):
        self.destroy()
        self.new_window.app.open_wishlist_window()

    def b_enter(self, event):
        event.widget.config(bg="#745E4D", fg="#DDC1A7", activebackground="#745E4D")
        event.widget.config(text="Назад")

    def b_leave(self, event):
        event.widget.config(bg="#745E4D", fg="#F8F7F4", activebackground="#745E4D")
        event.widget.config(text="Назад")

    def wish_enter(self, event):
        event.widget.config(bg="#AD8B73", fg="#DDC1A7", activebackground="#AD8B73")
        event.widget.config(text="Бажанки")

    def wish_leave(self, event):
        event.widget.config(bg="#AD8B73", fg="#F8F7F4", activebackground="#AD8B73")
        event.widget.config(text="Бажанки")


if __name__ == "__main__":
    root = tk.Tk()
    app = BookRecommenderApp(root)
    root.mainloop()