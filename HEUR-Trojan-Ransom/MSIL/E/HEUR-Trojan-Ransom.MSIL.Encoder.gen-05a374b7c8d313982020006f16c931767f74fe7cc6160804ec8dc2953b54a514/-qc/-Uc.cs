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
using System.Xml;
using _0023M;
using _0023ab;
using SmartAssembly.Shared.ReportHelper;

namespace _0023qc;

internal class _0023Uc : _0023pd
{
	internal struct _00238e
	{
		public readonly string _0023a;

		public readonly string _0023b;

		public readonly string _0023c;

		public readonly int _0023d;

		public _00238e(string _0023Nc)
		{
			_0023a = string.Empty;
			_0023b = string.Empty;
			_0023c = string.Empty;
			_0023d = 0;
			try
			{
				FileInfo fileInfo = new FileInfo(_0023Nc);
				_0023a = Path.GetFileName(_0023Nc);
				_0023d = (int)fileInfo.Length;
				byte[] array = new byte[_0023d];
				using (FileStream fileStream = File.Open(_0023Nc, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					fileStream.Read(array, 0, _0023d);
					fileStream.Close();
				}
				byte[] inArray;
				try
				{
					inArray = _0023_0023._0023Rf(array);
				}
				catch
				{
					inArray = null;
				}
				_0023b = Convert.ToBase64String(inArray);
			}
			catch (Exception ex)
			{
				_0023c = ex.Message;
			}
		}
	}

	internal struct _00239e
	{
		public readonly string _0023a;

		public readonly string _0023b;

		public _00239e(string _0023af, string _0023bf)
		{
			_0023a = _0023af;
			_0023b = _0023bf;
		}
	}

	internal struct _0023ef
	{
		public string _0023a;

		public _00239e _0023b;

		public bool IsEmpty => _0023a.Length == 0;

		public static _0023ef Empty => new _0023ef(string.Empty, string.Empty, string.Empty);

		private _0023ef(string _0023ff, string _0023af, string _0023bf)
		{
			_0023a = _0023ff;
			_0023b = new _00239e(_0023af, _0023bf);
		}
	}

	private new const string _0023a = "{bf13b64c-b3d2-4165-b3f5-7f852d4744cf}";

	private const string _0023b = "{07572d6f-5375-47d5-8a8c-b5f0cbe5bad0}";

	private const string _0023c = "{6d3806d4-1193-4601-a7df-2249c7f0014b}";

	private new const string _0023d = "{d316c294-ed40-4778-8b7b-29800a2dcbc3}";

	private new const string _0023e = "{a9035fc5-7ed1-4e0c-8962-dfcb1d508afc}";

	private const string _0023f = "{73fbfb9b-41e7-4744-bf74-74b7c6c117c1}";

	private readonly Exception _0023g;

	private readonly Guid _0023h;

	internal readonly char[] _0023i = new char[0];

	internal readonly Dictionary<string, object> _0023j = new Dictionary<string, object>();

	internal readonly Dictionary<string, _00238e> _0023k = new Dictionary<string, _00238e>();

	internal XmlWriter _0023l;

	private readonly List<_0023Zc> _0023m = new List<_0023Zc>();

	private readonly List<string> _0023n = new List<string>();

	private readonly Dictionary<string, int> _0023o = new Dictionary<string, int>();

	internal readonly List<_00239e> _0023p = new List<_00239e>();

	internal readonly Dictionary<string, int> _0023q = new Dictionary<string, int>();

	private MemoryStream _0023r;

	private byte[] _0023s;

	private const string _0023t = "SmartAssembly.exe";

	[CompilerGenerated]
	internal _00235c _0023u;

	[CompilerGenerated]
	internal EventHandler _0023v;

