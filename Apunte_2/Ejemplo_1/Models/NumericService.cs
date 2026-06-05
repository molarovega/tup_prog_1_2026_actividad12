using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Ejemplo_1.Models
{
    internal class NumericService
    {
        #region atributos
        int[] LUs;
        string[] Nombres;
        double[] Notas;
        int Contador;
        #endregion

        public NumericService() //constructor
        {
            LUs = new int[0];
            Nombres = new string[0];
            Notas = new double[0];
            Contador = 0;
        }

        #region metodos
        public void RegistrarAlumno(int lu, string nombre, double nota) 
        {
            LUs[Contador] = lu;
            Nombres[Contador]=nombre;
            Notas[Contador]=nota;
            Contador++;
        }
        public int VerContador() 
        {
            return Contador;
        }
        public string VerAlumno(int idx) 
        {
            return Nombres[idx];
        }
        public int BuscarPorLUSecuencial(int lu) 
        {
            int idx = -1;
            int n = 0;

            while (n<Contador && idx == -1) 
            {
                if (LUs[n] == lu) 
                {
                    idx = n;
                }
            }

            return idx;
        }
        public int BuscarPorLUBinario(int lu)
        {
            int pivot = -1;
            int inf = 0;
            int sup = Contador - 1;

            while (inf<=sup && pivot==-1) 
            {
                int centro = (inf + sup) / 2;

                if (LUs[centro] == lu)
                {
                    pivot = centro;
                }
                else if (lu < LUs[centro])
                {
                    sup = centro - 1;
                }
                else 
                {
                    inf = centro + 1;
                }
            }

            return pivot;
        }
        public void OrdenarPorLUBurbuja() 
        {

        }
        public void OrdenarPorQuickSort()
        {

        }

        #endregion



    }
}
