using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Школьный_проект
{
    public partial class Form3 : Form
    {
        Form2 loginForm;
        const int i = 0;

        public Form3( )
        {
            InitializeComponent( );
            Login( );
        }

        private void Login()
        {
            loginForm = new Form2( );
            loginForm.ShowDialog( );
            loginForm.Close( );
            label3.Text += this.loginForm.Student.ToString( );
        }
    }
}
