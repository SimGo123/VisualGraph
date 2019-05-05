using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualGraph
{
    /// <summary>
    /// Dialog to add an edge
    /// </summary>
    public partial class EdgeDialog : Form
    {
        Dijekstra dijekstra;
        Insert insert;
        Form1 form1;
        char language;

        public EdgeDialog(Dijekstra dij, Insert insert1, Form1 f1, char language1)
        {
            InitializeComponent();
            dijekstra = dij;
            insert = insert1;
            form1 = f1;
            language = language1;

            if (language == 'D')
            {
                laInitialVertex.Text = "Startknoten";
                laFinalVertex.Text = "Endknoten";
                laWeight.Text = "Gewicht";
            }
            else
            {
                laInitialVertex.Text = "Initial vertex";
                laFinalVertex.Text = "Final vertex";
                laWeight.Text = "weight";
            }
        }

        private void buOk_Click(object sender, EventArgs e)
        {
            if (dijekstra.vertexList.Where(x => x.name == tbStart.Text).ToList().Count != 0
                && dijekstra.vertexList.Where(x => x.name == tbEnd.Text).ToList().Count != 0
                && Double.TryParse(tbWeight.Text, out double d))
            {
                insert.insertEdge(tbStart.Text, tbEnd.Text, Convert.ToDouble(tbWeight.Text));
            }
            else
            {
                if (language == 'D') MessageBox.Show("Es ist ein Fehler aufgetreten!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("An error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dijekstra.createMatrix();
            form1.Refresh();
            this.Close();
        }
    }
}
