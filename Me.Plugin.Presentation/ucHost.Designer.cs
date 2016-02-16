namespace Me.Plugin.Presentation
{
    partial class ucHost
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Noeud3");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Noeud0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Noeud1");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Noeud2");
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBoxCommunauteSnmp = new System.Windows.Forms.TextBox();
            this.TextBoxDomaine = new System.Windows.Forms.TextBox();
            this.TextBoxMotDePasse = new System.Windows.Forms.TextBox();
            this.TextBoxMachine = new System.Windows.Forms.TextBox();
            this.TextBoxUtilisateur = new System.Windows.Forms.TextBox();
            this.TabControlGestion = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.TabPage1.SuspendLayout();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.TabControlGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(7, 3);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(401, 209);
            this.DataGridView1.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.SplitContainer1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(747, 499);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "ucHost";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 74);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.TreeView1);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.Button1);
            this.SplitContainer1.Panel2.Controls.Add(this.DataGridView1);
            this.SplitContainer1.Size = new System.Drawing.Size(747, 425);
            this.SplitContainer1.SplitterDistance = 224;
            this.SplitContainer1.TabIndex = 0;
            // 
            // TreeView1
            // 
            this.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView1.Location = new System.Drawing.Point(0, 0);
            this.TreeView1.Name = "TreeView1";
            treeNode1.Name = "Noeud3";
            treeNode1.Text = "Noeud3";
            treeNode2.Name = "Noeud0";
            treeNode2.Text = "Noeud0";
            treeNode3.Name = "Noeud1";
            treeNode3.Text = "Noeud1";
            treeNode4.Name = "Noeud2";
            treeNode4.Text = "Noeud2";
            this.TreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            this.TreeView1.Size = new System.Drawing.Size(224, 425);
            this.TreeView1.TabIndex = 1;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(320, 218);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(88, 27);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Button1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBoxCommunauteSnmp
            // 
            this.TextBoxCommunauteSnmp.Location = new System.Drawing.Point(573, 1);
            this.TextBoxCommunauteSnmp.Name = "TextBoxCommunauteSnmp";
            this.TextBoxCommunauteSnmp.Size = new System.Drawing.Size(124, 20);
            this.TextBoxCommunauteSnmp.TabIndex = 25;
            this.TextBoxCommunauteSnmp.Text = "public";
            // 
            // TextBoxDomaine
            // 
            this.TextBoxDomaine.Location = new System.Drawing.Point(53, 1);
            this.TextBoxDomaine.Name = "TextBoxDomaine";
            this.TextBoxDomaine.Size = new System.Drawing.Size(124, 20);
            this.TextBoxDomaine.TabIndex = 22;
            this.TextBoxDomaine.Text = "NBK-JALVAREZ";
            // 
            // TextBoxMotDePasse
            // 
            this.TextBoxMotDePasse.Location = new System.Drawing.Point(443, 1);
            this.TextBoxMotDePasse.Name = "TextBoxMotDePasse";
            this.TextBoxMotDePasse.Size = new System.Drawing.Size(124, 20);
            this.TextBoxMotDePasse.TabIndex = 24;
            // 
            // TextBoxMachine
            // 
            this.TextBoxMachine.Location = new System.Drawing.Point(183, 1);
            this.TextBoxMachine.Name = "TextBoxMachine";
            this.TextBoxMachine.Size = new System.Drawing.Size(124, 20);
            this.TextBoxMachine.TabIndex = 20;
            this.TextBoxMachine.Text = "localhost";
            // 
            // TextBoxUtilisateur
            // 
            this.TextBoxUtilisateur.Location = new System.Drawing.Point(313, 1);
            this.TextBoxUtilisateur.Name = "TextBoxUtilisateur";
            this.TextBoxUtilisateur.Size = new System.Drawing.Size(124, 20);
            this.TextBoxUtilisateur.TabIndex = 23;
            this.TextBoxUtilisateur.Text = "p-jalvarez";
            // 
            // TabControlGestion
            // 
            this.TabControlGestion.Controls.Add(this.TabPage1);
            this.TabControlGestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabControlGestion.Location = new System.Drawing.Point(0, 22);
            this.TabControlGestion.Name = "TabControlGestion";
            this.TabControlGestion.SelectedIndex = 0;
            this.TabControlGestion.Size = new System.Drawing.Size(755, 525);
            this.TabControlGestion.TabIndex = 21;
            // 
            // ucHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBoxCommunauteSnmp);
            this.Controls.Add(this.TextBoxDomaine);
            this.Controls.Add(this.TextBoxMotDePasse);
            this.Controls.Add(this.TextBoxMachine);
            this.Controls.Add(this.TextBoxUtilisateur);
            this.Controls.Add(this.TabControlGestion);
            this.Name = "ucHost";
            this.Size = new System.Drawing.Size(755, 547);
            this.Load += new System.EventHandler(this.ucHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.TabPage1.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.ResumeLayout(false);
            this.TabControlGestion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.TreeView TreeView1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBoxCommunauteSnmp;
        internal System.Windows.Forms.TextBox TextBoxDomaine;
        internal System.Windows.Forms.TextBox TextBoxMotDePasse;
        internal System.Windows.Forms.TextBox TextBoxMachine;
        internal System.Windows.Forms.TextBox TextBoxUtilisateur;
        internal System.Windows.Forms.TabControl TabControlGestion;
    }
}
