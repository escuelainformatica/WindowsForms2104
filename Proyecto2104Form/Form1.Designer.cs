namespace Proyecto2104Form
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridButtonColumn gridButtonColumn3 = new Syncfusion.WinForms.DataGrid.GridButtonColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.WinForms.DataGrid.GridButtonColumn gridButtonColumn4 = new Syncfusion.WinForms.DataGrid.GridButtonColumn();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.sfDataPager1 = new Syncfusion.WinForms.DataPager.SfDataPager();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridTextColumn5.HeaderText = "Column5";
            gridTextColumn5.MappingName = "Id";
            gridTextColumn6.HeaderText = "Column1";
            gridTextColumn6.MappingName = "Nombre";
            gridTextColumn7.HeaderText = "Column2";
            gridTextColumn7.MappingName = "Precio";
            gridTextColumn8.HeaderText = "Column3";
            gridTextColumn8.MappingName = "Categoria";
            gridButtonColumn3.AllowDefaultButtonText = true;
            gridButtonColumn3.ButtonSize = new System.Drawing.Size(0, 0);
            gridButtonColumn3.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridButtonColumn3.DefaultButtonText = "";
            gridButtonColumn3.HeaderText = "Editar";
            gridButtonColumn3.HeaderTextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            gridButtonColumn3.Image = ((System.Drawing.Image)(resources.GetObject("gridButtonColumn3.Image")));
            gridButtonColumn3.ImageSize = new System.Drawing.Size(16, 16);
            gridButtonColumn3.MappingName = "Column4";
            gridButtonColumn4.AllowDefaultButtonText = true;
            gridButtonColumn4.ButtonSize = new System.Drawing.Size(0, 0);
            gridButtonColumn4.DefaultButtonText = "";
            gridButtonColumn4.HeaderText = "borrar";
            gridButtonColumn4.ImageSize = new System.Drawing.Size(0, 0);
            gridButtonColumn4.MappingName = "Column6";
            this.sfDataGrid1.Columns.Add(gridTextColumn5);
            this.sfDataGrid1.Columns.Add(gridTextColumn6);
            this.sfDataGrid1.Columns.Add(gridTextColumn7);
            this.sfDataGrid1.Columns.Add(gridTextColumn8);
            this.sfDataGrid1.Columns.Add(gridButtonColumn3);
            this.sfDataGrid1.Columns.Add(gridButtonColumn4);
            this.sfDataGrid1.Location = new System.Drawing.Point(12, 12);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.PreviewRowHeight = 35;
            this.sfDataGrid1.Size = new System.Drawing.Size(776, 253);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            this.sfDataGrid1.CellButtonClick += new Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventHandler(this.sfDataGrid1_CellButtonClick);
            // 
            // sfDataPager1
            // 
            this.sfDataPager1.AccessibleName = "DataPager";
            this.sfDataPager1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataPager1.CanOverrideStyle = true;
            this.sfDataPager1.Location = new System.Drawing.Point(12, 271);
            this.sfDataPager1.Name = "sfDataPager1";
            this.sfDataPager1.PageSize = 100;
            this.sfDataPager1.Size = new System.Drawing.Size(776, 46);
            this.sfDataPager1.TabIndex = 1;
            this.sfDataPager1.Text = "sfDataPager1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sfDataPager1);
            this.Controls.Add(this.sfDataGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private Syncfusion.WinForms.DataPager.SfDataPager sfDataPager1;
    }
}

