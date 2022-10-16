using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AdapterOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceThread()
	{
	}
}
