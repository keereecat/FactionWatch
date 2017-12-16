using System;

namespace FactionWatch.Persistence {
    public interface IRepository<T> {
        T this[String index] {
            get;
        }

        Boolean IsUpdate(T obj);
    }
}
