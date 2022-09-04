using System;
using ns4;

internal class Class13
{
	internal static bool smethod_0()
	{
		DateTime dateTime = default(DateTime);
		try
		{
			dateTime = DateTime.Parse("2014-12-25T12:27:45");
			if (!(DateTime.Now > dateTime) && !(DateTime.Now < dateTime.AddDays(-21.0)))
			{
				if (Class24.smethod_72() == null)
				{
					try
					{
						smethod_1();
					}
					catch
					{
					}
				}
				return true;
			}
			throw new Exception("This assembly has been built with an evaluation version of SmartAssembly, which has expired.");
		}
		catch (Exception exception_)
		{
			Class24.smethod_130(exception_, (object)dateTime);
			throw;
		}
	}

	private static void smethod_1()
	{
		try
		{
			Console.WriteLine("This assembly has been built with an evaluation version of SmartAssembly, and therefore cannot be distributed.");
		}
		catch (Exception exception_)
		{
			Class24.smethod_73(exception_);
			throw;
		}
	}
}
