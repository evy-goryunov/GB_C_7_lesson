﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

/// <summary>
/// Горюнов Евгений
/// а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
/// б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
/// Игрок должен получить это число за минимальное количество ходов.
/// в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте обобщенный класс Stack.
/// Вся логика игры должна быть реализована в классе с удвоителем.

/// </summary>

namespace WF_doubler
{
	public partial class Form1 : Form
	{
		// коллекция Stack для Undo
		Stack<int> myStack = new Stack<int>();
		// переменные числа для победы и кол-ва ходов
		int numberToWin = 0;
		int cmdCount = 0;

		public Form1()
		{
			InitializeComponent();
			btnCommand1.Text = "+1";
			btnCommand2.Text = "x2";
			btnCommand3.Text = "Reset";
			btnCommand4.Text = "Start";
			btnCommand5.Text = "Exit";
			btnCommand6.Text = "Undo";
			lblNumber.Text = "0";
			lblNumber.Visible = false;
			cCount.Text = "0";
			cCount.Visible = false;
			this.Text = "Doubler";	
		}
		// кнопка +1
		private void btnCommand1_Click(object sender, EventArgs e)
		{
			if (int.Parse(lblNumber.Text) != numberToWin)
			{
				lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
				cmdCount++;
				cCount.Text = cmdCount.ToString();
				myStack.Push(int.Parse(lblNumber.Text));
			}
			if (int.Parse(lblNumber.Text) == numberToWin ) MessageBox.Show("Вы победили!");
			

		}
		// кнопка *2
		private void btnCommand2_Click(object sender, EventArgs e)
		{
			if (int.Parse(lblNumber.Text) != numberToWin)
			{
				lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
				cmdCount++;
				cCount.Text = cmdCount.ToString();
				myStack.Push(int.Parse(lblNumber.Text));
			}
			if (int.Parse(lblNumber.Text) == numberToWin) MessageBox.Show("Вы победили!");


		}

		// работа кнопки Reset
		private void btnCommand3_Click(object sender, EventArgs e)
		{
			lblNumber.Text = "0";
			cCount.Text = "0";
			cmdCount = 0;
			lblNumber.Visible = false;
			cCount.Visible = false;
		}

		// работа кнопки Start
		private void btnCommand4_Click(object sender, EventArgs e)
		{
			Random r = new Random();
			numberToWin = r.Next(10, 100);
			MessageBox.Show("Попытайтесь за наименьшее кол-во ходов получить число: " + numberToWin);
			lblNumber.Visible = true;
			cCount.Visible = true;
		}

		// кнопка Exit
		private void btnCommand5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		// отмена хода Undo
		private void btnCommand6_Click(object sender, EventArgs e)
		{
			if (myStack.Count != 0)
			{
				lblNumber.Text = myStack.Pop().ToString();
			}
			
		}
	}
}
