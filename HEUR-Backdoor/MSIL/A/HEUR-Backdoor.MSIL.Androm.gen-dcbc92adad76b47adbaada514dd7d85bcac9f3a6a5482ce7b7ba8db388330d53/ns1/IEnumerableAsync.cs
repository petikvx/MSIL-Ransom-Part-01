using Geopoliti7ians;

namespace ns1;

public interface IEnumerableAsync<T>
{
	IEnumeratorAsync<T> GetEnumeratorAsync();
}
