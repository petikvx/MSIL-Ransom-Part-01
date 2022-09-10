using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using ns2;
using ns3;

namespace ns4;

[GAttribute0(29)]
public abstract class GClass2
{
	private char[] char_0 = new char[58]
	{
		'\u0001', '\u0002', '\u0003', '\u0004', '\u0005', '\u0006', '\a', '\b', '\u000e', '\u000f',
		'\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019',
		'\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', '\u007f', '\u0080', '\u0081', '\u0082',
		'\u0083', '\u0084', '\u0086', '\u0087', '\u0088', '\u0089', '\u008a', '\u008b', '\u008c', '\u008d',
		'\u008e', '\u008f', '\u0090', '\u0091', '\u0092', '\u0093', '\u0094', '\u0095', '\u0096', '\u0097',
		'\u0098', '\u0099', '\u009a', '\u009b', '\u009c', '\u009d', '\u009e', '\u009f'
	};

	internal static bool bool_0 = false;

	private static GClass2 gclass2_0 = null;

	private Exception exception_0 = null;

	private Hashtable hashtable_0 = null;

	private XmlTextWriter xmlTextWriter_0 = null;

	private ArrayList arrayList_0 = new ArrayList();

	private ArrayList arrayList_1 = new ArrayList();

	private Hashtable hashtable_1 = new Hashtable();

	private EventHandler eventHandler_0;

