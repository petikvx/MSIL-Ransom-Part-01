using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CallbackBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SelectEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectEvent()
	{
	}
}
