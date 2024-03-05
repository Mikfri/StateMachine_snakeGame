using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine_snakeGame.Models
{
    public class State_South : IState<char, Move>
    {
        public IState<char, Move> NextStateFunction(char input)
        {
            switch (input)
            {
                //case 'a': return new State1();
                case 'a': return new State_East();
                case 'd': return new State_West();
                default: return new State_South();
            }
        }

        public Move OutputFunction(char input)
        {
            switch (input)
            {
                case 'a': return new Move(0,1);
                case 'd': return new Move(0,-1);
                default: return new Move(-1,0);
            }
        }
    }
}
