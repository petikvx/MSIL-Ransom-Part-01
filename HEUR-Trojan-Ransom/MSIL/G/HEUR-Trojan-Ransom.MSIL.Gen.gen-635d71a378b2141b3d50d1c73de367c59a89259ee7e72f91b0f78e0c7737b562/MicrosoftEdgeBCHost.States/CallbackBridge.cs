using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CallbackBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackBridge()
	{
		WriterPropertyProducer.ResolveStub();
		AddVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddVal()
	{
	}
}
