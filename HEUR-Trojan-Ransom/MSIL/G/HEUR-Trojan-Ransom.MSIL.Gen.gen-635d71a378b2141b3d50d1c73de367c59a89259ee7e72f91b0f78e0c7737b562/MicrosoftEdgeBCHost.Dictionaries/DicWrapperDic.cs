using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DicWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		PublishDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishDescriptor()
	{
	}
}
