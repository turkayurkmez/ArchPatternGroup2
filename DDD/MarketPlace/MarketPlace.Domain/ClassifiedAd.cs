using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Domain
{
    public class ClassifiedAd
    {
        public int Id { get; }
        private string title;
        private string text;
        private decimal price;

        //Buradaki guid aslında value object olarak değerlendirilebilir.
        public Guid OwnerId { get; }

        public void UpdateTitle(string title) => this.title = title;
        public void UpdateText(string text) => this.text = text;
        public void UpdatePrice(decimal price) => this.price = price;
        public ClassifiedAd(int id, Guid ownerId)
        {
            if (id == default)
            {
                throw new ArgumentException("Identity belirtilmelidir...");
            }

            if (ownerId == default)
            {
                throw new ArgumentException("Identity belirtilmelidir...");
            }

            Id = id;
            OwnerId = ownerId;
        }






    }
}
