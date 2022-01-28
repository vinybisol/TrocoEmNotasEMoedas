using System.Text;

namespace TrocoEmNotas
{
    public partial class FormCalcular : Form
    {
        public FormCalcular()
        {
            InitializeComponent();
        }

        #region Eventos
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos())
                return;
            var total = Convert.ToDecimal(textBoxTotal.Text);
            var pago = Convert.ToDecimal(textBoxPago.Text);

            var listaTroco = new Servicos.ServicoCalcularTroco().Calcular(total, pago);
            if (listaTroco.Count > 0)
            {
                richTextTroco.Text = RetornaListaDeTroco(listaTroco);
            }

        }
        private void textBoxTotal_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidaValor(sender);
        }
        private void textBoxPago_Validated(object sender, EventArgs e)
        {
            ValidaValor(sender);
        }

        private void textBoxTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            MascaraValor(sender, e);
        }

        private void textBoxPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            MascaraValor(sender, e);
        }
        #endregion

        #region Metodos Privados
        private string RetornaListaDeTroco(List<Modelos.Troco> trocos)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Modelos.Troco troco in trocos)
            {
                var quantidade = troco.Quantidade;
                var valor = troco.Valor;

                string plural = quantidade > 1 ? "s" : "";
                string substantivo = valor > 1 ? $"nota{plural}" : $"moeda{plural}";
                stringBuilder.AppendLine($"{troco.Quantidade} {substantivo} de {valor:0.00}");
            }
            return stringBuilder.ToString();
        }

        private bool ValidaCampos()
        {
            if (string.IsNullOrEmpty(textBoxTotal.Text))
            {
                richTextTroco.Text = "O campo Valor Total não pode ficar em branco";
                return false;
            }
            if (string.IsNullOrEmpty(textBoxPago.Text))
            {
                richTextTroco.Text = "O campo Valor Pago não pode ficar em branco";
                return false;
            }

            decimal total = Convert.ToDecimal(textBoxTotal.Text);
            decimal pago = Convert.ToDecimal(textBoxPago.Text);
            if (pago <= total)
            {
                richTextTroco.Text = "O Valor Pago deve ser maior que o Valor Total";
            }
            return true;

        }

        private void ValidaValor(object sender)
        {
            if (!((TextBox)sender).Text.Equals(""))
            {
                try
                {
                    string texto = ((TextBox)sender).Text;
                    var valor = decimal.Parse(texto);
                    ((TextBox)sender).Text = valor.ToString("###,###,##0.00");
                }
                catch
                {
                    ((TextBox)sender).Text = "0,00";
                }
            }
        }

        private void MascaraValor(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }


        #endregion

    }
}