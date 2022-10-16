using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConfigurationClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationClass()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceStruct()
	{
	}
}
