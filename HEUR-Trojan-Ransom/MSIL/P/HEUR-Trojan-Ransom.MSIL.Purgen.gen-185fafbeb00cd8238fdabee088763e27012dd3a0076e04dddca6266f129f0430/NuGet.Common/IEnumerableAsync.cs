namespace NuGet.Common;

public interface IEnumerableAsync<T>
{
	IEnumeratorAsync<T> GetEnumeratorAsync();
}
