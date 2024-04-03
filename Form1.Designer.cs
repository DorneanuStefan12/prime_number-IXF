namespace prime_number_IX_F
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.PrimeNumberTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PrimeNumberLabel = new System.Windows.Forms.Label();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrimeNumberTextBox
            // 
            this.PrimeNumberTextBox.Location = new System.Drawing.Point(134, 139);
            this.PrimeNumberTextBox.Name = "PrimeNumberTextBox";
            this.PrimeNumberTextBox.Size = new System.Drawing.Size(318, 20);
            this.PrimeNumberTextBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(330, 190);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(122, 70);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ClearButton.Location = new System.Drawing.Point(134, 190);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(123, 70);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrimeNumberLabel
            // 
            this.PrimeNumberLabel.AutoSize = true;
            this.PrimeNumberLabel.Location = new System.Drawing.Point(707, 93);
            this.PrimeNumberLabel.Name = "PrimeNumberLabel";
            this.PrimeNumberLabel.Size = new System.Drawing.Size(73, 13);
            this.PrimeNumberLabel.TabIndex = 4;
            this.PrimeNumberLabel.Text = "Prime Number";
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Location = new System.Drawing.Point(646, 93);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(39, 13);
            this.HistoryLabel.TabIndex = 5;
            this.HistoryLabel.Text = "History";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 478);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.PrimeNumberLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.PrimeNumberTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PrimeNumberTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label PrimeNumberLabel;
        private System.Windows.Forms.Label HistoryLabel;
    }
}

