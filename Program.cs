﻿// See https://aka.ms/new-console-template for more information
// Создать класс автомобиль с полями
// Название, Цвет, Максимальная скорость
// Создать класс гараж и добавить в него несколько автомобилей
// Далее используя стандартные интерфейсы,
// реализовать сортировку машин в гараже,
// по названию по цвету и по скорости.
// вывести состояние гаража после каждой сортировки
using Car_Garage;

Console.WriteLine("приложение автомобиль");

Garage garage = new Garage();
foreach (Car cars in garage)
{
    Console.WriteLine(cars);
}