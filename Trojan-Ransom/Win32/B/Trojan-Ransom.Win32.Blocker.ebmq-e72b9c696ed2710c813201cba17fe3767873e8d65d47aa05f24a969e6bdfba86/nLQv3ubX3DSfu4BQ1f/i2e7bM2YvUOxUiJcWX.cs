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
using Botom;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using svKc2ql5ZbiYmJAiYC;
using xl7YkIY46t0tbFwAl2;

namespace nLQv3ubX3DSfu4BQ1f;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class i2e7bM2YvUOxUiJcWX
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class oU1P0tUqXAvxSc9W3P
	{
		public Form1 jNvJUmv4T;

		[ThreadStatic]
		private static Hashtable CO8SPiJDl;

		public Form1 Form1
		{
			get
			{
				jNvJUmv4T = ryqOItjNE(jNvJUmv4T);
				return jNvJUmv4T;
			}
			set
			{
				V5QvR1yQacZ8NaFgX2();
				if (!T4E5v9gopJC7Sfc7xd())
				{
					if (V5QvR1yQacZ8NaFgX2())
					{
					}
					switch (3)
					{
					case 0:
					case 4:
						break;
					case 1:
					case 3:
						return;
					default:
						goto IL_0048;
					case 5:
						return;
					}
				}
				if (value == jNvJUmv4T)
				{
					return;
				}
				if (value == null)
				{
					oKjH1UR2u(ref jNvJUmv4T);
					return;
				}
				goto IL_0048;
				IL_0048:
				throw new ArgumentException("Property can only be set to Nothing");
			}
		}

		[DebuggerHidden]
		private static T ryqOItjNE<T>(T Instance) where T : Form, new()
		{
			if (Instance != null && !((Control)Instance).get_IsDisposed())
			{
				return Instance;
			}
			if (CO8SPiJDl != null)
			{
				if (CO8SPiJDl.ContainsKey(typeof(T)))
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
				}
			}
			else
			{
				CO8SPiJDl = new Hashtable();
			}
			CO8SPiJDl.Add(typeof(T), null);
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
				CO8SPiJDl.Remove(typeof(T));
			}
		}

		[DebuggerHidden]
		private void oKjH1UR2u<T>(ref T gparam_0) where T : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public oU1P0tUqXAvxSc9W3P()
		{
			l0f1nXKa5FXRQPfelV(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return knV7ZeNKsWEyV0y2DZ(this, Qok4bVsb9PJJxOSlAu(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return ncLo3rFUgbylJxxwmJ(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type HhOnJtgBn()
		{
			return yPWrlhuBO4gvSpXXrr(typeof(oU1P0tUqXAvxSc9W3P).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return (string)JKQrFaTpwb8ImVpLH0(this);
		}

		internal static bool T4E5v9gopJC7Sfc7xd()
		{
			return true;
		}

		internal static bool V5QvR1yQacZ8NaFgX2()
		{
			return false;
		}

		internal static void l0f1nXKa5FXRQPfelV(object object_0)
		{
			object_0._002Ector();
		}

		internal static object Qok4bVsb9PJJxOSlAu(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		internal static bool knV7ZeNKsWEyV0y2DZ(object object_0, object object_1)
		{
			return object_0.Equals(object_1);
		}

		internal static int ncLo3rFUgbylJxxwmJ(object object_0)
		{
			return object_0.GetHashCode();
		}

		internal static Type yPWrlhuBO4gvSpXXrr(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		internal static object JKQrFaTpwb8ImVpLH0(object object_0)
		{
			return object_0.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class zp34MELSnb5W93dLYO
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(ACLpHbfRmRRNDpOAo1(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return ebay2arcmSavb3xOQh(this);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type C01TvcvYb()
		{
			return typeof(zp34MELSnb5W93dLYO);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return (string)vNrLRUGXOKqGYYK6En(this);
		}

		[DebuggerHidden]
		private static T BObKxvhst<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void pnMQHEXaq<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public zp34MELSnb5W93dLYO()
		{
			PgngCwUYAW6LwAApXf(this);
		}

		internal static object ACLpHbfRmRRNDpOAo1(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		internal static bool kOQ9IlWFtgEvpJrGbA()
		{
			return true;
		}

		internal static bool AqkHoSBSuoruIXoEnW()
		{
			return false;
		}

		internal static int ebay2arcmSavb3xOQh(object object_0)
		{
			return object_0.GetHashCode();
		}

		internal static object vNrLRUGXOKqGYYK6En(object object_0)
		{
			return object_0.ToString();
		}

		internal static void PgngCwUYAW6LwAApXf(object object_0)
		{
			object_0._002Ector();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class wsGTNnDgSXSE4DP1cT<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T C2AixJQek;

		[SpecialName]
		[DebuggerHidden]
		internal T KdiXRbbNy()
		{
			if (C2AixJQek == null)
			{
				C2AixJQek = new T();
			}
			return C2AixJQek;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public wsGTNnDgSXSE4DP1cT()
		{
		}
	}

	private static readonly wsGTNnDgSXSE4DP1cT<d9tltFQTLnWvaY2l2D> ro4m3RudI;

	private static readonly wsGTNnDgSXSE4DP1cT<QWkmT5kb6y5doMXENx> M9S2ESmhy;

	private static readonly wsGTNnDgSXSE4DP1cT<User> vewbTg9WW;

	private static wsGTNnDgSXSE4DP1cT<oU1P0tUqXAvxSc9W3P> gF3DAjJwq;

	private static readonly wsGTNnDgSXSE4DP1cT<zp34MELSnb5W93dLYO> jN2ZfBMQJ;

	[HelpKeyword("My.Computer")]
	internal static d9tltFQTLnWvaY2l2D DMa1cso3A
	{
		[DebuggerHidden]
		get
		{
			return ro4m3RudI.KdiXRbbNy();
		}
	}

	[HelpKeyword("My.Application")]
	internal static QWkmT5kb6y5doMXENx PQ6FVMEjI
	{
		[DebuggerHidden]
		get
		{
			return M9S2ESmhy.KdiXRbbNy();
		}
	}

	[HelpKeyword("My.User")]
	internal static User apvhTB7Lw
	{
		[DebuggerHidden]
		get
		{
			return vewbTg9WW.KdiXRbbNy();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static oU1P0tUqXAvxSc9W3P SLZ8fHes9
	{
		[DebuggerHidden]
		get
		{
			return gF3DAjJwq.KdiXRbbNy();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static zp34MELSnb5W93dLYO MR1Pyxb0k
	{
		[DebuggerHidden]
		get
		{
			return jN2ZfBMQJ.KdiXRbbNy();
		}
	}

	static i2e7bM2YvUOxUiJcWX()
	{
		_ = 1;
		if (!eIAHqPd3rLGX5xbDEd())
		{
			ro4m3RudI = new wsGTNnDgSXSE4DP1cT<d9tltFQTLnWvaY2l2D>();
			M9S2ESmhy = new wsGTNnDgSXSE4DP1cT<QWkmT5kb6y5doMXENx>();
			vewbTg9WW = new wsGTNnDgSXSE4DP1cT<User>();
		}
		gF3DAjJwq = new wsGTNnDgSXSE4DP1cT<oU1P0tUqXAvxSc9W3P>();
		jN2ZfBMQJ = new wsGTNnDgSXSE4DP1cT<zp34MELSnb5W93dLYO>();
	}

	internal static bool k01EfaIGe7d8lyEuZR()
	{
		return true;
	}

	internal static bool eIAHqPd3rLGX5xbDEd()
	{
		return false;
	}
}
