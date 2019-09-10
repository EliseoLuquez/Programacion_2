using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    public class Program
    {
        public static bool AnioBisiesto(int anioB)
        {
            int resto;
            int restoDos;
            bool booleano = false;

            resto = anioB % 4;
            restoDos = anioB % 400;
            if (resto == 0)
            {
                if (anioB.ToString().ElementAt(2) == '0' && anioB.ToString().ElementAt(3) == '0' && restoDos != 0)
                {
                    booleano = false;
                }
                else
                {
                    booleano = true;
                }
            }
            return booleano;
        }

        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07";

            int dia;
            int mes;
            int anio;
            int diaAux;
            int mesAux;
            int anioAux;
            string dato;
            DateTime fechaNacimiento;
            DateTime fechaActual;
            int diasVividos = 0;
            bool booleanoDia;
            bool booleanoMes;
            bool booleanoAnio;
            bool primerMes = true;
            bool ultimoMes = false;

            do
            {
                Console.WriteLine("Ingrese fecha de nacimiento");
                Console.WriteLine("Ingrese Dia: ");
                dato = Console.ReadLine();
                booleanoDia = Int32.TryParse(dato, out dia);
                Console.WriteLine("Ingrese Mes: ");
                dato = Console.ReadLine();
                booleanoMes = Int32.TryParse(dato, out mes);
                Console.WriteLine("Ingrese Año: ");
                dato = Console.ReadLine();
                booleanoAnio = Int32.TryParse(dato, out anio);
                fechaNacimiento = new DateTime(anio, mes, dia);

            } while (!booleanoDia && !booleanoMes && !booleanoAnio);

            fechaActual = DateTime.Now;
            Console.WriteLine(fechaNacimiento);
            Console.WriteLine(fechaActual);

            diaAux = fechaActual.Day;
            mesAux = fechaActual.Month;
            anioAux = fechaActual.Year;

            for (int i = anio; i <= anioAux; i++)
            {
                if (ultimoMes)
                {
                    break;
                }
                for (int j = 1; j <= 12; j++)
                {
                    if (ultimoMes)
                    {
                        break;
                    }
                    if (primerMes)
                    {
                        j = mes;
                    }
                    if (anioAux == i && mesAux == j)
                    {
                        ultimoMes = true;                        
                    }

                    switch (j)
                    {
                        case 1:
                            if (primerMes)
                            {
                                primerMes = false;
                                diasVividos = 31 - dia;
                            }
                            else
                            {
                                if (ultimoMes)
                                {
                                    diasVividos += 31 - (31 - diaAux);
                                }
                                else
                                {
                                    diasVividos += 31;
                                }
                            }
                            break;
                        case 2:
                            if (AnioBisiesto(i))
                            {
                                if (primerMes)
                                {
                                    primerMes = false;
                                    diasVividos = 29 - dia;
                                }
                                else
                                {
                                    if (ultimoMes)
                                    {
                                        diasVividos += 29 - (29 - diaAux);
                                    }
                                    else
                                    {
                                        diasVividos += 29;
                                    }
                                }
                            }
                            else
                            {
                                if (primerMes)
                                {
                                    primerMes = false;
                                    diasVividos = 28 - dia;
                                }
                                else
                                {
                                    if (ultimoMes)
                                    {
                                        diasVividos += 28 - (28 - diaAux);
                                    }
                                    else
                                    {
                                        diasVividos += 28;
                                    }
                                }
                            }
                            break;
                        case 3:
                            if (primerMes)
                            {
                                primerMes = false;
                                diasVividos = 31 - dia;
                            }
                            else
                            {
                                if (ultimoMes)
                                {
                                    diasVividos += 31 - (31 - diaAux);
                                }
                                else
                                {
                                    diasVividos += 31;
                                }
                            }
                            break;
                        case 4:
                            if (primerMes)
                            {
                                primerMes = false;
                                diasVividos = 30 - dia;
                            }
                            else
                            {
                                if (ultimoMes)
                                {
                                    diasVividos += 30 - (30 - diaAux);
                                }
                                else
                                {
                                    diasVividos += 30;
                                }
                            }
                            break;
                        case 5:
                            if (primerMes)
                            {
                                primerMes = false;
                                diasVividos = 31 - dia;
                            }
                            else
                            {
                                if (ultimoMes)
                                {
                                    diasVividos += 31 - (31 - diaAux);
                                }
                                else
                                {
                                    diasVividos += 31;
                                }
                            }
                            break;
                        case 6:
                            if (primerMes)
                            {
                                primerMes = false;
                                diasVividos = 30 - dia;
                            }
                            else
                            {
                                if (ultimoMes)
                                {
                                    diasVividos += 30 - (30 - diaAux);
                                }
                                else
                                {
                                    diasVividos += 30;
                                }
                            }
                            break;
                        case 7:
                            if (primerMes)
                            {
                                primerMes = false;
                                diasVividos = 31 - dia;
                            }
                            else
                            {
                                if (ultimoMes)
                                {
                                    diasVividos += 31 - (31 - diaAux);
                                }
                                else
                                {
                                    diasVividos += 31;
                                }
                            }
                            break;
                        case 8:
                            if (primerMes)
                            {
                                primerMes = false;
                                diasVividos = 31 - dia;
                            }
                            else
                            {
                                if (ultimoMes)
                                {
                                    diasVividos += 31 - (31 - diaAux);
                                }
                                else
                                {
                                    diasVividos += 31;
                                }
                            }
                            break;
                        case 9:
                            if (primerMes)
                            {
                                primerMes = false;
                                diasVividos = 30 - dia;
                            }
                            else
                            {

                                if (ultimoMes)
                                {
                                    diasVividos += 30 - (30 - diaAux);
                                }
                                else
                                {
                                    diasVividos += 30;
                                }

                            }
                            break;
                        case 10:
                            if (primerMes)
                            {
                                primerMes = false;
                                diasVividos = 31 - dia;
                            }
                            else
                            {
                                if (ultimoMes)
                                {
                                    diasVividos += 31 - (31 - diaAux);
                                }
                                else
                                {
                                    diasVividos += 31;
                                }
                            }
                            break;
                        case 11:
                            if (primerMes)
                            {
                                primerMes = false;
                                diasVividos = 30 - dia;
                            }
                            else
                            {
                                if (ultimoMes)
                                {
                                    diasVividos += 30 - (30 - diaAux);
                                }
                                else
                                {
                                    diasVividos += 30;
                                }
                            }
                            break;
                        case 12:
                            if (primerMes)
                            {
                                primerMes = false;
                                diasVividos = 31 - dia;
                            }
                            else
                            {
                                if (ultimoMes)
                                {
                                    diasVividos += 31 - (31 - diaAux);
                                }
                                else
                                {
                                    diasVividos += 31;
                                }
                            }
                            break;
                    }

                }
            }

            Console.WriteLine("Dias vividos totales {0}", diasVividos);

            Console.ReadKey();
        }
    }
}
