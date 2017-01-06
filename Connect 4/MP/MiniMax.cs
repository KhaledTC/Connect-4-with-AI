using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MP
{
	class MiniMax
	{
		public int OptimalColumn;
		MakeMove Move = new MakeMove();
		public Board GameBoard = new Board();
		public int MaxDepth;

		public int MakeDecision(int Depth, bool Maximize)
		{
			if (GameBoard.CheckWinner(1))
				return (int)1e8 * Depth;
			if (GameBoard.CheckWinner(-1))
				return -(int)1e8 * Depth;
			if (Depth == 0)
				return HeuristicValue((Maximize ? 1 : -1), GameBoard.State);
			if (Maximize)
			{
				int Score = int.MinValue;
				for (int i = 1; i <= 7; i++)
				{
					int Row = Move.IsPossible(i, GameBoard.State);
					if (Row != -1)
					{
						GameBoard.State[Row, i] = 1;
						int Value = MakeDecision(Depth - 1, !Maximize);
						GameBoard.State[Row, i] = 0;
						if (Score < Value)
						{
							Score = Value;
							if (Depth == MaxDepth)
								OptimalColumn = i;
						}
					}
				}
				return Score;
			}
			else
			{
				int Score = int.MaxValue;
				for (int i = 1; i <= 7; i++)
				{
					int Row = Move.IsPossible(i, GameBoard.State);
					if (Row != -1)
					{
						GameBoard.State[Row, i] = -1;
						int Value = MakeDecision(Depth - 1, !Maximize);
						GameBoard.State[Row, i] = 0;
						Score = Math.Min(Score, Value);
					}
				}
				return Score;
			}
		}

		public int HeuristicValue(int Player, int[,] State)
		{
			int[] cnt = new int[15];
			int tmp = 0, Coin = Player;
			for (int x = 1; x <= 6; x++)
			{
				for (int y = 1; y <= 7; y++)
					if (State[x, y] == Coin)
					{
						for (int i = x; i <= 6; i++)
						{
							if (State[i, y] == Coin)
								++tmp;
							else
								break;
						}
						for (int i = x - 1; i >= 1; i--)
						{
							if (State[i, y] == Coin)
								++tmp;
							else
								break;
						}
						++cnt[tmp];
						tmp = 0;
						for (int i = y; i <= 7; i++)
						{
							if (State[x, i] == Coin)
								++tmp;
							else
								break;
						}
						for (int i = y - 1; i >= 1; i--)
						{
							if (State[x, i] == Coin)
								++tmp;
							else
								break;
						}
						++cnt[tmp];
						tmp = 0;
						for (int a = x, b = y; a <= 6 && b <= 7; ++a, ++b)
						{
							if (State[a, b] == Coin)
								++tmp;
							else
								break;
						}
						for (int a = x - 1, b = y - 1; a >= 1 && b >= 1; --a, --b)
						{
							if (State[a, b] == Coin)
								++tmp;
							else
								break;
						}
						++cnt[tmp];
						tmp = 0;
						for (int a = x, b = y; a <= 6 && b >= 1; ++a, --b)
						{
							if (State[a, b] == Coin)
								++tmp;
							else
								break;
						}
						for (int a = x - 1, b = y + 1; a >= 1 && b <= 7; --a, ++b)
						{
							if (State[a, b] == Coin)
								++tmp;
							else
								break;
						}
						++cnt[tmp];
						tmp = 0;
					}
			}
			for (int i = 1; i <= 4; i++)
				cnt[i] = Math.Min(cnt[i], 1);
			return cnt[1] * 10 + cnt[2] * 1000 + cnt[3] * 100000 + cnt[4] * 10000000;
		}
	}
}
