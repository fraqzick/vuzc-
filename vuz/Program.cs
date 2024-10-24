﻿using static System.Console;


namespace Lab_10
{
    class Sudno
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

        public Sudno(string n)
        {
            name = n;
        }

        public void Oops() {name = name[2..];}
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

        public new void Oops()
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

        public new void Oops() {WriteLine($"Ой, параход ''{Name}'' тонет (.");}
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

        public new void Oops(int speedtecheniya)
        {
            speed = speedtecheniya;
            WriteLine($"Мотор заглох, течение уносит со скорстью {speedtecheniya}");
        }
    }

    class Program
    {
        static void Main()
        {
            //Создаём экземпляры классов
            Sudno sudno = new();
            Korabl korabl = new();
            Parahod parahod = new();
            Kater kater = new();

            Sudno[] ships = [sudno, korabl, parahod, kater];
            
            //Демонстрация методов
            sudno.Oops();
            WriteLine(sudno.Name);

            korabl.Oops();
            WriteLine(korabl.Name);

            parahod.Oops();

            kater.Oops(5);
            WriteLine(kater.Speed);
        }
    }
}