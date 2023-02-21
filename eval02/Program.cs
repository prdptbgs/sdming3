/*
2.lakukan proses insert dan remove pada salah satu data yang sudah dimasukkan sebelumnya 
,yang diinsert dan diremove berasal dari pilihan user 
*/

//jawab
using System;
using System.Collections.Generic;
class program
{
    static void Main()
    {
        int n;
        string nmasuk;
        List<string> masuk = new List<string>();
        Console.Write("masukkan jumlah input : ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++){
            Console.Write("input ke {0} : ",i+1);
            nmasuk =Convert.ToString(Console.ReadLine());
            masuk.Add(nmasuk);
        }

        string masukan;
        while(true){
            Console.WriteLine("== pilihan ==");
            Console.WriteLine("1.insert");
            Console.WriteLine("2.remove");
            Console.WriteLine("3.enumerator");
            Console.WriteLine("4.keluar");
            Console.Write("masukkan pilihan : ");
            masukan = Convert.ToString(Console.ReadLine());

            switch(masukan){
                case "1" : 
                Console.Write("masukkan input baru : ");
                string baru = Convert.ToString(Console.ReadLine());
                masuk.Add(baru);
                Console.WriteLine("{0} telah dimasukan ", baru);
                break;

                case "2" :
                Console.Write("masukkan yang ingin dihapus : ");
                string hapus = Convert.ToString(Console.ReadLine());
                if(masuk.Remove(hapus)){
                    Console.WriteLine("{0} telah dihapus ", hapus);
                }else{
                    Console.WriteLine("{0} tidak ada dalam list" , hapus);
                }
                break;

                case "3" : 
                foreach( string i in masuk ){
                    Console.WriteLine(i);
                }
                break;

                case "4" :
                Console.WriteLine("telah keluar dari program ");
                return;
            }
        }
    }
}
