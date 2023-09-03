using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TA_TE_TI : Form
    {
        int turnos = 0;
        Jugador jugador1 = new Jugador();
        Jugador jugador2 = new Jugador();
        private class Jugador
        {
            /// <summary>
            ///  Obtenemos la vida del usuario que disminuye aunicamente al perder partidas
            /// </summary>
            private int vida = 3;
            private int movimientos = 5;

            /// Obtenemos el identificador de cada casilla marcada por el usuario <summary>
            /// Luego recorreremos la lista buscando las combinaciones ganadoras
            /// </summary>
            /// 
            public List<int> Casilla { get; set; } = new List<int>();
            public int Vida()
            {
                return vida;
            }
            public int Movimientos()
            {
                return movimientos;
            }
            public int Restar_Movimiento()
            {
               if(movimientos > 0)
                {
                    movimientos--;
                }
                return movimientos;
            }
        }
        public TA_TE_TI()
        {
            InitializeComponent();
            
        }
        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Visible_Interfaz_Game();
            Visible_Interfaz_Turnos();
            BTN_COMENZAR.Visible = false;
            stats(jugador1 , jugador2);
        }
        private void TA_TE_TI_Load(object sender, EventArgs e)
        {
            
        }
        private void TX_1_TextChanged(object sender, EventArgs e)
        {
        }
        // ------------------------------------------------------------------
        //                          COMBINACIONES
        // ------------------------------------------------------------------

        private void Combinaciones(Jugador jugador1 , Jugador jugador2)
        {
            bool Ganador = false;
            if (turnos >= 4)
            {
                ///-------------------------------------------------------------------------------------------------
                ///                                         JUGADOR 2
                ///-------------------------------------------------------------------------------------------------
                ///
                ///-------------------------------------------------------------------------------------------------
                ///                                       FILAS JUGADOR 1
                ///-------------------------------------------------------------------------------------------------
                if ( jugador1.Casilla.Contains(1) && jugador1.Casilla.Contains(2) && jugador1.Casilla.Contains(3))
                {
                    Ganador = true;
                    Mensaje(Ganador);
                }
                if (jugador1.Casilla.Contains(4) && jugador1.Casilla.Contains(4) && jugador1.Casilla.Contains(6))
                {
                    Ganador = true;
                    Mensaje(Ganador);
                }
                if (jugador1.Casilla.Contains(7) && jugador1.Casilla.Contains(8) && jugador1.Casilla.Contains(9))
                {
                    Ganador = true;
                    Mensaje(Ganador);
                }
                ///-------------------------------------------------------------------------------------------------
                ///                                       COLUMNAS JUGADOR 1
                ///-------------------------------------------------------------------------------------------------
                if (jugador1.Casilla.Contains(1) && jugador1.Casilla.Contains(4) && jugador1.Casilla.Contains(7))
                {
                    Ganador = true;
                    Mensaje(Ganador);
                }
                if (jugador1.Casilla.Contains(2) && jugador1.Casilla.Contains(5) && jugador1.Casilla.Contains(8))
                {
                    Ganador = true;
                    Mensaje(Ganador);
                }
                if (jugador1.Casilla.Contains(3) && jugador1.Casilla.Contains(6) && jugador1.Casilla.Contains(9))
                {
                    Ganador = true;
                    Mensaje(Ganador);
                }
                ///-------------------------------------------------------------------------------------------------
                ///                                       DIAGONALES JUGADOR 1
                ///-------------------------------------------------------------------------------------------------
                if (jugador1.Casilla.Contains(1) && jugador1.Casilla.Contains(5) && jugador1.Casilla.Contains(9))
                {
                    Ganador = true;
                    Mensaje(Ganador);
                }
                if (jugador1.Casilla.Contains(3) && jugador1.Casilla.Contains(5) && jugador1.Casilla.Contains(7))
                {
                    Ganador = true;
                    Mensaje(Ganador);
                }
                ///-------------------------------------------------------------------------------------------------
                ///                                          JUGADOR 2
                ///-------------------------------------------------------------------------------------------------
                ///
                ///-------------------------------------------------------------------------------------------------
                ///                                       FILAS JUGADOR 1
                ///-------------------------------------------------------------------------------------------------
                if (jugador2.Casilla.Contains(10) && jugador2.Casilla.Contains(11) && jugador2.Casilla.Contains(12))
                {
                    Ganador = false;
                    Mensaje(Ganador);
                }
                if (jugador2.Casilla.Contains(13) && jugador2.Casilla.Contains(14) && jugador2.Casilla.Contains(15))
                {
                    Ganador = false;
                    Mensaje(Ganador);
                }
                if (jugador2.Casilla.Contains(16) && jugador2.Casilla.Contains(17) && jugador2.Casilla.Contains(18))
                {
                    Ganador = false;
                    Mensaje(Ganador);
                }
                ///-------------------------------------------------------------------------------------------------
                ///                                       COLUMNAS JUGADOR 2
                ///-------------------------------------------------------------------------------------------------
                if (jugador2.Casilla.Contains(10) && jugador2.Casilla.Contains(13) && jugador2.Casilla.Contains(16))
                {
                    Ganador = false;
                    Mensaje(Ganador);
                }
                if (jugador2.Casilla.Contains(11) && jugador2.Casilla.Contains(14) && jugador2.Casilla.Contains(17))
                {
                    Ganador = false;
                    Mensaje(Ganador);
                }
                if (jugador2.Casilla.Contains(12) && jugador2.Casilla.Contains(15) && jugador2.Casilla.Contains(18))
                {
                    Ganador = false;
                    Mensaje(Ganador);
                }
                ///-------------------------------------------------------------------------------------------------
                ///                                   DIAGONALES JUGADOR 2
                ///-------------------------------------------------------------------------------------------------
                if (jugador2.Casilla.Contains(10) && jugador2.Casilla.Contains(14) && jugador2.Casilla.Contains(18))
                {
                    Ganador = false;
                    Mensaje(Ganador);
                }
                if (jugador2.Casilla.Contains(16) && jugador2.Casilla.Contains(14) && jugador2.Casilla.Contains(12))
                {
                    Ganador = false;
                    Mensaje(Ganador);
                }
            }
        }
        public void Mensaje (bool X)
        {
            if ( X == true )
            {
                MessageBox.Show("Jugador 1, Eres el GANADOR ! ! !");
            }
            else 
            {
                MessageBox.Show("Jugador 2, Eres el GANADOR ! ! !");
            }
        }
        // ------------------------------------------------------------------
        //                         VISILIDAD INTERFAZ 
        // ------------------------------------------------------------------
        public void Visible_Interfaz_Game()
        {
            ///
            /// No Visible Tablero
            ///
            TX_1.Visible = true;
            TX_2.Visible = true;
            TX_3.Visible = true;
            TX_4.Visible = true;
            TX_5.Visible = true;
            TX_6.Visible = true;
            TX_7.Visible = true;
            TX_8.Visible = true;
            TX_9.Visible = true;
            ///
            /// No visible Stats
            ///
            LB_MOV1.Visible = true;
            LB_MOV2.Visible = true;
            LB_VIDA1.Visible = true;
            LB_VIDA2.Visible = true;
            LB_TURNO.Visible = true;
            ///
            /// No Escritura TextBox
            ///
            TX_1.ReadOnly = true;
            TX_2.ReadOnly = true;
            TX_3.ReadOnly = true;
            TX_4.ReadOnly = true;
            TX_5.ReadOnly = true;
            TX_6.ReadOnly = true;
            TX_7.ReadOnly = true;
            TX_8.ReadOnly = true;
            TX_9.ReadOnly = true;
            ///
            /// No Seleccionable TextBox
            ///
            TX_1.TabStop = false;
            TX_2.TabStop = false;
            TX_3.TabStop = false;
            TX_4.TabStop = false;
            TX_5.TabStop = false;
            TX_6.TabStop = false;
            TX_7.TabStop = false;
            TX_8.TabStop = false;
            TX_9.TabStop = false;
        }
        public void Visible_Interfaz_Turnos()
        {
            if (turnos % 2 == 0)
            {
                LB_TURNO.Text = "Turno Jugador 1";
            }
            else
            {
                LB_TURNO.Text = "Turno Jugador 2";
            }
        }
        private void stats(Jugador jugador1, Jugador jugador2)
        {
            /// Stats
            LB_VIDA1.Text = "Vida = " + jugador1.Vida().ToString();
            LB_MOV1.Text = "Mov = " + jugador1.Movimientos().ToString();

            ////--------

            // Stats
            LB_VIDA2.Text = "Vida = " + jugador2.Vida().ToString();
            LB_MOV2.Text = "Mov = " + jugador2.Movimientos().ToString();
        }
        // ------------------------------------------------------------------
        //                                TABLERO 
        // ------------------------------------------------------------------
        private void textBox1_Click(object sender, EventArgs e)
        {
            /// TEXT - 1
            if (turnos % 2 == 0)
            {
                LB_MOV1.Text = "Movimiento = " + jugador1.Restar_Movimiento().ToString();
                TX_1.Text = "  X";
                TX_1.Enabled = false;
                jugador1.Casilla.Add(1);
            }
            else
            {
                LB_MOV2.Text = "Movimiento = " + jugador2.Restar_Movimiento().ToString();
                TX_1.Text = "  O";
                TX_1.Enabled = false;
                jugador2.Casilla.Add(10);
            }
            turnos++;
            Visible_Interfaz_Turnos();
            Combinaciones(jugador1,jugador2);
        }
        private void TX_2_Click(object sender, EventArgs e)
        {
            if (turnos % 2 == 0)
            {
                LB_MOV1.Text = "Movimiento = " + jugador1.Restar_Movimiento().ToString();
                TX_2.Text = "  X";
                TX_2.Enabled = false;
                jugador1.Casilla.Add(2);
            }
            else
            {
                LB_MOV2.Text = "Movimiento = " + jugador2.Restar_Movimiento().ToString();
                TX_2.Text = "  O";
                TX_2.Enabled = false;
                jugador2.Casilla.Add(11);
            }
            turnos++;
            Visible_Interfaz_Turnos();
            Combinaciones(jugador1, jugador2);
        }
        private void TX_3_Click(object sender, EventArgs e)
        {
            if (turnos % 2 == 0)
            {
                LB_MOV1.Text = "Movimiento = " + jugador1.Restar_Movimiento().ToString();
                TX_3.Text = "  X";
                TX_3.Enabled = false;
                jugador1.Casilla.Add(3);
            }
            else
            {
                LB_MOV2.Text = "Movimiento = " + jugador2.Restar_Movimiento().ToString();
                TX_3.Text = "  O";
                TX_3.Enabled = false;
                jugador2.Casilla.Add(12);
            }
            turnos++;
            Visible_Interfaz_Turnos();
            Combinaciones(jugador1, jugador2);
        }
        private void TX_4_Click(object sender, EventArgs e)
        {
            if (turnos % 2 == 0)
            {
                LB_MOV1.Text = "Movimiento = " + jugador1.Restar_Movimiento().ToString();
                TX_4.Text = "  X";
                TX_4.Enabled = false;
                jugador1.Casilla.Add(4);
            }
            else
            {
                LB_MOV2.Text = "Movimiento = " + jugador2.Restar_Movimiento().ToString();
                TX_4.Text = "  O";
                TX_4.Enabled = false;
                jugador2.Casilla.Add(13);
            }
            turnos++;
            Visible_Interfaz_Turnos();
            Combinaciones(jugador1, jugador2);
        }
        private void TX_5_Click(object sender, EventArgs e)
        {
            if (turnos % 2 == 0)
            {
                LB_MOV1.Text = "Movimiento = " + jugador1.Restar_Movimiento().ToString();
                TX_5.Text = "  X";
                TX_5.Enabled = false;
                jugador1.Casilla.Add(5);
            }
            else
            {
                LB_MOV2.Text = "Movimiento = " + jugador2.Restar_Movimiento().ToString();
                TX_5.Text = "  O";
                TX_5.Enabled = false;
                jugador2.Casilla.Add(14);
            }
            turnos++;
            Visible_Interfaz_Turnos();
            Combinaciones(jugador1, jugador2);
        }
        private void TX_6_TextChanged(object sender, EventArgs e)
        {

        }
        private void TX_6_Click(object sender, EventArgs e)
        {
            if (turnos % 2 == 0)
            {
                LB_MOV1.Text = "Movimiento = " + jugador1.Restar_Movimiento().ToString();
                TX_6.Text = "  X";
                TX_6.Enabled = false;
                jugador1.Casilla.Add(6);
            }
            else
            {
                LB_MOV2.Text = "Movimiento = " + jugador2.Restar_Movimiento().ToString();
                TX_6.Text = "  O";
                TX_6.Enabled = false;
                jugador2.Casilla.Add(15);
            }
            turnos++;
            Visible_Interfaz_Turnos();
            Combinaciones(jugador1, jugador2);
        }
        private void TX_7_Click(object sender, EventArgs e)
        {
            if (turnos % 2 == 0)
            {
                LB_MOV1.Text = "Movimiento = " + jugador1.Restar_Movimiento().ToString();
                TX_7.Text = "  X";
                TX_7.Enabled = false;
                jugador1.Casilla.Add(7);
            }
            else
            {
                LB_MOV2.Text = "Movimiento = " + jugador2.Restar_Movimiento().ToString();
                TX_7.Text = "  O";
                TX_7.Enabled = false;
                jugador2.Casilla.Add(16);
            }
            turnos++;
            Visible_Interfaz_Turnos();
            Combinaciones(jugador1, jugador2);
        }
        private void TX_8_Click(object sender, EventArgs e)
        {
            if (turnos % 2 == 0)
            {
                LB_MOV1.Text = "Movimiento = " + jugador1.Restar_Movimiento().ToString();
                TX_8.Text = "  X";
                TX_8.Enabled = false;
                jugador1.Casilla.Add(8);
            }
            else
            {
                LB_MOV2.Text = "Movimiento = " + jugador2.Restar_Movimiento().ToString();
                TX_8.Text = "  O";
                TX_8.Enabled = false;
                jugador2.Casilla.Add(17);
            }
            turnos++;
            Visible_Interfaz_Turnos();
            Combinaciones(jugador1, jugador2);
        }
        private void TX_9_Click(object sender, EventArgs e)
        {
            if (turnos % 2 == 0)
            {
                LB_MOV1.Text = "Movimiento = " + jugador1.Restar_Movimiento().ToString();
                TX_9.Text = "  X";
                TX_9.Enabled = false;
                jugador1.Casilla.Add(9);
            }
            else
            {
                LB_MOV2.Text = "Movimiento = " + jugador2.Restar_Movimiento().ToString();
                TX_9.Text = "  O";
                TX_9.Enabled = false;
                jugador2.Casilla.Add(18);
            }
            turnos++;
            Visible_Interfaz_Turnos();
            Combinaciones(jugador1, jugador2);
        }
    }
}
