using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InfoWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateRecord()
	{
	}
}
