using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InitializerBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerBridge()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotQueue()
	{
	}
}
