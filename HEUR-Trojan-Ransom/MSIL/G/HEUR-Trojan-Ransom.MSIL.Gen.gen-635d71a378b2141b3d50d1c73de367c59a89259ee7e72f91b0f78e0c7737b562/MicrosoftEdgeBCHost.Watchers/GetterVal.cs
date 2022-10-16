using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class GetterVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterVal()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatRepository()
	{
	}
}
