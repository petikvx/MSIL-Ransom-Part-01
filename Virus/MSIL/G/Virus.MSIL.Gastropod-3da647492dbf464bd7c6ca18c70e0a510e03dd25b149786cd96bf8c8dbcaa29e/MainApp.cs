using System.Threading;
using zwuUkpmiAMoxhf;

internal class MainApp
{
	public static void Main()
	{
		Thread thread = new Thread(lapixb.Go);
		thread.Start();
		Thread.Sleep(100000);
		thread.Abort();
	}
}
