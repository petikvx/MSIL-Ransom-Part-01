using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class HelperValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperValDic()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralComparator()
	{
	}
}
