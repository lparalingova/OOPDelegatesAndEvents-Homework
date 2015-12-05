namespace _02.InterestCalculator
{
    public delegate double CalculateInterest(double sum, double interest, int years);

    public class InterestCalculator
    {
        private readonly CalculateInterest interestdelegate;

        private double sum;
        private double interest;
        private int years;

        public InterestCalculator(
            double sum, 
            double interest, 
            int years, 
            CalculateInterest interestdelegate)
        {
            this.Sum = sum;
            this.Interest = interest;
            this.Years = years;
            this.interestdelegate = interestdelegate;
        }

        private double Sum
        {
            get
            {
                return this.sum;
            }

            set
            {
                Validator.ValidateNum(value, "Sum");
                this.sum = value;
            }
        }

        private double Interest
        {
            get
            {
                return this.interest;
            }

            set
            {
                Validator.ValidateNum(value, "Interest");
                this.interest = value;
            }
        }

        private int Years
        {
            get
            {
                return this.years;
            }

            set
            {
                Validator.ValidateNum(value, "Years");
                this.years = value;
            }
        }

        public override string ToString()
        {
            return $"{this.interestdelegate(this.Sum, this.Interest, this.Years):F4}";
        }
    }
}