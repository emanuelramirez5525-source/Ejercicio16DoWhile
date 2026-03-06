// Escriba un programa que pida una contraseña al usuario y continúe solicitándola hasta que sea correcta.

string contraseña;


do
{
    Console.WriteLine("Ingrese la contraseña");
    contraseña = Console.ReadLine();

    if (contraseña == "papitas")
    {
        Console.WriteLine("Contraseña correcta!! Iniciando Sesion");
    }



} while (contraseña != "papitas");