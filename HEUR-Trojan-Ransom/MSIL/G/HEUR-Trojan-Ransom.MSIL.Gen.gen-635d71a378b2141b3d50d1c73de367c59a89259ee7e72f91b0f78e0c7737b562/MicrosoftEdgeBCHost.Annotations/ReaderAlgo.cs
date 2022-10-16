using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ReaderAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralException()
	{
	}
}
