using System;

namespace DevelopmentWithADot.Repository
{
	public interface IUnitOfWork : IDisposable
	{
		Boolean HasChanges { get; }

		void Clear();

		void SaveChanges();
	}
}
