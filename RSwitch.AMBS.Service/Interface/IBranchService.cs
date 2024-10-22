using RSwitch.AMBS.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSwitch.AMBS.Service.Interface
{
    public interface IBranchService
    {
        public Task<IEnumerable<BranchView>> GetBranchAsync();
    }
}
