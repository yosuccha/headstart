using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pageTwoHundred
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople;
        private int numberOfPeople;
        decimal CostOfBeveragesPerPerson;
        decimal CostOfDecorations = 0;
        
        
        public void SetPartyOptions(int people, bool fancy)
        {
            numberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }
        public int GetNumberOfPeople()
        {
            return numberOfPeople;
        }
        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = (NumberOfPeople * 5.00M);
            }
            else
            {
                CostOfBeveragesPerPerson = (NumberOfPeople * 20M);
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (50M + (15.00M * NumberOfPeople));
            }
            else
            {
                CostOfDecorations = (30M + (7.50M * NumberOfPeople));
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + (CostOfBeveragesPerPerson
                                + CostOfFoodPerPerson) * NumberOfPeople;
                        if (healthyOption)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }          
        }
    }
}
