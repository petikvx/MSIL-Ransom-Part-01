using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ServiceBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceValue()
	{
	}
}
