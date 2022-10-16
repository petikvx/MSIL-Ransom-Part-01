using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InterceptorVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorVal()
	{
		WriterPropertyProducer.ResolveStub();
		DisableSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableSingleton()
	{
	}
}
