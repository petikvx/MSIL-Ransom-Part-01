using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FilterRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterRules()
	{
		WriterPropertyProducer.ResolveStub();
		AddMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddMessage()
	{
	}
}
