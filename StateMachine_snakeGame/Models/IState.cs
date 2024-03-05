using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine_snakeGame.Models
{
    public enum InputType
    {
        forward,
        left,
        right
    }

    public interface IState<Tin, Tout>
    {
        IState<Tin, Tout> NextStateFunction(Tin input);
        Tout OutputFunction(Tin input);
    }

    public record Move(int row, int collum);
}
