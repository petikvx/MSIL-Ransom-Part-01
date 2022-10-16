using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConnectionOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralReg()
	{
	}
}
