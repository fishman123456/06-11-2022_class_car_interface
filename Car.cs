
// Создать класс гараж и добавить в него несколько автомобилей
namespace Car_Garage
{

    class Car : IComparable
    {
        public string? _name { get; set; } // название
        public string? _color { get; set; }// цвет потом нужно реализовать на перечислениях enum
        public int? _max_speed { get; set; } // максимальная скорость

        public int CompareTo(object? obj)
        {
            return _name.CompareTo(obj as Car);
        }

        public override string ToString() // прегрузка string для передачи полей для вывода на консоль
        {
            return $"Марка {_name}  -  цвет {_color}  -  скорость {_max_speed} ";
        }
    }
}

