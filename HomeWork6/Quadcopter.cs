namespace HomeWork6
{
    internal class Quadcopter : IFlyingRobot, IChargeable
    {
        List<string> _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };

        public List<string> GetComponents()
        {
            return _components;
        }

        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3_000);
            Console.WriteLine("Charged");
        }

        public string GetInfo()
        {
            return "This is base model of Quadcopter";
        }

        public string GetRoboType()
        {
            return "I am a quadrocopter robot.";
        }
    }
}
