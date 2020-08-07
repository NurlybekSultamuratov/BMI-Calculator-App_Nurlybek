namespace BMI_Calculator_App_Nurlybek
{
    partial class BMICalculatorForm
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
            this.WeightInput = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.CalculatedResult = new System.Windows.Forms.TextBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.MyWeight = new System.Windows.Forms.Label();
            this.MyHeight = new System.Windows.Forms.Label();
            this.MyHeightInput = new System.Windows.Forms.TextBox();
            this.MyWeightInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeightInput
            // 
            this.WeightInput.Location = new System.Drawing.Point(154, 68);
            this.WeightInput.Name = "WeightInput";
            this.WeightInput.Size = new System.Drawing.Size(142, 20);
            this.WeightInput.TabIndex = 4;
            this.WeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CalculateBMIButton.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLayoutPanel2.SetColumnSpan(this.CalculateBMIButton, 2);
            this.CalculateBMIButton.Location = new System.Drawing.Point(81, 267);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(140, 82);
            this.CalculateBMIButton.TabIndex = 0;
            this.CalculateBMIButton.Text = "Calculate";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // CalculatedResult
            // 
            this.CalculatedResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CalculatedResult.BackColor = System.Drawing.SystemColors.Menu;
            this.tableLayoutPanel2.SetColumnSpan(this.CalculatedResult, 2);
            this.CalculatedResult.Enabled = false;
            this.CalculatedResult.Location = new System.Drawing.Point(3, 355);
            this.CalculatedResult.Multiline = true;
            this.CalculatedResult.Name = "CalculatedResult";
            this.CalculatedResult.Size = new System.Drawing.Size(297, 82);
            this.CalculatedResult.TabIndex = 2;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(163, 179);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(128, 82);
            this.ImperialRadioButton.TabIndex = 3;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(22, 179);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(106, 82);
            this.MetricRadioButton.TabIndex = 4;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // MyWeight
            // 
            this.MyWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MyWeight.AutoSize = true;
            this.MyWeight.Location = new System.Drawing.Point(5, 88);
            this.MyWeight.Name = "MyWeight";
            this.MyWeight.Size = new System.Drawing.Size(141, 88);
            this.MyWeight.TabIndex = 5;
            this.MyWeight.Text = "My Weight";
            this.MyWeight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MyHeight
            // 
            this.MyHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MyHeight.AutoSize = true;
            this.MyHeight.Location = new System.Drawing.Point(7, 0);
            this.MyHeight.Name = "MyHeight";
            this.MyHeight.Size = new System.Drawing.Size(136, 88);
            this.MyHeight.TabIndex = 6;
            this.MyHeight.Text = "My Height";
            this.MyHeight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MyHeightInput
            // 
            this.MyHeightInput.Location = new System.Drawing.Point(154, 3);
            this.MyHeightInput.MaxLength = 10;
            this.MyHeightInput.Name = "MyHeightInput";
            this.MyHeightInput.Size = new System.Drawing.Size(146, 38);
            this.MyHeightInput.TabIndex = 9;
            this.MyHeightInput.TextChanged += new System.EventHandler(this.MyHeightInput_TextChanged);
            this.MyHeightInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyHeightInput_KeyPress);
            // 
            // MyWeightInput
            // 
            this.MyWeightInput.Location = new System.Drawing.Point(154, 91);
            this.MyWeightInput.MaxLength = 10;
            this.MyWeightInput.Name = "MyWeightInput";
            this.MyWeightInput.Size = new System.Drawing.Size(146, 38);
            this.MyWeightInput.TabIndex = 10;
            this.MyWeightInput.TextChanged += new System.EventHandler(this.MyWeightInput_TextChanged);
            this.MyWeightInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyWeightInput_KeyPress);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.CalculatedResult, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.CalculateBMIButton, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.ImperialRadioButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.MetricRadioButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.MyHeightInput, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.MyHeight, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MyWeightInput, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.MyWeight, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(303, 440);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox WeightInput;
        private System.Windows.Forms.TextBox MyHeightInput;
        private System.Windows.Forms.Label MyHeight;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox CalculatedResult;
        private System.Windows.Forms.Label MyWeight;
        private System.Windows.Forms.TextBox MyWeightInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

