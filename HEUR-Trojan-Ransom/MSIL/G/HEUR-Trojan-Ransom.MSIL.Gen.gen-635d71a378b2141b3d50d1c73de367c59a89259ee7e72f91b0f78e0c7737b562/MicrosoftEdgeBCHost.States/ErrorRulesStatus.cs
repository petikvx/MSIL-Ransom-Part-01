using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ErrorRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RunProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunProc()
	{
	}
}
