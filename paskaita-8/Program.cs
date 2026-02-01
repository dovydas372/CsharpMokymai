using System.Diagnostics;
using System.Text;

namespace paskaita_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pasidaryti list su tuple kintamaisiais ir kad juos pridėtu 

            // neradau jokio Tuple metodo pridėti kintamajam.

            var toupleNew = (5, 7, 3);
            var touple = Tuple.Create(5, 7, 3);

             string stringas = "";
            //var stringBuild = new StringBuilder();   <--string builderis 
            var stopWatch = Stopwatch.StartNew();
            var i = 0;
            while (i < 500000) {
                i++;
                touple.add(1);
              
            };
           
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);

            //foreach (var touple in toupleNew)
            //{ Console.WriteLine(touple); };

            ////toupleNew.Item1;
            //touple.Item2 = 1;
            Console.WriteLine(touple.Item2);
           

        }
    }
}
