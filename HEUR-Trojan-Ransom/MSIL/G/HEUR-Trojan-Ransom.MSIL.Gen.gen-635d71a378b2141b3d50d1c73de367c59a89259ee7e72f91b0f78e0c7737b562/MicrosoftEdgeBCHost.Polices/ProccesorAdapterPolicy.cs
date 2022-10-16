using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProccesorAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralField()
	{
	}
}