	private GDelegate0 gdelegate0_0;

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_0(EventHandler eventHandler_1)
	{
		eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, eventHandler_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_1(GDelegate0 gdelegate0_1)
	{
		gdelegate0_0 = (GDelegate0)Delegate.Combine(gdelegate0_0, gdelegate0_1);
	}

	protected abstract void vmethod_0(GEventArgs1 geventArgs1_0);

	protected abstract void vmethod_1(GEventArgs0 geventArgs0_0);

	protected abstract void vmethod_2(GEventArgs2 geventArgs2_0);

	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\n               version=\"1\">\r\n   <IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\n                version=\"1\"\r\n                Flags=\"UnmanagedCode\"/>\r\n</PermissionSet>\r\n")]
	public static void smethod_0(GClass2 gclass2_1)
	{
		if (gclass2_1 != null)
		{
			gclass2_0 = gclass2_1;
			AppDomain.CurrentDomain.UnhandledException += gclass2_1.method_3;
			Application.add_ThreadException((ThreadExceptionEventHandler)gclass2_1.method_2);
		}
	}

	public static void smethod_1(Exception exception_1, int int_0, object[] object_0)
	{
		try
		{
			if (exception_1 == null || !(exception_1 is SecurityException) || !gclass2_0.method_18((SecurityException)exception_1))
			{
				gclass2_0.method_19(GException0.smethod_11(exception_1, int_0, object_0), bool_1: false);
			}
		}
		catch
		{
			Application.Exit();
		}
	}

	private void method_2(object sender, ThreadExceptionEventArgs e)
	{
		try
		{
			if (!(e.Exception is SecurityException) || !method_18(e.Exception as SecurityException))
			{
				method_19(e.Exception, bool_1: true);
			}
		}
		catch
		{
		}
	}

	private void method_3(object sender, UnhandledExceptionEventArgs e)
	{
		try
		{
			if ((!(e.ExceptionObject is SecurityException) || !method_18(e.ExceptionObject as SecurityException)) && e.ExceptionObject is Exception)
			{
				method_19((Exception)e.ExceptionObject, bool_1: true);
			}
		}
		catch
		{
		}
	}

	private string method_4(object object_0)
	{
		try
		{
			if (object_0 == null)
			{
				return string.Empty;
			}
			if (object_0 is int)
			{
				int num = (int)object_0;
				return num.ToString("");
			}
			if (object_0 is long)
			{
				long num2 = (long)object_0;
				return num2.ToString("");
			}
			if (object_0 is short)
			{
				short num3 = (short)object_0;
				return num3.ToString("");
			}
			if (object_0 is uint)
			{
				uint num4 = (uint)object_0;
				return num4.ToString("");
			}
			if (object_0 is ulong)
			{
				ulong num5 = (ulong)object_0;
				return num5.ToString("");
			}
			if (object_0 is ushort)
			{
				ushort num6 = (ushort)object_0;
				return num6.ToString("");
			}
			if (object_0 is byte)
			{
				byte b = (byte)object_0;
				return b.ToString("");
			}
			if (object_0 is sbyte)
			{
				sbyte b2 = (sbyte)object_0;
				return b2.ToString("");
			}
			if (object_0 is IntPtr)
			{
				IntPtr intPtr = (IntPtr)object_0;
				return intPtr.ToInt64().ToString("");
			}
			if (object_0 is UIntPtr)
			{
				UIntPtr uIntPtr = (UIntPtr)object_0;
				return uIntPtr.ToUInt64().ToString("");
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	private string method_5(string string_0)
	{
		if (string_0.StartsWith("㰢卒䭁祥慖畬㹥") && string_0.EndsWith("⼼卒䭁祥慖畬㹥"))
		{
			return "⨪\u202a湉潦浲瑡潩\u206e潮⁴敲潰瑲摥映牯猠捥牵瑩⁹敲獡湯\u2073⨪";
		}
		return string_0;
	}

	private void method_6(object object_0, FieldInfo fieldInfo_0)
	{
		string text = fieldInfo_0?.Name;
		string localName = (((object)fieldInfo_0 == null) ? "扏敪瑣" : "楆汥");
		if (object_0 == null)
		{
			xmlTextWriter_0.WriteStartElement(localName);
			if ((object)fieldInfo_0 != null)
			{
				if (fieldInfo_0.IsStatic)
				{
					xmlTextWriter_0.WriteAttributeString("瑓瑡捩", "");
				}
				Type fieldType = fieldInfo_0.FieldType;
				if ((object)fieldType != null && fieldType.HasElementType)
				{
					method_8(fieldType.GetElementType());
					if (fieldType.IsByRef)
					{
						xmlTextWriter_0.WriteAttributeString("祂敒", "");
					}
					if (fieldType.IsPointer)
					{
						xmlTextWriter_0.WriteAttributeString("潐湩整", "");
					}
					if (fieldType.IsArray)
					{
						xmlTextWriter_0.WriteAttributeString("慒歮", fieldType.GetArrayRank().ToString());
					}
				}
				else
				{
					method_8(fieldType);
				}
			}
			if (text != null)
			{
				method_7(text);
			}
			xmlTextWriter_0.WriteAttributeString("畎汬", "");
			xmlTextWriter_0.WriteEndElement();
			return;
		}
		Type type = object_0.GetType();
		string text2 = null;
		string text3 = null;
		if (object_0 is string)
		{
			text2 = "祓瑳浥匮牴湩";
		}
		if (text2 == null)
		{
			if (!type.IsPrimitive && !(object_0 is IntPtr) && !(object_0 is UIntPtr))
			{
				if (type.IsValueType && (object)type.Module != GetType().Module)
				{
					text2 = type.FullName;
				}
			}
			else
			{
				text2 = type.FullName;
				if (object_0 is char)
				{
					int num = (char)object_0;
					StringBuilder stringBuilder = new StringBuilder();
					if (num >= 32)
					{
						stringBuilder.Append('\'');
						stringBuilder.Append((char)object_0);
						stringBuilder.Append("‧");
					}
					stringBuilder.Append("〨");
					stringBuilder.Append(num.ToString(""));
					stringBuilder.Append(')');
					text3 = stringBuilder.ToString();
				}
				if (object_0 is bool)
				{
					text3 = object_0.ToString()!.ToLower();
				}
				if (text3 == null)
				{
					string text4 = string.Empty;
					try
					{
						text4 = method_4(object_0);
					}
					catch
					{
					}
					if (text4.Length > 0)
					{
						StringBuilder stringBuilder2 = new StringBuilder();
						stringBuilder2.Append(object_0.ToString());
						stringBuilder2.Append("⠠砰");
						stringBuilder2.Append(text4);
						stringBuilder2.Append(')');
						text3 = stringBuilder2.ToString();
					}
					else
					{
						text3 = object_0.ToString();
					}
				}
			}
		}
		if (text2 != null)
		{
			xmlTextWriter_0.WriteStartElement(localName);
			if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
			{
				xmlTextWriter_0.WriteAttributeString("瑓瑡捩", "");
			}
			method_8(type);
			if (text != null)
			{
				method_7(text);
			}
			if (type.IsEnum)
			{
				text3 = object_0.ToString();
			}
			if (object_0 is Guid)
			{
				text3 = "" + object_0.ToString() + "";
			}
			if (text3 == null)
			{
				text3 = "" + object_0.ToString() + "";
			}
			xmlTextWriter_0.WriteAttributeString("慖畬", method_5(text3));
			xmlTextWriter_0.WriteEndElement();
			return;
		}
		xmlTextWriter_0.WriteStartElement(localName);
		if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
		{
			xmlTextWriter_0.WriteAttributeString("瑓瑡捩", "");
		}
		int num2 = -1;
		for (int i = 0; i < arrayList_0.Count; i++)
		{
			try
			{
				if (arrayList_0[i]!.Equals(object_0))
				{
					num2 = i;
					break;
				}
			}
			catch
			{
			}
		}
		if (num2 == -1)
		{
			num2 = arrayList_0.Add(object_0);
		}
		xmlTextWriter_0.WriteAttributeString("䑉", num2.ToString());
		if (text != null)
		{
			method_7(text);
		}
		xmlTextWriter_0.WriteEndElement();
	}

	private void method_7(string string_0)
	{
		int num = method_9(string_0);
		if (num != -1)
		{
			xmlTextWriter_0.WriteAttributeString("慎敭䑉", num.ToString());
		}
		else
		{
			xmlTextWriter_0.WriteAttributeString("慎敭", string_0);
		}
	}

	private void method_8(Type type_0)
	{
		if ((object)type_0 == null)
		{
			return;
		}
		try
		{
			object[] array = null;
			try
			{
				array = type_0.GetCustomAttributes(typeof(GAttribute0), inherit: false);
			}
			catch
			{
			}
			if (array != null && array.Length > 0)
			{
				xmlTextWriter_0.WriteAttributeString("祔数敄䥦", ((GAttribute0)array[0]).int_0.ToString());
				return;
			}
			int num = -1;
			string fullName = type_0.FullName;
			if (hashtable_1.ContainsKey(fullName))
			{
				num = (int)hashtable_1[fullName];
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				string name = type_0.Assembly.GetName().Name;
				if (name.Length > 0 && name != "獭潣汲扩")
				{
					stringBuilder.Append('[');
					stringBuilder.Append(name);
					stringBuilder.Append(']');
				}
				string @namespace = type_0.Namespace;
				if (@namespace.Length > 0)
				{
					stringBuilder.Append(@namespace);
					stringBuilder.Append('.');
				}
				if (type_0.HasElementType)
				{
					type_0 = type_0.GetElementType();
				}
				int num2 = fullName.LastIndexOf("");
				if (num2 > 0)
				{
					string value = fullName.Substring(@namespace.Length + 1, num2 - @namespace.Length).Replace("", "");
					stringBuilder.Append(value);
				}
				stringBuilder.Append(type_0.Name);
				num = arrayList_1.Add(stringBuilder.ToString());
				hashtable_1.Add(fullName, num);
			}
			xmlTextWriter_0.WriteAttributeString("祔数慎敭", num.ToString());
		}
		catch
		{
		}
	}

	private int method_9(string string_0)
	{
		try
		{
			if (string_0 != null && string_0.Length != 0 && string_0.Length <= 4)
			{
				int num = 0;
				int num2 = string_0.Length - 1;
				while (true)
				{
					if (num2 >= 0)
					{
						char c = string_0[num2];
						bool flag = false;
						for (int i = 0; i < char_0.Length; i++)
						{
							if (char_0[i] == c)
							{
								num = num * char_0.Length + i;
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							break;
						}
						num2--;
						continue;
					}
					return num;
				}
				return -1;
			}
			return -1;
		}
		catch
		{
			return -1;
		}
	}

	protected virtual Guid vmethod_3()
	{
		return Guid.Empty;
	}

	private string method_10()
	{
		try
		{
			return Application.get_ExecutablePath();
		}
		catch
		{
			return "⽎";
		}
	}

	private Assembly[] method_11()
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { method_12() };
		}
	}

	private Assembly method_12()
	{
		try
		{
			return Assembly.GetExecutingAssembly();
		}
		catch
		{
			return null;
		}
	}

	private byte[] method_13(string string_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		xmlTextWriter_0 = new XmlTextWriter(memoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		xmlTextWriter_0.WriteStartDocument();
		xmlTextWriter_0.WriteStartElement("湕慨摮敬䕤捸灥楴湯敒潰瑲");
		xmlTextWriter_0.WriteAttributeString("獁敳扭祬䑉", "䉻䑃い䔱ⴶㄲ㐵㐭㜷ⴷ䈹㍆㠭㔹㘲䌱䔹〰紷".ToUpper());
		xmlTextWriter_0.WriteAttributeString("慄整楔敭", DateTime.Now.ToString(""));
		xmlTextWriter_0.WriteAttributeString("慐桴", method_10());
		Guid guid = vmethod_3();
		if (guid != Guid.Empty)
		{
			xmlTextWriter_0.WriteAttributeString("獕牥䑉", guid.ToString(""));
		}
		if (string_0.Length > 0)
		{
			xmlTextWriter_0.WriteAttributeString("敒潰瑲䑉", string_0);
		}
		xmlTextWriter_0.WriteStartElement("獁敳扭楬獥");
		Assembly assembly = method_12();
		Assembly[] array = method_11();
		foreach (Assembly assembly2 in array)
		{
			if ((object)assembly2 == null)
			{
				continue;
			}
			xmlTextWriter_0.WriteStartElement("獁敳扭祬");
			try
			{
				xmlTextWriter_0.WriteAttributeString("慎敭", assembly2.FullName);
				xmlTextWriter_0.WriteAttributeString("潃敤慂敳", assembly2.CodeBase);
				if ((object)assembly2 == assembly)
				{
					xmlTextWriter_0.WriteAttributeString("桔獩", "");
				}
			}
			catch
			{
			}
			xmlTextWriter_0.WriteEndElement();
		}
		xmlTextWriter_0.WriteEndElement();
		xmlTextWriter_0.WriteStartElement("畃瑳浯牐灯牥楴獥");
		if (hashtable_0 != null && hashtable_0.Count > 0)
		{
			foreach (string key in hashtable_0.Keys)
			{
				xmlTextWriter_0.WriteStartElement("畃瑳浯牐灯牥祴");
				xmlTextWriter_0.WriteAttributeString("慎敭", key);
				string text2 = (string)hashtable_0[key];
				if (text2 == null)
				{
					xmlTextWriter_0.WriteAttributeString("畎汬", "");
				}
				else
				{
					xmlTextWriter_0.WriteAttributeString("慖畬", "" + text2 + "");
				}
				xmlTextWriter_0.WriteEndElement();
			}
		}
		xmlTextWriter_0.WriteEndElement();
		xmlTextWriter_0.WriteStartElement("祓瑳浥湉潦浲瑡潩");
		try
		{
			xmlTextWriter_0.WriteElementString("协敖獲潩", Environment.OSVersion.Version.ToString());
			xmlTextWriter_0.WriteElementString("协汐瑡潦浲䑉", Environment.OSVersion.Platform.ToString());
			xmlTextWriter_0.WriteElementString("敓癲捩健捡", GClass4.smethod_2());
		}
		catch
		{
		}
		xmlTextWriter_0.WriteEndElement();
		ArrayList arrayList = new ArrayList();
		for (Exception innerException = exception_0; innerException != null; innerException = innerException.InnerException)
		{
			if (innerException is GException0)
			{
				arrayList.Add(innerException);
			}
			else
			{
				arrayList.Insert(0, innerException);
			}
		}
		xmlTextWriter_0.WriteStartElement("瑓捡呫慲散");
		int count = arrayList.Count;
		int num = 0;
		foreach (Exception item in arrayList)
		{
			num++;
			if (num > 100 && num == count - 100)
			{
				xmlTextWriter_0.WriteStartElement("敒潭敶䙤慲敭");
				xmlTextWriter_0.WriteAttributeString("潔慴䙬慲敭䍳畯瑮", count.ToString());
				xmlTextWriter_0.WriteEndElement();
			}
			else
			{
				if (num > 100 && num <= count - 100)
				{
					continue;
				}
				if (item is GException0)
				{
					if (item is GException0 gException)
					{
						xmlTextWriter_0.WriteStartElement("瑓捡䙫慲敭");
						xmlTextWriter_0.WriteAttributeString("敍桴摯䑉", gException.int_0.ToString());
						int int_ = gException.int_1;
						if (int_ != -1)
						{
							xmlTextWriter_0.WriteAttributeString("䱉晏獦瑥", int_.ToString());
						}
						object[] object_ = gException.object_0;
						foreach (object object_2 in object_)
						{
							method_6(object_2, null);
						}
						xmlTextWriter_0.WriteEndElement();
					}
					continue;
				}
				xmlTextWriter_0.WriteStartElement("硅散瑰潩");
				try
				{
					method_8(((object)item).GetType());
					string value = "⽎";
					try
					{
						value = item.Message;
					}
					catch
					{
					}
					xmlTextWriter_0.WriteAttributeString("敍獳条", value);
					string text3 = item.StackTrace!.Trim();
					xmlTextWriter_0.WriteAttributeString("硅散瑰潩卮慴正牔捡", text3);
					int num2 = text3.IndexOf(' ');
					text3 = text3.Substring(num2 + 1);
					num2 = text3.IndexOf("\u0a0d");
					if (num2 != -1)
					{
						text3 = text3.Substring(0, num2);
					}
					xmlTextWriter_0.WriteAttributeString("敍桴摯", text3);
				}
				catch
				{
				}
				xmlTextWriter_0.WriteEndElement();
			}
		}
		xmlTextWriter_0.WriteEndElement();
		xmlTextWriter_0.WriteStartElement("扏敪瑣");
		int count2 = arrayList_0.Count;
		for (int j = 0; j < arrayList_0.Count; j++)
		{
			object obj5 = arrayList_0[j];
			Type type = obj5.GetType();
			xmlTextWriter_0.WriteStartElement("扏敪瑣敄");
			xmlTextWriter_0.WriteAttributeString("䑉", j.ToString());
			string text4 = null;
			try
			{
				text4 = obj5.ToString();
				text4 = ((text4 == type.FullName) ? null : (type.IsEnum ? Enum.Format(type, obj5, "") : ((!(obj5 is Guid)) ? ("" + text4 + "") : ("" + text4 + ""))));
			}
			catch
			{
			}
			if (text4 != null)
			{
				xmlTextWriter_0.WriteAttributeString("慖畬", method_5(text4));
			}
			if (type.HasElementType)
			{
				method_8(type.GetElementType());
				if (type.IsByRef)
				{
					xmlTextWriter_0.WriteAttributeString("祂敒", "");
				}
				if (type.IsPointer)
				{
					xmlTextWriter_0.WriteAttributeString("潐湩整", "");
				}
				if (type.IsArray)
				{
					Array array2 = (Array)obj5;
					xmlTextWriter_0.WriteAttributeString("慒歮", array2.Rank.ToString());
					StringBuilder stringBuilder = new StringBuilder();
					for (int k = 0; k < array2.Rank; k++)
					{
						if (k > 0)
						{
							stringBuilder.Append(',');
						}
						stringBuilder.Append(array2.GetLength(k));
					}
					xmlTextWriter_0.WriteAttributeString("敌杮桴", stringBuilder.ToString());
					if (array2.Rank == 1)
					{
						int length = array2.Length;
						for (int l = 0; l < length; l++)
						{
							if (l == 10 && length > 16)
							{
								l = length - 5;
							}
							try
							{
								method_6(array2.GetValue(l), null);
							}
							catch
							{
							}
						}
					}
				}
			}
			else
			{
				method_8(type);
				if (j < count2)
				{
					bool flag = true;
					while ((object)type != null)
					{
						if (!flag)
						{
							xmlTextWriter_0.WriteStartElement("慂敳祔数敄");
							method_8(type);
							xmlTextWriter_0.WriteEndElement();
						}
						FieldInfo[] fields = type.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
						if (fields.Length > 0)
						{
							for (int m = 0; m < fields.Length; m++)
							{
								try
								{
									if (!fields[m].IsLiteral && (!fields[m].IsStatic || !fields[m].IsInitOnly))
									{
										method_6(fields[m].GetValue(obj5), fields[m]);
									}
								}
								catch
								{
								}
							}
						}
						type = type.BaseType;
						flag = false;
						object[] array3 = null;
						try
						{
							array3 = type.GetCustomAttributes(typeof(GAttribute0), inherit: false);
						}
						catch
						{
						}
						if (array3 == null || array3.Length == 0)
						{
							break;
						}
					}
				}
			}
			xmlTextWriter_0.WriteEndElement();
		}
		xmlTextWriter_0.WriteEndElement();
		xmlTextWriter_0.WriteStartElement("祔数慎敭");
		xmlTextWriter_0.WriteAttributeString("潃湵", arrayList_1.Count.ToString());
		for (int n = 0; n < arrayList_1.Count; n++)
		{
			string empty = string.Empty;
			try
			{
				empty = arrayList_1[n]!.ToString();
			}
			catch (Exception ex2)
			{
				empty = '"' + ex2.Message + '"';
			}
			xmlTextWriter_0.WriteElementString("祔数慎敭", empty);
		}
		xmlTextWriter_0.WriteEndElement();
		xmlTextWriter_0.WriteEndElement();
		xmlTextWriter_0.WriteEndDocument();
		xmlTextWriter_0.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	internal bool method_14(string string_0)
	{
		try
		{
			string string_ = Guid.NewGuid().ToString("");
			byte[] byte_ = method_13(string_);
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] byte_2 = Class3.smethod_0(byte_);
			byte[] array = Class1.smethod_0(byte_2, "刼䅓敋噹污敵㰾潍畤畬㹳ば摢圵楪啩儲佒煷䕂䵹䭘䥃祶剩慕㤲昱䌵琵獉祶串獓慈畭穸倴浬塩湫摹甫䅳乃协塇睕慨嘫䌲䭯偙㝤剳佐⭙睤呑䱡⬸䙭剫奢㍥㍶ぢ湑⽨㕌〵啃㕒ㅱ稴祧㑱䍙塌焹乥坲潊卺瑦㍳捧婱摒焫㍡扨䍙䝶歃潁㵕⼼潍畤畬㹳䔼灸湯湥㹴允䉁⼼硅潰敮瑮㰾刯䅓敋噹污敵");
			byte[] bytes = Encoding.ASCII.GetBytes("䉻䑃い䔱ⴶㄲ㐵㐭㜷ⴷ䈹㍆㠭㔹㘲䌱䔹〰紷");
			fileStream.Write(bytes, 0, bytes.Length);
			fileStream.Write(array, 0, array.Length);
			fileStream.Close();
			return true;
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	internal void method_15()
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			method_14(tempFileName);
			string text = method_17("慐桴");
			if (text.Length > 0 && !text.EndsWith(""))
			{
				text += "";
			}
			Process.Start(text + "獻慭瑲獡敳扭祬\u2e7d硥", "䄯摤硅散瑰潩剮灥牯⁴" + tempFileName + "");
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, EventArgs.Empty);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception exception_)
		{
			vmethod_1(new GEventArgs0(exception_));
		}
	}

	internal bool method_16()
	{
		try
		{
			if (gdelegate0_0 != null)
			{
				gdelegate0_0(this, new GEventArgs3(GEnum1.const_0));
			}
			byte[] array = null;
			try
			{
				array = method_13(string.Empty);
			}
			catch (Exception ex)
			{
				if (gdelegate0_0 != null)
				{
					gdelegate0_0(this, new GEventArgs3(GEnum1.const_0, "剅⁒〲㘰›" + ex.Message));
				}
				return false;
			}
			byte[] array2 = Class3.smethod_0(array);
			if (array2 == null)
			{
				if (gdelegate0_0 != null)
				{
					gdelegate0_0(this, new GEventArgs3(GEnum1.const_0, Class3.string_0));
				}
				return false;
			}
			byte[] array3 = Class1.smethod_0(array2, "刼䅓敋噹污敵㰾潍畤畬㹳ば摢圵楪啩儲佒煷䕂䵹䭘䥃祶剩慕㤲昱䌵琵獉祶串獓慈畭穸倴浬塩湫摹甫䅳乃协塇睕慨嘫䌲䭯偙㝤剳佐⭙睤呑䱡⬸䙭剫奢㍥㍶ぢ湑⽨㕌〵啃㕒ㅱ稴祧㑱䍙塌焹乥坲潊卺瑦㍳捧婱摒焫㍡扨䍙䝶歃潁㵕⼼潍畤畬㹳䔼灸湯湥㹴允䉁⼼硅潰敮瑮㰾刯䅓敋噹污敵");
			if (array3 == null)
			{
				if (gdelegate0_0 != null)
				{
					gdelegate0_0(this, new GEventArgs3(GEnum1.const_0, Class1.string_0));
				}
				return false;
			}
			if (gdelegate0_0 != null)
			{
				gdelegate0_0(this, new GEventArgs3(GEnum1.const_1));
			}
			Class9 @class = new Class9("ほ〰〰〰ⴰ〰〰\u302d〰ⴰ〰〰\u302d〰〰〰〰〰細");
			string text = @class.method_0();
			if (text == "䭏")
			{
				if (gdelegate0_0 != null)
				{
					gdelegate0_0(this, new GEventArgs3(GEnum1.const_2));
				}
				byte[] bytes = Encoding.ASCII.GetBytes("䉻䑃い䔱ⴶㄲ㐵㐭㜷ⴷ䈹㍆㠭㔹㘲䌱䔹〰紷");
				byte[] array4 = new byte[bytes.Length + array3.Length];
				Array.Copy(bytes, array4, bytes.Length);
				Array.Copy(array3, 0, array4, bytes.Length, array3.Length);
				string text2 = @class.method_1(array4);
				if (text2.StartsWith("剅"))
				{
					if (gdelegate0_0 != null)
					{
						gdelegate0_0(this, new GEventArgs3(GEnum1.const_2, text2));
					}
					return false;
				}
				if (gdelegate0_0 != null)
				{
					GEventArgs3 gEventArgs = new GEventArgs3(GEnum1.const_3);
					gEventArgs.method_3(text2);
					gdelegate0_0(this, gEventArgs);
				}
				return true;
			}
			string string_ = text;
			if (gdelegate0_0 != null)
			{
				gdelegate0_0(this, new GEventArgs3(GEnum1.const_1, string_));
			}
			return false;
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception exception_)
		{
			vmethod_1(new GEventArgs0(exception_));
			return false;
		}
	}

	private string method_17(string string_0)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("体呆䅗䕒筜浳牡慴獳浥汢絹");
			if (registryKey == null)
			{
				return string.Empty;
			}
			string result = (string)registryKey.GetValue(string_0, string.Empty);
			registryKey.Close();
			return result;
		}
		catch
		{
			return string.Empty;
		}
	}

	internal bool method_18(SecurityException securityException_0)
	{
		GEventArgs2 gEventArgs = new GEventArgs2(securityException_0);
		vmethod_2(gEventArgs);
		if (gEventArgs.method_5())
		{
			return false;
		}
		if (!gEventArgs.method_3())
		{
			Application.Exit();
		}
		return true;
	}

	internal void method_19(Exception exception_1, bool bool_1)
	{
		if (exception_1 == null || exception_1 is ThreadAbortException)
		{
			return;
		}
		bool_0 = true;
		bool flag = true;
		try
		{
			exception_0 = exception_1;
			hashtable_0 = null;
			GEventArgs1 gEventArgs = new GEventArgs1(this, exception_1);
			if ("ほ〰〰〰ⴰ〰〰\u302d〰ⴰ〰〰\u302d〰〰〰〰〰細".ToLower() == method_17("楌散獮䥥").ToLower())
			{
				gEventArgs.method_4();
			}
			string text = "ほ〰〰〰ⴰ〰〰\u302d〰ⴰ〰〰\u302d〰〰〰〰〰細".ToLower();
			Guid empty = Guid.Empty;
			if (text == empty.ToString("").ToLower())
			{
				gEventArgs.method_5();
			}
			if (!bool_1)
			{
				gEventArgs.method_6();
			}
			vmethod_0(gEventArgs);
			flag = !gEventArgs.method_7();
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception exception_2)
		{
			vmethod_1(new GEventArgs0(exception_2));
		}
		exception_0 = null;
		hashtable_0 = null;
		bool_0 = false;
		if (flag)
		{
			Application.Exit();
		}
	}
}
