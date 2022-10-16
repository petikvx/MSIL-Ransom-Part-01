using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ListOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListOrder()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterceptor()
	{
	}
}
