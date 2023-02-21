/*
1.ketikkan kode program dibawah ini kemudian simpan dengan nama #NIM anda dan ganti 
"pertama dengan nama lengkap anda"

02.
using System;
using System.Collections.Generic;
class program
{
    static void Main()
    {
        LinkedList<string> link = new LinkedList<string>();

        link.AddLast("honda");
        link.AddLast("yamaha");
        link.AddLast("pria");
        link.AddFirst("pertama");

        foreach(object i in link){
            Console.WriteLine(i);
        }
        Console.ReadKey();
    }
}
*/

// jawab 
using System;
using System.Collections.Generic;
class program
{
    static void Main()
    {
        LinkedList<string> link = new LinkedList<string>();

        link.AddLast("dipta");
        link.AddLast("22051214089");
        link.AddLast("pria");
        link.AddFirst("Pradipta Bagaskara Atmajaya");

        foreach(object i in link){
            Console.WriteLine(i);
        }
        Console.ReadKey();
    }
}