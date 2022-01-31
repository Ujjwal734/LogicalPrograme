// See https://aka.ms/new-console-template for more information
using LogicalPrograme;
Console.WriteLine("Hello, Welcome to Logical Programe...! ");
Console.WriteLine("1. Fibonaccci Series \n2. Perfect Number \n3. Prime Number \n4. Reverse Number \n5. Exit");
int option = Convert.ToInt32(Console.ReadLine());
bool flag = true;
while(true)
{
    
    switch(option)
    {
        case 1:
            FibonacSeries fibonacSeries = new FibonacSeries();
            Console.WriteLine("Enter a number upto where you want to print fibbnoci series: ");
            fibonacSeries.number = Convert.ToInt32(Console.ReadLine());
            fibonacSeries.Fibb();
            flag = false;
            break;
        case 2:
            Perfect perfect = new Perfect();
            perfect.Series();
            break;
        case 3:
            Prime prime = new Prime();
            Console.WriteLine("Enter a number to check Prime Number or Not...");
            prime.Prim();
            break;
        case 4:
            Reverse reverse = new Reverse();
            Console.WriteLine("Enter a number To print its reverse...");
            reverse.Series();
            break;
        case 5:
            flag = false;
            break;
    }
}
