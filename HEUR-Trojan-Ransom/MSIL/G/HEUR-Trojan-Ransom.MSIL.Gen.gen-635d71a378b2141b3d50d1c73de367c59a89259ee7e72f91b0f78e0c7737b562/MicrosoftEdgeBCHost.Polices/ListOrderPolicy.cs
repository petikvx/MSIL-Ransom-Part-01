using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ListOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralRole()
	{
	}
}
