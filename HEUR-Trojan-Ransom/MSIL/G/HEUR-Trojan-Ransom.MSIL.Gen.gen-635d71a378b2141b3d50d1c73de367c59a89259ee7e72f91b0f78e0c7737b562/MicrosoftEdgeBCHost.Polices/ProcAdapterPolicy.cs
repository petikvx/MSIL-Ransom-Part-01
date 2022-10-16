using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProcAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralClass()
	{
	}
}
