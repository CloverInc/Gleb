using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterLib
{
    public class PlayerUnit : DefaultCharacter
    {

        #region -- Stats --
        //Не считая наследующихся статов: здоровья, коэф. инициативы

        private double accuracy; //Поднимаеться количеством убитых противников на среднем и дальнем расстоянии
        public double Accuracy
        {
            get { return accuracy; }
            set { accuracy = value; }
        }

        private int concealment; //Зависит от навыков класса и снаряжения
        public int Concealment
        {
            get { return concealment; }
            set { concealment = value; }
        }

        private int leadership; //Я подумал, что можно перед каждой миссией выбирать командира отряда. Такой опыт будет повышать этот стат. 
        //Командиры поднимают разные статы отряда в зависимости от своей специализации и уровня лидерства.
        public int Leadership
        {
            get { return leadership; }
            set { leadership = value; }
        }

        #endregion


        public List<string> WeaponsKeys = new List<string>();
        public string ActiveWeaponKey;
        public string EquipmentKey; //Ключ, по которому будет определяться какое снаряжение доступно юниту для использования. Скорее всего это набор ключей итемов через какой-то разделитель.

        public void Shoot(string Enemykey) //Ключ цели
        {
            //Проверка на возможность выстрела делаеться вне метода
            //имея ключ используемого оружия, по БД находим урон по формуле.
            //Вызов анимации
            //EnemyDictionary[EnemyKey].health -= damage;
        }
        public void Melee(string Enemykey)
        {
            //Проверка на возможность удара делаеться вне метода
            //Вызов анимации
            //EnemyDictionary[EnemyKey].health -= damage;
        }


        //Чтобы не загромождать библиотеку, я пока-что опишу наследственные классы тут:
        //Gunman. Наследственные: Assault (средняя скорость, средняя броня), Heavy (низкая скорость, высокая броня)
        //Agent. Наследственные: Scout (высокая скорость, низкая/средняя броня), Ghost (средняя скорость, низкая броня)
        //Support. Наследственные: Healer(средняя скорость, низкая/средняя броня), Engineer (средняя скорость, средняя/высокая броня), Sniper (средняя скорость, низкая/средняя броня)


    }
}
