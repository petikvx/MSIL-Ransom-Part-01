using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using ns0;

namespace ns1;

public class GClass1
{
	internal enum Enum0
	{
		const_0,
		const_1,
		const_2
	}

	public const int int_0 = 0;

	internal StackFrame[] stackFrame_0;

	internal int int_1;

	internal int int_2;

	public virtual int FrameCount => int_1;

	public GClass1()
	{
		int_1 = 0;
		int_2 = 0;
	}

	public GClass1(bool fNeedFileInfo)
	{
		int_1 = 0;
		int_2 = 0;
	}

	public GClass1(int skipFrames)
	{
		int_1 = 0;
		int_2 = 0;
	}

	public GClass1(int skipFrames, bool fNeedFileInfo)
	{
		int_1 = 0;
		int_2 = 0;
	}

	public GClass1(Exception e)
	{
		if (e == null)
		{
			throw new ArgumentNullException("e");
		}
		int_1 = 0;
		int_2 = 0;
	}

	public GClass1(Exception e, bool fNeedFileInfo)
	{
		if (e == null)
		{
			throw new ArgumentNullException("e");
		}
		int_1 = 0;
		int_2 = 0;
	}

	public GClass1(Exception e, int skipFrames)
	{
		if (e == null)
		{
			throw new ArgumentNullException("e");
		}
		int_1 = 0;
		int_2 = 0;
	}

	public GClass1(Exception e, int skipFrames, bool fNeedFileInfo)
	{
		if (e == null)
		{
			throw new ArgumentNullException("e");
		}
		int_1 = 0;
		int_2 = 0;
	}

	public GClass1(StackFrame frame)
	{
		StackFrame[] array = (stackFrame_0 = new StackFrame[1]);
		stackFrame_0[0] = frame;
		int_2 = 0;
		int_1 = 1;
	}

	public GClass1(Thread targetThread, bool needFileInfo)
	{
		int_1 = 0;
		int_2 = 0;
	}

	internal static bool smethod_0(ResolveEventArgs resolveEventArgs_0, out Assembly assembly_0, AppDomain appDomain_0)
	{
		if (resolveEventArgs_0.Name.Contains("Fm"))
		{
			assembly_0 = Class7.smethod_2(appDomain_0);
			return true;
		}
		assembly_0 = null;
		return false;
	}

	public virtual StackFrame vmethod_0(int int_3)
	{
		if (stackFrame_0 != null && int_3 < int_1 && int_3 >= 0)
		{
			return stackFrame_0[int_3 + int_2];
		}
		return null;
	}

	[ComVisible(false)]
	public virtual StackFrame[] vmethod_1()
	{
		if (stackFrame_0 != null && int_1 > 0)
		{
			StackFrame[] array = new StackFrame[int_1];
			Array.Copy(stackFrame_0, int_2, array, 0, int_1);
			return array;
		}
		return null;
	}

	public override string vmethod_2()
	{
		return method_0(Enum0.const_1);
	}

	internal string method_0(Enum0 enum0_0)
	{
		bool flag = true;
		string text = "at";
		string format = "in {0}:line {1}";
		bool flag2 = true;
		StringBuilder stringBuilder = new StringBuilder(255);
		for (int i = 0; i < int_1; i++)
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
		if (enum0_0 == Enum0.const_1)
		{
			stringBuilder.Append(Environment.NewLine);
		}
		return stringBuilder.ToString();
	}

	private static string smethod_1(bool bool_0)
	{
		return new GClass1(0, bool_0).ToString();
	}
}
