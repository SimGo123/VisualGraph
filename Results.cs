using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace VisualGraph
{
    /// <summary>
    /// Displays the results
    /// </summary>
    public partial class Results : Form
    {
        public Results(double[] distances, String initialVertex, List<Vertex> vertexList, char language)
        {
            InitializeComponent();
            if (language == 'D') laHead.Text = "Entfernungen vom Startknoten " + initialVertex;
            else laHead.Text = "Distance to the initial vertex " + initialVertex;
            DataTable table = new DataTable();
            dataGridView1.DataSource = table;
            DataRow row = table.NewRow();

            for (int i = 0; i < vertexList.Count; i++)
            {
                table.Columns.Add(vertexList[i].name);
            }
            for (int i = 0; i < vertexList.Count; i++)
            {
                row[vertexList[i].name] = distances[i].ToString();
            }
            table.Rows.Add(row);
        }
    }
}
