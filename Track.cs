
// Создать класс гараж и добавить в него несколько автомобилей

class Track :ICar
{
    public string? _name; // название
    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }
    public string? _color;// цвет потом нужно реализовать на перечислениях enum
    public string Color
    {
        get { return this.Color; }
        set { this.Color = value; }
    }
    public int? _max_speed; // максимальная скорость

    public int Speed
    {
        get { return this.Speed; }
        set { this.Speed = value; }
    }
    public Track(string? name, string? color, int? max_speed)
    {
        this._name = name;
        this._color = color;
        this._max_speed = max_speed;
    }


    public void Show()
    {
        Console.WriteLine($"Легковая машина {this._name} ");
        Console.WriteLine($"Цвет машины {this._color} ");
        Console.WriteLine($"Скорость машины {this._max_speed} ");
    }
}

