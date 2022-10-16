using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AccountUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfacePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfacePrototype()
	{
	}
}
