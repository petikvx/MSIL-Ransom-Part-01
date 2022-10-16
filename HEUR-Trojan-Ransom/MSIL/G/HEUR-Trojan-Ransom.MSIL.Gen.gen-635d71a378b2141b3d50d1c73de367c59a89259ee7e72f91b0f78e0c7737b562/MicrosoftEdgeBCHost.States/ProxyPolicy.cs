using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProxyPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceProcess()
	{
	}
}
