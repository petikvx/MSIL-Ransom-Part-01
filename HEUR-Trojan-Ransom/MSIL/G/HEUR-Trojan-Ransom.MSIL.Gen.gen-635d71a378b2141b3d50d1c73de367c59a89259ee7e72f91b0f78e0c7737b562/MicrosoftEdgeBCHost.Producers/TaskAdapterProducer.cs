using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TaskAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralPrototype()
	{
	}
}
