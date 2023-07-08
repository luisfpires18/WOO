using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOO.Data.Repository.Model
{
    public class Weapon
    {
        public Guid WeaponId { get; set; }
        public string Name { get; set; }

        public Guid WeaponTypeId { get; set; }
        public string PlayerId { get; set; }

        public WeaponType WeaponType { get; set; }
        public Player Player { get; set; }
    }
}
