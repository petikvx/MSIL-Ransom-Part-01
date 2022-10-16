using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExceptionState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionState()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceIndexer()
	{
	}
}
