using System;
namespace IntroducingOfProgramming
{
    public struct CartItem
    {
        // 프로퍼티만 가진 구조체 (원래 구조체 개념(c)에 부합)
        public string Name { get; set; }
        public decimal Price { get; set; }
        public uint Quantity { get; set; }
    }
}
