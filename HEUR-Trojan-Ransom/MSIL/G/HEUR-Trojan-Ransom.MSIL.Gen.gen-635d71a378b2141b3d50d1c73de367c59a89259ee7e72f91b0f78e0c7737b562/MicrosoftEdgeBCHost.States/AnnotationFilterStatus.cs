using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AnnotationFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceSingleton()
	{
	}
}
