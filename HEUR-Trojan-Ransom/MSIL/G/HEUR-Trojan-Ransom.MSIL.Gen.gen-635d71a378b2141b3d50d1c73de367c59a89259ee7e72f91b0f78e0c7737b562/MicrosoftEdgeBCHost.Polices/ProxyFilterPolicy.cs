using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProxyFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptDescriptor()
	{
	}
}
