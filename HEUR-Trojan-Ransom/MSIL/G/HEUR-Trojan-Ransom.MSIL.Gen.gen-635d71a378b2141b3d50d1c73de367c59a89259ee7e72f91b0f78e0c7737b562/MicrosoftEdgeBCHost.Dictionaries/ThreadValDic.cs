using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ThreadValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralInfo()
	{
	}
}
