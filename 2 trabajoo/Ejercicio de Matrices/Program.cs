////Ejercicio 1: Crea una matriz de números aleatorios de tamaño 100x100. 
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Crear una instancia de la clase Random para generar números aleatorios
//        Random rnd = new Random();

//        // Definir el tamaño de la matriz
//        int filas = 100;
//        int columnas = 100;

//        // Crear y llenar la matriz con números aleatorios
//        int[,] matriz = new int[filas, columnas];
//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                matriz[i, j] = rnd.Next(1, 101); // Números aleatorios entre 1 y 100
//            }
//        }

//        // Imprimir la matriz (opcional)
//        Console.WriteLine("La matriz de números aleatorios de tamaño 100x100:");
//        // Por razones de visualización, sólo se imprimirán los primeros 10x10 elementos de la matriz
//        for (int i = 0; i < 10; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                Console.Write(matriz[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//        Console.ReadKey();
//    }
//}


////Ejercicio 2: Calcula la media, la mediana y la desviación estándar de los elementos de una matriz. 
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] matriz = {
//            { 2, 4, 6, 8 },
//            { 3, 6, 9, 12 },
//            { 5, 10, 15, 20 }
//        };

//        double media = matriz.Cast<int>().Average();
//        double mediana = matriz.Cast<int>().OrderBy(x => x).Skip(matriz.Length / 2).Take(1 + (matriz.Length % 2 == 0 ? 1 : 0)).Average();
//        double desviacionEstandar = Math.Sqrt(matriz.Cast<int>().Select(x => Math.Pow(x - media, 2)).Average());

//        Console.WriteLine("la Media es: " + media);
//        Console.WriteLine("La Mediana es : " + mediana);
//        Console.WriteLine("La Desviación estándar es : " + desviacionEstandar);
//        Console.ReadKey();
//    }

//}



////Ejercicio 3: Escribe una función que encuentre el elemento máximo de una matriz. 

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] matriz = {
//            { 2, 4, 6, 8 },
//            { 3, 12, 9, 6 },
//            { 5, 10, 15, 20 }
//        };

//        int maximo = matriz.Cast<int>().Max();
//        Console.WriteLine("El elemento máximo de la matriz es: " + maximo);
//        Console.ReadKey();
//    }
//}



//Ejercicio 4: Escribe una función que encuentre la submatriz de mayor suma de una matriz. 

//Ejercicio 5: Escribe una función que encuentre la matriz de covarianza de dos matrices.
