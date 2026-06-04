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
            return 0;
        }
        public string VerAlumno(int idx) 
        {
            return "";
        }
        public int BuscarPorLUSecuencial(int lu) 
        {
            return 0;
        }
        public int BuscarPorLUBinario(int lu)
        {
            return 0;
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
