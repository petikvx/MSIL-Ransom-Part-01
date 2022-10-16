using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DatabaseRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceContext()
	{
	}
}
