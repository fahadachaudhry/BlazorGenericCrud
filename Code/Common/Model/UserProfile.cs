namespace Common.Model
{
    public class UserProfile : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
    }
}
