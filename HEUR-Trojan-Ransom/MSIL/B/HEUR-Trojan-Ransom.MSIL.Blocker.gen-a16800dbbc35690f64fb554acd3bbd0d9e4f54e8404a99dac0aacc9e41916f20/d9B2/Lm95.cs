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
using Ak43;
using Bj2x;
using Kf82;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Nz6;
using Qw2;
using Wr1g;
using i9P;
using j5L;
using o4T;

namespace d9B2;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Lm95
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class x9DE
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public e9Z m_AddCTHD;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ra2 m_AddHD;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x0R m_AddKH;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ga5z m_AddLSP;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b8QK m_AddSp;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x4PY m_EditKH;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ze1 m_Form1;

		public e9Z AddCTHD
		{
			[DebuggerHidden]
			get
			{
				m_AddCTHD = d3JL(m_AddCTHD);
				return m_AddCTHD;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AddCTHD)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Np74(ref m_AddCTHD);
				}
			}
		}

		public Ra2 AddHD
		{
			[DebuggerHidden]
			get
			{
				m_AddHD = d3JL(m_AddHD);
				return m_AddHD;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AddHD)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Np74(ref m_AddHD);
				}
			}
		}

		public x0R AddKH
		{
			[DebuggerHidden]
			get
			{
				m_AddKH = d3JL(m_AddKH);
				return m_AddKH;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AddKH)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Np74(ref m_AddKH);
				}
			}
		}

		public Ga5z AddLSP
		{
			[DebuggerHidden]
			get
			{
				m_AddLSP = d3JL(m_AddLSP);
				return m_AddLSP;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AddLSP)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Np74(ref m_AddLSP);
				}
			}
		}

		public b8QK AddSp
		{
			[DebuggerHidden]
			get
			{
				m_AddSp = d3JL(m_AddSp);
				return m_AddSp;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AddSp)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Np74(ref m_AddSp);
				}
			}
		}

		public x4PY EditKH
		{
			[DebuggerHidden]
			get
			{
				m_EditKH = d3JL(m_EditKH);
				return m_EditKH;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_EditKH)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Np74(ref m_EditKH);
				}
			}
		}

		public Ze1 Form1
		{
			[DebuggerHidden]
			get
			{
				m_Form1 = d3JL(m_Form1);
				return m_Form1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Form1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Np74(ref m_Form1);
				}
			}
		}

		[DebuggerHidden]
		private static Md9x d3JL<Md9x>(Md9x x6BE) where Md9x : Form, new()
		{
			if (x6BE == null || ((Control)x6BE).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Md9x)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Md9x), null);
				try
				{
					return new Md9x();
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
					m_FormBeingCreated.Remove(typeof(Md9x));
				}
			}
			return x6BE;
		}

		[DebuggerHidden]
		private void Np74<Po78>(ref Po78 Zj50) where Po78 : Form
		{
			((Component)Zj50).Dispose();
			Zj50 = default(Po78);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public x9DE()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool d4R7(object Qj1n)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Qj1n));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Zr34()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type q5E2()
		{
			return typeof(x9DE);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string y4SN()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Nn30
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool s2XH(object r5NK)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(r5NK));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Bj8y()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type p3L1()
		{
			return typeof(Nn30);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Yj4e()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static k3F7 Td0n<k3F7>(k3F7 o6Q0) where k3F7 : new()
		{
			if (o6Q0 == null)
			{
				return new k3F7();
			}
			return o6Q0;
		}

		[DebuggerHidden]
		private void Xo2f<Le3p>(ref Le3p Xx3a)
		{
			Xx3a = default(Le3p);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Nn30()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class g0RJ<Go71> where Go71 : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static Go71 m_ThreadStaticValue;

		internal Go71 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Go71();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public g0RJ()
		{
		}
	}

	private static readonly g0RJ<e7X4> m_ComputerObjectProvider = new g0RJ<e7X4>();

	private static readonly g0RJ<y7B> m_AppObjectProvider = new g0RJ<y7B>();

	private static readonly g0RJ<User> m_UserObjectProvider = new g0RJ<User>();

	private static g0RJ<x9DE> m_MyFormsObjectProvider = new g0RJ<x9DE>();

	private static readonly g0RJ<Nn30> m_MyWebServicesObjectProvider = new g0RJ<Nn30>();

	[HelpKeyword("My.Computer")]
	internal static e7X4 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static y7B Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static x9DE Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Nn30 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
