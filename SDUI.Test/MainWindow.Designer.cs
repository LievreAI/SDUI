﻿using System.Windows.Forms;
using SDUI;

namespace SDUI.Test
{
    public partial class MainWindow
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
            this.tabControl1 = new SDUI.Controls.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new SDUI.Controls.ComboBox();
            this.textBox1 = new SDUI.Controls.TextBox();
            this.button3 = new SDUI.Controls.Button();
            this.button2 = new SDUI.Controls.Button();
            this.button1 = new SDUI.Controls.Button();
            this.progressBar1 = new SDUI.Controls.ProgressBar();
            this.buttonRandomColor = new System.Windows.Forms.Button();
            this.buttonOpenInputDialog = new System.Windows.Forms.Button();
            this.separator2 = new SDUI.Controls.Separator();
            this.separator1 = new SDUI.Controls.Separator();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new SDUI.Controls.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.buttonRandomColor);
            this.tabPage1.Controls.Add(this.buttonOpenInputDialog);
            this.tabPage1.Controls.Add(this.separator2);
            this.tabPage1.Controls.Add(this.separator1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(687, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // comboBox1
            // 
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownHeight = 100;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 17;
            this.comboBox1.Items.AddRange(new object[] {
            "asdfasdfasdfasdf",
            "asdfasdfasd",
            "asdfasdfasdfas",
            "asdfxcvxzcvzx",
            "1236afsdf"});
            this.comboBox1.Location = new System.Drawing.Point(180, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 23);
            this.comboBox1.StartIndex = 0;
            this.comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 100);
            this.textBox1.MaxLength = 32767;
            this.textBox1.MultiLine = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox1.UseSystemPasswordChar = false;
            // 
            // button3
            // 
            this.button3.Color = System.Drawing.Color.Maroon;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(222, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button1";
            // 
            // button2
            // 
            this.button2.Color = System.Drawing.Color.RoyalBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(23, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button1";
            // 
            // button1
            // 
            this.button1.Color = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(122, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.Gradient = new System.Drawing.Color[] {
        System.Drawing.Color.RosyBrown,
        System.Drawing.Color.Maroon};
            this.progressBar1.Location = new System.Drawing.Point(23, 45);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Maximum = ((long)(1000));
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.PercentIndices = 2;
            this.progressBar1.ShowAsPercent = true;
            this.progressBar1.ShowValue = true;
            this.progressBar1.Size = new System.Drawing.Size(179, 20);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Text = "22.2%";
            this.progressBar1.Value = ((long)(222));
            // 
            // buttonRandomColor
            // 
            this.buttonRandomColor.Location = new System.Drawing.Point(134, 16);
            this.buttonRandomColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRandomColor.Name = "buttonRandomColor";
            this.buttonRandomColor.Size = new System.Drawing.Size(153, 23);
            this.buttonRandomColor.TabIndex = 2;
            this.buttonRandomColor.Text = "Random Color";
            this.buttonRandomColor.UseVisualStyleBackColor = true;
            this.buttonRandomColor.Click += new System.EventHandler(this.buttonRandomColor_Click);
            // 
            // buttonOpenInputDialog
            // 
            this.buttonOpenInputDialog.Location = new System.Drawing.Point(23, 16);
            this.buttonOpenInputDialog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOpenInputDialog.Name = "buttonOpenInputDialog";
            this.buttonOpenInputDialog.Size = new System.Drawing.Size(105, 23);
            this.buttonOpenInputDialog.TabIndex = 1;
            this.buttonOpenInputDialog.Text = "Input Dialog";
            this.buttonOpenInputDialog.UseVisualStyleBackColor = true;
            this.buttonOpenInputDialog.Click += new System.EventHandler(this.buttonOpenInputDialog_Click);
            // 
            // separator2
            // 
            this.separator2.IsVertical = false;
            this.separator2.Location = new System.Drawing.Point(8, 6);
            this.separator2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(307, 2);
            this.separator2.TabIndex = 0;
            this.separator2.Text = "separator1";
            // 
            // separator1
            // 
            this.separator1.IsVertical = true;
            this.separator1.Location = new System.Drawing.Point(8, 14);
            this.separator1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(2, 222);
            this.separator1.TabIndex = 0;
            this.separator1.Text = "separator1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(687, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 3);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(679, 369);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 139;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 168;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 171;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 156;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 406);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Controls.Separator separator1;
        private Controls.Separator separator2;
        private Button buttonOpenInputDialog;
        private Button buttonRandomColor;
        private Controls.ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Controls.ProgressBar progressBar1;
        private Controls.Button button2;
        private Controls.Button button1;
        private Controls.TextBox textBox1;
        private Controls.Button button3;
        private Controls.ComboBox comboBox1;
    }
}