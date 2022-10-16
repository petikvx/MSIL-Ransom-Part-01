using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ValueValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InsertProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertProxy()
	{
	}
}
