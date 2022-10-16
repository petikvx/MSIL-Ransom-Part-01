using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class Resolver
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Resolver()
	{
		WriterPropertyProducer.ResolveStub();
		ManageEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageEvent()
	{
	}
}
