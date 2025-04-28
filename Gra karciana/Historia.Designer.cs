namespace Gra_karciana
{
    partial class Historia
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
            Gra = new DataGridViewTextBoxColumn();
            Numer_gry = new DataGridViewTextBoxColumn();
            Nick = new DataGridViewTextBoxColumn();
            Punkty = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 19);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 0;
            label1.Text = "Historia";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Gra, Numer_gry, Nick, Punkty });
            dataGridView1.Location = new Point(54, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(667, 366);
            dataGridView1.TabIndex = 1;
            // 
            // Gra
            // 
            Gra.HeaderText = "Gra";
            Gra.MinimumWidth = 8;
            Gra.Name = "Gra";
            Gra.Width = 150;
            // 
            // Numer_gry
            // 
            Numer_gry.HeaderText = "Numer gry";
            Numer_gry.MinimumWidth = 8;
            Numer_gry.Name = "Numer_gry";
            Numer_gry.Width = 150;
            // 
            // Nick
            // 
            Nick.HeaderText = "Nick";
            Nick.MinimumWidth = 8;
            Nick.Name = "Nick";
            Nick.Width = 150;
            // 
            // Punkty
            // 
            Punkty.HeaderText = "Punkty";
            Punkty.MinimumWidth = 8;
            Punkty.Name = "Punkty";
            Punkty.Width = 150;
            // 
            // Historia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Historia";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Gra;
        private DataGridViewTextBoxColumn Numer_gry;
        private DataGridViewTextBoxColumn Nick;
        private DataGridViewTextBoxColumn Punkty;
    }
}