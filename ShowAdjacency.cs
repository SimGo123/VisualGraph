using System.Data;
using System.Windows.Forms;

namespace VisualGraph
{
    /// <summary>
    /// Displays the adjacency matrix
    /// </summary>
    public partial class ShowAdjacency : Form
    {
        public ShowAdjacency(Dijekstra dijekstra, char language)
        {
            InitializeComponent();

            DataTable tabele = new DataTable();
            dataGridView1.DataSource = tabele;

            if (language == 'D') laAdj.Text = "Adjazenzmatrix";
            else laAdj.Text = "Adjacency matrix";

            for (int i = 0; i < dijekstra.vertexList.Count; i++)
            {
                tabele.Columns.Add(dijekstra.vertexList[i].name);
            }
            for (int i = 0; i < dijekstra.vertexList.Count; i++)
            {
                DataRow row = tabele.NewRow();
                for (int j = 0; j < dijekstra.vertexList.Count; j++)
                {
                    row[dijekstra.vertexList[j].name] = dijekstra.adjacencyMatrix[i, j];
                }
                tabele.Rows.Add(row);
            }
        }
    }
}
