/*
03.ketik program dibawah ini,kemudian ganti kata "satu" dengan nim anda,simpan dengan nama"find nim"

using System;
using System.Collections.Generic;
class program
{
    static void Main()
    {
        LinkedList <string> link = new LinkedList<string>();

        link.AddLast("satu");
        link.AddLast("dua");
        link.AddLast("tiga");

        LinkedListNode<string> node = link.Find("satu");
        link.AddAfter(node,"inserted");

        foreach(var value in link){
            Console.WriteLine(value);
        }
        Console.ReadKey();

    }
}
*/

//jawab
using System;
using System.Collections.Generic;
class program
{
    static void Main()
    {
        LinkedList <string> link = new LinkedList<string>();

        link.AddLast("22051214089");
        link.AddLast("dua");
        link.AddLast("tiga");

        LinkedListNode<string> find_nim = link.Find("22051214089");
        link.AddAfter(find_nim,"inserted");

        foreach(var value in link){
            Console.WriteLine(value);
        }
        Console.ReadKey();

    }
}