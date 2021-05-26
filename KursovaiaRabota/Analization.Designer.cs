namespace WindowsFormsApp1
{
    partial class Analization
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxWid = new System.Windows.Forms.TextBox();
            this.textBoxHeig = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Algo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Algo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.S,
            this.Time,
            this.Algo1,
            this.Algo2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxWid
            // 
            this.textBoxWid.Location = new System.Drawing.Point(54, 26);
            this.textBoxWid.Name = "textBoxWid";
            this.textBoxWid.Size = new System.Drawing.Size(100, 20);
            this.textBoxWid.TabIndex = 2;
            // 
            // textBoxHeig
            // 
            this.textBoxHeig.Location = new System.Drawing.Point(212, 26);
            this.textBoxHeig.Name = "textBoxHeig";
            this.textBoxHeig.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeig.TabIndex = 3;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(437, 26);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(12, 29);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(36, 13);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Длина";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(161, 29);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(45, 13);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Ширина";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(318, 29);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(113, 13);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "Количество итераций";
            // 
            // S
            // 
            this.S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.S.HeaderText = "Размер комнаты";
            this.S.Name = "S";
            this.S.ReadOnly = true;
            this.S.Width = 60;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Time.FillWeight = 131.3869F;
            this.Time.HeaderText = "N";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 60;
            // 
            // Algo1
            // 
            this.Algo1.FillWeight = 84.30657F;
            this.Algo1.HeaderText = "Хаотический алгоритм";
            this.Algo1.Name = "Algo1";
            this.Algo1.ReadOnly = true;
            // 
            // Algo2
            // 
            this.Algo2.FillWeight = 84.30657F;
            this.Algo2.HeaderText = "Построение карты";
            this.Algo2.Name = "Algo2";
            this.Algo2.ReadOnly = true;
            // 
            // Analization
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(753, 456);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxHeig);
            this.Controls.Add(this.textBoxWid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Analization";
            this.Text = "Analization";
            this.Load += new System.EventHandler(this.Analization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxWid;
        private System.Windows.Forms.TextBox textBoxHeig;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Algo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Algo2;
    }
}