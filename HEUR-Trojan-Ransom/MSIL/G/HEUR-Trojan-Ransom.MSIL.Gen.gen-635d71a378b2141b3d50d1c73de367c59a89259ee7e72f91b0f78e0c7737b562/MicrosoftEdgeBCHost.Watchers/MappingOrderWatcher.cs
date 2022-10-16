using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MappingOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CheckLiteralToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckLiteralToken()
	{
	}
}
