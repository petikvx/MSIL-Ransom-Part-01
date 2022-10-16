using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InterceptorAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralConfiguration()
	{
	}
}
