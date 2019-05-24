namespace Guess_The_Number
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.TitleLbl = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.QuestLable = new System.Windows.Forms.Label();
			this.btnGuess = new System.Windows.Forms.Button();
			this.btnInput = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TitleLbl
			// 
			this.TitleLbl.AutoSize = true;
			this.TitleLbl.Font = new System.Drawing.Font("MS Outlook", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TitleLbl.Location = new System.Drawing.Point(27, 25);
			this.TitleLbl.Name = "TitleLbl";
			this.TitleLbl.Size = new System.Drawing.Size(68, 25);
			this.TitleLbl.TabIndex = 0;
			this.TitleLbl.Text = "label1";
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(496, 288);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(496, 27);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 3;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// QuestLable
			// 
			this.QuestLable.AutoSize = true;
			this.QuestLable.Location = new System.Drawing.Point(32, 70);
			this.QuestLable.Name = "QuestLable";
			this.QuestLable.Size = new System.Drawing.Size(35, 13);
			this.QuestLable.TabIndex = 4;
			this.QuestLable.Text = "label1";
			// 
			// btnGuess
			// 
			this.btnGuess.Location = new System.Drawing.Point(496, 85);
			this.btnGuess.Name = "btnGuess";
			this.btnGuess.Size = new System.Drawing.Size(75, 23);
			this.btnGuess.TabIndex = 6;
			this.btnGuess.Text = "Guess";
			this.btnGuess.UseVisualStyleBackColor = true;
			this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
			// 
			// btnInput
			// 
			this.btnInput.Location = new System.Drawing.Point(496, 56);
			this.btnInput.Name = "btnInput";
			this.btnInput.Size = new System.Drawing.Size(75, 23);
			this.btnInput.TabIndex = 8;
			this.btnInput.Text = "Input";
			this.btnInput.UseVisualStyleBackColor = true;
			this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(603, 350);
			this.Controls.Add(this.btnInput);
			this.Controls.Add(this.btnGuess);
			this.Controls.Add(this.QuestLable);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.TitleLbl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Guess The Number";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleLbl;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label QuestLable;
		private System.Windows.Forms.Button btnGuess;
		private System.Windows.Forms.Button btnInput;
	}
}

