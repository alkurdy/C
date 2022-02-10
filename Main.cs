using System;
//using actors;
using word;
class Program
{
           static void Main(string[] args)
        {
            /*actor newObj = new actor(10,100,"Kurdyukov","Aleksey",DateTime.Now);*/
            DateTime bday = new DateTime(1988, 09, 05);
            Console.WriteLine(DateTime.Now.Year);
            noun newObj = new noun("cat");
            Console.WriteLine(newObj.wordValue);
            Console.WriteLine(newObj);
            newObj.wordValue = "dog";
            Console.WriteLine(newObj.wordValue);
        }
}