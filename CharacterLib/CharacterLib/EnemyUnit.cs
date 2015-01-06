using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterLib
{
    public class EnemyUnit
    {
        public List<string> WeaponsKeys = new List<string>();
        public string ActiveWeaponKey;

        public void Turn()
        {
            //ИИ алгоритм, вызываеться на ход этого юнита. Вызывает одно из действий.
        }

        public void Shoot(string Friendlykey) //Ключ цели
        {
            //Проверка на возможность выстрела делаеться вне метода
            //имея ключ используемого оружия, по БД находим урон по формуле.
            //Вызов анимации
            //FriendlyDictionary[FriendlyKey].health -= damage;
        }
        public void Melee(string Friendlykey)
        {
            //Проверка на возможность удара делаеться вне метода
            //Вызов анимации
            //FriendlyDictionary[FriendlyKey].health -= damage;
        }
    }
}
