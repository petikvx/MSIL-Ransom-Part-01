using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProductRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceContext()
	{
	}
}
