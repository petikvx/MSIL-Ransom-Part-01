using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PoolRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolRules()
	{
		WriterPropertyProducer.ResolveStub();
		PatchParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchParameter()
	{
	}
}
