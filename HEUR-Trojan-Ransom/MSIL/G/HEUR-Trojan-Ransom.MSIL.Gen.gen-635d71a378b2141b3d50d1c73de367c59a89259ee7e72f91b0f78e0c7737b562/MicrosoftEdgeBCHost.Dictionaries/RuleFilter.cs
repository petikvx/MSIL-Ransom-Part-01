using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RuleFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleFilter()
	{
		WriterPropertyProducer.ResolveStub();
		PushMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushMock()
	{
	}
}
