namespace ExampleSystem
{
    partial class adminPanel
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
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.ogrenciCikis = new DevExpress.XtraEditors.SimpleButton();
            this.btnOgretmen = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.btnOgrenci = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.btnGenelBasari = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel2
            // 
            this.sidePanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sidePanel2.Appearance.Options.UseBackColor = true;
            this.sidePanel2.Location = new System.Drawing.Point(0, 0);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1051, 5);
            this.sidePanel2.TabIndex = 23;
            this.sidePanel2.Text = "sidePanel1";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Location = new System.Drawing.Point(0, 602);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1051, 5);
            this.sidePanel1.TabIndex = 24;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // ogrenciCikis
            // 
            this.ogrenciCikis.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ogrenciCikis.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciCikis.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ogrenciCikis.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.ogrenciCikis.Appearance.Options.UseBackColor = true;
            this.ogrenciCikis.Appearance.Options.UseFont = true;
            this.ogrenciCikis.Appearance.Options.UseForeColor = true;
            this.ogrenciCikis.Location = new System.Drawing.Point(991, 0);
            this.ogrenciCikis.Name = "ogrenciCikis";
            this.ogrenciCikis.Size = new System.Drawing.Size(60, 46);
            this.ogrenciCikis.TabIndex = 25;
            this.ogrenciCikis.Text = "X";
            this.ogrenciCikis.Click += new System.EventHandler(this.ogrenciCikis_Click);
            // 
            // btnOgretmen
            // 
            this.btnOgretmen.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.btnOgretmen.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmen.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnOgretmen.Appearance.Options.UseBackColor = true;
            this.btnOgretmen.Appearance.Options.UseFont = true;
            this.btnOgretmen.Appearance.Options.UseForeColor = true;
            this.btnOgretmen.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmen.AppearanceHovered.Options.UseFont = true;
            this.btnOgretmen.Location = new System.Drawing.Point(63, 526);
            this.btnOgretmen.Name = "btnOgretmen";
            this.btnOgretmen.Size = new System.Drawing.Size(200, 46);
            this.btnOgretmen.TabIndex = 33;
            this.btnOgretmen.Text = "Öğretmenler";
            this.btnOgretmen.Click += new System.EventHandler(this.btnOgretmen_Click);
            // 
            // sidePanel3
            // 
            this.sidePanel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sidePanel3.Appearance.Options.UseBackColor = true;
            this.sidePanel3.Location = new System.Drawing.Point(58, 527);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(202, 48);
            this.sidePanel3.TabIndex = 34;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.btnOgrenci.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnOgrenci.Appearance.Options.UseBackColor = true;
            this.btnOgrenci.Appearance.Options.UseFont = true;
            this.btnOgrenci.Appearance.Options.UseForeColor = true;
            this.btnOgrenci.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.AppearanceHovered.Options.UseFont = true;
            this.btnOgrenci.Location = new System.Drawing.Point(415, 526);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(200, 46);
            this.btnOgrenci.TabIndex = 35;
            this.btnOgrenci.Text = "Öğrenciler";
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // sidePanel4
            // 
            this.sidePanel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sidePanel4.Appearance.Options.UseBackColor = true;
            this.sidePanel4.Location = new System.Drawing.Point(410, 527);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(202, 48);
            this.sidePanel4.TabIndex = 36;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // btnGenelBasari
            // 
            this.btnGenelBasari.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.btnGenelBasari.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenelBasari.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnGenelBasari.Appearance.Options.UseBackColor = true;
            this.btnGenelBasari.Appearance.Options.UseFont = true;
            this.btnGenelBasari.Appearance.Options.UseForeColor = true;
            this.btnGenelBasari.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenelBasari.AppearanceHovered.Options.UseFont = true;
            this.btnGenelBasari.Location = new System.Drawing.Point(764, 526);
            this.btnGenelBasari.Name = "btnGenelBasari";
            this.btnGenelBasari.Size = new System.Drawing.Size(200, 46);
            this.btnGenelBasari.TabIndex = 37;
            this.btnGenelBasari.Text = "Genel Başarı";
            this.btnGenelBasari.Click += new System.EventHandler(this.btnGenelBasari_Click);
            // 
            // sidePanel5
            // 
            this.sidePanel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sidePanel5.Appearance.Options.UseBackColor = true;
            this.sidePanel5.Location = new System.Drawing.Point(759, 527);
            this.sidePanel5.Name = "sidePanel5";
            this.sidePanel5.Size = new System.Drawing.Size(202, 48);
            this.sidePanel5.TabIndex = 38;
            this.sidePanel5.Text = "sidePanel5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(906, 417);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.Visible = false;
            // 
            // chartControl1
            // 
            this.chartControl1.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram2;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(58, 60);
            this.chartControl1.Name = "chartControl1";
            series4.Name = "Doğru";
            series5.Name = "Yanlış";
            series6.Name = "Boş";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4,
        series5,
        series6};
            this.chartControl1.Size = new System.Drawing.Size(906, 417);
            this.chartControl1.TabIndex = 40;
            this.chartControl1.Visible = false;
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1051, 607);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGenelBasari);
            this.Controls.Add(this.sidePanel5);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.sidePanel4);
            this.Controls.Add(this.btnOgretmen);
            this.Controls.Add(this.sidePanel3);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.ogrenciCikis);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SimpleButton ogrenciCikis;
        private DevExpress.XtraEditors.SimpleButton btnOgretmen;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.SimpleButton btnOgrenci;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.SimpleButton btnGenelBasari;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}