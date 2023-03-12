// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами

Console.Clear();

void PrintArray(string[] StringArray)
            {
                for (int i = 0; i < StringArray.Length; i++)
                {
                    Console.WriteLine(StringArray[i]);
                }
            }
            string[] AutoGenerateArray()
            {
                Random Rand = new Random();
                Thread.Sleep(100);
                Random Rand2 = new Random();
                Thread.Sleep(100);
                Random Rand3 = new Random();
                string[] StringArray = new string[Rand.Next(5, 100)];
                string BuffPhrase = "";
                for (int i = 0; i < StringArray.Length; i++)
                {
                    int RandCharCoint = Rand2.Next(1, 10);
                    for (int j = 0; j < RandCharCoint; j++)
                    {
                        BuffPhrase += (char)Rand3.Next(0x0410, 0x44F);
                    }
                    StringArray[i] = BuffPhrase;
                    BuffPhrase = "";
                }
                PrintArray(StringArray);
                return StringArray;
            }
            string[] HandGenerate()
            {
                Console.WriteLine("Введите размерность массива.");
                string[] StringArray = new string[int.Parse(Console.ReadLine())];
                for (int i = 0; i < StringArray.Length; i++) 
                {
                    Console.WriteLine(@"Введите значение № {0}",i+1);
                    StringArray[i] = Console.ReadLine();
                }
                Console.WriteLine("Массив сгенерирован.");
                PrintArray(StringArray);
                return StringArray;
            }
            string[] ArrayGeneratingChoice()
            {
                Console.WriteLine("Выберите способ генерации массива. Для генерации в случайном режиме напишите Y. Для генерации в Ручном режиме нажмите N");
                Console.WriteLine("Для генерации в случайном режиме напишите Y и нажмите Enter.");
                Console.WriteLine("Для генерации в Ручном режиме нажмите N и нажмите Enter.");
                switch (Console.ReadLine())
                {
                    case "Y":
                        return AutoGenerateArray();
                    case "N":
                        return HandGenerate();
                    default: return AutoGenerateArray();
                }
            }
            void RecreateArray(string [] StringArray)
            {
                int TotalCount = 0;
                for (int i = 0; i < StringArray.Length; i++)
                {
                    if (StringArray[i].Length <= 3)
                        TotalCount++;
                }
                string[] NewArray = new string[TotalCount];
                int j = 0;
                for (int i = 0; i < StringArray.Length; i++)
                {
                    if (StringArray[i].Length <= 3)
                        {
                        NewArray[j] = StringArray[i];
                        j++; 
                        }
                }
                Console.WriteLine("--------------");
                Console.WriteLine("Новый массив.");
                PrintArray(NewArray);
            }


            RecreateArray(ArrayGeneratingChoice());
            Console.ReadKey();
