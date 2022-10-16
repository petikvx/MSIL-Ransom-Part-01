using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ClientValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralManager()
	{
	}
}
