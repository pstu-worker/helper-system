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
        const string NULL = "";

        private Student student;
        private string surname;
        private string name;

        public Form2( )
        {
            InitializeComponent( );
            student = new Student( );
        }

        internal Student Student { get => student; set => student = value; }

        private string UppercaseFirst( string text ) => ( char.ToUpper( text[0]) + text.Substring(1) );

        private void Button1_Click( object sender, EventArgs e )
        {
            try
            {
                surname = SurnameTextBox.Text.ToLower( );
                name = NameTextBox.Text.ToLower( );
                if ( surname == NULL || name == NULL )
                {
                    throw new Exception( );
                }
                student.Surname = UppercaseFirst( surname );
                student.Name = UppercaseFirst( name );
                Close( );
            }
            catch ( Exception )
            {
                SurnameLabel.Visible = surname == NULL ? true : false;
                NameLabel.Visible = name == NULL ? true : false;
            }
        }

        private void SurnameChangeEvent( object sender, EventArgs e ) => SurnameLabel.Visible = false;

        private void NameChangeEvent( object sender, EventArgs e ) => NameLabel.Visible = false;
    }
}
