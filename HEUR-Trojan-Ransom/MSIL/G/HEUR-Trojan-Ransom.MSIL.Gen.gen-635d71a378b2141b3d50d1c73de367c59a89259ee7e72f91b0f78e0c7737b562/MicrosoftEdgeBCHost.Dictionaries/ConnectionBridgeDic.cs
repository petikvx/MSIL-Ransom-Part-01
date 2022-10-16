using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ConnectionBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		SetupCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupCallback()
	{
	}
}
