using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using B8a70nfPcJ9DoGa12G;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Windows_Media_Center;
using kk9RLFNZcCh8dgJJjF;
using o6Vt3sDunZAKonW1FG;
using slgtIAaxrEtv2vnjql;
using vQ4a1McgKSq6K6X39y;

namespace Xvc5U9juJtLRxdMpm8;

[HideModuleName]
[GeneratedCode("MyTemplate", "10.0.0.0")]
[StandardModule]
internal sealed class nJOkOiI03Joq9eJ9vx
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class eOolB3Zx2XXvOioih3
	{
		public object QJSrJwgWm;

		[ThreadStatic]
		private static Hashtable yGS11OoZ8;

		public Form1 Form1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				while (false)
				{
					_ = ((object[])null)[0];
				}
				QJSrJwgWm = Wpg0LBspw((Form1)QJSrJwgWm);
				return (Form1)QJSrJwgWm;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				//Discarded unreachable code: IL_0002, IL_0072
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 4;
				while (true)
				{
					switch (num)
					{
					case 4:
						if (value == QJSrJwgWm)
						{
							attG6WvZHLg7nPbBpw();
							num = ((!Vjptl90oi40UPhL36N()) ? 3 : 0);
							break;
						}
						if (value == null)
						{
							Qv3fGPR8V(ref System.Runtime.CompilerServices.Unsafe.As<object, Form1>(ref QJSrJwgWm));
							num = 5;
							if (1 == 0)
							{
								return;
							}
							break;
						}
						goto default;
					default:
						throw new ArgumentException(mb5iNAd8pqsS0bJh8L.dwXtr6E8mN(0));
					case 1:
					case 3:
						return;
					case 5:
						return;
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private static T Wpg0LBspw<T>(T Instance) where T : Form, new()
		{
			//Discarded unreachable code: IL_0002, IL_0106
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (Instance == null || ((Control)Instance).get_IsDisposed())
			{
				if (yGS11OoZ8 != null)
				{
					if (yGS11OoZ8.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString(mb5iNAd8pqsS0bJh8L.dwXtr6E8mN(74), new string[0]));
					}
				}
				else
				{
					yGS11OoZ8 = new Hashtable();
				}
				yGS11OoZ8.Add(typeof(T), null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError((Exception)ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString(mb5iNAd8pqsS0bJh8L.dwXtr6E8mN(134), new string[1] { ex.InnerException!.Message });
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					yGS11OoZ8.Remove(typeof(T));
				}
			}
			return Instance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void Qv3fGPR8V<T>(ref T _0020) where T : Form
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Component)_0020).Dispose();
			_0020 = default(T);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public eOolB3Zx2XXvOioih3()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Nj2rXmrpic7hwTlOBs();
			D1e3DauA9ASVSpudh4(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object _0020)
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rK5H9XxcMA6TjxQGaK(this, PE1CgLRrPgIA6S7ExZ(_0020));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zwuDJnVFmqHCZGthUI(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type FFxxRDGGD()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ceN0NiTa6hEIEjLDve(lYK2mrJQ8aeK3oDX9P(33554438));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)PqEpGOqBvEx9XZe5vV(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool attG6WvZHLg7nPbBpw()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vjptl90oi40UPhL36N()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Nj2rXmrpic7hwTlOBs()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			OGo1ZL8D0rpYTyrF8W.YQ2vTpjz4AREP();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void D1e3DauA9ASVSpudh4(object P_0)
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PE1CgLRrPgIA6S7ExZ(object P_0)
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RuntimeHelpers.GetObjectValue(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rK5H9XxcMA6TjxQGaK(object P_0, object P_1)
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0.Equals(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int zwuDJnVFmqHCZGthUI(object P_0)
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0.GetHashCode();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RuntimeTypeHandle lYK2mrJQ8aeK3oDX9P(int token)
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aJfe5GwnXBm8cr6nVw.j9AvTpg21sRgD(token);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Type ceN0NiTa6hEIEjLDve(RuntimeTypeHandle P_0)
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Type.GetTypeFromHandle(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PqEpGOqBvEx9XZe5vV(object P_0)
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class AGIuswlUT6b8ZbBHs8
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object _0020)
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yBZ4QcpHYVIoFZiTjZ(this, iTgC9wSmphGxYYMXRs(_0020));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EuNpZqZY3wOrnUu3XS(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type lVn7y6qxV()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ztjJSHB5vd0da2iG8F(gime1O55OLM0PYVH5h(33554439));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)clu7w2X119XCLHGbf6(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private static T YipQKRnVc<T>(T instance) where T : new()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void a6CwryUJo<T>(ref T _0020)
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_0020 = default(T);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public AGIuswlUT6b8ZbBHs8()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			A2y6L1olJO4Oip2gsa();
			FJFFhBL7IyeVnHtdVj(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iTgC9wSmphGxYYMXRs(object P_0)
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RuntimeHelpers.GetObjectValue(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yBZ4QcpHYVIoFZiTjZ(object P_0, object P_1)
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0.Equals(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RJL7ghNOK2SCURdub1()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ixBcaB4Pv3QeMvx4Vt()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int EuNpZqZY3wOrnUu3XS(object P_0)
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0.GetHashCode();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RuntimeTypeHandle gime1O55OLM0PYVH5h(int token)
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aJfe5GwnXBm8cr6nVw.j9AvTpg21sRgD(token);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Type ztjJSHB5vd0da2iG8F(RuntimeTypeHandle P_0)
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Type.GetTypeFromHandle(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object clu7w2X119XCLHGbf6(object P_0)
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0.ToString();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void A2y6L1olJO4Oip2gsa()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			OGo1ZL8D0rpYTyrF8W.YQ2vTpjz4AREP();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FJFFhBL7IyeVnHtdVj(object P_0)
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class a8G97tJrgHp6tBeMmP<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T Qtgnuiy64;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[DebuggerHidden]
		internal T aqOg8U0Qu()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (Qtgnuiy64 == null)
			{
				Qtgnuiy64 = new T();
			}
			return Qtgnuiy64;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public a8G97tJrgHp6tBeMmP()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			OGo1ZL8D0rpYTyrF8W.YQ2vTpjz4AREP();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zEyogf3tWWDeiFe5wX()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Sy9HI36ubhws7Shd3f()
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly a8G97tJrgHp6tBeMmP<Ey3Z4a3lNditO9lrSI> GM5ZA7gVv;

	private static readonly a8G97tJrgHp6tBeMmP<OrQmS3v7UcCaxRBKOI> DlPv6TuYC;

	private static readonly a8G97tJrgHp6tBeMmP<User> WuQcmlTLU;

	private static a8G97tJrgHp6tBeMmP<eOolB3Zx2XXvOioih3> IFsNZcfnd;

	private static readonly a8G97tJrgHp6tBeMmP<AGIuswlUT6b8ZbBHs8> oCUp5CIBn;

	[HelpKeyword("My.Computer")]
	internal static Ey3Z4a3lNditO9lrSI OpbYrrJi3
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		get
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GM5ZA7gVv.aqOg8U0Qu();
		}
	}

	[HelpKeyword("My.Application")]
	internal static OrQmS3v7UcCaxRBKOI FeqDFiQRm
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		get
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DlPv6TuYC.aqOg8U0Qu();
		}
	}

	[HelpKeyword("My.User")]
	internal static User aoYdPAKq6
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		get
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WuQcmlTLU.aqOg8U0Qu();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static eOolB3Zx2XXvOioih3 swFIL8AHN
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		get
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IFsNZcfnd.aqOg8U0Qu();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static AGIuswlUT6b8ZbBHs8 gwsUkeZv6
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		get
		{
			//Discarded unreachable code: IL_0002
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oCUp5CIBn.aqOg8U0Qu();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static nJOkOiI03Joq9eJ9vx()
	{
		//Discarded unreachable code: IL_0002, IL_0049
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (mQmI5bEHisF8okf771() ? 4 : 5);
		while (true)
		{
			switch (num)
			{
			case 2:
				IFsNZcfnd = new a8G97tJrgHp6tBeMmP<eOolB3Zx2XXvOioih3>();
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
				WuQcmlTLU = new a8G97tJrgHp6tBeMmP<User>();
				goto case 2;
			default:
				num = 2;
				break;
			case 0:
			case 5:
				L570fUUWCDBMXBu6DY();
				goto case 1;
			case 1:
			case 4:
				GM5ZA7gVv = new a8G97tJrgHp6tBeMmP<Ey3Z4a3lNditO9lrSI>();
				num = 6;
				break;
			case 6:
				DlPv6TuYC = new a8G97tJrgHp6tBeMmP<OrQmS3v7UcCaxRBKOI>();
				num = 3;
				break;
			case 7:
				oCUp5CIBn = new a8G97tJrgHp6tBeMmP<AGIuswlUT6b8ZbBHs8>();
				num = 8;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void L570fUUWCDBMXBu6DY()
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		OGo1ZL8D0rpYTyrF8W.YQ2vTpjz4AREP();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mR2fjgs5TvgnfPJ8RU()
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mQmI5bEHisF8okf771()
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
