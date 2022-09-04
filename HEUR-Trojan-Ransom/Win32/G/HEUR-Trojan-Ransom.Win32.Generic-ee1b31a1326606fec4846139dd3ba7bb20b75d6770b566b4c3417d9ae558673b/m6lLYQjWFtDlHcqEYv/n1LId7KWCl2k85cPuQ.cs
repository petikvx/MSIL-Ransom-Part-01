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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Mini;
using OvKuilgtOADYpdVrWF;
using RcL1efDCu5FSR27yEL;

namespace m6lLYQjWFtDlHcqEYv;

[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
internal sealed class n1LId7KWCl2k85cPuQ
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class j9FRA7w61bFaJkXjgD
	{
		public Min BZFy64JLD;

		[ThreadStatic]
		private static Hashtable G7hEahnkx;

		public Min Min
		{
			[DebuggerNonUserCode]
			get
			{
				BZFy64JLD = fDlVHcqEY(BZFy64JLD);
				return BZFy64JLD;
			}
			[DebuggerNonUserCode]
			set
			{
				while (true)
				{
					bool flag = value == BZFy64JLD;
					_ = 1;
					if (LnE2aOaQuOHpSVap4b())
					{
						break;
					}
					while (true)
					{
						IL_0062:
						if (flag)
						{
							return;
						}
						flag = value != null;
						while (!flag)
						{
							jv9PFRA76(ref BZFy64JLD);
							if (LnE2aOaQuOHpSVap4b())
							{
							}
							switch (7)
							{
							case 0:
								break;
							default:
								continue;
							case 1:
							case 2:
								goto IL_0062;
							case 4:
							case 6:
								goto end_IL_0001;
							case 3:
							case 7:
								return;
							}
							goto end_IL_0062;
						}
						goto end_IL_0001;
						continue;
						end_IL_0062:
						break;
					}
					continue;
					end_IL_0001:
					break;
				}
				throw new ArgumentException("Property can only be set to Nothing");
			}
		}

		[DebuggerHidden]
		private static T fDlVHcqEY<T>(T Instance) where T : Form, new()
		{
			if ((Instance == null || ((Control)Instance).get_IsDisposed()) ? true : false)
			{
				if (G7hEahnkx != null)
				{
					if (G7hEahnkx.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					G7hEahnkx = new Hashtable();
				}
				G7hEahnkx.Add(typeof(T), null);
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
					G7hEahnkx.Remove(typeof(T));
				}
			}
			return Instance;
		}

		[DebuggerHidden]
		private void jv9PFRA76<T>(ref T gparam_0) where T : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public j9FRA7w61bFaJkXjgD()
		{
			hn0dDr0hDmdwRyXQNH(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return ovYyalYh2r5ZUNlwSI(this, RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type wbF3aJkXj()
		{
			return typeof(j9FRA7w61bFaJkXjgD);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return (string)MOtFvqIKqvu8RBCSsW(this);
		}

		internal static bool euUaspdi7W9j3MvWqy()
		{
			return true;
		}

		internal static bool LnE2aOaQuOHpSVap4b()
		{
			return false;
		}

		internal static void hn0dDr0hDmdwRyXQNH(object object_0)
		{
			object_0._002Ector();
		}

		internal static bool ovYyalYh2r5ZUNlwSI(object object_0, object object_1)
		{
			return object_0.Equals(object_1);
		}

		internal static object MOtFvqIKqvu8RBCSsW(object object_0)
		{
			return object_0.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class xOVVobvfPXsmvrf4ZF
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return CcnBrDSIqEQqWCpFUn(this, po3C3P64rE5NGZekHx(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type RVMF4bi01()
		{
			return KGef3IubeAwwOFilad(typeof(xOVVobvfPXsmvrf4ZF).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return (string)IoXYarZns0V3mMhIdd(this);
		}

		[DebuggerHidden]
		private static T PD810Xb2r<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void f7hLo197P<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public xOVVobvfPXsmvrf4ZF()
		{
		}

		internal static object po3C3P64rE5NGZekHx(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		internal static bool CcnBrDSIqEQqWCpFUn(object object_0, object object_1)
		{
			return object_0.Equals(object_1);
		}

		internal static bool Kes2Ain6QcuGD5H9GI()
		{
			return true;
		}

		internal static bool VyK1iErXtP4clwUjFP()
		{
			return false;
		}

		internal static Type KGef3IubeAwwOFilad(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		internal static object IoXYarZns0V3mMhIdd(object object_0)
		{
			return object_0.ToString();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class U4JLDm27hahnkxpVM4<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T tZwYiHOES;

		[SpecialName]
		[DebuggerHidden]
		internal T CcDHYsBK8()
		{
			if (tZwYiHOES == null)
			{
				tZwYiHOES = new T();
			}
			return tZwYiHOES;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public U4JLDm27hahnkxpVM4()
		{
		}

		internal static bool af78v9MCODAMkkZ3XB()
		{
			return true;
		}

		internal static bool QQmcaXHN2lWsliWBWB()
		{
			return false;
		}
	}

	private static readonly U4JLDm27hahnkxpVM4<vIxLKptFMcOMfZPKpF> y1esfCu5F;

	private static readonly U4JLDm27hahnkxpVM4<Ryv8qU0ocgjO8PKwtb> aR2x7yELx;

	private static readonly U4JLDm27hahnkxpVM4<User> wLIRd7WCl;

	private static U4JLDm27hahnkxpVM4<j9FRA7w61bFaJkXjgD> kk8l5cPuQ;

	private static readonly U4JLDm27hahnkxpVM4<xOVVobvfPXsmvrf4ZF> m6lWLYQWF;

	[HelpKeyword("My.Computer")]
	internal static vIxLKptFMcOMfZPKpF kLSgB42EK
	{
		[DebuggerHidden]
		get
		{
			return y1esfCu5F.CcDHYsBK8();
		}
	}

	[HelpKeyword("My.Application")]
	internal static Ryv8qU0ocgjO8PKwtb ifnDTyv8q
	{
		[DebuggerHidden]
		get
		{
			return aR2x7yELx.CcDHYsBK8();
		}
	}

	[HelpKeyword("My.User")]
	internal static User hwtjbovKu
	{
		[DebuggerHidden]
		get
		{
			return wLIRd7WCl.CcDHYsBK8();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static j9FRA7w61bFaJkXjgD VVrvWFEIx
	{
		[DebuggerHidden]
		get
		{
			return kk8l5cPuQ.CcDHYsBK8();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static xOVVobvfPXsmvrf4ZF PZPIKpFpc
	{
		[DebuggerHidden]
		get
		{
			return m6lWLYQWF.CcDHYsBK8();
		}
	}

	[DebuggerNonUserCode]
	static n1LId7KWCl2k85cPuQ()
	{
		int num = 6;
		if (!Ct3nqX3iPwxcqIokrV())
		{
		}
		while (true)
		{
			switch (num)
			{
			case 6:
				y1esfCu5F = new U4JLDm27hahnkxpVM4<vIxLKptFMcOMfZPKpF>();
				goto case 5;
			case 5:
				aR2x7yELx = new U4JLDm27hahnkxpVM4<Ryv8qU0ocgjO8PKwtb>();
				_ = 1;
				if (Ct3nqX3iPwxcqIokrV())
				{
					num = 0;
					if (!Ct3nqX3iPwxcqIokrV())
					{
						continue;
					}
					break;
				}
				goto case 2;
			case 2:
			case 4:
				wLIRd7WCl = new U4JLDm27hahnkxpVM4<User>();
				goto default;
			default:
				kk8l5cPuQ = new U4JLDm27hahnkxpVM4<j9FRA7w61bFaJkXjgD>();
				break;
			case 1:
				break;
			case 7:
				return;
			}
			m6lWLYQWF = new U4JLDm27hahnkxpVM4<xOVVobvfPXsmvrf4ZF>();
			num = 7;
			if (!Ct3nqX3iPwxcqIokrV())
			{
			}
		}
	}

	internal static bool sOH0jKv6oS6uxW81vX()
	{
		return true;
	}

	internal static bool Ct3nqX3iPwxcqIokrV()
	{
		return false;
	}
}
