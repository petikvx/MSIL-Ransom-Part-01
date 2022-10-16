using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SerializerRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyProxy()
	{
	}
}
