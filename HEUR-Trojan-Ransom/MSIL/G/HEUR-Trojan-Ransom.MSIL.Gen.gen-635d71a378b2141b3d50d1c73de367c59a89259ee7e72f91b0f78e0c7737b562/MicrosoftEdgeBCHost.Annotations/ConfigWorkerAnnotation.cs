using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConfigWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralDispatcher()
	{
	}
}
