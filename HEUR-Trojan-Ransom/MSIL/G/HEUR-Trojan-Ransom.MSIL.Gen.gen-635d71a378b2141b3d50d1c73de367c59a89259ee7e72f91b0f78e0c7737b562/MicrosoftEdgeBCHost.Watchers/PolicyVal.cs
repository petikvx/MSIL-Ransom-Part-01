using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PolicyVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyVal()
	{
		WriterPropertyProducer.ResolveStub();
		CountVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountVisitor()
	{
	}
}
