using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VismaLoanSystem.Models
{
    public class HousingLoan : BaseLoan
    {
        public double InterestRatePerYear = 0.035;

        //public override double GetMonthlyPayback()
        //{
        //    return Math.Round((DesiredAmount * (1 + (this.InterestRatePerYear * PaybackTime))) / (PaybackTime * 12), 2);
        //}
    }
}