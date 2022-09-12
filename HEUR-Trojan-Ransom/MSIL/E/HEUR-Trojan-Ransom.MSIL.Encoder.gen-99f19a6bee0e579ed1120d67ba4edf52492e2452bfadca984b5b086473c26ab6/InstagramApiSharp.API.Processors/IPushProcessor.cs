using System.Threading.Tasks;

namespace InstagramApiSharp.API.Processors;

public interface IPushProcessor
{
	Task<bool> RegisterPush();
}
