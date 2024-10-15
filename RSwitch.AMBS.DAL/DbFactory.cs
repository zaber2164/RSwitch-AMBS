using System;
using Microsoft.EntityFrameworkCore;

namespace RSwitch.AMBS.DAL
{
    public class DbFactory : IDisposable
    {
        private bool _disposed;
        private readonly Func<RswitchDbContext> _instanceFunc;
        private DbContext _dbContext;
        public DbContext DbContext => _dbContext ??= _instanceFunc.Invoke();

        public DbFactory(Func<RswitchDbContext> dbContextFactory)
        {
            _instanceFunc = dbContextFactory;
        }

        public void Dispose()
        {
            if (_disposed || _dbContext == null) return;
            _disposed = true;
            _dbContext.Dispose();
        }
    }
}
