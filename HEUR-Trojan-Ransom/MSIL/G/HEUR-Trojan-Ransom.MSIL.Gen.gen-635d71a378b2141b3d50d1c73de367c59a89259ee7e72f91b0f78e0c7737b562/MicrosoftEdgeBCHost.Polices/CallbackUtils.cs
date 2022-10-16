using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CallbackUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfacePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfacePrototype()
	{
	}
}
