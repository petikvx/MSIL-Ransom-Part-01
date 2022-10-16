using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RuleWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		PublishService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishService()
	{
	}
}
