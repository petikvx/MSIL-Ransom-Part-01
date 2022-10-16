using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RegistryServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryServer()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralRules()
	{
	}
}
