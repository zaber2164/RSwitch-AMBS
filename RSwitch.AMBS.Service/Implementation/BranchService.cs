using Dapper;
using RSwitch.AMBS.DAL.Repositories.Interface;
using RSwitch.AMBS.Model.View;

namespace RSwitch.AMBS.Service.Implementation
{
    public class BranchService //: IBranchService
    {
        private readonly IBranchRepository _branchRepository;

        public BranchService(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        public async Task<IEnumerable<BranchView>> GetBranchAsync()
        {
            var parameters = new DynamicParameters();
            //parameters.Add("@Login", userName);
            //return await _branchRepository.GetAsync("SELECT * FROM UserBranchView WHERE UserLogin = @Login", parameters, false);
            return await _branchRepository.GetAsync("SELECT * FROM BranchView", parameters, false);
        }
    }
}