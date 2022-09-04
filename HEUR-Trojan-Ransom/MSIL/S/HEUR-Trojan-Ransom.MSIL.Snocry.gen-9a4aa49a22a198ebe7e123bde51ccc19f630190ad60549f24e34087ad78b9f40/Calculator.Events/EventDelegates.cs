using System.Threading;

namespace Calculator.Events;

internal static class EventDelegates
{
	public delegate int Converted(double d);

	public delegate void FoundTreasureHandler(Thread thread);
}
