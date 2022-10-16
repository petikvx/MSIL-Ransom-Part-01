using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CodeRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateDescriptor()
	{
	}
}
