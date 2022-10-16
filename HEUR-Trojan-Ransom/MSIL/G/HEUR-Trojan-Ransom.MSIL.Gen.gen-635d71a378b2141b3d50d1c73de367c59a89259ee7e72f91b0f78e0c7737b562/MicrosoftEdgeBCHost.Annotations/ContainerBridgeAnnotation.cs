using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ContainerBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeDic()
	{
	}
}
