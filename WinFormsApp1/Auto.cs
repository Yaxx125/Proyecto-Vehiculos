using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesVehiculos
{
    sealed  class Auto : Vehiculo
    {
        public int CantPasajeros {  get; set; }

        public override void Moverse()
        {
            MessageBox.Show($"El auto con {CantPasajeros} pasajeros, esta listo");   
        }

        public override void Detenerse()
        {
            MessageBox.Show($"El auto se detuvo");   
        }

    }
}
