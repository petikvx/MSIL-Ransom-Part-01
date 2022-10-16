using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class VisitorOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralMethod()
	{
	}
}
