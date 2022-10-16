using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class EventAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceError()
	{
	}
}
