using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.SmartExceptionsCore;

public class FatalExceptionEventArgs : EventArgs
{
	internal Exception exception_0;

	public Exception FatalException
	{
		get
		{
			try
			{
				return exception_0;
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}
	}

	internal FatalExceptionEventArgs(Exception exception_1)
	{
		Exception o = default(Exception);
		try
		{
			o = (exception_0 = exception_1);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, o, this, exception_1);
			throw;
		}
	}

	static FatalExceptionEventArgs()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static bool smethod_0(object object_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 103:
					return Convert.ToBoolean(object_0);
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, object_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_1(Stream stream_0, byte byte_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 53:
					stream_0.WriteByte(byte_0);
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, stream_0, byte_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_2(Control control_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 3;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 111:
					control_0.Refresh();
					return;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, control_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_3(Image image_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 67:
					image_0.Dispose();
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, image_0, int_0, int_1);
			throw;
		}
	}

	internal static Type smethod_4(Type type_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 116:
					return type_0.BaseType;
				case 117:
					return type_0.GetElementType();
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, type_0, int_0, int_1);
			throw;
		}
	}
}
