using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExporterClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterClass()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceRule()
	{
	}
}
