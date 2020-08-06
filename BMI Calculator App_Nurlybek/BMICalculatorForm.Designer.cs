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
            this.BMILayoutContainer = new System.Windows.Forms.TableLayoutPanel();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.CalculatedResult = new System.Windows.Forms.TextBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.MyWeight = new System.Windows.Forms.Label();
            this.MyHeight = new System.Windows.Forms.Label();
            this.MyHeightInput = new System.Windows.Forms.TextBox();
            this.MyWeightInput = new System.Windows.Forms.TextBox();
            this.ResultInBMIScale = new System.Windows.Forms.TextBox();
            this.BMILayoutContainer.SuspendLayout();
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
            // BMILayoutContainer
            // 
            this.BMILayoutContainer.ColumnCount = 2;
            this.BMILayoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMILayoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMILayoutContainer.Controls.Add(this.MyHeightInput, 1, 0);
            this.BMILayoutContainer.Controls.Add(this.MyHeight, 0, 0);
            this.BMILayoutContainer.Controls.Add(this.MetricRadioButton, 0, 2);
            this.BMILayoutContainer.Controls.Add(this.ImperialRadioButton, 1, 2);
            this.BMILayoutContainer.Controls.Add(this.MyWeight, 0, 1);
            this.BMILayoutContainer.Controls.Add(this.MyWeightInput, 1, 1);
            this.BMILayoutContainer.Controls.Add(this.ResultInBMIScale, 0, 4);
            this.BMILayoutContainer.Controls.Add(this.CalculateBMIButton, 1, 3);
            this.BMILayoutContainer.Controls.Add(this.CalculatedResult, 1, 4);
            this.BMILayoutContainer.Location = new System.Drawing.Point(0, 4);
            this.BMILayoutContainer.Name = "BMILayoutContainer";
            this.BMILayoutContainer.RowCount = 5;
            this.BMILayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMILayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMILayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMILayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMILayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMILayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BMILayoutContainer.Size = new System.Drawing.Size(298, 436);
            this.BMILayoutContainer.TabIndex = 0;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CalculateBMIButton.BackColor = System.Drawing.Color.PeachPuff;
            this.CalculateBMIButton.Location = new System.Drawing.Point(153, 264);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(140, 81);
            this.CalculateBMIButton.TabIndex = 0;
            this.CalculateBMIButton.Text = "Calculate";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            // 
            // CalculatedResult
            // 
            this.CalculatedResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CalculatedResult.BackColor = System.Drawing.SystemColors.Menu;
            this.CalculatedResult.Enabled = false;
            this.CalculatedResult.Location = new System.Drawing.Point(152, 351);
            this.CalculatedResult.Name = "CalculatedResult";
            this.CalculatedResult.Size = new System.Drawing.Size(143, 38);
            this.CalculatedResult.TabIndex = 2;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(159, 177);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(128, 81);
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
            this.MetricRadioButton.Location = new System.Drawing.Point(21, 177);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(106, 81);
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
            this.MyWeight.Location = new System.Drawing.Point(4, 87);
            this.MyWeight.Name = "MyWeight";
            this.MyWeight.Size = new System.Drawing.Size(141, 87);
            this.MyWeight.TabIndex = 5;
            this.MyWeight.Text = "My Weight";
            // 
            // MyHeight
            // 
            this.MyHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MyHeight.AutoSize = true;
            this.MyHeight.Location = new System.Drawing.Point(6, 0);
            this.MyHeight.Name = "MyHeight";
            this.MyHeight.Size = new System.Drawing.Size(136, 87);
            this.MyHeight.TabIndex = 6;
            this.MyHeight.Text = "My Height";
            // 
            // MyHeightInput
            // 
            this.MyHeightInput.Location = new System.Drawing.Point(152, 3);
            this.MyHeightInput.Name = "MyHeightInput";
            this.MyHeightInput.Size = new System.Drawing.Size(143, 38);
            this.MyHeightInput.TabIndex = 9;
            // 
            // MyWeightInput
            // 
            this.MyWeightInput.Location = new System.Drawing.Point(152, 90);
            this.MyWeightInput.Name = "MyWeightInput";
            this.MyWeightInput.Size = new System.Drawing.Size(143, 38);
            this.MyWeightInput.TabIndex = 10;
            // 
            // ResultInBMIScale
            // 
            this.ResultInBMIScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ResultInBMIScale.BackColor = System.Drawing.SystemColors.Menu;
            this.ResultInBMIScale.Enabled = false;
            this.ResultInBMIScale.Location = new System.Drawing.Point(3, 351);
            this.ResultInBMIScale.Multiline = true;
            this.ResultInBMIScale.Name = "ResultInBMIScale";
            this.ResultInBMIScale.Size = new System.Drawing.Size(143, 82);
            this.ResultInBMIScale.TabIndex = 1;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMILayoutContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.BMILayoutContainer.ResumeLayout(false);
            this.BMILayoutContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox WeightInput;
        private System.Windows.Forms.TableLayoutPanel BMILayoutContainer;
        private System.Windows.Forms.TextBox MyHeightInput;
        private System.Windows.Forms.Label MyHeight;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox CalculatedResult;
        private System.Windows.Forms.Label MyWeight;
        private System.Windows.Forms.TextBox MyWeightInput;
        private System.Windows.Forms.TextBox ResultInBMIScale;
    }
}

