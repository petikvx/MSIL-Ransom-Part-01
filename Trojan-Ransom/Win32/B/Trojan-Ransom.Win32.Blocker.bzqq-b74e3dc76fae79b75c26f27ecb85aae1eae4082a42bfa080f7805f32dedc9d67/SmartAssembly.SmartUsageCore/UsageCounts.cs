using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.SmartUsageCore;

public class UsageCounts
{
	internal ulong[] ulong_0;

	internal Dictionary<string, ulong> dictionary_0;

	public Dictionary<string, ulong> DynamicFeatureCounts
	{
		get
		{
			Dictionary<string, ulong> dictionary = default(Dictionary<string, ulong>);
			try
			{
				try
				{
					dictionary = dictionary_0;
					return dictionary;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, dictionary, this);
				throw;
			}
		}
	}

	public ulong[] StaticFeatureCounts
	{
		get
		{
			ulong[] array = default(ulong[]);
			try
			{
				try
				{
					array = ulong_0;
					return array;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, array, this);
				throw;
			}
		}
	}

	public bool IsEmpty
	{
		get
		{
			int num = default(int);
			bool flag = default(bool);
			try
			{
				try
				{
					num = 3;
					if (ulong_0.Length == 0)
					{
						flag = dictionary_0.Count == 0;
						return flag;
					}
					flag = false;
					return flag;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException3(exception2, flag, num, this);
				throw;
			}
		}
	}

	public UsageCounts(ulong[] staticFeatureCounts, Dictionary<string, ulong> dynamicFeatureCounts)
	{
		ulong[] o = default(ulong[]);
		Dictionary<string, ulong> o2 = default(Dictionary<string, ulong>);
		try
		{
			try
			{
				o = (ulong_0 = staticFeatureCounts);
				o2 = (dictionary_0 = dynamicFeatureCounts);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, this, staticFeatureCounts, dynamicFeatureCounts);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException5(exception2, o, o2, this, staticFeatureCounts, dynamicFeatureCounts);
			throw;
		}
	}

	static UsageCounts()
	{
		try
		{
			DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static int smethod_0(Version version_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 5:
					return version_0.Major;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, version_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_1(ButtonBase buttonBase_0, ContentAlignment contentAlignment_0, int int_0, int int_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		try
		{
			num = 4;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 110:
					buttonBase_0.set_ImageAlign(contentAlignment_0);
					return;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, buttonBase_0, contentAlignment_0, int_0, int_1);
			throw;
		}
	}

	internal static object smethod_2(MethodInfo methodInfo_0, object object_0, object[] object_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 51:
					return methodInfo_0.Invoke(object_0, object_1);
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num, methodInfo_0, object_0, object_1, int_0, int_1);
			throw;
		}
	}

	internal static Graphics smethod_3(Control control_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 118:
					return control_0.CreateGraphics();
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, control_0, int_0, int_1);
			throw;
		}
	}

	internal static Pen smethod_4(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 45:
					return SystemPens.get_ControlDark();
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_5(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 27:
					return Application.get_ExecutablePath();
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_6(Graphics graphics_0, Pen pen_0, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5)
	{
		int num = default(int);
		try
		{
			num = 1;
			while (true)
			{
				switch (int_5 ^ int_4)
				{
				case 21:
					graphics_0.DrawLine(pen_0, int_0, int_1, int_2, int_3);
					return;
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException10(exception, num, num2, graphics_0, pen_0, int_0, int_1, int_2, int_3, int_4, int_5);
			throw;
		}
	}

	internal static bool smethod_7(Type type_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 93:
					return type_0.HasElementType;
				case 94:
					return type_0.IsPointer;
				case 95:
					return type_0.IsEnum;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, type_0, int_0, int_1);
			throw;
		}
	}
}
