using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Xml;
using ns10;

namespace ns12;

internal class Class47 : Class46
{
	internal struct Struct20
	{
		public readonly string string_0;

		public readonly string string_1;

		public readonly string string_2;

		public readonly int int_0;

		public Struct20(string fileName)
		{
			string_0 = string.Empty;
			string_1 = string.Empty;
			string_2 = string.Empty;
			int_0 = 0;
			try
			{
				FileInfo fileInfo = new FileInfo(fileName);
				string_0 = Path.GetFileName(fileName);
				int_0 = (int)fileInfo.Length;
				byte[] array = new byte[int_0];
				using (FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					fileStream.Read(array, 0, int_0);
					fileStream.Close();
				}
				byte[] inArray;
				try
				{
					inArray = Class12.smethod_58(array);
				}
				catch
				{
					inArray = null;
				}
				string_1 = Convert.ToBase64String(inArray);
			}
			catch (Exception ex)
			{
				string_2 = ex.Message;
			}
		}

		internal static bool jtL6FKleJ681g8hNwc5()
		{
			return true;
		}

		internal static bool w0HpZ9lCCmXBDl447Fv()
		{
			return false;
		}
	}

	internal struct Struct21
	{
		public readonly string string_0;

		public readonly string string_1;

		public Struct21(string assemblyID, string assemblyFullName)
		{
			string_0 = assemblyID;
			string_1 = assemblyFullName;
		}

		internal static bool WJSLAIlGMIIBD1yYyv0()
		{
			return true;
		}

		internal static bool cbUc2SlsvZdXCIYAK8e()
		{
			return false;
		}
	}

	internal struct Struct22
	{
		public string string_0;

		public Struct21 struct21_0;

		public bool IsEmpty => string_0.Length == 0;

		public static Struct22 Empty => new Struct22(string.Empty, string.Empty, string.Empty);

		private Struct22(string id, string assemblyID, string assemblyFullName)
		{
			string_0 = id;
			struct21_0 = new Struct21(assemblyID, assemblyFullName);
		}

		internal static bool YGK6iEl2fWKYrfx3CO5()
		{
			return true;
		}

		internal static bool wlOXOAlW3qsf594tAiE()
		{
			return false;
		}
	}

	private readonly Exception exception_0;

	private readonly Guid guid_0;

	internal readonly char[] char_0 = new char[0];

	internal readonly Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	internal readonly Dictionary<string, Struct20> dictionary_1 = new Dictionary<string, Struct20>();

	internal XmlWriter xmlWriter_0;

	private readonly List<Class51> list_0 = new List<Class51>();

	private readonly List<string> list_1 = new List<string>();

	private readonly Dictionary<string, int> dictionary_2 = new Dictionary<string, int>();

	internal readonly List<Struct21> list_2 = new List<Struct21>();

	internal readonly Dictionary<string, int> dictionary_3 = new Dictionary<string, int>();

	private MemoryStream memoryStream_0;

	private byte[] byte_0;

	internal Delegate19 delegate19_0;

	internal EventHandler eventHandler_0;

	public event Delegate19 FatalException
	{
		add
		{
			Delegate19 @delegate = delegate19_0;
			Delegate19 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate19 value2 = (Delegate19)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate19_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			while (true)
			{
				Delegate19 @delegate = delegate19_0;
				while (true)
				{
					Delegate19 delegate2 = @delegate;
					while (true)
					{
						IL_0044:
						Delegate19 value2 = (Delegate19)Delegate.Remove(delegate2, value);
						while (true)
						{
							@delegate = Interlocked.CompareExchange(ref delegate19_0, value2, delegate2);
							if ((object)@delegate != delegate2)
							{
								break;
							}
							if (ItG47SlmOMlNRTKT5R3())
							{
							}
							switch (6)
							{
							case 2:
							case 3:
								goto IL_0044;
							case 0:
							case 1:
								goto end_IL_0030;
							case 4:
								goto end_IL_0053;
							case 6:
								return;
							}
							continue;
							end_IL_0030:
							break;
						}
						break;
					}
					continue;
					end_IL_0053:
					break;
				}
			}
		}
	}

