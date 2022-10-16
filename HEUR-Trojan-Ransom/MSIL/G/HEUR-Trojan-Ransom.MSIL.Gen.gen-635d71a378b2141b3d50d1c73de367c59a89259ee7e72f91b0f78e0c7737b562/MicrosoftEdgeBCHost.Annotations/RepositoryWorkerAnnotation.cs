using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RepositoryWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralWatcher()
	{
	}
}
