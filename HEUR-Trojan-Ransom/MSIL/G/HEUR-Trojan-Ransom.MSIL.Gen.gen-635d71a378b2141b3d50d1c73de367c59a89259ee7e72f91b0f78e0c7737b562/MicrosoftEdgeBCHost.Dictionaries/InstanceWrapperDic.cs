using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InstanceWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeAttr()
	{
	}
}
