using System.Collections.Generic;

namespace Business.Data;

public interface IData2
{
	int Save<T>(IEnumerable<T> obj);

	int Save<T>(T obj);

	int SaveWithInt32Identity<T>(T obj);

	long SaveWithInt64Identity<T>(T obj);

	int SaveOrUpdate<T>(IEnumerable<T> obj);

	int SaveOrUpdate<T>(T obj);

	int Update<T>(IEnumerable<T> obj);

	int Update<T>(T obj);

	int Delete<T>(IEnumerable<T> obj);

	int Delete<T>(T obj);
}
