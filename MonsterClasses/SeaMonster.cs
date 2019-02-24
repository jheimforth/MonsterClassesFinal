using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public class SeaMonster : Monster
    {

        private string _homeSea;
        private bool _hasGills;

        public bool HasGills
        {
            get { return _hasGills; }
            set { _hasGills = value; }
        }

        public string HomeSea
        {
            get { return _homeSea; }
            set { _homeSea = value; }
        }

        public override bool IsHappy()
        {
            //if (_hasGills)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return _hasGills ? true : false;
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
