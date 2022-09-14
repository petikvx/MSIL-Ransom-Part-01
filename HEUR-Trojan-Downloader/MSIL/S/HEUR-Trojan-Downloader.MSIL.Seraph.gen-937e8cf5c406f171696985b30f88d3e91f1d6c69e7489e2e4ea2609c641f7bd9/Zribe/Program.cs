using System;
using System.Collections.Generic;
using System.Threading;

namespace Zribe;

internal class Program
{
	[STAThread]
	private static void Main()
	{
		Queue<RequestType> queue = new Queue<RequestType>();
		AutoResetEvent autoResetEvent = new AutoResetEvent(initialState: false);
		autoResetEvent.WaitOne(15000);
		queue.Enqueue(RequestType.TextProblem);
		Member member = new Member();
		queue.Enqueue(RequestType.ScreenProblem);
		Console.WriteLine(member.Good());
		if (queue.Count > 0 && queue.Peek() != 0)
		{
			queue.Dequeue();
		}
		queue.Enqueue(RequestType.ModemProblem);
	}
}
