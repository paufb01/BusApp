using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusProjekt
{
    public partial class RecoveryRequest : System.Web.UI.Page
    {
        Validation validation = new Validation();
        Mail mail = new Mail();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Weiter_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (!string.IsNullOrEmpty(email)&&validation.EmailValidation(email))
            {
                string subject = "Vergessenes Passwort";
                string headerMessage = "Ändern Sie Ihr Passwort hier";
                string link = "http://172.26.136.209/password-recovery.html";
                mail.Send(email, subject, headerMessage, link);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Successfull: Wir haben ein mail gesendet.')", true);
                txtEmail.Text = "";
               




            }
        }


    }
}