////Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100

//class Program
//{
//    static void Main(string[] args)
//    {
//        NumerosPares(1);
//        Console.ReadKey();
//    }
//    static void NumerosPares(int número)
//    {
//        if (número > 100) return;
//        if (número % 2 == 0) Console.WriteLine(número);
//        NumerosPares(número + 1);
//    }

//}


////Ejercicio 2: Escribe una función recursiva que imprima la suma de los números del 1 al n. 

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Escriba el valor de n: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        int sum = Suma(n);
//        Console.WriteLine("La suma de los " + n + " números es: " + sum);
//        Console.ReadKey();
//    }

//    static int Suma(int n)
//    {
//        if (n == 1)
//            return 1;
//        else
//            return n + Suma(n - 1);
//    }
//}

////Ejercicio 3:Escribe una función recursiva que imprima la pirámide de números del 1 al n. 
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ingrese el número de n :");
//        int n = Convert.ToInt32(Console.ReadLine());

//        ImprimirPiramide(1, n);
//        Console.ReadKey();
//    }

//    static void ImprimirPiramide(int fila, int n)
//    {
//        if (fila > n)
//            return;

//        for (int i = 0; i < n - fila; i++)
//        {
//            Console.Write(" ");
//        }

//        for (int i = 1; i <= fila * 2 - 1; i++)
//        {
//            Console.Write(fila);
//        }
//        Console.WriteLine();
//        ImprimirPiramide(fila + 1, n);
//    }
//}

////4) Ejercicio 4: Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n. 
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ingrese el número de n :");
//        int n = Convert.ToInt32(Console.ReadLine());

//        ImprimirPiramideInvertida(n);
//        Console.ReadKey();
//    }

//    static void ImprimirPiramideInvertida(int n)
//    {
//        for (int fila = n; fila >= 1; fila--)
//        {
//            for (int i = 0; i < n - fila; i++)
//            {
//                Console.Write(" ");
//            }

//            for (int i = 1; i <= fila * 2 - 1; i++)
//            {
//                Console.Write(fila);
//            }
//            Console.WriteLine();
//        }
//    }
//}


////5) Ejercicio 2: Escribe una función recursiva que imprima la tabla de multiplicar del n. 
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ingrese un número para obtener su tabla de multiplicar:");
//        int n = Convert.ToInt32(Console.ReadLine());

//        Multiplicar(n, 1);
//        Console.ReadKey();
//    }

//    static void Multiplicar(int n, int multiplicador)
//    {
//        if (multiplicador <= 12)
//        {
//            Console.WriteLine(n + " x " + multiplicador + " = " + (n * multiplicador));
//            Multiplicar(n, multiplicador + 1);
//        }
//    }
//}
