using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StatusBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusBridge()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeCollection()
	{
	}
}
