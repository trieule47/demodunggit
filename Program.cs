// See https://aka.ms/new-console-template for more information
using System;
// using halo;
using Products;

namespace CSHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xin chào C# đây");

            int so = 1;
            double pi = 3.14;
            char chooseAction = 'S';
            string msg = "this is my house";

            Console.WriteLine("so: {0}" , so);
            Console.WriteLine("pi: {0}" , pi);
            Console.WriteLine("char: {0}" , chooseAction);
            Console.WriteLine("string: {0}" , msg);
            Console.WriteLine("so: {0}, pi: {1}", so, pi );

            int a = 123;
            double b = 567.123;

            Console.WriteLine("Biến a = {0}, biến b = {1}", a, b);

            int a1 = 123;
            // double b1= 321.31;
            // Console.WriteLine($"Biến a = {a1}, Biển b = {b1} - Tích là {a1*b1}");
            
            // //nhập dữ liệu
            // string key;
            // int key1;
            // double key2;

            // key = Console.ReadLine();
            // Console.Write("hello {0}\n", key);
            // key1 = Convert.ToInt32(key);
            // Console.Write($"hello {key1*2}");

            // // biến var, hằng const

            // // toán tử

            // if(key1 > 10)
            // {
            //     Console.WriteLine("số nhập vào lớn hơn 10!");
            // }
            // else
            // {
            //     Console.WriteLine("số nhập vào nhở hon 10!");
            // }

            // // mảng
            // var bienMang = new string[5];
            // int[] soMang = {1,3,5,7,8};
            // int[] soMang2 = new int[5]{1,2,5,6,7};

            // Console.WriteLine("============các phần tử trong mảng=========");
            // foreach (var item in soMang2)
            // {
            //     Console.WriteLine(item);
            // }

            // for( var i = 0 ; i< 5 ; i++)
            // {
            //     bienMang[i] = Console.ReadLine();
            // }

            // Console.WriteLine($"==========Mảng mới nhập vào=============== length{bienMang.Length}");
            // for( var i = 0 ; i< 5 ; i++){
            //     Console.WriteLine(bienMang[i]);
            // }

            Console.WriteLine(BinhPhuong(2));
            Console.WriteLine(halo.XinChao.SoLon(12,3));
            var s = new halo.Student();
            s.Name = "Trieu";

            Console.WriteLine(s.Name);
            Products.Products.Print("abc");

        }

        /// tính bình phương số thực
        static double BinhPhuong(double number){
            double ketqua = number*number;
            halo.XinChao.Hello();
            return ketqua;
        }
    }
}
// Console.WriteLine("halo");