using InterfaceReview;
namespace interfaceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV(8000.00,"HUAWEI","2024-1-1");
            tv.Run();
            tv.ShowInfo();
        }
    }
    
}
