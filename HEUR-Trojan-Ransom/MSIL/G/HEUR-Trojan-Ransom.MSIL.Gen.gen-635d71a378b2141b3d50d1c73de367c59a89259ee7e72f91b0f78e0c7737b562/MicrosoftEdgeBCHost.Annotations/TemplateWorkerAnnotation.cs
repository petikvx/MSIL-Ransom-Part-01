using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TemplateWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralToken()
	{
	}
}
