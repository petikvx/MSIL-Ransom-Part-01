using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProxyValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceProducer()
	{
	}
}
