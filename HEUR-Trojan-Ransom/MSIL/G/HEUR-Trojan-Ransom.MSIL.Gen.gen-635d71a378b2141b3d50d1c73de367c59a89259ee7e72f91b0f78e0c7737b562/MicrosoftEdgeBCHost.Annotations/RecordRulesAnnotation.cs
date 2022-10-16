using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RecordRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateMock()
	{
	}
}
