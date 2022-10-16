using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AlgoValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfacePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfacePublisher()
	{
	}
}
