# Технічне завдання
#### **Магазин книг:**
#### **Лабораторна робота 1 (LW1)**
 ##### - Вибір способу оплати (патерн Фабричний метод)
> Оплату можна здійснити:
>> - Банківським переказом
>> - Кредитною карткою
>> - PayPal
 ##### - Вибір способу доставки (патерн Абстрактна фабрика)
> ##### Нова пошта:
>> * Кур'єрська
>> * Відділення
>> * Поштомат
> ##### Укрпошта:
>> * Кур'єрська
>> * Відділення
#### **Лабораторна робота 2 (LW2)**
 - Реалізація покупки (патерн Прототип)
> Створення обєкта для покупки де буде визначино кількість замовлених книг клієнтів
 - Реалізація створення клієнта (патерн Будівельник)
> Можливість введення даних для індентифікації користувача
#### **Лабораторна робота 3 (LW3)**
 - Реалізація вибору способу оплати (патерн Стратегія)
> - Кредитною карткою
> - Готівкою
 - Реалізація стеження за наявністю товару (патерн Спостерігач)
> Можливість користувачу надсилати повідомлення про наявність певного товару за яким він стежить
 - Реалізація додавання, віднімання кількості товарів та видалення товарів з кошика (патерн Команда)
> - При віднімання кількість даного товару в кошику зменшується на 1
> - При додаванні кількість даного товару в кошику збільшується на 1
> - При видаленні товар зникає з кошику
#### **Лабораторна робота 4 (LW4)**
 - Обробка замовлення (Макрокоманди)
> Після оплати замовлення клієнтом адміністратор може виконати команди, такі як перевірка оплати, підтвердження замовлення, відправлення замовлення до клієнта
> (для виконання декількох команд використовується MacroCommands). 
> Якщо сталася якась помилка, в MacroCommands передбачено метод Undo(), що скасовує всі команди. 
 - Програма лояльності (Шаблонний метод)
