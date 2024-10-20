using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesVehiculos
{
    class Motocicleta : Vehiculo
    {
        public int CantidadP {  get; set; }

        public override void Moverse()
        {
            MessageBox.Show($"La motocicleta está lista y cuenta con {CantidadP} pasajeros.");
        }

        public override void Detenerse()
        {
            MessageBox.Show($"La motocicleta se detuvo");
        }
    }
}
