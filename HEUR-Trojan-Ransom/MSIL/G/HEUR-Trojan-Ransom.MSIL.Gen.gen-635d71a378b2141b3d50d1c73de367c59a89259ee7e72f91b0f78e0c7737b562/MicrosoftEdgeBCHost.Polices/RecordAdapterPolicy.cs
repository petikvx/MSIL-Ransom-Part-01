using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RecordAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralAuthentication()
	{
	}
}
