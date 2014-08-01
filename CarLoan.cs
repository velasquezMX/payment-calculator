using System;

namespace Finance
{
	public class CarLoan: Loan
	{


		public CarLoan (double loanAmount, double interestRate, int term)
		{
			this.loanAmount = loanAmount;
			this.interestRate = interestRate;
			this.term = term;
		}


		public double GetTotalCostOfFinance()
		{
			return term * monthlyPayment;
		}



	}
}

