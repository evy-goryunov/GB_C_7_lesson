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
/// Вторая форма для ввода числа
/// </summary>

namespace Guess_The_Number
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		// передаем ответ в статическую переменную PLG
		private void btnGuess2_Click(object sender, EventArgs e)
		{
			// обрабатываем исключение если пользователь оставил поле пустым
			try
			{
				DataClass.PLG = int.Parse(textBox1.Text);
			}
			catch (Exception)
			{

				MessageBox.Show("Введите число!");
			}
				
			
				
		}
	}
}
