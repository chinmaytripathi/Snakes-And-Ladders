using System;

namespace Snakes_and_Ladders
{
    class Player
    { 
        public string Name { get; set; }
        public string Color { get; set; }
        public int Position { get; set; }
        public void NewPlayer(string name, char type, int pos)
        {
            Position = pos;
            Name = name;
            if(type == 'A') { Color = "RED"; }
            else if (type == 'B') { Color = "BLUE"; }
            else if (type == 'C') { Color = "ORANGE"; }
            else if (type == 'D') { Color = "WHITE"; }
        }
    }
    class Snake
    {
        public int SnakeHead { get; set; }
        public int SnakeTail { get; set; }
        public void Snakes(int head, int bottom)
        {
            SnakeHead = head;
            SnakeTail = bottom;
        }
        public int SnakeBite(int pos)
        {
            if(pos == SnakeHead)
            {
                Console.WriteLine("Snake has bitten you");
                return SnakeTail;
            }
            else { return pos; }
        }
    }
    class Ladder
    {
        public int LadderAT { get; set; }
        public int LadderTop { get; set; }
        public void Ladders(int top, int bottom)
        {
            LadderAT = bottom;
            LadderTop = top;
        }
        public int ClimbLadder(int pos)
        {
            if (pos == LadderAT)
            {
                Console.WriteLine("YOU GOT LADDER!!!");
                return LadderTop;
            }
            else { return pos; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Snake s1 = new();
            s1.Snakes(99, 42);
            Snake s2 = new();
            s2.Snakes(96, 64);
            Snake s3 = new();
            s3.Snakes(92, 8);
            Snake s4 = new();
            s4.Snakes(85, 59);
            Snake s5 = new();
            s5.Snakes(38, 13);
            Snake s6 = new();
            s6.Snakes(56, 26);
            Snake s7 = new();
            s7.Snakes(29, 3);
            Snake s8 = new();
            s8.Snakes(44, 22);
            Snake s9 = new();
            s9.Snakes(56,2);
            Ladder l1 = new();
            l1.Ladders(98, 18);
            Ladder l2 = new();
            l2.Ladders(57, 39);
            Ladder l3 = new();
            l3.Ladders(27, 4);
            Ladder l4 = new();
            l4.Ladders(34, 6);
            Ladder l5 = new();
            l5.Ladders(43, 23);
            Ladder l6 = new();
            l6.Ladders(73, 53);
            Ladder l7 = new();
            l7.Ladders(63, 19);
            Ladder l8 = new();
            l8.Ladders(86, 62);
            Ladder l9 = new();
            l9.Ladders(93, 50);
            Ladder l10 = new();
            l10.Ladders(61, 10);

            Console.WriteLine("Enter the number of players: [FROM 2 TO 4]");
            int n = int.Parse(Console.ReadLine());
            if(n == 2)
            {
                Player A = new();
                Player B = new();
                Console.WriteLine("Enter the name of the player: ");
                A.Name = Console.ReadLine();
                A.NewPlayer(A.Name, 'A', 0);
                Console.WriteLine("Enter the name of the player: ");
                B.Name = Console.ReadLine();
                B.NewPlayer(B.Name, 'B', 0);
                bool M = true;
                Random R = new();
                int dice;
                while(true)
                {
                    if(M == true)
                    {
                        dice = R.Next(1, 7);
                        Console.WriteLine("\n{0} CHANCE: {1}", A.Name, dice);
                        if(A.Position + dice > 100)
                        {
                            M = false;
                            continue;
                        }
                        else
                        {
                            A.Position += dice;
                        }
                        M = false;
                        A.Position = s1.SnakeBite(A.Position);
                        A.Position = s2.SnakeBite(A.Position);
                        A.Position = s3.SnakeBite(A.Position);
                        A.Position = s4.SnakeBite(A.Position);
                        A.Position = s5.SnakeBite(A.Position);
                        A.Position = s6.SnakeBite(A.Position);
                        A.Position = s7.SnakeBite(A.Position);
                        A.Position = s8.SnakeBite(A.Position);
                        A.Position = s9.SnakeBite(A.Position);
                        A.Position = l1.ClimbLadder(A.Position);
                        A.Position = l2.ClimbLadder(A.Position);
                        A.Position = l3.ClimbLadder(A.Position);
                        A.Position = l4.ClimbLadder(A.Position);
                        A.Position = l5.ClimbLadder(A.Position);
                        A.Position = l6.ClimbLadder(A.Position);
                        A.Position = l7.ClimbLadder(A.Position);
                        A.Position = l8.ClimbLadder(A.Position);
                        A.Position = l9.ClimbLadder(A.Position);
                        A.Position = l10.ClimbLadder(A.Position);
                    }
                    else
                    {
                        dice = R.Next(1, 7);
                        Console.WriteLine("\n{0} CHANCE: {1}", B.Name, dice);
                        if (B.Position + dice > 100)
                        {
                            M = true;
                            continue;
                        }
                        else
                        {
                            B.Position += dice;
                        }
                        M = true;
                        B.Position = s1.SnakeBite(B.Position);
                        B.Position = s2.SnakeBite(B.Position);
                        B.Position = s3.SnakeBite(B.Position);
                        B.Position = s4.SnakeBite(B.Position);
                        B.Position = s5.SnakeBite(B.Position);
                        B.Position = s6.SnakeBite(B.Position);
                        B.Position = s7.SnakeBite(B.Position);
                        B.Position = s8.SnakeBite(B.Position);
                        B.Position = s9.SnakeBite(B.Position);
                        B.Position = l1.ClimbLadder(B.Position);
                        B.Position = l2.ClimbLadder(B.Position);
                        B.Position = l3.ClimbLadder(B.Position);
                        B.Position = l4.ClimbLadder(B.Position);
                        B.Position = l5.ClimbLadder(B.Position);
                        B.Position = l6.ClimbLadder(B.Position);
                        B.Position = l7.ClimbLadder(B.Position);
                        B.Position = l8.ClimbLadder(B.Position);
                        B.Position = l9.ClimbLadder(B.Position);
                        B.Position = l10.ClimbLadder(B.Position);
                    }
                    Console.WriteLine("{0}:\t{1},\t\t{2}:\t{3}\n", A.Name, A.Position, B.Name, B.Position);
                    if (A.Position == 100)
                    {
                        Console.WriteLine("*******HURRAY, {0} WINS*******", A.Name);
                        break;
                    }
                    if (B.Position == 100)
                    {
                        Console.WriteLine("*******HURRAY, {0} WINS*******", B.Name);
                        break;
                    }
                    if(A.Position > 100 || B.Position > 100)
                    {
                        break;
                    }
                }
            }
            else if(n == 3)
            {
                Player A = new();
                Player B = new();
                Player C = new();
                Console.WriteLine("Enter the name of the player: ");
                A.Name = Console.ReadLine();
                A.NewPlayer(A.Name, 'A', 0);
                Console.WriteLine("Enter the name of the player: ");
                B.Name = Console.ReadLine();
                B.NewPlayer(B.Name, 'B', 0);
                Console.WriteLine("Enter the name of the player: ");
                C.Name = Console.ReadLine();
                C.NewPlayer(C.Name, 'C', 0);
            }
            else
            {
                Player A = new();
                Player B = new();
                Player C = new();
                Player D = new();
                Console.WriteLine("Enter the name of the player A: ");
                A.Name = Console.ReadLine();
                A.NewPlayer(A.Name, 'A', 0);
                Console.WriteLine("Enter the name of the player B: ");
                B.Name = Console.ReadLine();
                B.NewPlayer(B.Name, 'B', 0);
                Console.WriteLine("Enter the name of the player C: ");
                C.Name = Console.ReadLine();
                C.NewPlayer(C.Name, 'C', 0);
                Console.WriteLine("Enter the name of the player D: ");
                D.Name = Console.ReadLine();
                D.NewPlayer(D.Name, 'D', 0);
                int chance = 0;
                Random R = new();
                int dice;
                while (true)
                {
                    string s = Console.ReadLine();
                    if (chance == 0)
                    {
                        dice = R.Next(1, 7);
                        Console.WriteLine("\n{0} CHANCE: {1}", A.Name, dice);
                        if (A.Position + dice > 100)
                        {
                            chance = 1;
                            continue;
                        }
                        else
                        {
                            A.Position += dice;
                        }
                        chance = 1;
                        A.Position = s1.SnakeBite(A.Position);
                        A.Position = s2.SnakeBite(A.Position);
                        A.Position = s3.SnakeBite(A.Position);
                        A.Position = s4.SnakeBite(A.Position);
                        A.Position = s5.SnakeBite(A.Position);
                        A.Position = s6.SnakeBite(A.Position);
                        A.Position = s7.SnakeBite(A.Position);
                        A.Position = s8.SnakeBite(A.Position);
                        A.Position = s9.SnakeBite(A.Position);
                        A.Position = l1.ClimbLadder(A.Position);
                        A.Position = l2.ClimbLadder(A.Position);
                        A.Position = l3.ClimbLadder(A.Position);
                        A.Position = l4.ClimbLadder(A.Position);
                        A.Position = l5.ClimbLadder(A.Position);
                        A.Position = l6.ClimbLadder(A.Position);
                        A.Position = l7.ClimbLadder(A.Position);
                        A.Position = l8.ClimbLadder(A.Position);
                        A.Position = l9.ClimbLadder(A.Position);
                        A.Position = l10.ClimbLadder(A.Position);
                    }
                    else if(chance == 1)
                    {
                        dice = R.Next(1, 7);
                        Console.WriteLine("\n{0} CHANCE: {1}", B.Name, dice);
                        if (B.Position + dice > 100)
                        {
                            chance = 2;
                            continue;
                        }
                        else
                        {
                            B.Position += dice;
                        }
                        chance = 2;
                        B.Position = s1.SnakeBite(B.Position);
                        B.Position = s2.SnakeBite(B.Position);
                        B.Position = s3.SnakeBite(B.Position);
                        B.Position = s4.SnakeBite(B.Position);
                        B.Position = s5.SnakeBite(B.Position);
                        B.Position = s6.SnakeBite(B.Position);
                        B.Position = s7.SnakeBite(B.Position);
                        B.Position = s8.SnakeBite(B.Position);
                        B.Position = s9.SnakeBite(B.Position);
                        B.Position = l1.ClimbLadder(B.Position);
                        B.Position = l2.ClimbLadder(B.Position);
                        B.Position = l3.ClimbLadder(B.Position);
                        B.Position = l4.ClimbLadder(B.Position);
                        B.Position = l5.ClimbLadder(B.Position);
                        B.Position = l6.ClimbLadder(B.Position);
                        B.Position = l7.ClimbLadder(B.Position);
                        B.Position = l8.ClimbLadder(B.Position);
                        B.Position = l9.ClimbLadder(B.Position);
                        B.Position = l10.ClimbLadder(B.Position);
                    }
                    else if(chance == 2)
                    {
                        dice = R.Next(1, 7);
                        Console.WriteLine("\n{0} CHANCE: {1}", C.Name, dice);
                        if(C.Position + dice > 100)
                        {
                            chance = 3;
                            continue;
                        }
                        else
                        {
                            C.Position += dice;
                        }
                        chance = 3;
                        C.Position = s1.SnakeBite(C.Position);
                        C.Position = s2.SnakeBite(C.Position);
                        C.Position = s3.SnakeBite(C.Position);
                        C.Position = s4.SnakeBite(C.Position);
                        C.Position = s5.SnakeBite(C.Position);
                        C.Position = s6.SnakeBite(C.Position);
                        C.Position = s7.SnakeBite(C.Position);
                        C.Position = s8.SnakeBite(C.Position);
                        C.Position = s9.SnakeBite(C.Position);
                        C.Position = l1.ClimbLadder(C.Position);
                        C.Position = l2.ClimbLadder(C.Position);
                        C.Position = l3.ClimbLadder(C.Position);
                        C.Position = l4.ClimbLadder(C.Position);
                        C.Position = l5.ClimbLadder(C.Position);
                        C.Position = l6.ClimbLadder(C.Position);
                        C.Position = l7.ClimbLadder(C.Position);
                        C.Position = l8.ClimbLadder(C.Position);
                        C.Position = l9.ClimbLadder(C.Position);
                        C.Position = l10.ClimbLadder(C.Position);
                    }
                    else
                    {
                        dice = R.Next(1, 7);
                        Console.WriteLine("{0} CHANCE: {1}", D.Name, dice);
                        if (D.Position + dice > 100)
                        {
                            chance = 0;
                            continue;
                        }
                        else
                        {
                            D.Position += dice;
                        }
                        chance = 0;
                        D.Position = s1.SnakeBite(D.Position);
                        D.Position = s2.SnakeBite(D.Position);
                        D.Position = s3.SnakeBite(D.Position);
                        D.Position = s4.SnakeBite(D.Position);
                        D.Position = s5.SnakeBite(D.Position);
                        D.Position = s6.SnakeBite(D.Position);
                        D.Position = s7.SnakeBite(D.Position);
                        D.Position = s8.SnakeBite(D.Position);
                        D.Position = s9.SnakeBite(D.Position);
                        D.Position = l1.ClimbLadder(D.Position);
                        D.Position = l2.ClimbLadder(D.Position);
                        D.Position = l3.ClimbLadder(D.Position);
                        D.Position = l4.ClimbLadder(D.Position);
                        D.Position = l5.ClimbLadder(D.Position);
                        D.Position = l6.ClimbLadder(D.Position);
                        D.Position = l7.ClimbLadder(D.Position);
                        D.Position = l8.ClimbLadder(D.Position);
                        D.Position = l9.ClimbLadder(D.Position);
                        D.Position = l10.ClimbLadder(D.Position);
                    }
                    Console.WriteLine("{0}:\t{1},\t\t{2}:\t{3},\t\t{4}:\t{5},\t\t{6}:\t{7}\n", A.Name, A.Position, B.Name, B.Position, C.Name, C.Position, D.Name, D.Position);
                    if (A.Position == 100)
                    {
                        Console.WriteLine("*******HURRAY, {0} WINS*******", A.Name);
                        break;
                    }
                    if (B.Position == 100)
                    {
                        Console.WriteLine("*******HURRAY, {0} WINS*******", B.Name);
                        break;
                    }
                    if (C.Position == 100)
                    {
                        Console.WriteLine("***********HURRAY, {0} WINS***********", C.Name);
                        break;
                    }
                    if(D.Position == 100)
                    {
                        Console.WriteLine("*********HURRAY, {0} WINS************", D.Name);
                        break;
                    }
                }
            }
        }
    }
}
