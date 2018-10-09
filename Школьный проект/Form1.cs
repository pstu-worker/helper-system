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
    public partial class Form1 : Form
    {
        Form3 startForm;

        public Form1( ) => InitializeComponent( );

        private void button1_Click( object sender, EventArgs e )
        {
            startForm = new Form3( );
            startForm.ShowDialog( );
            Close( );
        }
    }
}
