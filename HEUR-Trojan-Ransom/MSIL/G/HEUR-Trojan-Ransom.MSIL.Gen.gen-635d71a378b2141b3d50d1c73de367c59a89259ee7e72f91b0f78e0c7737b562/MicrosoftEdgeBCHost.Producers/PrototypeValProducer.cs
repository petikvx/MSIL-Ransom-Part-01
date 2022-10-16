using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PrototypeValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeContext()
	{
	}
}
