namespace Perceptron
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.LRateText = new System.Windows.Forms.TextBox();
            this.NumEpochText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PredictButton = new System.Windows.Forms.Button();
            this.TrainButton = new System.Windows.Forms.Button();
            this.OutputText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.x21radio = new System.Windows.Forms.RadioButton();
            this.x20radio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.x10radio = new System.Windows.Forms.RadioButton();
            this.x11radio = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Learning Rate (0-1):";
            // 
            // LRateText
            // 
            this.LRateText.Location = new System.Drawing.Point(168, 33);
            this.LRateText.Name = "LRateText";
            this.LRateText.Size = new System.Drawing.Size(157, 22);
            this.LRateText.TabIndex = 1;
            // 
            // NumEpochText
            // 
            this.NumEpochText.Location = new System.Drawing.Point(168, 61);
            this.NumEpochText.Name = "NumEpochText";
            this.NumEpochText.Size = new System.Drawing.Size(157, 22);
            this.NumEpochText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Epoch: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "X₁";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "X₂";
            // 
            // PredictButton
            // 
            this.PredictButton.Location = new System.Drawing.Point(220, 169);
            this.PredictButton.Name = "PredictButton";
            this.PredictButton.Size = new System.Drawing.Size(75, 23);
            this.PredictButton.TabIndex = 8;
            this.PredictButton.Text = "Predict";
            this.PredictButton.UseVisualStyleBackColor = true;
            this.PredictButton.Click += new System.EventHandler(this.PredictButton_Click);
            // 
            // TrainButton
            // 
            this.TrainButton.Location = new System.Drawing.Point(128, 169);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(75, 23);
            this.TrainButton.TabIndex = 9;
            this.TrainButton.Text = "Train";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // OutputText
            // 
            this.OutputText.AutoSize = true;
            this.OutputText.Location = new System.Drawing.Point(125, 218);
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(51, 16);
            this.OutputText.TabIndex = 10;
            this.OutputText.Text = "Output: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Logic Gate: ";
            // 
            // x21radio
            // 
            this.x21radio.AutoSize = true;
            this.x21radio.Location = new System.Drawing.Point(168, 124);
            this.x21radio.Name = "x21radio";
            this.x21radio.Size = new System.Drawing.Size(35, 20);
            this.x21radio.TabIndex = 18;
            this.x21radio.TabStop = true;
            this.x21radio.Text = "1";
            this.x21radio.UseVisualStyleBackColor = true;
            // 
            // x20radio
            // 
            this.x20radio.AutoSize = true;
            this.x20radio.Location = new System.Drawing.Point(220, 124);
            this.x20radio.Name = "x20radio";
            this.x20radio.Size = new System.Drawing.Size(35, 20);
            this.x20radio.TabIndex = 19;
            this.x20radio.TabStop = true;
            this.x20radio.Text = "0";
            this.x20radio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(354, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 168);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logical Gates";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(47, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 20);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "AND";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(47, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 20);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "OR";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(47, 91);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(56, 20);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "XOR";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(47, 122);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(67, 20);
            this.radioButton4.TabIndex = 18;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "NAND";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.x10radio);
            this.groupBox2.Controls.Add(this.x11radio);
            this.groupBox2.Location = new System.Drawing.Point(168, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(87, 24);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // x10radio
            // 
            this.x10radio.AutoSize = true;
            this.x10radio.Location = new System.Drawing.Point(52, 4);
            this.x10radio.Name = "x10radio";
            this.x10radio.Size = new System.Drawing.Size(35, 20);
            this.x10radio.TabIndex = 19;
            this.x10radio.TabStop = true;
            this.x10radio.Text = "0";
            this.x10radio.UseVisualStyleBackColor = true;
            // 
            // x11radio
            // 
            this.x11radio.AutoSize = true;
            this.x11radio.Location = new System.Drawing.Point(0, 4);
            this.x11radio.Name = "x11radio";
            this.x11radio.Size = new System.Drawing.Size(35, 20);
            this.x11radio.TabIndex = 18;
            this.x11radio.TabStop = true;
            this.x11radio.Text = "1";
            this.x11radio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 263);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.x20radio);
            this.Controls.Add(this.x21radio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.TrainButton);
            this.Controls.Add(this.PredictButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumEpochText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LRateText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Perceptron Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LRateText;
        private System.Windows.Forms.TextBox NumEpochText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PredictButton;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.Label OutputText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton x21radio;
        private System.Windows.Forms.RadioButton x20radio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton x10radio;
        private System.Windows.Forms.RadioButton x11radio;
    }
}

