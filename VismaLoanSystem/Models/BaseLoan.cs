using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VismaLoanSystem.Models
{
    public abstract class BaseLoan
    {
        [Display(Name = "Desired Amount")]
        [Required(ErrorMessage = "Enter Desired Amount")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0")]
        public uint DesiredAmount { get; set; }

        [Display(Name = "Payback Time (in year)")]
        [Required(ErrorMessage = "Enter the Payback Time in year")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0")]
        public uint PaybackTime { get; set; }

        [ReadOnly(true)]
        [Display(Name = "Monthly Payback")]
        public double MonthlyPayback { get; set; }
    }
}