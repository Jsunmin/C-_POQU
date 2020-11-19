using System;
namespace IntroducingOfProgramming
{
    public partial class Partial1
    {
        public Partial1( string name )
        {
            Name = name;
        }
        public string Name { get; private set; }
        public void ShootLaserBeam()
        {
            Console.WriteLine($"{Name} shooting laser beam!");
        }
        public void ShootMissiles()
        {
            Console.WriteLine($"{Name} shooting missiles!");
        }

    }
}
