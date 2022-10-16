using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProxyOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralReg()
	{
	}
}
