using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProccesorValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralParams()
	{
	}
}
