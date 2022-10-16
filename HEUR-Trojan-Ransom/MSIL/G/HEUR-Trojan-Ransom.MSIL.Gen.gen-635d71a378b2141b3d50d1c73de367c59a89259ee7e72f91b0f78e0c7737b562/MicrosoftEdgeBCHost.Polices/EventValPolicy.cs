using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class EventValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeRule()
	{
	}
}
