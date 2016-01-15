namespace SQLite_form
{
    partial class MainForm
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPopulate = new System.Windows.Forms.Button();
            this.listBoxDBTables = new System.Windows.Forms.ListBox();
            this.dataSetTest1 = new SQLite_form.DataSetTest();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTest1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(73, 256);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete All Data";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonPopulate
            // 
            this.buttonPopulate.Location = new System.Drawing.Point(47, 12);
            this.buttonPopulate.Name = "buttonPopulate";
            this.buttonPopulate.Size = new System.Drawing.Size(122, 23);
            this.buttonPopulate.TabIndex = 4;
            this.buttonPopulate.Text = "Populate Table";
            this.buttonPopulate.UseVisualStyleBackColor = true;
            // 
            // listBoxDBTables
            // 
            this.listBoxDBTables.FormattingEnabled = true;
            this.listBoxDBTables.Location = new System.Drawing.Point(12, 51);
            this.listBoxDBTables.Name = "listBoxDBTables";
            this.listBoxDBTables.Size = new System.Drawing.Size(198, 199);
            this.listBoxDBTables.TabIndex = 3;
            // 
            // dataSetTest1
            // 
            this.dataSetTest1.DataSetName = "DataSetTest";
            this.dataSetTest1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 292);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonPopulate);
            this.Controls.Add(this.listBoxDBTables);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "SQL Testing";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTest1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPopulate;
        private System.Windows.Forms.ListBox listBoxDBTables;
        private DataSetTest dataSetTest1;
    }
}

