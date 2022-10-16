using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FieldValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AssetProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetProc()
	{
	}
}
