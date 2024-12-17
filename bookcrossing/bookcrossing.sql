-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Час створення: Гру 17 2024 р., 17:12
-- Версія сервера: 10.4.32-MariaDB
-- Версія PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База даних: `bookcrossing`
--

-- --------------------------------------------------------

--
-- Структура таблиці `ads`
--

CREATE TABLE `ads` (
  `id` int(5) UNSIGNED NOT NULL,
  `id_user` int(5) UNSIGNED NOT NULL,
  `id_copies_of_books` int(5) UNSIGNED NOT NULL,
  `id_condition` int(5) UNSIGNED NOT NULL,
  `id_city` int(5) UNSIGNED NOT NULL,
  `id_contact` int(5) UNSIGNED NOT NULL,
  `date_act` date DEFAULT current_timestamp(),
  `date_deact` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `ads`
--

INSERT INTO `ads` (`id`, `id_user`, `id_copies_of_books`, `id_condition`, `id_city`, `id_contact`, `date_act`, `date_deact`) VALUES
(30, 1, 35, 2, 1, 34, '2024-11-13', '2024-11-26'),
(31, 1, 36, 3, 1, 35, '2024-11-13', '2024-11-19'),
(32, 2, 37, 2, 6, 36, '2024-11-13', NULL),
(33, 2, 38, 1, 6, 37, '2024-11-13', NULL),
(34, 4, 39, 3, 5, 38, '2024-11-16', '2024-11-17'),
(35, 4, 40, 2, 5, 39, '2024-11-16', NULL),
(36, 4, 41, 1, 7, 40, '2024-11-16', NULL),
(37, 4, 42, 2, 9, 41, '2024-11-16', NULL),
(38, 3, 43, 2, 11, 42, '2024-11-16', NULL),
(39, 3, 44, 2, 12, 43, '2024-11-16', NULL),
(40, 3, 45, 3, 4, 44, '2024-11-16', NULL),
(41, 3, 46, 3, 11, 45, '2024-11-16', NULL),
(42, 5, 47, 2, 2, 46, '2024-11-16', NULL),
(43, 1, 48, 2, 8, 47, '2024-11-17', NULL),
(44, 1, 49, 3, 10, 48, '2024-11-17', '2024-11-17'),
(45, 6, 50, 1, 13, 49, '2024-11-19', NULL);

-- --------------------------------------------------------

--
-- Структура таблиці `ages`
--

CREATE TABLE `ages` (
  `id` int(5) UNSIGNED NOT NULL,
  `name` int(5) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `ages`
--

INSERT INTO `ages` (`id`, `name`) VALUES
(1, 4),
(2, 6),
(3, 12),
(4, 14),
(5, 16),
(6, 18);

-- --------------------------------------------------------

--
-- Структура таблиці `bindings`
--

CREATE TABLE `bindings` (
  `id` int(5) UNSIGNED NOT NULL,
  `name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `bindings`
--

INSERT INTO `bindings` (`id`, `name`) VALUES
(1, 'Тверда'),
(2, 'М\'яка');

-- --------------------------------------------------------

--
-- Структура таблиці `books`
--

CREATE TABLE `books` (
  `id` int(5) UNSIGNED NOT NULL,
  `title` varchar(100) NOT NULL,
  `author` varchar(100) NOT NULL,
  `annotation` text NOT NULL,
  `id_genre` int(5) UNSIGNED NOT NULL,
  `id_type` int(5) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп даних таблиці `books`
--

INSERT INTO `books` (`id`, `title`, `author`, `annotation`, `id_genre`, `id_type`) VALUES
(45, 'Команда скелетів', 'Стівен Кінг', 'Що коли звичайне горище перетвориться на справжнє пекло, а буденна подорож автомобілем - закінчиться в геть неочікуваному пункті призначення? Чи може бути щось більш лячне, ніж місця описаних подій? Хіба що самі герої оповідань. Бабуся, яка прагнула понад усе обійняти свого онука… навіть після смерті, чи невинна іграшкова мавпочка, що таїть у собі суще зло, чи інші персонажі, які жахатимуть своїми намірами…', 1, 1),
(46, 'Різдво Еркюля Пуаро', 'Аґата Крісті', 'Симеон Лі, деспотичний багатій, наполягає, щоб четверо його синів разом з родинами приїхали додому на Святвечір. Різдво - лише привід, щоб зібрати всіх в одному будинку, адже голова родини має на меті зовсім не затишне святкування. Напруга в домі зростає, коли Симеон оголошує про наміри позбавити синів фінансової підтримки та змінити заповіт. Невдовзі господаря маєтку знаходять у його кабінеті з перерізаним горлом. Еркюль Пуаро, який випадково перебував у сусідньому селі, погоджується допомогти в розслідуванні. У будинку панує атмосфера взаємної підозри, а кожен член родини має власні мотиви для злочину.', 9, 4),
(47, 'Прокляття святих. Книга 1', 'К. Дреміс', 'Ая - елітна шпигунка і довірена особа королеви. У її житті є тільки обов’язок, дисципліна й... протистояння з Віллом. Вілл - королівський наглядач у Торговельній раді, мужній, благородний, недосяжний. Вони змушені працювати разом заради королівства і людей, яких присягалися захистити від темної магії. Та раптово Ая проявляє силу, про яку розповідали легенди. Якщо дівчина не зможе її підкорити, то стане загрозою для всього, що для неї цінне. Вілл зобов’язаний простягнути їй руку - та невідомо, захоче він допомогти чи зіштовхнути у прірву. Шпигунка і лицар - ким вони стануть, коли зустрінуться із силами, що руйнують їхній світ?', 3, 3),
(48, 'Шістка Атласа. Книга 1', 'Оліві Блейк', 'Кожне десятиліття лише шість найбільш унікально талановитих чарівників обираються, щоб отримати місце в Александрійському товаристві, провідному таємному товаристві у світі. На обраних чекає життя, повне влади та престижу, яке перевершує їхні найсміливіші мрії. Але якою ціною? У кожного з шести новобранців є свої причини прийняти запрошення Товариства. Навіть якщо це означає стати ближчими, ніж вони могли собі уявити, зі своїми найнебезпечнішими ворогами — або ризикувати непростимою зрадою з боку своїх найнадійніших союзників — вони боротимуться всіма способами за право долучитися до лав александрійців. Навіть якщо це означає, що вони не всі витримають рік.', 3, 4),
(49, 'Мистецтво війни', 'Сунь- дзи', 'Кожен у житті неминуче має «воювати»: звільняти собі місце під сонцем, долати власні страхи, сперечатися з начальством, боротися з конкурентами й суперниками. Найчастіше від того, чи здобудемо ми перемогу, залежить не тільки добробут, але й життя. Перед вами один з найвідоміших трактатів всіх часів про війну й тактику військових дій, який є путівником для багатьох відомих воєначальників і політиків. Поради стародавнього полководця не втратили своєї актуальності й сьогодні, тому що вчать нас приймати рішення й домагатися обраних цілей. Ця книга навчить вас перемагати незалежно від того, у чому саме ви хочете досягти успіху – у бізнесі, спорті або політиці!', 12, 1),
(50, 'Париж для самотніх та інші історії', 'Джоджо Мойєс', 'Романтична, несподівана, непримиренна історія «Париж для самотніх», як і десять інших оповідань, що увійшли до цієї книги, захоплює читачів легкістю і життєвістю, що знайома кожному серцю, яке колись кохало. Це блискуча колекція оповідань, сповнених романтики, шарму, авантюризму, гумору і надзвичайної чуттєвості.', 2, 1),
(51, 'Мансарда мрій. Ґем', 'Еріх Марія Ремарк', '«Мансарда мрій» - роман, у якому немає жодного слова про війну, зате книга наповнена віршами німецьких класиків та роздумами про кохання, при цьому стиль трохи піднесений і трохи віддає пафосом. Реальність головного героя Фріца, та його друзів складається із замріяних розмов, закоханостей, сентиментального і наївного ставлення до життя, яке сповнене надіями на прекрасне майбутнє. Та все змінюється тієї миті, коли Фріц помирає… Роман «Ґем» є одним з перших творів Ремарка, який не був опублікований прижиттєво внаслідок невдачі першого роману автора. Ґем - незалежна й волелюбна жінка. Вона подорожує континентами, де зустрічається із чоловіками, кожен з яких уособлює різні життєві філософії, і намагається віднайти себе.', 6, 1),
(52, 'Четверте крило. Емпіреї. Книга 1', 'Ребекка Яррос', 'Пориньте в жорстокий світ військового коледжу для вершників драконів! Тут народжується еліта! Або помирає... Двадцятирічна Вайолет планувала провести життя серед книжок. Однак наказ матері, уславленої захисниці королівства, змінює все. Дівчина змушена приєднатися до сотень кандидатів, які прагнуть стати гордістю Наварри - вершниками на драконах. У військовому коледжі не терплять слабаків - ні люди, ні дракони. А Вайолет не може похвалитися силою, тож вона помре. Її вб’ють або курсанти, що прагнуть позбутися конкурентки, або полум’я дракона. Якщо, звісно, першим до її горла не дістанеться той, хто має персональний рахунок до її матері, а платити доведеться Вайолет. І, щоб побачити наступний схід сонця, дівчині знадобляться весь її розум і вся удача.', 3, 4),
(53, 'Зроблено в Безодні, том 3', 'Акіхіто Цукуші', 'Бездонна Безодня таїть у собі прокляття, але людям не вдається встояти перед спокусою дослідити це урвище. Скільки починали свою мандрівку туди… і хто з них повертався? Для Ріко і її нового друга — робота Реґа спуск у надра триває. Нашим героям доводиться ризикувати життями, намагаючись дійти до матері Ріко, яка перебуває на нижніх рівнях та відправила на поверхню звістку з проханням. На щастя, тепер в них є союзник, який допомагає розвідувати територію. З кожним кроком Ріко і Реґ дізнаються більше про Безодню. Можливо, вони вже бачили більше, ніж хотілося б. Адже, що нижче, то темніше, і лютіші істоти чатують по закутках. Це вже четвертий рівень підземного світу, попереду ще стільки всього незвіданого. І вони це побачать, якщо зможуть уникнути смертельної загрози, яка зачаїлася в очікуванні…', 8, 4),
(54, 'Ґаннібал. Том 5', 'Н. Масаакі', 'Дайґо собі ніколи не пробачить, якщо схибить. Часу обмаль. Завтра — День підношень, а з ним і жертва. Людська жертва. Дитина, яка зникла кілька років тому. Дитина, яку з’їдять ці постійно усміхнені люди. Треба знайти сховок, де Гото утримують малечу. Це має бути якесь віддалене місце. Можливо, в лісі? Можливо, десь там, де заблукав Кано. Дайґо готовий ризикувати власним життям, якщо доведеться. Та, схоже, в нього тепер є союзники — поліцейські з міста теж зрозуміли, що в Куґе коїться щось лихе. Їм важко повірити у канібалізм, але смерть попереднього дільничного спонукає до дій.', 8, 4),
(55, 'Я - легенда', 'Річард Метісон', 'Він міг стати легендою для людей. Якби люди існували. Він був єдиний, на кого не подіяв страшний вірус, хто не перетворився на вампіра. Зі свого будинку, що нагадує неприступну фортецю, він виходить, тільки щоб убивати. Тих, через кого втратив кохану дружину й улюблену донечку – усе своє життя. Він пізно розуміє, що сонце вже давно сходить над іншим світом…', 5, 1),
(56, 'Усі ці світи ваші', 'Дж. Вілліс', 'Чи існують іншопланетяни? Майже напевно, так. Ба більше — населених світів цілком може бути багато, адже Всесвіт нескінченний, а в нескінченному Всесвіті абсолютно все, зокрема й життя, не лише можливе, але й неминуче.', 16, 1),
(57, 'Немезида', 'Аґата Крісті', 'Міс Марпл одержує листа від свого друга Джейсона Рейфаєла з його останньою волею. У ньому той просить узятися за розслідування таємничої справи. Однак не каже якої: немає навіть натяку не те, що й коли сталося! Невдовзі леді-детектив отримує першу підказку - поїздку, яку Джейсон організував для неї незадовго до смерті. Проте в цій подорожі починають траплятися дивні речі. Під час відвідин одного з визначних місць сталася жахлива трагедія: зі скелі зірвався камінь, унаслідок чого загинула екскурсантка. Що ж це було - нещасний випадок чи вбивство? Здається, хтось твердо вирішив завадити міс Марпл розкрити загадкову справу…', 9, 1),
(58, 'Панк 57', 'Пенелопа Дуглас', 'Ми були ідеальною парою. Поки не зустрілися... У п’ятому класі вчителі випадково поставили Мішу і Раєн у пару для листування. Їх розділяли десятки кілометрів, але об’єднували спільні думки і захоплення. Тільки одне з одним вони могли бути по-справжньому відвертими та щирими. Ці листи тримали їх на плаву в найтяжчі моменти дорослішання. Довгі сім років у їхньої дружби було лише три правила: не шукати одне одного в соцмережах, жодних телефонних дзвінків, жодних фотографій. Проте одного дня Міша вирішив порушити домовленість і побачити Раєн... Це була ненависть із першого погляду! Але Раєн навіть не здогадувалася, що перед нею Міша, її Міша. Дівчина не розуміє, чому більше не отримує листів від нього, чому він зник з її життя. Однак вона готова на все, аби повернути друга!', 2, 1),
(59, 'Мистецтво війни', 'Сунь- дзи', 'Кожен у житті неминуче має «воювати»: звільняти собі місце під сонцем, долати власні страхи, сперечатися з начальством, боротися з конкурентами й суперниками. Найчастіше від того, чи здобудемо ми перемогу, залежить не тільки добробут, але й життя. Перед вами один з найвідоміших трактатів всіх часів про війну й тактику військових дій, який є путівником для багатьох відомих воєначальників і політиків. Поради стародавнього полководця не втратили своєї актуальності й сьогодні, тому що вчать нас приймати рішення й домагатися обраних цілей. Ця книга навчить вас перемагати незалежно від того, у чому саме ви хочете досягти успіху – у бізнесі, спорті або політиці!', 4, 1),
(60, 'Кобзар. Вперше зі щоденником автора', 'Т. Шевченко', 'Видання укладене за сприяння Інституту літератури імені Т. Г. Шевченка.Тексти творів подані за оригіналами рукописів, що дозволило усунути неточності, допущені в інших виданнях.Збірка містить найвідоміші твори та щоденник письменника.', 6, 1);

-- --------------------------------------------------------

--
-- Структура таблиці `cities`
--

CREATE TABLE `cities` (
  `id` int(11) UNSIGNED NOT NULL,
  `name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `lat` decimal(9,6) DEFAULT NULL,
  `lng` decimal(9,6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `cities`
--

INSERT INTO `cities` (`id`, `name`, `lat`, `lng`) VALUES
(1, 'Хмельницький', 49.421600, 26.996500),
(2, 'Київ', 50.450100, 30.523400),
(3, 'Дніпро', 48.464700, 35.046200),
(4, 'Тернопіль', 49.553500, 25.594800),
(5, 'Львів', 49.839700, 24.029700),
(6, 'Одеса', 46.482500, 30.732600),
(7, 'Харків', 49.993500, 36.230400),
(8, 'Запоріжжя', 47.838800, 35.139600),
(9, 'Кривий Ріг', 47.910700, 33.394600),
(10, 'Чернігів', 51.505500, 31.289200),
(11, 'Миколаїв', 46.975000, 32.002600),
(12, 'Івано-Франківськ', 48.922000, 24.711100),
(13, 'Херсон', 46.635000, 32.616900);

-- --------------------------------------------------------

--
-- Структура таблиці `comments`
--

CREATE TABLE `comments` (
  `id` int(5) UNSIGNED NOT NULL,
  `id_ads` int(5) UNSIGNED NOT NULL,
  `id_user` int(5) UNSIGNED NOT NULL,
  `comment` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `date_act_com` date NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `comments`
--

INSERT INTO `comments` (`id`, `id_ads`, `id_user`, `comment`, `date_act_com`) VALUES
(6, 31, 1, 'Добрий день, дуже хочу цю книгу, написала вам у інстаграм)', '2024-11-14'),
(7, 42, 1, 'Круто!! Мені дуже сподобалась ця книга, рекомендую)', '2024-11-17'),
(8, 42, 1, 'Крута книга', '2024-11-19'),
(9, 42, 1, 'Вау', '2024-11-26'),
(10, 32, 1, 'Крута книга', '2024-11-26');

-- --------------------------------------------------------

--
-- Структура таблиці `conditions`
--

CREATE TABLE `conditions` (
  `id` int(5) UNSIGNED NOT NULL,
  `name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `conditions`
--

INSERT INTO `conditions` (`id`, `name`) VALUES
(1, 'Новий'),
(2, 'Задовільний'),
(3, 'Пошкоджений');

-- --------------------------------------------------------

--
-- Структура таблиці `contact_users`
--

CREATE TABLE `contact_users` (
  `id` int(5) UNSIGNED NOT NULL,
  `social_network` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `phone_number` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `contact_users`
--

INSERT INTO `contact_users` (`id`, `social_network`, `phone_number`) VALUES
(26, 'https://www.instagram.com/', '1111111111'),
(27, 'https://www.instagram.com/', '680251145'),
(28, 'https://www.instagram.com/', '2147483647'),
(29, 'https://www.instagram.com/', '2147483647'),
(30, 'https://www.instagram.com/', '2147483647'),
(31, 'https://www.instagram.com/', '1111111111'),
(32, 'https://www.instagram.com/', '682597411'),
(33, '', '680254107'),
(34, 'https://www.instagram.com/', '0'),
(35, '', '682557441'),
(36, 'https://www.instagram.com/', '675822415'),
(37, 'https://www.instagram.com/', '0'),
(38, 'https://www.instagram.com/', '0675224718'),
(39, 'https://www.instagram.com/', '0672558841'),
(40, '', '0970253414'),
(41, 'https://www.facebook.com/?locale=uk_UA', '0970253414'),
(42, 'https://www.instagram.com/', '0692582414'),
(43, 'https://www.instagram.com/', '0685247721'),
(44, 'https://www.instagram.com/', ''),
(45, 'https://www.instagram.com/', '0970252415'),
(46, 'https://www.instagram.com/', '0692582477'),
(47, 'https://www.instagram.com/', '0692544185'),
(48, 'https://www.instagram.com/', '0680352825'),
(49, 'https://www.instagram.com/', '0692582484');

-- --------------------------------------------------------

--
-- Структура таблиці `copies_of_books`
--

CREATE TABLE `copies_of_books` (
  `id` int(5) UNSIGNED NOT NULL,
  `id_book` int(5) UNSIGNED NOT NULL,
  `id_publish` int(5) UNSIGNED NOT NULL,
  `id_binding` int(5) UNSIGNED NOT NULL,
  `id_age_category` int(5) UNSIGNED NOT NULL,
  `pages` int(10) UNSIGNED NOT NULL,
  `cover` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `copies_of_books`
--

INSERT INTO `copies_of_books` (`id`, `id_book`, `id_publish`, `id_binding`, `id_age_category`, `pages`, `cover`) VALUES
(35, 45, 1, 1, 5, 800, 'uploads/covers/cover_6734fec03a9d6.jpg'),
(36, 46, 1, 1, 5, 288, 'uploads/covers/cover_67350b501da4a.jpg'),
(37, 47, 1, 1, 5, 512, 'uploads/covers/cover_673516ccd6514.jpg'),
(38, 48, 1, 1, 6, 528, 'uploads/covers/cover_673517237350b.jpg'),
(39, 49, 1, 1, 6, 128, 'uploads/covers/cover_67390a644b5a7.jpg'),
(40, 50, 1, 1, 4, 304, 'uploads/covers/cover_67391df6ac703.jpg'),
(41, 51, 1, 1, 5, 416, 'uploads/covers/cover_67391ed1e9869.jpg'),
(42, 52, 1, 2, 6, 640, 'uploads/covers/cover_67391f685c798.jpg'),
(43, 53, 8, 2, 6, 160, 'uploads/covers/cover_67392007015e7.jpg'),
(44, 54, 8, 2, 6, 192, 'uploads/covers/cover_67392068a65a3.jpg'),
(45, 55, 1, 1, 5, 192, 'uploads/covers/cover_673920d899fda.jpg'),
(46, 56, 11, 1, 4, 304, 'uploads/covers/cover_6739216c6c7ef.jpg'),
(47, 57, 1, 1, 4, 384, 'uploads/covers/cover_673922a4224bd.jpg'),
(48, 58, 1, 1, 6, 448, 'uploads/covers/cover_6739fa2976ef8.jpg'),
(49, 59, 1, 1, 4, 128, 'uploads/covers/cover_6739fc7944296.jpg'),
(50, 60, 1, 1, 2, 960, 'uploads/covers/cover_673c6ed6e70cb.jpg');

-- --------------------------------------------------------

--
-- Структура таблиці `genres`
--

CREATE TABLE `genres` (
  `id` int(5) UNSIGNED NOT NULL,
  `name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `genres`
--

INSERT INTO `genres` (`id`, `name`) VALUES
(1, 'Трилер'),
(2, 'Роман'),
(3, 'Фентезі'),
(4, 'Історична проза'),
(5, 'Фантастика'),
(6, 'Класична література'),
(7, 'Комікс'),
(8, 'Манґа'),
(9, 'Детектив'),
(10, 'Саморозвиток'),
(11, 'Бізнес-література'),
(12, 'Історична література'),
(13, 'Біографія'),
(14, 'Психологія'),
(15, 'Дозвілля та хобі'),
(16, 'Наукпоп'),
(17, 'Езотерика'),
(18, 'Казки'),
(19, 'Навчальна та шкільна'),
(20, 'Розвиваюча');

-- --------------------------------------------------------

--
-- Структура таблиці `publishers`
--

CREATE TABLE `publishers` (
  `id` int(5) UNSIGNED NOT NULL,
  `name` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `publishers`
--

INSERT INTO `publishers` (`id`, `name`) VALUES
(1, 'КСД'),
(2, 'Віват'),
(3, 'Букшеф'),
(4, 'Віхола'),
(5, 'READBERRY'),
(6, 'Ранок'),
(7, 'Malopus'),
(8, 'Наша Ідея'),
(9, 'Vovkulaka'),
(10, 'Видавництво Старого Лева'),
(11, 'Бородатий Тамарин');

-- --------------------------------------------------------

--
-- Структура таблиці `save_ads`
--

CREATE TABLE `save_ads` (
  `id` int(5) UNSIGNED NOT NULL,
  `id_user` int(5) UNSIGNED NOT NULL,
  `id_ads` int(5) UNSIGNED NOT NULL,
  `date_added` date NOT NULL DEFAULT current_timestamp(),
  `date_remove` date DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `save_ads`
--

INSERT INTO `save_ads` (`id`, `id_user`, `id_ads`, `date_added`, `date_remove`) VALUES
(5, 2, 30, '2024-11-13', '2024-11-13'),
(6, 2, 31, '2024-11-13', NULL),
(7, 2, 30, '2024-11-13', NULL),
(8, 3, 33, '2024-11-13', NULL),
(9, 1, 32, '2024-11-14', '2024-11-14'),
(10, 1, 33, '2024-11-17', '2024-12-01'),
(11, 1, 35, '2024-11-17', '2024-11-17'),
(12, 1, 42, '2024-11-17', '2024-11-17'),
(13, 1, 32, '2024-11-17', NULL),
(14, 1, 37, '2024-11-17', '2024-11-17'),
(15, 1, 37, '2024-11-17', '2024-11-19'),
(16, 1, 42, '2024-11-17', '2024-11-17'),
(17, 5, 36, '2024-11-17', NULL),
(18, 1, 42, '2024-11-18', '2024-11-18'),
(19, 6, 45, '2024-11-19', NULL),
(20, 1, 36, '2024-11-19', NULL),
(21, 1, 40, '2024-11-19', NULL),
(22, 1, 42, '2024-11-26', '2024-11-26'),
(23, 1, 42, '2024-11-26', '2024-11-26'),
(24, 1, 42, '2024-12-01', NULL);

-- --------------------------------------------------------

--
-- Структура таблиці `types`
--

CREATE TABLE `types` (
  `id` int(5) UNSIGNED NOT NULL,
  `name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `types`
--

INSERT INTO `types` (`id`, `name`) VALUES
(1, 'Одиночна'),
(2, 'Дуологія'),
(3, 'Трилогія'),
(4, 'Серія');

-- --------------------------------------------------------

--
-- Структура таблиці `users`
--

CREATE TABLE `users` (
  `id` int(5) UNSIGNED NOT NULL,
  `login` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `email` varchar(70) NOT NULL,
  `password` varchar(130) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп даних таблиці `users`
--

INSERT INTO `users` (`id`, `login`, `username`, `email`, `password`) VALUES
(1, 'pi4pai', 'Anastasia', 'studynzag70@gmail.com', '321321321'),
(2, 'Олег_25', 'Олег', 'olg25@gmail.com', '25252525'),
(3, 'Olen_a', 'Olena', 'olena85@gmail.com', '222222'),
(4, 'kkattya', 'Катерина', 'katyaa17@gmail.com', '7785d44d'),
(5, 'Emily01', 'Емілія', 'emm@gmail.com', '111111'),
(6, 'masha_botik_2005', 'Марія', 'mashabotik2005@gmail.com', '20052005');

--
-- Індекси збережених таблиць
--

--
-- Індекси таблиці `ads`
--
ALTER TABLE `ads`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_user` (`id_user`),
  ADD KEY `id_copies_of_books` (`id_copies_of_books`),
  ADD KEY `id_city` (`id_city`),
  ADD KEY `id_contact` (`id_contact`),
  ADD KEY `id_condition` (`id_condition`);

--
-- Індекси таблиці `ages`
--
ALTER TABLE `ages`
  ADD PRIMARY KEY (`id`);

--
-- Індекси таблиці `bindings`
--
ALTER TABLE `bindings`
  ADD PRIMARY KEY (`id`);

--
-- Індекси таблиці `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_genre` (`id_genre`),
  ADD KEY `id_type` (`id_type`);

--
-- Індекси таблиці `cities`
--
ALTER TABLE `cities`
  ADD PRIMARY KEY (`id`);

--
-- Індекси таблиці `comments`
--
ALTER TABLE `comments`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_ads` (`id_ads`),
  ADD KEY `id_user` (`id_user`);

--
-- Індекси таблиці `conditions`
--
ALTER TABLE `conditions`
  ADD PRIMARY KEY (`id`);

--
-- Індекси таблиці `contact_users`
--
ALTER TABLE `contact_users`
  ADD PRIMARY KEY (`id`);

--
-- Індекси таблиці `copies_of_books`
--
ALTER TABLE `copies_of_books`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_book` (`id_book`),
  ADD KEY `id_publish` (`id_publish`),
  ADD KEY `id_age_category` (`id_age_category`),
  ADD KEY `id_binding` (`id_binding`);

--
-- Індекси таблиці `genres`
--
ALTER TABLE `genres`
  ADD PRIMARY KEY (`id`);

--
-- Індекси таблиці `publishers`
--
ALTER TABLE `publishers`
  ADD PRIMARY KEY (`id`);

--
-- Індекси таблиці `save_ads`
--
ALTER TABLE `save_ads`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_ads` (`id_ads`),
  ADD KEY `id_user` (`id_user`);

--
-- Індекси таблиці `types`
--
ALTER TABLE `types`
  ADD PRIMARY KEY (`id`);

--
-- Індекси таблиці `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для збережених таблиць
--

--
-- AUTO_INCREMENT для таблиці `ads`
--
ALTER TABLE `ads`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT для таблиці `ages`
--
ALTER TABLE `ages`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблиці `bindings`
--
ALTER TABLE `bindings`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблиці `books`
--
ALTER TABLE `books`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;

--
-- AUTO_INCREMENT для таблиці `cities`
--
ALTER TABLE `cities`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT для таблиці `comments`
--
ALTER TABLE `comments`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT для таблиці `conditions`
--
ALTER TABLE `conditions`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблиці `contact_users`
--
ALTER TABLE `contact_users`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT для таблиці `copies_of_books`
--
ALTER TABLE `copies_of_books`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT для таблиці `genres`
--
ALTER TABLE `genres`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT для таблиці `publishers`
--
ALTER TABLE `publishers`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT для таблиці `save_ads`
--
ALTER TABLE `save_ads`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT для таблиці `types`
--
ALTER TABLE `types`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблиці `users`
--
ALTER TABLE `users`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Обмеження зовнішнього ключа збережених таблиць
--

--
-- Обмеження зовнішнього ключа таблиці `ads`
--
ALTER TABLE `ads`
  ADD CONSTRAINT `ads_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `ads_ibfk_2` FOREIGN KEY (`id_copies_of_books`) REFERENCES `copies_of_books` (`id`),
  ADD CONSTRAINT `ads_ibfk_3` FOREIGN KEY (`id_city`) REFERENCES `cities` (`id`),
  ADD CONSTRAINT `ads_ibfk_4` FOREIGN KEY (`id_contact`) REFERENCES `contact_users` (`id`),
  ADD CONSTRAINT `ads_ibfk_5` FOREIGN KEY (`id_condition`) REFERENCES `conditions` (`id`);

--
-- Обмеження зовнішнього ключа таблиці `books`
--
ALTER TABLE `books`
  ADD CONSTRAINT `books_ibfk_1` FOREIGN KEY (`id_genre`) REFERENCES `genres` (`id`),
  ADD CONSTRAINT `books_ibfk_2` FOREIGN KEY (`id_type`) REFERENCES `types` (`id`);

--
-- Обмеження зовнішнього ключа таблиці `comments`
--
ALTER TABLE `comments`
  ADD CONSTRAINT `comments_ibfk_1` FOREIGN KEY (`id_ads`) REFERENCES `ads` (`id`),
  ADD CONSTRAINT `comments_ibfk_2` FOREIGN KEY (`id_user`) REFERENCES `users` (`id`);

--
-- Обмеження зовнішнього ключа таблиці `copies_of_books`
--
ALTER TABLE `copies_of_books`
  ADD CONSTRAINT `copies_of_books_ibfk_1` FOREIGN KEY (`id_book`) REFERENCES `books` (`id`),
  ADD CONSTRAINT `copies_of_books_ibfk_3` FOREIGN KEY (`id_publish`) REFERENCES `publishers` (`id`),
  ADD CONSTRAINT `copies_of_books_ibfk_5` FOREIGN KEY (`id_age_category`) REFERENCES `ages` (`id`),
  ADD CONSTRAINT `copies_of_books_ibfk_6` FOREIGN KEY (`id_binding`) REFERENCES `bindings` (`id`);

--
-- Обмеження зовнішнього ключа таблиці `save_ads`
--
ALTER TABLE `save_ads`
  ADD CONSTRAINT `save_ads_ibfk_1` FOREIGN KEY (`id_ads`) REFERENCES `ads` (`id`),
  ADD CONSTRAINT `save_ads_ibfk_2` FOREIGN KEY (`id_user`) REFERENCES `users` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
