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
-	Реалізувати (Інтерпретатор (Interpreter))
-	Реалізувати (Посередник (Mediator))
#### **Лабораторна робота 7 (LW7)**
-	Реалізувати (Зберігач (Memento))
-	Реалізувати (Відвідувач (Visitor))
#### **Лабораторна робота 8 (LW8)**
-	Реалізувати (Фасад (Facade))
-	Реалізувати (Замісник (Проксі))
-	Реалізувати (Міст (Bridge))
