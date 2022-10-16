using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ValBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		LoginRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginRequest()
	{
	}
}
