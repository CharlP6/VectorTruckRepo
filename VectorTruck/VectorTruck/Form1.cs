using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorTruck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double X, Y;

            double.TryParse(txtX.Text, out X);
            double.TryParse(txtY.Text, out Y);

            Vector2 testVect = new Vector2(X, Y);
            Vector2 unitVect = testVect.Unit;

            lblMagnitude.Text = "M: " + testVect.Magnitude.ToString();
            lblUX.Text = "uX: " + unitVect.X.ToString();
            lblUY.Text = "uY: " + unitVect.Y.ToString();

            Vector2 rotationPoint = new Vector2(1, 1);
            Vector2 pTestPoint = testVect.RotateVectorAboutPoint(Math.PI / 4, rotationPoint);

            MessageBox.Show(pTestPoint.ToString());
        }
    }
}
