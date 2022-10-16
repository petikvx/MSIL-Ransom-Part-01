using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PredicateState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateState()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceModel()
	{
	}
}
