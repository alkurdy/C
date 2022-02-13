using System;
//using actors;
using word;
using Wordsmith;
class Program
{
           static void Main(string[] args)
        {
            /*actor newObj = new actor(10,100,"Kurdyukov","Aleksey",DateTime.Now);*/
            DateTime bday = new DateTime(1988, 09, 05);
            Console.WriteLine(DateTime.Now.Year);
            Noun newObj = new Noun("cat");
            Console.WriteLine(newObj.wordValue);
            Console.WriteLine(newObj.getpartOfSpeech);
            newObj.wordValue = "dog";
            Console.WriteLine(newObj.wordValue);
            Word newWord = new Word();
            Console.WriteLine(newWord.capitalizeWord("i"));

            
        }
}