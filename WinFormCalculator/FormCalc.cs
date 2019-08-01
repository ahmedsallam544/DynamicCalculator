using AuthService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCalculator
{
    public partial class FormCalc : Form
    {
 
        public FormCalc(int priviledge  )
        {
            InitializeComponent();
         
         
            if (priviledge == 1) {
                this.btnAdd.Visible = true;
                this.btnSub.Visible = false;
                this.btnMult.Visible = false;
                this.btnDiv.Visible = false;
            }
            else if (priviledge == 2) {

                this.btnAdd.Visible = true;
                this.btnSub.Visible = true;
                this.btnMult.Visible = false;
                this.btnDiv.Visible = false;

            }
            else if (priviledge == 3) {

                this.btnAdd.Visible = true;
                this.btnSub.Visible = true;
                this.btnMult.Visible = true;
                this.btnDiv.Visible = false;
            }
            else {

                this.btnAdd.Visible = true;
                this.btnSub.Visible = true;
                this.btnMult.Visible = true;
                this.btnDiv.Visible = true;
            }


        }
         

        // Another Way To Add controls Dynamicly in run time 
        //this.Hide();
        //Button add = new Button();
        //add.Text = "+";
        //add.Name = "btnAdd";
        //add.Height = 90;
        //add.Width = 58;
        //add.Location = new Point(630, 124);
        //add.Click += new EventHandler(form.);
        //form.Controls.Add(add);
        //form.Show();

        double Result = 0 ;
        string operationPerformed = "";
        bool IsOperationPerformed = false;
         void checkZero() {
            if ((ScreenTxtBox.Text == "0")||(IsOperationPerformed))
            {
                ScreenTxtBox.Clear();
            }
        }
       
        private void btnNum_Click(object sender, EventArgs e)
        {
            // Handles Numbers such as  123 456


            checkZero();
            IsOperationPerformed = false;
            Button button = (Button)sender;
            ScreenTxtBox.Text = ScreenTxtBox.Text + button.Text;
        }
         
        private void btnOperator(object sender, EventArgs e)
        {
            // Handle  +  -   *   /

            Button button = (Button)sender;
            operationPerformed = button.Text;
            Result = Double.Parse(ScreenTxtBox.Text);
            ScreenTxtBox.Clear();
            IsOperationPerformed = true;

        }
       
        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    ScreenTxtBox.Text = (Result + Double.Parse(ScreenTxtBox.Text)).ToString();
                 
                    break;

                case "-":
                    ScreenTxtBox.Text = (Result - Double.Parse(ScreenTxtBox.Text)).ToString();
                

                    break;

                case "*":
                  
                    ScreenTxtBox.Text = (Result * Double.Parse(ScreenTxtBox.Text)).ToString();
                    
                    break;

                case "/":
                    ScreenTxtBox.Text = (Result / Double.Parse(ScreenTxtBox.Text)).ToString();
                    
                    break;
                default:
                    Result = Double.Parse(ScreenTxtBox.Text);
                   
                    break;
            }

        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            ScreenTxtBox.Text = "0";
            Result = 0;
            IsOperationPerformed = false;
        }

        
    }
}
