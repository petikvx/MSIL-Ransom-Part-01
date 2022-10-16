using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RuleState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleState()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfaceProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfaceProperty()
	{
	}
}
