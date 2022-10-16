using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PrototypeOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralError()
	{
	}
}
