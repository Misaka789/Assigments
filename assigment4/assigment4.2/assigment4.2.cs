namespace assigment4._2
{
    internal class assigemnt4_2
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock(12, 15);
            myClock.OnCall += (sender,args) => { Console.Write("Tick  "); };
            myClock.OnCall += (sender, args) =>
            {
                Clock clock = (Clock)sender;
                //clock.ForEach(t => if (t.equals(clock.GetTime())) { Console.Write("Alarm  "); }); 
                clock.ForEach(t =>
                {
                    if (t.Equals(clock.GetTime()))
                    {
                        Console.Write("Alarm  ");
                    }
                });
            };
                myClock.AddAppointedTime(12, 30);
            int count = 50;
            while (count != 0)
            {
                myClock.Run();
                Console.WriteLine();
                count--;
            }
        }
    }
}
