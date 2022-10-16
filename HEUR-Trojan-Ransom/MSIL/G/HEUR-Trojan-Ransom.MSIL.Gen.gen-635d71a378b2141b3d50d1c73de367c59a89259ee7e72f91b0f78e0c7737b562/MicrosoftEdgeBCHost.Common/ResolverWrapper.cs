using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ResolverWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		SetRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetRole()
	{
	}
}
