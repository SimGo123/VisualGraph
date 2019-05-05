using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace VisualGraph
{
    public partial class Form1 : Form
    {
        Insert insert;
        Dijekstra dijekstra = new Dijekstra();
        GraphInterpreter gInterpret = new GraphInterpreter();
        Graphics g;
        List<Point> laPoints = new List<Point>();
        bool newVertex;
        bool open = true;
        char language = 'D';

        public Form1(String[] file)
        {
            InitializeComponent();
            insert = new Insert(dijekstra);
            if (file.Length > 0) ParamFile(file[0]);
            cbLanguage.Text = cbLanguage.Items[0].ToString();
        }

        private void laAddKnoten_Click(object sender, EventArgs e)
        {
            String vertexName = "";
            if (language == 'D') vertexName = Interaction.InputBox("Knotenname:", "Knotennamen eingeben");
            else vertexName = Interaction.InputBox("Vertex name:", "Enter vertex name");
            if (vertexName != String.Empty)
            {
                newVertex = true;
                insert.insertVertex(vertexName);
            }
            dijekstra.createMatrix();
        }

        private void laAddKante_Click(object sender, EventArgs e)
        {
            newVertex = false;
            EdgeDialog f2 = new EdgeDialog(dijekstra, insert, this, language);
            f2.Show();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (open)
            {
                g = e.Graphics;
                for (int i = 0; i < laPoints.Count; i++)
                {
                    Label la = new Label();
                    la.Name = "lala";
                    la.Size = new Size(60, 40);
                    la.Location = laPoints[i];
                    la.BackColor = Color.Red;
                    la.Text = insert.getVertexFromIndex(i);
                    la.TextAlign = ContentAlignment.MiddleCenter;
                    this.Controls.Add(la);
                }
                for (int i = 0; i < dijekstra.vertexList.Count; i++)
                {
                    for (int j = 0; j < dijekstra.vertexList.Count; j++)
                    {
                        if (dijekstra.adjacencyMatrix[i, j] != 0)
                        {
                            g.DrawLine(new Pen(Color.Black), PointConvert(laPoints[i]), PointConvert(laPoints[j]));
                        }
                    }
                }
            }
        }

        //Verschieben des Punktes auf Zentrum des Labels
        Point PointConvert(Point pnt)
        {
            return new Point(pnt.X + 30, pnt.Y + 20);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (newVertex)
            {
                laPoints.Add(new Point(e.X - 20, e.Y - 20));
                Refresh();
                newVertex = false;
            }
        }

        private void laDij_Click(object sender, EventArgs e)
        {
            String initialVertex = "";
            if (language == 'D') initialVertex = Interaction.InputBox("Startknoten:", "Startknoten eingeben");
            else initialVertex = Interaction.InputBox("Initial vertex:", "Enter initial vertex");
            List<Vertex> testlist = dijekstra.vertexList.Where(x => x.name == initialVertex).ToList();
            if (testlist.Count != 0)
            {
                double[] distances = dijekstra.DijekstraStart(testlist[0]);
                Results results = new Results(distances, initialVertex, dijekstra.vertexList, language);
                results.Show();
            }
        }

        private void laAdjZeigen_Click(object sender, EventArgs e)
        {
            ShowAdjacency ajz = new ShowAdjacency(dijekstra, language);
            ajz.Show();
        }

        private void laSave_Click(object sender, EventArgs e)
        {
            gInterpret = new GraphInterpreter();
            gInterpret.SaveFile(dijekstra, laPoints, language);
        }

        void ParamFile(String filepath)
        {
            gInterpret = new GraphInterpreter();
            gInterpret.ParseGraph(File.ReadAllLines(filepath));
            Reassignment();
        }

        private void laOpen_Click(object sender, EventArgs e)
        {
            gInterpret = new GraphInterpreter();
            gInterpret.OpenFile(language);
            Reassignment();
        }

        void Reassignment()
        {
            open = false;
            ResetAllLabels(this);
            dijekstra.vertexList = gInterpret.vertexList;
            laPoints = gInterpret.laPoints;
            dijekstra.initialVertex = gInterpret.initialVertex;
            dijekstra.finalVertex = gInterpret.finalVertex;
            dijekstra.weights = gInterpret.weights;
            dijekstra.createMatrix();
            open = true;
            this.Refresh();
        }

        void ResetAllLabels(Control form)
        {
            List<Label> tbdeleted = new List<Label>();
            foreach (Control control in form.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    tbdeleted.Add(label);
                }
            }
            foreach (Label l in tbdeleted) this.Controls.Remove(l);
        }

        private void laClean_Click(object sender, EventArgs e)
        {
            open = false;
            ResetAllLabels(this);
            dijekstra.vertexList.Clear();
            laPoints.Clear();
            dijekstra.initialVertex.Clear();
            dijekstra.finalVertex.Clear();
            dijekstra.weights.Clear();
            dijekstra.createMatrix();
            open = true;
            this.Refresh();
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLanguage.Text.ToString() == cbLanguage.Items[0].ToString())
            {
                language = 'D';
                laShowAdj.Text = "Adjazenzmatrix zeigen";
                laAddVertex.Text = "Knoten hinzufügen";
                laAddEdge.Text = "Kante hinzufügen";
                laDij.Text = "Dijekstra ausführen";
                laSave.Text = "Datei speichern";
                laOpen.Text = "Datei öffnen";
                laClean.Text = "Leeren";
            }
            else if (cbLanguage.Text == cbLanguage.Items[1].ToString())
            {
                language = 'E';
                laShowAdj.Text = "Show adjacency matrix";
                laAddVertex.Text = "Add vertex";
                laAddEdge.Text = "Add edge";
                laDij.Text = "Execute Dijekstra";
                laSave.Text = "Save file";
                laOpen.Text = "Open file";
                laClean.Text = "Clean";
            }
        }
    }
}
