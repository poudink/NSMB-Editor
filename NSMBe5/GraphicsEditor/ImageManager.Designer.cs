﻿namespace NSMBe5
{
    partial class ImageManager
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
            this.imageListBox = new System.Windows.Forms.ListBox();
            this.paletteListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblBitmaps = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPalettes = new System.Windows.Forms.Label();
            this.image2dOptions = new System.Windows.Forms.Panel();
            this.fourBppCheckBox = new System.Windows.Forms.CheckBox();
            this.tileOffsetNumber = new System.Windows.Forms.NumericUpDown();
            this.lblTileOffset = new System.Windows.Forms.Label();
            this.tileWidthNumber = new System.Windows.Forms.NumericUpDown();
            this.lblTileWidth = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.autopaletteCheckBox = new System.Windows.Forms.CheckBox();
            this.importAllBtn = new System.Windows.Forms.Button();
            this.saveAllBtn = new System.Windows.Forms.Button();
            this.exportAllBtn = new System.Windows.Forms.Button();
            this.importThisWithPalBtn = new System.Windows.Forms.Button();
            this.importThisBtn = new System.Windows.Forms.Button();
            this.exportThisBtn = new System.Windows.Forms.Button();
            this.graphicsEditor1 = new NSMBe5.GraphicsEditor();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.image2dOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileOffsetNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileWidthNumber)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListBox
            // 
            this.imageListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageListBox.FormattingEnabled = true;
            this.imageListBox.ItemHeight = 16;
            this.imageListBox.Location = new System.Drawing.Point(0, 17);
            this.imageListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageListBox.Name = "imageListBox";
            this.imageListBox.Size = new System.Drawing.Size(324, 119);
            this.imageListBox.TabIndex = 1;
            this.imageListBox.SelectedIndexChanged += new System.EventHandler(this.imageListBox_SelectedIndexChanged);
            this.imageListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageListBox_MouseDown);
            // 
            // paletteListBox
            // 
            this.paletteListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paletteListBox.FormattingEnabled = true;
            this.paletteListBox.ItemHeight = 16;
            this.paletteListBox.Location = new System.Drawing.Point(0, 17);
            this.paletteListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paletteListBox.Name = "paletteListBox";
            this.paletteListBox.Size = new System.Drawing.Size(324, 120);
            this.paletteListBox.TabIndex = 2;
            this.paletteListBox.SelectedIndexChanged += new System.EventHandler(this.paletteListBox_SelectedIndexChanged);
            this.paletteListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paletteListBox_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.image2dOptions);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 625);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 289);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.imageListBox);
            this.panel4.Controls.Add(this.lblBitmaps);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 136);
            this.panel4.TabIndex = 5;
            // 
            // lblBitmaps
            // 
            this.lblBitmaps.AutoSize = true;
            this.lblBitmaps.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBitmaps.Location = new System.Drawing.Point(0, 0);
            this.lblBitmaps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBitmaps.Name = "lblBitmaps";
            this.lblBitmaps.Size = new System.Drawing.Size(74, 17);
            this.lblBitmaps.TabIndex = 2;
            this.lblBitmaps.Text = "<Bitmaps>";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.paletteListBox);
            this.panel3.Controls.Add(this.lblPalettes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 148);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 137);
            this.panel3.TabIndex = 4;
            // 
            // lblPalettes
            // 
            this.lblPalettes.AutoSize = true;
            this.lblPalettes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPalettes.Location = new System.Drawing.Point(0, 0);
            this.lblPalettes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalettes.Name = "lblPalettes";
            this.lblPalettes.Size = new System.Drawing.Size(75, 17);
            this.lblPalettes.TabIndex = 3;
            this.lblPalettes.Text = "<Palettes>";
            // 
            // image2dOptions
            // 
            this.image2dOptions.Controls.Add(this.fourBppCheckBox);
            this.image2dOptions.Controls.Add(this.tileOffsetNumber);
            this.image2dOptions.Controls.Add(this.lblTileOffset);
            this.image2dOptions.Controls.Add(this.tileWidthNumber);
            this.image2dOptions.Controls.Add(this.lblTileWidth);
            this.image2dOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.image2dOptions.Location = new System.Drawing.Point(0, 289);
            this.image2dOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.image2dOptions.Name = "image2dOptions";
            this.image2dOptions.Size = new System.Drawing.Size(332, 107);
            this.image2dOptions.TabIndex = 3;
            // 
            // fourBppCheckBox
            // 
            this.fourBppCheckBox.AutoSize = true;
            this.fourBppCheckBox.Location = new System.Drawing.Point(59, 70);
            this.fourBppCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fourBppCheckBox.Name = "fourBppCheckBox";
            this.fourBppCheckBox.Size = new System.Drawing.Size(162, 21);
            this.fourBppCheckBox.TabIndex = 2;
            this.fourBppCheckBox.Text = "<ViewIn4bppFormat>";
            this.fourBppCheckBox.UseVisualStyleBackColor = true;
            this.fourBppCheckBox.CheckedChanged += new System.EventHandler(this.tileWidthNumber_ValueChanged);
            // 
            // tileOffsetNumber
            // 
            this.tileOffsetNumber.Enabled = false;
            this.tileOffsetNumber.Location = new System.Drawing.Point(100, 38);
            this.tileOffsetNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tileOffsetNumber.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.tileOffsetNumber.Name = "tileOffsetNumber";
            this.tileOffsetNumber.Size = new System.Drawing.Size(224, 22);
            this.tileOffsetNumber.TabIndex = 1;
            this.tileOffsetNumber.ValueChanged += new System.EventHandler(this.tileWidthNumber_ValueChanged);
            // 
            // lblTileOffset
            // 
            this.lblTileOffset.AutoSize = true;
            this.lblTileOffset.Location = new System.Drawing.Point(4, 41);
            this.lblTileOffset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTileOffset.Name = "lblTileOffset";
            this.lblTileOffset.Size = new System.Drawing.Size(85, 17);
            this.lblTileOffset.TabIndex = 0;
            this.lblTileOffset.Text = "<TileOffset>";
            // 
            // tileWidthNumber
            // 
            this.tileWidthNumber.Enabled = false;
            this.tileWidthNumber.Location = new System.Drawing.Point(100, 6);
            this.tileWidthNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tileWidthNumber.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.tileWidthNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tileWidthNumber.Name = "tileWidthNumber";
            this.tileWidthNumber.Size = new System.Drawing.Size(224, 22);
            this.tileWidthNumber.TabIndex = 1;
            this.tileWidthNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tileWidthNumber.ValueChanged += new System.EventHandler(this.tileWidthNumber_ValueChanged);
            // 
            // lblTileWidth
            // 
            this.lblTileWidth.AutoSize = true;
            this.lblTileWidth.Location = new System.Drawing.Point(4, 9);
            this.lblTileWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTileWidth.Name = "lblTileWidth";
            this.lblTileWidth.Size = new System.Drawing.Size(83, 17);
            this.lblTileWidth.TabIndex = 0;
            this.lblTileWidth.Text = "<TileWidth>";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.autopaletteCheckBox);
            this.panel2.Controls.Add(this.importAllBtn);
            this.panel2.Controls.Add(this.saveAllBtn);
            this.panel2.Controls.Add(this.exportAllBtn);
            this.panel2.Controls.Add(this.importThisWithPalBtn);
            this.panel2.Controls.Add(this.importThisBtn);
            this.panel2.Controls.Add(this.exportThisBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 396);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 229);
            this.panel2.TabIndex = 5;
            // 
            // autopaletteCheckBox
            // 
            this.autopaletteCheckBox.AutoSize = true;
            this.autopaletteCheckBox.Checked = true;
            this.autopaletteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autopaletteCheckBox.Location = new System.Drawing.Point(8, 196);
            this.autopaletteCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.autopaletteCheckBox.Name = "autopaletteCheckBox";
            this.autopaletteCheckBox.Size = new System.Drawing.Size(163, 21);
            this.autopaletteCheckBox.TabIndex = 3;
            this.autopaletteCheckBox.Text = "<Auto palette select>";
            this.autopaletteCheckBox.UseVisualStyleBackColor = true;
            // 
            // importAllBtn
            // 
            this.importAllBtn.Location = new System.Drawing.Point(4, 160);
            this.importAllBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.importAllBtn.Name = "importAllBtn";
            this.importAllBtn.Size = new System.Drawing.Size(316, 28);
            this.importAllBtn.TabIndex = 0;
            this.importAllBtn.Text = "<Import all bitmaps with all palettes>";
            this.importAllBtn.UseVisualStyleBackColor = true;
            this.importAllBtn.Click += new System.EventHandler(this.importAllBtn_Click);
            // 
            // saveAllBtn
            // 
            this.saveAllBtn.Location = new System.Drawing.Point(224, 4);
            this.saveAllBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveAllBtn.Name = "saveAllBtn";
            this.saveAllBtn.Size = new System.Drawing.Size(100, 28);
            this.saveAllBtn.TabIndex = 0;
            this.saveAllBtn.Text = "<Save all>";
            this.saveAllBtn.UseVisualStyleBackColor = true;
            this.saveAllBtn.Click += new System.EventHandler(this.saveAllBtn_Click);
            // 
            // exportAllBtn
            // 
            this.exportAllBtn.Location = new System.Drawing.Point(4, 124);
            this.exportAllBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exportAllBtn.Name = "exportAllBtn";
            this.exportAllBtn.Size = new System.Drawing.Size(316, 28);
            this.exportAllBtn.TabIndex = 0;
            this.exportAllBtn.Text = "<Export all bitmaps with all palettes>";
            this.exportAllBtn.UseVisualStyleBackColor = true;
            this.exportAllBtn.Click += new System.EventHandler(this.exportAllBtn_Click);
            // 
            // importThisWithPalBtn
            // 
            this.importThisWithPalBtn.Location = new System.Drawing.Point(4, 75);
            this.importThisWithPalBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.importThisWithPalBtn.Name = "importThisWithPalBtn";
            this.importThisWithPalBtn.Size = new System.Drawing.Size(320, 28);
            this.importThisWithPalBtn.TabIndex = 0;
            this.importThisWithPalBtn.Text = "<Import this bitmap and recreate palette>";
            this.importThisWithPalBtn.UseVisualStyleBackColor = true;
            this.importThisWithPalBtn.Click += new System.EventHandler(this.importThisWithPalBtn_Click);
            // 
            // importThisBtn
            // 
            this.importThisBtn.Location = new System.Drawing.Point(4, 39);
            this.importThisBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.importThisBtn.Name = "importThisBtn";
            this.importThisBtn.Size = new System.Drawing.Size(320, 28);
            this.importThisBtn.TabIndex = 0;
            this.importThisBtn.Text = "<Import this bitmap with existing palette>";
            this.importThisBtn.UseVisualStyleBackColor = true;
            this.importThisBtn.Click += new System.EventHandler(this.importThisBtn_Click);
            // 
            // exportThisBtn
            // 
            this.exportThisBtn.Location = new System.Drawing.Point(4, 4);
            this.exportThisBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exportThisBtn.Name = "exportThisBtn";
            this.exportThisBtn.Size = new System.Drawing.Size(155, 28);
            this.exportThisBtn.TabIndex = 0;
            this.exportThisBtn.Text = "<Export this bitmap>";
            this.exportThisBtn.UseVisualStyleBackColor = true;
            this.exportThisBtn.Click += new System.EventHandler(this.exportThisBtn_Click);
            // 
            // graphicsEditor1
            // 
            this.graphicsEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsEditor1.Location = new System.Drawing.Point(332, 0);
            this.graphicsEditor1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.graphicsEditor1.Name = "graphicsEditor1";
            this.graphicsEditor1.Size = new System.Drawing.Size(757, 625);
            this.graphicsEditor1.TabIndex = 4;
            this.graphicsEditor1.SomethingSaved += new NSMBe5.GraphicsEditor.SomethingSavedD(this.graphicsEditor1_SomethingSaved);
            // 
            // ImageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.graphicsEditor1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ImageManager";
            this.Size = new System.Drawing.Size(1089, 625);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.image2dOptions.ResumeLayout(false);
            this.image2dOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileOffsetNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileWidthNumber)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox imageListBox;
        private System.Windows.Forms.ListBox paletteListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblBitmaps;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPalettes;
        private System.Windows.Forms.Panel image2dOptions;
        private System.Windows.Forms.NumericUpDown tileWidthNumber;
        private System.Windows.Forms.Label lblTileWidth;
        private GraphicsEditor graphicsEditor1;
        private System.Windows.Forms.CheckBox fourBppCheckBox;
        private System.Windows.Forms.NumericUpDown tileOffsetNumber;
        private System.Windows.Forms.Label lblTileOffset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button importAllBtn;
        private System.Windows.Forms.Button exportAllBtn;
        private System.Windows.Forms.Button importThisBtn;
        private System.Windows.Forms.Button exportThisBtn;
        private System.Windows.Forms.Button saveAllBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button importThisWithPalBtn;
        private System.Windows.Forms.CheckBox autopaletteCheckBox;
    }
}
