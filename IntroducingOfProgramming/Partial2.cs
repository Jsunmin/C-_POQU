using System;
namespace IntroducingOfProgramming
{
    public partial class Partial1
    {
        // 생성자는 한 곳에서만 정의! ( 컴파일 에러 발생 )
        //public Partial1(string name)
        //{
        //    Name = name;
        //}
        // 동명 함수도 마찬가지 
        //public string Name { get; private set; }
        //public void ShootLaserBeam()
        //{
        //    Console.WriteLine($"{Name} shooting laser beam!");
        //}
        public void Nuke()
        {
            Console.WriteLine($"{Name} Nuke launch detected!");
        }

    }
}
