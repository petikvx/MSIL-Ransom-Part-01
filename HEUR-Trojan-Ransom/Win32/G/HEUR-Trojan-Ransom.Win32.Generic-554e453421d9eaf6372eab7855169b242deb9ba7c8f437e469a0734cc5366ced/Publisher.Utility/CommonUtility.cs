using System;
using System.IO;
using System.Net;
using System.Net.Configuration;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace Publisher.Utility;

internal class CommonUtility
{
	public static bool SetAllowUnsafeHeaderParsing20()
	{
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool result = default(bool);
		bool result2 = default(bool);
		Type type = default(Type);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		object obj = default(object);
		bool flag5 = default(bool);
		bool flag6 = default(bool);
		FieldInfo field = default(FieldInfo);
		bool flag7 = default(bool);
		bool flag8 = default(bool);
		while (true)
		{
			Assembly assembly = (Assembly)UDT0mkUZZRWQElm1lJ(typeof(SettingsSection));
			int num = 10;
			if (!nQvs09aZ2SNo6usBjn())
			{
				while (true)
				{
					switch (num)
					{
					case 2:
					case 13:
						flag2 = flag;
						num = 18;
						if (rH9LeUFvCExqMmFcBI())
						{
							continue;
						}
						goto IL_0114;
					case 10:
						flag = (object)assembly != null;
						_ = 1;
						if (!nQvs09aZ2SNo6usBjn())
						{
							goto case 2;
						}
						goto IL_00b3;
					case 6:
						break;
					case 18:
						goto IL_00b0;
					case 0:
					case 4:
						goto IL_00b3;
					case 19:
						goto IL_00c0;
					case 20:
						goto IL_00c7;
					case 9:
						goto IL_00cb;
					case 3:
						goto IL_00cf;
					case 7:
						goto IL_00f1;
					default:
						goto IL_00f5;
					case 1:
						goto IL_00f9;
					case 11:
						goto IL_0110;
					case 16:
						goto IL_0114;
					case 15:
						goto IL_0118;
					case 5:
						goto IL_0127;
					case 17:
						goto IL_0129;
					case 14:
						goto end_IL_008b;
					case 8:
					case 21:
						return result;
					}
					break;
				}
				continue;
			}
			goto IL_00b0;
			IL_012e:
			result2 = false;
			break;
			IL_00b0:
			if (flag2)
			{
				goto IL_00b3;
			}
			goto IL_012e;
			IL_00b3:
			type = jQZr1PbDUNVRToSDkI(assembly, "System.Net.Configuration.SettingsSectionInternal");
			goto IL_00c0;
			IL_00c0:
			flag3 = (object)type != null;
			goto IL_00c7;
			IL_00c7:
			flag4 = flag3;
			goto IL_00cb;
			IL_00cb:
			if (flag4)
			{
				goto IL_00cf;
			}
			goto IL_012e;
			IL_00cf:
			obj = type.InvokeMember("Section", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetProperty, null, null, new object[0]);
			flag5 = obj != null;
			goto IL_00f1;
			IL_00f1:
			flag6 = flag5;
			goto IL_00f5;
			IL_00f5:
			if (flag6)
			{
				goto IL_00f9;
			}
			goto IL_012e;
			IL_00f9:
			field = type.GetField("useUnsafeHeaderParsing", BindingFlags.Instance | BindingFlags.NonPublic);
			flag7 = (object)field != null;
			goto IL_0110;
			IL_0110:
			flag8 = flag7;
			goto IL_0114;
			IL_0114:
			if (flag8)
			{
				goto IL_0118;
			}
			goto IL_012e;
			IL_0118:
			field.SetValue(obj, true);
			goto IL_0127;
			IL_0127:
			result2 = true;
			goto IL_0129;
			IL_0129:
			return result2;
			continue;
			end_IL_008b:
			break;
		}
		return result2;
	}

	public static string GetCountryByIP()
	{
		try
		{
			WebClient object_ = new WebClient();
			string object_2 = (string)J1C3DFsBUp1K1crULK(object_, "http://freegeoip.net/xml/");
			byte[] buffer = (byte[])yRv56mGvB3GM9U2Okr(TGgoPLilE6OVBqGS4g(), object_2);
			ResponseLocation object_3 = null;
			XmlSerializer object_4 = new XmlSerializer(ECJtsgM31tVs5jOAQL(typeof(ResponseLocation).TypeHandle));
			MemoryStream memoryStream = new MemoryStream(buffer);
			try
			{
				object_3 = (ResponseLocation)Yl5DWnDBt7o06sr3wq(object_4, memoryStream);
			}
			finally
			{
				if (memoryStream != null)
				{
					kuhHTTHg3s1skwhuRn(memoryStream);
				}
			}
			return (string)ylOje2zb0YsdyADFfK(object_3);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public CommonUtility()
	{
		WABRyXNJbV0IJLqDIR8(this);
	}

	internal static object UDT0mkUZZRWQElm1lJ(Type type_0)
	{
		return Assembly.GetAssembly(type_0);
	}

	internal static Type jQZr1PbDUNVRToSDkI(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetType((string)object_1);
	}

	internal static bool rH9LeUFvCExqMmFcBI()
	{
		return true;
	}

	internal static bool nQvs09aZ2SNo6usBjn()
	{
		return false;
	}

	internal static object J1C3DFsBUp1K1crULK(object object_0, object object_1)
	{
		return ((WebClient)object_0).DownloadString((string)object_1);
	}

	internal static object TGgoPLilE6OVBqGS4g()
	{
		return Encoding.ASCII;
	}

	internal static object yRv56mGvB3GM9U2Okr(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetBytes((string)object_1);
	}

	internal static Type ECJtsgM31tVs5jOAQL(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object Yl5DWnDBt7o06sr3wq(object object_0, object object_1)
	{
		return ((XmlSerializer)object_0).Deserialize((Stream)object_1);
	}

	internal static void kuhHTTHg3s1skwhuRn(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static object ylOje2zb0YsdyADFfK(object object_0)
	{
		return ((ResponseLocation)object_0).CountryCode;
	}

	internal static void WABRyXNJbV0IJLqDIR8(object object_0)
	{
		object_0._002Ector();
	}
}
