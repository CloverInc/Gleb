using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterLib
{
    public class DefaultCharacter
    {
        public DefaultCharacter(string charName)
        {
            Key = Guid.NewGuid().ToString();
            Name = charName;
            Health = 50;
            status = 0;
            
        }

        #region -- PrivateFields --

        private string name;
        public int charKoef; //уровень инициативы
        private int health;
        private int xcoord, ycoord, zcoord;
        private bool covered = false;

        #endregion

        #region -- PublicFields --

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Key; //Для идентификации в таблицах и словарях. Генерируеться случайно.
        public int status; //Указывает на состояние. 0 - жив. 1 - мертв. Персонажи со статусом 1 по окончанию уровня удаляються из списка юнитов. Я не использую bool, так как позже может сделаем еще "критическое" состояние.
        public int Health
        {
            get { return health; }
            set 
            {
                if (health <= 0)
                    { status = 1; health = 0; }
                else
                    health = value; 
            }
        }

        public int CharKoef
        {
            get { return charKoef; }
            set { charKoef = value; }
        }

        public int Xcoord
        {
            get { return xcoord; }
            set { xcoord = value; }
        }
        public int Ycoord
        {
            get { return ycoord; }
            set { ycoord = value; }
        }
        public int Zcoord
        {
            get { return zcoord; }
            set { zcoord = value; }
        }

        public bool Covered
        {
            get { return covered; }
            set { covered = value; }
        }

        #endregion

        #region -- PublicMethods --

        public void Moving(int newX, int newY, int newZ)
        {
            //В методах, которые отвечают за действия не нужна проверка на то, жив ли юнит. Мертвые будут исключаться из самой линейки инициативы и будут недоступны для хода. А картинку просто заменим другой.

            //Нужен код для расчета маршрута. 
            //Вызов анимации
            covered = false;
            xcoord = newX;
            ycoord = newY;
            zcoord = newZ; 
            //Проверка: если стена рядом -> Covering();
        }
        public void Covering()
        {
            //Вызов анимации
            covered = true;      
        }

        #endregion
    }
}
