namespace StringInterp {
    class Program {
        static void Main(string[] args) { 
        
        DateTime myDate = DateTime.Parse("2019-01-22 23:01:27");
            var pi = Math.PI;

            Console.WriteLine($"{$"1.{myDate:MMMM} {myDate:dd} {myDate:yyyy}",40:f3}");
            Console.WriteLine($"2.{myDate:yyyy.MM.dd}");
            Console.WriteLine($"3.Day {myDate:dd} of {myDate:MMMM}, {myDate:yyyy}");
            Console.WriteLine($"4.Year:{myDate:yyyy}, Month: {myDate:MM}, Day: {myDate:dd}");
            Console.WriteLine($"5.{myDate,17:dddd}");
            Console.WriteLine($"6.{myDate,10:h:mm tt} {myDate,10:dddd}");
            Console.WriteLine($"7.h:{myDate:hh}, m:{myDate:mm}, s:{myDate:ss}");
            Console.WriteLine($"8.{myDate:yyyy.MM.dd.hh.mm.ss}");

            Console.WriteLine($"1.{pi:C}");
            Console.WriteLine($"2.{pi,10:f3}");
        }
    
    }

}
