<?php
require "lib/db.php";

if (!isset($_COOKIE['id_user'])) {
    echo '<p>Ви не увійшли в систему. Перенаправляємо вас на сторінку входу.</p>';
    header('Location: auth.php');
    exit();
}

$id_user = $_COOKIE['id_user'];

if (isset($_GET['ad_id'])) {
    $ad_id = $_GET['ad_id'];
} else {
    header("Location: auth.php");
    exit();
}
if ($_SERVER['REQUEST_METHOD'] === 'POST' && isset($_POST['comment_text'])) {
    $comment_text = trim($_POST['comment_text']);
    if (!empty($comment_text)) {
        $sql = 'INSERT INTO comments (id_ads, id_user, comment, date_act_com) VALUES (?, ?, ?, NOW())';
        $query = $pdo->prepare($sql);
        $query->execute([$ad_id, $id_user, $comment_text]);
        header("Location: details2.php?ad_id=$ad_id");
        exit();
    } else {
        echo '<p>Коментар не може бути порожнім.</p>';
    }
}

if ($_SERVER['REQUEST_METHOD'] === 'POST' && isset($_POST['save_ad'])) {
    $sql_check = 'SELECT * FROM save_ads WHERE id_user = ? AND id_ads = ? AND date_remove IS NULL';
    $query_check = $pdo->prepare($sql_check);
    $query_check->execute([$id_user, $ad_id]);
    $saved = $query_check->fetch();

    if (!$saved) {
        $sql_save = 'INSERT INTO save_ads (id_user, id_ads, date_added, date_remove) VALUES (?, ?, NOW(), NULL)';
        $query_save = $pdo->prepare($sql_save);
        $query_save->execute([$id_user, $ad_id]);
        header("Location: details2.php?ad_id=$ad_id");
        exit();
    } else {
        echo '<p>Це оголошення вже є у вашому вибраному.</p>';
    }
}

$sql = 'SELECT ads.id, books.title, books.author, books.annotation, ads.date_act, copies_of_books.cover,
        genres.name AS genre_name, publishers.name AS publish_name, types.name AS type_name, 
        ages.name AS age_category_name, copies_of_books.pages, bindings.name AS binding_name,
        contact_users.social_network, contact_users.phone_number, conditions.name AS condition_name, 
        cities.name AS city_name
        FROM ads
        JOIN copies_of_books ON ads.id_copies_of_books = copies_of_books.id
        JOIN books ON copies_of_books.id_book = books.id
        JOIN contact_users ON ads.id_contact = contact_users.id
        JOIN genres ON books.id_genre = genres.id
        JOIN publishers ON copies_of_books.id_publish = publishers.id
        JOIN types ON books.id_type = types.id
        JOIN ages ON copies_of_books.id_age_category = ages.id
        JOIN bindings ON copies_of_books.id_binding = bindings.id
        JOIN conditions ON ads.id_condition = conditions.id
        JOIN cities ON ads.id_city = cities.id
        WHERE ads.id = ?';

$query = $pdo->prepare($sql);
$query->execute([$ad_id]);
$ad = $query->fetch();
if (!$ad) {
    echo 'Оголошення не знайдено.';
    exit();
}

$sql = 'SELECT comments.comment, comments.date_act_com, users.login
        FROM comments
        JOIN users ON comments.id_user = users.id
        WHERE comments.id_ads = ?
        ORDER BY comments.date_act_com DESC';

$query = $pdo->prepare($sql);
$query->execute([$ad_id]);
$comments = $query->fetchAll();

?>

<!DOCTYPE html>
<html lang="uk">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Деталі оголошення</title>
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
    <?php include 'header.php'; ?>

    <div class="details-form">
        <div class="book-details">
            <div class="book-info">
                <h2>Деталі оголошення</h2>
                <h3>Назва: <?php echo htmlspecialchars($ad['title']); ?></h3>
                <p><strong>Автор:</strong> <?php echo htmlspecialchars($ad['author']); ?></p>
                <p><strong>Опис:</strong> <?php echo nl2br(htmlspecialchars($ad['annotation'])); ?></p>
                <p><strong>Дата публікації:</strong> <?php echo htmlspecialchars($ad['date_act']); ?></p>

                <p><strong>Жанр:</strong> <?php echo htmlspecialchars($ad['genre_name']); ?></p>
                <p><strong>Видавництво:</strong> <?php echo htmlspecialchars($ad['publish_name']); ?></p>
                <p><strong>Тип книги:</strong> <?php echo htmlspecialchars($ad['type_name']); ?></p>
                <p><strong>Вікова категорія:</strong> <?php echo htmlspecialchars($ad['age_category_name']); ?></p>
                <p><strong>Кількість сторінок:</strong> <?php echo htmlspecialchars($ad['pages']); ?></p>
                <p><strong>Тип обкладинки:</strong> <?php echo htmlspecialchars($ad['binding_name']); ?></p>
                <p><strong>Соціальна мережа:</strong> <?php echo htmlspecialchars($ad['social_network']); ?></p>
                <p><strong>Телефон:</strong> <?php echo htmlspecialchars($ad['phone_number']); ?></p>
                <p><strong>Стан книги:</strong> <?php echo htmlspecialchars($ad['condition_name']); ?></p>
                <p><strong>Місто:</strong> <?php echo htmlspecialchars($ad['city_name']); ?></p>
                <div class="button-container">
                <button onclick="history.back()" class="back-button">Повернутись назад</button>
                <div class="save-ad">
    <?php
    $sql_check = 'SELECT * FROM save_ads WHERE id_user = ? AND id_ads = ? AND date_remove IS NULL';
    $query_check = $pdo->prepare($sql_check);
    $query_check->execute([$id_user, $ad_id]);
    $saved = $query_check->fetch();

    if ($saved) {
        echo '<p>Оголошення вже в вибраному.</p>';
    } else {
        echo '<form action="" method="POST">
                <button type="submit" name="save_ad" class="deactivate-button">Додати до вибраного</button>
              </form>';
    }
    ?>
    </div>
</div>

            </div>

            <?php if (!empty($ad['cover'])): ?>
                <img src="http://localhost/bookcrossing/lib/<?php echo htmlspecialchars($ad['cover']); ?>" alt="Обкладинка книги" class="book-cover-details">
            <?php else: ?>
                <p>Обкладинка не доступна</p>
            <?php endif; ?>
        </div>
        <div class="comments">
            <h3>Коментарі</h3>
            <?php if ($comments): ?>
                <?php foreach ($comments as $comment): ?>
                    <div class="comment">
                        <p><strong><?php echo htmlspecialchars($comment['login']); ?>:</strong> <?php echo htmlspecialchars($comment['comment']); ?></p>
                        <p><small>Дата: <?php echo htmlspecialchars($comment['date_act_com']); ?></small></p>
                    </div>
                <?php endforeach; ?>
            <?php else: ?>
                <p>Коментарів ще немає.</p>
            <?php endif; ?>
        </div>
         <div class="add-comment">
            <h3>Додати коментар</h3>
            <form action="" method="post">
                <textarea name="comment_text" placeholder="Ваш коментар" required></textarea>
                <button type="submit">Додати коментар</button>
            </form>
        </div>
  
        
</div>
    </div>

    <?php include 'footer.php'; ?>
</body>
</html>