using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace four
{
    class Program
    {
        static void Main(string[] args)
        {
            double people_hp = 1000;// хп юнита
            double first_people_damage = 120;// предполагаемый дамаг юнита
            double people_armor = 0.05;// процентная защита юнита
            

            double monster_hp = 1500; // хп монстра
            double first_monster_damage = 80;// урон монстра
            double monster_armor = 0.02;// процентная защита монстра


            double second_people_damage = (first_people_damage - first_people_damage * monster_armor);// урон юнита с учетом защиты монстра
            double second_monster_damage = (first_monster_damage - first_monster_damage * people_armor);// урон монстра с учетом защиты юнита


            Console.WriteLine("игра начинается");
            while (people_hp > 0 && monster_hp > 0) 
            {


                Console.WriteLine($"юнит бьет оставляя монстру {monster_hp -= second_people_damage} здоровья");
                Console.WriteLine($"монстр бьет оставляя юниту {people_hp -= second_monster_damage} здоровья");
                

            }
            Console.WriteLine("ПОБЕДА ЧЕЛОВЕКА");
            Console.ReadKey();
        }
    }
}
