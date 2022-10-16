using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MapperFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceComposer()
	{
	}
}
