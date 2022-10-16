using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ManagerValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralObserver()
	{
	}
}
