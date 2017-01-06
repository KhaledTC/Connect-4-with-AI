using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP
{
	class MakeMove
	{
		public int PlayerMove(int x, List<Tuple<int, int>> PositionsOnX)
		{
			for (int i = 0; i < 7; i++) if (x >= PositionsOnX[i].Item1 && x <= PositionsOnX[i].Item2)
					return i + 1;
			return -1;
		}

		public int PCMove(int Depth, int[,] GameBoard)
		{
			MiniMax Game = new MiniMax();
			Game.GameBoard.State = GameBoard;
			Game.MaxDepth = Depth;
			Game.MakeDecision(Depth, true);
			return Game.OptimalColumn;
		}

		public int IsPossible(int Column, int[,] GameBoard)
		{
			for (int i = 6; i > 0; i--)
				if (GameBoard[i, Column] == 0)
					return i;
			return -1;
		}
	}
}
