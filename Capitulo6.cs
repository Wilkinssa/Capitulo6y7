using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Unidad5
{
    public partial class Capitulo6 : Form
    {
        int cantsalones;
        int estudiantes;
        int i = 0;
        int j = 0;
        double[][] calif;
        double prom;
        int[] cant;
        int repeticion;
        int y = 1, o = 1;
        int t = 0;
        int d = 0;
        double prom1;
        double mayor, menor;
        double mayorgeneral, menorgeneral;
        public Capitulo6()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            cantsalones = int.Parse(textcantsalones.Text);
            textcantsalones.ReadOnly = true;
            Aceptar.Visible = false;
            labcantalumnos.Visible = true;
            textcantalumnos.Visible = true;
            Aceptar1.Visible = true;
            calif = new double[cantsalones][];
            cant = new int[cantsalones];
        }


        private void Aceptar1_Click(object sender, EventArgs e)
        {
            estudiantes = int.Parse(textcantalumnos.Text);
            calif[i] = new double[estudiantes];
            cant[i] = estudiantes;
            string r = "Cantidad de alumnos del salon " + (i + 2);
            labcantalumnos.Text = r;
            i++;
            
            textcantalumnos.Clear();
            if(i == cantsalones)
            {
                textcantalumnos.ReadOnly = true;
                Aceptar1.Visible = false;
                labcalifalumnos.Visible = true;
                textcalifalumnos.Visible = true;
                Aceptar2.Visible = true;
                repeticion = cant[0];
                string rt = "Cantidad de alumnos del salon " + (i);
                labcantalumnos.Text = rt;
            }
        }

        int h = 1;

        private void Continuar_Click(object sender, EventArgs e)
        {
            listprom.Items.Clear();
            for (int i = 0; i < cantsalones; i++)
            {
                listprom.Items.Add("Salon " + (i + 1));
                for (int j = 0; j < cant[i]; j++)
                {
                    listprom.Items.Add("Alumno " + (j + 1) + ": " + calif[i][j]);
                }
            }
            labprom.Visible = false;
            textcantprom.Visible = false;
            labpromgeneral.Visible = true;
            textpromgeneral.Visible = true;
            labcalifmenor.Text = "Calificacion menor general";
            labcalifmayor.Text = "Calificacion mayor general";
            double prom2 = prom1 / cantsalones;
            textpromgeneral.Text = prom2.ToString("N2");
            textcalifmenor.Text = menorgeneral.ToString();
            textcalifmayor.Text = mayorgeneral.ToString();
            Salir.Visible = true;
            Continuar.Visible = false;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void salonsigte_Click(object sender, EventArgs e)
        {
            listprom.Items.Clear();
            int cont = 0;
            int z = 1;
            double total1 = 0;
            for(int i = 0; i < cant[h]; i++)
            {
                total1 += calif[h][cont];
                cont++;
            }
            labprom.Text = "Promedio de calificaciones del salon: " + (h + 1);
            prom = Convert.ToDouble(total1 / cont);
            textcantprom.Text = prom.ToString();
            prom1 += prom;
            for (int v = 0; v < cant[h]; v++)
            {
                listprom.Items.Add("Calificacion alumno " + z + " es:  " + calif[h][v]);
                if(v == 0){
                    mayor = calif[h][v];
                    menor = calif[h][v];
                }
                else
                {
                    if(calif[h][v] > mayor)
                    {
                        mayor = calif[h][v];
                    }
                    if(calif[h][v] < menor)
                    {
                        menor = calif[h][v];
                    }
                }
               
                if(calif[h][v] > mayorgeneral)
                {
                    mayorgeneral = calif[h][v];
                }
                if(calif[h][v] < menorgeneral)
                {
                    menorgeneral = calif[h][v];
                }
                z++;
            }
            textcalifmenor.Text = menor.ToString();
            textcalifmayor.Text = mayor.ToString();
            h++;
            if (h == cantsalones)
            {
                Continuar.Visible = true;
                salonsigte.Visible = false;
            }
        }

        private void Aceptar2_Click(object sender, EventArgs e)
        {
            double calificaciones = Convert.ToDouble(textcalifalumnos.Text);
            textcalifalumnos.Clear();
            calif[j][t] = calificaciones;

            if (t == repeticion-1)
            {
                y = 1;
                o++;
                d++;
                t = 0;
                j++;
                if (j == cantsalones)
                {
                    
                }
                else
                {
                    repeticion = cant[d];
                }
            }else
            { 
                y++;   
                t++;
            }

            if (j == cantsalones)
            {
                textcalifalumnos.ReadOnly = true;
                Aceptar2.Visible = false;
                labcantalumnos.Visible = false;
                textcantalumnos.Visible = false;
                labcalifalumnos.Visible = false;
                textcalifalumnos.Visible = false;
                labprom.Visible = true;
                textcantprom.Visible = true;
                listprom.Visible = true;
                labcalifmenor.Visible = true;
                labcalifmayor.Visible = true;
                textcalifmenor.Visible = true;
                textcalifmayor.Visible = true;
                salonsigte.Visible = true;
                int s = 0;
                double total = 0;
                int g = 0;
                for (int m = 0; m < cant[0]; m++)
                {
                    total += calif[s][m];
                    g++;
                }
                prom = Convert.ToDouble(total / g);

                int z = 1, c = 0;
                textcantprom.Text = prom.ToString();
                prom1 += prom;
                for (int v = 0; v < cant[0]; v++)
                {
                    listprom.Items.Add("Calificacion alumno " + z + " es " + calif[c][v]);
                    if(v == 0)
                    {
                        mayor = calif[c][v];
                        menor = calif[c][v];
                        mayorgeneral = calif[c][v];
                        menorgeneral = calif[c][v];
                    }
                    else
                    {
                        if(calif[c][v] > mayor)
                        {
                            mayor = calif[c][v];
                        }
                        if(calif[c][v] < menor)
                        {
                            menor = calif[c][v];
                        }
                        if(calif[c][v] > mayorgeneral)
                        {
                            mayorgeneral = calif[c][v];
                        }
                        if(calif[c][v] < menorgeneral)
                        {
                            menorgeneral = calif[c][v];
                        }
                    }
                    z++;
                }
                textcalifmenor.Text = menor.ToString();
                textcalifmayor.Text = mayor.ToString();
            }
            if(j == cantsalones)
            {
                o--;
                y = repeticion;
            }
            labcalifalumnos.Text = "Calificacion del alumno " + y + " del salon " + o;
        }
    }
}