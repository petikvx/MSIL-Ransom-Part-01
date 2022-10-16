using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ManagerFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralManager()
	{
	}
}
