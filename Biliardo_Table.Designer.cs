namespace Biliardo_Play_Store
{
    partial class Biliardo_Table
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Time_String = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTN_STOP = new FontAwesome.Sharp.IconButton();
            this.BTN_PAUSE = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.LB_PRICE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(208, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 33);
            this.textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Biliardo_Play_Store.Properties.Resources.Pil_table;
            this.pictureBox1.Location = new System.Drawing.Point(126, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Time_String
            // 
            this.Time_String.AutoSize = true;
            this.Time_String.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_String.ForeColor = System.Drawing.Color.Transparent;
            this.Time_String.Location = new System.Drawing.Point(28, 40);
            this.Time_String.Name = "Time_String";
            this.Time_String.Size = new System.Drawing.Size(103, 29);
            this.Time_String.TabIndex = 2;
            this.Time_String.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bluu Next", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BTN_STOP
            // 
            this.BTN_STOP.BackColor = System.Drawing.Color.Red;
            this.BTN_STOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_STOP.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_STOP.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.BTN_STOP.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            this.BTN_STOP.IconColor = System.Drawing.Color.Black;
            this.BTN_STOP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_STOP.IconSize = 21;
            this.BTN_STOP.Location = new System.Drawing.Point(127, 180);
            this.BTN_STOP.Name = "BTN_STOP";
            this.BTN_STOP.Size = new System.Drawing.Size(98, 34);
            this.BTN_STOP.TabIndex = 4;
            this.BTN_STOP.Text = "Stop";
            this.BTN_STOP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_STOP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_STOP.UseVisualStyleBackColor = false;
            this.BTN_STOP.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // BTN_PAUSE
            // 
            this.BTN_PAUSE.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_PAUSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PAUSE.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PAUSE.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.BTN_PAUSE.IconChar = FontAwesome.Sharp.IconChar.Pause;
            this.BTN_PAUSE.IconColor = System.Drawing.Color.Black;
            this.BTN_PAUSE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_PAUSE.IconSize = 21;
            this.BTN_PAUSE.Location = new System.Drawing.Point(231, 180);
            this.BTN_PAUSE.Name = "BTN_PAUSE";
            this.BTN_PAUSE.Size = new System.Drawing.Size(98, 34);
            this.BTN_PAUSE.TabIndex = 5;
            this.BTN_PAUSE.Text = "Pause";
            this.BTN_PAUSE.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BTN_PAUSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_PAUSE.UseVisualStyleBackColor = false;
            this.BTN_PAUSE.Click += new System.EventHandler(this.BTN_PAUSE_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Hourglass1;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 21;
            this.iconButton3.Location = new System.Drawing.Point(335, 180);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(98, 34);
            this.iconButton3.TabIndex = 6;
            this.iconButton3.Text = "Start";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // LB_PRICE
            // 
            this.LB_PRICE.AutoSize = true;
            this.LB_PRICE.Font = new System.Drawing.Font("Bluu Next", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PRICE.ForeColor = System.Drawing.Color.Orange;
            this.LB_PRICE.Location = new System.Drawing.Point(16, 157);
            this.LB_PRICE.Name = "LB_PRICE";
            this.LB_PRICE.Size = new System.Drawing.Size(0, 41);
            this.LB_PRICE.TabIndex = 7;
            this.LB_PRICE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Biliardo_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.Controls.Add(this.LB_PRICE);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.BTN_PAUSE);
            this.Controls.Add(this.BTN_STOP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Time_String);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Biliardo_Table";
            this.Size = new System.Drawing.Size(442, 220);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Time_String;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton BTN_STOP;
        private FontAwesome.Sharp.IconButton BTN_PAUSE;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label LB_PRICE;
    }
}
