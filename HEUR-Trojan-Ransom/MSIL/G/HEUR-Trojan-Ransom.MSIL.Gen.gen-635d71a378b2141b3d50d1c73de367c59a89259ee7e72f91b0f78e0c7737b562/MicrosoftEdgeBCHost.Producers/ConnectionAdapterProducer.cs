using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConnectionAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralAttribute()
	{
	}
}
