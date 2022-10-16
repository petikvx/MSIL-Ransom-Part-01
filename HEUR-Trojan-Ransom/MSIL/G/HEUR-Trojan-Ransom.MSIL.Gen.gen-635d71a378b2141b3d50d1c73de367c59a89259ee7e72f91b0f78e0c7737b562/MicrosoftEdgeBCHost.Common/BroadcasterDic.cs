using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class BroadcasterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterDic()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralInfo()
	{
	}
}
