using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusProjekt
{
    public partial class LoginForm : System.Web.UI.Page
    {
        static Validation validation = new Validation();
        static Connection connection = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Einloggen_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string passwort = txtPasswort.Text;

            if (!validation.EmailValidation(email)) {

            } else
            {
                string sql = "SELECT * FROM `users` WHERE email='" + email + "';";
                if(connection.Selects(sql, passwort))
                {
                      ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Successfull: Sie sind anmeldet.')", true);

                 }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ERROR')", true);

                }
            }

        }
    }
}