using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrocoEmNotas.Modelos;

namespace TrocoEmNotas.Servicos
{
    public class ServicoCalcularTroco
    {
        public List<Troco> Calcular(decimal valorPago, decimal valorTotal)
        {
            List<Troco> listaRetorno = new();
            var total = valorPago;
            var pago = valorTotal;
            decimal troco = pago - total;

            while (troco > 0)
            {
                foreach (decimal dinheiro in ModeloNotasEMoedas.Notas)
                {
                    int count = 0;

                    while (dinheiro <= troco)
                    {
                        troco -= dinheiro;
                        count++;
                    }

                    if (count >= 1)
                    {
                        listaRetorno.Add(new Troco
                        {
                            Quantidade = count,
                            Valor = dinheiro
                        });
                    }
                }
            }
            return listaRetorno;

        }

    }

}
