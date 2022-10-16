using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MethodAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralInitializer()
	{
	}
}
