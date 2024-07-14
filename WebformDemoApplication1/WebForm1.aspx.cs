using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebformDemoApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
            string connectionString;
            SqlConnection cnn;

            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\3D Objects\\david is king\\WEBDRAGONPROJECTS\\WebformDemoApplication1\\App_Data\\DragonDatabase.accdb;User ID=Admin";


            cnn = new SqlConnection(connectionString);
            cnn.Open();

            Response.Write("Connection made");
            cnn.Close();
        }

        protected void Webbtn_Click(object sender, EventArgs e)
        {
            Session["KingsName"] = txtName.Text;
            Response.Write(Session["KingsName"]);

            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                ResultLabel.Text = txtName.Text + "<br />";
            }
            else
            {
                ResultLabel.Text = "Please enter a name.<br />";
            }

            if (lstKingnames.SelectedItem != null)
            {
                ResultLabel.Text += lstKingnames.SelectedItem.Text + "<br />";
            }
            else
            {
                ResultLabel.Text += "Please select an item from the list.<br />";
            }

            // Optionally, you can check which radio button is selected
            if (RadioButtonKing.Checked)
            {
                ResultLabel.Text += "King<br />";
            }
            else if (RadioButtonQueen.Checked)
            {
                ResultLabel.Text += "Queen<br />";
            }
            else if (RadioButtonServant.Checked)
            {
                ResultLabel.Text += "Servant<br />";
            }
            else
            {
                ResultLabel.Text += "No radio button selected.<br />";
            }

            // Checking which checkboxes are selected
            if (CheckBoxFire.Checked)
            {
                ResultLabel.Text += "Fire<br />";
            }

            if (CheckBoxLuminous.Checked)
            {
                ResultLabel.Text += "Luminous<br />";
            }

            if (CheckBoxIonic.Checked)
            {
                ResultLabel.Text += "Ionic<br />";
            }

            // Hide the controls
            txtName.Visible = false;
            lblName.Visible = false;
            lstKingnames.Visible = false;
            RadioButtonKing.Visible = false;
            RadioButtonQueen.Visible = false;
            RadioButtonServant.Visible = false;
            CheckBoxFire.Visible = false;
            CheckBoxLuminous.Visible = false;
            CheckBoxIonic.Visible = false;
            Webbtn.Visible=false;
        }

        
    }
}
