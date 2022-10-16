using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class UtilsAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralPrinter()
	{
	}
}
