using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StateValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceFacade()
	{
	}
}
