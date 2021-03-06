﻿namespace PythonIntegrationSample
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCombination = new System.Windows.Forms.RadioButton();
            this.rdbPermutation = new System.Windows.Forms.RadioButton();
            this.chbRepetition = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.nudP = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCombination);
            this.groupBox1.Controls.Add(this.rdbPermutation);
            this.groupBox1.Controls.Add(this.chbRepetition);
            this.groupBox1.Location = new System.Drawing.Point(25, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(132, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation";
            // 
            // rdbCombination
            // 
            this.rdbCombination.AutoSize = true;
            this.rdbCombination.Location = new System.Drawing.Point(7, 62);
            this.rdbCombination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbCombination.Name = "rdbCombination";
            this.rdbCombination.Size = new System.Drawing.Size(107, 21);
            this.rdbCombination.TabIndex = 2;
            this.rdbCombination.Text = "Combination";
            this.rdbCombination.UseVisualStyleBackColor = true;
            // 
            // rdbPermutation
            // 
            this.rdbPermutation.AutoSize = true;
            this.rdbPermutation.Checked = true;
            this.rdbPermutation.Location = new System.Drawing.Point(7, 34);
            this.rdbPermutation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbPermutation.Name = "rdbPermutation";
            this.rdbPermutation.Size = new System.Drawing.Size(105, 21);
            this.rdbPermutation.TabIndex = 1;
            this.rdbPermutation.TabStop = true;
            this.rdbPermutation.Text = "Permutation";
            this.rdbPermutation.UseVisualStyleBackColor = true;
            // 
            // chbRepetition
            // 
            this.chbRepetition.AutoSize = true;
            this.chbRepetition.Location = new System.Drawing.Point(5, 107);
            this.chbRepetition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbRepetition.Name = "chbRepetition";
            this.chbRepetition.Size = new System.Drawing.Size(94, 21);
            this.chbRepetition.TabIndex = 0;
            this.chbRepetition.Text = "Repetition";
            this.chbRepetition.UseVisualStyleBackColor = true;
            this.chbRepetition.CheckedChanged += new System.EventHandler(this.chbRepetition_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(279, 144);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "P";
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(233, 53);
            this.nudN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudN.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(148, 22);
            this.nudN.TabIndex = 4;
            this.nudN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudN.ValueChanged += new System.EventHandler(this.nudN_ValueChanged);
            // 
            // nudP
            // 
            this.nudP.Location = new System.Drawing.Point(231, 105);
            this.nudP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudP.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudP.Name = "nudP";
            this.nudP.Size = new System.Drawing.Size(149, 22);
            this.nudP.TabIndex = 5;
            this.nudP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudP.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            // 
            // txbResult
            // 
            this.txbResult.Enabled = false;
            this.txbResult.Location = new System.Drawing.Point(15, 193);
            this.txbResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(376, 22);
            this.txbResult.TabIndex = 7;
            this.txbResult.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 242);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudP);
            this.Controls.Add(this.nudN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(421, 289);
            this.MinimumSize = new System.Drawing.Size(421, 289);
            this.Name = "MainForm";
            this.Text = "Python Combinatorics Sample";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCombination;
        private System.Windows.Forms.RadioButton rdbPermutation;
        private System.Windows.Forms.CheckBox chbRepetition;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.NumericUpDown nudP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbResult;
    }
}

