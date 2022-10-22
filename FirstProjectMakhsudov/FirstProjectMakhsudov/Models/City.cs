namespace FirstProjectMakhsudov.Models
{
    public class City
    {
        public int Id { get; set; } = ++Global.CityId;
        public string Name { get; set; } = string.Empty;

    }
}
