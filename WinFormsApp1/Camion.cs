using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesVehiculos
{
    class Camion : Vehiculo
    {
        public int CapCarga {  get; set; }

        public override void Moverse()
        {
            MessageBox.Show($"El camion cuenta con {CapCarga} kilogramos, está listo para arrancar");
        }

        public override void Detenerse()
        {
            MessageBox.Show($"El camion se detuvo.");
        }
    }
}
