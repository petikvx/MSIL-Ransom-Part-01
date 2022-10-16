using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProductPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfaceProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfaceProcess()
	{
	}
}
