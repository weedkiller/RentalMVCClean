using System.Collections.Generic;
using RentalMobile.Model.Models;
using RentalModel.Repository.Data.Fake;
using RentalModel.Repository.Generic.Repositories.Base;

namespace RentalModel.Repository.Data.Repositories
{
    public class FakeAgentRejectedApplicationRepository : FakeGenericRepository<AgentRejectedApplication>
    {
        public FakeAgentRejectedApplicationRepository() : base(new FakeAgentRejectedApplications().MyAgentRejectedApplications)
        {
        }
        public FakeAgentRejectedApplicationRepository(List<AgentRejectedApplication> myAgentRejectedApplication): base(myAgentRejectedApplication)
        {
        }

    }
}
       