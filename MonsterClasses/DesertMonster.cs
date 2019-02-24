using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public class DesertMonster : Monster
    {
        private string _homeDesert;
        private int _limbs;
        private bool _coldBlood;

        public bool ColdBlood
        {
            get { return _coldBlood; }
            set { _coldBlood = value; }
        }



        public int Limbs
        {
            get { return _limbs; }
            set { _limbs = value; }
        }


        public string HomeDesert
        {
            get { return _homeDesert; }
            set { _homeDesert = value; }
        }


        public override bool IsHappy()
        {
            return true;
        }



        public MonsterAction MonsterBattleResponse()
        {
            Random randomNumber = new Random();
            int battleResponseNumber = randomNumber.Next(0, 101);

            if (battleResponseNumber >= 66)
            {
                return MonsterAction.Attack;
            }
            else if (battleResponseNumber >= 33)
            {
                return MonsterAction.Defend;
            }
            else
            {
                return MonsterAction.Retreat;
            }
        }
    }
}
