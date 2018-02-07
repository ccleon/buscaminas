using BuscaminasWindows.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaminasWindows
{
    public partial class ventana_JuegoBuscaminas : Form
    {
        private int columnas, filas, nivel;
        private int levantadas = 0;
        private MiBoton[,] botones;
        private Tablero tablero;
        private MiBoton miboton;
        bool ponFlag = false;

        public ventana_JuegoBuscaminas()
        {
            InitializeComponent();
        }

        private void btn_comenzar_Click(object sender, EventArgs e)
        {
            String nivelSeleccionado = cbox_nivel.Text;

            switch (nivelSeleccionado)
            {
                case ("Facil"):
                    filas = 5;
                    columnas = 5;
                    nivel = 1;
                    break;
                case ("Medio"):
                    filas = 10;
                    columnas = 10;
                    nivel = 2;
                    break;
                case ("Dificil"):
                    filas = 15;
                    columnas = 15;
                    nivel = 3;
                    break;
            }

            lbl_nivel.Visible = false;
            btn_comenzar.Visible = false;
            cbox_nivel.Visible = false;
            btn_restart.Visible = true;
            lbl_levantadas.Visible = true;
            lbl_levantadas.Text = "Puntuacion: ";

            InicializaTablero();
        }

        public void InicializaTablero()
        {
            tablero = new Tablero(filas, columnas, nivel);
            lyt_tablero.RowCount = filas;
            lyt_tablero.ColumnCount = columnas;
            botones = new MiBoton[filas, columnas];

            for (int f = 0; f < filas; f++)
                for (int c = 0; c < columnas; c++)
                {
                    botones[f, c] = new MiBoton(f, c);
                    botones[f, c].AutoSize = true;
                    botones[f, c].Width = 33;
                    botones[f, c].Height = 33;
                    botones[f, c].Margin = new Padding(0);
                    botones[f, c].Image = global::BuscaminasWindows.Properties.Resources.img_vacia;
                    lyt_tablero.Controls.Add(botones[f, c]);
                    botones[f, c].MouseDown += new MouseEventHandler(this.boton_click);
                }
        }


        private void boton_click(object sender, EventArgs e)
        {
            miboton = (MiBoton)sender;
            MouseEventArgs me = (MouseEventArgs)e;
            int col = miboton.getColumna();
            int fil = miboton.getFila();

            switch (me.Button)
            {
                case MouseButtons.Left:
                    tablero.LevantaCasilla(fil + 1, col + 1);

                    if (tablero.EsBomba(fil + 1, col + 1))
                    {
                        miboton.Image = global::BuscaminasWindows.Properties.Resources.img_bomba;
                        tablero.LevantarTodas();
                        ActualizarTablero();
                        MessageBox.Show("¡BOOOOMBA! \nHas perdido");
                    }
                    else
                    {
                        ActualizarTablero();
                        lbl_levantadas.Text = "Puntuacion: " + levantadas;

                        if (((tablero.GetNumeroCasillas()) - tablero.CuantasBombas()) == levantadas)
                        {
                            tablero.LevantarTodas();
                            ActualizarTablero();
                            MessageBox.Show("¡Enhorabuena! \n¡HAS GANADO!");
                        }
                    }
                    break;

                case MouseButtons.Right:
                    if (!tablero.EstaLevantada(fil+1,col+1) && !ponFlag)
                    {
                        miboton.Image = global::BuscaminasWindows.Properties.Resources.img_flag;
                        ponFlag = true;
                    }else if(!tablero.EstaLevantada(fil + 1, col + 1) && ponFlag)
                    {
                        miboton.Image = global::BuscaminasWindows.Properties.Resources.img_vacia;
                        ponFlag = false;
                    }
                    break;
            }
        }
        
        private void ActualizarTablero()
        {
            levantadas = 0;
            for (int f = 0; f < filas; f++)
                for (int c = 0; c < columnas; c++)
                {
                    if (tablero.EstaLevantada(f + 1, c + 1))
                    {
                        levantadas++;
                        if (tablero.EsBomba(f + 1, c + 1))
                        {
                            botones[f, c].Image = global::BuscaminasWindows.Properties.Resources.img_bomba;
                        } else
                        {
                            switch (tablero.DameValor(f + 1, c + 1))
                            {
                                case 0:
                                    botones[f, c].Image = global::BuscaminasWindows.Properties.Resources.img_cover;
                                    break;
                                case 1:
                                    botones[f, c].Image = global::BuscaminasWindows.Properties.Resources.img_uno;
                                    break;
                                case 2:
                                    botones[f, c].Image = global::BuscaminasWindows.Properties.Resources.img_dos;
                                    break;
                                case 3:
                                    botones[f, c].Image = global::BuscaminasWindows.Properties.Resources.img_tres;
                                    break;
                                case 4:
                                    botones[f, c].Image = global::BuscaminasWindows.Properties.Resources.img_cuatro;
                                    break;
                                case 5:
                                    botones[f, c].Image = global::BuscaminasWindows.Properties.Resources.img_cinco;
                                    break;
                                case 6:
                                    botones[f, c].Image = global::BuscaminasWindows.Properties.Resources.img_seis;
                                    break;
                                case 7:
                                    botones[f, c].Image = global::BuscaminasWindows.Properties.Resources.img_siete;
                                    break;
                                case 8:
                                    botones[f, c].Image = global::BuscaminasWindows.Properties.Resources.img_eight;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }
    }
}
