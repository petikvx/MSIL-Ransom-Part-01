using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ReponseSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralCode()
	{
	}
}
