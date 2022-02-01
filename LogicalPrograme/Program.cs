using LogicalPrograme;

Console.WriteLine("Hello, Welcome to Logical Programe...! ");
Console.WriteLine("1. Fibonaccci Series \n2. Perfect Number \n3. Prime Number \n4. Reverse Number \n5. Coupan Number \n6. Use Stopwatch");
int option = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Press S to start and N to stop ");
char ch = Convert.ToChar(Console.ReadLine());
bool flag = true;
while(ch != 'N')
{
    switch (option)
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
            Coupan coupan = new Coupan();
            coupan.Code();
            break;
        case 6:
            CustomStopwatch customstopwatch = new CustomStopwatch();
            customstopwatch.Start();
            Console.WriteLine("Enter after how much second you want to stop ");
            int tie = Convert.ToInt32(Console.ReadLine()); 
            Thread.Sleep(tie*1000);
            customstopwatch.Stop();
            Console.WriteLine("Stopwatch elapsed: {0}, StartAt: {1}, EndAt: {2}", customstopwatch.ElapsedMilliseconds, customstopwatch.StartAt.Value, customstopwatch.EndAt.Value);
            break;
        default:
            Console.WriteLine("Enter valid given option :-");
            break;
    }
    Console.WriteLine("please enter N to stop your programe or press any key to do programe...!");
    ch = Convert.ToChar(Console.ReadLine());
}
