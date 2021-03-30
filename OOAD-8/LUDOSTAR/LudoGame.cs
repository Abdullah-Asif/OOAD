using System;

namespace LUDOSTAR
{
    public class  LudoGame : IGame, IBoardGame 
    {
        Dice Dice { get; set; }
        List<Piece> Pieces {get; set; }
        BoardPosition BoardPosition { get; set; }
        public void StarGame() {}
        public void EndGame() {}
        public void Winner() {}

    }
}
