using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ClientFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SetCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetCode()
	{
	}
}
