﻿namespace breadCompany
{
    partial class printForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printForm));
            this.dgvDayForPrint = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOFOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumInOneMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintSubmit = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayForPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDayForPrint
            // 
            this.dgvDayForPrint.AllowUserToAddRows = false;
            this.dgvDayForPrint.AllowUserToDeleteRows = false;
            this.dgvDayForPrint.BackgroundColor = System.Drawing.Color.White;
            this.dgvDayForPrint.ColumnHeadersHeight = 25;
            this.dgvDayForPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDayForPrint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MarketI,
            this.Day1,
            this.Day2,
            this.Day3,
            this.Day4,
            this.Day5,
            this.Day6,
            this.Day7,
            this.Day8,
            this.Day9,
            this.Day10,
            this.Day11,
            this.Day12,
            this.Day13,
            this.Day14,
            this.Day15,
            this.Day16,
            this.Day17,
            this.Day18,
            this.Day19,
            this.Day20,
            this.Day21,
            this.Day22,
            this.Day23,
            this.Day24,
            this.Day25,
            this.Day26,
            this.Day27,
            this.Day28,
            this.Day29,
            this.Day30,
            this.Day31,
            this.MonthName,
            this.TotalCount,
            this.PriceOFOne,
            this.TotalPrice,
            this.SumInOneMonth});
            this.dgvDayForPrint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDayForPrint.Location = new System.Drawing.Point(0, 37);
            this.dgvDayForPrint.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDayForPrint.Name = "dgvDayForPrint";
            this.dgvDayForPrint.RowHeadersVisible = false;
            this.dgvDayForPrint.RowHeadersWidth = 51;
            this.dgvDayForPrint.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDayForPrint.Size = new System.Drawing.Size(2057, 971);
            this.dgvDayForPrint.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.Frozen = true;
            this.ID.HeaderText = "№";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 43;
            // 
            // MarketI
            // 
            this.MarketI.DataPropertyName = "MarketName";
            this.MarketI.HeaderText = "Market Ad";
            this.MarketI.MinimumWidth = 6;
            this.MarketI.Name = "MarketI";
            this.MarketI.Width = 125;
            // 
            // Day1
            // 
            this.Day1.DataPropertyName = "Day1";
            this.Day1.HeaderText = "1";
            this.Day1.MinimumWidth = 6;
            this.Day1.Name = "Day1";
            this.Day1.Width = 36;
            // 
            // Day2
            // 
            this.Day2.DataPropertyName = "Day2";
            this.Day2.HeaderText = "2";
            this.Day2.MinimumWidth = 6;
            this.Day2.Name = "Day2";
            this.Day2.Width = 36;
            // 
            // Day3
            // 
            this.Day3.DataPropertyName = "Day3";
            this.Day3.HeaderText = "3";
            this.Day3.MinimumWidth = 6;
            this.Day3.Name = "Day3";
            this.Day3.Width = 36;
            // 
            // Day4
            // 
            this.Day4.DataPropertyName = "Day4";
            this.Day4.HeaderText = "4";
            this.Day4.MinimumWidth = 6;
            this.Day4.Name = "Day4";
            this.Day4.Width = 36;
            // 
            // Day5
            // 
            this.Day5.DataPropertyName = "Day5";
            this.Day5.HeaderText = "5";
            this.Day5.MinimumWidth = 6;
            this.Day5.Name = "Day5";
            this.Day5.Width = 36;
            // 
            // Day6
            // 
            this.Day6.DataPropertyName = "Day6";
            this.Day6.HeaderText = "6";
            this.Day6.MinimumWidth = 6;
            this.Day6.Name = "Day6";
            this.Day6.Width = 36;
            // 
            // Day7
            // 
            this.Day7.DataPropertyName = "Day7";
            this.Day7.HeaderText = "7";
            this.Day7.MinimumWidth = 6;
            this.Day7.Name = "Day7";
            this.Day7.Width = 36;
            // 
            // Day8
            // 
            this.Day8.DataPropertyName = "Day8";
            this.Day8.HeaderText = "8";
            this.Day8.MinimumWidth = 6;
            this.Day8.Name = "Day8";
            this.Day8.Width = 36;
            // 
            // Day9
            // 
            this.Day9.DataPropertyName = "Day9";
            this.Day9.HeaderText = "9";
            this.Day9.MinimumWidth = 6;
            this.Day9.Name = "Day9";
            this.Day9.Width = 36;
            // 
            // Day10
            // 
            this.Day10.DataPropertyName = "Day10";
            this.Day10.HeaderText = "10";
            this.Day10.MinimumWidth = 6;
            this.Day10.Name = "Day10";
            this.Day10.Width = 36;
            // 
            // Day11
            // 
            this.Day11.DataPropertyName = "Day11";
            this.Day11.HeaderText = "11";
            this.Day11.MinimumWidth = 6;
            this.Day11.Name = "Day11";
            this.Day11.Width = 36;
            // 
            // Day12
            // 
            this.Day12.DataPropertyName = "Day12";
            this.Day12.HeaderText = "12";
            this.Day12.MinimumWidth = 6;
            this.Day12.Name = "Day12";
            this.Day12.Width = 36;
            // 
            // Day13
            // 
            this.Day13.DataPropertyName = "Day13";
            this.Day13.HeaderText = "13";
            this.Day13.MinimumWidth = 6;
            this.Day13.Name = "Day13";
            this.Day13.Width = 36;
            // 
            // Day14
            // 
            this.Day14.DataPropertyName = "Day14";
            this.Day14.HeaderText = "14";
            this.Day14.MinimumWidth = 6;
            this.Day14.Name = "Day14";
            this.Day14.Width = 36;
            // 
            // Day15
            // 
            this.Day15.DataPropertyName = "Day15";
            this.Day15.HeaderText = "15";
            this.Day15.MinimumWidth = 6;
            this.Day15.Name = "Day15";
            this.Day15.Width = 36;
            // 
            // Day16
            // 
            this.Day16.DataPropertyName = "Day16";
            this.Day16.HeaderText = "16";
            this.Day16.MinimumWidth = 6;
            this.Day16.Name = "Day16";
            this.Day16.Width = 36;
            // 
            // Day17
            // 
            this.Day17.DataPropertyName = "Day17";
            this.Day17.HeaderText = "17";
            this.Day17.MinimumWidth = 6;
            this.Day17.Name = "Day17";
            this.Day17.Width = 36;
            // 
            // Day18
            // 
            this.Day18.DataPropertyName = "Day18";
            this.Day18.HeaderText = "18";
            this.Day18.MinimumWidth = 6;
            this.Day18.Name = "Day18";
            this.Day18.Width = 36;
            // 
            // Day19
            // 
            this.Day19.DataPropertyName = "Day19";
            this.Day19.HeaderText = "19";
            this.Day19.MinimumWidth = 6;
            this.Day19.Name = "Day19";
            this.Day19.Width = 36;
            // 
            // Day20
            // 
            this.Day20.DataPropertyName = "Day20";
            this.Day20.HeaderText = "20";
            this.Day20.MinimumWidth = 6;
            this.Day20.Name = "Day20";
            this.Day20.Width = 36;
            // 
            // Day21
            // 
            this.Day21.DataPropertyName = "Day21";
            this.Day21.HeaderText = "21";
            this.Day21.MinimumWidth = 6;
            this.Day21.Name = "Day21";
            this.Day21.Width = 36;
            // 
            // Day22
            // 
            this.Day22.DataPropertyName = "Day22";
            this.Day22.HeaderText = "22";
            this.Day22.MinimumWidth = 6;
            this.Day22.Name = "Day22";
            this.Day22.Width = 36;
            // 
            // Day23
            // 
            this.Day23.DataPropertyName = "Day23";
            this.Day23.HeaderText = "23";
            this.Day23.MinimumWidth = 6;
            this.Day23.Name = "Day23";
            this.Day23.Width = 36;
            // 
            // Day24
            // 
            this.Day24.DataPropertyName = "Day24";
            this.Day24.HeaderText = "24";
            this.Day24.MinimumWidth = 6;
            this.Day24.Name = "Day24";
            this.Day24.Width = 36;
            // 
            // Day25
            // 
            this.Day25.DataPropertyName = "Day25";
            this.Day25.HeaderText = "25";
            this.Day25.MinimumWidth = 6;
            this.Day25.Name = "Day25";
            this.Day25.Width = 36;
            // 
            // Day26
            // 
            this.Day26.DataPropertyName = "Day26";
            this.Day26.HeaderText = "26";
            this.Day26.MinimumWidth = 6;
            this.Day26.Name = "Day26";
            this.Day26.Width = 36;
            // 
            // Day27
            // 
            this.Day27.DataPropertyName = "Day27";
            this.Day27.HeaderText = "27";
            this.Day27.MinimumWidth = 6;
            this.Day27.Name = "Day27";
            this.Day27.Width = 36;
            // 
            // Day28
            // 
            this.Day28.DataPropertyName = "Day28";
            this.Day28.HeaderText = "28";
            this.Day28.MinimumWidth = 6;
            this.Day28.Name = "Day28";
            this.Day28.Width = 44;
            // 
            // Day29
            // 
            this.Day29.DataPropertyName = "Day29";
            this.Day29.HeaderText = "29";
            this.Day29.MinimumWidth = 6;
            this.Day29.Name = "Day29";
            this.Day29.Width = 36;
            // 
            // Day30
            // 
            this.Day30.DataPropertyName = "Day30";
            this.Day30.HeaderText = "30";
            this.Day30.MinimumWidth = 6;
            this.Day30.Name = "Day30";
            this.Day30.Width = 36;
            // 
            // Day31
            // 
            this.Day31.DataPropertyName = "Day31";
            this.Day31.HeaderText = "31";
            this.Day31.MinimumWidth = 6;
            this.Day31.Name = "Day31";
            this.Day31.Width = 36;
            // 
            // MonthName
            // 
            this.MonthName.DataPropertyName = "MonthName";
            this.MonthName.HeaderText = "Ay";
            this.MonthName.MinimumWidth = 6;
            this.MonthName.Name = "MonthName";
            this.MonthName.Width = 44;
            // 
            // TotalCount
            // 
            this.TotalCount.DataPropertyName = "TotalCount";
            this.TotalCount.HeaderText = "Cəm Say";
            this.TotalCount.MinimumWidth = 6;
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Width = 60;
            // 
            // PriceOFOne
            // 
            this.PriceOFOne.DataPropertyName = "PriceOFOne";
            this.PriceOFOne.HeaderText = "Qiymət";
            this.PriceOFOne.MinimumWidth = 6;
            this.PriceOFOne.Name = "PriceOFOne";
            this.PriceOFOne.Width = 74;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Ümumi";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Width = 53;
            // 
            // SumInOneMonth
            // 
            this.SumInOneMonth.DataPropertyName = "SumInOneMonth";
            this.SumInOneMonth.HeaderText = "Aylıq";
            this.SumInOneMonth.MinimumWidth = 6;
            this.SumInOneMonth.Name = "SumInOneMonth";
            this.SumInOneMonth.Width = 80;
            // 
            // btnPrintSubmit
            // 
            this.btnPrintSubmit.Location = new System.Drawing.Point(13, 1);
            this.btnPrintSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintSubmit.Name = "btnPrintSubmit";
            this.btnPrintSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnPrintSubmit.TabIndex = 2;
            this.btnPrintSubmit.Text = "Yadda Saxla";
            this.btnPrintSubmit.UseVisualStyleBackColor = true;
            this.btnPrintSubmit.Click += new System.EventHandler(this.btnPrintSubmit_Click);
            // 
            // printDialog
            // 
            this.printDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printDialog.Document = this.printDocument1;
            this.printDialog.Enabled = true;
            this.printDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printDialog.Icon")));
            this.printDialog.Name = "printDialog";
            this.printDialog.Visible = false;
            // 
            // printForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2057, 1008);
            this.Controls.Add(this.btnPrintSubmit);
            this.Controls.Add(this.dgvDayForPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "printForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayForPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDayForPrint;
        private System.Windows.Forms.Button btnPrintSubmit;
        private System.Windows.Forms.PrintPreviewDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day29;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day30;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day31;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOFOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumInOneMonth;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}