using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MapFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceRef()
	{
	}
}
