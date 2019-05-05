namespace VisualGraph
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.laClean = new System.Windows.Forms.Label();
            this.laOpen = new System.Windows.Forms.Label();
            this.laSave = new System.Windows.Forms.Label();
            this.laShowAdj = new System.Windows.Forms.Label();
            this.laDij = new System.Windows.Forms.Label();
            this.laAddEdge = new System.Windows.Forms.Label();
            this.laAddVertex = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbLanguage);
            this.panel1.Controls.Add(this.laClean);
            this.panel1.Controls.Add(this.laOpen);
            this.panel1.Controls.Add(this.laSave);
            this.panel1.Controls.Add(this.laShowAdj);
            this.panel1.Controls.Add(this.laDij);
            this.panel1.Controls.Add(this.laAddEdge);
            this.panel1.Controls.Add(this.laAddVertex);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 1000);
            this.panel1.TabIndex = 0;
            // 
            // laClean
            // 
            this.laClean.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laClean.Location = new System.Drawing.Point(0, 491);
            this.laClean.Name = "laClean";
            this.laClean.Size = new System.Drawing.Size(208, 67);
            this.laClean.TabIndex = 5;
            this.laClean.Text = "Leeren";
            this.laClean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laClean.Click += new System.EventHandler(this.laClean_Click);
            // 
            // laOpen
            // 
            this.laOpen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laOpen.Location = new System.Drawing.Point(0, 412);
            this.laOpen.Name = "laOpen";
            this.laOpen.Size = new System.Drawing.Size(208, 67);
            this.laOpen.TabIndex = 4;
            this.laOpen.Text = "Datei öffnen";
            this.laOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laOpen.Click += new System.EventHandler(this.laOpen_Click);
            // 
            // laSave
            // 
            this.laSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laSave.Location = new System.Drawing.Point(0, 332);
            this.laSave.Name = "laSave";
            this.laSave.Size = new System.Drawing.Size(208, 67);
            this.laSave.TabIndex = 1;
            this.laSave.Text = "Datei speichern";
            this.laSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laSave.Click += new System.EventHandler(this.laSave_Click);
            // 
            // laAdjZeigen
            // 
            this.laShowAdj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laShowAdj.Location = new System.Drawing.Point(0, 250);
            this.laShowAdj.Name = "laAdjZeigen";
            this.laShowAdj.Size = new System.Drawing.Size(208, 67);
            this.laShowAdj.TabIndex = 3;
            this.laShowAdj.Text = "Adjazenzmatrix zeigen";
            this.laShowAdj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laShowAdj.Click += new System.EventHandler(this.laAdjZeigen_Click);
            // 
            // laDij
            // 
            this.laDij.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laDij.Location = new System.Drawing.Point(0, 172);
            this.laDij.Name = "laDij";
            this.laDij.Size = new System.Drawing.Size(208, 67);
            this.laDij.TabIndex = 2;
            this.laDij.Text = "Dijekstra ausführen";
            this.laDij.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laDij.Click += new System.EventHandler(this.laDij_Click);
            // 
            // laAddKante
            // 
            this.laAddEdge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laAddEdge.Location = new System.Drawing.Point(0, 93);
            this.laAddEdge.Name = "laAddKante";
            this.laAddEdge.Size = new System.Drawing.Size(208, 67);
            this.laAddEdge.TabIndex = 1;
            this.laAddEdge.Text = "Kante hinzufügen";
            this.laAddEdge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laAddEdge.Click += new System.EventHandler(this.laAddKante_Click);
            // 
            // laAddKnoten
            // 
            this.laAddVertex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laAddVertex.Location = new System.Drawing.Point(0, 14);
            this.laAddVertex.Name = "laAddKnoten";
            this.laAddVertex.Size = new System.Drawing.Size(208, 67);
            this.laAddVertex.TabIndex = 0;
            this.laAddVertex.Text = "Knoten hinzufügen";
            this.laAddVertex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laAddVertex.Click += new System.EventHandler(this.laAddKnoten_Click);
            // 
            // cbLanguage
            // 
            this.cbLanguage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "Deutsch (German)",
            "English"});
            this.cbLanguage.Location = new System.Drawing.Point(7, 630);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(198, 28);
            this.cbLanguage.TabIndex = 6;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Language/Sprache:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 719);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VisualGraph";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label laAddVertex;
        private System.Windows.Forms.Label laAddEdge;
        private System.Windows.Forms.Label laDij;
        private System.Windows.Forms.Label laShowAdj;
        private System.Windows.Forms.Label laSave;
        private System.Windows.Forms.Label laOpen;
        private System.Windows.Forms.Label laClean;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label label1;
    }
}

