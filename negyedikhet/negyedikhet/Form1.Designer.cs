
namespace negyedikhet
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.flatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realEstateDataSet = new negyedikhet.RealEstateDataSet();
            this.flatTableAdapter = new negyedikhet.RealEstateDataSetTableAdapters.FlatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.flatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // flatBindingSource
            // 
            this.flatBindingSource.DataMember = "Flat";
            this.flatBindingSource.DataSource = this.realEstateDataSet;
            // 
            // realEstateDataSet
            // 
            this.realEstateDataSet.DataSetName = "RealEstateDataSet";
            this.realEstateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flatTableAdapter
            // 
            this.flatTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.flatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RealEstateDataSet realEstateDataSet;
        private System.Windows.Forms.BindingSource flatBindingSource;
        private RealEstateDataSetTableAdapters.FlatTableAdapter flatTableAdapter;
    }
}

