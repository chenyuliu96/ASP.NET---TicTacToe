using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW2
{
    public class Person
    {
        public string userName { get; set; }
        public string userPassword { get; set; }

        public int[] game { get; set; }

        public int myTurn = 1;
        public  Image x;
        public Image y;
        
        
    }
}