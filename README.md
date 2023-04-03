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
-	(Ітератор)
-	(Стан)  
-	(Ланцюжок обов'язків)
