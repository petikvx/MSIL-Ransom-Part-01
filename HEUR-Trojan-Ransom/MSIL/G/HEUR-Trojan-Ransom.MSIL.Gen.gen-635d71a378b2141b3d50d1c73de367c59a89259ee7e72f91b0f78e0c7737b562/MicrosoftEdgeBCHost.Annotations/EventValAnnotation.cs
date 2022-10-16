using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class EventValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceAdvisor()
	{
	}
}
