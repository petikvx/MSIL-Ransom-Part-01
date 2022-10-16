using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AnnotationReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationReponse()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralMethod()
	{
	}
}
