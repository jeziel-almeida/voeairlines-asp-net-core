using ApiVoeAirlines.Entities.Enums;

namespace ApiVoeAirlines.Entities
{
    public class Piloto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Matricula { get; set; }
        public TipoLicensa Licensa { get; set; }
    }
}