using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ConfigurationBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceValue()
	{
	}
}
