using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ThreadValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeAuthentication()
	{
	}
}
