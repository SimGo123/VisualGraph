namespace VisualGraph
{
    partial class EdgeDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdgeDialog));
            this.laAddEdge = new System.Windows.Forms.Label();
            this.laInitialVertex = new System.Windows.Forms.Label();
            this.laFinalVertex = new System.Windows.Forms.Label();
            this.laWeight = new System.Windows.Forms.Label();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.buOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laAddEdge
            // 
            this.laAddEdge.AutoSize = true;
            this.laAddEdge.Location = new System.Drawing.Point(134, 39);
            this.laAddEdge.Name = "laAddEdge";
            this.laAddEdge.Size = new System.Drawing.Size(154, 22);
            this.laAddEdge.TabIndex = 0;
            this.laAddEdge.Text = "Kante hinzufügen:";
            // 
            // laInitialVertex
            // 
            this.laInitialVertex.AutoSize = true;
            this.laInitialVertex.Location = new System.Drawing.Point(27, 83);
            this.laInitialVertex.Name = "laInitialVertex";
            this.laInitialVertex.Size = new System.Drawing.Size(107, 22);
            this.laInitialVertex.TabIndex = 1;
            this.laInitialVertex.Text = "Startknoten:";
            // 
            // laFinalVertex
            // 
            this.laFinalVertex.AutoSize = true;
            this.laFinalVertex.Location = new System.Drawing.Point(33, 133);
            this.laFinalVertex.Name = "laFinalVertex";
            this.laFinalVertex.Size = new System.Drawing.Size(101, 22);
            this.laFinalVertex.TabIndex = 2;
            this.laFinalVertex.Text = "Endknoten:";
            // 
            // laWeight
            // 
            this.laWeight.AutoSize = true;
            this.laWeight.Location = new System.Drawing.Point(54, 182);
            this.laWeight.Name = "laWeight";
            this.laWeight.Size = new System.Drawing.Size(80, 22);
            this.laWeight.TabIndex = 3;
            this.laWeight.Text = "Gewicht:";
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(157, 83);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(131, 27);
            this.tbStart.TabIndex = 4;
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(157, 130);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(131, 27);
            this.tbEnd.TabIndex = 5;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(157, 179);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(131, 27);
            this.tbWeight.TabIndex = 6;
            // 
            // buOk
            // 
            this.buOk.Location = new System.Drawing.Point(179, 229);
            this.buOk.Name = "buOk";
            this.buOk.Size = new System.Drawing.Size(86, 41);
            this.buOk.TabIndex = 7;
            this.buOk.Text = "OK";
            this.buOk.UseVisualStyleBackColor = true;
            this.buOk.Click += new System.EventHandler(this.buOk_Click);
            // 
            // EdgeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 282);
            this.Controls.Add(this.buOk);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.tbStart);
            this.Controls.Add(this.laWeight);
            this.Controls.Add(this.laFinalVertex);
            this.Controls.Add(this.laInitialVertex);
            this.Controls.Add(this.laAddEdge);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EdgeDialog";
            this.Text = "Kante hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laAddEdge;
        private System.Windows.Forms.Label laInitialVertex;
        private System.Windows.Forms.Label laFinalVertex;
        private System.Windows.Forms.Label laWeight;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Button buOk;
    }
}