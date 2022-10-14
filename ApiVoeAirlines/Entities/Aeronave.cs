using ApiVoeAirlines.Entities.Enums;

namespace ApiVoeAirlines.Entities
{
    public class Aeronave
    {
        public Aeronave(int id, string fabricante, string modelo, string codigo, TipoAeronave tipo)
        {
            this.Id = id;
            this.Fabricante = fabricante;
            this.Modelo = modelo;
            this.Codigo = codigo;
            this.Tipo = tipo;
        }

        public int Id { get; set; }
        public string? Fabricante { get; set; }
        public string? Modelo { get; set; }
        public string? Codigo { get; set; }
        public TipoAeronave Tipo { get; set; }
    }
}