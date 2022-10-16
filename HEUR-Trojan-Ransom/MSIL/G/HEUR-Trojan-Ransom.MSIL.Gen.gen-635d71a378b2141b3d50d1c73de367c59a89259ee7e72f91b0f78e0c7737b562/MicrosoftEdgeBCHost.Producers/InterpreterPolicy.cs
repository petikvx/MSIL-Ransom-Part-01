using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InterpreterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
