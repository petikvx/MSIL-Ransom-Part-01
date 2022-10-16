using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AccountOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountOrder()
	{
		WriterPropertyProducer.ResolveStub();
		ManageItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageItem()
	{
	}
}
