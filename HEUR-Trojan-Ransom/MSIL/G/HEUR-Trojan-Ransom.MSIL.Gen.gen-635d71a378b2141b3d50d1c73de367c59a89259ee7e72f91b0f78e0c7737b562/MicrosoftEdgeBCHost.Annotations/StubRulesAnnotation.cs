using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StubRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		NewRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewRecord()
	{
	}
}
