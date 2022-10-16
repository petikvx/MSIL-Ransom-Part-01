using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProxyOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfacePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfacePolicy()
	{
	}
}
