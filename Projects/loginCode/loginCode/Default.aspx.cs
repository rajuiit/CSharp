using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace loginCode
{
    public partial class Default : System.Web.UI.Page
    {


        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["checkCS"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            wLB.Visible = false;
        }

        protected void loginBT_Click(object sender, EventArgs e)
        {

           
                     con.Open();
                     
                     string q="SELECT `user_name` , `pass_word` FROM `check` WHERE  `user_name`='"+uNameTB.Text+"' and `pass_word`='"+pWordTB.Text+"' ";

                     MySqlCommand cmd = new MySqlCommand(q, con);



                     MySqlDataReader reader = cmd.ExecuteReader();


                     if (reader.Read())
                     {
                         

                          Response.Redirect("homePage.aspx");
                    
                     }
                         

                     

                     else
                     {

                         wLB.Visible = true;

                     }


                     


                     con.Close();
   


                 
        }
    }
}