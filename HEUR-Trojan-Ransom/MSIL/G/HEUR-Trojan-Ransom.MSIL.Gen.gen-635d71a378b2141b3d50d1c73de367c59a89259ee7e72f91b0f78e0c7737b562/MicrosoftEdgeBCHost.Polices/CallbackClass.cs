using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CallbackClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackClass()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceClass()
	{
	}
}
