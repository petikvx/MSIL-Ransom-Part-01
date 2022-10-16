using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ImporterWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralAuthentication()
	{
	}
}
