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
    public partial class Form2 : Form
    {
        private Student student;

        public Form2( )
        {
            InitializeComponent( );
            this.student = new Student( );
        }

        internal Student Student { get => student; set => student = value; }

        private string UppercaseFirst( string text ) => ( char.ToUpper( text[0]) + text.Substring(1) );

        private void Button1_Click( object sender, EventArgs e )
        {
            try
            {
                string surname = SurnameTextBox.Text.ToLower( );
                string name = NameTextBox.Text.ToLower( );
                if ( surname == "" || name == "" )
                {
                    throw new Exception( );
                }
                this.student.Surname = UppercaseFirst( surname );
                this.student.Name = UppercaseFirst( name );
                this.Close( );
            }
            catch ( Exception )
            {
                
            }
        }
    }
}
