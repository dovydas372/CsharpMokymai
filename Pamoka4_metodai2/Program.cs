namespace Pamoka4_metodai2
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //Console.WriteLine("Hello, World!");
        //    //string vardas = "Tomas   ";
        //    //string pavarde = "Tomaitis ";
           
        //    //Console.WriteLine(VardasPavarde(vardas, pavarde, out int simboliai));
        //    //Console.WriteLine($"panaikinti simboliai: {simboliai}");

        //}

        
       //Sukurk funkciją, kuri gauna vardą ir pavardę ir sutvarko juos (pvz. nuima tarpus pradžioje/pabaigoje) taip, kad pakeitimai liktų po iškvietimo.
       //Per out grąžink, kiek simbolių buvo pašalinta, o su return grąžink suformuotą pilną vardą vienoje eilutėje. Po iškvietimo atspausdink rezultatą.

        //static string VardasPavarde(string vardas,string pavarde, out int simboliai)
        //{
       
        //    int vardasLenghtPries = vardas.Length;
          
        //    int vardasLenghtPo = vardas.Trim(" ").Length;

        //    int pavardeLenghtPries = pavarde.Length;
          
        //    int pavardeLenghtPo = pavarde.Trim(" ").Length;

        //    simboliai = (vardasLenghtPries - vardasLenghtPo) + (pavardeLenghtPries - pavardeLenghtPo);

        //    return vardas+pavarde;
        //}

        //Sukurk funkciją, kuri bando paimti iš sandėlio (Dictionary<string,int>) tam tikrą prekės kiekį taip, kad sandėlis po iškvietimo būtų atnaujintas.
        //Per out grąžink, kiek realiai pavyko paimti, o su return grąžink ar pavyko paimti visą prašytą kiekį.

        // tiek ref tiek out, keiciasi i reference tipa taciau ref sako, kad as tau duodu egzistuojanti kintamaji ir tu gali ji pakeisti arba ne
        // out sako, as tau duodu galbut egzistuojant arba neegzistuojanti kintamaji ir tu privalai visais atvejais metodo, suteikti jam reiksme, kad netycia nebutu null

    }
}
