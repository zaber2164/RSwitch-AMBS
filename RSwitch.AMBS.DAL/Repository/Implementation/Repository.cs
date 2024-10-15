using RSwitch.AMBS.DAL.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace RSwitch.AMBS.DAL.Repositories.Implementation
{
    public class Repository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
    {
        private readonly DbFactory _dbFactory;
        private DbSet<TEntity> _dbSet;
        private readonly IApplicationConfigurationManager _configurationManager;

        public Repository(DbFactory dbFactory, IApplicationConfigurationManager configurationManager)
        {
            _dbFactory = dbFactory;
            _configurationManager = configurationManager;
        }

        protected DbSet<TEntity> DbSet
        {
            get => _dbSet ??= _dbFactory.DbContext.Set<TEntity>();
        }
        public async Task<IEnumerable<TEntity>> GetAsync(string sql, bool isProcedure = false)
        {
            await using var connection = new SqlConnection(_configurationManager.GetConnectionString());
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            return await connection.QueryAsync<TEntity>(sql, commandType: isProcedure ? CommandType.StoredProcedure : CommandType.Text);
        }

        public async Task<IEnumerable<TEntity>> GetAsync(string sql, DynamicParameters parameters, bool isProcedure = false)
        {
            await using var connection = new SqlConnection(_configurationManager.GetConnectionString());
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            return await connection.QueryAsync<TEntity>(sql, parameters, commandType: isProcedure ? CommandType.StoredProcedure : CommandType.Text);
        }

        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<DataTable> GetDataTableAsync(string sql, bool isProcedure = false)
        {
            using var connection = new SqlConnection(_configurationManager.GetConnectionString());
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            var reader = await connection.ExecuteReaderAsync(sql, commandType: isProcedure ? CommandType.StoredProcedure : CommandType.Text);

            DataTable table = new DataTable();
            table.Load(reader);

            return table;
        }

        public async Task<DataTable> GetDataTableAsync(string sql, DynamicParameters parameters, bool isProcedure = false)
        {
            using var connection = new SqlConnection(_configurationManager.GetConnectionString());
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            var reader = await connection.ExecuteReaderAsync(sql, parameters, commandType: isProcedure ? CommandType.StoredProcedure : CommandType.Text);

            var table = new DataTable();
            table.Load(reader);

            return table;
        }
        public DataTable GetDataTable(string sql, DynamicParameters parameters, bool isProcedure = false)
        {
            using var connection = new SqlConnection(_configurationManager.GetConnectionString());
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            var reader = connection.ExecuteReader(sql, parameters, commandType: isProcedure ? CommandType.StoredProcedure : CommandType.Text);

            var table = new DataTable();
            table.Load(reader);

            return table;
        }

        public async Task<TEntity> SingleAsync(string sql, bool isProcedure = false)
        {
            await using var connection = new SqlConnection(_configurationManager.GetConnectionString());
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            return await connection.QueryFirstOrDefaultAsync<TEntity>(sql, commandType: isProcedure ? CommandType.StoredProcedure : CommandType.Text);
        }

        public async Task<TEntity> SingleAsync(string sql, DynamicParameters parameters, bool isProcedure = false)
        {
            await using var connection = new SqlConnection(_configurationManager.GetConnectionString());
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            return await connection.QueryFirstOrDefaultAsync<TEntity>(sql, parameters, commandType: isProcedure ? CommandType.StoredProcedure : CommandType.Text);
        }

        public async Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<TEntity> FindByIdAsync(object id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            return await DbSet.FindAsync(id);
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            await DbSet.AddAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> InsertAsync(IEnumerable<TEntity> entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            await DbSet.AddRangeAsync(entity);
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            DbSet.Update(entity);
            await Task.CompletedTask;
            return entity;
        }

        public async Task<IEnumerable<TEntity>> UpdateAsync(IEnumerable<TEntity> entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            DbSet.UpdateRange(entity);
            await Task.CompletedTask;
            return entity;
        }

        public async Task DeleteAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            DbSet.Remove(entity);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(IEnumerable<TEntity> entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            DbSet.RemoveRange(entity);
            await Task.CompletedTask;
        }

        public void Dispose()
        {
            _dbFactory?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
