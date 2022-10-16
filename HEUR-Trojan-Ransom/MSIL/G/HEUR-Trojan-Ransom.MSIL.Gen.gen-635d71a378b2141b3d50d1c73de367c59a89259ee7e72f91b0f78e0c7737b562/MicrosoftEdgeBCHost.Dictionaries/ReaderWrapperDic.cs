using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ReaderWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		CallRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallRef()
	{
	}
}