	public event EventHandler DebuggerLaunched
	{
		add
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler eventHandler2 = default(EventHandler);
			EventHandler value2 = default(EventHandler);
			while (true)
			{
				EventHandler eventHandler = eventHandler_0;
				if (eY9yMBl0MexdYJ9IoDY())
				{
					switch (5)
					{
					case 0:
						break;
					case 5:
						goto IL_003a;
					default:
						goto IL_004b;
					case 1:
					case 2:
						goto IL_0051;
					case 6:
						return;
					}
					continue;
				}
				goto IL_0051;
				IL_003a:
				eventHandler2 = eventHandler;
				value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				goto IL_0051;
				IL_0051:
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
				goto IL_004b;
				IL_004b:
				if ((object)eventHandler == eventHandler2)
				{
					break;
				}
				goto IL_003a;
			}
		}
	}

	public Class47(Guid userId, Exception currentException, IWebProxy proxy)
	{
		guid_0 = userId;
		exception_0 = currentException;
		iwebProxy_0 = proxy;
		string text;
		if ((text = Class32.smethod_0(5046).ToUpper()) == null)
		{
			return;
		}
		if (!(text == Class32.smethod_0(5046)))
		{
			if (text == Class32.smethod_0(5055))
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

	private void method_0(Class51 class51_0, FieldInfo fieldInfo_0)
	{
		string text;
		string name;
		StringBuilder stringBuilder2 = default(StringBuilder);
		string text5 = default(string);
		int num2 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		Class60 @class = default(Class60);
		while (true)
		{
			IL_01e8:
			object obj;
			if ((object)fieldInfo_0 == null)
			{
				obj = null;
				goto IL_01de;
			}
			goto IL_01d8;
			IL_01d8:
			obj = fieldInfo_0.Name;
			goto IL_01de;
			IL_01de:
			text = (string)obj;
			string text2;
			if ((object)fieldInfo_0 == null)
			{
				text2 = Class32.smethod_0(5077);
				goto IL_01c7;
			}
			goto IL_01bd;
			IL_01bd:
			text2 = Class32.smethod_0(5068);
			goto IL_01c7;
			IL_01c7:
			name = text2;
			object object_ = class51_0.object_0;
			if (object_ == null)
			{
				break;
			}
			Type type = class51_0.object_0.GetType();
			while (true)
			{
				string text3 = null;
				string text4 = null;
				if (object_ is string)
				{
					text3 = Class32.smethod_0(5135);
				}
				if (text3 == null)
				{
					int num = 10;
					if (!eY9yMBl0MexdYJ9IoDY())
					{
						break;
					}
					while (true)
					{
						switch (num)
						{
						case 13:
							stringBuilder2.Append(')');
							text4 = stringBuilder2.ToString();
							goto IL_0058;
						case 3:
							if (text4 == null)
							{
								text5 = Class12.smethod_126(object_);
								num = 5;
								if (eY9yMBl0MexdYJ9IoDY())
								{
									continue;
								}
								goto case 4;
							}
							goto IL_038a;
						case 4:
							stringBuilder2.Append(Class32.smethod_0(5156));
							goto IL_008c;
						case 10:
							if (type.IsPrimitive || object_ is IntPtr || object_ is UIntPtr)
							{
								text3 = type.FullName;
								if (!(object_ is char))
								{
									goto IL_0058;
								}
								num2 = (char)object_;
								stringBuilder2 = new StringBuilder();
								if (num2 < 32)
								{
									goto IL_008c;
								}
								stringBuilder2.Append('\'');
								stringBuilder2.Append((char)object_);
								goto case 4;
							}
							if (type.IsValueType && (object)type.Module != GetType().Module)
							{
								text3 = type.FullName;
							}
							goto IL_038a;
						case 5:
						case 8:
							if (text5.Length > 0)
							{
								num = 12;
								if (!ItG47SlmOMlNRTKT5R3())
								{
									continue;
								}
								goto case 12;
							}
							text4 = object_.ToString();
							goto IL_038a;
						default:
							num = 3;
							if (eY9yMBl0MexdYJ9IoDY())
							{
								continue;
							}
							goto case 0;
						case 7:
							break;
						case 2:
							goto end_IL_01aa;
						case 9:
							goto IL_01d8;
						case 1:
							goto IL_01e8;
						case 12:
							stringBuilder = new StringBuilder();
							stringBuilder.Append(object_.ToString());
							goto case 0;
						case 0:
							stringBuilder.Append(Class32.smethod_0(5166));
							stringBuilder.Append(text5);
							stringBuilder.Append(')');
							text4 = stringBuilder.ToString();
							goto IL_038a;
						case 6:
						case 11:
							goto IL_038a;
						case 14:
							goto IL_0399;
							IL_0058:
							if (object_ is bool)
							{
								text4 = object_.ToString()!.ToLower();
							}
							goto case 3;
							IL_008c:
							stringBuilder2.Append(Class32.smethod_0(5161));
							stringBuilder2.Append(num2.ToString(Class32.smethod_0(4531)));
							goto case 13;
						}
						break;
					}
					continue;
				}
				goto IL_038a;
				IL_0399:
				try
				{
					if ((object)fieldInfo_0 != null && fieldInfo_0.IsStatic)
					{
						goto IL_040b;
					}
					goto IL_042a;
					IL_0445:
					if (type.IsEnum)
					{
						text4 = object_.ToString();
					}
					if (object_ is Guid)
					{
						text4 = string.Concat(Class32.smethod_0(3568), object_, Class32.smethod_0(5175));
					}
					if (text4 == null)
					{
						goto IL_047b;
					}
					goto IL_0496;
					IL_042a:
					if (text3 == null)
					{
						if ((object)fieldInfo_0 != null)
						{
							method_3(fieldInfo_0.FieldType);
						}
						method_1(class51_0);
						if (text == null)
						{
							return;
						}
						int num3 = 7;
						if (eY9yMBl0MexdYJ9IoDY())
						{
							while (true)
							{
								switch (num3)
								{
								default:
									num3 = 3;
									if (!ItG47SlmOMlNRTKT5R3())
									{
									}
									continue;
								case 0:
								case 5:
									break;
								case 2:
									goto IL_043d;
								case 1:
									goto IL_0445;
								case 3:
									goto IL_047b;
								case 4:
								case 6:
									goto IL_0496;
								case 7:
									method_2(text);
									return;
								}
								break;
							}
						}
						goto IL_040b;
					}
					method_3(type);
					if (text != null)
					{
						goto IL_043d;
					}
					goto IL_0445;
					IL_047b:
					text4 = string.Concat(Class32.smethod_0(1374), object_, Class32.smethod_0(1374));
					goto IL_0496;
					IL_0496:
					xmlWriter_0.WriteAttributeString(Class32.smethod_0(5180), Class12.smethod_15(text4));
					return;
					IL_043d:
					method_2(text);
					goto IL_0445;
					IL_040b:
					xmlWriter_0.WriteAttributeString(Class32.smethod_0(5086), Class32.smethod_0(871));
					goto IL_042a;
				}
				finally
				{
					((IDisposable)@class)?.Dispose();
				}
				IL_038a:
				@class = new Class60(xmlWriter_0, name);
				goto IL_0399;
				continue;
				end_IL_01aa:
				break;
			}
			goto IL_01bd;
		}
		using (new Class60(xmlWriter_0, name))
		{
			if ((object)fieldInfo_0 != null)
			{
				if (fieldInfo_0.IsStatic)
				{
					xmlWriter_0.WriteAttributeString(Class32.smethod_0(5086), Class32.smethod_0(871));
				}
				Type fieldType = fieldInfo_0.FieldType;
				if ((object)fieldType != null && fieldType.HasElementType)
				{
					method_3(fieldType.GetElementType());
					if (fieldType.IsByRef)
					{
						xmlWriter_0.WriteAttributeString(Class32.smethod_0(5095), Class32.smethod_0(871));
					}
					if (fieldType.IsPointer)
					{
						xmlWriter_0.WriteAttributeString(Class32.smethod_0(5104), Class32.smethod_0(871));
					}
					if (fieldType.IsArray)
					{
						xmlWriter_0.WriteAttributeString(Class32.smethod_0(5117), fieldType.GetArrayRank().ToString());
					}
				}
				else
				{
					method_3(fieldType);
				}
			}
			if (text != null)
			{
				method_2(text);
			}
			xmlWriter_0.WriteAttributeString(Class32.smethod_0(5126), Class32.smethod_0(871));
		}
	}

	internal void method_1(Class51 class51_0)
	{
		object object_ = class51_0.object_0;
		int num = -1;
		for (int i = 0; i < list_0.Count; i++)
		{
			if (object.ReferenceEquals(list_0[i].object_0, object_))
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			num = list_0.Count;
			list_0.Add(class51_0);
		}
		xmlWriter_0.WriteAttributeString(Class32.smethod_0(5189), num.ToString());
	}

	private void method_2(string string_0)
	{
		int num = Class12.smethod_105(string_0, this);
		if (num != -1)
		{
			xmlWriter_0.WriteAttributeString(Class32.smethod_0(5194), num.ToString());
		}
		else
		{
			xmlWriter_0.WriteAttributeString(Class32.smethod_0(5203), string_0);
		}
	}

	private static Struct22 smethod_0(Type type_0)
	{
		Assembly assembly = default(Assembly);
		while (true)
		{
			Struct22 empty = Struct22.Empty;
			while (true)
			{
				if ((object)type_0 != null)
				{
					int num = 1;
					if (!ItG47SlmOMlNRTKT5R3())
					{
					}
					while (true)
					{
						switch (num)
						{
						default:
							num = 2;
							if (!ItG47SlmOMlNRTKT5R3())
							{
							}
							continue;
						case 5:
							break;
						case 0:
						case 4:
							goto end_IL_0040;
						case 1:
							if ((object)type_0.Assembly.GetType(Class32.smethod_0(5212)) != null)
							{
								empty.string_0 = ((type_0.MetadataToken & 0xFFFFFF) - 1).ToString();
								assembly = type_0.Assembly;
								goto case 2;
							}
							goto IL_00b7;
						case 2:
						case 3:
							empty.struct21_0 = new Struct21(assembly.ManifestModule.ModuleVersionId.ToString(Class32.smethod_0(5273)), assembly.FullName);
							goto IL_00b7;
						case 6:
							goto IL_00b7;
						}
						break;
					}
					continue;
				}
				goto IL_00b7;
				IL_00b7:
				return empty;
				continue;
				end_IL_0040:
				break;
			}
		}
	}

	internal void method_3(Type type_0)
	{
		if ((object)type_0 == null)
		{
			return;
		}
		try
		{
			Struct22 struct22_ = smethod_0(type_0);
			int num = 9;
			if (!ItG47SlmOMlNRTKT5R3())
			{
			}
			string fullName = default(string);
			StringBuilder stringBuilder = default(StringBuilder);
			int value = default(int);
			string name = default(string);
			string @namespace = default(string);
			int num3 = default(int);
			while (true)
			{
				int num2;
				switch (num)
				{
				case 9:
					if (struct22_.IsEmpty)
					{
						fullName = type_0.FullName;
						if (!dictionary_2.ContainsKey(fullName))
						{
							stringBuilder = new StringBuilder();
							goto case 0;
						}
						value = dictionary_2[fullName];
						break;
					}
					goto case 6;
				case 0:
					name = type_0.Assembly.GetName().Name;
					goto default;
				default:
					if (name.Length > 0 && name != Class32.smethod_0(5304))
					{
						stringBuilder.Append('[');
						stringBuilder.Append(name);
						stringBuilder.Append(']');
					}
					goto case 5;
				case 5:
				case 7:
					@namespace = type_0.Namespace;
					if (@namespace.Length > 0)
					{
						goto case 8;
					}
					goto IL_00b2;
				case 8:
					stringBuilder.Append(@namespace);
					stringBuilder.Append('.');
					goto IL_00b2;
				case 1:
					goto IL_0116;
				case 6:
					xmlWriter_0.WriteAttributeString(Class32.smethod_0(5278), struct22_.string_0);
					num3 = Class12.smethod_141(struct22_, this);
					goto case 2;
				case 2:
					if (num3 > 0)
					{
						xmlWriter_0.WriteAttributeString(Class32.smethod_0(5291), num3.ToString());
					}
					return;
				case 10:
					break;
					IL_00b2:
					if (type_0.HasElementType)
					{
						type_0 = type_0.GetElementType();
					}
					num2 = fullName.LastIndexOf(Class32.smethod_0(5317));
					if (num2 > 0)
					{
						string value2 = fullName.Substring(@namespace.Length + 1, num2 - @namespace.Length).Replace(Class32.smethod_0(5317), Class32.smethod_0(5322));
						stringBuilder.Append(value2);
					}
					goto IL_0116;
				}
				goto IL_01ef;
				IL_0116:
				stringBuilder.Append(type_0.Name);
				value = list_1.Count;
				list_1.Add(stringBuilder.ToString());
				dictionary_2.Add(fullName, value);
				num = 10;
				if (!ItG47SlmOMlNRTKT5R3())
				{
					continue;
				}
				goto IL_01ef;
				IL_01ef:
				xmlWriter_0.WriteAttributeString(Class32.smethod_0(5327), value.ToString());
				break;
			}
		}
		catch
		{
		}
	}

	internal byte[] method_4()
	{
		if (byte_0 != null)
		{
			return byte_0;
		}
		memoryStream_0 = new MemoryStream();
		xmlWriter_0 = new XmlTextWriter(memoryStream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		xmlWriter_0.WriteStartDocument();
		using (new Class60(xmlWriter_0, Class32.smethod_0(5340)))
		{
			xmlWriter_0.WriteAttributeString(Class32.smethod_0(5373), Class32.smethod_0(2800).ToUpper());
			xmlWriter_0.WriteAttributeString(Class32.smethod_0(5390), DateTime.Now.ToString(Class32.smethod_0(5403)));
			xmlWriter_0.WriteAttributeString(Class32.smethod_0(785), Class12.smethod_154());
			if (guid_0 != Guid.Empty)
			{
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = Class32.smethod_0(5408);
				Guid guid = guid_0;
				xmlWriter.WriteAttributeString(localName, guid.ToString(Class32.smethod_0(5273)));
			}
			xmlWriter_0.WriteAttributeString(Class32.smethod_0(5417), Guid.NewGuid().ToString(Class32.smethod_0(5273)));
			if (list_2.Count > 0)
			{
				list_2.Clear();
			}
			list_2.Add(new Struct21(Class32.smethod_0(2800), string.Empty));
			if (dictionary_3.Count > 0)
			{
				dictionary_3.Clear();
			}
			dictionary_3.Add(Class32.smethod_0(2800), 0);
			using (new Class60(xmlWriter_0, Class32.smethod_0(5430)))
			{
				Assembly assembly = Class12.smethod_77();
				Assembly[] array = Class12.smethod_153(this);
				foreach (Assembly assembly2 in array)
				{
					if ((object)assembly2 == null)
					{
						continue;
					}
					using (new Class60(xmlWriter_0, Class32.smethod_0(5291)))
					{
						try
						{
							xmlWriter_0.WriteAttributeString(Class32.smethod_0(5203), assembly2.FullName);
							xmlWriter_0.WriteAttributeString(Class32.smethod_0(5447), assembly2.CodeBase);
							if ((object)assembly2 == assembly)
							{
								xmlWriter_0.WriteAttributeString(Class32.smethod_0(5460), Class32.smethod_0(871));
							}
						}
						catch
						{
						}
					}
				}
			}
			using (new Class60(xmlWriter_0, Class32.smethod_0(5469)))
			{
				if (dictionary_0 != null && dictionary_0.Count > 0)
				{
					foreach (string key in dictionary_0.Keys)
					{
						using (new Class60(xmlWriter_0, Class32.smethod_0(5494)))
						{
							xmlWriter_0.WriteAttributeString(Class32.smethod_0(5203), key);
							while (true)
							{
								IL_0348:
								string text = (string)dictionary_0[key];
								if (text == null)
								{
									while (true)
									{
										xmlWriter_0.WriteAttributeString(Class32.smethod_0(5126), Class32.smethod_0(871));
										int num = 4;
										if (!eY9yMBl0MexdYJ9IoDY())
										{
											break;
										}
										while (true)
										{
											switch (num)
											{
											default:
												num = 2;
												if (!ItG47SlmOMlNRTKT5R3())
												{
												}
												continue;
											case 1:
											case 2:
												break;
											case 0:
											case 3:
												goto IL_0348;
											case 4:
												goto end_IL_031b;
											}
											break;
										}
										continue;
										end_IL_031b:
										break;
									}
								}
								else
								{
									xmlWriter_0.WriteAttributeString(Class32.smethod_0(5180), Class32.smethod_0(1374) + text + Class32.smethod_0(1374));
								}
								break;
							}
						}
					}
				}
			}
			if (dictionary_1 != null && dictionary_1.Count > 0)
			{
				using (new Class60(xmlWriter_0, Class32.smethod_0(5515)))
				{
					foreach (string key2 in dictionary_1.Keys)
					{
						using (new Class60(xmlWriter_0, Class32.smethod_0(5536)))
						{
							xmlWriter_0.WriteAttributeString(Class32.smethod_0(5553), key2);
							while (true)
							{
								Struct20 @struct = dictionary_1[key2];
								xmlWriter_0.WriteAttributeString(Class32.smethod_0(5558), @struct.string_0);
								if (eY9yMBl0MexdYJ9IoDY())
								{
									switch (3)
									{
									case 4:
										continue;
									case 1:
									case 3:
									{
										XmlWriter xmlWriter2 = xmlWriter_0;
										string localName2 = Class32.smethod_0(5571);
										int int_ = @struct.int_0;
										xmlWriter2.WriteAttributeString(localName2, int_.ToString());
										break;
									}
									case 5:
										goto end_IL_044f;
									}
								}
								if (@struct.string_2.Length > 0)
								{
									xmlWriter_0.WriteAttributeString(Class32.smethod_0(5580), @struct.string_2);
								}
								else
								{
									xmlWriter_0.WriteAttributeString(Class32.smethod_0(5589), @struct.string_1);
								}
								break;
								continue;
								end_IL_044f:
								break;
							}
						}
					}
				}
			}
			using (new Class60(xmlWriter_0, Class32.smethod_0(5598)))
			{
				try
				{
					xmlWriter_0.WriteElementString(Class32.smethod_0(5623), Environment.Version.ToString());
					xmlWriter_0.WriteElementString(Class32.smethod_0(5640), Environment.OSVersion.Version.ToString());
					xmlWriter_0.WriteElementString(Class32.smethod_0(5653), Environment.OSVersion.Platform.ToString());
					xmlWriter_0.WriteElementString(Class32.smethod_0(5670), Class59.ServicePack);
					xmlWriter_0.WriteElementString(Class32.smethod_0(5687), Class59.IsServerR2 ? Class32.smethod_0(871) : Class32.smethod_0(5700));
					xmlWriter_0.WriteElementString(Class32.smethod_0(5705), Class59.IsX64 ? Class32.smethod_0(871) : Class32.smethod_0(5700));
					xmlWriter_0.WriteElementString(Class32.smethod_0(5710), Class59.IsWorkstation ? Class32.smethod_0(871) : Class32.smethod_0(5700));
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
			using (new Class60(xmlWriter_0, Class32.smethod_0(5727)))
			{
				foreach (Exception item in list)
				{
					try
					{
						Class12.smethod_118(this, item);
						if (!item.Data.Contains(Class32.smethod_0(4805)))
						{
							continue;
						}
						ICollection collection = (ICollection)item.Data[Class32.smethod_0(4805)];
						int count = collection.Count;
						int num2 = 0;
						foreach (object item2 in collection)
						{
							try
							{
								Type type = item2.GetType();
								num2++;
								if (num2 > 100 && num2 == count - 100)
								{
									using (new Class60(xmlWriter_0, Class32.smethod_0(5744)))
									{
										xmlWriter_0.WriteAttributeString(Class32.smethod_0(5765), count.ToString());
									}
								}
								else
								{
									if (num2 > 100 && num2 <= count - 100)
									{
										continue;
									}
									int num3 = (int)type.GetField(Class32.smethod_0(5790))!.GetValue(item2);
									int num4 = (int)type.GetField(Class32.smethod_0(5803))!.GetValue(item2);
									int num5 = (int)type.GetField(Class32.smethod_0(5816))!.GetValue(item2);
									object[] array2 = (object[])type.GetField(Class32.smethod_0(5845))!.GetValue(item2);
									Struct22 struct22_ = smethod_0(type);
									if (struct22_.IsEmpty)
									{
										continue;
									}
									using (new Class60(xmlWriter_0, Class32.smethod_0(5858)))
									{
										xmlWriter_0.WriteAttributeString(Class32.smethod_0(5790), num3.ToString());
										xmlWriter_0.WriteAttributeString(Class32.smethod_0(5816), num5.ToString());
										int num6 = Class12.smethod_141(struct22_, this);
										if (num6 > 0)
										{
											xmlWriter_0.WriteAttributeString(Class32.smethod_0(5291), num6.ToString());
										}
										if (num4 != -1)
										{
											xmlWriter_0.WriteAttributeString(Class32.smethod_0(5803), num4.ToString());
										}
										object[] array3 = array2;
										foreach (object o in array3)
										{
											try
											{
												method_0(new Class51(o, firstLevel: true), null);
											}
											catch
											{
											}
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
			method_5();
			using (new Class60(xmlWriter_0, Class32.smethod_0(5875)))
			{
				xmlWriter_0.WriteAttributeString(Class32.smethod_0(5888), list_1.Count.ToString());
				for (int k = 0; k < list_1.Count; k++)
				{
					string value;
					try
					{
						value = list_1[k].ToString();
					}
					catch (Exception ex)
					{
						value = '"' + ex.Message + '"';
					}
					xmlWriter_0.WriteElementString(Class32.smethod_0(5327), value);
				}
			}
			using (new Class60(xmlWriter_0, Class32.smethod_0(5897)))
			{
				xmlWriter_0.WriteAttributeString(Class32.smethod_0(5888), list_2.Count.ToString());
				for (int l = 0; l < list_2.Count; l++)
				{
					using (new Class60(xmlWriter_0, Class32.smethod_0(5373)))
					{
						Struct21 struct2 = list_2[l];
						xmlWriter_0.WriteAttributeString(Class32.smethod_0(5189), struct2.string_0);
						if (struct2.string_1.Length > 0)
						{
							xmlWriter_0.WriteAttributeString(Class32.smethod_0(5914), struct2.string_1);
						}
					}
				}
			}
		}
		xmlWriter_0.WriteEndDocument();
		xmlWriter_0.Flush();
		memoryStream_0.Flush();
		byte_0 = memoryStream_0.ToArray();
		return byte_0;
	}

	private void method_5()
	{
		using (new Class60(xmlWriter_0, Class32.smethod_0(5845)))
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				Class51 @class = list_0[i];
				object object_ = @class.object_0;
				Type type_ = @class.type_0;
				using (new Class60(xmlWriter_0, Class32.smethod_0(5927)))
				{
					xmlWriter_0.WriteAttributeString(Class32.smethod_0(5189), i.ToString());
					string text = null;
					bool flag = true;
					string[] array = Class32.smethod_0(1013).Split(new char[1] { ',' });
					foreach (string text2 in array)
					{
						if (text2 != Class32.smethod_0(1013) && type_.FullName!.StartsWith(text2))
						{
							flag = false;
							break;
						}
					}
					object[] customAttributes = type_.GetCustomAttributes(inherit: true);
					for (int k = 0; k < customAttributes.Length; k++)
					{
						Attribute attribute = (Attribute)customAttributes[k];
						string name = attribute.GetType().Name;
						if (!(name != Class32.smethod_0(5940)) || !(name != Class32.smethod_0(5977)))
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						try
						{
							text = object_.ToString();
							int num = 0;
							if (!eY9yMBl0MexdYJ9IoDY())
							{
								goto IL_01e1;
							}
							while (true)
							{
								switch (num)
								{
								case 0:
									if (text == type_.FullName)
									{
										num = 3;
										if (eY9yMBl0MexdYJ9IoDY())
										{
											continue;
										}
										goto case 1;
									}
									if (type_.IsEnum)
									{
										text = Enum.Format(type_, object_, Class32.smethod_0(6006));
										goto end_IL_0174;
									}
									if (object_ is Guid)
									{
										break;
									}
									text = Class32.smethod_0(1374) + text + Class32.smethod_0(1374);
									goto end_IL_0174;
								case 1:
								case 3:
									text = null;
									goto end_IL_0174;
								case 5:
									goto end_IL_0174;
								}
								goto IL_01e1;
								continue;
								end_IL_0174:
								break;
							}
							goto end_IL_013e;
							IL_01e1:
							text = Class32.smethod_0(3568) + text + Class32.smethod_0(5175);
							end_IL_013e:;
						}
						catch
						{
						}
						if (text != null)
						{
							xmlWriter_0.WriteAttributeString(Class32.smethod_0(5180), Class12.smethod_15(text));
						}
					}
					if (type_.HasElementType)
					{
						method_3(type_.GetElementType());
						if (type_.IsByRef)
						{
							xmlWriter_0.WriteAttributeString(Class32.smethod_0(5095), Class32.smethod_0(871));
						}
						if (type_.IsPointer)
						{
							xmlWriter_0.WriteAttributeString(Class32.smethod_0(5104), Class32.smethod_0(871));
						}
						if (!type_.IsArray)
						{
							continue;
						}
						Array array2 = (Array)object_;
						xmlWriter_0.WriteAttributeString(Class32.smethod_0(5117), array2.Rank.ToString());
						StringBuilder stringBuilder = new StringBuilder();
						for (int l = 0; l < array2.Rank; l++)
						{
							if (l > 0)
							{
								stringBuilder.Append(',');
							}
							stringBuilder.Append(array2.GetLength(l));
						}
						xmlWriter_0.WriteAttributeString(Class32.smethod_0(5571), stringBuilder.ToString());
						if (array2.Rank != 1)
						{
							continue;
						}
						int length = array2.Length;
						for (int m = 0; m < length; m++)
						{
							if (m == 10 && length > 16)
							{
								m = length - 5;
							}
							try
							{
								method_0(new Class51(array2.GetValue(m), firstLevel: false), null);
							}
							catch
							{
							}
						}
						continue;
					}
					method_3(type_);
					if (!@class.bool_0 || !flag)
					{
						continue;
					}
					try
					{
						if (object_ is IEnumerable)
						{
							using (new Class60(xmlWriter_0, Class32.smethod_0(6011)))
							{
								int num2 = 0;
								foreach (object item in (IEnumerable)object_)
								{
									if (num2 <= 20)
									{
										method_0(new Class51(item, firstLevel: false), null);
										num2++;
										continue;
									}
									xmlWriter_0.WriteElementString(Class32.smethod_0(6028), string.Empty);
									break;
								}
							}
						}
					}
					catch
					{
					}
					method_6(@class);
				}
			}
		}
	}

	private void method_6(Class51 class51_0)
	{
		int num = 6;
		if (!eY9yMBl0MexdYJ9IoDY())
		{
			return;
		}
		FieldInfo[] fields = default(FieldInfo[]);
		FieldInfo[] array = default(FieldInfo[]);
		int i = default(int);
		while (true)
		{
			switch (num)
			{
			case 6:
				fields = class51_0.type_0.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				goto case 2;
			case 2:
				array = fields;
				i = 0;
				goto case 5;
			case 5:
				for (; i < array.Length; i++)
				{
					FieldInfo fieldInfo = array[i];
					try
					{
						if (fieldInfo.IsLiteral || (fieldInfo.IsStatic && fieldInfo.IsInitOnly))
						{
							continue;
						}
						bool flag = true;
						object[] customAttributes = fieldInfo.GetCustomAttributes(inherit: true);
						for (int j = 0; j < customAttributes.Length; j++)
						{
							Attribute attribute = (Attribute)customAttributes[j];
							if (attribute.GetType().Name == Class32.smethod_0(5977))
							{
								flag = false;
								break;
							}
						}
						if (flag)
						{
							method_0(new Class51(fieldInfo.GetValue(class51_0.object_0), firstLevel: false), fieldInfo);
						}
					}
					catch
					{
					}
				}
				class51_0 = new Class51(class51_0.object_0, class51_0.type_0.BaseType, class51_0.bool_0);
				goto case 1;
			case 1:
			case 3:
				if ((object)class51_0.type_0 == null)
				{
					num = 0;
					if (ItG47SlmOMlNRTKT5R3())
					{
					}
					break;
				}
				using (new Class60(xmlWriter_0, Class32.smethod_0(5068)))
				{
					method_2(Class32.smethod_0(6037));
					xmlWriter_0.WriteAttributeString(Class32.smethod_0(5189), list_0.Count.ToString());
				}
				list_0.Add(class51_0);
				return;
			default:
				num = 1;
				if (ItG47SlmOMlNRTKT5R3())
				{
				}
				break;
			case 0:
			case 4:
				return;
			case 7:
				return;
			}
		}
	}

	internal bool method_7()
	{
		try
		{
			Class12.smethod_45((Class46)this, Enum4.const_0);
			byte[] array;
			try
			{
				array = method_4();
			}
			catch (Exception ex)
			{
				int num = -1;
				try
				{
					StackTrace stackTrace = new StackTrace(ex);
					while (stackTrace.FrameCount > 0)
					{
						while (true)
						{
							StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
							if (ItG47SlmOMlNRTKT5R3())
							{
							}
							switch (4)
							{
							default:
								continue;
							case 0:
							case 3:
								break;
							case 4:
								num = frame.GetILOffset();
								goto end_IL_001f;
							}
							goto IL_0056;
							continue;
							end_IL_001f:
							break;
						}
						break;
						IL_0056:;
					}
				}
				catch
				{
				}
				Class12.smethod_73((Class46)this, Enum4.const_0, string.Format(Class32.smethod_0(6046), ex.Message, num));
				return false;
			}
			Class50 class50_ = new Class50(Class32.smethod_0(1013), Class32.smethod_0(6079), Class32.smethod_0(6084));
			return Class12.smethod_101(array, class50_, (Class46)this);
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception fatalException)
		{
			Class12.smethod_147(new EventArgs0(fatalException), this);
			return false;
		}
	}

	internal static bool eY9yMBl0MexdYJ9IoDY()
	{
		return true;
	}

	internal static bool ItG47SlmOMlNRTKT5R3()
	{
		return false;
	}
}
