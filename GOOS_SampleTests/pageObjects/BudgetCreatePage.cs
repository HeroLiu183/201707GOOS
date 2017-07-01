using System;
using FluentAutomation;

namespace GOOS_SampleTests.pageObjects
{
    public class BudgetCreatePage:PageObject<BudgetCreatePage>
    {
        public BudgetCreatePage(FluentTest test) : base(test)
        {
        }

        public BudgetCreatePage Amount(int amount)
        {
            throw new NotImplementedException();
        }

        public BudgetCreatePage Month(string yearMonth)
        {
            throw new NotImplementedException();
        }

        public void AddBudget()
        {
            throw new NotImplementedException();
        }

        public void ShouldDisplay(string message)
        {
            throw new NotImplementedException();
        }
    }
}