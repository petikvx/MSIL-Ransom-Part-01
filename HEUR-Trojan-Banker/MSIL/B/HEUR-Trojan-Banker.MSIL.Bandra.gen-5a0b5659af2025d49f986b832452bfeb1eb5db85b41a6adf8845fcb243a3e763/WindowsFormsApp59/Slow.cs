using System.Reflection;
using System.Threading;

namespace WindowsFormsApp59;

internal class Slow
{
	internal Assembly MyAssembly()
	{
		return Thread.GetDomain().Load(Low.Buffers());
	}
}
