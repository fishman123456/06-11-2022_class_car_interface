﻿
// Создать класс гараж и добавить в него несколько автомобилей
namespace Car_Garage
{
    class Garage 
    {

            Car[] cars =
        {
            new Car
            {
                _name = "audi", // название
                _color = "elow",// цвет потом нужно реализовать на перечислениях enum
                _max_speed = 220 // максимальная скорость

            },
            new Car
            {
                _name = "reno", // название
                _color = "white",// цвет потом нужно реализовать на перечислениях enum
                _max_speed = 180 // максимальная скорость

            },
            new Car
            {
                _name = "Gaz", // название
                _color = "brown",// цвет потом нужно реализовать на перечислениях enum
                _max_speed = 160 // максимальная скорость

            },
            new Car
            {
                _name = "X-Trail", // название
                _color = "silver",// цвет потом нужно реализовать на перечислениях enum
                _max_speed = 165 // максимальная скорость

            }
        };
    }
}
