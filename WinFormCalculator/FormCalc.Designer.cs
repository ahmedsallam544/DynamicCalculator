namespace WinFormCalculator
{
    partial class FormCalc
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalc));
            this.btnNum = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.ScreenTxtBox = new System.Windows.Forms.RichTextBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(51, 134);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(90, 58);
            this.btnNum.TabIndex = 0;
            this.btnNum.Text = "1";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(399, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(51, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 58);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(226, 237);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 58);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(399, 237);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 58);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(51, 323);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 58);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(226, 323);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 58);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(399, 323);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 58);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(226, 403);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 58);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(630, 313);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(90, 58);
            this.btnMult.TabIndex = 10;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnOperator);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(630, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 58);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnOperator);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(630, 221);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(90, 58);
            this.btnSub.TabIndex = 12;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnOperator);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(630, 403);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(90, 58);
            this.btnDiv.TabIndex = 13;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnOperator);
            // 
            // ScreenTxtBox
            // 
            this.ScreenTxtBox.Enabled = false;
            this.ScreenTxtBox.Location = new System.Drawing.Point(51, 33);
            this.ScreenTxtBox.Name = "ScreenTxtBox";
            this.ScreenTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ScreenTxtBox.Size = new System.Drawing.Size(509, 80);
            this.ScreenTxtBox.TabIndex = 14;
            this.ScreenTxtBox.Text = "0";
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(399, 403);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(90, 58);
            this.btnEqual.TabIndex = 15;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(51, 403);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(90, 59);
            this.btnRest.TabIndex = 16;
            this.btnRest.Text = "C";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 484);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.ScreenTxtBox);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormCalc";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        public System.Windows.Forms.Button btnMult;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnSub;
        public System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.RichTextBox ScreenTxtBox;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnRest;
    }
}

