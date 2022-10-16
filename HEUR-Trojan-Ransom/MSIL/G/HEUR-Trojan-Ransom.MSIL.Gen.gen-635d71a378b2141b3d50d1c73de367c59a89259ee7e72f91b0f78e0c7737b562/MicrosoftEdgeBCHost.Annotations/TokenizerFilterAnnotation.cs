using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TokenizerFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceQueue()
	{
	}
}
