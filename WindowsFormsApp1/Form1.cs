using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Visor2;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Visor visor;
        private const float COEFICIENTE_ZOOM_AUMENTAR = 1.1f;
        private const float COEFICIENTE_ZOOM_REDUCIR = 0.9f;
        private const String TITULO_VENTANA_ERROR_GENERAL = "Aviso";
        private const String MENSAJE_VENTANA_ERROR_GENERAL = "No has añadido ninguna foto aún.";
        private int locationYLabelFooter;
        private int alturaVentana;
        private string[] nombreFotos;
        private int controlZoom;

        public Form1()
        {
            visor = new Visor(958, 415);
            InitializeComponent();
            alturaVentana = this.Size.Height;
            locationYLabelFooter = fotoInfoLabel.Location.Y;
            controlZoom = 0;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFicheroDialog.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cargarFicheroBrn_Click(object sender, EventArgs e)
        {
            if (abrirFicheroDialog.ShowDialog() != DialogResult.Cancel)
            {
                if (visor.Num_Fotos() > 0)
                {
                    visor = new Visor(displayImagen.Width, displayImagen.Height);
                }

                int nbImagesCargadas = abrirFicheroDialog.FileNames.Length;

                if (nbImagesCargadas > 0)
                {
                    this.nombreFotos = new string[nbImagesCargadas];
                    for (int i = 0; i < nbImagesCargadas; i++)
                    {
                        visor.Agregar_Foto(abrirFicheroDialog.FileNames[i]);
                        nombreFotos[i] = System.IO.Path.GetFileName(abrirFicheroDialog.SafeFileNames[i]);
                    }
                    displayImagen.Image = visor.Get_Foto(0);
                    string nombreFichero = System.IO.Path.GetFileName(abrirFicheroDialog.SafeFileNames[0]);
                    estableceInformacionFooter(nombreFichero);
                }
            }
        }

        private void estableceInformacionFooter(string nombreFichero)
        {
            int numeroActual = visor.Num_Actual + 1;
            int total = visor.Num_Fotos();
            fotoInfoLabel.Text = nombreFichero + "      (" + numeroActual + "/" + total + ")";

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void siguienteFoto(object sender, EventArgs e)
        {
            if (visor.Num_Fotos() > 0)
            {
                displayImagen.Image = visor.Next_Foto();
                estableceInformacionFooter(this.nombreFotos[visor.Num_Actual]);
            }
            else
            {
                muestraError(TITULO_VENTANA_ERROR_GENERAL, MENSAJE_VENTANA_ERROR_GENERAL);
            }
        }

        private void muestraError(String titulo, String mensaje)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK);
        }

        private void anteriorFoto(object sender, EventArgs e)
        {
            if (visor.Num_Fotos() > 0)
            {
                displayImagen.Image = visor.Prev_Foto();
                estableceInformacionFooter(this.nombreFotos[visor.Num_Actual]);
            }
            else 
            {
                muestraError(TITULO_VENTANA_ERROR_GENERAL, MENSAJE_VENTANA_ERROR_GENERAL);
            }
        }

        private void addZoomClick(object sender, EventArgs e)
        {
            if (visor.Num_Fotos() > 0)
            {
                displayImagen.Image = visor.Zoom(COEFICIENTE_ZOOM_AUMENTAR);
                controlZoom++;
            }
            else
            {
                muestraError(TITULO_VENTANA_ERROR_GENERAL, MENSAJE_VENTANA_ERROR_GENERAL);
            }
        }

        private void reduceZoomClick(object sender, EventArgs e)
        {
            if (visor.Num_Fotos() > 0)
            {
                displayImagen.Image = visor.Zoom(COEFICIENTE_ZOOM_REDUCIR);
                controlZoom--;
            }
            else
            {
                muestraError(TITULO_VENTANA_ERROR_GENERAL, MENSAJE_VENTANA_ERROR_GENERAL);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolBoxBtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giraIzquierda(object sender, EventArgs e)
        {
            if (visor.Num_Fotos() > 0)
            {
                visor.rotar_antihor();
                displayImagen.Image = visor.Foto_Actual();
            }
        }

        private void girarDerecha(object sender, EventArgs e)
        {
            if (visor.Num_Fotos() > 0)
            {
                visor.rotar_hor();
                displayImagen.Image = visor.Foto_Actual();
            }
        }

        private void restaurarZoom(object sender, EventArgs e)
        {
            if (visor.Num_Fotos() > 0)
            {
                displayImagen.Image = visor.Zoom(0.0f);
                controlZoom = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void displayImagen_Click(object sender, EventArgs e)
        {

        }

        private void onResizeWindow(object sender, EventArgs e)
        {

            fijarFooter();
            redimensionarPictureBox();
        }

        private void redimensionarPictureBox()
        {
            int altoPictureBox = this.displayImagen.Size.Height;
            int anchoPictureBox = this.displayImagen.Size.Width;

            visor.Resize(anchoPictureBox, altoPictureBox);
            displayImagen.Image = visor.Foto_Actual();

        }

        private void fijarFooter()
        {
            int diferenciaAltura = 0;

            if (this.Size.Height > this.alturaVentana)
            {
                diferenciaAltura = this.Size.Height - alturaVentana;
            }
            else
            {
                diferenciaAltura = alturaVentana - this.Size.Height;
            }

            int locationY = fotoInfoLabel.Location.Y;
            fotoInfoLabel.Location = new Point(
                fotoInfoLabel.Location.X,
                locationYLabelFooter + diferenciaAltura
            );
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            if (visor.Num_Fotos() < 1)
            {
                return;
            }

            if (e.Delta > 0)
            {
                // scroll up

                displayImagen.Image = visor.Next_Foto();
            }
            else
            {
                // scroll down
                displayImagen.Image = visor.Prev_Foto();
            }

            estableceInformacionFooter(this.nombreFotos[visor.Num_Actual]);
        }

        private void iniciaDesplazamiento(int x, int y)
        {
            if (visor.Num_Fotos() > 0 && this.controlZoom > 0)
            {
                displayImagen.Image = visor.Despl(x, y);
            }
        }

        private void cambiaPunteroMano(object sender, EventArgs e)
        {
            if (visor.Num_Fotos() < 1) return;
            displayImagen.Cursor = Cursors.Hand;
        }

        private void disparaEventosTeclado(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.Left)
            {
                iniciaDesplazamiento(10, 0);
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.Right) {
                iniciaDesplazamiento(-10, 0);
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.Up)
            {
                iniciaDesplazamiento(0, 10);
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.Down)
            {
                iniciaDesplazamiento(0, -10);
            } else if (e.KeyCode == Keys.Left)
            {
                displayImagen.Image = visor.Prev_Foto();
            } else if (e.KeyCode == Keys.Right) {
                displayImagen.Image = visor.Next_Foto();
            }
        }

        private void mostrarAyuda(object sender, EventArgs e)
        { 
            new AyudaForm().ShowDialog();
        }
    }
}
