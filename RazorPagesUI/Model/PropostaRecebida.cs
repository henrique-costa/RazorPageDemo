using System.ComponentModel.DataAnnotations;

namespace RazorPagesUI.Model
{
    public class PropostaRecebida
    {
        [Required]
        public string JsonPropost { get; set; }
        public int versaoPropost { get; set; }
        public string tituloPropost { get; set; }
    }
}
