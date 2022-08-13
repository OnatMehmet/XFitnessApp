using Microsoft.EntityFrameworkCore;
using NLayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Repositoeries
{
    public class GenericRepository<T> : IGenericRepository<T>  where T : class
    {

        protected readonly AppDbContext _context; // readonly yapmmamın sebebi bu değişkenlere ya burda değer verilecek yada Constructorda değer everilececk.Bunların dışında bir yerde değer vermeyiz.
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context, DbSet<T> dbSet)
        {
            _context = context;
            //_dbSet = dbSet;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddRangeAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
           return await _dbSet.AnyAsync(expression);
        }

        public void Remove(T entity)
        {
            //_context.Entry(entity).State = EntityState.Deleted; //Burada aşağıdaki kodun aynı işini yapıyor Update ve Delete de  Asenkron yok
           _dbSet.Remove(entity);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
           return _dbSet.AsNoTracking().AsQueryable();//AsNoTracking :  çekilen  kayıtları hafızaya almasın  performans olarak düşüş olmasın diye insert ve update olmayacagından kullanıldı
        }

        public async Task<T> GetByIdAsync(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _dbSet.FindAsync(id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
           return _dbSet.Where(expression);

        }
    }
}
