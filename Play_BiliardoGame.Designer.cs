namespace Biliardo_Play_Store
{
    partial class Play_BiliardoGame
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
            this.biliardo_Table1 = new Biliardo_Play_Store.Biliardo_Table();
            this.biliardo_Table2 = new Biliardo_Play_Store.Biliardo_Table();
            this.biliardo_Table3 = new Biliardo_Play_Store.Biliardo_Table();
            this.biliardo_Table4 = new Biliardo_Play_Store.Biliardo_Table();
            this.SuspendLayout();
            // 
            // biliardo_Table1
            // 
            this.biliardo_Table1.BackColor = System.Drawing.SystemColors.MenuText;
            this.biliardo_Table1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.biliardo_Table1.Location = new System.Drawing.Point(553, 28);
            this.biliardo_Table1.Name = "biliardo_Table1";
            this.biliardo_Table1.Size = new System.Drawing.Size(442, 220);
            this.biliardo_Table1.TabIndex = 0;
            // 
            // biliardo_Table2
            // 
            this.biliardo_Table2.BackColor = System.Drawing.SystemColors.MenuText;
            this.biliardo_Table2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.biliardo_Table2.Location = new System.Drawing.Point(12, 28);
            this.biliardo_Table2.Name = "biliardo_Table2";
            this.biliardo_Table2.Size = new System.Drawing.Size(442, 220);
            this.biliardo_Table2.TabIndex = 2;
            // 
            // biliardo_Table3
            // 
            this.biliardo_Table3.BackColor = System.Drawing.SystemColors.MenuText;
            this.biliardo_Table3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.biliardo_Table3.Location = new System.Drawing.Point(553, 319);
            this.biliardo_Table3.Name = "biliardo_Table3";
            this.biliardo_Table3.Size = new System.Drawing.Size(442, 220);
            this.biliardo_Table3.TabIndex = 3;
            // 
            // biliardo_Table4
            // 
            this.biliardo_Table4.BackColor = System.Drawing.SystemColors.MenuText;
            this.biliardo_Table4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.biliardo_Table4.Location = new System.Drawing.Point(12, 319);
            this.biliardo_Table4.Name = "biliardo_Table4";
            this.biliardo_Table4.Size = new System.Drawing.Size(442, 220);
            this.biliardo_Table4.TabIndex = 4;
            // 
            // Play_BiliardoGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1009, 562);
            this.Controls.Add(this.biliardo_Table4);
            this.Controls.Add(this.biliardo_Table3);
            this.Controls.Add(this.biliardo_Table2);
            this.Controls.Add(this.biliardo_Table1);
            this.Name = "Play_BiliardoGame";
            this.Text = "Play_BiliardoGame";
            this.ResumeLayout(false);

        }

        #endregion

        private Biliardo_Table biliardo_Table1;
        private Biliardo_Table biliardo_Table2;
        private Biliardo_Table biliardo_Table3;
        private Biliardo_Table biliardo_Table4;
    }
}