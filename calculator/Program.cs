// Calculadora
int suma, resta, multiplicacion, division;
Console.WriteLine("Coloca el primer numero:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Coloca el segundo numero:");
int num2 = int.Parse(Console.ReadLine());
suma = num1 + num2;
resta = num1 - num2;
multiplicacion = num1 * num2;
division = num1 / num2;
Console.WriteLine("El resultado de la suma es:" + suma);
Console.WriteLine("El resultado de la resta es:" + resta);
Console.WriteLine("El resultado de la multiplicacion es:" + multiplicacion);
Console.WriteLine("El resultado de la division es:" + division);
Console.ReadKey();