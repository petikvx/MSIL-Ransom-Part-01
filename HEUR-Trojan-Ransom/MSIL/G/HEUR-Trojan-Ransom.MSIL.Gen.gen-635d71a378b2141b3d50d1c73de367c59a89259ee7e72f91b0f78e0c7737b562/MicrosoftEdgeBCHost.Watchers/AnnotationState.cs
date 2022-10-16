using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AnnotationState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationState()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceMessage()
	{
	}
}
