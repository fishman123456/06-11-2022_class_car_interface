// See https://aka.ms/new-console-template for more information
// Создать класс автомобиль с полями
// Название, Цвет, Максимальная скорость
// Создать класс гараж и добавить в него несколько автомобилей
// Далее используя стандартные интерфейсы,
// реализовать сортировку машин в гараже,
// по названию по цвету и по скорости.
// вывести состояние гаража после каждой сортировки
ICar[] arr =
{
    new Car ("fgsfg","sdfsdf",75),
    new Car ("fghsdfghsdfg","ghkk",99),
    new Track ("dfg","sdf",555)
};
foreach (ICar item in arr)
{
    item.Show ();
    Console.WriteLine();
}