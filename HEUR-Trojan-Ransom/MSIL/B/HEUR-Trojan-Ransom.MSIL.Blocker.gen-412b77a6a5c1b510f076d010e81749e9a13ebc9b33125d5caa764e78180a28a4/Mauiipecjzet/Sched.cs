using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Mauiipecjzet;

internal class Sched
{
	public class Coroutine
	{
		public IEnumerator routine;

		public Coroutine waitForCoroutine;

		public bool finished;

		public Coroutine(IEnumerator routine)
		{
			this.routine = routine;
		}
	}

	private static Sched instance = new Sched();

	private List<Coroutine> coroutines = new List<Coroutine>();

	public static Sched Instance => instance;

	private Sched()
	{
	}

	public Coroutine StartCoroutine(IEnumerator routine)
	{
		Coroutine coroutine = new Coroutine(routine);
		coroutines.Add(coroutine);
		return coroutine;
	}

	public void Update()
	{
		foreach (Coroutine item in Enumerable.Reverse(coroutines))
		{
			if (item.routine.Current is Coroutine)
			{
				item.waitForCoroutine = item.routine.Current as Coroutine;
			}
			if (item.waitForCoroutine != null && item.waitForCoroutine.finished)
			{
				item.waitForCoroutine = null;
			}
			if (item.waitForCoroutine == null)
			{
				if (item.routine.MoveNext())
				{
					item.finished = false;
					continue;
				}
				coroutines.Remove(item);
				item.finished = true;
			}
		}
	}
}
