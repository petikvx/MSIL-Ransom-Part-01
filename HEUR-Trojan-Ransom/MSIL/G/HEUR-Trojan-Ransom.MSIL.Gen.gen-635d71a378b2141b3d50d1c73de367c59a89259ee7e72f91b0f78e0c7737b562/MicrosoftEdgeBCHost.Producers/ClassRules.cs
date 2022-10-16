using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ClassRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassRules()
	{
		WriterPropertyProducer.ResolveStub();
		PatchTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchTag()
	{
	}
}
