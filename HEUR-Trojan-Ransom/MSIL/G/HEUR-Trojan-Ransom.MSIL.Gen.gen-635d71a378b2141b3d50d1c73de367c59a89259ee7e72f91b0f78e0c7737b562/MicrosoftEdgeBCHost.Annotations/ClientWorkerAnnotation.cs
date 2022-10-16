using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ClientWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralRequest()
	{
	}
}
