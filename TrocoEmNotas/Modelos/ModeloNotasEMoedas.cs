
namespace TrocoEmNotas.Modelos
{
    public static class ModeloNotasEMoedas
    {
        public static IList<decimal> Notas
        {
            get
            {
                return new List<decimal>()
                {
                    200,
                    100,
                    50,
                    25,
                    10,
                    5,
                    2,
                    1,
                    0.50M,
                    0.25M,
                    0.10M,
                    0.05M,
                    0.01M
                };
            }
        }

    }
}
