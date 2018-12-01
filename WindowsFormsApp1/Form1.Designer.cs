namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AumentarZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.siguienteFotoBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addZoomBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.salirBtn = new System.Windows.Forms.ToolStripButton();
            this.displayImagen = new System.Windows.Forms.PictureBox();
            this.abrirFicheroDialog = new System.Windows.Forms.OpenFileDialog();
            this.fotoInfoLabel = new System.Windows.Forms.Label();
            this.reducirZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reestablecerZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotarIzquierdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotarDerechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.abrirToolStripMenuItem.Text = "&Abrir...";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.cargarFicheroBrn_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AumentarZoomToolStripMenuItem,
            this.reducirZoomToolStripMenuItem,
            this.reestablecerZoomToolStripMenuItem,
            this.rotarIzquierdaToolStripMenuItem,
            this.rotarDerechaToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // AumentarZoomToolStripMenuItem
            // 
            this.AumentarZoomToolStripMenuItem.Name = "AumentarZoomToolStripMenuItem";
            this.AumentarZoomToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.AumentarZoomToolStripMenuItem.Text = "Aumentar Zoom";
            this.AumentarZoomToolStripMenuItem.Click += new System.EventHandler(this.addZoomClick);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "A&yuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.mostrarAyuda);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton8,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.siguienteFotoBtn,
            this.toolStripSeparator1,
            this.addZoomBtn,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator2,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripSeparator4,
            this.salirBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(982, 63);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(57, 60);
            this.toolStripButton8.Text = "Cargar";
            this.toolStripButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton8.Click += new System.EventHandler(this.cargarFicheroBrn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 63);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButton1.Size = new System.Drawing.Size(47, 60);
            this.toolStripButton1.Text = "Atrás";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.anteriorFoto);
            // 
            // siguienteFotoBtn
            // 
            this.siguienteFotoBtn.Image = ((System.Drawing.Image)(resources.GetObject("siguienteFotoBtn.Image")));
            this.siguienteFotoBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.siguienteFotoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.siguienteFotoBtn.Name = "siguienteFotoBtn";
            this.siguienteFotoBtn.Size = new System.Drawing.Size(75, 60);
            this.siguienteFotoBtn.Text = "Siguiente";
            this.siguienteFotoBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.siguienteFotoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.siguienteFotoBtn.Click += new System.EventHandler(this.siguienteFoto);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 63);
            // 
            // addZoomBtn
            // 
            this.addZoomBtn.Image = ((System.Drawing.Image)(resources.GetObject("addZoomBtn.Image")));
            this.addZoomBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addZoomBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addZoomBtn.Name = "addZoomBtn";
            this.addZoomBtn.Size = new System.Drawing.Size(78, 60);
            this.addZoomBtn.Text = "Aumentar";
            this.addZoomBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addZoomBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addZoomBtn.ToolTipText = "Aumentar";
            this.addZoomBtn.Click += new System.EventHandler(this.addZoomClick);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(63, 60);
            this.toolStripButton4.Text = "Reducir";
            this.toolStripButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.reduceZoomClick);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(63, 60);
            this.toolStripButton5.Text = "Normal";
            this.toolStripButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Click += new System.EventHandler(this.restaurarZoom);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 63);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(75, 60);
            this.toolStripButton6.Text = "Izquierda";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton6.Click += new System.EventHandler(this.giraIzquierda);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(68, 60);
            this.toolStripButton7.Text = "Derecha";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton7.Click += new System.EventHandler(this.girarDerecha);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 63);
            // 
            // salirBtn
            // 
            this.salirBtn.Image = ((System.Drawing.Image)(resources.GetObject("salirBtn.Image")));
            this.salirBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(42, 60);
            this.salirBtn.Text = "Salir";
            this.salirBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.salirBtn.Click += new System.EventHandler(this.salirToolBoxBtn);
            // 
            // displayImagen
            // 
            this.displayImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.displayImagen.Location = new System.Drawing.Point(0, 94);
            this.displayImagen.MinimumSize = new System.Drawing.Size(600, 100);
            this.displayImagen.Name = "displayImagen";
            this.displayImagen.Size = new System.Drawing.Size(982, 415);
            this.displayImagen.TabIndex = 2;
            this.displayImagen.TabStop = false;
            this.displayImagen.Click += new System.EventHandler(this.displayImagen_Click);
            this.displayImagen.MouseEnter += new System.EventHandler(this.cambiaPunteroMano);
            // 
            // abrirFicheroDialog
            // 
            this.abrirFicheroDialog.FileName = "abrirFicheroDialog";
            this.abrirFicheroDialog.Filter = "Imágenes|*.jpg;*.png;*.jpeg";
            this.abrirFicheroDialog.Multiselect = true;
            this.abrirFicheroDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // fotoInfoLabel
            // 
            this.fotoInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fotoInfoLabel.Location = new System.Drawing.Point(-3, 509);
            this.fotoInfoLabel.Name = "fotoInfoLabel";
            this.fotoInfoLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.fotoInfoLabel.Size = new System.Drawing.Size(985, 44);
            this.fotoInfoLabel.TabIndex = 3;
            this.fotoInfoLabel.Text = "--";
            this.fotoInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fotoInfoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // reducirZoomToolStripMenuItem
            // 
            this.reducirZoomToolStripMenuItem.Name = "reducirZoomToolStripMenuItem";
            this.reducirZoomToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.reducirZoomToolStripMenuItem.Text = "Reducir Zoom";
            this.reducirZoomToolStripMenuItem.Click += new System.EventHandler(this.reduceZoomClick);
            // 
            // reestablecerZoomToolStripMenuItem
            // 
            this.reestablecerZoomToolStripMenuItem.Name = "reestablecerZoomToolStripMenuItem";
            this.reestablecerZoomToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.reestablecerZoomToolStripMenuItem.Text = "Reestablecer Zoom";
            this.reestablecerZoomToolStripMenuItem.Click += new System.EventHandler(this.restaurarZoom);
            // 
            // rotarIzquierdaToolStripMenuItem
            // 
            this.rotarIzquierdaToolStripMenuItem.Name = "rotarIzquierdaToolStripMenuItem";
            this.rotarIzquierdaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rotarIzquierdaToolStripMenuItem.Text = "Rotar Izquierda";
            this.rotarIzquierdaToolStripMenuItem.Click += new System.EventHandler(this.giraIzquierda);
            // 
            // rotarDerechaToolStripMenuItem
            // 
            this.rotarDerechaToolStripMenuItem.Name = "rotarDerechaToolStripMenuItem";
            this.rotarDerechaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rotarDerechaToolStripMenuItem.Text = "Rotar Derecha";
            this.rotarDerechaToolStripMenuItem.Click += new System.EventHandler(this.girarDerecha);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.fotoInfoLabel);
            this.Controls.Add(this.displayImagen);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor Imágenes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.disparaEventosTeclado);
            this.Resize += new System.EventHandler(this.onResizeWindow);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AumentarZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton siguienteFotoBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton addZoomBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.PictureBox displayImagen;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.OpenFileDialog abrirFicheroDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton salirBtn;
        private System.Windows.Forms.Label fotoInfoLabel;
        private System.Windows.Forms.ToolStripMenuItem reducirZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reestablecerZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotarIzquierdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotarDerechaToolStripMenuItem;
    }
}

