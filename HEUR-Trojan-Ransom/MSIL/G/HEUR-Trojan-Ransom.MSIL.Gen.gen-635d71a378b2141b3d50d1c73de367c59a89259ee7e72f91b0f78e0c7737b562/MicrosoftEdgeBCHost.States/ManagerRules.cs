using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ManagerRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerRules()
	{
		WriterPropertyProducer.ResolveStub();
		ResetSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetSchema()
	{
	}
}
