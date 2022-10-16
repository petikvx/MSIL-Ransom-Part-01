using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ModelFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceDispatcher()
	{
	}
}
