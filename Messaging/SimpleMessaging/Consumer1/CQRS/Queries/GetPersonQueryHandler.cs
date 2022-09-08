using Models;

namespace Consumer1.CQRS.Queries
{
    public class GetPersonQueryHandler
    {
        public GetPersonQueryResponse Handle(GetPersonQueryRequest request)
        {
            var person = FakePersonCollection.GetPeople().FirstOrDefault(p => p.Id == request.Id);
            return new GetPersonQueryResponse { Id = person.Id, Age = person.Age, LastName = person.LastName, Name = person.Name };
        }
    }


    public class GetPeopleQueryHandler
    {
        public List<GetPeopleQueryResponse> Handle()
        {
            return FakePersonCollection.GetPeople().Select(p => new GetPeopleQueryResponse { Id = p.Id, Age = p.Age }).ToList();
        }
    }
}
