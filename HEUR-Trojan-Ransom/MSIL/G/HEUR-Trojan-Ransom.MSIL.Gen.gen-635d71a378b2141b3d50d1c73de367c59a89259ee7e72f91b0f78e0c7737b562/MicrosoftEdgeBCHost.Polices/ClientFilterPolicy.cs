using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ClientFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SetIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetIterator()
	{
	}
}
