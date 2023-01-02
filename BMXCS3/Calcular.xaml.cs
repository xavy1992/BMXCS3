using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMXCS3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calcular : ContentPage
    {
        public Calcular()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)

        {
            double Dato1 = Convert.ToDouble(txtDatoUno.Text);
            double Dato2 = Convert.ToDouble(txtDatoDos.Text);


            double Operacion = (Dato1 * (0.3)) + (Dato2 * (0.2));

            double Dato3 = Convert.ToDouble(txtDatoUnoo.Text);
            double Dato4 = Convert.ToDouble(txtDatoDoss.Text);
            double Operacion2 = (Dato3 * (0.3)) + (Dato4 * (0.2));

            double OperacionFin = (Operacion + Operacion2);

            txtResultado.Text = Operacion.ToString();
            txtResultadoo.Text = Operacion2.ToString();
            txtResultadoFinal.Text = OperacionFin.ToString();

            if (OperacionFin >= 7 && OperacionFin <= 10)
            { // Si la condicion se cumple 

                // mostramos este mensaje
                txtVerificar.Text = ("Aprobado");
                DisplayAlert("Felicitaciones", " Su nota final es:" + " " + OperacionFin, "cerrar");

            }

            if (OperacionFin < 6.9 && OperacionFin >= 5)
            { // Si no se cuemple la anterior...  

                // Mostramos otro mensaje
                txtVerificar.Text = ("Complementario");
                DisplayAlert("Examen Complementario", " Su nota final es:" + " " + OperacionFin, "cerrar");
            }

            if (OperacionFin <= 4.9 && OperacionFin >= 0.1)
            { // Si no se cuemple la anterior...  

                // Mostramos otro mensaje
                txtVerificar.Text = ("Reprobado");
                 DisplayAlert("Reprobado", "Su nota final es:" + " " + OperacionFin, "cerrar");
            }
        }
                private void txtDatoUno_TextChanged(object sender, TextChangedEventArgs e)
                {

                    try
                    {
                        if (Convert.ToDouble(txtDatoUno.Text) > 10)
                        {
                            DisplayAlert("Error", "ingrese un numero menor o igual a 10", "cerrar");
                        }
                        if (Convert.ToDouble(txtDatoUno.Text) < 0.1)
                        {
                            DisplayAlert("Error", "ingrese un numero mayor o igual a 0.1", "cerrar");
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }

                private void txtDatoDos_TextChanged(object sender, TextChangedEventArgs e)
                {
                    try
                    {
                        if (Convert.ToDouble(txtDatoDos.Text) > 10)
                        {
                            DisplayAlert("Error", "ingrese un numero menor o igual a 10", "cerrar");
                        }
                        if (Convert.ToDouble(txtDatoDos.Text) < 0.1)
                        {
                            DisplayAlert("Error", "ingrese un numero mayor o igual a 0.1", "cerrar");
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }


                }

                private void txtDatoUnoo_TextChanged(object sender, TextChangedEventArgs e)
                {
                    try
                    {
                        if (Convert.ToDouble(txtDatoUnoo.Text) > 10)
                        {
                            DisplayAlert("Error", "ingrese un numero menor o iguala 10", "cerrar");
                        }
                        if (Convert.ToDouble(txtDatoUnoo.Text) < 0.1)
                        {
                            DisplayAlert("Error", "ingrese un numero mayor o iguala 0.1", "cerrar");
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }

                private void txtDatoDoss_TextChanged(object sender, TextChangedEventArgs e)
                {
                    try
                    {
                        if (Convert.ToDouble(txtDatoDoss.Text) > 10)
                        {
                            DisplayAlert("Error", "ingrese un numero menor o iguala 10", "cerrar");
                        }
                        if (Convert.ToDouble(txtDatoDoss.Text) > 10)
                        {
                            DisplayAlert("Error", "ingrese un numero mayor o iguala 0.1", "cerrar");
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }


                }
            }
        }

    