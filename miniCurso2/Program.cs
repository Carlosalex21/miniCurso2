//Metodos en c#

using System.Numerics;
using System.Reflection.Metadata;

string sNombre = escribeNombre();
string sApellido = escribeApellido();

Console.WriteLine("Mi nombre es: {0}, Mi apellido es: {1}", sNombre, sApellido);

int lhs = 5;
int rhs = 0;

int suma = SumaValores(lhs, rhs);
int resta = restaValores(lhs, rhs);
int multiplicacion = multiplicaValores(lhs, rhs);
calculaDivision(lhs, rhs);
calculaDivisionCero(lhs, rhs);
int division = divideValores(lhs, rhs);

Console.WriteLine("El resultado de la suma es: {0}", suma);
Console.WriteLine("El resultado de la resta es: {0}", resta);
Console.WriteLine("El resultado de la multiplicacion es: {0}", multiplicacion);
Console.WriteLine("El resultado de la division es: {0}", division);

string escribeNombre()
{
    string nombre = "Carlos";
    return nombre;
}

string escribeApellido()
{
    string apellido = "Barrientos";
    return apellido;
}

int SumaValores(int lhs, int rhs)
{
    int ths = lhs + rhs;
    return ths;
}

int restaValores(int lhs, int rhs)
{
    int ths = lhs - rhs;
    return ths;
}

int multiplicaValores(int lhs, int rhs)
{
    int ths = lhs * rhs;
    return ths;
}

int divideValores(int lhs, int rhs)
{
    int ths = lhs / rhs;
    return ths;
}

int calculaDivision(int lhs, int rhs)
{
    int ths = 0;

    try
    {
        ths = lhs / rhs;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ha aparecido un error: {0}", ex.Message);
        Console.Read();
    }

    return ths;
}

int calculaDivisionCero(int lhs, int rhs)
{
    int ths = 0;

    try
    {
        ths = lhs / rhs;
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Ha aparecido un error de formato: {0}", ex.Message);
        Console.Read();
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Ha aparecido un error de calculo: {0}", ex.Message);
        Console.Read();
    }
    return ths;
}

//colecciones de datos: vectores o arrays

string[] texto = new string[4];
texto[0] = "texto 1";
texto[1] = "texto 2";
texto[2] = "texto 3";
texto[3] = "texto 4";

for (int i = 0; i < texto.Length; i++)
{
    Console.WriteLine("Posicion " + i + ":" + texto[i]);
}

int[] air = new int[4];
int[,] airm = new int[2, 3];

string[,] matriz = new string[2, 3];

for (int i = 0; i < matriz.Rank; i++)
{
    Console.WriteLine("Longitud de la dimension " + i + ": " + matriz.GetLength(i));
}

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        matriz[i, j] = (i + j).ToString();
        Console.WriteLine(matriz[i, j]);
    }
}

Console.Read();

//Ejercicio 1: realizar un programa que sume dos vectores y los almacene en un tercer vector


int[] Vector1 = new int[4];
Console.WriteLine("Por favor coloque el valor de la posicion 0 del 1er Vector: ");
Vector1[0] = int.Parse(Console.ReadLine());

Console.WriteLine("Por favor coloque el valor de la posicion 1 del 1er Vector: ");
Vector1[1] = int.Parse(Console.ReadLine());

Console.WriteLine("Por favor coloque el valor de la posicion 2 del 1er Vector: ");
Vector1[2] = int.Parse(Console.ReadLine());

Console.WriteLine("Por favor coloque el valor de la posicion 3 del 1er Vector: ");
Vector1[3] = int.Parse(Console.ReadLine());


int[] Vector2 = new int[4];
Console.WriteLine("Por favor coloque el valor de la posicion 0 del 2do Vector: ");
Vector2[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Por favor coloque el valor de la posicion 1 del 2do Vector: ");

Vector2[1] = int.Parse(Console.ReadLine());
Console.WriteLine("Por favor coloque el valor de la posicion 2 del 2do Vector: ");

Vector2[2] = int.Parse(Console.ReadLine());
Console.WriteLine("Por favor coloque el valor de la posicion 3 del 2do Vector: ");

Vector2[3] = int.Parse(Console.ReadLine()); 

int[] Vector3 = new int[4];
Vector3[0] = Vector1[0] + Vector2[0];
Vector3[1] = Vector1[1] + Vector2[1];
Vector3[2] = Vector1[2] + Vector2[2];
Vector3[3] = Vector1[3] + Vector2[3];
Console.WriteLine($"El valor de la suma es: {Vector3[0]}, {Vector3[1]}, {Vector3[2]}, {Vector3[3]}");

Vector3[0] = Vector1[0] - Vector2[0];
Vector3[1] = Vector1[1] - Vector2[1];
Vector3[2] = Vector1[2] - Vector2[2];
Vector3[3] = Vector1[3] - Vector2[3];
Console.WriteLine($"El valor de la resta es: {Vector3[0]}, {Vector3[1]}, {Vector3[2]}, {Vector3[3]}");

Vector3[0] = Vector1[0] * Vector2[0];
Vector3[1] = Vector1[1] * Vector2[1];
Vector3[2] = Vector1[2] * Vector2[2];
Vector3[3] = Vector1[3] * Vector2[3];
Console.WriteLine($"El valor de la multiplicacion es: {Vector3[0]}, {Vector3[1]}, {Vector3[2]}, {Vector3[3]}");

Vector3[0] = Vector1[0] / Vector2[0];
Vector3[1] = Vector1[1] / Vector2[1];
Vector3[2] = Vector1[2] / Vector2[2];
Vector3[3] = Vector1[3] / Vector2[3];
Console.WriteLine($"El valor de la division es: {Vector3[0]}, {Vector3[1]}, {Vector3[2]}, {Vector3[3]}");












