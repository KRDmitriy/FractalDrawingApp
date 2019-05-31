using System.Drawing;
using System;

namespace Kara_79
{
    partial class MainForm
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
            this.tableLayoutScalePanel = new System.Windows.Forms.TableLayoutPanel();
            this.MenuLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.HelloLabel2 = new System.Windows.Forms.Label();
            this.LabelDepth = new System.Windows.Forms.Label();
            this.EntryDepth = new System.Windows.Forms.TrackBar();
            this.LabelStartColor = new System.Windows.Forms.Label();
            this.EntryStartColor = new System.Windows.Forms.Button();
            this.LabelEndColor = new System.Windows.Forms.Label();
            this.EntryEndColor = new System.Windows.Forms.Button();
            this.TreeFractalLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.PifagorLabel = new System.Windows.Forms.Label();
            this.LabelCoef = new System.Windows.Forms.Label();
            this.EntryCoef = new System.Windows.Forms.TextBox();
            this.LabelCornerL = new System.Windows.Forms.Label();
            this.EntryCornerL = new System.Windows.Forms.TextBox();
            this.LabelCornerR = new System.Windows.Forms.Label();
            this.EntryCornerR = new System.Windows.Forms.TextBox();
            this.CantorLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.CantorLabel = new System.Windows.Forms.Label();
            this.LabelDistance = new System.Windows.Forms.Label();
            this.EntryDistance = new System.Windows.Forms.TextBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ShowPic1 = new System.Windows.Forms.PictureBox();
            this.ShowPic3 = new System.Windows.Forms.PictureBox();
            this.ShowPic2 = new System.Windows.Forms.PictureBox();
            this.LabelZoom = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PicLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.MainPic = new System.Windows.Forms.PictureBox();
            this.ChooseColor = new System.Windows.Forms.ColorDialog();
            this.ZoomBar = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutScalePanel.SuspendLayout();
            this.MenuLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntryDepth)).BeginInit();
            this.TreeFractalLayout.SuspendLayout();
            this.CantorLayout.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPic2)).BeginInit();
            this.PicLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutScalePanel
            // 
            this.tableLayoutScalePanel.AutoSize = true;
            this.tableLayoutScalePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutScalePanel.ColumnCount = 2;
            this.tableLayoutScalePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutScalePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutScalePanel.Controls.Add(this.MenuLayout, 0, 0);
            this.tableLayoutScalePanel.Controls.Add(this.PicLayout, 1, 0);
            this.tableLayoutScalePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutScalePanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutScalePanel.Name = "tableLayoutScalePanel";
            this.tableLayoutScalePanel.RowCount = 2;
            this.tableLayoutScalePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutScalePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutScalePanel.Size = new System.Drawing.Size(962, 669);
            this.tableLayoutScalePanel.TabIndex = 0;
            // 
            // MenuLayout
            // 
            this.MenuLayout.AutoSize = true;
            this.MenuLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MenuLayout.Controls.Add(this.HelloLabel);
            this.MenuLayout.Controls.Add(this.HelloLabel2);
            this.MenuLayout.Controls.Add(this.LabelDepth);
            this.MenuLayout.Controls.Add(this.EntryDepth);
            this.MenuLayout.Controls.Add(this.LabelStartColor);
            this.MenuLayout.Controls.Add(this.EntryStartColor);
            this.MenuLayout.Controls.Add(this.LabelEndColor);
            this.MenuLayout.Controls.Add(this.EntryEndColor);
            this.MenuLayout.Controls.Add(this.TreeFractalLayout);
            this.MenuLayout.Controls.Add(this.CantorLayout);
            this.MenuLayout.Controls.Add(this.ButtonPanel);
            this.MenuLayout.Controls.Add(this.LabelZoom);
            this.MenuLayout.Controls.Add(this.ZoomBar);
            this.MenuLayout.Controls.Add(this.SaveButton);
            this.MenuLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MenuLayout.Location = new System.Drawing.Point(3, 3);
            this.MenuLayout.Name = "MenuLayout";
            this.MenuLayout.Size = new System.Drawing.Size(261, 643);
            this.MenuLayout.TabIndex = 0;
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HelloLabel.Location = new System.Drawing.Point(3, 0);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(255, 17);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "Добро пожаловать!";
            this.HelloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HelloLabel2
            // 
            this.HelloLabel2.AutoSize = true;
            this.HelloLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.HelloLabel2.Location = new System.Drawing.Point(3, 22);
            this.HelloLabel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.HelloLabel2.Name = "HelloLabel2";
            this.HelloLabel2.Size = new System.Drawing.Size(255, 17);
            this.HelloLabel2.TabIndex = 1;
            this.HelloLabel2.Text = "Фракталы на любой вкус и цвет";
            this.HelloLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDepth
            // 
            this.LabelDepth.AutoSize = true;
            this.LabelDepth.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelDepth.Location = new System.Drawing.Point(3, 39);
            this.LabelDepth.Name = "LabelDepth";
            this.LabelDepth.Size = new System.Drawing.Size(255, 17);
            this.LabelDepth.TabIndex = 1;
            this.LabelDepth.Text = "Глубина рекурсии: 7";
            // 
            // EntryDepth
            // 
            this.EntryDepth.Dock = System.Windows.Forms.DockStyle.Top;
            this.EntryDepth.Location = new System.Drawing.Point(3, 59);
            this.EntryDepth.Maximum = 18;
            this.EntryDepth.Minimum = 1;
            this.EntryDepth.Name = "EntryDepth";
            this.EntryDepth.Size = new System.Drawing.Size(255, 56);
            this.EntryDepth.TabIndex = 13;
            this.EntryDepth.Value = 5;
            this.EntryDepth.ValueChanged += new System.EventHandler(this.EntryDepth_ValueChanged);
            // 
            // LabelStartColor
            // 
            this.LabelStartColor.AutoSize = true;
            this.LabelStartColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelStartColor.Location = new System.Drawing.Point(3, 121);
            this.LabelStartColor.Margin = new System.Windows.Forms.Padding(3);
            this.LabelStartColor.Name = "LabelStartColor";
            this.LabelStartColor.Size = new System.Drawing.Size(255, 17);
            this.LabelStartColor.TabIndex = 3;
            this.LabelStartColor.Text = "Введите начальный цвет";
            // 
            // EntryStartColor
            // 
            this.EntryStartColor.BackColor = System.Drawing.Color.Red;
            this.EntryStartColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.EntryStartColor.Location = new System.Drawing.Point(3, 144);
            this.EntryStartColor.Name = "EntryStartColor";
            this.EntryStartColor.Size = new System.Drawing.Size(255, 23);
            this.EntryStartColor.TabIndex = 16;
            this.EntryStartColor.UseVisualStyleBackColor = false;
            this.EntryStartColor.BackColorChanged += new System.EventHandler(this.EntryCoef_TextChanged);
            this.EntryStartColor.Click += new System.EventHandler(this.EntryStartcolor_Click);
            // 
            // LabelEndColor
            // 
            this.LabelEndColor.AutoSize = true;
            this.LabelEndColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelEndColor.Location = new System.Drawing.Point(3, 170);
            this.LabelEndColor.Name = "LabelEndColor";
            this.LabelEndColor.Size = new System.Drawing.Size(255, 17);
            this.LabelEndColor.TabIndex = 5;
            this.LabelEndColor.Text = "Введите конечный цвет";
            // 
            // EntryEndColor
            // 
            this.EntryEndColor.BackColor = System.Drawing.Color.Green;
            this.EntryEndColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.EntryEndColor.Location = new System.Drawing.Point(3, 190);
            this.EntryEndColor.Name = "EntryEndColor";
            this.EntryEndColor.Size = new System.Drawing.Size(255, 23);
            this.EntryEndColor.TabIndex = 7;
            this.EntryEndColor.UseVisualStyleBackColor = false;
            this.EntryEndColor.BackColorChanged += new System.EventHandler(this.EntryCoef_TextChanged);
            this.EntryEndColor.Click += new System.EventHandler(this.EntryEndColor_Click);
            // 
            // TreeFractalLayout
            // 
            this.TreeFractalLayout.AutoSize = true;
            this.TreeFractalLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TreeFractalLayout.BackColor = System.Drawing.SystemColors.Control;
            this.TreeFractalLayout.Controls.Add(this.PifagorLabel);
            this.TreeFractalLayout.Controls.Add(this.LabelCoef);
            this.TreeFractalLayout.Controls.Add(this.EntryCoef);
            this.TreeFractalLayout.Controls.Add(this.LabelCornerL);
            this.TreeFractalLayout.Controls.Add(this.EntryCornerL);
            this.TreeFractalLayout.Controls.Add(this.LabelCornerR);
            this.TreeFractalLayout.Controls.Add(this.EntryCornerR);
            this.TreeFractalLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.TreeFractalLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TreeFractalLayout.Location = new System.Drawing.Point(0, 216);
            this.TreeFractalLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TreeFractalLayout.Name = "TreeFractalLayout";
            this.TreeFractalLayout.Size = new System.Drawing.Size(261, 157);
            this.TreeFractalLayout.TabIndex = 8;
            this.TreeFractalLayout.Visible = false;
            // 
            // PifagorLabel
            // 
            this.PifagorLabel.AutoSize = true;
            this.PifagorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PifagorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PifagorLabel.Location = new System.Drawing.Point(3, 0);
            this.PifagorLabel.Name = "PifagorLabel";
            this.PifagorLabel.Size = new System.Drawing.Size(255, 17);
            this.PifagorLabel.TabIndex = 6;
            this.PifagorLabel.Text = "Дерево Пифагора";
            this.PifagorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCoef
            // 
            this.LabelCoef.AutoSize = true;
            this.LabelCoef.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelCoef.Location = new System.Drawing.Point(3, 22);
            this.LabelCoef.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.LabelCoef.Name = "LabelCoef";
            this.LabelCoef.Size = new System.Drawing.Size(255, 17);
            this.LabelCoef.TabIndex = 0;
            this.LabelCoef.Text = "Введите коэффициент";
            // 
            // EntryCoef
            // 
            this.EntryCoef.Dock = System.Windows.Forms.DockStyle.Top;
            this.EntryCoef.Location = new System.Drawing.Point(3, 42);
            this.EntryCoef.Name = "EntryCoef";
            this.EntryCoef.Size = new System.Drawing.Size(255, 22);
            this.EntryCoef.TabIndex = 3;
            this.EntryCoef.Text = "0,7";
            // 
            // LabelCornerL
            // 
            this.LabelCornerL.AutoSize = true;
            this.LabelCornerL.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelCornerL.Location = new System.Drawing.Point(3, 67);
            this.LabelCornerL.Name = "LabelCornerL";
            this.LabelCornerL.Size = new System.Drawing.Size(255, 17);
            this.LabelCornerL.TabIndex = 2;
            this.LabelCornerL.Text = " Введите левый угол";
            // 
            // EntryCornerL
            // 
            this.EntryCornerL.Dock = System.Windows.Forms.DockStyle.Top;
            this.EntryCornerL.Location = new System.Drawing.Point(3, 87);
            this.EntryCornerL.Name = "EntryCornerL";
            this.EntryCornerL.Size = new System.Drawing.Size(255, 22);
            this.EntryCornerL.TabIndex = 4;
            this.EntryCornerL.Text = "45";
            // 
            // LabelCornerR
            // 
            this.LabelCornerR.AutoSize = true;
            this.LabelCornerR.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelCornerR.Location = new System.Drawing.Point(3, 112);
            this.LabelCornerR.Name = "LabelCornerR";
            this.LabelCornerR.Size = new System.Drawing.Size(255, 17);
            this.LabelCornerR.TabIndex = 4;
            this.LabelCornerR.Text = "Введите правый угол";
            // 
            // EntryCornerR
            // 
            this.EntryCornerR.Location = new System.Drawing.Point(3, 132);
            this.EntryCornerR.Name = "EntryCornerR";
            this.EntryCornerR.Size = new System.Drawing.Size(255, 22);
            this.EntryCornerR.TabIndex = 5;
            this.EntryCornerR.Text = "45";
            // 
            // CantorLayout
            // 
            this.CantorLayout.AutoSize = true;
            this.CantorLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CantorLayout.Controls.Add(this.CantorLabel);
            this.CantorLayout.Controls.Add(this.LabelDistance);
            this.CantorLayout.Controls.Add(this.EntryDistance);
            this.CantorLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.CantorLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CantorLayout.Location = new System.Drawing.Point(0, 373);
            this.CantorLayout.Margin = new System.Windows.Forms.Padding(0);
            this.CantorLayout.Name = "CantorLayout";
            this.CantorLayout.Size = new System.Drawing.Size(261, 67);
            this.CantorLayout.TabIndex = 9;
            this.CantorLayout.Visible = false;
            // 
            // CantorLabel
            // 
            this.CantorLabel.AutoSize = true;
            this.CantorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CantorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CantorLabel.Location = new System.Drawing.Point(3, 5);
            this.CantorLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.CantorLabel.Name = "CantorLabel";
            this.CantorLabel.Size = new System.Drawing.Size(252, 17);
            this.CantorLabel.TabIndex = 7;
            this.CantorLabel.Text = "Множество Кантора";
            this.CantorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDistance
            // 
            this.LabelDistance.AutoSize = true;
            this.LabelDistance.Location = new System.Drawing.Point(3, 22);
            this.LabelDistance.Name = "LabelDistance";
            this.LabelDistance.Size = new System.Drawing.Size(144, 17);
            this.LabelDistance.TabIndex = 8;
            this.LabelDistance.Text = "Введите расстояние";
            // 
            // EntryDistance
            // 
            this.EntryDistance.Location = new System.Drawing.Point(3, 42);
            this.EntryDistance.Name = "EntryDistance";
            this.EntryDistance.Size = new System.Drawing.Size(252, 22);
            this.EntryDistance.TabIndex = 9;
            this.EntryDistance.Text = "30";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.ShowPic1);
            this.ButtonPanel.Controls.Add(this.ShowPic3);
            this.ButtonPanel.Controls.Add(this.ShowPic2);
            this.ButtonPanel.Location = new System.Drawing.Point(3, 443);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(252, 62);
            this.ButtonPanel.TabIndex = 12;
            // 
            // ShowPic1
            // 
            this.ShowPic1.Location = new System.Drawing.Point(3, 0);
            this.ShowPic1.Name = "ShowPic1";
            this.ShowPic1.Size = new System.Drawing.Size(52, 52);
            this.ShowPic1.TabIndex = 8;
            this.ShowPic1.TabStop = false;
            this.ShowPic1.Click += new System.EventHandler(this.ShowPic_Click);
            // 
            // ShowPic3
            // 
            this.ShowPic3.BackColor = System.Drawing.SystemColors.Control;
            this.ShowPic3.Cursor = System.Windows.Forms.Cursors.Default;
            this.ShowPic3.Location = new System.Drawing.Point(126, 0);
            this.ShowPic3.Margin = new System.Windows.Forms.Padding(0);
            this.ShowPic3.MaximumSize = new System.Drawing.Size(79, 54);
            this.ShowPic3.Name = "ShowPic3";
            this.ShowPic3.Size = new System.Drawing.Size(52, 52);
            this.ShowPic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ShowPic3.TabIndex = 7;
            this.ShowPic3.TabStop = false;
            this.ShowPic3.Click += new System.EventHandler(this.ShowPic3_Click);
            // 
            // ShowPic2
            // 
            this.ShowPic2.BackColor = System.Drawing.SystemColors.Control;
            this.ShowPic2.Location = new System.Drawing.Point(68, 0);
            this.ShowPic2.Margin = new System.Windows.Forms.Padding(0);
            this.ShowPic2.MaximumSize = new System.Drawing.Size(79, 70);
            this.ShowPic2.Name = "ShowPic2";
            this.ShowPic2.Size = new System.Drawing.Size(52, 52);
            this.ShowPic2.TabIndex = 6;
            this.ShowPic2.TabStop = false;
            this.ShowPic2.Click += new System.EventHandler(this.ShowPic2_Click);
            // 
            // LabelZoom
            // 
            this.LabelZoom.AutoSize = true;
            this.LabelZoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelZoom.Location = new System.Drawing.Point(3, 508);
            this.LabelZoom.Name = "LabelZoom";
            this.LabelZoom.Size = new System.Drawing.Size(255, 17);
            this.LabelZoom.TabIndex = 15;
            this.LabelZoom.Text = " Zoom: 1";
            this.LabelZoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(3, 556);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(252, 40);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save as Image";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PicLayout
            // 
            this.PicLayout.AutoScroll = true;
            this.PicLayout.Controls.Add(this.MainPic);
            this.PicLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PicLayout.Location = new System.Drawing.Point(267, 0);
            this.PicLayout.Margin = new System.Windows.Forms.Padding(0);
            this.PicLayout.Name = "PicLayout";
            this.PicLayout.Size = new System.Drawing.Size(695, 649);
            this.PicLayout.TabIndex = 1;
            // 
            // MainPic
            // 
            this.MainPic.Location = new System.Drawing.Point(0, 0);
            this.MainPic.Margin = new System.Windows.Forms.Padding(0);
            this.MainPic.Name = "MainPic";
            this.MainPic.Size = new System.Drawing.Size(637, 521);
            this.MainPic.TabIndex = 0;
            this.MainPic.TabStop = false;
            this.MainPic.BackColorChanged += new System.EventHandler(this.EntryCoef_TextChanged);
            // 
            // ZoomBar
            // 
            this.ZoomBar.Location = new System.Drawing.Point(3, 528);
            this.ZoomBar.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.ZoomBar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ZoomBar.Name = "ZoomBar";
            this.ZoomBar.Size = new System.Drawing.Size(120, 22);
            this.ZoomBar.TabIndex = 17;
            this.ZoomBar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ZoomBar.ValueChanged += new System.EventHandler(this.ZoomBar_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 669);
            this.Controls.Add(this.tableLayoutScalePanel);
            this.MinimumSize = new System.Drawing.Size(980, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Фракталы";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.tableLayoutScalePanel.ResumeLayout(false);
            this.tableLayoutScalePanel.PerformLayout();
            this.MenuLayout.ResumeLayout(false);
            this.MenuLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntryDepth)).EndInit();
            this.TreeFractalLayout.ResumeLayout(false);
            this.TreeFractalLayout.PerformLayout();
            this.CantorLayout.ResumeLayout(false);
            this.CantorLayout.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPic2)).EndInit();
            this.PicLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutScalePanel;
        private System.Windows.Forms.FlowLayoutPanel MenuLayout;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Label HelloLabel2;
        private System.Windows.Forms.Label LabelDepth;
        private System.Windows.Forms.Label LabelStartColor;
        private System.Windows.Forms.Label LabelEndColor;
        private System.Windows.Forms.TextBox EntryCornerL;
        private System.Windows.Forms.Label LabelCoef;
        private System.Windows.Forms.TextBox EntryCoef;
        private System.Windows.Forms.Label LabelCornerR;
        private System.Windows.Forms.TextBox EntryCornerR;
        private System.Windows.Forms.FlowLayoutPanel PicLayout;
        private System.Windows.Forms.PictureBox MainPic;
        private System.Windows.Forms.PictureBox ShowPic2;
        private System.Windows.Forms.PictureBox ShowPic3;
        private System.Windows.Forms.FlowLayoutPanel TreeFractalLayout;
        private System.Windows.Forms.Label LabelCornerL;
        private System.Windows.Forms.Label PifagorLabel;
        private System.Windows.Forms.FlowLayoutPanel CantorLayout;
        private System.Windows.Forms.Label CantorLabel;
        private System.Windows.Forms.Label LabelDistance;
        private System.Windows.Forms.TextBox EntryDistance;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.PictureBox ShowPic1;
        private System.Windows.Forms.ColorDialog ChooseColor;
        private System.Windows.Forms.TrackBar EntryDepth;
        private System.Windows.Forms.Label LabelZoom;
        private System.Windows.Forms.Button EntryStartColor;
        private System.Windows.Forms.Button EntryEndColor;
        private System.Windows.Forms.NumericUpDown ZoomBar;
    }
}
