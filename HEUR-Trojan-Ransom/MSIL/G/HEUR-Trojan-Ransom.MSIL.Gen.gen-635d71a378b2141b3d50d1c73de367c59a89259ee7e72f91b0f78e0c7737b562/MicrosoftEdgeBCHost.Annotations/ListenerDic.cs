using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ListenerDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerDic()
	{
		WriterPropertyProducer.ResolveStub();
		AddLiteralInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddLiteralInfo()
	{
	}
}
