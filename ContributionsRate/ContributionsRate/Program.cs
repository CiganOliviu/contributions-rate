﻿using System;

namespace ContributionsRate
{
    internal class Io
    {
        protected readonly int Contributions;

        protected Io(int contributions)
        {
            Contributions = contributions;
        }

        public int GetContributions()
        {
            return Contributions;
        }
    }

    internal class Rates : Io
    {
        public Rates(int contributions) : base(contributions)
        {
        }

        public double GetAnnualContributionsRate()
        {
            var result = Convert.ToDouble(Contributions) / Convert.ToDouble(DateTime.Now.DayOfYear);
            
            return result;
        }

        public double PredictNumberOfAnnualContributions()
        {
            var result = GetAnnualContributionsRate() * 365;

            return result;
        }
    }
    
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var rates = new Rates(973);

            Console.WriteLine(rates.GetAnnualContributionsRate());
            Console.WriteLine(rates.PredictNumberOfAnnualContributions());
        }
    }
}