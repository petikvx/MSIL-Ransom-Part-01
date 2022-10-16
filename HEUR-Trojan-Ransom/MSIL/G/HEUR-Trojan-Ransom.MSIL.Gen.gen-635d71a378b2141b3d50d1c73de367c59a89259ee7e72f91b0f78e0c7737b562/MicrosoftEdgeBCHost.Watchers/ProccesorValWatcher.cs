using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProccesorValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceTemplate()
	{
	}
}
