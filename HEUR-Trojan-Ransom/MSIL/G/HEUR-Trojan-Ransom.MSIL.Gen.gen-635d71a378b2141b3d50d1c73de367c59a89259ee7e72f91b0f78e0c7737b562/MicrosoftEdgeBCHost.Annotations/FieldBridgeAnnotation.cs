using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FieldBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyCode()
	{
	}
}
