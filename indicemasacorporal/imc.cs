using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indicemasacorporal
{
    public class Imc
    {
        private double peso;
        private double estatura;

        public void setPeso(double total)
        {
            this.peso=total;
        }

        public double getPeso()
        {
            return this.peso;
        }

        public void setEstatura(double total)
        {
            this.estatura = total;
        }

        public double getEstatura()
        {
            return this.estatura;
        }

        public double calcularImc()
        {
            return (this.getPeso() / (this.getEstatura() * this.getEstatura()));
        }


    }
}
