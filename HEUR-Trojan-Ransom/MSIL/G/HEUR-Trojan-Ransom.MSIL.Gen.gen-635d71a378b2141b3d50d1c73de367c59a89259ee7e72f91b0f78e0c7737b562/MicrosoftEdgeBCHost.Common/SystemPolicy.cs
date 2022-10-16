using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SystemPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceAccount()
	{
	}
}
