using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CallbackState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackState()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceProperty()
	{
	}
}
