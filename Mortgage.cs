using System;

namespace Finance
{
	public class Mortgage: Loan
	{
		public Mortgage (double loanAmount, double interestRate, int term)
		{
			this.loanAmount = loanAmount;
			this.interestRate = interestRate;
			this.term = term;
		}


	}
}

