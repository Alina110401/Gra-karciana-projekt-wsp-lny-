namespace Uno
{
    partial class GameForm
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
            buttonDraw = new Button();
            listBoxHand = new ListBox();
            labelCurrent = new Label();
            labelTopCard = new Label();
            listBoxCounts = new ListBox();
            buttonPlay = new Button();
            SuspendLayout();
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(509, 362);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(86, 49);
            buttonDraw.TabIndex = 0;
            buttonDraw.Text = "Draw";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // listBoxHand
            // 
            listBoxHand.FormattingEnabled = true;
            listBoxHand.ItemHeight = 25;
            listBoxHand.Location = new Point(295, 207);
            listBoxHand.Name = "listBoxHand";
            listBoxHand.Size = new Size(191, 204);
            listBoxHand.TabIndex = 1;
            // 
            // labelCurrent
            // 
            labelCurrent.AutoSize = true;
            labelCurrent.Location = new Point(25, 21);
            labelCurrent.Name = "labelCurrent";
            labelCurrent.Size = new Size(59, 25);
            labelCurrent.TabIndex = 2;
            labelCurrent.Text = "label1";
            // 
            // labelTopCard
            // 
            labelTopCard.AutoSize = true;
            labelTopCard.Location = new Point(364, 141);
            labelTopCard.Name = "labelTopCard";
            labelTopCard.Size = new Size(59, 25);
            labelTopCard.TabIndex = 3;
            labelTopCard.Text = "label1";
            // 
            // listBoxCounts
            // 
            listBoxCounts.FormattingEnabled = true;
            listBoxCounts.ItemHeight = 25;
            listBoxCounts.Location = new Point(628, 21);
            listBoxCounts.Name = "listBoxCounts";
            listBoxCounts.Size = new Size(160, 54);
            listBoxCounts.TabIndex = 4;
            // 
            // buttonPlay
            // 
            buttonPlay.Location = new Point(511, 314);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(84, 43);
            buttonPlay.TabIndex = 5;
            buttonPlay.Text = "Confirm";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += this.buttonPlay_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPlay);
            Controls.Add(listBoxCounts);
            Controls.Add(labelTopCard);
            Controls.Add(labelCurrent);
            Controls.Add(listBoxHand);
            Controls.Add(buttonDraw);
            Name = "GameForm";
            Text = "GameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDraw;
        private ListBox listBoxHand;
        private Label labelCurrent;
        private Label labelTopCard;
        private ListBox listBoxCounts;
        private Button buttonPlay;
    }
}