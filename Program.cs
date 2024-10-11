namespace CoPilotUppgifter1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lägg uppgiften att köra här.
            Uppgift28();
        }

        static void Uppgift1()
        {
            int[] numbers = GenerateIntArray();
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"Summan av alla nummer i arrayen är {sum}");
        }

        static void Uppgift2()
        {
            int[] numbers = GenerateIntArray();
            // Sätter första numret i arrayen som startvärde, och skippar första index i loopen.
            int highestNum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > highestNum) highestNum = numbers[i];
            } 

            Console.WriteLine($"Största talet i arrayen är {highestNum}");
        }

        static void Uppgift3()
        {
            int[] numbers = GenerateIntArray();
            int evenNums = 0;
            int oddNums = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) 
                {
                    evenNums += 1;
                }
                else
                {
                    oddNums += 1;
                }
            }  
            Console.WriteLine($"Antal jämna tal: {evenNums}");
            Console.WriteLine($"Antal udda tal: {oddNums}");
        }

        static void Uppgift4()
        {
            int[] numbers = GenerateIntArray();
            int[] reversedNumbers = new int[10];
            int invertedIndex = numbers.Length - 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                reversedNumbers[i] = numbers[invertedIndex - i];
            }

            Console.Write("Vanliga arrayen: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine("");
            Console.Write("Vända arrayen:   ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(reversedNumbers[i] + ", ");
            }
        }

        static void Uppgift5()
        {
            int[] numbers = GenerateIntArray();
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            
            // Explicit konvertering av int till double för att få med decimaler.
            double median = (double)sum / (double)numbers.Length;
            Console.WriteLine($"Medianen av summan från arrayen är {median}");
        }

        static void Uppgift6()
        {
            int[] numbers = GenerateIntArray();
            // Sätter första numret i arrayen som startvärde, och skippar första index i loopen.
            int smallestNum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < smallestNum) smallestNum = numbers[i];
            } 

            Console.WriteLine($"Minsta talet i arrayen är {smallestNum}");
        }

        static void Uppgift7()
        {
            int[] numbers = GenerateIntArray();
            int occurenceNum = GenerateInt();
            int totalOccurences = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (occurenceNum == numbers[i]) totalOccurences++;
            }

            Console.WriteLine($"Talet {occurenceNum} förekommer i arrayen {totalOccurences} gånger");
        }

        static void Uppgift8()
        {
            int[] numbers = GenerateIntArray();
            int temp = 0;

            // Denna loopens syfte är att köra den nestlade loopen tillräckligt många gånger för att sortera arrayen.
            for (int i = 0; i < numbers.Length; i++)
            {
                // Kollar varje rad i arrayen.
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    // om värdet på index är större än värdet på nästa index körs selektionen.
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Spara värdet på nästa index temporärt.
                        temp = numbers[j + 1];
                        // Flytta värdet på index i nästa index.
                        numbers[j + 1] = numbers[j];
                        //  Flytta värdet i nästa index (sparad i temp) till index.
                        numbers[j] = temp;
                    }
                }
            }
            Console.Write("Alla nummer i arrayen sorterade: ");
            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.Write(numbers[i] + ", ");
            }
        }

        static void Uppgift9()
        {
            // Jag vet fan inte vad jag har gjort här...
            int[,] dimensionalArr = new int[10,10];
            
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    dimensionalArr[i-1,j-1] = i * j;
                }
            }

            Console.WriteLine("Multiplikationstabellen");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++) 
                {
                    Console.WriteLine(dimensionalArr[i, j]);
                }
            }
        }

        static void Uppgift10() 
        {
            // Skriver array manuellt, eftersom att generera en array som är palindrom går blä.
            int[] numbers = { 5, 4, 3, 2, 1, 1, 2, 3, 4, 5};
            int[] reversedNumbers = new int[10];
            int invertedIndex = numbers.Length - 1;
            bool isPalindrome = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                reversedNumbers[i] = numbers[invertedIndex - i];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != reversedNumbers[i])
                {
                    isPalindrome = !isPalindrome;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Arrayen är en palindrom.");
            }
            else 
            {
                Console.WriteLine("Arrayen är inte en palindrom.");
            }
        }

        static void Uppgift11()
        {
            int[] numbers = GenerateIntArray();
            int product = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }

            Console.WriteLine($"Produkten av alla nummer i arrayen är {product}");
        }

        static void Uppgift12()
        {
            int[] numbers = GenerateIntArray();
            // Fråga inte
            int highestNum = numbers[0] > numbers[1] ? numbers[0] : numbers[1]; 
            int secondHighestNum = numbers[0] < numbers[1] ? numbers[0] : numbers[1];
            int temp = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > secondHighestNum)
                {
                    temp = numbers[i];
                    if (numbers[i] > highestNum) 
                    {
                        temp = highestNum;
                        highestNum = numbers[i];
                        secondHighestNum = temp;
                    } 
                    else if (numbers[i] < highestNum)
                    {
                        secondHighestNum = numbers[i];
                    }
                }
            }

            Console.WriteLine($"Näst högsta nummer: {secondHighestNum}");
        }

        static void Uppgift13()
        {
            int[] numbers = GenerateIntArray2();
            int totalNegativeNums = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0) totalNegativeNums++; 
            }

            Console.WriteLine($"Total negative numbers: {totalNegativeNums}");
        }

        static void Uppgift14()
        {
            // Finns säkert bättre lösning men orkar inte fixa just denna.
            int[] numbers = GenerateIntArray3();
            int zeroes = 0;

            // Identifiera alla 0 i arrayen.
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0) zeroes++;
            }

            // Skapa ny array som ska bli sorterad.
            int[] sortedNumbers = new int[numbers.Length];
            int index = 0;

            // Samma loop igen, men placera alla nummer som inte är 0 i nya listan.
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0) 
                {
                    sortedNumbers[index] = numbers[i];
                    index++;
                }
            }

            // Sätt alla sista och tomma värdentill 0 i sorterade arrayen.
            for (int i = index; i < numbers.Length; i++)
            {
                sortedNumbers[i] = 0;
            }

            Console.Write("Arrayen med alla 0 sorterade i slutet: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(sortedNumbers[i] + ", ");
            }
        }

        static void Uppgift15()
        {
            int[] numbers = GenerateIntArray2();
            int sum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0) sum += numbers[i];
            }

            Console.WriteLine($"Summan av alla positiva tal i arrayen är {sum}");
        }

        static void Uppgift16()
        {
            int[] numbers = GenerateIntArray2();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0) 
                {
                    Console.WriteLine($"Första positiva talet i arrayen är {numbers[i]}");
                    break;
                }
            }
        }

        static void Uppgift17()
        {
            int[] numbers = GenerateIntArray();
            int num = GenerateInt();
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (num < numbers[i]) count++;
            }

            Console.WriteLine($"Antalet tal i arrayen som är större än {num} är {count}");
        }

        static void Uppgift18()
        {
            int[] numbers = GenerateIntArray2();
            int highestNum = 0;
            int lowestNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > highestNum) highestNum = numbers[i];
                if (numbers[i] < lowestNum) lowestNum = numbers[i];
            }
            int diff = highestNum - lowestNum;

            Console.WriteLine($"Differensen mellan {highestNum} och {lowestNum} är {diff}");
        }

        static void Uppgift19()
        {
            int[] quadArr = new int[10];

            for (int i = 1; i <= quadArr.Length; i++)
            {
                quadArr[i - 1] = i * i;
            }

            Console.Write("Kvadraterna mellan 1 till 10 är: ");

            for (int i = 0; i < quadArr.Length; i++) Console.Write(quadArr[i] + ", ");
        }

        static void Uppgift20()
        {
            int[] numbers = GenerateIntArray();
            int num = GenerateInt();
            bool isInArr = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (num == numbers[i])
                {
                    isInArr = !isInArr;
                    break;
                }
            }

            if (isInArr) 
            {
                Console.WriteLine($"The number {num} is in array.");
            }
            else 
            {
                Console.WriteLine($"The number {num} is not in array.");
            }
        }

        static void Uppgift21()
        {
            int i = 1;
            int sum = 0;

            while (i <= 100)
            {
                sum += i;
                i++;
            }

            Console.WriteLine($"Summan av alla tal mellan 1 och 100 är {sum}");
        }

        static void Uppgift22()
        {
            bool isCorrect = false;
            int correctAnswer = GenerateLargeInt();
            
            while (!isCorrect)
            {
                Console.Write("Gissa på ett tal mellan 1-100: ");
                string guessInput = Console.ReadLine();
                int guess = Convert.ToInt32(guessInput);

                if (guess > correctAnswer)
                {
                    Console.WriteLine("Du gissade för högt");
                }
                else if (guess < correctAnswer)
                { 
                    Console.WriteLine("Du gissade för lågt");
                }
                else
                {
                    Console.WriteLine($"Korrekt, svaret är {correctAnswer}");
                    isCorrect = !isCorrect;
                }

            }
        }

        static void Uppgift23()
        {
            int num = 10;

            while (num >= 0)
            {
                Console.WriteLine(num);
                num--;
            }
        }

        static void Uppgift24()
        {
            Console.Write("Ange ett tal för multiplikation: ");
            string input = Console.ReadLine();
            int intInput = Convert.ToInt32(input);

            Console.Write("Varje multiplikation mellan 1-10: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i * intInput + ", ");
            }
        }

        static void Uppgift25()
        {
            Console.Write("Ange ett tal för multiplikation: ");
            int input = userNumInput();

            Console.Write("Varje multiplikation mellan 1-10: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i * input + ", ");
            }
        }

        static void Uppgift26()
        {
            Console.Write("Ange tal att beräkna fakulteten på: ");
            int input = userNumInput();
            int fakultetThing = 1;

            Console.Write($"Fakulteten av {input} är ");
        
            while (input > 0)
            {
                fakultetThing *= input;
                input--;
            }

            Console.WriteLine(fakultetThing);
        }

        static void Uppgift27()
        {
            // while loop känns helt mupp i denna? jag kör foreach iaf...
            Console.Write("Ange ett tal där siffrorna ska summeras");
            string input = Console.ReadLine();
            int sum = 0;

            foreach (char c in input)
            {
                // Sluta klaga tack
                int cInt = (int)char.GetNumericValue(c);
                sum += cInt;
            }

            Console.WriteLine($"Summan av alla siffror i talet är {sum}");
        }

        static void Uppgift28()
        {
            // Jag sover ZZZZZzzzzzzzz..............
        }

        static int userNumInput()
        {
            string input = Console.ReadLine();
            int intInput = Convert.ToInt32(input);
            return intInput;
        }

        static int GenerateInt()
        {
            Random rnd = new Random();
            return rnd.Next(1, 11);
        }

        static int GenerateLargeInt()
        {
            Random rnd = new Random();
            return rnd.Next(1, 101);
        }

        static int[] GenerateIntArray()
        {
            // Använder sig av inbyggda klassen random för att generera en array med 10 tal med värde mellan 1-10.
            int[] intArr = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = rnd.Next(1, 11);
                Console.Write(intArr[i] + ", ");
            }

            return intArr;
        }

        static int[] GenerateIntArray2()
        {
            // Samma som övre metod, fast den genererar tal som är negativa.
            int[] intArr = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = rnd.Next(-10, 11);
                Console.Write(intArr[i] + ", ");
            }

            return intArr;
        }

        static int[] GenerateIntArray3()
        {
            // Genererar tal från 0-10, vilket första metoden borde gjort men jag är dum i huvudet...
            int[] intArr = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = rnd.Next(0, 11);
                Console.Write(intArr[i] + ", ");
            }

            return intArr;
        }
    }
}
