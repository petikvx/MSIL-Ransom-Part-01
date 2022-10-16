using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FieldRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldRules()
	{
		WriterPropertyProducer.ResolveStub();
		EnableContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableContext()
	{
	}
}
