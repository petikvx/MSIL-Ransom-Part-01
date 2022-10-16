using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PrinterBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceProccesor()
	{
	}
}
