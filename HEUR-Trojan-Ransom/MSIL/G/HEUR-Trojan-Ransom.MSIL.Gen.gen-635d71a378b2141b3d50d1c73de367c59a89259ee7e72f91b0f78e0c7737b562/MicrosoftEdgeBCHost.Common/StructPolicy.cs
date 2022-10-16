using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StructPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfaceAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfaceAccount()
	{
	}
}
