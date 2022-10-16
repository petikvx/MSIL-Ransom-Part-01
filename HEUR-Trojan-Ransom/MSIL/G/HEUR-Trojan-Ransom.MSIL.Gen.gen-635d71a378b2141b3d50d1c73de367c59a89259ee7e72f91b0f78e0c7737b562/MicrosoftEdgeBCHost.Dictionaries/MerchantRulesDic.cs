using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MerchantRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceParams()
	{
	}
}
