using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParamAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralTest()
	{
	}
}
