using System;

namespace oop_6115261025_w05
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Building b4 = new Building("4", "computer", "452", "365");
            Room r431 = new Room("431", "434", "4", "4", "computer", b4);
            Subject sub001 = new Subject("001", "programming", "3", "2", "5");
            Lecturer l001 = new Lecturer("001", "TAT", "CHI", "professor");
            Section sec01 = new Section("01", "Sunday", "8.00AM", "12.00PM", r431, sub001, l001);
            Console.WriteLine(sec01);
        }
    }
}
