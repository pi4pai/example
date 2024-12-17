<!DOCTYPE html>
<html lang="uk">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>BookCrossing</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css">

    <link rel="stylesheet" href="css/style.css">
</head>

<body>
    <?php include 'header.php'; ?>
    <section id="popular">
        <div class="container">
            <form action="search_results.php" method="get" class="search-form">
                <div class="search-container">
                    <input type="text" name="search_query" placeholder="Пошук за назвою, автором або жанром" required>
                    <button type="submit" class="search-btn">
                        <i class="fas fa-search"></i>
                    </button>
                </div>
            </form>
            <div class="books">
                <?php include 'lib/popular_books.php'; ?>
            </div>
        </div>
    </section>
    <?php include 'footer.php'; ?>
</body>

</html>