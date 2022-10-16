using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class HelperVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperVal()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterPredicate()
	{
	}
}
