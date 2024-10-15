using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dapper;

namespace RSwitch.AMBS.DAL.Repositories.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Get All Data using SQL Query or procedure
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isProcedure"></param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> GetAsync(string sql, bool isProcedure = false);
        /// <summary>
        /// Get All data using SQL Query or Procedure with adding dapper parameters
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="isProcedure"></param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> GetAsync(string sql, DynamicParameters parameters, bool isProcedure = false);
        /// <summary>
        /// Get All Data using EntityFramework
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);
        /// <summary>
        /// Get All Data using EntityFramework
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> GetAllAsync();
        /// <summary>
        /// Get DataTable using SQl Query or Procedure
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isProcedure"></param>
        /// <returns></returns>
        Task<DataTable> GetDataTableAsync(string sql, bool isProcedure = false);
        /// <summary>
        /// Get DataTable using SQL Query or Procedure with adding dapper parameters
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="isProcedure"></param>
        /// <returns></returns>
        Task<DataTable> GetDataTableAsync(string sql, DynamicParameters parameters, bool isProcedure = false);

        /// <summary>
        /// Get Single Mapped Data using SQL Query or Procedure
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isProcedure"></param>
        /// <returns></returns>
        Task<TEntity> SingleAsync(string sql, bool isProcedure = false);
        /// <summary>
        /// Get Single Mapped Data using SQL Query or Procedure with adding dapper parameters
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="isProcedure"></param>
        /// <returns></returns>
        Task<TEntity> SingleAsync(string sql, DynamicParameters parameters, bool isProcedure = false);
        /// <summary>
        /// Get Single Mapped Data using EntityFramework
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Get Single Mapped Data using Table Primary Key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> FindByIdAsync(object id);
        /// <summary>
        /// Insert data using EF
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> InsertAsync(TEntity entity);
        /// <summary>
        /// Insert multiple data using EF
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> InsertAsync(IEnumerable<TEntity> entity);
        /// <summary>
        /// Update data using EF
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> UpdateAsync(TEntity entity);
        /// <summary>
        /// Update Multiple data using EF
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> UpdateAsync(IEnumerable<TEntity> entity);
        /// <summary>
        /// Delete data using EF
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task DeleteAsync(TEntity entity);
        /// <summary>
        /// Delete multiple data using EF
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task DeleteAsync(IEnumerable<TEntity> entity);

    }
}
