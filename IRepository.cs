using System;
using System.Linq;
using System.Linq.Expressions;

namespace DevelopmentWithADot.Repository
{
	public interface IRepository
	{
		T Create<T>();

		T Find<T>(params Object[] ids);

		IQueryable<T> Query<T>();
		IQueryable<T> QueryAndFetch<T>(params Expression<Func<T, Object>>[] paths);

		void Attach<T>(T item);
		void Detach<T>(T item);

		void Save<T>(T item);
		void Update<T>(T item);
		void Delete<T>(T item);
	}
}
