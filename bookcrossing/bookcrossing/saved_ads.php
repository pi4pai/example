<?php
require "lib/db.php";

if (!isset($_COOKIE['id_user'])) {
    echo '<p>Ви не увійшли в систему. Перенаправляємо вас на сторінку входу.</p>';
    header('Location: auth.php');
    exit();
}

$id_user = $_COOKIE['id_user'];

$sql = 'SELECT ads.id, books.title, books.author, ads.date_act, copies_of_books.cover
        FROM save_ads
        JOIN ads ON save_ads.id_ads = ads.id
        JOIN copies_of_books ON ads.id_copies_of_books = copies_of_books.id
        JOIN books ON copies_of_books.id_book = books.id
        WHERE save_ads.id_user = ? AND save_ads.date_remove IS NULL
        ORDER BY save_ads.date_added DESC';

$query = $pdo->prepare($sql);
$query->execute([$id_user]);
$saved_ads = $query->fetchAll();
?>

<!DOCTYPE html>
<html lang="uk">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Мої збережені оголошення</title>
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
    <?php include 'header.php'; ?>

    <div class="container">
        <h2>Мої збережені оголошення</h2>
        <div class="books">
        <?php if ($saved_ads): ?>
            <?php foreach ($saved_ads as $ad): ?>
                <div class="book">
                    <h3><?php echo htmlspecialchars($ad['title']); ?></h3>
                    <p><strong>Автор:</strong> <?php echo htmlspecialchars($ad['author']); ?></p>

                    <?php if (!empty($ad['cover'])): ?>
                        <img src="http://localhost/bookcrossing/lib/<?php echo htmlspecialchars($ad['cover']); ?>" alt="Обкладинка книги" class="ad-cover">
                    <?php else: ?>
                        <p>Обкладинка не доступна</p>
                    <?php endif; ?>

                    <a href="details3.php?ad_id=<?php echo $ad['id']; ?>" class="details-button">Деталі оголошення</a>
                </div>
            <?php endforeach; ?>
        <?php else: ?>
            <p>У вас немає збережених оголошень.</p>
        <?php endif; ?>
        </div>
    </div>

    <?php include 'footer.php'; ?>
</body>
</html>


