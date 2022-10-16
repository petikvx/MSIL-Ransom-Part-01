using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CodeProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeProperty()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceImporter()
	{
	}
}
