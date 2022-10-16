using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ManagerOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralMethod()
	{
	}
}
