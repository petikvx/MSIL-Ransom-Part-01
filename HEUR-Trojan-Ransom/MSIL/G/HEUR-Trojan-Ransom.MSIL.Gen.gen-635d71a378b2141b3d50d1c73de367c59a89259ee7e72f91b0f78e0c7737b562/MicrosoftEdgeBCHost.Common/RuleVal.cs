using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RuleVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleVal()
	{
		WriterPropertyProducer.ResolveStub();
		CallRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallRequest()
	{
	}
}
