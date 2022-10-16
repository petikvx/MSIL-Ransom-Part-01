using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AdapterValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceIterator()
	{
	}
}
