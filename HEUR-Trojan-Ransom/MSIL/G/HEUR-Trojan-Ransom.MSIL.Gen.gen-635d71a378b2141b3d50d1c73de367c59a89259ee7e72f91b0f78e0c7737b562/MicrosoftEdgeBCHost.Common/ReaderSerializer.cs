using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ReaderSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralProccesor()
	{
	}
}
