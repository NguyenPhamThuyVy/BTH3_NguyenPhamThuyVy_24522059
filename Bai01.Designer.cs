namespace BTH3_BT1
{
    partial class Bai01
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
            lstEvent = new ListBox();
            SuspendLayout();
            // 
            // lstEvent
            // 
            lstEvent.Dock = DockStyle.Right;
            lstEvent.FormattingEnabled = true;
            lstEvent.Location = new Point(419, 0);
            lstEvent.Name = "lstEvent";
            lstEvent.Size = new Size(381, 450);
            lstEvent.TabIndex = 0;
            // 
            // Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstEvent);
            Name = "Bai01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstEvent;
    }
}
