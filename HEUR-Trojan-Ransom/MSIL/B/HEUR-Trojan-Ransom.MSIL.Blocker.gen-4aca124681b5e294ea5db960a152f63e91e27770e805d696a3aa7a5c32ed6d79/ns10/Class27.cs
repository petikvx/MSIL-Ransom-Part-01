using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using SmartAssembly.Shared.ReportHelper;
using ns0;
using ns11;
using ns2;
using ns4;
using ns5;
using ns6;

namespace ns10;

internal sealed class Class27 : Class26
{
	private struct Struct8
	{
		public readonly string string_0;

		public readonly string string_1;

		public readonly string string_2;

		public readonly int int_0;
	}

	private struct Struct9
	{
		public readonly string string_0;

		public readonly string string_1;

		public Struct9(string string_2, string string_3)
		{
			string_0 = string_2;
			string_1 = string_3;
		}
	}

	private struct Struct10
	{
		public string string_0;

		public Struct9 struct9_0;

		[SpecialName]
		public bool method_0()
		{
			return string_0.Length == 0;
		}

		[SpecialName]
		public static Struct10 smethod_0()
		{
			return new Struct10(string.Empty, string.Empty, string.Empty);
		}

		private Struct10(string string_1, string string_2, string string_3)
		{
			string_0 = string_1;
			struct9_0 = new Struct9(string_2, string_3);
		}
	}

	private readonly Exception exception_0;

	private readonly Guid guid_0;

	private readonly char[] char_0 = new char[0];

	private readonly Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	private readonly Dictionary<string, Struct8> dictionary_1 = new Dictionary<string, Struct8>();

	private XmlWriter xmlWriter_0;

	private readonly List<Class31> list_0 = new List<Class31>();

	private readonly List<string> list_1 = new List<string>();

	private readonly Dictionary<string, int> dictionary_2 = new Dictionary<string, int>();

	private readonly List<Struct9> list_2 = new List<Struct9>();

	private readonly Dictionary<string, int> dictionary_3 = new Dictionary<string, int>();

	private MemoryStream memoryStream_0;

	private byte[] byte_0;

	private Delegate1 delegate1_0;

	private EventHandler eventHandler_0;

	[NonSerialized]
	internal static GetString getString_1;

	public Class27(Guid guid_1, Exception exception_1, IWebProxy iwebProxy_1)
	{
		guid_0 = guid_1;
		exception_0 = exception_1;
		method_0(iwebProxy_1);
		string text = getString_1(107390436).ToUpper();
		if (!(text == getString_1(107389879)))
		{
			if (text == getString_1(107390436))
			{
				char_0 = new char[58]
				{
					'\u0001', '\u0002', '\u0003', '\u0004', '\u0005', '\u0006', '\a', '\b', '\u000e', '\u000f',
					'\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019',
					'\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', '\u007f', '\u0080', '\u0081', '\u0082',
					'\u0083', '\u0084', '\u0086', '\u0087', '\u0088', '\u0089', '\u008a', '\u008b', '\u008c', '\u008d',
					'\u008e', '\u008f', '\u0090', '\u0091', '\u0092', '\u0093', '\u0094', '\u0095', '\u0096', '\u0097',
					'\u0098', '\u0099', '\u009a', '\u009b', '\u009c', '\u009d', '\u009e', '\u009f'
				};
			}
		}
		else
		{
			char_0 = new char[62]
			{
				'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
				'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
				'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D',
				'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
				'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
				'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7',
				'8', '9'
			};
		}
	}

