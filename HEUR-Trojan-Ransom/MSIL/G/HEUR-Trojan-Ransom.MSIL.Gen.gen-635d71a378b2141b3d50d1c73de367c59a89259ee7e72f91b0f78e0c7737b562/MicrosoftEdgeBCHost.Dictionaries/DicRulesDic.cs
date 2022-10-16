using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DicRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceTag()
	{
	}
}
