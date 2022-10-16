using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PredicateVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateVal()
	{
		WriterPropertyProducer.ResolveStub();
		ListInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInfo()
	{
	}
}
