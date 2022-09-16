using System.Threading.Tasks;

namespace Geopoliti7ians;

public interface IEnumeratorAsync<T>
{
	T Current { get; }

	Task<bool> MoveNextAsync();
}
