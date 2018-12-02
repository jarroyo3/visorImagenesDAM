namespace WindowsFormsApp1 {
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Visor2;

    /// <summary>
    /// Defines the <see cref="Form1" />
    /// </summary>
    public partial class Form1 : Form {
        /// <summary>
        /// Defines the visor
        /// </summary>
        private Visor visor;

        /// <summary>
        /// Defines the COEFICIENTE_ZOOM_AUMENTAR
        /// </summary>
        private const float COEFICIENTE_ZOOM_AUMENTAR = 1.1f;

        /// <summary>
        /// Defines the COEFICIENTE_ZOOM_REDUCIR
        /// </summary>
        private const float COEFICIENTE_ZOOM_REDUCIR = 0.9f;

        /// <summary>
        /// Defines the TITULO_VENTANA_ERROR_GENERAL
        /// </summary>
        private const String TITULO_VENTANA_ERROR_GENERAL = "Aviso";

        /// <summary>
        /// Defines the MENSAJE_VENTANA_ERROR_GENERAL
        /// </summary>
        private const String MENSAJE_VENTANA_ERROR_GENERAL = "No has añadido ninguna foto aún.";

        /// <summary>
        /// Defines the locationYLabelFooter
        /// </summary>
        private int locationYLabelFooter;

        /// <summary>
        /// Defines the alturaVentana
        /// </summary>
        private int alturaVentana;

        /// <summary>
        /// Defines the nombreFotos
        /// </summary>
        private string[] nombreFotos;

        /// <summary>
        /// Defines the controlZoom
        /// </summary>
        private int controlZoom;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1() {
            visor = new Visor(958, 415);
            InitializeComponent();
            alturaVentana = this.Size.Height;
            locationYLabelFooter = fotoInfoLabel.Location.Y;
            controlZoom = 0;
        }

        /// <summary>
        /// The abrirToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e) {
            abrirFicheroDialog.ShowDialog();
        }

        /// <summary>
        /// The salirToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// The toolStrip1_ItemClicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="ToolStripItemClickedEventArgs"/></param>
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
        }

        /// <summary>
        /// The cargarFicheroBrn_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void cargarFicheroBrn_Click(object sender, EventArgs e) {
            if (abrirFicheroDialog.ShowDialog() != DialogResult.Cancel) {
                if (visor.Num_Fotos() > 0) {
                    visor = new Visor(displayImagen.Width, displayImagen.Height);
                }

                int nbImagesCargadas = abrirFicheroDialog.FileNames.Length;

                if (nbImagesCargadas > 0) {
                    this.nombreFotos = new string[nbImagesCargadas];
                    for (int i = 0; i < nbImagesCargadas; i++) {
                        visor.Agregar_Foto(abrirFicheroDialog.FileNames[i]);
                        nombreFotos[i] = System.IO.Path.GetFileName(abrirFicheroDialog.SafeFileNames[i]);
                    }
                    displayImagen.Image = visor.Get_Foto(0);
                    string nombreFichero = System.IO.Path.GetFileName(abrirFicheroDialog.SafeFileNames[0]);
                    estableceInformacionFooter(nombreFichero);
                }
            }
        }

        /// <summary>
        /// The estableceInformacionFooter
        /// </summary>
        /// <param name="nombreFichero">The nombreFichero<see cref="string"/></param>
        private void estableceInformacionFooter(string nombreFichero) {
            int numeroActual = visor.Num_Actual + 1;
            int total = visor.Num_Fotos();
            fotoInfoLabel.Text = nombreFichero + "      (" + numeroActual + "/" + total + ")";
        }

        /// <summary>
        /// The openFileDialog1_FileOk
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="CancelEventArgs"/></param>
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {
        }

        /// <summary>
        /// The siguienteFoto
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void siguienteFoto(object sender, EventArgs e) {
            if (visor.Num_Fotos() > 0) {
                displayImagen.Image = visor.Next_Foto();
                estableceInformacionFooter(this.nombreFotos[visor.Num_Actual]);
            } else {
                muestraError(TITULO_VENTANA_ERROR_GENERAL, MENSAJE_VENTANA_ERROR_GENERAL);
            }
        }

        /// <summary>
        /// The muestraError
        /// </summary>
        /// <param name="titulo">The titulo<see cref="String"/></param>
        /// <param name="mensaje">The mensaje<see cref="String"/></param>
        private void muestraError(String titulo, String mensaje) {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK);
        }

        /// <summary>
        /// The anteriorFoto
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void anteriorFoto(object sender, EventArgs e) {
            if (visor.Num_Fotos() > 0) {
                displayImagen.Image = visor.Prev_Foto();
                estableceInformacionFooter(this.nombreFotos[visor.Num_Actual]);
            } else {
                muestraError(TITULO_VENTANA_ERROR_GENERAL, MENSAJE_VENTANA_ERROR_GENERAL);
            }
        }

        /// <summary>
        /// The addZoomClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void addZoomClick(object sender, EventArgs e) {
            if (visor.Num_Fotos() > 0) {
                displayImagen.Image = visor.Zoom(COEFICIENTE_ZOOM_AUMENTAR);
                controlZoom++;
            } else {
                muestraError(TITULO_VENTANA_ERROR_GENERAL, MENSAJE_VENTANA_ERROR_GENERAL);
            }
        }

        /// <summary>
        /// The reduceZoomClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void reduceZoomClick(object sender, EventArgs e) {
            if (visor.Num_Fotos() > 0) {
                displayImagen.Image = visor.Zoom(COEFICIENTE_ZOOM_REDUCIR);
                controlZoom--;
            } else {
                muestraError(TITULO_VENTANA_ERROR_GENERAL, MENSAJE_VENTANA_ERROR_GENERAL);
            }
        }

        /// <summary>
        /// The Form1_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void Form1_Load(object sender, EventArgs e) {
        }

        /// <summary>
        /// The salirToolBoxBtn
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void salirToolBoxBtn(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// The giraIzquierda
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void giraIzquierda(object sender, EventArgs e) {
            if (visor.Num_Fotos() > 0) {
                visor.rotar_antihor();
                displayImagen.Image = visor.Foto_Actual();
            }
        }

        /// <summary>
        /// The girarDerecha
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void girarDerecha(object sender, EventArgs e) {
            if (visor.Num_Fotos() > 0) {
                visor.rotar_hor();
                displayImagen.Image = visor.Foto_Actual();
            }
        }

        /// <summary>
        /// The restaurarZoom
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void restaurarZoom(object sender, EventArgs e) {
            if (visor.Num_Fotos() > 0) {
                displayImagen.Image = visor.Zoom(0.0f);
                controlZoom = 0;
            }
        }

        /// <summary>
        /// The label1_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void label1_Click(object sender, EventArgs e) {
        }

        /// <summary>
        /// The displayImagen_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void displayImagen_Click(object sender, EventArgs e) {
        }

        /// <summary>
        /// The onResizeWindow
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void onResizeWindow(object sender, EventArgs e) {

            fijarFooter();
            redimensionarPictureBox();
        }

        /// <summary>
        /// The redimensionarPictureBox
        /// </summary>
        private void redimensionarPictureBox() {
            int altoPictureBox = this.displayImagen.Size.Height;
            int anchoPictureBox = this.displayImagen.Size.Width;

            visor.Resize(anchoPictureBox, altoPictureBox);
            displayImagen.Image = visor.Foto_Actual();
        }

        /// <summary>
        /// The fijarFooter
        /// </summary>
        private void fijarFooter() {
            int diferenciaAltura = 0;

            if (this.Size.Height > this.alturaVentana) {
                diferenciaAltura = this.Size.Height - alturaVentana;
            } else {
                diferenciaAltura = alturaVentana - this.Size.Height;
            }

            int locationY = fotoInfoLabel.Location.Y;
            fotoInfoLabel.Location = new Point(
                fotoInfoLabel.Location.X,
                locationYLabelFooter + diferenciaAltura
            );
        }

        /// <summary>
        /// The OnMouseWheel
        /// </summary>
        /// <param name="e">The e<see cref="MouseEventArgs"/></param>
        protected override void OnMouseWheel(MouseEventArgs e) {
            base.OnMouseWheel(e);
            if (visor.Num_Fotos() < 1) {
                return;
            }

            if (e.Delta > 0) {
                // scroll up

                displayImagen.Image = visor.Next_Foto();
            } else {
                // scroll down
                displayImagen.Image = visor.Prev_Foto();
            }

            estableceInformacionFooter(this.nombreFotos[visor.Num_Actual]);
        }

        /// <summary>
        /// The iniciaDesplazamiento
        /// </summary>
        /// <param name="x">The x<see cref="int"/></param>
        /// <param name="y">The y<see cref="int"/></param>
        private void iniciaDesplazamiento(int x, int y) {
            if (visor.Num_Fotos() > 0 && this.controlZoom > 0) {
                displayImagen.Image = visor.Despl(x, y);
            }
        }

        /// <summary>
        /// The cambiaPunteroMano
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void cambiaPunteroMano(object sender, EventArgs e) {
            if (visor.Num_Fotos() < 1) return;
            displayImagen.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// The disparaEventosTeclado
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="KeyEventArgs"/></param>
        private void disparaEventosTeclado(object sender, KeyEventArgs e) {
            if (e.Control && e.Shift && e.KeyCode == Keys.Left) {
                iniciaDesplazamiento(10, 0);
            } else if (e.Control && e.Shift && e.KeyCode == Keys.Right) {
                iniciaDesplazamiento(-10, 0);
            } else if (e.Control && e.Shift && e.KeyCode == Keys.Up) {
                iniciaDesplazamiento(0, 10);
            } else if (e.Control && e.Shift && e.KeyCode == Keys.Down) {
                iniciaDesplazamiento(0, -10);
            } else if (e.KeyCode == Keys.Left) {
                displayImagen.Image = visor.Prev_Foto();
            } else if (e.KeyCode == Keys.Right) {
                displayImagen.Image = visor.Next_Foto();
            }
        }

        /// <summary>
        /// The mostrarAyuda
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void mostrarAyuda(object sender, EventArgs e) {
            new AyudaForm().ShowDialog();
        }
    }
}
