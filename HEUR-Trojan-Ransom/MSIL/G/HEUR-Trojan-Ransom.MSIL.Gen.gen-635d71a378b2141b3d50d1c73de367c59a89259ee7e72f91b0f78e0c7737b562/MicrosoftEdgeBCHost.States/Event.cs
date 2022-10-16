using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class Event
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Event()
	{
		WriterPropertyProducer.ResolveStub();
		CreateValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateValue()
	{
	}
}
