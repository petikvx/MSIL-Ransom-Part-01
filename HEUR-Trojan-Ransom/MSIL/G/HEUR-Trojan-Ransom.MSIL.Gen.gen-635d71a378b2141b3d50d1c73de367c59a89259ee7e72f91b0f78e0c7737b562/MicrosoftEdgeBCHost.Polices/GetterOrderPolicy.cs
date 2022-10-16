using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class GetterOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralException()
	{
	}
}
