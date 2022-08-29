using System.ComponentModel.DataAnnotations;

namespace Log.Unimed.Controllers
{
    public class LogDTO
    {
        public int Id { get; set; } 
        public DataType DataModificacao { get; set; }
        public int Operador { get; set; } 
        public int TipoDeLog { get; set; }
        public int Contratante { get; set; } 
        public int Fornecedor { get; set; } 
        public string Log { get; set; } 
    }
}