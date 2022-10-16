using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RecordWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		CancelSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelSetter()
	{
	}
}
