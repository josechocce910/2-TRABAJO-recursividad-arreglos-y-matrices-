////6) Crea una matriz de números reales. 
//class Program
//{
//    static void Main()
//    {
//        double[,] matriz = new double[2, 4] {
//            {1.1, 2.2, 3.3, 4.4},
//            {5.5, 6.6, 7.7, 8.8}
//        };

//        for (int i = 0; i < matriz.GetLength(0); i++)
//        {
//            for (int j = 0; j < matriz.GetLength(1); j++)
//            {
//                Console.Write(matriz[i, j] + "  ");
//            }
//            Console.WriteLine();
//        }
//        Console.ReadKey();
//    }
//}


////7) Crea una matriz de números complejos. 
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Crear una matriz de números complejos
//        ComplexNumber[,] matrizCompleja = new ComplexNumber[2, 2]
//        {
//            { new ComplexNumber(1, 2), new ComplexNumber(3, 4) },
//            { new ComplexNumber(5, 6), new ComplexNumber(7, 8) }
//        };

//        // Imprimir la matriz de números complejos
//        Console.WriteLine("Matriz de números complejos:");
//        for (int i = 0; i < matrizCompleja.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrizCompleja.GetLength(1); j++)
//            {
//                Console.WriteLine(matrizCompleja[i, j]);
//            }
//        }
//    }
//}
//// Clase para representar números complejos
//class ComplexNumber
//{
//    public double Real { get; set; }
//    public double Imaginario { get; set; }

//    public ComplexNumber(double real, double imaginario)
//    {
//        Real = real;
//        Imaginario = imaginario;
//    }

//    public override string ToString()
//    {
//        if (Imaginario >= 0)
//            return $"{Real} + {Imaginario}i";
//        else
//            return $"{Real} - {-Imaginario}i";
//    }
//}


////8) Crea una matriz de matrices. 

//int[][] matrizdematrices = new int[][]
//{
//    new int[] { 1, 2, 3 },
//    new int[] { 4, 5, 6 },
//    new int[] { 7, 8, 9 }
//};

//for (int i = 0; i < matrizdematrices.Length; i++)
//{
//    for (int j = 0; j < matrizdematrices[i].Length; j++)
//    {
//        Console.Write(matrizdematrices[i][j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();


////9) Accede al elemento central de una matriz. 
//int[,] matriz = new int[2, 2] { { 1, 2 }, { 3, 4 } };

//int centro = matriz[1, 1];

//Console.WriteLine("El elemento central es: " + centro);
//Console.ReadKey();


////10) Suma dos matrices de diferentes tamaños.

//class Program
//{
//    static void Main()
//    {
//        int[][] matriz1 = { new int[] { 1, 2 }, new int[] { 3, 4 } };
//        int[][] matriz2 = { new int[] { 5, 6, 7 }, new int[] { 8, 9 } };

//        int[][] joinedMatrix = matriz1.Concat(matriz2).ToArray();

//        for (int i = 0; i < joinedMatrix.Length; i++)
//        {
//            for (int j = 0; j < joinedMatrix[i].Length; j++)
//            {
//                Console.Write(joinedMatrix[i][j] + " ");
//            }
//            Console.WriteLine();
//        }
//        Console .ReadKey ();
//    }
//}



////11) Multiplica una matriz por un número. 

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Declarar la matriz
//        int[,] matriz = new int[,] { { 1, 2 }, { 3, 4 } };

//        // Pedir al usuario que ingrese un número
//        Console.Write("Ingrese un número por la cual multiplicar la matriz : ");
//        int num = Convert.ToInt32(Console.ReadLine());

//        // Multiplicar la matriz por el número
//        for (int i = 0; i < matriz.GetLength(0); i++)
//        {
//            for (int j = 0; j < matriz.GetLength(1); j++)
//            {
//                matriz[i, j] *= num;
//            }
//        }
//        // Imprimir la matriz resultante
//        Console.WriteLine("La matriz resultante es:");
//        for (int i = 0; i < matriz.GetLength(0); i++)
//        {
//            for (int j = 0; j < matriz.GetLength(1); j++)
//            {
//                Console.Write(matriz[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//        Console.ReadKey();
//    }
//}


////12) Calcula la media de los elementos de una matriz. 

//int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

//int sum = 0;
//int count = 0;

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        sum += matrix[i, j];
//        count++;
//    }
//}

//double average = (double)sum / count;

//Console.WriteLine("La media de la matriz es: " + average);
//Console.ReadKey();