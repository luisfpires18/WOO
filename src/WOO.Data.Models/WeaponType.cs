namespace WOO.Data.Model
{
    public class WeaponType
    {
        public Guid WeaponTypeId { get; set; }
        public string Designation { get; set; }
        public string ImagePath { get; set; }
        public Guid ClassId { get; set; }
        public Class Class { get; set; }
        public IEnumerable<Weapon> Weapons { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
    }
}