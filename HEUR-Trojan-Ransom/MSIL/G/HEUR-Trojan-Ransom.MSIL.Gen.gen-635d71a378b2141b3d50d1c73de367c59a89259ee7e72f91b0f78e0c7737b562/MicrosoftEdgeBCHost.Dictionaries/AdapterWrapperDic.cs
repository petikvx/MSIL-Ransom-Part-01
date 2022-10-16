using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AdapterWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateIdentifier()
	{
	}
}
