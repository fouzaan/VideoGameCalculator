namespace WindowsFormsApp2
{
    partial class WeeklySalesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SalesEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DayLable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.WholeSalesChart = new System.Windows.Forms.RichTextBox();
            this.ShowAvarageGameSales = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video Game Sales";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SalesEntry
            // 
            this.SalesEntry.Cursor = System.Windows.Forms.Cursors.Default;
            this.SalesEntry.Location = new System.Drawing.Point(496, 47);
            this.SalesEntry.Name = "SalesEntry";
            this.SalesEntry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SalesEntry.Size = new System.Drawing.Size(473, 31);
            this.SalesEntry.TabIndex = 0;
            this.toolTip1.SetToolTip(this.SalesEntry, "put your one day video game sales here");
            this.SalesEntry.TextChanged += new System.EventHandler(this.SalesEntry_TextChanged);
            this.SalesEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SalesEntry_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1004, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Day#";
            this.toolTip1.SetToolTip(this.label2, "this shows on which dau you are");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DayLable
            // 
            this.DayLable.AutoSize = true;
            this.DayLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLable.Location = new System.Drawing.Point(1145, 41);
            this.DayLable.Name = "DayLable";
            this.DayLable.Size = new System.Drawing.Size(18, 42);
            this.DayLable.TabIndex = 3;
            this.DayLable.Text = "\r\n";
            this.DayLable.Click += new System.EventHandler(this.DayLable_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 695);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enter";
            this.toolTip1.SetToolTip(this.button1, "hit enter to add the day sales.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 695);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(340, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reset";
            this.toolTip1.SetToolTip(this.button2, "Rest to rest the whole form ");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(947, 695);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(340, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Exit";
            this.toolTip1.SetToolTip(this.button3, "hit exit to exit the form");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // WholeSalesChart
            // 
            this.WholeSalesChart.Enabled = false;
            this.WholeSalesChart.Location = new System.Drawing.Point(59, 123);
            this.WholeSalesChart.Name = "WholeSalesChart";
            this.WholeSalesChart.Size = new System.Drawing.Size(1228, 452);
            this.WholeSalesChart.TabIndex = 6;
            this.WholeSalesChart.Text = "";
            this.toolTip1.SetToolTip(this.WholeSalesChart, "this has the record of all of your weekly sales");
            // 
            // ShowAvarageGameSales
            // 
            this.ShowAvarageGameSales.AutoSize = true;
            this.ShowAvarageGameSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowAvarageGameSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAvarageGameSales.Location = new System.Drawing.Point(447, 600);
            this.ShowAvarageGameSales.MaximumSize = new System.Drawing.Size(550, 0);
            this.ShowAvarageGameSales.MinimumSize = new System.Drawing.Size(90, 0);
            this.ShowAvarageGameSales.Name = "ShowAvarageGameSales";
            this.ShowAvarageGameSales.Size = new System.Drawing.Size(522, 44);
            this.ShowAvarageGameSales.TabIndex = 7;
            this.ShowAvarageGameSales.Text = "Average Video Game Sales: $";
            this.toolTip1.SetToolTip(this.ShowAvarageGameSales, "This hsows you the avarage of your total game sales");
            this.ShowAvarageGameSales.Click += new System.EventHandler(this.label3_Click);
            // 
            // WeeklySalesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1362, 841);
            this.Controls.Add(this.ShowAvarageGameSales);
            this.Controls.Add(this.WholeSalesChart);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DayLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SalesEntry);
            this.Controls.Add(this.label1);
            this.Name = "WeeklySalesForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avarage Weekly Game Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SalesEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DayLable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox WholeSalesChart;
        private System.Windows.Forms.Label ShowAvarageGameSales;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

