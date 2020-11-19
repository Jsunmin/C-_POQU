using System;
namespace IntroducingOfProgramming
{
    public class Warrior
    {
        private const int MAX_HEALTH = 500;
        private const int MAX_MANA = 50;
        private const int MAX_STAMINA = 200;

        private int mHealth = MAX_HEALTH;
        private int mMana = MAX_MANA;
        private int mStamina = MAX_STAMINA;

        public Warrior(string name)
        {
            Name = name;
        }
        // Name을 프로퍼티로 세팅
        // 프로퍼티일뿐, Name, get, set은 그 자체로 변수가 아니다.
        // 컴파일 후, 컴파일러가 임의로 만든 멤버변수에 게터 세터 맵핑하는 것!
        public string Name { get; private set; }
        // 헬스 프로퍼티
        public int Health
        {
            get
            {
                return mHealth;
            }
            set
            {
                mHealth = value;
                // 최대최소 처리를 위해 수동 프로퍼티
                if (mHealth < 0)
                {
                    mHealth = 0;
                }

                if (mHealth > MAX_HEALTH)
                {
                    mHealth = MAX_HEALTH;
                }
            }
        }

        public int Mana
        {
            get
            {
                return mMana;
            }
            set
            {
                mMana = value;

                if (mMana < 0)
                {
                    mMana = 0;
                }

                if (mMana > MAX_MANA)
                {
                    mMana = MAX_MANA;
                }
            }
        }

        public int Stamina
        {
            get
            {
                return mStamina;
            }
            set
            {
                mStamina = value;

                if (mStamina < 0)
                {
                    mStamina = 0;
                }

                if (mStamina > MAX_STAMINA)
                {
                    mStamina = MAX_STAMINA;
                }
            }
        }

        public void Introduce()
        {
            Console.WriteLine($"I'm {Name}! Honour and glory!! THIS IS SPARTA!!");
        }

        public void UseWhirlwind()
        {
            if (Mana < 5 || Stamina < 70)
            {
                Console.WriteLine($"{Name} can't use Whirlwind!");
                return;
            }

            Mana -= 5;
            Stamina -= 70;

            Console.WriteLine($"{Name} used Whilrwind!");
        }

        public void SwordStrike()
        {
            if (Stamina < 20)
            {
                Console.WriteLine($"{Name} can't use SwordStrike!");
                return;
            }

            Stamina -= 20;

            Console.WriteLine($"{Name} used SwordStrike!");
        }

        public void Rest()
        {
            Mana += 2;
            Stamina += 5;
            Health += 5;

            Console.WriteLine($"{Name} is resting.");
        }

        public void GetStatus()
        {
            Console.WriteLine($"{Name} - Health: {Health} / Mana: {Mana} / Stamina: {Stamina}");
        }
    }
}