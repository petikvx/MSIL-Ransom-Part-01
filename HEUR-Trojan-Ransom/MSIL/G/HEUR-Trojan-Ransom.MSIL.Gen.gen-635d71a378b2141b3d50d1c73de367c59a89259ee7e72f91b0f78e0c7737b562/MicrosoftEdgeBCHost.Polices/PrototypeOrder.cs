using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PrototypeOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeOrder()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterClass()
	{
	}
}
