using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class GetterWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceField()
	{
	}
}
