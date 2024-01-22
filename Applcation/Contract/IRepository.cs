using System;

public class Class1
{
    public interface IRepository<T, Id> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(Id id);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        int Save();
    }
}
}
