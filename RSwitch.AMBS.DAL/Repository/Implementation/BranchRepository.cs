using Dapper;
using RSwitch.AMBS.Model.View;

namespace RSwitch.AMBS.DAL.Repositories.Implementation
{
    public class BranchRepository : Repository<BranchView>, IBranchRepository
    {
        public BranchRepository(DbFactory dbFactory, IApplicationConfigurationManager configurationManager) : base(dbFactory, configurationManager)
        {
        }

        public async Task<BranchView> GetBranches()
        {
            DynamicParameters parameters = new DynamicParameters();
            //parameters.Add("@BranchId", branchId);

            return await base.SingleAsync("SELECT * FROM BranchView ", parameters, false);
        }
    }
}
