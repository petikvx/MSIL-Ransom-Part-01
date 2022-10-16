using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RequestOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralSchema()
	{
	}
}
