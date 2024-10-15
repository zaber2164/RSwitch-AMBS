using RSwitch.AMBS.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSwitch.AMBS.DAL.Repositories.Interface
{
    public interface IBranchRepository : IRepository<BranchView>
    {
        Task<BranchView> GetBranches();
    }
}
