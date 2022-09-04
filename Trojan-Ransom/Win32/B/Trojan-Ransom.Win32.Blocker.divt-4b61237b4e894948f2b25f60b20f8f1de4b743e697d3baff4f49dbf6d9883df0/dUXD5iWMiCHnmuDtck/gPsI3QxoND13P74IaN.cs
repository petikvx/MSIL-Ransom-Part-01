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
using EZpwhZ2U8g14H9vX6C;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Vconsole;
using myQBLPqUahJ79JxFuJ;

namespace dUXD5iWMiCHnmuDtck;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class gPsI3QxoND13P74IaN
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class jE56luORoeLKynmi6F
	{
		public Form1 IFPpjy8x2;

		[ThreadStatic]
		private static Hashtable Wb71G46mn;

		public Form1 Form1
		{
			get
			{
				IFPpjy8x2 = t3Ps74IaN(IFPpjy8x2);
				return IFPpjy8x2;
			}
			set
			{
				while (true)
				{
					int num;
					if (value != IFPpjy8x2)
					{
						if (value != null)
						{
							break;
						}
						dUXDD5iMi(ref IFPpjy8x2);
						num = 5;
						if (BgEFCuLDDrlL2nmdkH())
						{
							return;
						}
					}
					else
					{
						_ = 0;
						if (rIG2uYtfC68vMucoQ2())
						{
							return;
						}
						num = 3;
						if (!rIG2uYtfC68vMucoQ2())
						{
							continue;
						}
					}
					switch (num)
					{
					case 4:
						continue;
					case 0:
					case 1:
					case 5:
						return;
					}
					break;
				}
				throw new ArgumentException("Property can only be set to Nothing");
			}
		}

		[DebuggerHidden]
		private static T t3Ps74IaN<T>(T Instance) where T : Form, new()
		{
			if (Instance != null && !((Control)Instance).get_IsDisposed())
			{
				return Instance;
			}
			if (Wb71G46mn != null)
			{
				if (Wb71G46mn.ContainsKey(typeof(T)))
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
				}
			}
			else
			{
				Wb71G46mn = new Hashtable();
			}
			Wb71G46mn.Add(typeof(T), null);
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
				string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException!.Message });
				throw new InvalidOperationException(resourceString, ex.InnerException);
			}
			finally
			{
				Wb71G46mn.Remove(typeof(T));
			}
		}

		[DebuggerHidden]
		private void dUXDD5iMi<T>(ref T gparam_0) where T : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public jE56luORoeLKynmi6F()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(AGeYTZfd6i2acMjeJo(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type SHnMmuDtc()
		{
			return w4cBDH2PyQgCe58jxo(typeof(jE56luORoeLKynmi6F).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		internal static bool rIG2uYtfC68vMucoQ2()
		{
			return true;
		}

		internal static bool BgEFCuLDDrlL2nmdkH()
		{
			return false;
		}

		internal static object AGeYTZfd6i2acMjeJo(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		internal static Type w4cBDH2PyQgCe58jxo(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Ejy8x278b7G46mnLk2
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object obj)
		{
			return HKUPicl2nJLcy7jVgU(this, Vpwws1vHDPywrlgsGx(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return nS6JoE9d2ICqdlft8v(this);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type ck2NvDHWH()
		{
			return typeof(Ejy8x278b7G46mnLk2);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T tdUEDy2Th<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void au5U2NDqR<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ejy8x278b7G46mnLk2()
		{
		}

		internal static object Vpwws1vHDPywrlgsGx(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		internal static bool HKUPicl2nJLcy7jVgU(object object_0, object object_1)
		{
			return object_0.Equals(object_1);
		}

		internal static bool aUCtFVwP81EVY5OZtN()
		{
			return true;
		}

		internal static bool ieebXbFMM8kdQXOamw()
		{
			return false;
		}

		internal static int nS6JoE9d2ICqdlft8v(object object_0)
		{
			return object_0.GetHashCode();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class xDHWH15dUDy2Th4u52<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T kiql2fStu;

		[SpecialName]
		[DebuggerHidden]
		internal T TPavvebcv()
		{
			if (kiql2fStu == null)
			{
				kiql2fStu = new T();
			}
			return kiql2fStu;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public xDHWH15dUDy2Th4u52()
		{
		}
	}

	private static readonly xDHWH15dUDy2Th4u52<VH1d5rIZ7umuF15IRi> N5r5Z7umu;

	private static readonly xDHWH15dUDy2Th4u52<fBfglFeIGB8QQYG99a> N15kIRiPZ;

	private static readonly xDHWH15dUDy2Th4u52<User> swhTZU8g1;

	private static xDHWH15dUDy2Th4u52<jE56luORoeLKynmi6F> aH9yvX6Cx;

	private static readonly xDHWH15dUDy2Th4u52<Ejy8x278b7G46mnLk2> EsIi3QoND;

	[HelpKeyword("My.Computer")]
	internal static VH1d5rIZ7umuF15IRi wSoj8a4Ut
	{
		[DebuggerHidden]
		get
		{
			return N5r5Z7umu.TPavvebcv();
		}
	}

	[HelpKeyword("My.Application")]
	internal static fBfglFeIGB8QQYG99a koSqMXqqI
	{
		[DebuggerHidden]
		get
		{
			return N15kIRiPZ.TPavvebcv();
		}
	}

	[HelpKeyword("My.User")]
	internal static User Lbi2IBfgl
	{
		[DebuggerHidden]
		get
		{
			return swhTZU8g1.TPavvebcv();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static jE56luORoeLKynmi6F Y99WayyQB
	{
		[DebuggerHidden]
		get
		{
			return aH9yvX6Cx.TPavvebcv();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Ejy8x278b7G46mnLk2 OxF7uJgH1
	{
		[DebuggerHidden]
		get
		{
			return EsIi3QoND.TPavvebcv();
		}
	}

	static gPsI3QxoND13P74IaN()
	{
		if (ErdFep6VRLOtPNPrD3())
		{
			switch (2)
			{
			case 2:
				N5r5Z7umu = new xDHWH15dUDy2Th4u52<VH1d5rIZ7umuF15IRi>();
				goto case 5;
			case 5:
				N15kIRiPZ = new xDHWH15dUDy2Th4u52<fBfglFeIGB8QQYG99a>();
				break;
			case 6:
				break;
			default:
				goto IL_0054;
			case 0:
			case 3:
				goto IL_0061;
			case 1:
			case 4:
				goto IL_006e;
			case 7:
				return;
			}
		}
		swhTZU8g1 = new xDHWH15dUDy2Th4u52<User>();
		goto IL_0054;
		IL_0054:
		YJXwflQdR6ByVaUOjo();
		if (ErdFep6VRLOtPNPrD3())
		{
			goto IL_0061;
		}
		goto IL_006e;
		IL_006e:
		EsIi3QoND = new xDHWH15dUDy2Th4u52<Ejy8x278b7G46mnLk2>();
		return;
		IL_0061:
		aH9yvX6Cx = new xDHWH15dUDy2Th4u52<jE56luORoeLKynmi6F>();
		goto IL_006e;
	}

	internal static bool ErdFep6VRLOtPNPrD3()
	{
		return true;
	}

	internal static bool YJXwflQdR6ByVaUOjo()
	{
		return false;
	}
}
