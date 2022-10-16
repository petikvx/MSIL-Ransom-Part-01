using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ValValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralValue()
	{
	}
}
