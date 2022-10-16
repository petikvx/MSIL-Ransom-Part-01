using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class BasePolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BasePolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceAccount()
	{
	}
}
