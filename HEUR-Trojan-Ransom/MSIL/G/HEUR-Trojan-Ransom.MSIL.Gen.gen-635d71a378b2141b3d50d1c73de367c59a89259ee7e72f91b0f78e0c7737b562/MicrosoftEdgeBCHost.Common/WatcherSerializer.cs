using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class WatcherSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralDecorator()
	{
	}
}
