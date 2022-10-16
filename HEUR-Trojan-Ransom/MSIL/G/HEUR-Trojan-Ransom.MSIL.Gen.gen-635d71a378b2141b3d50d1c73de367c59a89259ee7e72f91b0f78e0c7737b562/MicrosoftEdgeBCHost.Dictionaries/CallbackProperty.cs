using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CallbackProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackProperty()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceState()
	{
	}
}
