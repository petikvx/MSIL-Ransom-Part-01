using System.Threading.Tasks;

namespace NuGet.Common;

public interface IEnumeratorAsync<T>
{
	T Current { get; }

	Task<bool> MoveNextAsync();
}
