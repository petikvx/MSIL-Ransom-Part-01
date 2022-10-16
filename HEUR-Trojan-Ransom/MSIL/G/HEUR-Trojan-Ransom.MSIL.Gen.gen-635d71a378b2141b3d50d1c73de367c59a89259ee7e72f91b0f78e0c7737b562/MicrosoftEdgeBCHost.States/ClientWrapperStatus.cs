using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ClientWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyProccesor()
	{
	}
}
