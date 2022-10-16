using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ObjectVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectVal()
	{
		WriterPropertyProducer.ResolveStub();
		StopPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopPredicate()
	{
	}
}
