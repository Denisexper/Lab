using System;
using LABORATORY.models.Enums;

Console.WriteLine("**************");
Console.WriteLine("-----MENU-------");

Console.WriteLine("**************");
 Console.WriteLine("--1)  Add book \n");
 Console.WriteLine("--2)  delet book \n");
 Console.WriteLine("--3)  searcg book \n");
 Console.WriteLine("*Ingrese una opcion: \n");

try
{
     var option = Convert.ToInt32(Console.ReadLine());
     switch (option)
     {
        case 1: 
           BookCapture.CreateNewBok();
        break;
        default:
        break;
        
     }
}
catch(Exception ex)
{
    Console.WriteLine("seleccion no disponible ");
    Console.ReadKey();

}

 static class BookCapture
{
    
  public  static Book CreateNewBok()
  {
    
    Console.WriteLine("Ingrese el titulo del libro: ");
    Console.WriteLine("0- Homosapiens");
    Console.WriteLine("1- El_alquimista\n");
    Console.WriteLine("2- El_principito\n");
    Console.WriteLine("3- Los_miserables\n");
    Console.WriteLine("4- Nada\n");
    Console.WriteLine("5- El_coran\n");
     

    try
    {
        var titles =(title)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Igrese el autor \n");
             var autho = Console.ReadLine();

               Console.WriteLine(" Igrese la descripcion del libro\n");
             var description = Console.ReadLine();

                  Console.WriteLine(" Igrese el preci\n");
             var  price = Convert.ToDecimal(Console.ReadLine());

                  Console.WriteLine(" Igrese la categoria\n");
             var category = Console.ReadLine();

       Book book = new(titles, author, description,  price,category);
       return book;
    }
    catch(Exception)
    {
        Console.WriteLine("Titulo no disponible ");
        Console.ReadKey();

    }
  
  }
}


