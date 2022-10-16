using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PolicyRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyRules()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeTag()
	{
	}
}
