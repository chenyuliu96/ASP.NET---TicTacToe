using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace HW2
{
    public partial class TicTacToe : System.Web.UI.Page
    {
        List<Image> A =new List<Image>();
     
       
        protected void Page_Load(object sender, EventArgs e)
        {
           //if not logged in
            if (Session["person"] == null)
            {
                noAccess.Visible = true;
                GameContainer.Visible = false;
                Winner.Visible = false ;
                currentPlayer.Visible = false;
            }
            //if logged in
            else { noAccess.Visible = false;
                GameContainer.Visible = true;
                Winner.Visible = true ;
                currentPlayer.Visible = true;
                
                //if post back, then do not refresh the game board
                if (!IsPostBack)
               
                {

                    Person p = (Person)Session["person"];
                    p.myTurn = 1;
                    for (int i = 0; i < 9; i++)
                    {
                        p.game[i] = 0;
                    }
                }
            }
            
        }
        protected void Button_Disable()
        {
            Button0.Enabled = false;
            Button1.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            Button6.Enabled = false;
            Button7.Enabled = false;
            Button8.Enabled = false;
           
        }
        protected void Button_Click(object sender, EventArgs e)
        {
            Button c = (Button)sender;

            A.Add(Image0); A.Add(Image1); A.Add(Image2); A.Add(Image3); A.Add(Image4); A.Add(Image5); A.Add(Image6); A.Add(Image7); A.Add(Image8);

            int boardIndexClicked = int.Parse(c.ID.Substring(6));
            Image toBeD = A[boardIndexClicked];
            toBeD.Style.Add("display", "inline-block");
            Person p = (Person)Session["person"];
            c.Style.Add("display", "none");
            if (p.myTurn == 1) {
                p.game[boardIndexClicked] = 1;
                p.myTurn = -1;
               
                currentPlayer.Text = "Current Player is O";
                c.Text = "clicked";
                
               
                toBeD.ImageUrl = "~/Image/X.PNG";

              
            }
            else if(p.myTurn ==-1)
            {
                p.game[boardIndexClicked] = -1;
                p.myTurn = 1;
                currentPlayer.Text = "Current Player is X";
               
                toBeD.ImageUrl = "~/Image/O.PNG";
                //c.BackColor = System.Drawing.Color.BlueViolet;

            }
           
           
            int winner = checkWinner(p.game);
            if(winner == 1) { Winner.Text = "Game is over. X is the winner!"; Button_Disable(); currentPlayer.Visible = false; }
            if(winner == -1) { Winner.Text = "Game is over. O is the winner!"; Button_Disable(); currentPlayer.Visible = false; }
            if(winner == 0) { Winner.Text = "The game is tied. Nobody wins."; currentPlayer.Visible = false; }
            c.Enabled = false;
        

        }
        protected int checkWinner(int[] arr)
        {
            //check row winner
            for (int i = 0; i < 3; i++)
            {
                if(arr[i*3]==1 && arr[3*i+1] ==1 && arr[3*i + 2] == 1)
                {
                    return 1;
                }
                else if(arr[i * 3] == -1 && arr[3 * i + 1] == -1 && arr[3 * i + 2] == -1)
                {
                    return -1;
                }
            }
            //check column winner
            for (int j = 0; j < 3; j++)
            {
                if (arr[j] == 1 && arr[j + 3] == 1 && arr[j + 6] == 1)
                {
                    return 1;
                }
                if (arr[j] == -1 && arr[j + 3] == -1 && arr[j + 6] == -1)
                {
                    return -1;
                }
            }
            //check diagonal winner
            if (arr[0]==1 && arr[4] == 1&& arr[8] == 1)
            {
                return 1;
            }
            if (arr[0] == -1 && arr[4] == -1 && arr[8] == -1)
            {
                return -1;
            }
            //check diagonal winner
            if (arr[2] == 1 && arr[4] == 1 && arr[6] == 1)
            {
                return 1;
            }
            if (arr[2] == -1 && arr[4] == -1 && arr[6] == -1)
            {
                return -1;
            }
            //check for no winner
            int countFilled = 0;
            for(int i = 0; i < 9; i++)
            {
                if(arr[i] != 0)
                {
                    countFilled += 1;
                }
            }
            if (countFilled == 9)
            {
                return 0;
            }
            return 2;
        }
    }
}