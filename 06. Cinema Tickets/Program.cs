namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int untakenSits;
            string ticketType;
            int studentCount = 0;
            int standartCount = 0;
            int kidCount = 0;
            int totalCount = 0;
            
            while (input != "Finish")
            {
                untakenSits = int.Parse(Console.ReadLine());
                ticketType = Console.ReadLine();
                totalCount = 0;
                while (ticketType != "End")
                {
                   
                     
                    if (ticketType == "student")
                    {
                        studentCount++;
                        
                    }
                    else if (ticketType == "standard")
                    {
                        standartCount++;
                        
                    }
                    else if (ticketType == "kid")
                    {
                        kidCount++;
                        
                    }
                    totalCount++;
                   
                    if (totalCount >= untakenSits)
                    {
                        break;
                    }
                     ticketType = Console.ReadLine();
                    
                    
                    
                }
                Console.WriteLine($"{input} - {totalCount / (double)untakenSits * 100:f2}% full.");
                input = Console.ReadLine();
                
                
               

            }
            Console.WriteLine($"Total tickets: {standartCount + kidCount + studentCount}");
            Console.WriteLine($"{(double)studentCount / (standartCount + kidCount + studentCount) * 100:f2}% student tickets.");
            Console.WriteLine($"{(double)standartCount / (standartCount + kidCount + studentCount) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(double)kidCount / (standartCount + kidCount + studentCount) * 100:f2}% kids tickets.");

        }
    }
}
