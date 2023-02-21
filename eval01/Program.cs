/*
01.tulislah sebuah program unruk membuat list dalam jumlah tertentu sekaligus ini dari
list tersebut berasal dari inputan user 
*/

//jawab 
using System;
using System.Collections.Generic;
class eval02
{
    static void Main()
    {
        int n,nmasuk;
        Console.Write("masukkan jumlah input ke list : ");
        n = int.Parse(Console.ReadLine());

        LinkedList<int> masuk = new LinkedList<int>();
        for (int i = 0; i < n; i++){
            Console.Write("masukkan nilai ke {0} : ",i+1);
            nmasuk = int.Parse(Console.ReadLine());
            masuk.AddLast(nmasuk);
        }
        int p = 0;
        foreach( int i in masuk){
            Console.Write("nilai ke {0} dari input adalah : ", p+1);
            Console.WriteLine(i);
            p++;
        }

    }
}