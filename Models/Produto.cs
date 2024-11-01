using System.ComponentModel;

namespace Pim8.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [DisplayName("Nome do vídeo")]
        public string Nome { get; set; }
        [DisplayName("Tempo de vídeo")]
        public decimal Preco { get; set; }
    }
}
