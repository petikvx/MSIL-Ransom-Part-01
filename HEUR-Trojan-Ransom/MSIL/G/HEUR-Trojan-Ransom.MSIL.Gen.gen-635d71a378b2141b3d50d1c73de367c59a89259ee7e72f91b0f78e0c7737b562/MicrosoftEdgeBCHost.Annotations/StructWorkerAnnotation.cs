using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StructWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralTemplate()
	{
	}
}
