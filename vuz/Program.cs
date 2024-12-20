﻿using static System.Console;


namespace Lab_11
{
    abstract class Sudno
    {
        private string name;

        public string Name
        {
            get{return name;}
            set{if (value != "") name = value;}
        }

        public Sudno()
        {
            name = "Pobeda";
        }

        public abstract void Oops();
    }

    class Korabl : Sudno
    {
        private int countmast;
        public int Countmast
        {
            get{return countmast;}
            set{if (value >= 1) countmast = value;}
        }
        
        public Korabl() {countmast = 2;}
        public Korabl(int cm, string nm)
        {
            countmast = cm;
            Name = nm;
        }

        public override void Oops()
        {
            Name = Name[2..];
            char[] ch = Name.ToCharArray();
            ch[0] = char.ToUpper(ch[0]);
            Name = new string(ch);
        }
    }

    class Parahod : Sudno
    {
        private int rashod;
        public int Rashod
        {
            get {return rashod;}
            set {if (value >= 0) rashod = value;}
        }

        public Parahod()
        {
            rashod = 825;
            Name = "Titanic";
        }

        public Parahod(int rd, string nm)
        {
            rashod = rd;
            Name = nm;
        }

        public override void Oops() {WriteLine($"Ой, параход ''{Name}'' тонет (.");}
    }

    class Kater : Sudno
    {
        private int speed;
        public int Speed
        {
            get{return speed;}
            set{if (value >= 0) speed = value;}
        }

        public Kater()
        {
            speed = 50;
            Name = "Волжанка 46 Fish";
        }

        public Kater(int sd, string nm)
        {
            speed = sd;
            Name = nm;
        }

        public override void Oops()
        {
            speed = 5;
            WriteLine($"Мотор заглох, течение уносит со скорстью {speed}");
        }
    }

    class Port
    {
        private List<Sudno> sudna = [];

        //Реализация методов
        public void AddSudno(Sudno s) {sudna.Add(s);}
        
        public void ChangeName(int i)
        {
            WriteLine("Введите новое имя судна");
            sudna[i].Name = ReadLine();
        }

        public void RemoveSudno(int i) {sudna.Remove(sudna[i]);}
        
        public void OutputInfo()
        {
            int i = 0;
            foreach(Sudno s in sudna)
            {
                ++i;
                if(s.GetType() == typeof(Korabl)) {WriteLine($"№{i} - корабль '{s.Name}'");}
                if(s.GetType() == typeof(Parahod)) {WriteLine($"№{i} - параход '{s.Name}'");}
                if(s.GetType() == typeof(Kater)) {WriteLine($"№{i} - катер '{s.Name}'");}
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Port port = new();
            bool flag = false;
            do
            {
                WriteLine("Выберите действие\n1 - Добавить в коллекцию судно\n2 - удалить судно из коллекции\n3 - вывести сведения по имеющимся в коллекции объектам\n4 - внести изменения в характеристики объекта коллекции\n5 - выход из программы");
                try
                {
                    int c = Convert.ToInt32(ReadLine());
                    switch(c)
                    {
                        case 1:
                        {
                            bool f = false;
                            do
                            {
                                WriteLine("Создaйте один из видов суден:\n1 - корабль\n2 - параход\n3 - катер\n4 - выйти");
                                try
                                {
                                    int k = Convert.ToInt32(ReadLine());
                                    switch(k)
                                    {
                                        case 1:
                                        {
                                            Korabl kor = new();
                                            port.AddSudno(kor);
                                        }; break;
                                        case 2:
                                        {
                                            Parahod par = new();
                                            port.AddSudno(par);
                                        }; break;
                                        case 3: 
                                        {
                                            Kater kat = new();
                                            port.AddSudno(kat);
                                        }; break;
                                        case 4: f = true; break;
                                        default: WriteLine("Введите число от 1 до 3"); break;
                                    }
                                }
                                catch{}
                            }
                            while(f == false); 
                        };break;
                        case 2:
                        {
                            bool f = false;
                            do
                            {
                                WriteLine("Введите номер судна, которое хотите удалить, либо напишите -1, чтобы выйти");
                                int i = Convert.ToInt32(ReadLine());
                                try
                                {
                                    switch(i)
                                    {
                                        case -1: f = true; break;
                                        default: port.RemoveSudno(i); break;
                                    }
                                }
                                catch{WriteLine("Судна под таким номером нет");}
                                }
                            while(f == false);
                        }; break;
                        case 3: port.OutputInfo(); break;
                        case 4:
                        {
                            try
                            {
                                WriteLine("Введите номер судна имя, которого будете менять");
                                port.ChangeName(Convert.ToInt32(ReadLine()));
                            }
                            catch{WriteLine("Ошибка");}
                        }; break;
                        case 5: flag = true; break;
                        default: WriteLine("Число должно быть в отрезке от 1 до 5"); break;
                    }
                }
                catch{}
            }
            while(flag == false);
            WriteLine("Сау булыгыз");
        }
    }
}