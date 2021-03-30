using System;

namespace LUDOSTAR
{
    public interface IBoardGame
    {
       Dice Dice {get; set; }
       List<Piece> Pieces {get; set; }
       BoardPosition BoardPosition { get; set; }
       
    }
}
