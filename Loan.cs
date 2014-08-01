using System;

namespace Finance
{
	public class Loan
	{
		public double loanAmount = 0.0;
		public double interestRate = 0.0;
		public int term = 0;
		public double monthlyPayment = 0.0;

		public Loan ()
		{

		}

		public double GetMonthlyPayment()
		{
			double monthlyInterestRate = (interestRate / 100) / 12;
			double temp = monthlyInterestRate * Math.Pow ((1 + monthlyInterestRate), term);
			double temp2 = Math.Pow((1 + monthlyInterestRate), term) - 1;
			double monthlyPayment = loanAmount * (temp / temp2);
			this.monthlyPayment = Math.Round(monthlyPayment, 2);
			return monthlyPayment;
		}



	}
}

