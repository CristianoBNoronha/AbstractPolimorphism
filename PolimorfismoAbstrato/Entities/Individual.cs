
namespace PolimorfismoAbstrato.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpeditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpeditures) : base(name, anualIncome)
        {
            HealthExpeditures = healthExpeditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {
                return AnualIncome * 0.15 - HealthExpeditures / 2;
            }

            else
            {
                return AnualIncome * 0.25 - HealthExpeditures / 2;
            }
        }
    }
}
