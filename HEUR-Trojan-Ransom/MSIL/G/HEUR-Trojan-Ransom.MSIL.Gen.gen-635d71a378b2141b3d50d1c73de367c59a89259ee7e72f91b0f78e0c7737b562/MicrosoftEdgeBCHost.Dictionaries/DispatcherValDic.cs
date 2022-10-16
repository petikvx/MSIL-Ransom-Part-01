using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DispatcherValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherValDic()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralRequest()
	{
	}
}
