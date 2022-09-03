         void factorialdigit (string? data)
         {
            ulong num;
            while(true)
            {
                if(ulong.TryParse(data, out num))
                {
                    break;
                }
                else
                {
                    System.Console.WriteLine("Ошибка");
                    data = System.Console.ReadLine();
                }
            }
            ulong result = 1;
            for(ulong i = 2; i <= num; i++)
            {
                result*= i;
            }
            System.Console.WriteLine(result);
         }

System.Console.WriteLine("Введите число");
factorialdigit(Console.ReadLine());