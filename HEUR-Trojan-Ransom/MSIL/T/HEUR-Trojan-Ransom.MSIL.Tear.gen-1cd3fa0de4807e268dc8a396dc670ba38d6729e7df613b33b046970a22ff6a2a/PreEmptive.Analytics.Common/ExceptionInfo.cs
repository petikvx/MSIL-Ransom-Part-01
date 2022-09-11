using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PreEmptive.Analytics.Common;

public class ExceptionInfo
{
	[CompilerGenerated]
	private Exception exception_0;

	[CompilerGenerated]
	private ExceptionType exceptionType_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private string string_2;

	public Exception Exception
	{
		[CompilerGenerated]
		get
		{
			int num = 6736;
			int num2 = num;
			num = 6736;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return exception_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -9197;
			int num2 = num;
			num = -9197;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			exception_0 = value;
		}
	}

	public ExceptionType ExceptionType
	{
		[CompilerGenerated]
		get
		{
			int num = 7757;
			int num2 = num;
			num = 7757;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return exceptionType_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 19558;
			int num2 = num;
			num = 19558;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			exceptionType_0 = value;
		}
	}

	public string Message
	{
		[CompilerGenerated]
		get
		{
			int num = 31500;
			int num2 = num;
			num = 31500;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return string_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -30840;
			int num2 = num;
			num = -30840;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			string_0 = value;
		}
	}

	public string Contact
	{
		[CompilerGenerated]
		get
		{
			int num = -8342;
			int num2 = num;
			num = -8342;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return string_1;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -21334;
			int num2 = num;
			num = -21334;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			string_1 = value;
		}
	}

	public string Comment
	{
		[CompilerGenerated]
		get
		{
			int num = 1717;
			int num2 = num;
			num = 1717;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return string_2;
			}
		}
		[CompilerGenerated]
		set
		{
			if (1 == 0)
			{
			}
			int num = -16562;
			int num2 = num;
			num = -16562;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			string_2 = value;
		}
	}

	public ExceptionInfo()
		: this(ExceptionType.Caught)
	{
	}

	public ExceptionInfo(ExceptionType type, [Optional] Exception exception, [Optional] string contact, [Optional] string comment, [Optional] string message)
	{
		ExceptionType = type;
		Exception = exception;
		if (message != null)
		{
			Message = message;
		}
		else if (exception != null)
		{
			Message = exception.Message;
		}
		Contact = contact;
		Comment = comment;
	}

	public static ExceptionInfo Caught([Optional] Exception exception, [Optional] string contact, [Optional] string comment, [Optional] string message)
	{
		int num = -32097;
		int num2 = num;
		num = -32097;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return new ExceptionInfo(ExceptionType.Caught, exception, contact, comment, message);
		}
	}

	public static ExceptionInfo Caught(string name, [Optional] string message, [Optional] string callstack, [Optional] string callstackregex, [Optional] string contact, [Optional] string comment)
	{
		int num = -13224;
		int num2 = num;
		num = -13224;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return Caught(CreateException(name, message, callstack, callstackregex), contact, comment, message);
		}
	}

	public static ExceptionInfo Uncaught([Optional] Exception exception, [Optional] string contact, [Optional] string comment, [Optional] string message)
	{
		int num = -11210;
		int num2 = num;
		num = -11210;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return new ExceptionInfo(ExceptionType.Uncaught, exception, contact, comment, message);
		}
	}

	public static ExceptionInfo Uncaught(string name, [Optional] string message, [Optional] string callstack, [Optional] string callstackregex, [Optional] string contact, [Optional] string comment)
	{
		int num = 15337;
		int num2 = num;
		num = 15337;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			return Uncaught(CreateException(name, message, callstack, callstackregex), contact, comment, message);
		}
	}

	public static ExceptionInfo Thrown([Optional] Exception exception, [Optional] string contact, [Optional] string comment, [Optional] string message)
	{
		int num = 18429;
		int num2 = num;
		num = 18429;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return new ExceptionInfo(ExceptionType.Thrown, exception, contact, comment, message);
		}
	}

	public static ExceptionInfo Thrown(string name, [Optional] string message, [Optional] string callstack, [Optional] string callstackregex, [Optional] string contact, [Optional] string comment)
	{
		int num = 21462;
		int num2 = num;
		num = 21462;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return Thrown(CreateException(name, message, callstack, callstackregex), contact, comment, message);
		}
	}

	public static Exception CreateException(string name, string exceptionmessage, string callstack, string callstackregex)
	{
		int num = 2;
		Exception ex = default(Exception);
		while (true)
		{
			int num2 = 32100;
			int num3 = num2;
			num2 = 32100;
			int num4;
			switch (num3 == num2)
			{
			case false:
			case true:
				if (true)
				{
				}
				ex.Data["횁튪\udeb3튵횹틺껀닗뛑닛뻠닓뛕닋긪"] = callstackregex;
				num2 = 3;
				num4 = num2;
				goto IL_0088;
			default:
				{
					if (0 == 0)
					{
					}
					ex = new Exception(exceptionmessage);
					ex.Data["횗튦\udeb1튳횢틚껛닙뛜닰뻓닛뛗"] = name;
					num2 = 5;
					num4 = num2;
					goto IL_0088;
				}
				IL_0088:
				while (true)
				{
					switch (num4)
					{
					case 5:
						if (callstack != null)
						{
							num2 = 0;
							num4 = num2;
							continue;
						}
						goto case 4;
					case 4:
						num2 = 2;
						num4 = num2;
						continue;
					case 2:
						if (callstackregex != null)
						{
							num2 = 1;
							num4 = num2;
							continue;
						}
						goto case 3;
					case 0:
						ex.Data["횁튪\udeb3튵횹틺껀닗뛑닛"] = callstack;
						num2 = 4;
						num4 = num2;
						continue;
					case 1:
						break;
					default:
						goto end_IL_0113;
					case 3:
						return ex;
					}
					break;
				}
				goto case false;
				end_IL_0113:
				break;
			}
		}
	}
}