> Реалізувати для покупців програму Лояльності для отримання спеціальних бонусів. Є два види програми:
> - Буденна версія:
>> - Нарахування бонусів (при кожній покупці нараховується 100 бонусів);
> - Преміум версія:
>> - Нарахування бонусів (при кожній покупці користувачеві нараховується 100 бонусів);
>> - Нарахування знижки за товар (при покупці товару(ів) більше 1000 грн. покупець отримує знижку на наступну покупку);
>> - Отримання подарункового товару (при покупці кількості одного товару більше п'яти одиниць за раз, покупець отримує подарунковий товар);
#### **Лабораторна робота 5 (LW5)**
-	Реалізувати список товарів (Ітератор)
>Розробити механізм, що дозволяє перебирати список товарів в інтернет-магазині та здійснювати з ними необхідні дії.
>> - Реалізувати можливість додавання товарів в список магазину.
>> - Забезпечити можливість виводу списку товарів на екран користувача.
>> - Отримання інформації про кількість товарів в магазині.
-	Встановлення стану замовлення(Стан)
Забезпечити можливість користувачу переглядати стан замовлення;
>Користувач може:
> - Переглянути стан замовлення
> - Оплатити замовлення
> - Трекінг посилки
>В замовлення може бути кілька станів:
> - Нове
>> Користувач обрав:
>> - Переглянути стан: відображається стан "Нове"
>> - Оплатити замовлення: відображається "Ви оплатили замовлення" стан переходить до оплаченого і відображається "Оплачено"
>> - Трекінг посилки: Не оплачене
> - Оплачене
>> - Переглянути стан: відображається стан "Оплачено"
>> - Оплатити замовлення: відображається "Оплачено"
>> - Трекінг посилки: "Готується до відправлення"
> - Відправлене
>> - Переглянути стан: відображається стан "Відправлено"
>> - Оплатити замовлення: відображається "Оплачено"
>> - Трекінг посилки: відображається стан "Відправлено"
- Створити систему обробки запитів(Ланцюжок обов'язків)
> Для інтернет-магазину реалізувати можливість обробляти запити на оплату, оформлення замовлення та доставку.
> - Система повинна мати три обробники запитів: PaymentHandler, OrderHandler та ShippingHandler.
> - Кожен обробник повинен мати можливість обробити запит, якщо він відповідає певним критеріям.
> - Якщо запит не може бути оброблений поточним обробником, він повинен передаватися наступному обробнику у ланцюгу.
> - Клас запиту повинен мати тип запиту (RequestType), який може бути Payment, Order або Shipping.
> - Клас клієнта (Client) повинен мати можливість відправляти запити до системи обробки.
> - Після відправки запиту до системи обробки, система повинна здатна визначити потрібний обробник та обробити запит.
#### **Лабораторна робота 6 (LW6)**
 -	Виконання пошуку книг за заданими умовами та логічними операторами в текстовому запиті (Інтерпретатор (Interpreter))
> Програма може інтерпретувати запити, що включають різні умови (автор, назва, жанр, рік публікації) та логічні оператори (AND, OR) (пошуку книг у бібліотеці за запитом, який складається з ключових слів "title", "author", "genre", "AND" або "OR")
> - Відповідно до запиту, програма повинна відбирати книги зі списку книг та повертати результат.
> - Для реалізації пошуку використовується патерн Інтерпретатор.
> - Клас Query відповідає за розбір запиту та отримання ключових слів.
> - Клас Context слугує клієнтом для виразів, що можна інтерпретувати для знаходження книг, які задовольняють певні умови.
> - Абстрактний клас AbstractExpression визначає спільний інтерфейс для всіх виразів та метод Interpret(), який застосовує вираз до списку книг.
> - Класи TitleExpression, AuthorExpression, GenreExpression та YearExpression наслідуються від AbstractExpression та реалізовують метод Interpret() для фільтрування списку книг за відповідною умовою.
> - Класи AndExpression та OrExpression наслідуються від AbstractExpression та реалізовують метод Interpret(), який застосовує два вирази до списку книг з операціями "AND" та "OR" відповідно
> - Клас Book містить дані про книгу - назву, автора, жанр та рік виходу. Клас Query приймає запит та повертає список ключових слів. Клас Context приймає список книг та запит, створює потрібні вирази та викликає
-	Використати патерн Mediator, який дозволить додавати книги до кошика та робити замовлення з можливістю оплати за допомогою кредитної картки або PayPal, забезпечуючи зв'язок між класами без прямого залежності між ними (Посередник (Mediator)).
> - Забезпечити можливість додавати книги до кошика та робити замовлення з можливістю оплати за допомогою кредитної картки або PayPal. Крім того, необхідно забезпечити зв'язок між класами без прямого залежності між ними, що дозволить зменшити взаємодію між класами та спростити код.
> - В даному коді клас Mediator містить список платіжних методів (об'єктів, які реалізують інтерфейс IPayment), і може приймати нові платіжні методи за допомогою методу AddPayment(). Клас Mediator має метод MakePayment(), який приймає об'єкт замовлення (Order) і викликає метод ProcessPayment() платіжного методу, який може обробити платіж для заданого платіжного методу.
> - Клас Cart використовує клас Mediator для обробки платежу за допомогою методу PlaceOrder(). При створенні об'єкта замовлення (Order), він передає список продуктів та метод оплати, який повинен бути використаний. Замовлення передається класу Mediator за допомогою методу MakePayment(), який виконує пошук платіжного методу, який може обробити заданий метод оплати.
>> Основні функції програми:
>> - Додавання продуктів до кошика
>> - Оформлення замовлення з можливістю оплати за допомогою кредитної картки або PayPal.
#### **Лабораторна робота 7 (LW7)**
-	Реалізувати відновлення початкової ціни товару після закінчення акції(Зберігач (Memento))
Це досягається за допомогою використання патерну Memento, який зберігає стан товару перед акцією та дозволяє повернути його до початкового стану після акції.
>Для цього слід:
> 1. Потрібно створити клас "Product" для представлення товару з обов'язковими параметрами:
> - Name: рядок, що містить назву товару.
> - Price: децимальне число, що відображає поточну ціну товару.
> 2. Реалізувати у класі "Product" методи для збереження та відновлення стану:
> - CreateMemento(): Метод, що створює об'єкт Memento, який зберігає поточну ціну товару.
> - RestoreMemento(memento): Метод, який відновлює стан товару з об'єкта Memento.
> 3. Створити клас "Memento", що представляє об'єкт Memento з такими властивостями:
> - Price: число, що зберігає ціну товару.
> 4. Реалізувати клас "Caretaker", який буде відповідати за зберігання та відновлення стану товару:
> - Зберігання стану: Метод "Backup(product)" приймає об'єкт "Product" та створює об'єкт "Memento", що зберігає поточну ціну товару.
> - Відновлення стану: Метод "Restore(product)" приймає об'єкт "Product" та застосовує збережений об'єкт "Memento", щоб відновити початкову ціну товару.
> 5. У реалізації інтернет-магазину:
> - Після створення об'єкту товару та встановлення початкової ціни, створіть об'єкт "Caretaker".
> - Перед початком акції знижки на товар, викличте метод "Backup(product)" на об'єкті "Caretaker", щоб зберегти початкову ціну.
> - Змініть ціну товару під час акції.
> - Після закінчення акції або за необхідності відновлення початкової слід викликати метод "Restore(product)" на об'єкті "Caretaker", щоб відновити початкову ціну товару.
> - Після виклику методу "Restore(product)" ви можете використовувати об'єкт товару з відновленою початковою ціною.

-	Реалізувати генерацію звіту про продажі в інтернет-магазині(Відвідувач (Visitor))
>	1. Необхідно, щоб класи для представлення замовлення та товару містили наступні поля:
>> Клас "Order" з полями:
> - Products - список товарів у замовленні.
>> Клас "Product" з полями:
> - Name - назва товару,
> - Price - ціна товару,
> - Quantity - кількість одиниць товару.
> 2. Створити інтерфейс "IVisitor" з методом "Visit", що приймає об'єкт класу "Order". Цей інтерфейс буде використовуватися для реалізації відвідувачів, які будуть обробляти замовлення.
> 3. Створити клас "SalesReportVisitor", який реалізує інтерфейс "IVisitor". У цьому класі будуть зберігатися дані про продажі:
> - Приватне поле "totalSales" - загальна сума продажів,
> - Приватне поле "popularProducts" - словник, що містить назви популярних товарів та кількість проданих одиниць кожного товару,
> - Приватне поле "totalUnitsSold" - загальна кількість проданих одиниць.
> Клас "SalesReportVisitor" має такі методи:
> - Публічний конструктор, що ініціалізує поля класу.
> - Публічний метод "Visit", який приймає об'єкт класу "Order" та обчислює дані про продажі на основі товарів у замовленні:
>> - Для кожного товару в замовленні додати до "totalSales" його вартість, помножену на кількість одиниць.
>> - Додати кількість проданих одиниць товару до "popularProducts". Якщо товар вже є у словнику, додати кількість до існуючого значення, інакше додати новий запис.
>> - Додати кількість проданих одиниць товару до "totalUnitsSold".
> - Публічний метод "GenerateReport", який виводить звіт про продажі на консоль:
>> - Вивести заголовок "Sales Report".
>> - Вивести загальну суму продажів з поля "totalSales".
>> - Вивести список популярних товарів з їхньою кількістю проданих одиниць з поля "popularProducts".
>> - Вивести загальну кількість проданих одиниць з поля "totalUnitsSold".
#### **Лабораторна робота 8 (LW8)**
> -	Необхідно реалізувати систему реєстрації клієнтів за допомогою патерну Фасад (Фасад (Facade))
> Завдання патерну Фасад полягає в тому, щоб зробити процес реєстрації клієнта простим і зрозумілим. Замість того, щоб клієнтський код викликав кожну окрему частину процесу, він просто викликає метод RegisterCustomer класу CustomerRegistration, який самостійно виконує всі необхідні кроки: перевірку клієнта, збереження даних та надсилання реєстраційного листа.
Освновні складові:
>>    1. Клас Customer (Клієнт): Містить дані про клієнта, такі як його ім'я, електронна пошта, мобільний номер та адреса. Додаткові властивості можуть бути додані згідно з бізнес-вимогами.
>>    2. Клас Validator (Перевірка): Містить методи для перевірки коректності даних клієнта. Метод ValidateCustomer перевіряє дані клієнта і виводить їх на екран.
>>    3. Клас CustomerDataAccessLayer (Рівень доступу до даних клієнта): Містить методи для збереження даних клієнта в базі даних. Метод SaveCustomer зберігає дані клієнта в базі даних і повертає прапорець успішності операції.
>>    4. Клас Email (Електронна пошта): Містить методи для відправлення реєстраційного листа клієнту. Метод SendRegistrationEmail надсилає електронний лист з підтвердженням реєстрації.
>>    5. Клас CustomerRegistration (Реєстрація клієнта): Містить метод RegisterCustomer, який координує процес реєстрації клієнта. Він викликає методи інших класів відповідно до потрібних кроків реєстрації: перевірка клієнта, збереження даних клієнта і надсилання реєстраційного листа.
>>    6. Клас Program (Головна програма): Містить точку входу в програму. У методі Main створюється екземпляр класу Customer з відповідними даними клієнта. Потім створюється екземпляр класу CustomerRegistration і викликається метод RegisterCustomer для реєстрації клієнта.

> - Реалізувати завантаження зображень в інтернет-магазині за допомогою патерну Проксі (Замісник (Проксі))
У контексті інтернет-магазину, коли користувач переглядає сторінку товару, можуть бути виведені зображення, що демонструють товар. Завантаження цих зображень може вимагати часу та ресурсів.
>> - Основна мета використання патерну Замісник (Проксі) полягає в тому, щоб створити об'єкт-проксі, який може контролювати доступ до іншого об'єкта (у цьому випадку, ImageLoader). Проксі може виконувати різні функції, такі як аутентифікація, авторизація, кешування, оптимізація, обмеження доступу та інше.
>> - Якщо значення null, створиться екземпляр, а потім на екземплярі imageLoader можна викликати метод DisplayImage. З іншого боку, якщо екземпляр imageLoader не є нульовим, він не створить екземпляр, замість цього він використовуватиме наявний екземпляр imageLoader для виклику методу DisplayImage.
> Кроки реалізації:
>> 1. Необхідно створити інтерфейс IImageLoader, який визначатиме метод DisplayImage(), що відображатиме зображення.
>> 2. Створити клас ImageLoader, який реалізуватиме інтерфейс IImageLoader. Цей клас буде відповідати за завантаження та відображення зображень з сервера. У конструкторі ImageLoader передається URL зображення для завантаження.
>> 3. В класі ImageLoader реалізувати приватний метод LoadImageFromServer(), який буде виконувати завантаження зображення з сервера.
>> 4. Створити клас ImageLoaderProxy, який також реалізуватиме інтерфейс IImageLoader. Цей клас буде виступати як проксі і контролюватиме доступ до реального об'єкта ImageLoader. У конструкторі ImageLoaderProxy передається URL зображення для завантаження.
>> 5. В класі ImageLoaderProxy створити приватне поле imageUrl, яке зберігатиме URL зображення для завантаження.
>> 6. В класі ImageLoaderProxy реалізувати метод DisplayImage(), який буде перевіряти, чи існує екземпляр ImageLoader. Якщо такого екземпляра немає, то створити його і викликати метод DisplayImage() на цьому екземплярі. У протилежному випадку, просто викликати метод DisplayImage() на вже існуючому екземплярі.
>> 7. У Main методі або відповідному місці додатку створити екземпляр ImageLoaderProxy з вказаним URL зображення.
>> 8. Викликати метод DisplayImage() на створеному екземплярі ImageLoaderProxy для завантаження та відображення зображення.
> -	Реалізувати способу зв'язку клієнта з контактним центром (Міст (Bridge))
> В коді застосовано патерн "Міст" (Bridge) для розділення абстракції (клас "Customer") від реалізації (класи "EmailContactCenter" і "PhoneContactCenter") для забезпечення гнучкості і можливості зміни способу зв'язку з контактним центром.
> У патерні "Міст" є дві головні складові:
>> 1. Абстракція (Abstraction): Це представлено класом "Customer". Він має метод ContactCustomerSupport(), який використовує об'єкт типу ContactCenter для взаємодії з контактним центром. Клас "Customer" використовує цей об'єкт ContactCenter для виклику методів SendRequest() та ReceiveResponse(), які представляють загальні дії зв'язку з контактним центром. Абстракція дозволяє клієнту взаємодіяти з контактним центром без прив'язки до конкретного способу зв'язку.
>> 2. Реалізація (Implementation): Це представлено класами "EmailContactCenter" і "PhoneContactCenter". Вони розширюють клас "ContactCenter", який визначає загальний інтерфейс для всіх способів зв'язку з контактним центром. Кожен з цих класів надає власну реалізацію методів SendRequest() та ReceiveResponse(), а також додаткові специфічні методи, такі як SendEmail(), ReceiveEmail(), MakeCall() та ReceiveCall(). Реалізація може варіюватись між різними способами зв'язку, наприклад, електронною поштою чи телефонним дзвінком.

> Завдяки патерну "Міст" можна легко додавати нові класи для реалізації різних способів зв'язку з контактним центром, а також нові методи вже існуючих класів, не змінюючи структуру клієнтського коду. Клас "Customer" використовує об'єкт ContactCenter, щоб взаємодіяти з контактним центром без необхідності знати деталі реалізації конкретного способу зв'язку. Це забезпечує гнучкість, розширюваність і легкість підтримки системи, що використовує патерн "Міст".
