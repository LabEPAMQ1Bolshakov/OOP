using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Women
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Short stories about women\n");

            StudentGirl student = new StudentGirl();
            Console.WriteLine("A Student\n");
            student.SetParam();
            Console.Write("\n");
            student.TellBasicInfo();
            student.ChangeColorOfHair("black","last Sunday");
            student.Eat();
            student.Duty();
            student.Like();
            Console.Write("\n\n");

            BusinessWoman bwoman = new BusinessWoman();
            Console.WriteLine("A Businesswoman\n");
            bwoman.SetParam();
            Console.Write("\n");
            bwoman.TellBasicInfo();
            bwoman.ChangeColorOfHair("dark", "two weeks ago");
            bwoman.Eat();
            bwoman.Duty();
            bwoman.Like();
            Console.Write("\n\n");

            HouseWife houseWife = new HouseWife();
            Console.WriteLine("A Housewife\n");
            houseWife.SetParam();
            Console.Write("\n");
            houseWife.TellBasicInfo();
            houseWife.ChangeColorOfHair("gray", "yesterday");
            houseWife.Eat();
            houseWife.Duty();
            houseWife.Like();
            Console.Write("\n\n");

            LittleGirl littleGirl = new LittleGirl();
            Console.WriteLine("A little Girl\n");
            littleGirl.SetParam();
            Console.Write("\n");
            littleGirl.TellBasicInfo();
            littleGirl.ChangeColorOfHair("black", "last Sunday");
            littleGirl.Eat();
            littleGirl.Duty();
            littleGirl.Like();
                        
            Console.ReadKey();
            
        }
    }
}
