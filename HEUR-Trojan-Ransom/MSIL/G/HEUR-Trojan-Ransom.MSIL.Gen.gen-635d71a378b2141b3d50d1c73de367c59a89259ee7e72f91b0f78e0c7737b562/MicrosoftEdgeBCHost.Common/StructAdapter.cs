using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StructAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceInstance()
	{
	}
}
