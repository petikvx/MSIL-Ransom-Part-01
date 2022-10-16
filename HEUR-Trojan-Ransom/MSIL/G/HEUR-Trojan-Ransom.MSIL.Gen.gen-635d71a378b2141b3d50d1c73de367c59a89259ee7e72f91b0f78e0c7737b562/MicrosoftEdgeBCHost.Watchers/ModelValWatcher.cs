using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ModelValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceContext()
	{
	}
}
