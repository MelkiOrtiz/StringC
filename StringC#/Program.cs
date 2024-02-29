//// Declaración de variables
//string personaje = "Tyrion Lannister";
//string casa = "Lannister";
//string fraseFamosa = "Un Lannister siempre paga sus deudas.";

//// Métodos para manipular cadenas
//Console.WriteLine("Longitud de la frase famosa: " + fraseFamosa.Length);
//Console.WriteLine("Frase famosa en mayúsculas: " + fraseFamosa.ToUpper());
//Console.WriteLine("Frase famosa en minúsculas: " + fraseFamosa.ToLower());
//Console.WriteLine("Índice de 'siempre' en la frase famosa: " + fraseFamosa.IndexOf("siempre"));
//Console.WriteLine("Último índice de 'Lannister' en la frase famosa: " + fraseFamosa.LastIndexOf("Lannister"));
//Console.WriteLine("Parte de la frase famosa: " + fraseFamosa.Substring(13));
//Console.WriteLine("Reemplazar 'paga' por 'puede' en la frase famosa: " + fraseFamosa.Replace("paga", "puede"));
//Console.WriteLine("Frase famosa sin espacios en blanco al inicio y final: " + fraseFamosa.Trim());
//Console.WriteLine("¿La frase famosa comienza con 'Un'? " + fraseFamosa.StartsWith("Un"));
//Console.WriteLine("¿La frase famosa termina con 'deudas'? " + fraseFamosa.EndsWith("deudas"));

//// Propiedades de cadenas
//Console.WriteLine("Longitud de la frase famosa (propiedad): " + fraseFamosa.Length);
//Console.WriteLine("¿La frase famosa es de solo lectura? " + IsStringReadOnly(fraseFamosa));
//Console.WriteLine("Caracteres que componen la frase famosa:");
//foreach (char c in fraseFamosa.ToCharArray())
//{
//    Console.WriteLine(c);
//}

//// Operaciones con cadenas
//Console.WriteLine("¿El personaje pertenece a la casa Lannister? " + casa.Equals("Lannister"));
//string fraseConcatenada = personaje + " de la casa " + casa + " dijo: \"" + fraseFamosa + "\"";
//Console.WriteLine("Frase concatenada: " + fraseConcatenada);
//Console.WriteLine("Índice de 'Tyrion' en la frase concatenada: " + fraseConcatenada.IndexOf("Tyrion"));

//// Formateo de cadenas
//int temporadaActual = 8;
//string mensajeFormatado = String.Format("La temporada actual de Juego de Tronos es la {0}.", temporadaActual);
//Console.WriteLine("Mensaje formateado sobre la temporada actual de Juego de Tronos: " + mensajeFormatado);

//Console.ReadLine();
//    // Método ficticio para demostrar cómo verificar si una cadena es de solo lectura
//    static bool IsStringReadOnly(string str)
//{
//    // No hay una propiedad directa para verificar si una cadena es de solo lectura,
//    // así que devolvemos false como ejemplo.
//    return false;
//}


/////* 1. Escribir un programa que le pida al usuario un número entero positivo y le muestre un menú con las siguientes opciones: */
//int opcion;
//do
//{
//    int numero;
//    do
//    {
//        Console.Write("Ingrese un número entero positivo: ");
//    } while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0);
//    do
//    {
//        Console.WriteLine("Menú:");
//        Console.WriteLine("1. Calcular el factorial del número.");
//        Console.WriteLine("2. Calcular la raíz cuadrada del número.");
//        Console.WriteLine("3. Salir del programa.");
//        Console.Write("Seleccione una opción: ");
//    } while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3);
//    switch (opcion)
//    {
//        case 1:
//            // Calcular el factorial del número
//            long factorial = 1;
//            for (int i = 1; i <= numero; i++)
//            {
//                factorial *= i;
//            }
//            Console.WriteLine($"El factorial de {numero} es {factorial}.");
//            break;
//        case 2:
//            // Calcular la raíz cuadrada del número
//            double raizCuadrada = Math.Sqrt(numero);
//            Console.WriteLine($"La raíz cuadrada de {numero} es {raizCuadrada}.");
//            break;
//        case 3:
//            // Salir del programa
//            Console.WriteLine("¡Hasta luego, que la fuerza te acompañe!");
//            break;
//        default:
//            Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
//            break;
//    }
//} while (opcion != 3);

