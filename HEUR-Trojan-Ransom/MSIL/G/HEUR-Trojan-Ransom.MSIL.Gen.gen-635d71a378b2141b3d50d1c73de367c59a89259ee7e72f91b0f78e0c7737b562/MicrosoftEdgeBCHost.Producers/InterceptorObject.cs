using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InterceptorObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorObject()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralTemplate()
	{
	}
}
