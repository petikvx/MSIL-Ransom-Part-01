using System;

namespace game;

internal class Class11
{
	public static void smethod_0()
	{
		Class7 class7_ = new Class7(8, 5);
		try
		{
			Class8 @class = new Class8(new Class10[8]
			{
				new Class10(0, 2, class7_),
				new Class10(1, 2, class7_),
				new Class10(2, 2, class7_),
				new Class10(3, 2, class7_),
				new Class10(4, 2, class7_),
				new Class10(5, 2, class7_),
				new Class10(6, 2, class7_),
				new Class10(7, 2, class7_)
			});
			Interface2[] interface2_ = new Interface2[5]
			{
				new Class4(@class),
				new Class3(@class),
				new Class5(@class),
				new Class2(@class),
				new Class13(@class)
			};
			Class14[] class14_ = new Class14[3]
			{
				new Class14(new Class10(1, 3, class7_)),
				new Class14(new Class10(3, 3, class7_)),
				new Class14(new Class10(5, 3, class7_))
			};
			Class6 class2 = new Class6(interface2_)
			{
				Class14_0 = class14_
			};
			bool flag = class2.method_0();
			Console.WriteLine("Player " + (flag ? "won" : "lost"));
		}
		catch (Exception1 exception)
		{
			Console.WriteLine(exception.Message);
		}
		catch (Exception0)
		{
			Console.WriteLine("Unhandled Exception");
		}
		catch (Exception ex)
		{
			Console.WriteLine("Unhandled Exception: " + ex);
		}
	}
}
