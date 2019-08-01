using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
namespace WinFormCalculator
{
    public partial class Login : Form
    {
      
           // Self Binding 
        public ServiceHost Host;
        // Service will Invoke functions & retrive data from DB
        public AuthService.Service1 service ;
        BasicHttpBinding php = new BasicHttpBinding();
     
        public Login()
        {
            InitializeComponent();
          //  Host.AddServiceEndpoint(typeof(AuthService.Service1),php, "http://localhost:8888");       
            // SelfBind to Service in Wcf 
            try
            {
                if (Host.State == System.ServiceModel.CommunicationState.Faulted)
                {
                    Host = new ServiceHost(typeof(AuthService.Service1));
                    Host.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
              service = new AuthService.Service1();

         

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            Form form;
                     

            // permissions return form record primisons in DB
            int prvilage = service.LoginSuccess(txtUsername.Text, txtPass.Text) ;

            if ( prvilage == 1 || prvilage == 2 || prvilage == 3 || prvilage == 4 )
            {
                // Send ServiseHost to Form To Close There With Application 
                form = new FormCalc(prvilage );
                form.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("UnSuccessfully Login");
            }

        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Host.Close(); // Close Service Host

        }


        // Another UnWanted Functionality

        private void showdata() {
            DataSet ds = new DataSet();
            ds = service.SelectUserDetails();
           // dataGridView1.DataSource = ds.Tables[0];
    //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        // Handle operation of register in Database
        private void register_Click(object sender, EventArgs e)
        {
            // not Handeled yet 
            // add type reference
             AuthService.UserDetails userDetails = new AuthService.UserDetails();
            //userDetails.UserName = textBoxUserName.Text;
            //userDetails.Password = textBoxPassword.Text;
            service.InsertUserDetails(userDetails);
               showdata();

        }
  
    }
}
