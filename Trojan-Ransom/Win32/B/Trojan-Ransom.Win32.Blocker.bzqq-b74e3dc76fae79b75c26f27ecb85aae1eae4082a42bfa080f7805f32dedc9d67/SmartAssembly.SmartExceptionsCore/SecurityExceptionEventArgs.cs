using System;
using System.IO;
using System.Security;
using System.Windows.Forms;
using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.SmartExceptionsCore;

public class SecurityExceptionEventArgs : EventArgs
{
	internal SecurityException securityException_0;

	internal string string_0;

	internal bool bool_0;

	internal bool bool_1;

	internal bool bool_2;

	public SecurityException SecurityException
	{
		get
		{
			try
			{
				return securityException_0;
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}
	}

	public string SecurityMessage
	{
		get
		{
			try
			{
				return string_0;
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}
	}

	public bool CanContinue
	{
		get
		{
			try
			{
				return bool_2;
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}
	}

	public bool TryToContinue
	{
		get
		{
			try
			{
				return bool_0;
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}
		set
		{
			bool flag = default(bool);
			try
			{
				flag = (bool_0 = value);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, flag, this, value);
				throw;
			}
		}
	}

	public bool ReportException
	{
		get
		{
			try
			{
				return bool_1;
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}
		set
		{
			bool flag = default(bool);
			try
			{
				flag = (bool_1 = value);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, flag, this, value);
				throw;
			}
		}
	}

	public SecurityExceptionEventArgs(SecurityException securityException)
	{
		string o = (string_0 = string.Empty);
		bool flag = true;
		bool_2 = true;
		base._002Ector();
		SecurityException o2 = default(SecurityException);
		try
		{
			o2 = (securityException_0 = securityException);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, o, flag, o2, this, securityException);
			throw;
		}
	}

	public SecurityExceptionEventArgs(SecurityException securityException, bool canContinue)
		: this(securityException)
	{
		bool flag = default(bool);
		try
		{
			flag = (bool_2 = canContinue);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, flag, this, securityException, canContinue);
			throw;
		}
	}

	public SecurityExceptionEventArgs(string securityMessage, bool canContinue)
		: this(new SecurityException(securityMessage), canContinue)
	{
		string o = default(string);
		try
		{
			o = (string_0 = securityMessage);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, o, this, securityMessage, canContinue);
			throw;
		}
	}

	static SecurityExceptionEventArgs()
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

	internal static bool smethod_0(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 29:
					return dateTime_0 < dateTime_1;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, dateTime_0, dateTime_1, int_0, int_1);
			throw;
		}
	}

	internal static object smethod_1(Type type_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 46:
					return Activator.CreateInstance(type_0);
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

	internal static int smethod_2(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 85:
					return stream_0.Read(byte_0, int_0, int_1);
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, num, stream_0, byte_0, int_0, int_1, int_2, int_3);
			throw;
		}
	}

	internal static short smethod_3(byte[] byte_0, int int_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 118:
					return BitConverter.ToInt16(byte_0, int_0);
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, byte_0, int_0, int_1, int_2);
			throw;
		}
	}

	internal static void smethod_4(Control control_0, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5)
	{
		int num = default(int);
		try
		{
			num = 3;
			while (true)
			{
				switch (int_5 ^ int_4)
				{
				case 17:
					control_0.SetBounds(int_0, int_1, int_2, int_3);
					return;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException9(exception, num, num2, control_0, int_0, int_1, int_2, int_3, int_4, int_5);
			throw;
		}
	}
}
