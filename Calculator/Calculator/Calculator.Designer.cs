namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.calculatorDisplay = new System.Windows.Forms.Label();
            this.fourButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.svenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.dvideButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.ACbutton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculatorDisplay
            // 
            this.calculatorDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculatorDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calculatorDisplay.Location = new System.Drawing.Point(12, 9);
            this.calculatorDisplay.Name = "calculatorDisplay";
            this.calculatorDisplay.Size = new System.Drawing.Size(338, 75);
            this.calculatorDisplay.TabIndex = 1;
            this.calculatorDisplay.Text = "0";
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.Location = new System.Drawing.Point(12, 196);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(80, 49);
            this.fourButton.TabIndex = 2;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.Location = new System.Drawing.Point(12, 249);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(80, 49);
            this.oneButton.TabIndex = 5;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.Location = new System.Drawing.Point(96, 249);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(80, 49);
            this.twoButton.TabIndex = 6;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.Location = new System.Drawing.Point(96, 196);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(80, 49);
            this.fiveButton.TabIndex = 7;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // svenButton
            // 
            this.svenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svenButton.Location = new System.Drawing.Point(12, 142);
            this.svenButton.Name = "svenButton";
            this.svenButton.Size = new System.Drawing.Size(80, 49);
            this.svenButton.TabIndex = 8;
            this.svenButton.Text = "7";
            this.svenButton.UseVisualStyleBackColor = true;
            this.svenButton.Click += new System.EventHandler(this.svenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.Location = new System.Drawing.Point(96, 142);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(80, 49);
            this.eightButton.TabIndex = 9;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButton.Location = new System.Drawing.Point(180, 249);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(80, 49);
            this.threeButton.TabIndex = 10;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.Location = new System.Drawing.Point(180, 196);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(80, 49);
            this.sixButton.TabIndex = 11;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.Location = new System.Drawing.Point(180, 142);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(80, 49);
            this.nineButton.TabIndex = 12;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.Location = new System.Drawing.Point(178, 304);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(166, 49);
            this.equalButton.TabIndex = 13;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(264, 249);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(80, 49);
            this.minusButton.TabIndex = 14;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(264, 196);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(80, 49);
            this.plusButton.TabIndex = 15;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.Location = new System.Drawing.Point(264, 142);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(80, 49);
            this.multiplyButton.TabIndex = 16;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // dvideButton
            // 
            this.dvideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvideButton.Location = new System.Drawing.Point(265, 87);
            this.dvideButton.Name = "dvideButton";
            this.dvideButton.Size = new System.Drawing.Size(80, 49);
            this.dvideButton.TabIndex = 17;
            this.dvideButton.Text = "/";
            this.dvideButton.UseVisualStyleBackColor = true;
            this.dvideButton.Click += new System.EventHandler(this.dvideButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.Location = new System.Drawing.Point(12, 304);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(80, 49);
            this.zeroButton.TabIndex = 18;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // ACbutton
            // 
            this.ACbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACbutton.Location = new System.Drawing.Point(9, 87);
            this.ACbutton.Name = "ACbutton";
            this.ACbutton.Size = new System.Drawing.Size(252, 49);
            this.ACbutton.TabIndex = 19;
            this.ACbutton.Text = "AC";
            this.ACbutton.UseVisualStyleBackColor = true;
            this.ACbutton.Click += new System.EventHandler(this.ACbutton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(95, 304);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(80, 49);
            this.decimalButton.TabIndex = 20;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(362, 374);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.ACbutton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.dvideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.svenButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.calculatorDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label calculatorDisplay;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button svenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button dvideButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button ACbutton;
        private System.Windows.Forms.Button decimalButton;
    }
}

