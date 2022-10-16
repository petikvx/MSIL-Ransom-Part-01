using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TokenWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralDefinition()
	{
	}
}
