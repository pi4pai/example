<?php
if (!isset($_COOKIE['id_user'])) {
    echo '<p>Ви не увійшли в систему. Перенаправляємо вас на сторінку входу.</p>';
    header('Location: auth.php');
    exit();
}

require "db.php";

$id_user = $_COOKIE['id_user'];

$sql = 'SELECT ads.id, books.title, books.author, copies_of_books.cover
        FROM ads 
        JOIN copies_of_books ON ads.id_copies_of_books = copies_of_books.id
        JOIN books ON copies_of_books.id_book = books.id
        WHERE ads.id_user = ? AND ads.date_deact IS NULL';

$query = $pdo->prepare($sql);
$query->execute([$id_user]);
$ads = $query->fetchAll();

if ($ads) {
    foreach ($ads as $ad) {
        echo '<div class="book">';
        if (!empty($ad['cover'])) {
            $cover_path = 'http://localhost/bookcrossing/lib/' . htmlspecialchars($ad['cover']);
            echo '<img src="' . $cover_path . '" alt="Обкладинка книги" class="book-cover">';
        } else {
            echo '<p>Обкладинка не доступна</p>';
        }
        echo '<h3>' . htmlspecialchars($ad['title']) . '</h3>';
        echo '<p>Автор: ' . htmlspecialchars($ad['author']) . '</p>';
        echo '<a href="details.php?ad_id=' . htmlspecialchars($ad['id']) . '" class="details-button">Деталі оголошення</a>';
        echo '</div>';
    }
} else {
    echo '<p>У вас немає оголошень.</p>';
}