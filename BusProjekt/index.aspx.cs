using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusProjekt
{
    public partial class index : System.Web.UI.Page
    {
        static Connection connection = new Connection();
        static Validation validation = new Validation();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
          int num;
          string name= txtName.Text;
          string vorname = txtVorname.Text;
          string email = txtEmail.Text;
          string passwort = txtPasswort.Text;
          string passwort2 = txtPasswort2.Text;
          bool nameEmpty = string.IsNullOrEmpty(name);  
          bool vornameEmpty = string.IsNullOrEmpty(vorname);  
          bool passwortEmpty = string.IsNullOrEmpty(passwort);  
          bool passwort2Empty = string.IsNullOrEmpty(passwort2);
          bool nameisNumber = int.TryParse(name, out num);
          bool vornameisNumber = int.TryParse(vorname, out num);

            if (nameEmpty || vornameEmpty || passwortEmpty || passwort2Empty ||nameisNumber|| vornameisNumber || !validation.EmailValidation(email))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ERROR: Ungültige Daten, überprüfen Sie die Textfelder')", true);
                /*txtName.Text = "";
                txtVorname.Text = "";
                txtEmail.Text = "";*/
            }
            else
            {
                if (!passwort.Equals(passwort2)) { lblPasswortError.Text = "ERROR: The password must be the same"; txtPasswort.Text = ""; txtPasswort2.Text = ""; }
                else if (passwort.Length < 8 || passwort.Length < 8) { lblPasswortError.Text = "ERROR: Passwort musst 8 character haben."; txtPasswort.Text = ""; txtPasswort2.Text = ""; }
                else
                {

                    string hashedPasswort = BCrypt.Net.BCrypt.HashString(passwort);
                    lblPasswortError.Text = "";
                    string sql = "INSERT INTO `users` (`namee`,`vorname`,`email`,`passwort`) VALUES ('" + name + "', '" + vorname +"', '"+ email +"','"+ hashedPasswort +"');";
                    connection.Inserts(sql);
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Successfull: Sie sind anmeldet.')", true);
                }    
            }            
        }
    }
}