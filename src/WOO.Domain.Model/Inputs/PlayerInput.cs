namespace WOO.Domain.Model.Inputs
{
    public class PlayerInput
    {
        public string Name { get; set; } = string.Empty;

        public int Score { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Score: {Score}";
        }
    }
}