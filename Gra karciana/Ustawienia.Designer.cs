namespace Gra_karciana
{
    partial class Ustawienia
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Lp = new DataGridViewTextBoxColumn();
            Nick = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 39);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "Lista graczy";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Lp, Nick });
            dataGridView1.Location = new Point(170, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(488, 183);
            dataGridView1.TabIndex = 1;
            // 
            // Lp
            // 
            Lp.HeaderText = "Lp";
            Lp.MinimumWidth = 8;
            Lp.Name = "Lp";
            Lp.Width = 150;
            // 
            // Nick
            // 
            Nick.HeaderText = "Nick";
            Nick.MinimumWidth = 8;
            Nick.Name = "Nick";
            Nick.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(103, 350);
            button1.Name = "button1";
            button1.Size = new Size(232, 34);
            button1.TabIndex = 2;
            button1.Text = "Dodaj gracza";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Dodaj_Click;
            // 
            // button2
            // 
            button2.Location = new Point(464, 350);
            button2.Name = "button2";
            button2.Size = new Size(232, 34);
            button2.TabIndex = 3;
            button2.Text = "Usun gracza";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Usun_Click;
            // 
            // Ustawienia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Ustawienia";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Lp;
        private DataGridViewTextBoxColumn Nick;
        private Button button1;
        private Button button2;
    }
}