	private unsafe static string smethod_0(object object_0)
	{
		void* ptr = stackalloc byte[30];
		try
		{
			if (object_0 == null)
			{
				return string.Empty;
			}
			if (object_0 is int)
			{
				*(int*)((byte*)ptr + 16) = (int)object_0;
				return ((int*)((byte*)ptr + 16))->ToString(getString_1(107395296));
			}
			if (object_0 is long)
			{
				*(long*)ptr = (long)object_0;
				return ((long*)ptr)->ToString(getString_1(107395296));
			}
			if (object_0 is short)
			{
				*(short*)((byte*)ptr + 24) = (short)object_0;
				return ((short*)((byte*)ptr + 24))->ToString(getString_1(107395296));
			}
			if (object_0 is uint)
			{
				*(uint*)((byte*)ptr + 20) = (uint)object_0;
				return ((uint*)((byte*)ptr + 20))->ToString(getString_1(107395296));
			}
			if (object_0 is ulong)
			{
				*(ulong*)((byte*)ptr + 8) = (ulong)object_0;
				return ((ulong*)((byte*)ptr + 8))->ToString(getString_1(107395296));
			}
			if (object_0 is ushort)
			{
				*(ushort*)((byte*)ptr + 26) = (ushort)object_0;
				return ((ushort*)((byte*)ptr + 26))->ToString(getString_1(107395296));
			}
			if (object_0 is byte)
			{
				((byte*)ptr)[28] = (byte)object_0;
				return ((byte*)ptr)[28].ToString(getString_1(107395296));
			}
			if (object_0 is sbyte)
			{
				((byte*)ptr)[29] = (byte)(sbyte)object_0;
				return ((sbyte*)((byte*)ptr + 29))->ToString(getString_1(107395296));
			}
			if (object_0 is IntPtr intPtr)
			{
				*(long*)ptr = intPtr.ToInt64();
				return ((long*)ptr)->ToString(getString_1(107395296));
			}
			if (object_0 is UIntPtr)
			{
				*(ulong*)((byte*)ptr + 8) = ((UIntPtr)object_0).ToUInt64();
				return ((ulong*)((byte*)ptr + 8))->ToString(getString_1(107395296));
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	private static string smethod_1(string string_0)
	{
		if (string_0.StartsWith(getString_1(107389902)) && string_0.EndsWith(getString_1(107389849)))
		{
			return getString_1(107389860);
		}
		return string_0;
	}

	private unsafe void method_6(Class31 class31_0, FieldInfo fieldInfo_0)
	{
		void* ptr = stackalloc byte[8];
		string text = fieldInfo_0?.Name;
		string string_ = (((object)fieldInfo_0 == null) ? getString_1(107389746) : getString_1(107389755));
		object obj = class31_0.method_1();
		if (obj == null)
		{
			using (new Class38(xmlWriter_0, string_))
			{
				if ((object)fieldInfo_0 != null)
				{
					if (fieldInfo_0.IsStatic)
					{
						xmlWriter_0.WriteAttributeString(getString_1(107389769), getString_1(107397106));
					}
					Type fieldType = fieldInfo_0.FieldType;
					if ((object)fieldType != null && fieldType.HasElementType)
					{
						method_10(fieldType.GetElementType());
						if (fieldType.IsByRef)
						{
							xmlWriter_0.WriteAttributeString(getString_1(107389728), getString_1(107397106));
						}
						if (fieldType.IsPointer)
						{
							xmlWriter_0.WriteAttributeString(getString_1(107389719), getString_1(107397106));
						}
						if (fieldType.IsArray)
						{
							XmlWriter xmlWriter = xmlWriter_0;
							string localName = getString_1(107389738);
							*(int*)ptr = fieldType.GetArrayRank();
							xmlWriter.WriteAttributeString(localName, ((int*)ptr)->ToString());
						}
					}
					else
					{
						method_10(fieldType);
					}
				}
				if (text != null)
				{
					method_8(text);
				}
				xmlWriter_0.WriteAttributeString(getString_1(107389729), getString_1(107397106));
				return;
			}
		}
		Type type = class31_0.method_1().GetType();
		string text2 = null;
		string text3 = null;
		if (obj is string)
		{
			text2 = getString_1(107389688);
		}
		if (text2 == null)
		{
			if (!type.IsPrimitive && !(obj is IntPtr) && !(obj is UIntPtr))
			{
				if (type.IsValueType && (object)type.Module != GetType().Module)
				{
					text2 = type.FullName;
				}
			}
			else
			{
				text2 = type.FullName;
				if (obj is char)
				{
					*(int*)((byte*)ptr + 4) = (char)obj;
					StringBuilder stringBuilder = new StringBuilder();
					if (*(int*)((byte*)ptr + 4) >= 32)
					{
						stringBuilder.Append('\'');
						stringBuilder.Append((char)obj);
						stringBuilder.Append(getString_1(107389699));
					}
					stringBuilder.Append(getString_1(107389662));
					stringBuilder.Append(((int*)((byte*)ptr + 4))->ToString(getString_1(107395296)));
					stringBuilder.Append(')');
					text3 = stringBuilder.ToString();
				}
				if (obj is bool)
				{
					text3 = obj.ToString()!.ToLower();
				}
				if (text3 == null)
				{
					string text4 = smethod_0(obj);
					if (text4.Length > 0)
					{
						StringBuilder stringBuilder2 = new StringBuilder();
						stringBuilder2.Append(obj.ToString());
						stringBuilder2.Append(getString_1(107389657));
						stringBuilder2.Append(text4);
						stringBuilder2.Append(')');
						text3 = stringBuilder2.ToString();
					}
					else
					{
						text3 = obj.ToString();
					}
				}
			}
		}
		using (new Class38(xmlWriter_0, string_))
		{
			if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
			{
				xmlWriter_0.WriteAttributeString(getString_1(107389769), getString_1(107397106));
			}
			if (text2 != null)
			{
				method_10(type);
				if (text != null)
				{
					method_8(text);
				}
				if (type.IsEnum)
				{
					text3 = obj.ToString();
				}
				if (obj is Guid)
				{
					text3 = getString_1(107390245) + obj?.ToString() + getString_1(107389680);
				}
				if (text3 == null)
				{
					text3 = getString_1(107396940) + obj?.ToString() + getString_1(107396940);
				}
				xmlWriter_0.WriteAttributeString(getString_1(107389675), smethod_1(text3));
			}
			else
			{
				if ((object)fieldInfo_0 != null)
				{
					method_10(fieldInfo_0.FieldType);
				}
				method_7(class31_0);
				if (text != null)
				{
					method_8(text);
				}
			}
		}
	}

	private unsafe void method_7(Class31 class31_0)
	{
		void* ptr = stackalloc byte[8];
		object obj = class31_0.method_1();
		*(int*)ptr = -1;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < list_0.Count)
		{
			if (list_0[*(int*)((byte*)ptr + 4)].method_1() != obj)
			{
				(*(int*)((byte*)ptr + 4))++;
				continue;
			}
			*(int*)ptr = *(int*)((byte*)ptr + 4);
			break;
		}
		if (*(int*)ptr == -1)
		{
			*(int*)ptr = list_0.Count;
			list_0.Add(class31_0);
		}
		xmlWriter_0.WriteAttributeString(getString_1(107389666), ((int*)ptr)->ToString());
	}

	private void method_8(string string_0)
	{
		int num = method_11(string_0);
		if (num != -1)
		{
			xmlWriter_0.WriteAttributeString(getString_1(107390141), num.ToString());
		}
		else
		{
			xmlWriter_0.WriteAttributeString(getString_1(107390132), string_0);
		}
	}

	private static Struct10 smethod_2(Type type_0)
	{
		Struct10 result = Struct10.smethod_0();
		if ((object)type_0 != null && (object)type_0.Assembly.GetType(getString_1(107390155)) != null)
		{
			result.string_0 = ((type_0.MetadataToken & 0xFFFFFF) - 1).ToString();
			Assembly assembly = type_0.Assembly;
			result.struct9_0 = new Struct9(assembly.ManifestModule.ModuleVersionId.ToString(getString_1(107395303)), assembly.FullName);
		}
		return result;
	}

	private int method_9(Struct10 struct10_0)
	{
		string key = struct10_0.struct9_0.string_0.ToUpper();
		if (dictionary_3.ContainsKey(key))
		{
			return dictionary_3[key];
		}
		int count = list_2.Count;
		list_2.Add(struct10_0.struct9_0);
		dictionary_3.Add(key, count);
		return count;
	}

	private unsafe void method_10(Type type_0)
	{
		void* ptr = stackalloc byte[12];
		if ((object)type_0 == null)
		{
			return;
		}
		try
		{
			Struct10 struct10_ = smethod_2(type_0);
			if (!struct10_.method_0())
			{
				xmlWriter_0.WriteAttributeString(getString_1(107390094), struct10_.string_0);
				*(int*)ptr = method_9(struct10_);
				if (*(int*)ptr > 0)
				{
					xmlWriter_0.WriteAttributeString(getString_1(107390081), ((int*)ptr)->ToString());
				}
				return;
			}
			string fullName = type_0.FullName;
			if (dictionary_2.ContainsKey(fullName))
			{
				*(int*)((byte*)ptr + 4) = dictionary_2[fullName];
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				string name = type_0.Assembly.GetName().Name;
				if (name.Length > 0 && name != getString_1(107390036))
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
				*(int*)((byte*)ptr + 8) = fullName.LastIndexOf(getString_1(107396076));
				if (*(int*)((byte*)ptr + 8) > 0)
				{
					string value = fullName.Substring(@namespace.Length + 1, *(int*)((byte*)ptr + 8) - @namespace.Length).Replace(getString_1(107396076), getString_1(107396112));
					stringBuilder.Append(value);
				}
				stringBuilder.Append(type_0.Name);
				*(int*)((byte*)ptr + 4) = list_1.Count;
				list_1.Add(stringBuilder.ToString());
				dictionary_2.Add(fullName, *(int*)((byte*)ptr + 4));
			}
			xmlWriter_0.WriteAttributeString(getString_1(107390055), ((int*)((byte*)ptr + 4))->ToString());
		}
		catch
		{
		}
	}

	private unsafe int method_11(string string_0)
	{
		void* ptr = stackalloc byte[18];
		try
		{
			((byte*)ptr)[16] = ((char_0[0] == '\u0001') ? ((byte)1) : ((byte)0));
			if (string_0 != null && string_0.Length != 0 && (((byte*)ptr)[16] == 0 || string_0.Length <= 4) && (((byte*)ptr)[16] != 0 || string_0[0] == '#'))
			{
				*(int*)ptr = 0;
				*(int*)((byte*)ptr + 8) = string_0.Length - 1;
				while (true)
				{
					if (*(int*)((byte*)ptr + 8) >= 0 && (((byte*)ptr)[16] != 0 || *(int*)((byte*)ptr + 8) != 0))
					{
						char c = string_0[*(int*)((byte*)ptr + 8)];
						((byte*)ptr)[17] = 0;
						*(int*)((byte*)ptr + 12) = 0;
						while (*(int*)((byte*)ptr + 12) < char_0.Length)
						{
							if (char_0[*(int*)((byte*)ptr + 12)] != c)
							{
								(*(int*)((byte*)ptr + 12))++;
								continue;
							}
							*(int*)ptr = *(int*)ptr * char_0.Length + *(int*)((byte*)ptr + 12);
							((byte*)ptr)[17] = 1;
							break;
						}
						if (((byte*)ptr)[17] != 0)
						{
							(*(int*)((byte*)ptr + 8))--;
							continue;
						}
						*(int*)((byte*)ptr + 4) = -1;
						break;
					}
					*(int*)((byte*)ptr + 4) = *(int*)ptr;
					break;
				}
			}
			else
			{
				*(int*)((byte*)ptr + 4) = -1;
			}
		}
		catch
		{
			*(int*)((byte*)ptr + 4) = -1;
		}
		return *(int*)((byte*)ptr + 4);
	}

	private static string smethod_3()
	{
		try
		{
			return Application.get_ExecutablePath();
		}
		catch
		{
			return getString_1(107390010);
		}
	}

	private Assembly[] method_12()
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { smethod_4() };
		}
	}