	public event _00235c FatalException
	{
		[CompilerGenerated]
		add
		{
			_00235c _00235c2 = _0023u;
			_00235c _00235c3;
			do
			{
				_00235c3 = _00235c2;
				_00235c value2 = (_00235c)Delegate.Combine(_00235c3, value);
				_00235c2 = Interlocked.CompareExchange(ref _0023u, value2, _00235c3);
			}
			while ((object)_00235c2 != _00235c3);
		}
		[CompilerGenerated]
		remove
		{
			_00235c _00235c2 = _0023u;
			_00235c _00235c3;
			do
			{
				_00235c3 = _00235c2;
				_00235c value2 = (_00235c)Delegate.Remove(_00235c3, value);
				_00235c2 = Interlocked.CompareExchange(ref _0023u, value2, _00235c3);
			}
			while ((object)_00235c2 != _00235c3);
		}
	}

	public event EventHandler DebuggerLaunched
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = _0023v;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref _0023v, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = _0023v;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref _0023v, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public _0023Uc(Guid _0023Vc, Exception _0023Wc, IWebProxy _0023Xc)
	{
		_0023h = _0023Vc;
		_0023g = _0023Wc;
		base._0023d = _0023Xc;
		string text = _0023ab._00239._00237(107395359).ToUpper();
		if (!(text == _0023ab._00239._00237(107395359)))
		{
			if (text == _0023ab._00239._00237(107395350))
			{
				_0023i = new char[58]
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
			_0023i = new char[62]
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

	private void _0023xc(_0023Zc _0023yc, FieldInfo _0023zc)
	{
		string text = ((_0023zc == null) ? null : _0023zc.Name);
		string _0023Cc = ((_0023zc == null) ? _0023ab._00239._00237(107394784) : _0023ab._00239._00237(107394793));
		object obj = _0023yc._0023b;
		if (obj == null)
		{
			using (new _0023Ge(_0023l, _0023Cc))
			{
				if (_0023zc != null)
				{
					if (_0023zc.IsStatic)
					{
						_0023l.WriteAttributeString(_0023ab._00239._00237(107394807), _0023ab._00239._00237(107394766));
					}
					Type fieldType = _0023zc.FieldType;
					if (fieldType != null && fieldType.HasElementType)
					{
						_0023Gc(fieldType.GetElementType());
						if (fieldType.IsByRef)
						{
							_0023l.WriteAttributeString(_0023ab._00239._00237(107394761), _0023ab._00239._00237(107394766));
						}
						if (fieldType.IsPointer)
						{
							_0023l.WriteAttributeString(_0023ab._00239._00237(107394752), _0023ab._00239._00237(107394766));
						}
						if (fieldType.IsArray)
						{
							_0023l.WriteAttributeString(_0023ab._00239._00237(107394771), fieldType.GetArrayRank().ToString());
						}
					}
					else
					{
						_0023Gc(fieldType);
					}
				}
				if (text != null)
				{
					_0023Bc(text);
				}
				_0023l.WriteAttributeString(_0023ab._00239._00237(107394730), _0023ab._00239._00237(107394766));
				return;
			}
		}
		Type type = _0023yc._0023b.GetType();
		string text2 = null;
		string text3 = null;
		if (obj is string)
		{
			text2 = _0023ab._00239._00237(107394721);
		}
		if (text2 == null)
		{
			if (type.IsPrimitive || obj is IntPtr || obj is UIntPtr)
			{
				text2 = type.FullName;
				if (obj is int num)
				{
					StringBuilder stringBuilder = new StringBuilder();
					if (num >= 32)
					{
						stringBuilder.Append('\'');
						stringBuilder.Append((char)obj);
						stringBuilder.Append(_0023ab._00239._00237(107394700));
					}
					stringBuilder.Append(_0023ab._00239._00237(107394695));
					stringBuilder.Append(num.ToString(_0023ab._00239._00237(107394690)));
					stringBuilder.Append(')');
					text3 = stringBuilder.ToString();
				}
				if (obj is bool)
				{
					text3 = obj.ToString()!.ToLower();
				}
				if (text3 == null)
				{
					string text4 = _0023_0023._00230g(obj);
					if (text4.Length > 0)
					{
						StringBuilder stringBuilder2 = new StringBuilder();
						stringBuilder2.Append(obj.ToString());
						stringBuilder2.Append(_0023ab._00239._00237(107394717));
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
			else if (type.IsValueType && type.Module != GetType().Module)
			{
				text2 = type.FullName;
			}
		}
		using (new _0023Ge(_0023l, _0023Cc))
		{
			if (_0023zc != null && _0023zc.IsStatic)
			{
				_0023l.WriteAttributeString(_0023ab._00239._00237(107394807), _0023ab._00239._00237(107394766));
			}
			if (text2 != null)
			{
				_0023Gc(type);
				if (text != null)
				{
					_0023Bc(text);
				}
				if (type.IsEnum)
				{
					text3 = obj.ToString();
				}
				if (obj is Guid)
				{
					text3 = _0023ab._00239._00237(107394708) + obj?.ToString() + _0023ab._00239._00237(107394671);
				}
				if (text3 == null)
				{
					text3 = _0023ab._00239._00237(107394666) + obj?.ToString() + _0023ab._00239._00237(107394666);
				}
				_0023l.WriteAttributeString(_0023ab._00239._00237(107394661), _0023_0023._00236h(text3));
			}
			else
			{
				if (_0023zc != null)
				{
					_0023Gc(_0023zc.FieldType);
				}
				_0023Ac(_0023yc);
				if (text != null)
				{
					_0023Bc(text);
				}
			}
		}
	}

	internal void _0023Ac(_0023Zc _0023yc)
	{
		object obj = _0023yc._0023b;
		int num = -1;
		for (int i = 0; i < _0023m.Count; i++)
		{
			if (_0023m[i]._0023b == obj)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			num = _0023m.Count;
			_0023m.Add(_0023yc);
		}
		_0023l.WriteAttributeString(_0023ab._00239._00237(107394684), num.ToString());
	}

	private void _0023Bc(string _0023Cc)
	{
		int num = _0023_0023._00235f(_0023Cc, this);
		if (num != -1)
		{
			_0023l.WriteAttributeString(_0023ab._00239._00237(107394679), num.ToString());
		}
		else
		{
			_0023l.WriteAttributeString(_0023ab._00239._00237(107394638), _0023Cc);
		}
	}

	private static _0023ef _0023Dc(Type _0023Ec)
	{
		_0023ef result = _0023ef.Empty;
		if (_0023Ec != null && _0023Ec.Assembly.GetType(_0023ab._00239._00237(107394629)) != null)
		{
			result._0023a = ((_0023Ec.MetadataToken & 0xFFFFFF) - 1).ToString();
			Assembly assembly = _0023Ec.Assembly;
			result._0023b = new _00239e(assembly.ManifestModule.ModuleVersionId.ToString(_0023ab._00239._00237(107394568)), assembly.FullName);
		}
		return result;
	}

	internal void _0023Gc(Type _0023Ec)
	{
		if (_0023Ec == null)
		{
			return;
		}
		try
		{
			_0023ef _0023Fc = _0023Dc(_0023Ec);
			if (!_0023Fc.IsEmpty)
			{
				_0023l.WriteAttributeString(_0023ab._00239._00237(107394563), _0023Fc._0023a);
				int num = _0023_0023._0023bg(_0023Fc, this);
				if (num > 0)
				{
					_0023l.WriteAttributeString(_0023ab._00239._00237(107394582), num.ToString());
				}
				return;
			}
			string fullName = _0023Ec.FullName;
			int value;
			if (_0023o.ContainsKey(fullName))
			{
				value = _0023o[fullName];
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				string name = _0023Ec.Assembly.GetName().Name;
				if (name.Length > 0 && name != _0023ab._00239._00237(107395049))
				{
					stringBuilder.Append('[');
					stringBuilder.Append(name);
					stringBuilder.Append(']');
				}
				string @namespace = _0023Ec.Namespace;
				if (@namespace.Length > 0)
				{
					stringBuilder.Append(@namespace);
					stringBuilder.Append('.');
				}
				if (_0023Ec.HasElementType)
				{
					_0023Ec = _0023Ec.GetElementType();
				}
				int num2 = fullName.LastIndexOf(_0023ab._00239._00237(107395068));
				if (num2 > 0)
				{
					string value2 = fullName.Substring(@namespace.Length + 1, num2 - @namespace.Length).Replace(_0023ab._00239._00237(107395068), _0023ab._00239._00237(107395063));
					stringBuilder.Append(value2);
				}
				stringBuilder.Append(_0023Ec.Name);
				value = _0023n.Count;
				_0023n.Add(stringBuilder.ToString());
				_0023o.Add(fullName, value);
			}
			_0023l.WriteAttributeString(_0023ab._00239._00237(107395058), value.ToString());
		}
		catch
		{
		}
	}

	internal byte[] _0023Ic()
	{
		if (_0023s != null)
		{
			return _0023s;
		}
		_0023r = new MemoryStream();
		_0023l = new XmlTextWriter(_0023r, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		_0023l.WriteStartDocument();
		using (new _0023Ge(_0023l, _0023ab._00239._00237(107395013)))
		{
			_0023l.WriteAttributeString(_0023ab._00239._00237(107394980), _0023ab._00239._00237(107394995).ToUpper());
			_0023l.WriteAttributeString(_0023ab._00239._00237(107394942), DateTime.Now.ToString(_0023ab._00239._00237(107394929)));
			_0023l.WriteAttributeString(_0023ab._00239._00237(107394892), _0023_0023._00237g());
			if (_0023h != Guid.Empty)
			{
				XmlWriter xmlWriter = _0023l;
				string localName = _0023ab._00239._00237(107394883);
				Guid guid = _0023h;
				xmlWriter.WriteAttributeString(localName, guid.ToString(_0023ab._00239._00237(107394568)));
			}
			_0023l.WriteAttributeString(_0023ab._00239._00237(107394906), Guid.NewGuid().ToString(_0023ab._00239._00237(107394568)));
			if (_0023p.Count > 0)
			{
				_0023p.Clear();
			}
			_0023p.Add(new _00239e(_0023ab._00239._00237(107394995), string.Empty));
			if (_0023q.Count > 0)
			{
				_0023q.Clear();
			}
			_0023q.Add(_0023ab._00239._00237(107394995), 0);
			using (new _0023Ge(_0023l, _0023ab._00239._00237(107394861)))
			{
				Assembly assembly = _0023_0023._0023bh();
				Assembly[] array = _0023_0023._0023Gf(this);
				foreach (Assembly assembly2 in array)
				{
					if (!(assembly2 != null))
					{
						continue;
					}
					using (new _0023Ge(_0023l, _0023ab._00239._00237(107394582)))
					{
						try
						{
							_0023l.WriteAttributeString(_0023ab._00239._00237(107394638), assembly2.FullName);
							_0023l.WriteAttributeString(_0023ab._00239._00237(107394876), assembly2.CodeBase);
							if (assembly2 == assembly)
							{
								_0023l.WriteAttributeString(_0023ab._00239._00237(107394831), _0023ab._00239._00237(107394766));
							}
						}
						catch
						{
						}
					}
				}
			}
			using (new _0023Ge(_0023l, _0023ab._00239._00237(107394822)))
			{
				if (_0023j != null && _0023j.Count > 0)
				{
					foreach (string key in _0023j.Keys)
					{
						using (new _0023Ge(_0023l, _0023ab._00239._00237(107394285)))
						{
							_0023l.WriteAttributeString(_0023ab._00239._00237(107394638), key);
							string text = (string)_0023j[key];
							if (text == null)
							{
								_0023l.WriteAttributeString(_0023ab._00239._00237(107394730), _0023ab._00239._00237(107394766));
							}
							else
							{
								_0023l.WriteAttributeString(_0023ab._00239._00237(107394661), _0023ab._00239._00237(107394666) + text + _0023ab._00239._00237(107394666));
							}
						}
					}
				}
			}
			if (_0023k != null && _0023k.Count > 0)
			{
				using (new _0023Ge(_0023l, _0023ab._00239._00237(107394296)))
				{
					foreach (string key2 in _0023k.Keys)
					{
						using (new _0023Ge(_0023l, _0023ab._00239._00237(107394243)))
						{
							_0023l.WriteAttributeString(_0023ab._00239._00237(107394258), key2);
							_00238e _00238e = _0023k[key2];
							_0023l.WriteAttributeString(_0023ab._00239._00237(107394221), _00238e._0023a);
							XmlWriter xmlWriter2 = _0023l;
							string localName2 = _0023ab._00239._00237(107394208);
							int i = _00238e._0023d;
							xmlWriter2.WriteAttributeString(localName2, i.ToString());
							if (_00238e._0023c.Length > 0)
							{
								_0023l.WriteAttributeString(_0023ab._00239._00237(107394231), _00238e._0023c);
							}
							else
							{
								_0023l.WriteAttributeString(_0023ab._00239._00237(107394190), _00238e._0023b);
							}
						}
					}
				}
			}
			using (new _0023Ge(_0023l, _0023ab._00239._00237(107394181)))
			{
				try
				{
					Version _0023J = Environment.Version;
					Version _0023K = Environment.OSVersion.Version;
					string _0023F = Environment.OSVersion.Platform.ToString();
					bool _0023H = default(bool);
					_0023L _0023I = default(_0023L);
					_0023_0023._00236f(out string _0023G, ref _0023H, ref _0023F, ref _0023I, out _0023J, out _0023K);
					_0023l.WriteElementString(_0023ab._00239._00237(107394156), _0023J.ToString());
					_0023l.WriteElementString(_0023ab._00239._00237(107394171), _0023K.ToString());
					_0023l.WriteElementString(_0023ab._00239._00237(107394126), _0023F);
					_0023l.WriteElementString(_0023ab._00239._00237(107394141), _0023G);
					_0023l.WriteElementString(_0023ab._00239._00237(107394088), _0023Fe.ServicePack);
					_0023l.WriteElementString(_0023ab._00239._00237(107394103), _0023Fe.IsServerR2 ? _0023ab._00239._00237(107394766) : _0023ab._00239._00237(107394058));
					_0023l.WriteElementString(_0023ab._00239._00237(107394053), OsVersionInformation.IsX64 ? _0023ab._00239._00237(107394766) : _0023ab._00239._00237(107394058));
					_0023l.WriteElementString(_0023ab._00239._00237(107394048), _0023Fe.IsWorkstation ? _0023ab._00239._00237(107394766) : _0023ab._00239._00237(107394058));
				}
				catch
				{
				}
			}
			List<Exception> list = new List<Exception>();
			for (Exception innerException = _0023g; innerException != null; innerException = innerException.InnerException)
			{
				list.Add(innerException);
			}
			list.Reverse();
			using (new _0023Ge(_0023l, _0023ab._00239._00237(107394543)))
			{
				foreach (Exception item in list)
				{
					try
					{
						_0023_0023._0023Wh(item, this);
						if (!item.Data.Contains(_0023ab._00239._00237(107394558)))
						{
							continue;
						}
						ICollection obj3 = (ICollection)item.Data[_0023ab._00239._00237(107394558)];
						int count = obj3.Count;
						int num = 0;
						foreach (object item2 in obj3)
						{
							try
							{
								Type type = item2.GetType();
								num++;
								if (num > 100 && num == count - 100)
								{
									using (new _0023Ge(_0023l, _0023ab._00239._00237(107394501)))
									{
										_0023l.WriteAttributeString(_0023ab._00239._00237(107394512), count.ToString());
									}
								}
								else
								{
									if (num > 100 && num <= count - 100)
									{
										continue;
									}
									int num2 = (int)type.GetField(_0023ab._00239._00237(107394487))!.GetValue(item2);
									int num3 = (int)type.GetField(_0023ab._00239._00237(107394442))!.GetValue(item2);
									int num4 = (int)type.GetField(_0023ab._00239._00237(107394461))!.GetValue(item2);
									object[] array2 = (object[])type.GetField(_0023ab._00239._00237(107394400))!.GetValue(item2);
									_0023ef _0023Fc = _0023Dc(type);
									if (_0023Fc.IsEmpty)
									{
										continue;
									}
									using (new _0023Ge(_0023l, _0023ab._00239._00237(107394419)))
									{
										_0023l.WriteAttributeString(_0023ab._00239._00237(107394487), num2.ToString());
										_0023l.WriteAttributeString(_0023ab._00239._00237(107394461), num4.ToString());
										int num5 = _0023_0023._0023bg(_0023Fc, this);
										if (num5 > 0)
										{
											_0023l.WriteAttributeString(_0023ab._00239._00237(107394582), num5.ToString());
										}
										if (num3 != -1)
										{
											_0023l.WriteAttributeString(_0023ab._00239._00237(107394442), num3.ToString());
										}
										object[] array3 = array2;
										foreach (object _0023wc in array3)
										{
											try
											{
												_0023xc(new _0023Zc(_0023wc, _00230c: true), null);
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
			_0023Jc();
			using (new _0023Ge(_0023l, _0023ab._00239._00237(107394370)))
			{
				_0023l.WriteAttributeString(_0023ab._00239._00237(107394389), _0023n.Count.ToString());
				for (int j = 0; j < _0023n.Count; j++)
				{
					string value;
					try
					{
						value = _0023n[j].ToString();
					}
					catch (Exception ex)
					{
						value = _0023ab._00239._00237(107394666) + ex.Message + _0023ab._00239._00237(107394666);
					}
					_0023l.WriteElementString(_0023ab._00239._00237(107395058), value);
				}
			}
			using (new _0023Ge(_0023l, _0023ab._00239._00237(107394348)))
			{
				_0023l.WriteAttributeString(_0023ab._00239._00237(107394389), _0023p.Count.ToString());
				for (int k = 0; k < _0023p.Count; k++)
				{
					using (new _0023Ge(_0023l, _0023ab._00239._00237(107394980)))
					{
						_00239e _00239e = _0023p[k];
						_0023l.WriteAttributeString(_0023ab._00239._00237(107394684), _00239e._0023a);
						if (_00239e._0023b.Length > 0)
						{
							_0023l.WriteAttributeString(_0023ab._00239._00237(107394363), _00239e._0023b);
						}
					}
				}
			}
		}
		_0023l.WriteEndDocument();
		_0023l.Flush();
		_0023r.Flush();
		_0023s = _0023r.ToArray();
		return _0023s;
	}

	private void _0023Jc()
	{
		using (new _0023Ge(_0023l, _0023ab._00239._00237(107394400)))
		{
			for (int i = 0; i < _0023m.Count; i++)
			{
				_0023Zc _0023Zc2 = _0023m[i];
				object obj = _0023Zc2._0023b;
				Type type = _0023Zc2._0023a;
				using (new _0023Ge(_0023l, _0023ab._00239._00237(107394318)))
				{
					_0023l.WriteAttributeString(_0023ab._00239._00237(107394684), i.ToString());
					string text = null;
					bool flag = true;
					string[] array = _0023ab._00239._00237(107394305).Split(new char[1] { ',' });
					foreach (string text2 in array)
					{
						if (text2 != _0023ab._00239._00237(107394305) && type.FullName!.StartsWith(text2))
						{
							flag = false;
							break;
						}
					}
					object[] customAttributes = type.GetCustomAttributes(inherit: true);
					for (int j = 0; j < customAttributes.Length; j++)
					{
						string name = ((Attribute)customAttributes[j]).GetType().Name;
						if (!(name != _0023ab._00239._00237(107394304)) || !(name != _0023ab._00239._00237(107393787)))
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						try
						{
							text = obj.ToString();
							text = ((text == type.FullName) ? null : (type.IsEnum ? Enum.Format(type, obj, _0023ab._00239._00237(107393758)) : ((!(obj is Guid)) ? (_0023ab._00239._00237(107394666) + text + _0023ab._00239._00237(107394666)) : (_0023ab._00239._00237(107394708) + text + _0023ab._00239._00237(107394671)))));
						}
						catch
						{
						}
						if (text != null)
						{
							_0023l.WriteAttributeString(_0023ab._00239._00237(107394661), _0023_0023._00236h(text));
						}
					}
					if (type.HasElementType)
					{
						_0023Gc(type.GetElementType());
						if (type.IsByRef)
						{
							_0023l.WriteAttributeString(_0023ab._00239._00237(107394761), _0023ab._00239._00237(107394766));
						}
						if (type.IsPointer)
						{
							_0023l.WriteAttributeString(_0023ab._00239._00237(107394752), _0023ab._00239._00237(107394766));
						}
						if (!type.IsArray)
						{
							continue;
						}
						Array array2 = (Array)obj;
						_0023l.WriteAttributeString(_0023ab._00239._00237(107394771), array2.Rank.ToString());
						StringBuilder stringBuilder = new StringBuilder();
						for (int k = 0; k < array2.Rank; k++)
						{
							if (k > 0)
							{
								stringBuilder.Append(',');
							}
							stringBuilder.Append(array2.GetLength(k));
						}
						_0023l.WriteAttributeString(_0023ab._00239._00237(107394208), stringBuilder.ToString());
						if (array2.Rank != 1)
						{
							continue;
						}
						int length = array2.Length;
						for (int l = 0; l < length; l++)
						{
							if (l == 10 && length > 16)
							{
								l = length - 5;
							}
							try
							{
								_0023xc(new _0023Zc(array2.GetValue(l), _00230c: false), null);
							}
							catch
							{
							}
						}
						continue;
					}
					_0023Gc(type);
					if (!_0023Zc2._0023c || !flag)
					{
						continue;
					}
					try
					{
						if (obj is IEnumerable)
						{
							using (new _0023Ge(_0023l, _0023ab._00239._00237(107393753)))
							{
								int num = 0;
								foreach (object item in (IEnumerable)obj)
								{
									if (num > 20)
									{
										_0023l.WriteElementString(_0023ab._00239._00237(107393704), string.Empty);
										break;
									}
									_0023xc(new _0023Zc(item, _00230c: false), null);
									num++;
								}
							}
						}
					}
					catch
					{
					}
					_0023Kc(_0023Zc2);
				}
			}
		}
	}

	private void _0023Kc(_0023Zc _0023Lc)
	{
		FieldInfo[] fields = _0023Lc._0023a.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
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
					if (((Attribute)customAttributes[j]).GetType().Name == _0023ab._00239._00237(107393787))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					_0023xc(new _0023Zc(fieldInfo.GetValue(_0023Lc._0023b), _00230c: false), fieldInfo);
				}
			}
			catch
			{
			}
		}
		_0023Lc = new _0023Zc(_0023Lc._0023b, _0023Lc._0023a.BaseType, _0023Lc._0023c);
		if (!(_0023Lc._0023a == null))
		{
			using (new _0023Ge(_0023l, _0023ab._00239._00237(107394793)))
			{
				_0023Bc(_0023ab._00239._00237(107393727));
				_0023l.WriteAttributeString(_0023ab._00239._00237(107394684), _0023m.Count.ToString());
			}
			_0023m.Add(_0023Lc);
		}
	}

	internal bool _0023Oc()
	{
		try
		{
			_0023_0023._0023Af((_0023pd)this, _0023Hd._0023a);
			byte[] _0023id;
			try
			{
				_0023id = _0023Ic();
			}
			catch (Exception ex)
			{
				int num = -1;
				try
				{
					StackTrace stackTrace = new StackTrace(ex);
					if (stackTrace.FrameCount > 0)
					{
						num = stackTrace.GetFrame(stackTrace.FrameCount - 1)!.GetILOffset();
					}
				}
				catch
				{
				}
				_0023_0023._0023Af((_0023pd)this, _0023Hd._0023a, string.Format(_0023ab._00239._00237(107393718), ex.Message, num));
				return false;
			}
			_0023rf _0023jd = new _0023rf(_0023ab._00239._00237(107394305), _0023ab._00239._00237(107393685), _0023ab._00239._00237(107393636));
			return _0023_0023._0023ig(_0023id, _0023jd, (_0023pd)this);
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception _00234c)
		{
			_0023_0023._0023Yg(new _00233c(_00234c), this);
			return false;
		}
	}
}
