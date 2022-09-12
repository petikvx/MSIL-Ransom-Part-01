namespace Newtonsoft.Json;

public interface IArrayPool<T> where T : notnull
{
	T[] Rent(int minimumLength);

	void Return(T[]? array);
}
