using ShopExample.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopExample
{
    interface IPriceManager
    {
        void AddArticle(Article article);
        bool AddPromotion(string articleName, double discount, DateTime startDate, int durationDays);
        double GetPrice(string name, DateTime date);
        IEnumerable<string> GetArticleNames();
        void SetChristmasPeriod(DateTime startDate, DateTime endDate);
        void SetClearancePeriod(DateTime startDate, int DaysDuration);
    }

}
