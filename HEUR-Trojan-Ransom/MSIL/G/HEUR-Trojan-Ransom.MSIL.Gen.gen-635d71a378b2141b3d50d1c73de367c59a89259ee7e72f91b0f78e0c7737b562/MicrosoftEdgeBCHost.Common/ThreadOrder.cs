using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ThreadOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadOrder()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeRegistry()
	{
	}
}
