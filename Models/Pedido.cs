using System.ComponentModel.DataAnnotations;

namespace Exercicios.Models
{
    public class Pedido
    {
        [Display(Name = "Código do Produto")]
        [Required(ErrorMessage = "Informe o Código do Produto")]
        [RegularExpression(@"[0-9]*$", ErrorMessage = "Informe um valor válido!")]
        public int Codigo { get; set; }

        [Display(Name = "Quantidade do Produto")]
        [Required(ErrorMessage = "Informe a Quantidade do Produto")]
        [RegularExpression(@"[0-9]*$", ErrorMessage = "Informe um valor válido!")]
        public int Qtde { get; set; }

        public double ValorTotal
        {
            get
            {
                double valor = 0;
                switch (Codigo)
                {
                    case 100 : // 100 é o codigo do
                        valor = Qtde * 5.5f; // f de float
                        break;
                    case 101 :
                        valor = Qtde * 6.5f;
                        break;
                    case 102 :
                        valor = Qtde * 7.5f;
                        break;
                    case 103 :
                        valor = Qtde * 6f;
                        break;
                    case 104 :
                        valor = Qtde * 6.3f;
                        break;
                    case 105 :
                        valor = Qtde * 5f;
                        break;
                }
                return valor;
            }
        }
    }
}

