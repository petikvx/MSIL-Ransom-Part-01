using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ThreadWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyConfiguration()
	{
	}
}
