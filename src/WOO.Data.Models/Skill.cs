using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOO.Data.Model
{
    public class Skill
    {
        public Guid SkillId { get; set; }
        public string Name { get; set; }
        public SkillType SkillType { get; set; }
        public string ImagePath { get; set; }
        public Guid? WeaponTypeId { get; set; }
        public Guid? ClassId { get; set; }

        public WeaponType WeaponType { get; set; }
        public Class Class { get; set; }
    }
}
