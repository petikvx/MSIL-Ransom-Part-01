using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ClientFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientFilter()
	{
		WriterPropertyProducer.ResolveStub();
		OrderClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderClient()
	{
	}
}
