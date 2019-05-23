namespace WF_doubler
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnCommand1 = new System.Windows.Forms.Button();
			this.btnCommand2 = new System.Windows.Forms.Button();
			this.btnCommand3 = new System.Windows.Forms.Button();
			this.lblNumber = new System.Windows.Forms.Label();
			this.btnCommand4 = new System.Windows.Forms.Button();
			this.cCount = new System.Windows.Forms.Label();
			this.btnCommand5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCommand1
			// 
			this.btnCommand1.Location = new System.Drawing.Point(458, 49);
			this.btnCommand1.Name = "btnCommand1";
			this.btnCommand1.Size = new System.Drawing.Size(75, 23);
			this.btnCommand1.TabIndex = 0;
			this.btnCommand1.Text = "+1";
			this.btnCommand1.UseVisualStyleBackColor = true;
			this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
			// 
			// btnCommand2
			// 
			this.btnCommand2.Location = new System.Drawing.Point(458, 78);
			this.btnCommand2.Name = "btnCommand2";
			this.btnCommand2.Size = new System.Drawing.Size(75, 23);
			this.btnCommand2.TabIndex = 1;
			this.btnCommand2.Text = "*2";
			this.btnCommand2.UseVisualStyleBackColor = true;
			this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
			// 
			// btnCommand3
			// 
			this.btnCommand3.Location = new System.Drawing.Point(458, 107);
			this.btnCommand3.Name = "btnCommand3";
			this.btnCommand3.Size = new System.Drawing.Size(75, 23);
			this.btnCommand3.TabIndex = 2;
			this.btnCommand3.Text = "Reset";
			this.btnCommand3.UseVisualStyleBackColor = true;
			this.btnCommand3.Click += new System.EventHandler(this.btnCommand3_Click);
			// 
			// lblNumber
			// 
			this.lblNumber.AutoSize = true;
			this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblNumber.Location = new System.Drawing.Point(244, 19);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(60, 24);
			this.lblNumber.TabIndex = 3;
			this.lblNumber.Text = "label1";
			// 
			// btnCommand4
			// 
			this.btnCommand4.Location = new System.Drawing.Point(458, 20);
			this.btnCommand4.Name = "btnCommand4";
			this.btnCommand4.Size = new System.Drawing.Size(75, 23);
			this.btnCommand4.TabIndex = 4;
			this.btnCommand4.Text = "Start";
			this.btnCommand4.UseVisualStyleBackColor = true;
			this.btnCommand4.Click += new System.EventHandler(this.btnCommand4_Click);
			// 
			// cCount
			// 
			this.cCount.AutoSize = true;
			this.cCount.Location = new System.Drawing.Point(13, 286);
			this.cCount.Name = "cCount";
			this.cCount.Size = new System.Drawing.Size(82, 13);
			this.cCount.TabIndex = 5;
			this.cCount.Text = "Кол-во команд";
			// 
			// btnCommand5
			// 
			this.btnCommand5.Location = new System.Drawing.Point(458, 275);
			this.btnCommand5.Name = "btnCommand5";
			this.btnCommand5.Size = new System.Drawing.Size(75, 23);
			this.btnCommand5.TabIndex = 6;
			this.btnCommand5.Text = "Exit";
			this.btnCommand5.UseVisualStyleBackColor = true;
			this.btnCommand5.Click += new System.EventHandler(this.btnCommand5_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(545, 311);
			this.Controls.Add(this.btnCommand5);
			this.Controls.Add(this.cCount);
			this.Controls.Add(this.btnCommand4);
			this.Controls.Add(this.lblNumber);
			this.Controls.Add(this.btnCommand3);
			this.Controls.Add(this.btnCommand2);
			this.Controls.Add(this.btnCommand1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Doubler";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCommand1;
		private System.Windows.Forms.Button btnCommand2;
		private System.Windows.Forms.Button btnCommand3;
		private System.Windows.Forms.Label lblNumber;
		private System.Windows.Forms.Button btnCommand4;
		private System.Windows.Forms.Label cCount;
		private System.Windows.Forms.Button btnCommand5;
	}
}

