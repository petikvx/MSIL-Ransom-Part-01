using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ComposerVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerVal()
	{
		WriterPropertyProducer.ResolveStub();
		InitSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitSpecification()
	{
	}
}
