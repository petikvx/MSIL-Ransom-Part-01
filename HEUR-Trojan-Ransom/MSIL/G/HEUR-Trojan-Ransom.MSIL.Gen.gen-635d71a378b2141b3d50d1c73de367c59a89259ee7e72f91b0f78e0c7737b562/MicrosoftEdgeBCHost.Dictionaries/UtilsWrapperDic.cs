using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class UtilsWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeCode()
	{
	}
}
