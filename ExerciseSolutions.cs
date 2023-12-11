namespace Listas
{
    class ExerciseSolutions
    {
       
            public static void Exercise1()
            {
                var namesList = new List<string?>();

                while (true)
                {
                    Console.Write("Escribe un nombre: ");
                    var newName = Console.ReadLine();
                    if (newName == "") break;
                    namesList.Add(newName);
                }

                if (namesList.Count == 1)
                {
                    Console.WriteLine("A " + namesList[0] + " le gustó tu post.");
                }
                else if (namesList.Count == 2)
                {
                    Console.WriteLine("A " + namesList[0] + " y " + namesList[1] + " les gustó tu publicación.");
                }
                else if (namesList.Count > 2)
                {
                    var remainingNames = namesList.Count - 2;
                    Console.WriteLine("A " + namesList[0] + ", " + namesList[1] + " y " + remainingNames + " más les gustó tu publicación.");
                }
            }

        public static void Exercise2()
        {
            Console.Write("Escribe tu nombre: ");
            var userName = Console.ReadLine();
            var arrayOfUserName = userName.ToCharArray(); //para manejar mejor un nombre, preferible es usar una cadena de caracteres para su posterior manipulación
            Array.Reverse(arrayOfUserName);
            var reverseName = new string(arrayOfUserName);
            Console.WriteLine("Nombre invertido: " + reverseName);
        }

        public static void Exercise3()
        {
            var numbersList = new List<int>();

            while (true)
            {
                Console.Write("Digite un número: ");
                var newNumber = Convert.ToInt32(Console.ReadLine());
                if (numbersList.Exists(number => number == newNumber))
                {
                    Console.WriteLine("Número no único, intente de nuevo.");
                    continue;
                }
                numbersList.Add(newNumber);

                if (numbersList.Count == 5) break;
            }

            numbersList.Sort();
            Console.WriteLine("Números introducidos y ordenados: ");
            foreach (var number in numbersList)
            {
                Console.WriteLine(number);
            }
        }

        public static void Exercise4()
        {
            var numbersList = new List<int>();
            while (true)
            {
                Console.WriteLine("Digite un número o \"Quit\" para salir.");
                var response = Console.ReadLine();
                if (response == "Quit") break;
                var responseAsNumber = Convert.ToInt32(response);
                numbersList.Add(responseAsNumber);
            }
            Console.WriteLine("Números únicos: ");
            var uniqueNumbersList = numbersList.Distinct().ToList(); // El método distinct permite encontrar aquellos elementos únicos de una lista/array y luego los convertimos en una lista.
            foreach (var uniqueNumber in uniqueNumbersList)
            {
                Console.WriteLine(uniqueNumber);
            }
        }

        public static void Exercise5()
        {
            var responseList = new List<int>();
            while (true)
            {
                Console.WriteLine("Escriba una serie de números separados por comas: ");
                var response = Console.ReadLine();
                var numbersFromResponseArray = response.Split(','); // Se separa el string introducido y se mete en un array, identificando como separador las comas.


                if (numbersFromResponseArray == null || numbersFromResponseArray.Length < 5)
                {
                    Console.WriteLine("Lista no válida, intente de nuevo.");
                    continue;
                }

                else
                {
                    foreach (var number in numbersFromResponseArray)
                    {
                        responseList.Add(Convert.ToInt32(number));
                    }
                    break;
                }

            }
            responseList.Sort(); 

            for (int i = 0; i < 3; i++) // Se quieren los 3 mínimos números, por ello, se usa Sort y luego se imprime de manera manual los primeros 3.
            {
                Console.WriteLine(responseList[i]);
            }
        }
    }
}