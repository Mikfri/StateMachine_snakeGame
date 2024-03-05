using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine_snakeGame.Models
{
    public class State_East : IState<char, Move>
    {

        public IState<char, Move> NextStateFunction(char input)
        {
            switch (input)
            {
                case 'a': return new State_North();
                case 'd': return new State_South();
                default: return new State_East(); //w
            }
        }

        public Move OutputFunction(char input)
        {
            switch (input)
            {
                case 'a': return new Move(1, 0);    // 1 row op! samme collum
                case 'd': return new Move(-1, 0);   // vi går 1 row ned, samme collum
                default: return new Move(0, 1);     // samme row, 1 feldt til højre
            }
        }

    }
}
