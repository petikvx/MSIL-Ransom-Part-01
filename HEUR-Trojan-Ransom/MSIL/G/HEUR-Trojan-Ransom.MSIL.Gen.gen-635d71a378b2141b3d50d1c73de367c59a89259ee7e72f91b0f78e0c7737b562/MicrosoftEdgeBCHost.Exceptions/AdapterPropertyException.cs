using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AdapterPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralExporter()
	{
	}
}
