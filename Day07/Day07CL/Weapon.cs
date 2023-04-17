using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Weapon
    {
        #region Fields (class-level data)
        private int _level;
        private int _maxDamage;
        #endregion

        #region Properies
        //full property: there is a backing field
        public int Level
        {
            //getter (accessor)
            //same as public int GetLevel() {return _level;}
            get
            {
                return _level;
            }

            //setter (mutator)
            //same as public void SetLevel(int value) { _level = value; }
            set
            {
                if (value > 0 && value < 200)
                    _level = value;
            }
        }

        //auto-property: the compiler provides the code and the field
        public int Cost { get; private set; }
        #endregion

        #region Methods
        int DoIt(int damageModifier)
        {
            Random rando = new Random();
            int totalDamage = rando.Next(_maxDamage) * _level + damageModifier;
            return totalDamage;
        }
        #endregion
    }
}
