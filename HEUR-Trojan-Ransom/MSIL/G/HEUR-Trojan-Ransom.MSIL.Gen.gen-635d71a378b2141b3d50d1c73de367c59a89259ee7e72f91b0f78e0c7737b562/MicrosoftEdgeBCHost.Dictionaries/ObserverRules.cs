using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ObserverRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverRules()
	{
		WriterPropertyProducer.ResolveStub();
		ViewContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewContext()
	{
	}
}
