using System;
namespace IntroducingOfProgramming
{
    public static class UnitConverter
    {
        public static double GetInchesFromCentimeters(double centimeters)
        {
            return centimeters * 0.393701;
        }
        public static double GetCentimetersFromInches(double inches)
        {
            return inches / 0.393701;
        }
        public static double GetMetersFromCentimeters(double centimeters)
        {
            return centimeters / 100;
        }
        public static double GetFeetFromInches(double inches)
        {
            return inches / 12;
        }
        // 정적 클래스는 생성자 및 정적이 아닌 클래스 멤버를 가질 수 없다!
    }
}
