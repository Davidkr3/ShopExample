using ShopExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopExample
{
    public class PriceManager : IPriceManager
    {
        public List<Article> Articles;

        public PriceManager()
        {
            this.Articles = new List<Article>();
        }

        public void AddArticle(Article article)
        {
            bool exists = this.Articles.Any(a => a.Name == article.Name);

            if (exists)
            {
                throw new ArgumentException();                
            }

            this.Articles.Add(article);
        }

        public bool AddPromotion(string articleName, double discount, DateTime startDate, int durationDays)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetArticleNames()
        {
            throw new NotImplementedException();
        }

        public double GetPrice(string name, DateTime date)
        {
            throw new NotImplementedException();
        }

        public void SetChristmasPeriod(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public void SetClearancePeriod(DateTime startDate, int DaysDuration)
        {
            throw new NotImplementedException();
        }
    }
}
