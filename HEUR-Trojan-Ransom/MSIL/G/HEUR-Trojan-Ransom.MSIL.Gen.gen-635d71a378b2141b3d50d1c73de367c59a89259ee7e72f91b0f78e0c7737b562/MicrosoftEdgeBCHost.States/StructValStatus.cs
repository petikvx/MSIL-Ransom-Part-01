using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StructValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralRecord()
	{
	}
}
