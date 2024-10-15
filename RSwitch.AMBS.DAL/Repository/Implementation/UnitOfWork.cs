using System;
using System.Threading.Tasks;
using RSwitch.AMBS.DAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace RSwitch.AMBS.DAL.Repositories.Implementation
{
    public class UnitOfWork: IUnitOfWork, IDisposable
    {
        private readonly DbFactory _dbFactory;

        public UnitOfWork(DbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<int> CommitAsync()
        {
            await using var transaction = await _dbFactory.DbContext.Database.BeginTransactionAsync();
            try
            {
                var affectedRows = await _dbFactory.DbContext.SaveChangesAsync();
                await transaction.CommitAsync();
                return affectedRows;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw;
            }
            finally
            {
                await _dbFactory.DbContext.Database.CloseConnectionAsync();
                await _dbFactory.DbContext.DisposeAsync();
            }
        }

        public void Dispose()
        {
            _dbFactory?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
