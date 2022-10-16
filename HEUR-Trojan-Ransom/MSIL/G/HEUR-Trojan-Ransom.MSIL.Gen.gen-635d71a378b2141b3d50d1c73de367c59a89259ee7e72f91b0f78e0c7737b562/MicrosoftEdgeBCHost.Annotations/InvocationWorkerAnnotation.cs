using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InvocationWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralTemplate()
	{
	}
}
