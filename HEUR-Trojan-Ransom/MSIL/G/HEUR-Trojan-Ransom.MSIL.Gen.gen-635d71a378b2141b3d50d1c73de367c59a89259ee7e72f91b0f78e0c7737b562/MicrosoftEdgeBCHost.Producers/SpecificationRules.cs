using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SpecificationRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationRules()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteContext()
	{
	}
}
