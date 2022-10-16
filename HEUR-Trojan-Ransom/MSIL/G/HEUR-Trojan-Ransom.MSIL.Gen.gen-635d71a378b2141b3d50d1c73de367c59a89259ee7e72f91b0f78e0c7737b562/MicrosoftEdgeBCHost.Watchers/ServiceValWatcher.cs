using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ServiceValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceParams()
	{
	}
}
