using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class GetterFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterFilter()
	{
		WriterPropertyProducer.ResolveStub();
		FindWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindWatcher()
	{
	}
}
