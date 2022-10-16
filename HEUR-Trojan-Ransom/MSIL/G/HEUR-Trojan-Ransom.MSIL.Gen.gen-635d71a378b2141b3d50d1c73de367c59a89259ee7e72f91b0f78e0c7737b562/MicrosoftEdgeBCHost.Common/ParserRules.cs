using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParserRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserRules()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutOrder()
	{
	}
}
