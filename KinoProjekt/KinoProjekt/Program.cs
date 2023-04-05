using KinoProjekt.Data;
using KinoProjekt.Model;

using AppDbContext context = new AppDbContext();

string CustomPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\test.txt";

//Klient klient1 = new Klient("Kamil", "Szewczyk", "2002xTest", "Mezczyzna", "123", "kamil@gmail.com", "123321213", KinoProjekt.Data.Wojewodztwa.łódzkie,
//               "Radomsko", "Radomska", "12", "10", "97-500", true, false);
//Bilet bilet1 = new Bilet(1,"Maciej","Tomczyk",2,1);
Klient testKlient = new Klient(0.0, "Maciej", "Taklinski", "06.07.2002", "Mezczyzna", "mactek123", "macius2002@gmail.com", "213654897", Wojewodztwa.mazowieckie
        , "Warszawa", "Szkona", "13", "10", "98-506", true, false);

Console.WriteLine("Start");

//context.DbBilet.Add(bilet1);
//context.DbKlient.Add(testKlient);
//context.SaveChanges();

Console.WriteLine(CustomPath);
using (StreamWriter sw = File.CreateText(CustomPath))
Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
Console.WriteLine(context.TestString());
Console.WriteLine("Done"); 




 Console.ReadLine();