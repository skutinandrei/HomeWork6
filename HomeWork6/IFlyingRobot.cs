namespace HomeWork6
{
    internal interface IFlyingRobot : IRobot
    {
        new string GetRobotType()
        {
            return "I am a flying robot.";
        }
    }
}
