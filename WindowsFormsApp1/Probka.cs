using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public class Probka
    {
        public System.Windows.Forms.TextBox[] textboxtab { get; set; }
        public Probka()
        {
            textboxtab = new System.Windows.Forms.TextBox[4];
        }

        String[] wartext=new string[4];
        float[] wartlicz=new float[4];        
    }
}
