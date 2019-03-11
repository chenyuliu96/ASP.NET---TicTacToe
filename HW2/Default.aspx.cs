using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Helpers;

namespace HW2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["person"] == null)
            {
                Login1.Visible = true;
                LogOffButton.Visible = false;
                
            }
            else { Login1.Visible = false;
                LogOffButton.Visible = true;
                
                }

           

        }

        private bool SiteSpecificAuthenticationMethod(string UserName, string Password)
        {
            
            return false;
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

            Application.Lock();
            //if this is a registered user, then we compare the password
            if(Application[Login1.UserName] != null)
            {
                Person p = (Person) Application[Login1.UserName];
                if (Crypto.VerifyHashedPassword(p.userPassword, Login1.Password)){
                    e.Authenticated = true;
                    Session["person"] = p;
                    Session.Timeout = 10;
                    Response.Redirect("TicTacToe.aspx");
                }
            }
            //if this is a new user, then we add it to server memory 
            else
            {
                Person person = new Person() { userName = Login1.UserName, userPassword = Crypto.HashPassword(Login1.Password), game = new int[9] };
                
                Application[person.userName] = person;
                e.Authenticated = true;
                Session["person"] = person;
                Session.Timeout = 10;
                Response.Redirect("TicTacToe.aspx");
            }
            e.Authenticated = false;
            Application.UnLock();
            
            
            
        }

        protected void LogOffButton_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }
    }
}