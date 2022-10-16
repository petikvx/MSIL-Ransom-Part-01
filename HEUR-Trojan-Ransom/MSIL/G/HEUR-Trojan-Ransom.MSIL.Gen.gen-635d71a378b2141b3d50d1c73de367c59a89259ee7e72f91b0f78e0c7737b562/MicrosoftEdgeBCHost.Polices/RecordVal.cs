using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RecordVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordVal()
	{
		WriterPropertyProducer.ResolveStub();
		CreateUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateUtils()
	{
	}
}
