using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InterpreterReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterReponse()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralValue()
	{
	}
}
