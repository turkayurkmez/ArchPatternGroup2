namespace Consumer1.CQRS.Queries
{
    public class GetPersonQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
