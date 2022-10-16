using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FacadePolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadePolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceProcess()
	{
	}
}
