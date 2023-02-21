/*
04.ketian program loop list dibawah ini kemudian capture outputan dari program dibawah ini !
*/

//jawab 
using System;
using System.Collections.Generic;
using System.Diagnostics;
class prak4
{
    const int _max = 100000;
    static void Main()
    {
        var list = new List<string>();
        var link = new LinkedList<string>();
        //... add elements
        for(int i = 0; i < 1000; i++){
            list.Add("ok");
            link.AddLast("ok");
        }

        var s1 = Stopwatch.StartNew();
        for ( int i = 0; i < _max; i++){
            foreach( string v in list){
                if(v.Length != 2){
                    throw new Exception();
                }
            }
        }

        s1.Stop();
        var s2 = Stopwatch.StartNew();
        for( int i = 0; i < _max; i++){
            foreach(string v in link){
                if(v.Length != 2){
                    throw new Exception();
                }
            }
        }
        
        Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000)/_max).ToString("0.00 ns"));
        Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000)/_max).ToString("0.00 ns"));
        Console.ReadKey();
    }
}