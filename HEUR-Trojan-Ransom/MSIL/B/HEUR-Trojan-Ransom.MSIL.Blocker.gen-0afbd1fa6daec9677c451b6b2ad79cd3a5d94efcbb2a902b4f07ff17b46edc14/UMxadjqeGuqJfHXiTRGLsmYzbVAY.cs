using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;

public class UMxadjqeGuqJfHXiTRGLsmYzbVAY
{
	internal enum UHIpFFWYcwzREaXVemcMgNxeenbI
	{
		const_0,
		const_1,
		const_2
	}

	private StackFrame[] gwaxwXlQimTtHhPRbqdZgltqAjBo;

	public const int UeTGdJKFZFUXDUAjWFHPOWkBszTr = 0;

	private int ZHmUwxKiEgpsZLHHMnYMMWdkUgwT;

	internal int int_0;

	public virtual int JLpodqgoIpMCfdhcCEcJFuqLFiCcb => int_0;

	public UMxadjqeGuqJfHXiTRGLsmYzbVAY()
	{
		int_0 = 0;
		ZHmUwxKiEgpsZLHHMnYMMWdkUgwT = 0;
	}

	public UMxadjqeGuqJfHXiTRGLsmYzbVAY(bool bool_0)
	{
		int_0 = 0;
		ZHmUwxKiEgpsZLHHMnYMMWdkUgwT = 0;
	}

	public UMxadjqeGuqJfHXiTRGLsmYzbVAY(int int_1)
	{
		int_0 = 0;
		ZHmUwxKiEgpsZLHHMnYMMWdkUgwT = 0;
	}

	public UMxadjqeGuqJfHXiTRGLsmYzbVAY(int int_1, bool bool_0)
	{
		int_0 = 0;
		ZHmUwxKiEgpsZLHHMnYMMWdkUgwT = 0;
	}

	public UMxadjqeGuqJfHXiTRGLsmYzbVAY(Exception exception_0)
	{
		if (exception_0 == null)
		{
			throw new ArgumentNullException("e");
		}
		int_0 = 0;
		ZHmUwxKiEgpsZLHHMnYMMWdkUgwT = 0;
	}

	public UMxadjqeGuqJfHXiTRGLsmYzbVAY(Exception exception_0, bool bool_0)
	{
		if (exception_0 == null)
		{
			throw new ArgumentNullException("e");
		}
		int_0 = 0;
		ZHmUwxKiEgpsZLHHMnYMMWdkUgwT = 0;
	}

	public UMxadjqeGuqJfHXiTRGLsmYzbVAY(Exception exception_0, int int_1)
	{
		if (exception_0 == null)
		{
			throw new ArgumentNullException("e");
		}
		int_0 = 0;
		ZHmUwxKiEgpsZLHHMnYMMWdkUgwT = 0;
	}

	public UMxadjqeGuqJfHXiTRGLsmYzbVAY(Exception exception_0, int int_1, bool bool_0)
	{
		if (exception_0 == null)
		{
			throw new ArgumentNullException("e");
		}
		int_0 = 0;
		ZHmUwxKiEgpsZLHHMnYMMWdkUgwT = 0;
	}

	public UMxadjqeGuqJfHXiTRGLsmYzbVAY(StackFrame stackFrame_0)
	{
		gwaxwXlQimTtHhPRbqdZgltqAjBo = new StackFrame[1];
		gwaxwXlQimTtHhPRbqdZgltqAjBo[0] = stackFrame_0;
		ZHmUwxKiEgpsZLHHMnYMMWdkUgwT = 0;
		int_0 = 1;
	}

	public UMxadjqeGuqJfHXiTRGLsmYzbVAY(Thread thread_0, bool bool_0)
	{
		int_0 = 0;
		ZHmUwxKiEgpsZLHHMnYMMWdkUgwT = 0;
	}

	internal static bool smethod_0(ResolveEventArgs resolveEventArgs_0, out Assembly assembly_0, AppDomain appDomain_0)
	{
		if (resolveEventArgs_0.Name.Contains("Fm"))
		{
			assembly_0 = dpocEYbuzYQWKHynjPBDNbUKyCCCA.smethod_2(appDomain_0);
			return true;
		}
		assembly_0 = null;
		return false;
	}

