using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pluto_Launcher_V1
{
    public partial class UserControl1 : UserControl
    {
        private Form2 form2;
        private object timer;

        public UserControl1()
        {
            InitializeComponent();
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            // Erstelle eine Instanz von Form2
            form2 = new Form2();

            // Bestimme die Position von Form2 relativ zum Bildschirm
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int form2Width = form2.Width;
            int form2Height = form2.Height;

            // Berechne die Position von Form2 in der unteren rechten Ecke
            int x = screenWidth - form2Width;
            int y = screenHeight - form2Height;

            // Setze die Position von Form2
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(x, y);

            // Zeige Form2 an
            form2.Show();

            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            pictureBox1.Parent = pictureBox2;
            pictureBox1.BackColor = Color.Transparent;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
