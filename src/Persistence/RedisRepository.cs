using System;
using System.Collections.Generic;
using System.Text;

namespace FactionWatch.Persistence {
    class RedisRepository<T> : IRepository<T> {
		public T this[String indexer] {
			get => GetItem(indexer);
		}

		//TODO: Write backend code for updating and reporting if it needed it.
		public Boolean IsUpdate(T obj) {
            throw new NotImplementedException();
        }

        private T GetItem(String indexer) =>
            throw new NotImplementedException();
    }
}
