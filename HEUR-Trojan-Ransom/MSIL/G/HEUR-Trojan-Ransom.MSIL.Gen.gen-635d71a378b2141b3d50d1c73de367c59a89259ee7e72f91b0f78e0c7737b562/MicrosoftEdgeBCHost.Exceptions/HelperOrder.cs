using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class HelperOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperOrder()
	{
		WriterPropertyProducer.ResolveStub();
		DeletePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeletePool()
	{
	}
}
