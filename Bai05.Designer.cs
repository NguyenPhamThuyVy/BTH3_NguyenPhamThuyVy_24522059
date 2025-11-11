namespace BTH3_BT5
{
    partial class Bai05
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNum1 = new TextBox();
            lbNum1 = new Label();
            lbNum2 = new Label();
            txtNum2 = new TextBox();
            btnAdd = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            lbAnswer = new Label();
            txtAnswer = new TextBox();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(107, 45);
            txtNum1.Multiline = true;
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(360, 27);
            txtNum1.TabIndex = 0;
            txtNum1.TextChanged += textBox1_TextChanged;
            // 
            // lbNum1
            // 
            lbNum1.AutoSize = true;
            lbNum1.Location = new Point(26, 52);
            lbNum1.Name = "lbNum1";
            lbNum1.Size = new Size(75, 20);
            lbNum1.TabIndex = 1;
            lbNum1.Text = "Number 1";
            // 
            // lbNum2
            // 
            lbNum2.AutoSize = true;
            lbNum2.Location = new Point(26, 92);
            lbNum2.Name = "lbNum2";
            lbNum2.Size = new Size(75, 20);
            lbNum2.TabIndex = 2;
            lbNum2.Text = "Number 2";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(107, 85);
            txtNum2.Multiline = true;
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(360, 27);
            txtNum2.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveBorder;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 14F);
            btnAdd.Location = new Point(26, 155);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 55);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSub
            // 
            btnSub.BackColor = SystemColors.ActiveBorder;
            btnSub.Cursor = Cursors.Hand;
            btnSub.FlatStyle = FlatStyle.Flat;
            btnSub.Font = new Font("Segoe UI", 14F);
            btnSub.Location = new Point(142, 155);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 55);
            btnSub.TabIndex = 5;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            // 
            // btnMul
            // 
            btnMul.BackColor = SystemColors.ActiveBorder;
            btnMul.Cursor = Cursors.Hand;
            btnMul.FlatStyle = FlatStyle.Flat;
            btnMul.Font = new Font("Segoe UI", 14F);
            btnMul.Location = new Point(261, 155);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(75, 55);
            btnMul.TabIndex = 6;
            btnMul.Text = "X";
            btnMul.UseVisualStyleBackColor = false;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = SystemColors.ActiveBorder;
            btnDiv.Cursor = Cursors.Hand;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Segoe UI", 14F);
            btnDiv.Location = new Point(378, 155);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 55);
            btnDiv.TabIndex = 7;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            // 
            // lbAnswer
            // 
            lbAnswer.AutoSize = true;
            lbAnswer.Location = new Point(26, 245);
            lbAnswer.Name = "lbAnswer";
            lbAnswer.Size = new Size(57, 20);
            lbAnswer.TabIndex = 8;
            lbAnswer.Text = "Answer";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(107, 238);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(360, 27);
            txtAnswer.TabIndex = 9;
            // 
            // Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 303);
            Controls.Add(txtAnswer);
            Controls.Add(lbAnswer);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(txtNum2);
            Controls.Add(lbNum2);
            Controls.Add(lbNum1);
            Controls.Add(txtNum1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Bai05";
            Text = "Lab02-Example";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private Label lbNum1;
        private Label lbNum2;
        private TextBox txtNum2;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
        private Label lbAnswer;
        private TextBox txtAnswer;
    }
}
