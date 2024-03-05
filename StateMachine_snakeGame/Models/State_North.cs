using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine_snakeGame.Models
{
    public class State_North : IState<char, Move>
    {
        
        public IState<char, Move> NextStateFunction(char input)
        {
            switch (input)
            {
                //case 'a': return new State1();
                case 'a': return new State_West();
                case 'd': return new State_East();
                default: return new State_North();
            }
        }

        public Move OutputFunction(char input)
        {
            switch (input)
            {
                case 'a': return new Move(0,-1);    // bliver i samme row. 1 collum til venstre (-1)
                case 'd': return new Move(0,1);     // samme row, 1 collum til højre (+1)
                default: return new Move(1,0);      // 1 row op, vi går ikke højre/venstre 
            }
        }
    }
}