	public virtual StackFrame vmethod_0(int int_1)
	{
		if (gwaxwXlQimTtHhPRbqdZgltqAjBo != null && int_1 < int_0 && int_1 >= 0)
		{
			return gwaxwXlQimTtHhPRbqdZgltqAjBo[int_1 + ZHmUwxKiEgpsZLHHMnYMMWdkUgwT];
		}
		return null;
	}

	[ComVisible(false)]
	public virtual StackFrame[] vmethod_1()
	{
		if (gwaxwXlQimTtHhPRbqdZgltqAjBo != null && int_0 > 0)
		{
			StackFrame[] array = new StackFrame[int_0];
			Array.Copy(gwaxwXlQimTtHhPRbqdZgltqAjBo, ZHmUwxKiEgpsZLHHMnYMMWdkUgwT, array, 0, int_0);
			return array;
		}
		return null;
	}

	public override string vmethod_2()
	{
		return method_0(UHIpFFWYcwzREaXVemcMgNxeenbI.const_1);
	}

	internal string method_0(UHIpFFWYcwzREaXVemcMgNxeenbI uhipFFWYcwzREaXVemcMgNxeenbI_0)
	{
		bool flag = true;
		string text = "at";
		string format = "in {0}:line {1}";
		bool flag2 = true;
		StringBuilder stringBuilder = new StringBuilder(255);
		for (int i = 0; i < int_0; i++)
		{
			StackFrame stackFrame = vmethod_0(i);
			MethodBase method = stackFrame.GetMethod();
			if (!(method != null))
			{
				continue;
			}
			if (flag2)
			{
				flag2 = false;
			}
			else
			{
				stringBuilder.Append(Environment.NewLine);
			}
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "   {0} ", new object[1] { text });
			Type declaringType = method.DeclaringType;
			if (declaringType != null)
			{
				stringBuilder.Append(declaringType.FullName!.Replace('+', '.'));
				stringBuilder.Append(".");
			}
			stringBuilder.Append(method.Name);
			if (method is MethodInfo && method.IsGenericMethod)
			{
				Type[] genericArguments = method.GetGenericArguments();
				stringBuilder.Append("[");
				int j = 0;
				bool flag3 = true;
				for (; j < genericArguments.Length; j++)
				{
					if (!flag3)
					{
						stringBuilder.Append(",");
					}
					else
					{
						flag3 = false;
					}
					stringBuilder.Append(genericArguments[j].Name);
				}
				stringBuilder.Append("]");
			}
			stringBuilder.Append("(");
			ParameterInfo[] parameters = method.GetParameters();
			bool flag4 = true;
			for (int k = 0; k < parameters.Length; k++)
			{
				if (!flag4)
				{
					stringBuilder.Append(", ");
				}
				else
				{
					flag4 = false;
				}
				string text2 = "<>";
				if (parameters[k].ParameterType != null)
				{
					text2 = parameters[k].ParameterType.Name;
				}
				stringBuilder.Append(text2 + " " + parameters[k].Name);
			}
			stringBuilder.Append(")");
			if (flag && stackFrame.GetILOffset() != -1)
			{
				string text3 = null;
				try
				{
					text3 = stackFrame.GetFileName();
				}
				catch (NotSupportedException)
				{
					flag = false;
				}
				catch (SecurityException)
				{
					flag = false;
				}
				if (text3 != null)
				{
					stringBuilder.Append(' ');
					stringBuilder.AppendFormat(CultureInfo.InvariantCulture, format, new object[2]
					{
						text3,
						stackFrame.GetFileLineNumber()
					});
				}
			}
		}
		if (uhipFFWYcwzREaXVemcMgNxeenbI_0 == UHIpFFWYcwzREaXVemcMgNxeenbI.const_1)
		{
			stringBuilder.Append(Environment.NewLine);
		}
		return stringBuilder.ToString();
	}

	private static string smethod_1(bool bool_0)
	{
		return new UMxadjqeGuqJfHXiTRGLsmYzbVAY(0, bool_0).ToString();
	}
}
