using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RequestRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestRules()
	{
		WriterPropertyProducer.ResolveStub();
		SetProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetProxy()
	{
	}
}
