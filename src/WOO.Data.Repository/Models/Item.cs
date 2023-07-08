using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOO.Data.Repository.Model
{
    public class Item
    {
        public Guid ItemId { get; set; }

        public string Designation { get; set; }

        public string Type { get; set; }

        public string ImagePath { get; set; }

        public IEnumerable<ItemReward> ItemRewards { get; set; }
    }
}
