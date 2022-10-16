using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AttrWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralMapper()
	{
	}
}
