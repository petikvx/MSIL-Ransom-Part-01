using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProxyWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		RateBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateBridge()
	{
	}
}
