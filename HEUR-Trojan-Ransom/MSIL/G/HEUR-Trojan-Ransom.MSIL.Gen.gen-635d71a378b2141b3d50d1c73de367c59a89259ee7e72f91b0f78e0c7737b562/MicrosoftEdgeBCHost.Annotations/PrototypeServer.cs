using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PrototypeServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeServer()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralRules()
	{
	}
}
