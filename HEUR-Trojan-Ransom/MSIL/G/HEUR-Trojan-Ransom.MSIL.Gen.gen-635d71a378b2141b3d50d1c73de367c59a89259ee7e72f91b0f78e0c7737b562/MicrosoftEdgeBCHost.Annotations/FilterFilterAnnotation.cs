using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FilterFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceManager()
	{
	}
}
