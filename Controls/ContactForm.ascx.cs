using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.ObjectModel;

public partial class ContactForm : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        
        

    }

    public bool isValid
    {
        get { return Page.IsValid; }
    }
    

    public string Name 
    { 
        get { return tb_name.Text.Trim(); }
        set { tb_name.Text = value; }
    }

    public string Email 
    { 
        get { return tb_email.Text.Trim(); }
        set { tb_email.Text = value; }
    }

    public string Subject 
    { 
        get { return tb_subject.Text.Trim(); }
        set { tb_subject.Text = value; }
    }

    public string Message 
    { 
        get { return tb_message.Text.Trim(); }
        set { tb_message.Text = value; }
    } 

    
}