using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace VisualGraph
{
    /// <summary>
    /// Creates and opens files with a .graph-extension
    /// </summary>
    class GraphInterpreter
    {
        Dijekstra dijekstra;
        List<Point> laPointsÜbg;
        char language;

        public List<Vertex> vertexList = new List<Vertex>();
        public List<Point> laPoints = new List<Point>();
        public List<int> initialVertex = new List<int>();
        public List<int> finalVertex = new List<int>();
        public List<double> weights = new List<double>();

        public void SaveFile(Dijekstra dij, List<Point> laPts, char language1)
        {
            dijekstra = dij;
            laPointsÜbg = laPts;
            language = language1;

            SaveFileDialog sfd = new SaveFileDialog();
            if (language == 'D')
            {
                sfd.Filter = "Graph-Datei|*.graph";
                sfd.Title = "Graph speichern";
            }
            else
            {
                sfd.Filter = "Graph-File|*.graph";
                sfd.Title = "Save graph";
            }
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(sfd.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(CreateText());
                }
            }
            sfd.Dispose();
        }

        String CreateText()
        {
            String ret = "";
            if (language == 'D')
            {
                ret += "Knoten:{";
                for (int i = 0; i < dijekstra.vertexList.Count; i++)
                {
                    ret += dijekstra.vertexList[i].name;
                    if (i != dijekstra.vertexList.Count - 1) ret += ";";
                }
                ret += "}\n";
                ret += "LaPunkte:{";
                foreach (Point pnt in laPointsÜbg)
                {
                    ret += "(" + pnt.X + ";" + pnt.Y + ")";
                }
                ret += "}\n";
                ret += "Kanten:{";
                for (int i = 0; i < dijekstra.initialVertex.Count; i++)
                {
                    ret += "(" + dijekstra.initialVertex[i] + ";" + dijekstra.finalVertex[i] + ";" + dijekstra.weights[i] + ")";
                }
                ret += "}\n";
            }
            else
            {
                ret += "Vertices:{";
                for (int i = 0; i < dijekstra.vertexList.Count; i++)
                {
                    ret += dijekstra.vertexList[i].name;
                    if (i != dijekstra.vertexList.Count - 1) ret += ";";
                }
                ret += "}\n";
                ret += "LaPoints:{";
                foreach (Point pnt in laPointsÜbg)
                {
                    ret += "(" + pnt.X + ";" + pnt.Y + ")";
                }
                ret += "}\n";
                ret += "Edges:{";
                for (int i = 0; i < dijekstra.initialVertex.Count; i++)
                {
                    ret += "(" + dijekstra.initialVertex[i] + ";" + dijekstra.finalVertex[i] + ";" + dijekstra.weights[i] + ")";
                }
                ret += "}\n";
            }
            return ret;
        }

        public void OpenFile(char language1)
        {
            language = language1;
            OpenFileDialog ofd = new OpenFileDialog();
            if (language == 'D')
            {
                ofd.Filter = "Graph-Datei|*.graph";
                ofd.Title = "Graph öffnen";
            }
            else
            {
                ofd.Filter = "Graph-File|*.graph";
                ofd.Title = "Open graph";
            }
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ParseGraph(File.ReadAllLines(ofd.FileName));
            }
            ofd.Dispose();
        }

        public void ParseGraph(String[] lines)
        {
            try
            {
                String vertextext = lines[0].Split('{', '}')[1];
                String[] vertexNames = vertextext.Split(';');
                foreach (String vname in vertexNames) vertexList.Add(new Vertex(vname));

                String pointtext = lines[1].Split('{', '}')[1];
                List<String> pointStructure = pointtext.Split('(', ')').ToList();
                pointStructure.RemoveAll(x => x == "");
                foreach (String pts in pointStructure)
                {
                    String[] xy = pts.Split(';');
                    laPoints.Add(new Point(Convert.ToInt32(xy[0]), Convert.ToInt32(xy[1])));
                }

                String edgetext = lines[2].Split('{', '}')[1];
                List<String> edgeStructure = edgetext.Split('(', ')').ToList();
                edgeStructure.RemoveAll(x => x == "");
                foreach (String edg in edgeStructure)
                {
                    String[] sew = edg.Split(';');
                    initialVertex.Add(Convert.ToInt32(sew[0]));
                    finalVertex.Add(Convert.ToInt32(sew[1]));
                    weights.Add(Convert.ToDouble(sew[2]));
                }
            }
            catch (Exception)
            {
                if (language == 'D') MessageBox.Show("Fehler beim Dateilesen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Error while reading file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
