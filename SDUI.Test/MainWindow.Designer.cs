﻿using System.Windows.Forms;
using SDUI;
using SDUI.Controls;

namespace SDUI.Test;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("123412341234");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("123412341324");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "123412341324"}, -1, System.Drawing.Color.White, System.Drawing.SystemColors.HotTrack, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point));
            this.tabControl = new SDUI.Controls.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new SDUI.Controls.ContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.rsButton1 = new SDUI.Controls.Button();
            this.button6 = new SDUI.Controls.Button();
            this.groupBox4 = new SDUI.Controls.GroupBox();
            this.comboBox6 = new SDUI.Controls.ComboBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.comboBox5 = new SDUI.Controls.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button4 = new SDUI.Controls.Button();
            this.button2 = new SDUI.Controls.Button();
            this.label4 = new SDUI.Controls.Label();
            this.button5 = new SDUI.Controls.Button();
            this.groupBox3 = new SDUI.Controls.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radio2 = new SDUI.Controls.Radio();
            this.radio1 = new SDUI.Controls.Radio();
            this.checkBox6 = new SDUI.Controls.CheckBox();
            this.checkBox2 = new SDUI.Controls.CheckBox();
            this.checkBox1 = new SDUI.Controls.CheckBox();
            this.panel6 = new SDUI.Controls.Panel();
            this.panel5 = new SDUI.Controls.Panel();
            this.panel8 = new SDUI.Controls.Panel();
            this.toggleButton1 = new SDUI.Controls.ToggleButton();
            this.shapeProgressBar2 = new SDUI.Controls.ShapeProgressBar();
            this.shapeProgressBar1 = new SDUI.Controls.ShapeProgressBar();
            this.chatBubble2 = new SDUI.Controls.ChatBubble();
            this.chatBubble1 = new SDUI.Controls.ChatBubble();
            this.numUpDown1 = new SDUI.Controls.NumUpDown();
            this.checkBox4 = new SDUI.Controls.CheckBox();
            this.checkBox3 = new SDUI.Controls.CheckBox();
            this.label3 = new SDUI.Controls.Label();
            this.progressBar5 = new SDUI.Controls.ProgressBar();
            this.panel7 = new SDUI.Controls.Panel();
            this.panel4 = new SDUI.Controls.Panel();
            this.label2 = new SDUI.Controls.Label();
            this.label1 = new SDUI.Controls.Label();
            this.panel2 = new SDUI.Controls.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.separator5 = new SDUI.Controls.Separator();
            this.comboBox3 = new SDUI.Controls.ComboBox();
            this.separator3 = new SDUI.Controls.Separator();
            this.comboBox2 = new SDUI.Controls.ComboBox();
            this.groupBox2 = new SDUI.Controls.GroupBox();
            this.listView3 = new SDUI.Controls.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.comboBox4 = new SDUI.Controls.ComboBox();
            this.groupBox1 = new SDUI.Controls.GroupBox();
            this.separator4 = new SDUI.Controls.Separator();
            this.panel1 = new SDUI.Controls.Panel();
            this.listView2 = new SDUI.Controls.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.comboBox1 = new SDUI.Controls.ComboBox();
            this.textBox1 = new SDUI.Controls.TextBox();
            this.button3 = new SDUI.Controls.Button();
            this.buttonDark = new SDUI.Controls.Button();
            this.buttonLight = new SDUI.Controls.Button();
            this.progressBar9 = new SDUI.Controls.ProgressBar();
            this.progressBar8 = new SDUI.Controls.ProgressBar();
            this.progressBar4 = new SDUI.Controls.ProgressBar();
            this.progressBar7 = new SDUI.Controls.ProgressBar();
            this.progressBar3 = new SDUI.Controls.ProgressBar();
            this.progressBar6 = new SDUI.Controls.ProgressBar();
            this.progressBar2 = new SDUI.Controls.ProgressBar();
            this.progressBar1 = new SDUI.Controls.ProgressBar();
            this.separator2 = new SDUI.Controls.Separator();
            this.separator1 = new SDUI.Controls.Separator();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new SDUI.Controls.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.multiPageControl = new SDUI.Controls.MultiPageControl();
            this.buttonRemoveTab = new SDUI.Controls.Button();
            this.buttonAddTab = new SDUI.Controls.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonSelectColor = new SDUI.Controls.Button();
            this.comboBoxHatchType = new SDUI.Controls.ComboBox();
            this.checkBoxDrawFullHatch = new SDUI.Controls.CheckBox();
            this.checkBoxDrawTitleBarHatch = new SDUI.Controls.CheckBox();
            this.numTitleHeight = new SDUI.Controls.NumUpDown();
            this.numIconWidth = new SDUI.Controls.NumUpDown();
            this.label5 = new SDUI.Controls.Label();
            this.label6 = new SDUI.Controls.Label();
            this.menuStrip1 = new SDUI.Controls.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(80, 24);
            this.tabControl.Location = new System.Drawing.Point(0, 32);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1257, 583);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.ContextMenuStrip = this.contextMenuStrip1;
            this.tabPage1.Controls.Add(this.rsButton1);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.comboBox6);
            this.tabPage1.Controls.Add(this.trackBar2);
            this.tabPage1.Controls.Add(this.comboBox5);
            this.tabPage1.Controls.Add(this.trackBar1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.radio2);
            this.tabPage1.Controls.Add(this.radio1);
            this.tabPage1.Controls.Add(this.checkBox6);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel8);
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.buttonDark);
            this.tabPage1.Controls.Add(this.buttonLight);
            this.tabPage1.Controls.Add(this.progressBar9);
            this.tabPage1.Controls.Add(this.progressBar8);
            this.tabPage1.Controls.Add(this.progressBar4);
            this.tabPage1.Controls.Add(this.progressBar7);
            this.tabPage1.Controls.Add(this.progressBar3);
            this.tabPage1.Controls.Add(this.progressBar6);
            this.tabPage1.Controls.Add(this.progressBar2);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.separator2);
            this.tabPage1.Controls.Add(this.separator1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1249, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General UI";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripSeparator6});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 164);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripSeparator7,
            this.toolStripMenuItem10});
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem8.Text = "toolStripMenuItem8";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem9.Text = "toolStripMenuItem9";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(183, 6);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14});
            this.toolStripMenuItem10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem10.Text = "toolStripMenuItem10";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem11.Text = "toolStripMenuItem11";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem12.Text = "toolStripMenuItem12";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem13.Text = "toolStripMenuItem13";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem14.Text = "toolStripMenuItem14";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "toolStripMenuItem5";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "toolStripMenuItem6";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem7.Text = "toolStripMenuItem7";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // rsButton1
            // 
            this.rsButton1.Color = System.Drawing.Color.Transparent;
            this.rsButton1.Location = new System.Drawing.Point(416, 370);
            this.rsButton1.Name = "rsButton1";
            this.rsButton1.Radius = 6;
            this.rsButton1.ShadowDepth = 4F;
            this.rsButton1.Size = new System.Drawing.Size(75, 23);
            this.rsButton1.TabIndex = 33;
            this.rsButton1.Text = "rsButton1";
            this.rsButton1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Color = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(819, 385);
            this.button6.Name = "button6";
            this.button6.Radius = 6;
            this.button6.ShadowDepth = 4F;
            this.button6.Size = new System.Drawing.Size(99, 23);
            this.button6.TabIndex = 31;
            this.button6.Text = "Async Button";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Location = new System.Drawing.Point(432, 430);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox4.Radius = 10;
            this.groupBox4.ShadowDepth = 4;
            this.groupBox4.Size = new System.Drawing.Size(230, 106);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // comboBox6
            // 
            this.comboBox6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox6.DropDownHeight = 100;
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.IntegralHeight = false;
            this.comboBox6.ItemHeight = 17;
            this.comboBox6.Location = new System.Drawing.Point(24, 542);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Radius = 5;
            this.comboBox6.ShadowDepth = 4F;
            this.comboBox6.Size = new System.Drawing.Size(194, 23);
            this.comboBox6.TabIndex = 8;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(24, 491);
            this.trackBar2.Maximum = 24;
            this.trackBar2.Minimum = 4;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(233, 45);
            this.trackBar2.TabIndex = 29;
            this.trackBar2.Value = 4;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // comboBox5
            // 
            this.comboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox5.DropDownHeight = 100;
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.IntegralHeight = false;
            this.comboBox5.ItemHeight = 17;
            this.comboBox5.Items.AddRange(new object[] {
            "asdfasdfasdfasdf",
            "asdfasdfasd",
            "asdfasdfasdfas",
            "asdfxcvxzcvzx",
            "1236afsdf"});
            this.comboBox5.Location = new System.Drawing.Point(169, 101);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Radius = 5;
            this.comboBox5.ShadowDepth = 4F;
            this.comboBox5.Size = new System.Drawing.Size(146, 23);
            this.comboBox5.TabIndex = 8;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(20, 440);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(233, 45);
            this.trackBar1.TabIndex = 29;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button4
            // 
            this.button4.Color = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(20, 14);
            this.button4.Name = "button4";
            this.button4.Radius = 6;
            this.button4.ShadowDepth = 2F;
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Input Dialog";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonOpenInputDialog_Click);
            // 
            // button2
            // 
            this.button2.Color = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(130, 14);
            this.button2.Name = "button2";
            this.button2.Radius = 6;
            this.button2.ShadowDepth = 4F;
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Random Color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonRandomColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(159, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "label4";
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Color = System.Drawing.Color.Transparent;
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(942, 14);
            this.button5.Name = "button5";
            this.button5.Radius = 6;
            this.button5.ShadowDepth = 2F;
            this.button5.Size = new System.Drawing.Size(68, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "Disabled";
            this.button5.Click += new System.EventHandler(this.buttonLight_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(696, 430);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.groupBox3.Radius = 10;
            this.groupBox3.ShadowDepth = 4;
            this.groupBox3.Size = new System.Drawing.Size(287, 123);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(281, 96);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Checked = true;
            this.radio2.Location = new System.Drawing.Point(829, 342);
            this.radio2.Margin = new System.Windows.Forms.Padding(0);
            this.radio2.Name = "radio2";
            this.radio2.Ripple = true;
            this.radio2.Size = new System.Drawing.Size(65, 30);
            this.radio2.TabIndex = 24;
            this.radio2.TabStop = true;
            this.radio2.Text = "radio1";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(663, 342);
            this.radio1.Margin = new System.Windows.Forms.Padding(0);
            this.radio1.Name = "radio1";
            this.radio1.Ripple = true;
            this.radio1.Size = new System.Drawing.Size(65, 30);
            this.radio1.TabIndex = 24;
            this.radio1.Text = "radio1";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.BackColor = System.Drawing.Color.Transparent;
            this.checkBox6.Depth = 0;
            this.checkBox6.Location = new System.Drawing.Point(515, 370);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Ripple = true;
            this.checkBox6.Size = new System.Drawing.Size(143, 30);
            this.checkBox6.TabIndex = 14;
            this.checkBox6.Text = "Draw Debug Borders";
            this.checkBox6.UseVisualStyleBackColor = false;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Depth = 0;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(515, 349);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Ripple = true;
            this.checkBox2.Size = new System.Drawing.Size(87, 30);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "checkBox1";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Depth = 0;
            this.checkBox1.Location = new System.Drawing.Point(663, 370);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Ripple = true;
            this.checkBox1.Size = new System.Drawing.Size(142, 30);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "checkBox1 asdfadfas";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Border = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panel6.BorderColor = System.Drawing.Color.Transparent;
            this.panel6.Location = new System.Drawing.Point(23, 275);
            this.panel6.Name = "panel6";
            this.panel6.Radius = 0;
            this.panel6.ShadowDepth = 2F;
            this.panel6.Size = new System.Drawing.Size(63, 45);
            this.panel6.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Border = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.panel5.BorderColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(113, 275);
            this.panel5.Name = "panel5";
            this.panel5.Radius = 0;
            this.panel5.ShadowDepth = 2F;
            this.panel5.Size = new System.Drawing.Size(63, 45);
            this.panel5.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Border = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panel8.BorderColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.toggleButton1);
            this.panel8.Controls.Add(this.shapeProgressBar2);
            this.panel8.Controls.Add(this.shapeProgressBar1);
            this.panel8.Controls.Add(this.chatBubble2);
            this.panel8.Controls.Add(this.chatBubble1);
            this.panel8.Controls.Add(this.numUpDown1);
            this.panel8.Controls.Add(this.checkBox4);
            this.panel8.Controls.Add(this.checkBox3);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.progressBar5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1016, 0);
            this.panel8.Name = "panel8";
            this.panel8.Radius = 0;
            this.panel8.ShadowDepth = 2F;
            this.panel8.Size = new System.Drawing.Size(233, 551);
            this.panel8.TabIndex = 12;
            // 
            // toggleButton1
            // 
            this.toggleButton1.AutoSize = true;
            this.toggleButton1.BackColor = System.Drawing.Color.Transparent;
            this.toggleButton1.Location = new System.Drawing.Point(106, 380);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(46, 22);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Size = new System.Drawing.Size(46, 22);
            this.toggleButton1.TabIndex = 31;
            this.toggleButton1.UseVisualStyleBackColor = false;
            // 
            // shapeProgressBar2
            // 
            this.shapeProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.shapeProgressBar2.DrawHatch = true;
            this.shapeProgressBar2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shapeProgressBar2.Gradient = new System.Drawing.Color[] {
        System.Drawing.Color.Maroon,
        System.Drawing.Color.Red};
            this.shapeProgressBar2.HatchType = System.Drawing.Drawing2D.HatchStyle.ZigZag;
            this.shapeProgressBar2.Location = new System.Drawing.Point(122, 453);
            this.shapeProgressBar2.Maximum = ((long)(100));
            this.shapeProgressBar2.MinimumSize = new System.Drawing.Size(100, 100);
            this.shapeProgressBar2.Name = "shapeProgressBar2";
            this.shapeProgressBar2.Size = new System.Drawing.Size(113, 113);
            this.shapeProgressBar2.TabIndex = 30;
            this.shapeProgressBar2.Text = "shapeProgressBar1";
            this.shapeProgressBar2.Value = ((long)(52));
            // 
            // shapeProgressBar1
            // 
            this.shapeProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.shapeProgressBar1.DrawHatch = false;
            this.shapeProgressBar1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shapeProgressBar1.Gradient = new System.Drawing.Color[] {
        System.Drawing.Color.Maroon,
        System.Drawing.Color.Red};
            this.shapeProgressBar1.HatchType = System.Drawing.Drawing2D.HatchStyle.ZigZag;
            this.shapeProgressBar1.Location = new System.Drawing.Point(16, 453);
            this.shapeProgressBar1.Maximum = ((long)(100));
            this.shapeProgressBar1.MinimumSize = new System.Drawing.Size(100, 100);
            this.shapeProgressBar1.Name = "shapeProgressBar1";
            this.shapeProgressBar1.Size = new System.Drawing.Size(113, 113);
            this.shapeProgressBar1.TabIndex = 30;
            this.shapeProgressBar1.Text = "shapeProgressBar1";
            this.shapeProgressBar1.Value = ((long)(52));
            // 
            // chatBubble2
            // 
            this.chatBubble2.ArrowPosition = System.Windows.Forms.AnchorStyles.Right;
            this.chatBubble2.BackColor = System.Drawing.Color.Transparent;
            this.chatBubble2.BubbleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.chatBubble2.DrawBubbleArrow = true;
            this.chatBubble2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.chatBubble2.Location = new System.Drawing.Point(16, 326);
            this.chatBubble2.Name = "chatBubble2";
            this.chatBubble2.Size = new System.Drawing.Size(175, 38);
            this.chatBubble2.TabIndex = 28;
            this.chatBubble2.Text = "Hello Bob i am fine, Thanks";
            // 
            // chatBubble1
            // 
            this.chatBubble1.ArrowPosition = System.Windows.Forms.AnchorStyles.Left;
            this.chatBubble1.BackColor = System.Drawing.Color.Transparent;
            this.chatBubble1.BubbleColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.chatBubble1.DrawBubbleArrow = true;
            this.chatBubble1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.chatBubble1.Location = new System.Drawing.Point(43, 279);
            this.chatBubble1.Name = "chatBubble1";
            this.chatBubble1.Size = new System.Drawing.Size(175, 38);
            this.chatBubble1.TabIndex = 28;
            this.chatBubble1.Text = "Hello Jean How are you?";
            // 
            // numUpDown1
            // 
            this.numUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.numUpDown1.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numUpDown1.Location = new System.Drawing.Point(16, 379);
            this.numUpDown1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDown1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numUpDown1.MinimumSize = new System.Drawing.Size(80, 25);
            this.numUpDown1.Name = "numUpDown1";
            this.numUpDown1.Size = new System.Drawing.Size(80, 25);
            this.numUpDown1.TabIndex = 28;
            this.numUpDown1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Depth = 0;
            this.checkBox4.Location = new System.Drawing.Point(16, 238);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Ripple = true;
            this.checkBox4.Size = new System.Drawing.Size(87, 30);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "checkBox1";
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Depth = 0;
            this.checkBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox3.Location = new System.Drawing.Point(0, 0);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Ripple = true;
            this.checkBox3.Size = new System.Drawing.Size(233, 30);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Toggle Title";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.Click += new System.EventHandler(this.checkBox3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(8, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lorem Ipsum is simply dummy text \r\nof the printing and typesetting industry. ";
            // 
            // progressBar5
            // 
            this.progressBar5.BackColor = System.Drawing.Color.Transparent;
            this.progressBar5.DrawHatch = false;
            this.progressBar5.Gradient = new System.Drawing.Color[] {
        System.Drawing.Color.Maroon,
        System.Drawing.Color.Red};
            this.progressBar5.HatchType = System.Drawing.Drawing2D.HatchStyle.Percent10;
            this.progressBar5.Location = new System.Drawing.Point(16, 417);
            this.progressBar5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar5.Maximum = ((long)(100));
            this.progressBar5.MaxPercentShowValue = 100F;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.PercentIndices = 2;
            this.progressBar5.Radius = 4;
            this.progressBar5.ShowAsPercent = true;
            this.progressBar5.ShowValue = true;
            this.progressBar5.Size = new System.Drawing.Size(179, 16);
            this.progressBar5.TabIndex = 3;
            this.progressBar5.Text = "70.00%";
            this.progressBar5.Value = ((long)(70));
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Border = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panel7.BorderColor = System.Drawing.Color.Transparent;
            this.panel7.Location = new System.Drawing.Point(293, 275);
            this.panel7.Name = "panel7";
            this.panel7.Radius = 0;
            this.panel7.ShadowDepth = 2F;
            this.panel7.Size = new System.Drawing.Size(63, 45);
            this.panel7.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Border = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.panel4.BorderColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(203, 275);
            this.panel4.Name = "panel4";
            this.panel4.Radius = 0;
            this.panel4.ShadowDepth = 2F;
            this.panel4.Size = new System.Drawing.Size(63, 45);
            this.panel4.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(377, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(618, 106);
            this.label2.TabIndex = 11;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Border = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.panel2.BorderColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.separator3);
            this.panel2.Location = new System.Drawing.Point(23, 130);
            this.panel2.Name = "panel2";
            this.panel2.Radius = 5;
            this.panel2.ShadowDepth = 4F;
            this.panel2.Size = new System.Drawing.Size(333, 134);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.separator5);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Location = new System.Drawing.Point(17, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 100);
            this.panel3.TabIndex = 10;
            // 
            // separator5
            // 
            this.separator5.IsVertical = false;
            this.separator5.Location = new System.Drawing.Point(16, 15);
            this.separator5.Name = "separator5";
            this.separator5.Size = new System.Drawing.Size(120, 10);
            this.separator5.TabIndex = 0;
            this.separator5.Text = "separator3";
            // 
            // comboBox3
            // 
            this.comboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox3.DropDownHeight = 100;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.IntegralHeight = false;
            this.comboBox3.ItemHeight = 17;
            this.comboBox3.Items.AddRange(new object[] {
            "asdfasdfasdfasdf",
            "asdfasdfasd",
            "asdfasdfasdfas",
            "asdfxcvxzcvzx",
            "1236afsdf"});
            this.comboBox3.Location = new System.Drawing.Point(3, 32);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Radius = 5;
            this.comboBox3.ShadowDepth = 4F;
            this.comboBox3.Size = new System.Drawing.Size(194, 23);
            this.comboBox3.TabIndex = 8;
            // 
            // separator3
            // 
            this.separator3.IsVertical = false;
            this.separator3.Location = new System.Drawing.Point(17, 11);
            this.separator3.Name = "separator3";
            this.separator3.Size = new System.Drawing.Size(120, 10);
            this.separator3.TabIndex = 0;
            this.separator3.Text = "separator3";
            // 
            // comboBox2
            // 
            this.comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox2.DropDownHeight = 100;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.ItemHeight = 17;
            this.comboBox2.Location = new System.Drawing.Point(24, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Radius = 5;
            this.comboBox2.ShadowDepth = 2F;
            this.comboBox2.Size = new System.Drawing.Size(136, 23);
            this.comboBox2.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.listView3);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Location = new System.Drawing.Point(660, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox2.Radius = 10;
            this.groupBox2.ShadowDepth = 5;
            this.groupBox2.Size = new System.Drawing.Size(275, 190);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // listView3
            // 
            this.listView3.CheckBoxes = true;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.listView3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView3.FullRowSelect = true;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 1;
            listViewItem3.Checked = true;
            listViewItem3.StateImageIndex = 1;
            this.listView3.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView3.Location = new System.Drawing.Point(3, 58);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(269, 129);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView3_ItemCheck);
            this.listView3.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView3_ItemChecked);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Width = 220;
            // 
            // comboBox4
            // 
            this.comboBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox4.DropDownHeight = 100;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.IntegralHeight = false;
            this.comboBox4.ItemHeight = 17;
            this.comboBox4.Items.AddRange(new object[] {
            "asdfasdfasdfasdf",
            "asdfasdfasd",
            "asdfasdfasdfas",
            "asdfxcvxzcvzx",
            "1236afsdf"});
            this.comboBox4.Location = new System.Drawing.Point(3, 26);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Radius = 5;
            this.comboBox4.ShadowDepth = 0F;
            this.comboBox4.Size = new System.Drawing.Size(269, 23);
            this.comboBox4.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.separator4);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(363, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox1.Radius = 10;
            this.groupBox1.ShadowDepth = 5;
            this.groupBox1.Size = new System.Drawing.Size(275, 190);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // separator4
            // 
            this.separator4.IsVertical = false;
            this.separator4.Location = new System.Drawing.Point(17, 51);
            this.separator4.Name = "separator4";
            this.separator4.Size = new System.Drawing.Size(120, 10);
            this.separator4.TabIndex = 0;
            this.separator4.Text = "separator3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Border = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.panel1.BorderColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.listView2);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(6, 65);
            this.panel1.Name = "panel1";
            this.panel1.Radius = 1;
            this.panel1.ShadowDepth = 2F;
            this.panel1.Size = new System.Drawing.Size(263, 115);
            this.panel1.TabIndex = 9;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(10, 9);
            this.listView2.Name = "listView2";
            this.listView2.ShowItemToolTips = true;
            this.listView2.Size = new System.Drawing.Size(240, 97);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = 220;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.comboBox1.Location = new System.Drawing.Point(3, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Radius = 5;
            this.comboBox1.ShadowDepth = 0F;
            this.comboBox1.Size = new System.Drawing.Size(269, 23);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 74);
            this.textBox1.MaxLength = 32767;
            this.textBox1.MultiLine = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Radius = 2;
            this.textBox1.Size = new System.Drawing.Size(134, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox1.UseSystemPasswordChar = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Color = System.Drawing.Color.Maroon;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(222, 44);
            this.button3.Name = "button3";
            this.button3.Radius = 6;
            this.button3.ShadowDepth = 2F;
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button1";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonDark
            // 
            this.buttonDark.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDark.Color = System.Drawing.Color.RoyalBlue;
            this.buttonDark.ForeColor = System.Drawing.Color.White;
            this.buttonDark.Location = new System.Drawing.Point(23, 44);
            this.buttonDark.Name = "buttonDark";
            this.buttonDark.Radius = 6;
            this.buttonDark.ShadowDepth = 2F;
            this.buttonDark.Size = new System.Drawing.Size(93, 23);
            this.buttonDark.TabIndex = 4;
            this.buttonDark.Text = "Dark";
            this.buttonDark.Click += new System.EventHandler(this.buttonDark_Click);
            // 
            // buttonLight
            // 
            this.buttonLight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLight.Color = System.Drawing.Color.Transparent;
            this.buttonLight.Location = new System.Drawing.Point(122, 44);
            this.buttonLight.Name = "buttonLight";
            this.buttonLight.Radius = 6;
            this.buttonLight.ShadowDepth = 2F;
            this.buttonLight.Size = new System.Drawing.Size(93, 23);
            this.buttonLight.TabIndex = 4;
            this.buttonLight.Text = "Light";
            this.buttonLight.Click += new System.EventHandler(this.buttonLight_Click);
            // 
            // progressBar9
            // 
            this.progressBar9.BackColor = System.Drawing.Color.Transparent;
            this.progressBar9.DrawHatch = true;
            this.progressBar9.Gradient = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Yellow};
            this.progressBar9.HatchType = System.Drawing.Drawing2D.HatchStyle.Percent10;
            this.progressBar9.Location = new System.Drawing.Point(260, 440);
            this.progressBar9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar9.Maximum = ((long)(1000));
            this.progressBar9.MaxPercentShowValue = 100F;
            this.progressBar9.Name = "progressBar9";
            this.progressBar9.PercentIndices = 2;
            this.progressBar9.Radius = 4;
            this.progressBar9.ShowAsPercent = false;
            this.progressBar9.ShowValue = true;
            this.progressBar9.Size = new System.Drawing.Size(165, 25);
            this.progressBar9.TabIndex = 3;
            this.progressBar9.Text = "0 / 1000";
            this.progressBar9.Value = ((long)(0));
            // 
            // progressBar8
            // 
            this.progressBar8.BackColor = System.Drawing.Color.Transparent;
            this.progressBar8.DrawHatch = true;
            this.progressBar8.Gradient = new System.Drawing.Color[] {
        System.Drawing.Color.Gold,
        System.Drawing.Color.Yellow};
            this.progressBar8.HatchType = System.Drawing.Drawing2D.HatchStyle.Percent10;
            this.progressBar8.Location = new System.Drawing.Point(222, 385);
            this.progressBar8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar8.Maximum = ((long)(1000));
            this.progressBar8.MaxPercentShowValue = 100F;
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.PercentIndices = 2;
            this.progressBar8.Radius = 4;
            this.progressBar8.ShowAsPercent = false;
            this.progressBar8.ShowValue = true;
            this.progressBar8.Size = new System.Drawing.Size(179, 16);
            this.progressBar8.TabIndex = 3;
            this.progressBar8.Text = "777 / 1000";
            this.progressBar8.Value = ((long)(777));
            // 
            // progressBar4
            // 
            this.progressBar4.BackColor = System.Drawing.Color.Transparent;
            this.progressBar4.DrawHatch = false;
            this.progressBar4.Gradient = new System.Drawing.Color[] {
        System.Drawing.Color.Gold,
        System.Drawing.Color.Yellow};
            this.progressBar4.HatchType = System.Drawing.Drawing2D.HatchStyle.Percent10;
            this.progressBar4.Location = new System.Drawing.Point(20, 408);
            this.progressBar4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar4.Maximum = ((long)(1000));
            this.progressBar4.MaxPercentShowValue = 100F;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.PercentIndices = 2;
            this.progressBar4.Radius = 4;
            this.progressBar4.ShowAsPercent = false;
            this.progressBar4.ShowValue = true;
            this.progressBar4.Size = new System.Drawing.Size(179, 16);
            this.progressBar4.TabIndex = 3;
            this.progressBar4.Text = "777 / 1000";
            this.progressBar4.Value = ((long)(777));
            // 
            // progressBar7
            // 
            this.progressBar7.BackColor = System.Drawing.Color.Transparent;
            this.progressBar7.DrawHatch = false;
            this.progressBar7.Gradient = new System.Drawing.Color[] {
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.Lime};
            this.progressBar7.HatchType = System.Drawing.Drawing2D.HatchStyle.Percent10;
            this.progressBar7.Location = new System.Drawing.Point(222, 363);
            this.progressBar7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar7.Maximum = ((long)(1000));
            this.progressBar7.MaxPercentShowValue = 99.99F;
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.PercentIndices = 2;
            this.progressBar7.Radius = 4;
            this.progressBar7.ShowAsPercent = true;
            this.progressBar7.ShowValue = true;
            this.progressBar7.Size = new System.Drawing.Size(179, 16);
            this.progressBar7.TabIndex = 3;
            this.progressBar7.Text = "99.99%";
            this.progressBar7.Value = ((long)(1000));
            // 
            // progressBar3
            // 
            this.progressBar3.BackColor = System.Drawing.Color.Transparent;
            this.progressBar3.DrawHatch = false;
            this.progressBar3.Gradient = new System.Drawing.Color[] {
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.Lime};
            this.progressBar3.HatchType = System.Drawing.Drawing2D.HatchStyle.Percent10;
            this.progressBar3.Location = new System.Drawing.Point(20, 386);
            this.progressBar3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar3.Maximum = ((long)(1000));
            this.progressBar3.MaxPercentShowValue = 100F;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.PercentIndices = 2;
            this.progressBar3.Radius = 4;
            this.progressBar3.ShowAsPercent = true;
            this.progressBar3.ShowValue = true;
            this.progressBar3.Size = new System.Drawing.Size(179, 16);
            this.progressBar3.TabIndex = 3;
            this.progressBar3.Text = "62.30%";
            this.progressBar3.Value = ((long)(623));
            // 
            // progressBar6
            // 
            this.progressBar6.BackColor = System.Drawing.Color.Transparent;
            this.progressBar6.DrawHatch = false;
            this.progressBar6.Gradient = new System.Drawing.Color[] {
        System.Drawing.Color.MidnightBlue,
        System.Drawing.Color.RoyalBlue};
            this.progressBar6.HatchType = System.Drawing.Drawing2D.HatchStyle.Percent10;
            this.progressBar6.Location = new System.Drawing.Point(222, 341);
            this.progressBar6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar6.Maximum = ((long)(100));
            this.progressBar6.MaxPercentShowValue = 100F;
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.PercentIndices = 2;
            this.progressBar6.Radius = 4;
            this.progressBar6.ShowAsPercent = false;
            this.progressBar6.ShowValue = true;
            this.progressBar6.Size = new System.Drawing.Size(179, 16);
            this.progressBar6.TabIndex = 3;
            this.progressBar6.Text = "33 / 100";
            this.progressBar6.Value = ((long)(33));
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.Transparent;
            this.progressBar2.DrawHatch = false;
            this.progressBar2.Gradient = new System.Drawing.Color[] {
        System.Drawing.Color.MidnightBlue,
        System.Drawing.Color.RoyalBlue};
            this.progressBar2.HatchType = System.Drawing.Drawing2D.HatchStyle.Percent10;
            this.progressBar2.Location = new System.Drawing.Point(20, 364);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar2.Maximum = ((long)(100));
            this.progressBar2.MaxPercentShowValue = 100F;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.PercentIndices = 2;
            this.progressBar2.Radius = 4;
            this.progressBar2.ShowAsPercent = true;
            this.progressBar2.ShowValue = true;
            this.progressBar2.Size = new System.Drawing.Size(179, 16);
            this.progressBar2.TabIndex = 3;
            this.progressBar2.Text = "33.00%";
            this.progressBar2.Value = ((long)(33));
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.DrawHatch = false;
            this.progressBar1.Gradient = new System.Drawing.Color[] {
        System.Drawing.Color.Maroon,
        System.Drawing.Color.Red};
            this.progressBar1.HatchType = System.Drawing.Drawing2D.HatchStyle.Percent10;
            this.progressBar1.Location = new System.Drawing.Point(20, 342);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Maximum = ((long)(100));
            this.progressBar1.MaxPercentShowValue = 100F;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.PercentIndices = 2;
            this.progressBar1.Radius = 4;
            this.progressBar1.ShowAsPercent = true;
            this.progressBar1.ShowValue = true;
            this.progressBar1.Size = new System.Drawing.Size(179, 16);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Text = "70.00%";
            this.progressBar1.Value = ((long)(70));
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
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1249, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ListView";
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
            this.listView1.Location = new System.Drawing.Point(4, 3);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(1241, 545);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ColumnHeader 1";
            this.columnHeader1.Width = 139;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ColumnHeader 2";
            this.columnHeader2.Width = 168;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ColumnHeader 3";
            this.columnHeader3.Width = 171;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ColumnHeader 4";
            this.columnHeader4.Width = 156;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.multiPageControl);
            this.tabPage3.Controls.Add(this.buttonRemoveTab);
            this.tabPage3.Controls.Add(this.buttonAddTab);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1249, 551);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MultipageControl";
            // 
            // multiPageControl
            // 
            this.multiPageControl.BackColor = System.Drawing.Color.Transparent;
            this.multiPageControl.Border = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.multiPageControl.BorderColor = System.Drawing.Color.Transparent;
            this.multiPageControl.HeaderControlSize = new System.Drawing.Size(80, 30);
            this.multiPageControl.Location = new System.Drawing.Point(80, 70);
            this.multiPageControl.Name = "multiPageControl";
            this.multiPageControl.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.multiPageControl.Radius = 10;
            this.multiPageControl.SelectedIndex = 0;
            this.multiPageControl.ShadowDepth = 4F;
            this.multiPageControl.Size = new System.Drawing.Size(974, 420);
            this.multiPageControl.TabIndex = 5;
            // 
            // buttonRemoveTab
            // 
            this.buttonRemoveTab.Color = System.Drawing.Color.Transparent;
            this.buttonRemoveTab.Location = new System.Drawing.Point(171, 41);
            this.buttonRemoveTab.Name = "buttonRemoveTab";
            this.buttonRemoveTab.Radius = 6;
            this.buttonRemoveTab.ShadowDepth = 4F;
            this.buttonRemoveTab.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveTab.TabIndex = 1;
            this.buttonRemoveTab.Text = "Remove Tab";
            this.buttonRemoveTab.UseVisualStyleBackColor = true;
            this.buttonRemoveTab.Click += new System.EventHandler(this.buttonRemoveTab_Click);
            // 
            // buttonAddTab
            // 
            this.buttonAddTab.Color = System.Drawing.Color.Transparent;
            this.buttonAddTab.Location = new System.Drawing.Point(80, 41);
            this.buttonAddTab.Name = "buttonAddTab";
            this.buttonAddTab.Radius = 6;
            this.buttonAddTab.ShadowDepth = 4F;
            this.buttonAddTab.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTab.TabIndex = 1;
            this.buttonAddTab.Text = "Add tab";
            this.buttonAddTab.UseVisualStyleBackColor = true;
            this.buttonAddTab.Click += new System.EventHandler(this.buttonAddTab_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Controls.Add(this.buttonSelectColor);
            this.tabPage4.Controls.Add(this.comboBoxHatchType);
            this.tabPage4.Controls.Add(this.checkBoxDrawFullHatch);
            this.tabPage4.Controls.Add(this.checkBoxDrawTitleBarHatch);
            this.tabPage4.Controls.Add(this.numTitleHeight);
            this.tabPage4.Controls.Add(this.numIconWidth);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1249, 551);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Config";
            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.Color = System.Drawing.Color.Transparent;
            this.buttonSelectColor.Location = new System.Drawing.Point(731, 136);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.Radius = 6;
            this.buttonSelectColor.ShadowDepth = 4F;
            this.buttonSelectColor.Size = new System.Drawing.Size(95, 23);
            this.buttonSelectColor.TabIndex = 39;
            this.buttonSelectColor.Text = "Select Color";
            this.buttonSelectColor.UseVisualStyleBackColor = true;
            this.buttonSelectColor.Click += new System.EventHandler(this.buttonSelectColor_Click);
            // 
            // comboBoxHatchType
            // 
            this.comboBoxHatchType.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxHatchType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxHatchType.DropDownHeight = 100;
            this.comboBoxHatchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHatchType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(91)))));
            this.comboBoxHatchType.FormattingEnabled = true;
            this.comboBoxHatchType.IntegralHeight = false;
            this.comboBoxHatchType.ItemHeight = 16;
            this.comboBoxHatchType.Location = new System.Drawing.Point(595, 55);
            this.comboBoxHatchType.Name = "comboBoxHatchType";
            this.comboBoxHatchType.Radius = 5;
            this.comboBoxHatchType.ShadowDepth = 4F;
            this.comboBoxHatchType.Size = new System.Drawing.Size(121, 22);
            this.comboBoxHatchType.TabIndex = 34;
            this.comboBoxHatchType.SelectedIndexChanged += new System.EventHandler(this.comboBoxHatchType_SelectedIndexChanged);
            // 
            // checkBoxDrawFullHatch
            // 
            this.checkBoxDrawFullHatch.AutoSize = true;
            this.checkBoxDrawFullHatch.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDrawFullHatch.Depth = 0;
            this.checkBoxDrawFullHatch.Location = new System.Drawing.Point(731, 51);
            this.checkBoxDrawFullHatch.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDrawFullHatch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxDrawFullHatch.Name = "checkBoxDrawFullHatch";
            this.checkBoxDrawFullHatch.Ripple = true;
            this.checkBoxDrawFullHatch.Size = new System.Drawing.Size(111, 30);
            this.checkBoxDrawFullHatch.TabIndex = 37;
            this.checkBoxDrawFullHatch.Text = "Draw full hatch";
            this.checkBoxDrawFullHatch.UseVisualStyleBackColor = true;
            this.checkBoxDrawFullHatch.CheckedChanged += new System.EventHandler(this.checkBoxDrawFullHatch_CheckedChanged);
            // 
            // checkBoxDrawTitleBarHatch
            // 
            this.checkBoxDrawTitleBarHatch.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxDrawTitleBarHatch.AutoSize = true;
            this.checkBoxDrawTitleBarHatch.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDrawTitleBarHatch.Depth = 0;
            this.checkBoxDrawTitleBarHatch.Location = new System.Drawing.Point(438, 50);
            this.checkBoxDrawTitleBarHatch.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDrawTitleBarHatch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxDrawTitleBarHatch.Name = "checkBoxDrawTitleBarHatch";
            this.checkBoxDrawTitleBarHatch.Ripple = true;
            this.checkBoxDrawTitleBarHatch.Size = new System.Drawing.Size(139, 30);
            this.checkBoxDrawTitleBarHatch.TabIndex = 38;
            this.checkBoxDrawTitleBarHatch.Text = "Draw Title Bar hatch";
            this.checkBoxDrawTitleBarHatch.UseVisualStyleBackColor = true;
            this.checkBoxDrawTitleBarHatch.CheckedChanged += new System.EventHandler(this.checkBoxDrawTitleBarHatch_CheckedChanged);
            // 
            // numTitleHeight
            // 
            this.numTitleHeight.BackColor = System.Drawing.Color.Transparent;
            this.numTitleHeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numTitleHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.numTitleHeight.Location = new System.Drawing.Point(746, 95);
            this.numTitleHeight.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTitleHeight.Minimum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numTitleHeight.MinimumSize = new System.Drawing.Size(80, 25);
            this.numTitleHeight.Name = "numTitleHeight";
            this.numTitleHeight.Size = new System.Drawing.Size(80, 25);
            this.numTitleHeight.TabIndex = 32;
            this.numTitleHeight.Text = "rsNumericUpDown1";
            this.numTitleHeight.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numTitleHeight.ValueChanged += new System.EventHandler(this.numTitleHeight_ValueChanged);
            // 
            // numIconWidth
            // 
            this.numIconWidth.BackColor = System.Drawing.Color.Transparent;
            this.numIconWidth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numIconWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.numIconWidth.Location = new System.Drawing.Point(529, 95);
            this.numIconWidth.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numIconWidth.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numIconWidth.MinimumSize = new System.Drawing.Size(80, 25);
            this.numIconWidth.Name = "numIconWidth";
            this.numIconWidth.Size = new System.Drawing.Size(80, 25);
            this.numIconWidth.TabIndex = 33;
            this.numIconWidth.Text = "rsNumericUpDown1";
            this.numIconWidth.Value = new decimal(new int[] {
            41,
            0,
            0,
            0});
            this.numIconWidth.ValueChanged += new System.EventHandler(this.numIconWidth_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(449, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "IconWidth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(669, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Title Height:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 615);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(151, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Black;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Heuuuu";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 639);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainTabControl = this.tabControl;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Controls.TabControl tabControl;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Controls.Separator separator1;
    private Controls.Separator separator2;
    private Controls.ListView listView1;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private Controls.ProgressBar progressBar1;
    private Controls.Button buttonDark;
    private Controls.Button buttonLight;
    private Controls.TextBox textBox1;
    private Controls.Button button3;
    private Controls.ComboBox comboBox1;
    private Controls.GroupBox groupBox1;
    private Controls.ComboBox comboBox2;
    private Controls.Panel panel1;
    private Controls.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private Controls.Separator separator5;
    private Controls.Separator separator3;
    private Controls.Separator separator4;
    private Controls.Label label1;
    private Controls.Label label2;
    private Controls.Panel panel4;
    private Controls.Panel panel6;
    private Controls.Panel panel5;
    private Controls.Panel panel8;
    private Controls.Panel panel7;
    private Controls.CheckBox checkBox1;
    private Controls.CheckBox checkBox2;
    private Controls.CheckBox checkBox3;
    private Controls.CheckBox checkBox4;
    private Controls.ComboBox comboBox3;
    private Controls.Label label3;
    private Controls.CheckBox checkBox6;
    private RichTextBox richTextBox1;
    private Controls.MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem newToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem saveAsToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem printToolStripMenuItem;
    private ToolStripMenuItem printPreviewToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripMenuItem undoToolStripMenuItem;
    private ToolStripMenuItem redoToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem cutToolStripMenuItem;
    private ToolStripMenuItem copyToolStripMenuItem;
    private ToolStripMenuItem pasteToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripMenuItem selectAllToolStripMenuItem;
    private ToolStripMenuItem toolsToolStripMenuItem;
    private ToolStripMenuItem customizeToolStripMenuItem;
    private ToolStripMenuItem optionsToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem contentsToolStripMenuItem;
    private ToolStripMenuItem indexToolStripMenuItem;
    private ToolStripMenuItem searchToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private Controls.ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem toolStripMenuItem2;
    private ToolStripMenuItem toolStripMenuItem3;
    private ToolStripMenuItem toolStripMenuItem8;
    private ToolStripMenuItem toolStripMenuItem9;
    private ToolStripMenuItem toolStripMenuItem10;
    private ToolStripMenuItem toolStripMenuItem11;
    private ToolStripMenuItem toolStripMenuItem12;
    private ToolStripMenuItem toolStripMenuItem13;
    private ToolStripMenuItem toolStripMenuItem14;
    private ToolStripMenuItem toolStripMenuItem4;
    private ToolStripMenuItem toolStripMenuItem5;
    private ToolStripMenuItem toolStripMenuItem6;
    private ToolStripMenuItem toolStripMenuItem7;
    private ToolStripSeparator toolStripSeparator7;
    private ToolStripSeparator toolStripSeparator6;
    private Controls.Radio radio1;
    private Controls.ListView listView2;
    private ColumnHeader columnHeader5;
    private Controls.GroupBox groupBox2;
    private Controls.ListView listView3;
    private ColumnHeader columnHeader6;
    private Controls.ComboBox comboBox4;
    private Controls.Radio radio2;
    private Controls.ProgressBar progressBar4;
    private Controls.ProgressBar progressBar3;
    private Controls.ProgressBar progressBar2;
    private Controls.GroupBox groupBox3;
    private Controls.Label label4;
    private Controls.Button button4;
    private Controls.Button button2;
    private Controls.Button button5;
    private Controls.ChatBubble chatBubble1;
    private Controls.ChatBubble chatBubble2;
    private Controls.NumUpDown numUpDown1;
    private Controls.ShapeProgressBar shapeProgressBar1;
    private Controls.ProgressBar progressBar8;
    private Controls.ProgressBar progressBar7;
    private Controls.ProgressBar progressBar6;
    private Controls.ProgressBar progressBar5;
    private Controls.ShapeProgressBar shapeProgressBar2;
    private TrackBar trackBar1;
    private TrackBar trackBar2;
    private Controls.ComboBox comboBox5;
    private Controls.GroupBox groupBox4;
    private TabPage tabPage3;
    private Controls.Button buttonRemoveTab;
    private Controls.Button buttonAddTab;
    private Controls.ComboBox comboBox6;
    private Controls.ProgressBar progressBar9;
    private Controls.Button button6;
    private ToolTip toolTip1;
    private Controls.ToggleButton toggleButton1;
    private SDUI.Controls.Button rsButton1;
    private TabPage tabPage4;
    private Controls.Button buttonSelectColor;
    private Controls.ComboBox comboBoxHatchType;
    private Controls.CheckBox checkBoxDrawFullHatch;
    private Controls.CheckBox checkBoxDrawTitleBarHatch;
    private NumUpDown numTitleHeight;
    private NumUpDown numIconWidth;
    private Controls.Label label5;
    private Controls.Label label6;
    private MultiPageControl multiPageControl;
}