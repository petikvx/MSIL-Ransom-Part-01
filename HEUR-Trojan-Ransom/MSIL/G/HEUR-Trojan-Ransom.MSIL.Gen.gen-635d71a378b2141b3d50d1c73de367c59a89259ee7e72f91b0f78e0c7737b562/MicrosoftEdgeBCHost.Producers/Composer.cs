using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class Composer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Composer()
	{
		WriterPropertyProducer.ResolveStub();
		PatchCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchCode()
	{
	}
}
