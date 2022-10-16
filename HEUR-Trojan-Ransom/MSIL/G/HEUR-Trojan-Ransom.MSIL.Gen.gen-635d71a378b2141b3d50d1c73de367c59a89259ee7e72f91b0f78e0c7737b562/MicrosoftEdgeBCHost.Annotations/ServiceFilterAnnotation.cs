using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ServiceFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		MapInterfaceInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInterfaceInitializer()
	{
	}
}
