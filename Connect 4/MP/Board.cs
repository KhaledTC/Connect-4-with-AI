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
	class Board
	{
		public int[,] State = new int[7, 8];
		PictureBox Cell;
		public void ColorCell(Form1 obj, int Row, int Column, bool Player)
		{
			int stpx = 68;
			int stpy = 69;
			Cell = new PictureBox();
			Cell.Size = new Size(68, 69);
			string CellPath;
			if (!Player)
				CellPath = Path.Combine(Environment.CurrentDirectory, @"imgs\RED.jpg");
			else
				CellPath = Path.Combine(Environment.CurrentDirectory, @"imgs\YELLOW.jpg");
			Cell.ImageLocation = CellPath;
			Cell.Location = new Point((Column - 1) * (stpx + 1 + 6) + 1 + 4, (Row - 1) * (stpy + 1 + 6) + 1 + 70);
			obj.Controls.Add(Cell);
		}

		public bool CheckWinner(int Player)
		{
			int ret = 0, tmp = 0, Coin = Player;

			for (int x = 1; x <= 6; x++)
			{
				for (int y = 1; y <= 7; y++)
					if (State[x, y] == Coin)
					{
						for (int i = x; i <= 6; i++)
							if (State[i, y] == Coin)
								++tmp;
							else
								break;
						for (int i = x - 1; i >= 1; i--)
							if (State[i, y] == Coin)
								++tmp;
							else
								break;
						ret = Math.Max(ret, tmp);
						tmp = 0;
						for (int i = y; i <= 7; i++)
							if (State[x, i] == Coin)
								++tmp;
							else
								break;
						for (int i = y - 1; i >= 1; i--)
							if (State[x, i] == Coin)
								++tmp;
							else
								break;
						ret = Math.Max(ret, tmp);
						tmp = 0;
						for (int a = x, b = y; a <= 6 && b <= 7; ++a, ++b)
							if (State[a, b] == Coin)
								++tmp;
							else
								break;
						for (int a = x - 1, b = y - 1; a >= 1 && b >= 1; --a, --b)
							if (State[a, b] == Coin)
								++tmp;
							else
								break;
						ret = Math.Max(ret, tmp);
						tmp = 0;
						for (int a = x, b = y; a <= 6 && b >= 1; ++a, --b)
							if (State[a, b] == Coin)
								++tmp;
							else
								break;
						for (int a = x - 1, b = y + 1; a >= 1 && b <= 7; --a, ++b)
							if (State[a, b] == Coin)
								++tmp;
							else
								break;
						ret = Math.Max(ret, tmp);
						tmp = 0;
						if (ret > 3)
							return true;
					}
			}
			return false;
		}

	}
}
