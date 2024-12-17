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
    <section id="register">
    <div class="form-container">
        <h2 class="header-style-1">Реєстрація</h2>

        <form method="POST" action="lib/reg.php">
            <div class="form-group">
                <label for="login">Логін</label>
                <input type="text" id="login" name="login">
            </div>
            <div class="form-group">
                <label for="username">Ім'я</label>
                <input type="text" id="username" name="username">
            </div>
            <div class="form-group">
                <label for="email">Пошта</label>
                <input type="email" id="email" name="email">
            </div>
            <div class="form-group">
                <label for="password">Пароль</label>
                <input type="password" id="password" name="password">
            </div>
            <button type="submit" class="register-button">Зареєструватись</button>
        </form>
    </div>
</section>
    <?php include 'footer.php'; ?>
</body>
</html>