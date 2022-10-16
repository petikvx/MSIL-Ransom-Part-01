using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProxyClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyClass()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceFilter()
	{
	}
}
