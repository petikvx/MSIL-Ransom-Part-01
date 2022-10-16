using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PublisherValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceToken()
	{
	}
}