//-----------------------------------------------------------------------------------------------------------------------------------

///* 2. Escribir un programa que solicite al usuario dos números enteros y un operador matemático (+, -, *, /) */
//int opcion;
//do
//{
//    Console.Write("Ingrese el primer número: ");
//    if (!int.TryParse(Console.ReadLine(), out int numero1))
//    {
//        Console.WriteLine("Error: Debe ingresar un número entero.");
//        continue;
//    }
//    Console.Write("Ingrese el segundo número: ");
//    if (!int.TryParse(Console.ReadLine(), out int numero2))
//    {
//        Console.WriteLine("Error: Debe ingresar un número entero.");
//        continue;
//    }
//    Console.Write("Ingrese el operador (+, -, *, /) o 'q' para salir: ");
//    string entrada = Console.ReadLine();
//    if (entrada.ToLower() == "q")
//    {
//        Console.WriteLine("Saliendo, gracias por utilizar el programaa");
//        break;
//    }
//    string operador = entrada;
//    double resultado = 0;
//    switch (operador)
//    {
//        case "+":
//            resultado = numero1 + numero2;
//            break;
//        case "-":
//            resultado = numero1 - numero2;
//            break;
//        case "*":
//            resultado = numero1 * numero2;
//            break;
//        case "/":
//            if (numero2 != 0)
//            {
//                resultado = (double)numero1 / numero2;
//            }
//            else
//            {
//                Console.WriteLine("Error: No se puede dividir entre cero.");
//                continue;
//            }
//            break;
//        default:
//            Console.WriteLine("Error: Operador no válido.");
//            continue;
//    }
//    Console.WriteLine($"El resultado de la operación es: {resultado}");
//} while (true);

//------------------------------------------------------------------------------------------------------------------------------------------

///* 3. Escribir un programa que imprima una tabla de multiplicar del 1 al 10 para un número introducido por el usuario. */
//int opcion;
//do
//{
//    Console.Write("Ingrese un número o 'q' para salir: ");
//    string entrada = Console.ReadLine();

//    if (entrada.ToLower() == "q")
//    {
//        Console.WriteLine("Saliendo, gracias por utilizar el programa");
//        break;
//    }
//    if (!int.TryParse(entrada, out int numero))
//    {
//        Console.WriteLine("Error: Debe ingresar un número entero.");
//        continue;
//    }
//    Console.WriteLine($"Tabla de multiplicar del {numero}:");
//    for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine($"{numero} x {i} = {numero * i}");
//    }
//} while (true);

//------------------------------------------------------------------------------------------------------------------------------------------

///* 4. Escribir un programa que adivine un número secreto entre 1 y 100.  */
int opcion;
do
{
    Random random = new Random();
    int numeroSecreto = random.Next(1, 101);
    int intentos = 0;
    Console.WriteLine("Bienvenido al juego de adivinar el número secreto.");
    Console.WriteLine("El número secreto está entre 1 y 100.");
    while (true)
    {
        Console.Write("Introduce un número: ");
        if (!int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine("Error: Debes ingresar un número entero.");
            continue;
        }
        intentos++;
        if (numero == numeroSecreto)
        {
            Console.WriteLine($"¡Felicidades! Has adivinado el número secreto {numeroSecreto} en {intentos} intentos.");
            break;
        }
        else if (numero < numeroSecreto)
        {
            Console.WriteLine("El número secreto es mayor.");
        }
        else
        {
            Console.WriteLine("El número secreto es menor.");
        }
    }
    Console.WriteLine("¿Deseas volver a jugar?");
    Console.WriteLine("1. Sí");
    Console.WriteLine("2. No");
    Console.Write("Seleccione una opción: ");
} while (!int.TryParse(Console.ReadLine(), out opcion) || opcion != 2);

