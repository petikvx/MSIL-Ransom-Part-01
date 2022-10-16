using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InvocationState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationState()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfacePrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfacePrinter()
	{
	}
}
