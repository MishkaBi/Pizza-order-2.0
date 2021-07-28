using System;

namespace Pizza_Order_2._0
{
    class Program
    {
        const int MaxUpperLimit = 5;
        const int DoughUnleavened = 1;
        const int DoughYeast = 2;
        const int DoughLeaves = 3;
        const int DoughBlack = 4;
        const int MaxNumberOfElectoins = 4;
        const int FillingSausage = 1;
        const int FillingChiken = 2;
        const int FillingBacon = 3;
        const int FillingCheese = 4;
        const int SauceKetchup = 1;
        const int SauceMayonaise = 2;
        const int SauceTartar = 3;
        const int SauceCheesy = 4;
        const int AdditionalOlives = 1;
        const int AdditionalTomatoes = 2;
        const int AdditionalPineapple = 3;
        const int AdditionalShrimp = 4;
        const int Exit = 0;
        static void ExitTheProgram()
        {
            Console.Clear();
            Console.WriteLine("Ви вийшли з програми.");
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Вибер1ть з якого т1ста буде складатись п1ца\n1. Бездр1жджове\n2. Др1жджове\n3. Листкове\n4. Чорне\n0. Вих1д");
            string dough = Console.ReadLine();
            int ChoiceOfDough = Convert.ToInt32(dough);
            for (; ChoiceOfDough > MaxNumberOfElectoins;)
            {
                dough = Console.ReadLine();
                ChoiceOfDough = Convert.ToInt32(dough);

                if (ChoiceOfDough < MaxUpperLimit)
                    break;

                Console.WriteLine("Введ1ть число в д1апазог1 0-4");
            }
            switch (ChoiceOfDough)
            {
                case DoughUnleavened:
                    dough = "Бездр1жджове";
                    break;
                case DoughYeast:
                    dough = "Др1жджове";
                    break;
                case DoughLeaves:
                    dough = "Листкове";
                    break;
                case DoughBlack:
                    dough = "Чорне";
                    break;
                case Exit:
                    ExitTheProgram();
                    break;
            }
            Console.Clear();


            Console.WriteLine("Вибер1ть яка начинка буде у п1ц1\n1. Ковбаса\n2. Курка\n3. Бекон\n4. Сир\n0. Вих1д");
            string filling = Console.ReadLine();
            int ChoiceOfFilling = Convert.ToInt32(filling);
            for (; ChoiceOfFilling > MaxNumberOfElectoins;)
            {
                filling = Console.ReadLine();
                ChoiceOfFilling = Convert.ToInt32(filling);

                if (ChoiceOfFilling < MaxUpperLimit)
                    break;

                Console.WriteLine("Введ1ть число в д1апазог1 0-4");
            }
            switch (ChoiceOfFilling)
            {
                case FillingSausage:
                    filling = "Ковбаса";
                    break;
                case FillingChiken:
                    filling = "Курка";
                    break;
                case FillingBacon:
                    filling = "Бекон";
                    break;
                case FillingCheese:
                    filling = "Сир";
                    break;
                case Exit:
                    ExitTheProgram();
                    break;
            }
            Console.Clear();

            Console.WriteLine("Вибер1ть який соус буде у п1ц1\n1. Кетчуп\n2. Майонез\n3. Тартар\n4. Сирний\n0. Вих1д");
            string sauce = Console.ReadLine();
            int ChoiceOfSauce = Convert.ToInt32(sauce);
            for (; ChoiceOfSauce > MaxNumberOfElectoins;)
            {
                sauce = Console.ReadLine();
                ChoiceOfSauce = Convert.ToInt32(sauce);

                if (ChoiceOfSauce < MaxUpperLimit)
                    break;

                Console.WriteLine("Введ1ть число в д1апазог1 0-4");
            }
            switch (ChoiceOfSauce)
            {
                case SauceKetchup:
                    sauce = "Кетчуп";
                    break;
                case SauceMayonaise:
                    sauce = "Майонез";
                    break;
                case SauceTartar:
                    sauce = "Тартар";
                    break;
                case SauceCheesy:
                    sauce = "Сирний";
                    break;
                case Exit:
                    ExitTheProgram();
                    break;
            }
            Console.Clear();

            Console.WriteLine("Вибер1ть як1 додатков1 1нгред1єнти будуть у п1ц1\n1. Оливки\n2. Пом1дори\n3. Ананас\n4. Креветки\n0. Вих1д");
            string additional = Console.ReadLine();
            int ChoiceOfAdditional = Convert.ToInt32(additional);
            for (; ChoiceOfAdditional > MaxNumberOfElectoins;)
            {
                sauce = Console.ReadLine();
                ChoiceOfAdditional = Convert.ToInt32(additional);

                if (ChoiceOfAdditional < MaxUpperLimit)
                    break;

                Console.WriteLine("Введ1ть число в д1апазог1 0-4");
            }
            switch (ChoiceOfAdditional)
            {
                case AdditionalOlives:
                    additional = "Оливки";
                    break;
                case AdditionalTomatoes:
                    additional = "Пом1дори";
                    break;
                case AdditionalPineapple:
                    additional = "Ананас";
                    break;
                case AdditionalShrimp:
                    additional = "Креветки";
                    break;
                case Exit:
                    ExitTheProgram();
                    break;
            }
            Console.Clear();

            Console.WriteLine($"Ваша п1ца");
            Console.WriteLine($"Т1сто: {dough} ");
            Console.WriteLine($"Начинка: {filling}");
            Console.WriteLine($"Соус: {sauce}");
            Console.WriteLine($"Додатков1 1нгред1єти: {additional}");
        }
    }
}
