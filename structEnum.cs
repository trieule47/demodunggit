using System;
//trieu
// hello
// TrieuLe47 merge
// commit to revert

namespace Products
{
   public class Products
   {
      static public void Print(string a)
      {
         Product hang1 = new Product("Ghế", 200);
         Console.WriteLine($"Hello! c# here $a {hang1.ToString()}");

         // Category hang2 = new Category("Trieu");
         // Console.WriteLine($"Hello! c# here $a {hang2.Name()}");
         
         TestEnum();
         Console.WriteLine("Hello mấy C#");

      }

      public struct Product {
         public Product( string _name, double _price) {
            name = _name;
            price = _price;
         }

         private string name;
         private double price;
         public string ToString() => $"{name} : {price}$";
      }

      public struct Category
      {
         public Category(string _name)
         {
            name = _name;
         }

         private string name;

         public string Name {
            set => name = value;
            get => name;
         }
      }

      enum HocLuc{Kem ,TrungBinh=5, Kha, Gioi};

      static public void TestEnum(){
         HocLuc hl_hocSinhA = HocLuc.Kem;

         switch(hl_hocSinhA) 
         {
            case HocLuc.Kem: 
               Console.WriteLine("Học Lực Kém");
               break;
            case HocLuc.Kha: 
               Console.WriteLine("Hoc Lực khá");
               break;
            case HocLuc.TrungBinh: 
               Console.WriteLine("Hoc Lực khá");
               break;   
            default: 
               Console.WriteLine("Hoc Lực giỏi");
               break;
         }
      }   
   }
}
