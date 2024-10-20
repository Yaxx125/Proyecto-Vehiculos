using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesVehiculos
{
    abstract class Vehiculo: ITransporte
    {
        public string Marca { get; set; }
        public string Modelo {  get; set; }

        public virtual void Iniciar()
        {
            MessageBox.Show($"El vehiculo {Marca} {Modelo} está listo. ");
        }

        public abstract void Moverse();
        

        public virtual void Detenerse()
        {
            MessageBox.Show($"El vehiculo {Marca} {Modelo} se detuvo. ");

        }
    }
}
