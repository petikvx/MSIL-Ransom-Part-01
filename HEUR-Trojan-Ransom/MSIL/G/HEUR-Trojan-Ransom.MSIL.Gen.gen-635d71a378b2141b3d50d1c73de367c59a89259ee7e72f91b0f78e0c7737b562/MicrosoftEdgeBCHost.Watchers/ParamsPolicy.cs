using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParamsPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceDatabase()
	{
	}
}
