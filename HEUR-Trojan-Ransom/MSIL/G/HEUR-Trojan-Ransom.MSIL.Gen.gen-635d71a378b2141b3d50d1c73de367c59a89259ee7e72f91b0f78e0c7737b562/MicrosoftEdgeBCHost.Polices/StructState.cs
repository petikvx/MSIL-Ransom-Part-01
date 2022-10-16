using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StructState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructState()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfacePrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfacePrinter()
	{
	}
}
