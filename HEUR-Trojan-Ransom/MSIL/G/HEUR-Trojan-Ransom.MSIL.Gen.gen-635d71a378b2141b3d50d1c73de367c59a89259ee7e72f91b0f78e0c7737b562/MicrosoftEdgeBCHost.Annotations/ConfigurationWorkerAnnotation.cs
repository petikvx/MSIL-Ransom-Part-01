using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConfigurationWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FlushLiteralFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushLiteralFacade()
	{
	}
}
