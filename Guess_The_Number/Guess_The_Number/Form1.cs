using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Горюнов Егвений
/// Используя Windows Forms, разработать игру «Угадай число». 
/// Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. 
/// Компьютер говорит, больше или меньше загаданное число введенного.  
/// a) Для ввода данных от человека используется элемент TextBox;
/// б) ** Реализовать отдельную форму c TextBox для ввода числа.

/// </summary>

namespace Guess_The_Number
{
	public partial class Form1 : Form
	{
		public int questNumber;
		public Form1()
		{
			
			InitializeComponent();
			btnStart.Text = "Start";
			TitleLbl.Text = "Guess The Number Game";
			QuestLable.Visible = false;
		}

		// выход
		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// старт
		private void btnStart_Click(object sender, EventArgs e)
		{
			
			QuestLable.Text = "Угадайте число от 0 до 100";
			QuestLable.Visible = true;
			
			//убрать комент для проверки
			//TitleLbl.Text = DataClass.questNumber.ToString();
		}

		
		// проверка ответа игрока
		private void btnGuess_Click(object sender, EventArgs e)
		{
			if (DataClass.PLG > DataClass.questNumber)
			{
				QuestLable.Text = "Слишком большое число";
			}
			else if (DataClass.PLG < DataClass.questNumber)
			{
				QuestLable.Text = "Слишком маленькое число";
			}
			else if (DataClass.PLG == DataClass.questNumber)
			{
				QuestLable.Text = "Вы угадали!";
			}
		}

		// переход на вторую форму
		private void btnInput_Click(object sender, EventArgs e)
		{
			Form2 newForm2 = new Form2();
			newForm2.Show();
		}
	}
}
