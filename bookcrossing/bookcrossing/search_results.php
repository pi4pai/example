<?php
if (!isset($_COOKIE['id_user'])) {
    echo '<p>Ви не увійшли в систему. Перенаправляємо вас на сторінку входу.</p>';
    header('Location: auth.php');
    exit();
}

require "lib/db.php";

$id_user = $_COOKIE['id_user'];

$search_query = $_GET['search_query'] ?? '';

$sql = 'SELECT ads.id, books.title, books.author, copies_of_books.cover, genres.name AS genre_name
        FROM ads 
        JOIN copies_of_books ON ads.id_copies_of_books = copies_of_books.id
        JOIN books ON copies_of_books.id_book = books.id
        JOIN genres ON books.id_genre = genres.id
        WHERE ads.id_user != ? AND ads.date_deact IS NULL';

$params = [$id_user];

if (!empty($search_query)) {
    $sql .= ' AND (books.title LIKE ? OR books.author LIKE ? OR genres.name LIKE ?)';
    $search_param = '%' . $search_query . '%';
    $params[] = $search_param;
    $params[] = $search_param;
    $params[] = $search_param;
}

$query = $pdo->prepare($sql);
$query->execute($params);
$ads = $query->fetchAll();
?>

<!DOCTYPE html>
<html lang="uk">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Результати пошуку</title>
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
    <?php include 'header.php'; ?>

    <section id="search-results">
        <div class="container">
            <h2>Результати пошуку</h2>
            <div class="books">
                <?php if ($ads): ?>
                    <?php foreach ($ads as $ad): ?>
                        <div class="book">
                            <?php if (!empty($ad['cover'])): ?>
                                <img src="http://localhost/bookcrossing/lib/<?php echo htmlspecialchars($ad['cover']); ?>" alt="Обкладинка книги" class="book-cover">
                            <?php else: ?>
                                <p>Обкладинка не доступна</p>
                            <?php endif; ?>
                            <h3><?php echo htmlspecialchars($ad['title']); ?></h3>
                            <p>Автор: <?php echo htmlspecialchars($ad['author']); ?></p>
                            <p>Жанр: <?php echo htmlspecialchars($ad['genre_name']); ?></p>
                            <a href="details4.php?ad_id=<?php echo htmlspecialchars($ad['id']); ?>" class="details-button">Деталі оголошення</a>
                        </div>
                    <?php endforeach; ?>
                <?php else: ?>
                    <p>Немає результатів за вашим запитом.</p>
                <?php endif; ?>
            </div>
            <a href="book.php" class="back-button">Повернутись назад</a>

        </div>
    </section>

    <?php include 'footer.php'; ?>
</body>
</html>
