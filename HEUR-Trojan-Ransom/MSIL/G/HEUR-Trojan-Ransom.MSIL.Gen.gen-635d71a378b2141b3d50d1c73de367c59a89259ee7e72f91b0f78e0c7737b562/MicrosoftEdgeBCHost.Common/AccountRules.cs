using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AccountRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountRules()
	{
		WriterPropertyProducer.ResolveStub();
		SetContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetContext()
	{
	}
}
