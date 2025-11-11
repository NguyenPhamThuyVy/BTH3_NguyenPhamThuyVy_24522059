namespace BTH3_BT3
{
    partial class Bai03
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
            btnChangeColor = new Button();
            SuspendLayout();
            // 
            // btnChangeColor
            // 
            btnChangeColor.Cursor = Cursors.Hand;
            btnChangeColor.Font = new Font("Segoe UI", 12F);
            btnChangeColor.Location = new Point(290, 187);
            btnChangeColor.Name = "btnChangeColor";
            btnChangeColor.Size = new Size(192, 52);
            btnChangeColor.TabIndex = 0;
            btnChangeColor.Text = "Change Color";
            btnChangeColor.UseVisualStyleBackColor = true;
            btnChangeColor.Click += btnChangeColor_Click;
            // 
            // Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChangeColor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Bai03";
            ResumeLayout(false);
        }

        #endregion

        private Button btnChangeColor;
    }
}
