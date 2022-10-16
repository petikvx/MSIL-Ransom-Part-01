using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ModelRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelRules()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateModel()
	{
	}
}
