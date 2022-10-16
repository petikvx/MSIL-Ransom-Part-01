using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class Tag
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Tag()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeCode()
	{
	}
}
