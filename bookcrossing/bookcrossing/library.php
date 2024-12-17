<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>BookCrossing</title>
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
    <?php include 'header.php'; ?>
    <section id="library">
        <div class="container">
        <a href="add.php" class="saved-ads-button">Додати оголошення</a>
        <a href="saved_ads.php" class="saved-ads-button">Мої збережені оголошення</a>
        <h2 class="library">Мої оголошення</h2>
            <div class="books">
            <?php include 'lib/library2.php'; ?>

            </div>
        </div>
    </section>
    <?php include 'footer.php'; ?>
</body>
</html>
