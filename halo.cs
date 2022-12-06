using System;

namespace halo
{
    public class XinChao
    {
        static public void Hello()
        {
            Console.WriteLine("Hello! c# here");
        }
        
        static public int SoLon(int num1 = 1, int num2 = 2)
        {
            int max = num1 > num2 ? num1 : num2;
            return max;
        }
    }

    public class Student
    {
        private string name;

        public string Name 
        {
            set 
            {
                Console.WriteLine("Ghi dữ liêu <---" + value);
                name = value;
            }

            get
            {
                return "Tên là : " + name + "nmmn";
            }
        }
    }

}