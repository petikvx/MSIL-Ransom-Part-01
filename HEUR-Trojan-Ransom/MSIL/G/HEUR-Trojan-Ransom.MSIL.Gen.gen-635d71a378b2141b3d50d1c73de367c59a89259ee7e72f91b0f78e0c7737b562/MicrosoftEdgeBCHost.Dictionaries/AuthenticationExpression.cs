using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AuthenticationExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationExpression()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralSetter()
	{
	}
}
