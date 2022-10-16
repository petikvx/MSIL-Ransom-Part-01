using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CallbackBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceManager()
	{
	}
}
