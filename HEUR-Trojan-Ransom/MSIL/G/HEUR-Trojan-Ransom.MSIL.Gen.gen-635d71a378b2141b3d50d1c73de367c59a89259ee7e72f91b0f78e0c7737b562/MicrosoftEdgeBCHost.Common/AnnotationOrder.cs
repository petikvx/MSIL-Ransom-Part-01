using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AnnotationOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationOrder()
	{
		WriterPropertyProducer.ResolveStub();
		MoveReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveReg()
	{
	}
}
