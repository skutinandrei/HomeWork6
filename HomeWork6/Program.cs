namespace HomeWork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quadrocopter = new Quadcopter();
            Console.WriteLine(quadrocopter.GetInfo());
            Console.WriteLine(quadrocopter.GetRoboType());
            foreach (var component in quadrocopter.GetComponents())
            {
                Console.WriteLine(component);
            }
            quadrocopter.Charge();
        }
    }
}
