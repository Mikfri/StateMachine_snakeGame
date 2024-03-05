using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine_snakeGame.Models
{
    public class State_West : IState<char, Move>
    {
        public IState<char, Move> NextStateFunction(char input)
        {
            switch (input)
            {
                case 'a': return new State_South();
                case 'd': return new State_North();
                default: return new State_West();
            }
        }

        public Move OutputFunction(char input)
        {
            switch (input)
            {
                case 'a': return new Move(-1,0);    // samme row 0, collumn down -1
                case 'd': return new Move(0,1);     // samme row, Up +1
                default: return new Move(0,-1);     // Vi fortsætter mod venstre row 0, samme collum -1
            }
        }
    }
}
