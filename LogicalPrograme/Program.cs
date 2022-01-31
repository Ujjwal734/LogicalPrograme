// See https://aka.ms/new-console-template for more information
using LogicalPrograme;
Console.WriteLine("Hello, Welcome to Logical Programe...! ");
Console.WriteLine("1. Fibonaccci Series \n2. Exit");
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
            flag = false;
            break;
    }
}
