using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Item class for items in listSapsansList
        public class Sapsan
        {
            private string listSapsanIP;
            private string listSapsanName;

            public Sapsan(string strSapsanName, string strSapsanIP)
            {

                this.listSapsanIP = strSapsanIP;
                this.listSapsanName = strSapsanName;
            }

            public string SapsanIP
            {
                get
                {
                    return listSapsanIP;
                }
            }

            public string SapsanName
            {

                get
                {
                    return listSapsanName;
                }
            }

        }

    }
}
