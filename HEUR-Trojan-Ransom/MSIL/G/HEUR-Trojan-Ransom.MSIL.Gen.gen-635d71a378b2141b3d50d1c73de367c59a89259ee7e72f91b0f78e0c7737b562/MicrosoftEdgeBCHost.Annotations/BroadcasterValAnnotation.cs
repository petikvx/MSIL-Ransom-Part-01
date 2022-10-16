using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BroadcasterValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceStub()
	{
	}
}
