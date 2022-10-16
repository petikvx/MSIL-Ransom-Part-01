using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FieldVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldVal()
	{
		WriterPropertyProducer.ResolveStub();
		NewRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewRequest()
	{
	}
}
