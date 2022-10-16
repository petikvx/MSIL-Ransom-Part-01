using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ClientRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ReadStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadStruct()
	{
	}
}
