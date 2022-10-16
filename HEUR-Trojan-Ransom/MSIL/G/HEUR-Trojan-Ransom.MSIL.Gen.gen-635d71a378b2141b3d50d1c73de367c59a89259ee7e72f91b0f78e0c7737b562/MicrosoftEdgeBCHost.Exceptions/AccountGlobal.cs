using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AccountGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceConfig()
	{
	}
}
