using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMBUSTIBLE
{
    public partial class Automovil
    {
        public string Marca { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public double CapacidadTanque { get; set; }
        public double NivelCombustible { get; set; } 
        public double Rendimiento { get; set; } 

        public Automovil(string marca, string placa, string modelo, string color, double capacidadTanque, double Rendimiento)
        {
            this.Marca = marca;
            this.Placa = placa;
            this.Modelo = modelo;
            this.Color = color;
            this.CapacidadTanque = CapacidadTanque;
            this.NivelCombustible = 0; 
            this.Rendimiento = Rendimiento;
        }

        public void Drive(int distancia)
        {
            double CombustibleNecesario = distancia / Rendimiento; 
            if (CombustibleNecesario <= NivelCombustible)
            {
                NivelCombustible -= CombustibleNecesario;
                Console.WriteLine("puede conducir");
            }
            else
            {
                Console.WriteLine("combustible insuficiente");
            }
        }

        public bool PuedeConducir(int distancia)
        {
            double combustibleNecesario = distancia / Rendimiento;
            return combustibleNecesario <= NivelCombustible;
        }
}

}