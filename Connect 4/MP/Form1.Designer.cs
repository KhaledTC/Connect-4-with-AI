namespace MP
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.RadioPlayer = new System.Windows.Forms.RadioButton();
			this.RadioComputer = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.RadioExpert = new System.Windows.Forms.RadioButton();
			this.RadioEasy = new System.Windows.Forms.RadioButton();
			this.RadioMedium = new System.Windows.Forms.RadioButton();
			this.RadioHard = new System.Windows.Forms.RadioButton();
			this.StartButton = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.PlayerName = new System.Windows.Forms.TextBox();
			this.HintButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// RadioPlayer
			// 
			this.RadioPlayer.AutoSize = true;
			this.RadioPlayer.Location = new System.Drawing.Point(25, 29);
			this.RadioPlayer.Name = "RadioPlayer";
			this.RadioPlayer.Size = new System.Drawing.Size(54, 17);
			this.RadioPlayer.TabIndex = 0;
			this.RadioPlayer.TabStop = true;
			this.RadioPlayer.Text = "Player";
			this.RadioPlayer.UseVisualStyleBackColor = true;
			// 
			// RadioComputer
			// 
			this.RadioComputer.AutoSize = true;
			this.RadioComputer.Location = new System.Drawing.Point(25, 52);
			this.RadioComputer.Name = "RadioComputer";
			this.RadioComputer.Size = new System.Drawing.Size(70, 17);
			this.RadioComputer.TabIndex = 1;
			this.RadioComputer.TabStop = true;
			this.RadioComputer.Text = "Computer";
			this.RadioComputer.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.RadioPlayer);
			this.groupBox1.Controls.Add(this.RadioComputer);
			this.groupBox1.Location = new System.Drawing.Point(580, 128);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(123, 91);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Move first";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.RadioExpert);
			this.groupBox2.Controls.Add(this.RadioEasy);
			this.groupBox2.Controls.Add(this.RadioMedium);
			this.groupBox2.Controls.Add(this.RadioHard);
			this.groupBox2.Location = new System.Drawing.Point(580, 225);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(123, 135);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Difficulty";
			// 
			// RadioExpert
			// 
			this.RadioExpert.AutoSize = true;
			this.RadioExpert.Location = new System.Drawing.Point(25, 102);
			this.RadioExpert.Name = "RadioExpert";
			this.RadioExpert.Size = new System.Drawing.Size(55, 17);
			this.RadioExpert.TabIndex = 5;
			this.RadioExpert.TabStop = true;
			this.RadioExpert.Text = "Expert";
			this.RadioExpert.UseVisualStyleBackColor = true;
			// 
			// RadioEasy
			// 
			this.RadioEasy.AutoSize = true;
			this.RadioEasy.Location = new System.Drawing.Point(25, 33);
			this.RadioEasy.Name = "RadioEasy";
			this.RadioEasy.Size = new System.Drawing.Size(48, 17);
			this.RadioEasy.TabIndex = 2;
			this.RadioEasy.TabStop = true;
			this.RadioEasy.Text = "Easy";
			this.RadioEasy.UseVisualStyleBackColor = true;
			// 
			// RadioMedium
			// 
			this.RadioMedium.AutoSize = true;
			this.RadioMedium.Location = new System.Drawing.Point(25, 56);
			this.RadioMedium.Name = "RadioMedium";
			this.RadioMedium.Size = new System.Drawing.Size(62, 17);
			this.RadioMedium.TabIndex = 3;
			this.RadioMedium.TabStop = true;
			this.RadioMedium.Text = "Medium";
			this.RadioMedium.UseVisualStyleBackColor = true;
			// 
			// RadioHard
			// 
			this.RadioHard.AutoSize = true;
			this.RadioHard.Location = new System.Drawing.Point(25, 79);
			this.RadioHard.Name = "RadioHard";
			this.RadioHard.Size = new System.Drawing.Size(48, 17);
			this.RadioHard.TabIndex = 4;
			this.RadioHard.TabStop = true;
			this.RadioHard.Text = "Hard";
			this.RadioHard.UseVisualStyleBackColor = true;
			// 
			// StartButton
			// 
			this.StartButton.Location = new System.Drawing.Point(580, 366);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(123, 35);
			this.StartButton.TabIndex = 5;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.Start_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.PlayerName);
			this.groupBox3.Location = new System.Drawing.Point(580, 71);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(123, 51);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Player name";
			// 
			// PlayerName
			// 
			this.PlayerName.Location = new System.Drawing.Point(6, 19);
			this.PlayerName.Name = "PlayerName";
			this.PlayerName.Size = new System.Drawing.Size(111, 20);
			this.PlayerName.TabIndex = 0;
			// 
			// HintButton
			// 
			this.HintButton.Location = new System.Drawing.Point(614, 442);
			this.HintButton.Name = "HintButton";
			this.HintButton.Size = new System.Drawing.Size(101, 75);
			this.HintButton.TabIndex = 7;
			this.HintButton.Text = "Hint";
			this.HintButton.UseVisualStyleBackColor = true;
			this.HintButton.Click += new System.EventHandler(this.Hint_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(727, 529);
			this.Controls.Add(this.HintButton);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.StartButton);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Connect 4";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Connect4_Paint);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Connect4_MouseClick);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RadioButton RadioPlayer;
		private System.Windows.Forms.RadioButton RadioComputer;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton RadioEasy;
		private System.Windows.Forms.RadioButton RadioMedium;
		private System.Windows.Forms.RadioButton RadioHard;
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.RadioButton RadioExpert;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox PlayerName;
		private System.Windows.Forms.Button HintButton;
	}
}

