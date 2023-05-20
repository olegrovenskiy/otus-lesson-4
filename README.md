# otus-lesson-4


##  1. Создать базу данных PostgreSQL для одной из компаний на выбор: 
Авито, СберБанк, Otus или eBay. Написать скрипт создания 3 таблиц, 
которые должны иметь первичные ключи и быть соединены внешними ключами.


    CREATE DATABASE hwLesson4;



    CREATE TABLE customers
    (
        id SERIAL PRIMARY KEY,
        firstName CHARACTER VARYING(30),
        lastName CHARACTER VARYING(30),
        email CHARACTER VARYING(30),
        age INTEGER
    );

    CREATE TABLE items 
    (
      id serial primary key ,
      name CHARACTER VARYING(30),
      type CHARACTER VARYING(10),
      description CHARACTER VARYING(30),
      price money
    );

    CREATE TABLE orders
    (
      id serial primary key, 
      customerID int REFERENCES customers (id), 
      itemID int REFERENCES items (id), 
      quantity INTEGER not null
    );



##  2. Написать скрипт заполнения таблиц данными, минимум по пять строк в каждую.


    INSERT INTO customers VALUES (1, 'ivan', 'ivanov', 'ivan@mail.ru', 25)
    INSERT INTO customers VALUES (2, 'serg', 'sergeev', 'serg@mail.ru', 29)
    INSERT INTO customers VALUES (3, 'petr', 'petrov', 'petr@mail.ru', 33)
    INSERT INTO customers VALUES (4, 'anna', 'lipatova', 'anna@mail.ru', 22)
    INSERT INTO customers VALUES (5, 'olga', 'denisova', 'olga@mail.ru', 24)


    INSERT INTO items  (name, type, description, price)
    VALUES
    ('iPhone 6', 'mobile', 'smarthpone', 36000),
    ('Galaxy S8', 'mobile', 'smarthpone', 46000),
    ('Galaxy S8 Plus', 'mobile', 'smarthpone', 56000),
    ('Sony-5745', 'TV', 'SmartTV', 67000),
    ('Banana', 'food', 'Banana from Africa, kg', 220.5)


    INSERT INTO orders  (customerID, itemID, quantity)
    VALUES
    (1, 1, 1),
    (1, 4, 1),
    (2, 5, 3),
    (3, 3, 2),
    (5, 5, 1)


##  3. Создать консольную программу, которая выводит содержимое всех таблиц.

- установить 

Npgsql.EntityFrameworkCore.PostgreSQL
Microsoft.EntityFrameworkCore.Tools



    Scaffold-DbContext "Host=localhost;Port=5432;Database=hwlesson4;Username=postgres;Password=12345"


    PM> Scaffold-DbContext "Host=localhost;Port=5432;Database=hwLesson4;Username=postgres;Password=12345"
    cmdlet Scaffold-DbContext at command pipeline position 1
    Supply values for the following parameters:
    Provider: Npgsql.EntityFrameworkCore.PostgreSQL
    Build started...
    Build succeeded.

