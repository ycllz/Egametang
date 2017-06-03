﻿using Model;
using MongoDB.Bson;

namespace Hotfix
{
	public interface IDisposable2
	{
		void Dispose();
	}

	public abstract class Object: IDisposable2
	{
		public long Id { get; protected set; }

		protected Object()
		{
			Id = IdGenerater.GenerateId();
		}

		protected Object(long id)
		{
			this.Id = id;
		}

		public virtual void Dispose()
		{
		}
	}
}