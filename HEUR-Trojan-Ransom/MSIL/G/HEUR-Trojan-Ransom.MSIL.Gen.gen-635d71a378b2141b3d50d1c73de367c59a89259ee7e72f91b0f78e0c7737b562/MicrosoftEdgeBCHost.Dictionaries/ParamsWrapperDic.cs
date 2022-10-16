using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParamsWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		CheckMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckMapper()
	{
	}
}
