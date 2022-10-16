using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConnectionFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionFilter()
	{
		WriterPropertyProducer.ResolveStub();
		InitComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitComposer()
	{
	}
}
