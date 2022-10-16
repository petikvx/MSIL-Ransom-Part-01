using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WrapperOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralMap()
	{
	}
}
