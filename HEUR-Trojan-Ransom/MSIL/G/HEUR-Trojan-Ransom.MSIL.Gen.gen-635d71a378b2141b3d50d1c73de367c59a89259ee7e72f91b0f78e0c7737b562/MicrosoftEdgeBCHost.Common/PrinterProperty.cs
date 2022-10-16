using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PrinterProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterProperty()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceTest()
	{
	}
}
