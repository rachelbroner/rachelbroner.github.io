using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class contact_us : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lbl_msg.Visible = false;
        }
    }

    protected void btn_Send_Click(object sender, EventArgs e)
    {
        if (Page.IsValid && ContactForm1.isValid)
        {

            Utils.SendContactInfoToAdmin(ContactForm1.Name, ContactForm1.Email, ContactForm1.Subject, ContactForm1.Message);

           // ContactUsModel.SendContactMessage(contactForm.Name, contactForm.Email, contactForm.Subject, contactForm.Message);

            ContactForm1.Name = "";
            ContactForm1.Email = "";
            ContactForm1.Subject = "";
            ContactForm1.Message = "";
          
            lbl_msg.Visible = true;

        }
    }
}