using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProcFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralFactory()
	{
	}
}
