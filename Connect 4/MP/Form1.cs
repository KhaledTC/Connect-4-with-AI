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
	public partial class Form1 : Form
	{
		Board GameBoard = new Board();
		List<Tuple<int, int>> PositionsOnX = new List<Tuple<int, int>>();
		MakeMove Move = new MakeMove();
		int cnt = 21, Row, Column, difficulty;
		PictureBox Cell;
		bool GameStarted = false;

		public Form1()
		{
			InitializeComponent();
			this.BackColor = Color.SteelBlue;
			RadioEasy.Checked = true;
			difficulty = 3;
		}

		private void Connect4_Paint(object sender, PaintEventArgs e)
		{
			InitializeBoard(e);
		}

		private void Start_Click(object sender, EventArgs e)
		{
			if (GameStarted)
				return;
			if (PlayerName.Text.Length == 0)
			{
				MessageBox.Show("Please enter your name");
				return;
			}
			if (RadioMedium.Checked)
				difficulty = 4;
			else if (RadioHard.Checked)
				difficulty = 5;
			else if (RadioExpert.Checked)
				difficulty = 6;
			if (RadioComputer.Checked)
			{
				if (difficulty < 5)
					Column = Move.PCMove(difficulty, GameBoard.State);
				else
					Column = 4;
				Row = Move.IsPossible(Column, GameBoard.State);
				GameBoard.State[Row, Column] = 1;
				GameBoard.ColorCell(this, Row, Column, true);
			}
			GameStarted = true;
		}

		private void Hint_Click(object sender, EventArgs e)
		{
			Column = Move.PCMove(difficulty, GameBoard.State);
			if (Column < 0)
				return;
			if (!GameStarted)
			{
				MessageBox.Show("Start the game first");
				return;
			}
			MessageBox.Show("Column number " + Column.ToString());
		}

		void InitializeBoard(PaintEventArgs e)
		{
			SolidBrush p = new SolidBrush(Color.Black);
			int stpx = 68, x;
			int stpy = 69, y = 1;
			for (int i = 0; i < 6; i++)
			{
				x = 4;
				for (int j = 0; j < 7; j++)
				{
					e.Graphics.FillEllipse(p, x, y + 70, stpx, stpy);
					if (i == 0)
						PositionsOnX.Add(new Tuple<int, int>(x, x + stpx));
					x += stpx + 1 + 6;
				}
				y += stpy + 1 + 6;
			}
		}

		private void Connect4_MouseClick(object sender, MouseEventArgs e)
		{
			Column = Move.PlayerMove(e.X, PositionsOnX);
			if (Column < 0)
				return;
			if (!GameStarted)
			{
				MessageBox.Show("Click Start button");
				return;
			}
			if (GameBoard.State[1, Column] != 0)
			{
				MessageBox.Show("Column is full");
				return;
			}
			--cnt;

			Row = Move.IsPossible(Column, GameBoard.State);
			GameBoard.State[Row, Column] = -1;
			GameBoard.ColorCell(this, Row, Column, false);

			if (GameBoard.CheckWinner(-1))
			{
				MessageBox.Show("You Win! :/");
				SaveResult(1, 0);
				Application.Exit();
			}

			Column = Move.PCMove(difficulty, GameBoard.State);
			Row = Move.IsPossible(Column, GameBoard.State);
			GameBoard.State[Row, Column] = 1;
			GameBoard.ColorCell(this, Row, Column, true);

			if (GameBoard.CheckWinner(1))
			{
				MessageBox.Show("You lost ^^");
				SaveResult(0, 1);
				Application.Exit();
			}

			if (cnt == 0)
			{
				MessageBox.Show("Draw");
				SaveResult(0, 0);
				Application.Exit();
			}
		}

		void SaveResult(int Player, int Computer)
		{
			using (StreamWriter w = new StreamWriter(Environment.CurrentDirectory + @"\log.txt", true))
			{
				if (Player < Computer)
					w.WriteLine("Computer have beated player " + PlayerName.Text + ", score = [1, 0] to the Computer.");
				else if (Player > Computer)
					w.WriteLine("Player " + PlayerName.Text + " have beated the computer, score = [1, 0] to " + PlayerName.Text + ".");
				else
					w.WriteLine("Draw [0, 0].");
			}
		}

	}
}
