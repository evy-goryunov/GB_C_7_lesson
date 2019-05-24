using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_The_Number
{
	public partial class Form1 : Form
	{
		int questNumber;
		public Form1()
		{
			
			InitializeComponent();
			btnStart.Text = "Start";
			TitleLbl.Text = "Guess The Number Game";
			QuestLable.Visible = false;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			Random r = new Random();
			questNumber = r.Next(0, 100);
			QuestLable.Text = "Угадайте число от 0 до 100";
			QuestLable.Visible = true;
			TitleLbl.Text = questNumber.ToString();
		}

		private void GuessText_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnGuess_Click(object sender, EventArgs e)
		{
			if (int.Parse(GuessText.Text) == questNumber)
			{
				QuestLable.Text = "Вы угадали!";
			}
		}
	}
}
