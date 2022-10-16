using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AdvisorValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceParameter()
	{
	}
}
