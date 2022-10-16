using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AlgoVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoVal()
	{
		WriterPropertyProducer.ResolveStub();
		CallVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallVisitor()
	{
	}
}
