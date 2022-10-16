using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ExporterValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralIdentifier()
	{
	}
}
