
public interface ICar
{
    string Name { get; set; } // название
    string Color { get; set; }// цвет потом нужно реализовать на перечислениях enum
    int Speed { get; set; } // максимальная скорость

    void Show();
}

