using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InvocationRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationRules()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateContext()
	{
	}
}
