using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MethodFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralMethod()
	{
	}
}
