﻿using static System.Console;

namespace Lab_7
{
    class Ship
    {
        //Создаём поля класса
        private string Name{get; set;} = "Noname";
        private int Displacement{get; set;} = 6000;
        private string Type{get; set;} = "Cruiser";


        //Создаём конструкторы
        public Ship()
        {
            Name = "Pobeda";
            Displacement = 1500;
            Type = "Yacht";
        }
        public Ship(string name, int displasement, string type)
        {
            Name = name;
            Displacement = displasement;
            Type = type;
        }


        //Создаём методы класса
        public void WhatchData()
        {
            WriteLine($"Наименование - {Name}\nВодоизмещение - {Displacement}\nТип - {Type}");
        }
        public void ChangeData(string name, int displasement, string type)
        {
            Name = name;
            Displacement = displasement;
            Type = type;
        }
        public void SaveData()
        {
            FileInfo f = new(@"C:\Users\User\Desktop\vuzc-\vuz\for_save_data_lab_7.txt");
            StreamWriter writer = f.AppendText();
            writer.WriteLine($"Наименование - {Name}\nВодоизмещение - {Displacement}\nТип - {Type}");
            writer.Close();
        }


        //Перегуржаем логические операции
        public static Ship operator +(Ship obj1, Ship obj2)
        {
            Ship ship = new(obj1.Name, obj1.Displacement + obj2.Displacement, obj1.Type);
            return ship;
        }
        public static Ship operator <(Ship obj1, Ship obj2)
        {
            if (obj1.Displacement < obj2.Displacement) return obj1;
            else return obj2;
        }
        public static Ship operator >(Ship obj1, Ship obj2)
        {
            if (obj1.Displacement > obj2.Displacement) return obj1;
            else return obj2;
        }
    }
    class Program
    {
        static void Main()
        {
            //Создём экземпляры класса
            Ship ship1 = new();
            Ship ship2 = new("Avrora", 7130, "Cruiser");
            //Тестим методы класса
            ship1.WhatchData();
            ship2.WhatchData();
            ship1.ChangeData("beda", 1500, "Yacht");
            ship1.SaveData();
            //Тестим перегрузку операции сложения
            Ship ship3 = ship1 + ship2;
            ship3.WhatchData();
            //Тестим перегрузку операции меньше
            Ship ship4 = ship1 < ship2;
            ship4.WhatchData();
        }
    }
}
//Вывод:
// Наименование - Pobeda
// Водоизмещение - 1500
// Тип - Yacht
// Наименование - Avrora
// Водоизмещение - 7130
// Тип - Cruiser
// Наименование - beda
// Водоизмещение - 8630
// Тип - Yacht
// Наименование - beda
// Водоизмещение - 1500
// Тип - Yacht

//Запись в файл:
// Наименование - beda
// Водоизмещение - 1500
// Тип - Yacht
