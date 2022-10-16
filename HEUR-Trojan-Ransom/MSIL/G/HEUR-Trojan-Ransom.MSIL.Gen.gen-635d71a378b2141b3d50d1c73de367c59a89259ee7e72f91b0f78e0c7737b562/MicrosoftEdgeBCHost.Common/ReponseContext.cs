using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ReponseContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseContext()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceRules()
	{
	}
}
