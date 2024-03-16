static void ejemplo()
{
    int[] calificaciones;
    calificaciones = new int[] {85, 77, 68, 94, 75};
    Console.WriteLine(calificaciones[2]);
}
static void ejemplo2()
{
    string[] nombres = new string[3];
    nombres[0] = "Juan";
    nombres[1] = "Ana";
    nombres[2] = "Pedro";

    foreach (string nombre in nombres)
    {
        Console.WriteLine($"Nombre = {nombre}");
    }
}


static void promedios()
{
    int[] notas = {80, 75, 90, 95, 73, 79};
    int suma = 0;
    foreach (int promedio in notas)
    {
        suma = suma + promedio; //Así es como se debe de hacer 
    }
    Console.WriteLine("El promedio es igual a " + suma / 6);
}

static void ejemplo4()
{
    int[] calificaciones = { 85, 92, 77, 68, 94 };
    int suma = 0;
    for (int i = 0; i < calificaciones.Length; i++)
    {
        suma = suma + calificaciones[i];
        Console.WriteLine($"Calificacion {i + 1}: {calificaciones[i]}");
    }
}

static void orden()
{
    int[] notas = { 80, 75, 90, 95, 73, 79 };
    int suma = 0;
    foreach (int nota in notas)
    {
        suma = suma + nota; //Así es como se debe de hacer 
    }
    Console.WriteLine("El promedio es igual a " + (suma / notas.Length));
    Console.WriteLine("Original");
}

static void Ejemplo()
{
    int[] notas = { 80, 75, 90, 95, 73, 79 };
    bool hayAprobados = Array.Exists(notas, calif => calif >= 60);
    Console.WriteLine(hayAprobados);
}

static void Ejercicio()
{
        string[] nombres = {"Juan", "Ana", "Pedro", "Maria", "Andrea"};

        Console.WriteLine("Datos originales:");
        ImprimirArreglo(nombres);

        // Intercambiar el valor en la posición 0 con el valor en la posición 4
        string temp = nombres[0];
        nombres[0] = nombres[4];
        nombres[4] = temp;

        // Imprimir el arreglo después del intercambio
        Console.WriteLine("\nArreglo después del intercambio:");
        ImprimirArreglo(nombres);
    }

    // Método para imprimir el arreglo
    static void ImprimirArreglo(string[] arr)
{
    foreach (string nombre in arr)
    {
        Console.WriteLine(nombre);
    }
}

static void primedio2()
{
    int[] notas = { 80, 75, 90, 95, 73, 79 };
    int[] n2 = new int[notas.Length];
    int i = notas.Length -1;
    foreach(int nota in notas)
    {
        n2[i] = nota;
        Console.WriteLine(n2[i]);
        i--;
    }
}