	private static Assembly smethod_4()
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

	private unsafe byte[] method_13()
	{
		void* ptr = stackalloc byte[33];
		if (byte_0 != null)
		{
			return byte_0;
		}
		memoryStream_0 = new MemoryStream();
		xmlWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		xmlWriter_0.WriteStartDocument();
		using (new Class38(xmlWriter_0, getString_1(107390005)))
		{
			xmlWriter_0.WriteAttributeString(getString_1(107389972), getString_1(107389987).ToUpper());
			xmlWriter_0.WriteAttributeString(getString_1(107389934), DateTime.Now.ToString(getString_1(107395386)));
			xmlWriter_0.WriteAttributeString(getString_1(107391542), smethod_3());
			if (guid_0 != Guid.Empty)
			{
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = getString_1(107389921);
				Guid guid = guid_0;
				xmlWriter.WriteAttributeString(localName, guid.ToString(getString_1(107395303)));
			}
			xmlWriter_0.WriteAttributeString(getString_1(107389368), Guid.NewGuid().ToString(getString_1(107395303)));
			if (list_2.Count > 0)
			{
				list_2.Clear();
			}
			list_2.Add(new Struct9(getString_1(107389987), string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add(getString_1(107389987), 0);
			using (new Class38(xmlWriter_0, getString_1(107389387)))
			{
				Assembly assembly = smethod_4();
				Assembly[] array = method_12();
				*(int*)ptr = 0;
				while (*(int*)ptr < array.Length)
				{
					Assembly assembly2 = array[*(int*)ptr];
					if ((object)assembly2 != null)
					{
						using (new Class38(xmlWriter_0, getString_1(107390081)))
						{
							try
							{
								xmlWriter_0.WriteAttributeString(getString_1(107390132), assembly2.FullName);
								xmlWriter_0.WriteAttributeString(getString_1(107389338), assembly2.CodeBase);
								if ((object)assembly2 == assembly)
								{
									xmlWriter_0.WriteAttributeString(getString_1(107389357), getString_1(107397106));
								}
							}
							catch
							{
							}
						}
					}
					(*(int*)ptr)++;
				}
			}
			using (new Class38(xmlWriter_0, getString_1(107389348)))
			{
				if (dictionary_0 != null && dictionary_0.Count > 0)
				{
					foreach (string key in dictionary_0.Keys)
					{
						using (new Class38(xmlWriter_0, getString_1(107389323)))
						{
							xmlWriter_0.WriteAttributeString(getString_1(107390132), key);
							string text = (string)dictionary_0[key];
							if (text == null)
							{
								xmlWriter_0.WriteAttributeString(getString_1(107389729), getString_1(107397106));
							}
							else
							{
								xmlWriter_0.WriteAttributeString(getString_1(107389675), getString_1(107396940) + text + getString_1(107396940));
							}
						}
					}
				}
			}
			if (dictionary_1 != null && dictionary_1.Count > 0)
			{
				using (new Class38(xmlWriter_0, getString_1(107389270)))
				{
					foreach (string key2 in dictionary_1.Keys)
					{
						using (new Class38(xmlWriter_0, getString_1(107389281)))
						{
							xmlWriter_0.WriteAttributeString(getString_1(107389264), key2);
							Struct8 @struct = dictionary_1[key2];
							xmlWriter_0.WriteAttributeString(getString_1(107389259), @struct.string_0);
							XmlWriter xmlWriter2 = xmlWriter_0;
							string localName2 = getString_1(107389214);
							*(int*)ptr = @struct.int_0;
							xmlWriter2.WriteAttributeString(localName2, ((int*)ptr)->ToString());
							if (@struct.string_2.Length > 0)
							{
								xmlWriter_0.WriteAttributeString(getString_1(107389205), @struct.string_2);
							}
							else
							{
								xmlWriter_0.WriteAttributeString(getString_1(107389228), @struct.string_1);
							}
						}
					}
				}
			}
			using (new Class38(xmlWriter_0, getString_1(107389219)))
			{
				try
				{
					Version version_ = Environment.Version;
					Version version_2 = Environment.OSVersion.Version;
					string string_ = Environment.OSVersion.Platform.ToString();
					OsInformation.smethod_3(out var _, ref version_, ref version_2, ref string_, out var string_2, out *(bool*)((byte*)ptr + 32));
					xmlWriter_0.WriteElementString(getString_1(107389194), version_.ToString());
					xmlWriter_0.WriteElementString(getString_1(107389145), version_2.ToString());
					xmlWriter_0.WriteElementString(getString_1(107389164), string_);
					xmlWriter_0.WriteElementString(getString_1(107389627), string_2);
					xmlWriter_0.WriteElementString(getString_1(107389638), Class37.smethod_3());
					xmlWriter_0.WriteElementString(getString_1(107389589), Class37.smethod_1() ? getString_1(107397106) : getString_1(107397116));
					xmlWriter_0.WriteElementString(getString_1(107389608), OsVersionInformation.smethod_1() ? getString_1(107397106) : getString_1(107397116));
					xmlWriter_0.WriteElementString(getString_1(107389603), Class37.smethod_2() ? getString_1(107397106) : getString_1(107397116));
				}
				catch
				{
				}
			}
			List<Exception> list = new List<Exception>();
			for (Exception innerException = exception_0; innerException != null; innerException = innerException.InnerException)
			{
				list.Add(innerException);
			}
			list.Reverse();
			using (new Class38(xmlWriter_0, getString_1(107389554)))
			{
				foreach (Exception item in list)
				{
					try
					{
						method_16(item);
						if (!item.Data.Contains(getString_1(107389569)))
						{
							continue;
						}
						ICollection obj3 = (ICollection)item.Data[getString_1(107389569)];
						int count = obj3.Count;
						*(int*)((byte*)ptr + 4) = 0;
						foreach (object item2 in obj3)
						{
							try
							{
								Type type = item2.GetType();
								(*(int*)((byte*)ptr + 4))++;
								if (*(int*)((byte*)ptr + 4) > 100 && *(int*)((byte*)ptr + 4) == count - 100)
								{
									using (new Class38(xmlWriter_0, getString_1(107389544)))
									{
										xmlWriter_0.WriteAttributeString(getString_1(107389491), count.ToString());
									}
								}
								else
								{
									if (*(int*)((byte*)ptr + 4) > 100 && *(int*)((byte*)ptr + 4) <= count - 100)
									{
										continue;
									}
									*(int*)((byte*)ptr + 8) = (int)type.GetField(getString_1(107389466))!.GetValue(item2);
									*(int*)((byte*)ptr + 12) = (int)type.GetField(getString_1(107389485))!.GetValue(item2);
									*(int*)((byte*)ptr + 16) = (int)type.GetField(getString_1(107389440))!.GetValue(item2);
									object[] array2 = (object[])type.GetField(getString_1(107389443))!.GetValue(item2);
									Struct10 struct10_ = smethod_2(type);
									if (struct10_.method_0())
									{
										continue;
									}
									using (new Class38(xmlWriter_0, getString_1(107389398)))
									{
										xmlWriter_0.WriteAttributeString(getString_1(107389466), ((int*)((byte*)ptr + 8))->ToString());
										xmlWriter_0.WriteAttributeString(getString_1(107389440), ((int*)((byte*)ptr + 16))->ToString());
										*(int*)((byte*)ptr + 20) = method_9(struct10_);
										if (*(int*)((byte*)ptr + 20) > 0)
										{
											xmlWriter_0.WriteAttributeString(getString_1(107390081), ((int*)((byte*)ptr + 20))->ToString());
										}
										if (*(int*)((byte*)ptr + 12) != -1)
										{
											xmlWriter_0.WriteAttributeString(getString_1(107389485), ((int*)((byte*)ptr + 12))->ToString());
										}
										object[] array3 = array2;
										*(int*)ptr = 0;
										while (*(int*)ptr < array3.Length)
										{
											object object_ = array3[*(int*)ptr];
											try
											{
												method_6(new Class31(object_, bool_1: true), null);
											}
											catch
											{
											}
											(*(int*)ptr)++;
										}
									}
									continue;
								}
							}
							catch
							{
							}
						}
					}
					catch
					{
					}
				}
			}
			method_14();
			using (new Class38(xmlWriter_0, getString_1(107389413)))
			{
				XmlWriter xmlWriter3 = xmlWriter_0;
				string localName3 = getString_1(107388856);
				*(int*)ptr = list_1.Count;
				xmlWriter3.WriteAttributeString(localName3, ((int*)ptr)->ToString());
				*(int*)((byte*)ptr + 24) = 0;
				while (*(int*)((byte*)ptr + 24) < list_1.Count)
				{
					string value;
					try
					{
						value = list_1[*(int*)((byte*)ptr + 24)].ToString();
					}
					catch (Exception ex)
					{
						value = getString_1(107396940) + ex.Message + getString_1(107396940);
					}
					xmlWriter_0.WriteElementString(getString_1(107390055), value);
					(*(int*)((byte*)ptr + 24))++;
				}
			}
			using (new Class38(xmlWriter_0, getString_1(107388879)))
			{
				XmlWriter xmlWriter4 = xmlWriter_0;
				string localName4 = getString_1(107388856);
				*(int*)ptr = list_2.Count;
				xmlWriter4.WriteAttributeString(localName4, ((int*)ptr)->ToString());
				*(int*)((byte*)ptr + 28) = 0;
				while (*(int*)((byte*)ptr + 28) < list_2.Count)
				{
					using (new Class38(xmlWriter_0, getString_1(107389972)))
					{
						Struct9 struct2 = list_2[*(int*)((byte*)ptr + 28)];
						xmlWriter_0.WriteAttributeString(getString_1(107389666), struct2.string_0);
						if (struct2.string_1.Length > 0)
						{
							xmlWriter_0.WriteAttributeString(getString_1(107388830), struct2.string_1);
						}
					}
					(*(int*)((byte*)ptr + 28))++;
				}
			}
		}
		xmlWriter_0.WriteEndDocument();
		xmlWriter_0.Flush();
		memoryStream_0.Flush();
		byte_0 = memoryStream_0.ToArray();
		return byte_0;
	}

	private unsafe void method_14()
	{
		void* ptr = stackalloc byte[25];
		using (new Class38(xmlWriter_0, getString_1(107389443)))
		{
			*(int*)ptr = 0;
			while (*(int*)ptr < list_0.Count)
			{
				Class31 @class = list_0[*(int*)ptr];
				object obj = @class.method_1();
				Type type = @class.method_2();
				using (new Class38(xmlWriter_0, getString_1(107388817)))
				{
					xmlWriter_0.WriteAttributeString(getString_1(107389666), ((int*)ptr)->ToString());
					string text = null;
					((byte*)ptr)[24] = 1;
					string[] array = getString_1(107396845).Split(new char[1] { ',' });
					*(int*)((byte*)ptr + 4) = 0;
					while (*(int*)((byte*)ptr + 4) < array.Length)
					{
						string text2 = array[*(int*)((byte*)ptr + 4)];
						if (!(text2 != getString_1(107396845)) || !type.FullName!.StartsWith(text2))
						{
							(*(int*)((byte*)ptr + 4))++;
							continue;
						}
						((byte*)ptr)[24] = 0;
						break;
					}
					object[] customAttributes = type.GetCustomAttributes(inherit: true);
					*(int*)((byte*)ptr + 4) = 0;
					while (*(int*)((byte*)ptr + 4) < customAttributes.Length)
					{
						string name = ((Attribute)customAttributes[*(int*)((byte*)ptr + 4)]).GetType().Name;
						if (name != getString_1(107388836) && name != getString_1(107388767))
						{
							(*(int*)((byte*)ptr + 4))++;
							continue;
						}
						((byte*)ptr)[24] = 0;
						break;
					}
					if (((byte*)ptr)[24] != 0)
					{
						try
						{
							text = obj.ToString();
							text = ((text == type.FullName) ? null : (type.IsEnum ? Enum.Format(type, obj, getString_1(107395408)) : ((!(obj is Guid)) ? (getString_1(107396940) + text + getString_1(107396940)) : (getString_1(107390245) + text + getString_1(107389680)))));
						}
						catch
						{
						}
						if (text != null)
						{
							xmlWriter_0.WriteAttributeString(getString_1(107389675), smethod_1(text));
						}
					}
					if (type.HasElementType)
					{
						method_10(type.GetElementType());
						if (type.IsByRef)
						{
							xmlWriter_0.WriteAttributeString(getString_1(107389728), getString_1(107397106));
						}
						if (type.IsPointer)
						{
							xmlWriter_0.WriteAttributeString(getString_1(107389719), getString_1(107397106));
						}
						if (type.IsArray)
						{
							Array array2 = (Array)obj;
							XmlWriter xmlWriter = xmlWriter_0;
							string localName = getString_1(107389738);
							*(int*)((byte*)ptr + 4) = array2.Rank;
							xmlWriter.WriteAttributeString(localName, ((int*)((byte*)ptr + 4))->ToString());
							StringBuilder stringBuilder = new StringBuilder();
							*(int*)((byte*)ptr + 8) = 0;
							while (*(int*)((byte*)ptr + 8) < array2.Rank)
							{
								if (*(int*)((byte*)ptr + 8) > 0)
								{
									stringBuilder.Append(',');
								}
								stringBuilder.Append(array2.GetLength(*(int*)((byte*)ptr + 8)));
								(*(int*)((byte*)ptr + 8))++;
							}
							xmlWriter_0.WriteAttributeString(getString_1(107389214), stringBuilder.ToString());
							if (array2.Rank == 1)
							{
								*(int*)((byte*)ptr + 12) = array2.Length;
								*(int*)((byte*)ptr + 16) = 0;
								while (*(int*)((byte*)ptr + 16) < *(int*)((byte*)ptr + 12))
								{
									if (*(int*)((byte*)ptr + 16) == 10 && *(int*)((byte*)ptr + 12) > 16)
									{
										*(int*)((byte*)ptr + 16) = *(int*)((byte*)ptr + 12) - 5;
									}
									try
									{
										method_6(new Class31(array2.GetValue(*(int*)((byte*)ptr + 16)), bool_1: false), null);
									}
									catch
									{
									}
									(*(int*)((byte*)ptr + 16))++;
								}
							}
						}
					}
					else
					{
						method_10(type);
						if (@class.method_0() && ((byte*)ptr)[24] != 0)
						{
							try
							{
								if (obj is IEnumerable)
								{
									using (new Class38(xmlWriter_0, getString_1(107388770)))
									{
										*(int*)((byte*)ptr + 20) = 0;
										foreach (object item in (IEnumerable)obj)
										{
											if (*(int*)((byte*)ptr + 20) <= 20)
											{
												method_6(new Class31(item, bool_1: false), null);
												(*(int*)((byte*)ptr + 20))++;
												continue;
											}
											xmlWriter_0.WriteElementString(getString_1(107388721), string.Empty);
											break;
										}
									}
								}
							}
							catch
							{
							}
							method_15(@class);
						}
					}
				}
				(*(int*)ptr)++;
			}
		}
	}

	private unsafe void method_15(Class31 class31_0)
	{
		void* ptr = stackalloc byte[9];
		FieldInfo[] fields = class31_0.method_2().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		*(int*)ptr = 0;
		while (*(int*)ptr < fields.Length)
		{
			FieldInfo fieldInfo = fields[*(int*)ptr];
			try
			{
				if (!fieldInfo.IsLiteral && (!fieldInfo.IsStatic || !fieldInfo.IsInitOnly))
				{
					((byte*)ptr)[8] = 1;
					object[] customAttributes = fieldInfo.GetCustomAttributes(inherit: true);
					*(int*)((byte*)ptr + 4) = 0;
					while (*(int*)((byte*)ptr + 4) < customAttributes.Length)
					{
						if (!(((Attribute)customAttributes[*(int*)((byte*)ptr + 4)]).GetType().Name == getString_1(107388767)))
						{
							(*(int*)((byte*)ptr + 4))++;
							continue;
						}
						((byte*)ptr)[8] = 0;
						break;
					}
					if (((byte*)ptr)[8] != 0)
					{
						method_6(new Class31(fieldInfo.GetValue(class31_0.method_1()), bool_1: false), fieldInfo);
					}
				}
			}
			catch
			{
			}
			(*(int*)ptr)++;
		}
		class31_0 = new Class31(class31_0.method_1(), class31_0.method_2().BaseType, class31_0.method_0());
		if ((object)class31_0.method_2() != null)
		{
			using (new Class38(xmlWriter_0, getString_1(107389755)))
			{
				method_8(getString_1(107388744));
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = getString_1(107389666);
				*(int*)ptr = list_0.Count;
				xmlWriter.WriteAttributeString(localName, ((int*)ptr)->ToString());
			}
			list_0.Add(class31_0);
		}
	}

	private void method_16(Exception exception_1)
	{
		using (new Class38(xmlWriter_0, getString_1(107388703)))
		{
			try
			{
				Type type = exception_1.GetType();
				method_10(type);
				string value = getString_1(107390010);
				try
				{
					value = exception_1.Message;
				}
				catch
				{
				}
				xmlWriter_0.WriteAttributeString(getString_1(107388690), value);
				string text = exception_1.StackTrace!.Trim();
				xmlWriter_0.WriteAttributeString(getString_1(107388709), text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf(getString_1(107388680));
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				xmlWriter_0.WriteAttributeString(getString_1(107388675), text);
				method_7(new Class31(exception_1, bool_1: true));
			}
			catch
			{
			}
		}
	}

	internal unsafe bool method_17()
	{
		void* ptr = stackalloc byte[5];
		Class46.smethod_0(1u);
		try
		{
			method_5(Enum6.const_0);
			byte[] array;
			try
			{
				array = method_13();
			}
			catch (Exception ex)
			{
				*(int*)ptr = -1;
				try
				{
					StackTrace stackTrace = new StackTrace(ex);
					if (stackTrace.FrameCount > 0)
					{
						*(int*)ptr = stackTrace.GetFrame(stackTrace.FrameCount - 1)!.GetILOffset();
					}
				}
				catch
				{
				}
				method_4(Enum6.const_0, string.Format(getString_1(107388634), ex.Message, *(int*)ptr));
				((byte*)ptr)[4] = 0;
				goto end_IL_000b;
			}
			Class30 class30_ = new Class30(getString_1(107396845), getString_1(107396961), getString_1(107389113));
			((byte*)ptr)[4] = (method_1(array, class30_) ? ((byte)1) : ((byte)0));
			end_IL_000b:;
		}
		catch (ThreadAbortException)
		{
			((byte*)ptr)[4] = 0;
		}
		catch (Exception exception_)
		{
			method_19(new EventArgs1(exception_));
			((byte*)ptr)[4] = 0;
		}
		return ((byte*)ptr)[4] != 0;
	}

	[SpecialName]
	public void method_18(Delegate1 delegate1_1)
	{
		Delegate1 @delegate = delegate1_0;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_1);
			@delegate = Interlocked.CompareExchange(ref delegate1_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	public void method_19(EventArgs1 eventArgs1_0)
	{
		delegate1_0?.Invoke(this, eventArgs1_0);
	}

	[SpecialName]
	public void method_20(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal void method_21()
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			method_22(tempFileName);
			Process.Start(Path.Combine(Class4.smethod_0(), getString_1(107389096)), getString_1(107389071) + tempFileName + getString_1(107396940));
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
			method_19(new EventArgs1(exception_));
		}
	}

	internal bool method_22(string string_0)
	{
		try
		{
			byte[] array = method_13();
			byte[] array2;
			try
			{
				array2 = Class13.smethod_2(array);
			}
			catch
			{
				array2 = null;
			}
			byte[] array3 = Class25.smethod_0(array2, getString_1(107389010));
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes(getString_1(107389987));
			fileStream.Write(bytes, 0, bytes.Length);
			fileStream.Write(array3, 0, array3.Length);
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

	static Class27()
	{
		Strings.CreateGetStringDelegate(typeof(Class27));
	}
}
