﻿using ProyectoII_Tiquete_bus.Datos;
using ProyectoII_Tiquete_bus.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoII_Tiquete_bus
{
    public partial class VentaInternacionalRegreso : Form
    {
        
        DatosTiquetes data = new DatosTiquetes();
        List<Button> res = new List<Button>();
        Button[] LISTA = new Button[56];
        bool val;
        int asientosdisponibles, cantidadasientos, contador;
        public string dia2, hora, color, destino, salida, cantidadeq, numpasaporte, numautobus = "";


        public VentaInternacionalRegreso(String salida)
        {
            InitializeComponent();
            lista();
            bloqueados();
            cboSalida.Text = salida;
            btnComprar.Enabled = false;
            cboDestino.Enabled = false;
            txtidpasaporte.Enabled = false;
            dtpfenchavencimiento.Enabled = false;
            dateTimePicker1.MinDate = DateTime.Now.AddDays(8);

        }

        private void btnComprar_Click_1(object sender, EventArgs e)
        {

            if (numCantidadPas != null)
            {
                cantidadasientos = int.Parse(numCantidadPas.Text);

                if (cantidadasientos != contador)
                {
                    hablitados();
                }
                else
                {
                    bloqueados();
                }

            }
            else
            {
                MessageBox.Show("Porfavor seleccione la cantidad de asientos a comprar");
            }

        }

        //Todos los botones de asientos estan redirigidos aca
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            if ((cantidadasientos = int.Parse(numCantidadPas.Text)) != contador)
            {
                MessageBox.Show("contador ;" + contador.ToString());
                Button t = (Button)sender;
                if (t.BackColor == Color.Red)
                {
                    MessageBox.Show("Este asiento ya se encuentra reservado");
                }
                else
                {
                    string asiento = Regex.Replace(t.Name, @"[^\d]", "");
                    t.BackColor = Color.Red;
                    label1.Text = asiento;

                    dia2 = dateTimePicker1.Text;
                    hora = cboHoraSalida.GetItemText(cboHoraSalida.SelectedItem);
                    salida = cboSalida.GetItemText(cboSalida.SelectedItem);
                    destino = cboDestino.GetItemText(cboDestino.SelectedItem);
                    cantidadeq = numCantidadMaletas.Value.ToString();
                    numpasaporte = txtidpasaporte.Text;
                    numautobus = txtidbus.Text;

                    MessageBox.Show(hora);
                    MessageBox.Show(asiento);
                    MessageBox.Show(dia2);



                    Tiquete_Internacional_Regreso venta = new Tiquete_Internacional_Regreso
                    {
                        Numpasaporte = numpasaporte,
                        Fecha = dia2,
                        Hora = hora,
                        Numautobus = numautobus,
                        Asiento = asiento,
                        Salida = salida,
                        Destino = destino,
                        Equipaje = cantidadeq

                    };

                    DatosTiquetes.GuardarDatosInterReg(venta);

                    contador++;

                    if ((cantidadasientos = int.Parse(numCantidadPas.Text)) == contador)
                    {
                        bloqueados();
                        numCantidadPas.Value = 0;
                        btnComprar.Enabled = false;
                        numCantidadPas.Enabled = false;
                        cboSalida.Enabled = false;
                        cboHoraSalida.SelectedIndex = -1;
                        cboSalida.SelectedIndex = -1;
                    }

                }
                MessageBox.Show(dia2);
                MessageBox.Show(hora);
            }

        }



        private void btnDisponibilidad_Click(object sender, EventArgs e)
        {

            limpiar();
            contador = 0;

            if (cboHoraSalida.SelectedItem == null || cboHoraSalida.SelectedItem == "" || numCantidadPas.Text == null)
            {
                MessageBox.Show("Favor seleccione bien los valores");
            }
            else
            {


                dia2 = dateTimePicker1.Text;
                hora = cboHoraSalida.GetItemText(cboHoraSalida.SelectedItem);
                salida = cboSalida.GetItemText(cboSalida.SelectedItem);

                bool validado = validacion(hora, dia2, salida);

                MessageBox.Show(validado.ToString());

                if (validado == true)
                {
                    List<AsientoTemp> lista2 = DatosTiquetes.Consultarfecha3(dia2, hora);

                    if (lista2.Count >= 1)
                    {
                        for (int i = 0; i < lista2.Count; i++)
                        {
                            MessageBox.Show("lista monstrada en boton verif" + lista2[i].Asiento);
                            int asd = int.Parse(lista2[i].Asiento);
                            LISTA[asd - 1].BackColor = Color.Red;
                            asientosdisponibles++;

                        }

                        asientosdisponibles = 56 - asientosdisponibles;
                        MessageBox.Show("astientos disponibles " + asientosdisponibles.ToString());

                        if (asientosdisponibles < 0)
                        {
                            MessageBox.Show("No hay espacios disponibles en este horario");
                        }
                        else
                        {
                            numCantidadPas.Enabled = true;
                            numCantidadPas.Maximum = asientosdisponibles;
                            cboSalida.Enabled = true;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Ahora si papiyo");
                    btnComprar.Enabled = true;
                    numCantidadPas.Enabled = true;
                    cboSalida.Enabled = true;
                    cboDestino.Enabled = true;
                    numCantidadPas.Maximum = 56;
                }



            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



       

        public void lista()
        {


            LISTA[0] = btnPrincipal;
            LISTA[1] = button2;
            LISTA[2] = button3;
            LISTA[3] = button4;
            LISTA[4] = button5;
            LISTA[5] = button6;
            LISTA[6] = button7;
            LISTA[7] = button8;
            LISTA[8] = button9;
            LISTA[9] = button10;
            LISTA[10] = button11;
            LISTA[11] = button12;
            LISTA[12] = button13;
            LISTA[13] = button14;
            LISTA[14] = button15;
            LISTA[15] = button16;
            LISTA[16] = button17;
            LISTA[17] = button18;
            LISTA[18] = button19;
            LISTA[19] = button20;
            LISTA[20] = button21;
            LISTA[21] = button22;
            LISTA[22] = button23;
            LISTA[23] = button24;
            LISTA[24] = button25;
            LISTA[25] = button26;
            LISTA[26] = button27;
            LISTA[27] = button28;
            LISTA[28] = button29;
            LISTA[29] = button30;
            LISTA[30] = button31;
            LISTA[31] = button32;
            LISTA[32] = button33;
            LISTA[33] = button34;
            LISTA[34] = button35;
            LISTA[35] = button36;
            LISTA[36] = button37;
            LISTA[37] = button38;
            LISTA[38] = button39;
            LISTA[39] = button40;
            LISTA[40] = button41;
            LISTA[41] = button42;
            LISTA[42] = button43;
            LISTA[43] = button44;
            LISTA[44] = button45;
            LISTA[45] = button46;
            LISTA[46] = button47;
            LISTA[47] = button48;
            LISTA[48] = button49;
            LISTA[49] = button50;
            LISTA[50] = button51;
            LISTA[51] = button52;
            LISTA[52] = button53;
            LISTA[53] = button54;
            LISTA[54] = button55;
            LISTA[55] = button56;

            color = btnPrincipal.BackColor.ToString();
        }


        private void limpiar()
        {
            for (int i = 0; i < 56; i++)
            {
                LISTA[i].BackColor = Color.FromName(color);
            }
        }

        private void bloqueados()
        {
            for (int i = 0; i < 56; i++)
            {
                LISTA[i].Enabled = false;
            }
        }

        private void hablitados()
        {
            for (int i = 0; i < 56; i++)
            {
                LISTA[i].Enabled = true;
            }
        }

        public bool validacion(string a1, string a2, string a3)
        {

            MessageBox.Show("Esto es la hora " + a1);
            MessageBox.Show("Esto es la fecha " + a2);
            MessageBox.Show("Esto es la salida " + a3);
            List<Tiquete_Internacional_Regreso> lista1 = DatosTiquetes.todoregreso();

            for (int i = 0; i < lista1.Count; i++)
            {
                if (lista1[i].Hora == a1 && lista1[i].Fecha == a2 && lista1[i].Salida == a3)
                {
                    MessageBox.Show("Esto es la hora " + lista1[i].Hora);
                    MessageBox.Show("Esto es la fecha " + lista1[i].Fecha);
                    MessageBox.Show("Esto es la salida " + lista1[i].Salida);
                    val = true;
                    break;
                }
                else
                {
                    val = false;

                }

            }
            MessageBox.Show("To string" + val.ToString());
            return val;
        }

        private void dtpfenchavencimiento_CloseUp(object sender, EventArgs e)
        {

            DateTime fechahora = DateTime.Now;
            DateTime fecha = dtpfenchavencimiento.Value; ;
            DateTime fecha6mes = fecha.AddMonths(6);

            int result = DateTime.Compare(fecha, fecha6mes);

            if (result != -1)
            {
                MessageBox.Show("Imposible comprar ticket, pasaporte pronto a vencer");
            }
            else
            {
                btnComprar.Enabled = true;
                MessageBox.Show("Seleccione los asientos a comprar");
            }
        }


         
    }
}
