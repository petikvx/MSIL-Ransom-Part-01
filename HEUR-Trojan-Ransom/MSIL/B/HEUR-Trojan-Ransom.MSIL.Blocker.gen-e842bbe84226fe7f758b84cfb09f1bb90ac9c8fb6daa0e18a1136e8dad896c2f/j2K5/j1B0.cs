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
using As38;
using Fq7;
using Hf6p;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Qb9d;
using c1EG;
using f1C;
using k3Q9;
using o0TY;
using w1SN;

namespace j2K5;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class j1B0
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class d0F8
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public f8R1 m_AddCTHD;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public r1D3 m_AddHD;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public p8N1 m_AddKH;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ck9z m_AddLSP;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public i6K7 m_AddSp;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ks8 m_EditKH;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public a6L m_Form1;

		public f8R1 AddCTHD
		{
			[DebuggerHidden]
			get
			{
				m_AddCTHD = t5F7(m_AddCTHD);
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
					Re47(ref m_AddCTHD);
				}
			}
		}

		public r1D3 AddHD
		{
			[DebuggerHidden]
			get
			{
				m_AddHD = t5F7(m_AddHD);
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
					Re47(ref m_AddHD);
				}
			}
		}

		public p8N1 AddKH
		{
			[DebuggerHidden]
			get
			{
				m_AddKH = t5F7(m_AddKH);
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
					Re47(ref m_AddKH);
				}
			}
		}

		public Ck9z AddLSP
		{
			[DebuggerHidden]
			get
			{
				m_AddLSP = t5F7(m_AddLSP);
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
					Re47(ref m_AddLSP);
				}
			}
		}

		public i6K7 AddSp
		{
			[DebuggerHidden]
			get
			{
				m_AddSp = t5F7(m_AddSp);
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
					Re47(ref m_AddSp);
				}
			}
		}

		public Ks8 EditKH
		{
			[DebuggerHidden]
			get
			{
				m_EditKH = t5F7(m_EditKH);
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
					Re47(ref m_EditKH);
				}
			}
		}

		public a6L Form1
		{
			[DebuggerHidden]
			get
			{
				m_Form1 = t5F7(m_Form1);
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
					Re47(ref m_Form1);
				}
			}
		}

		[DebuggerHidden]
		private static Ha61 t5F7<Ha61>(Ha61 Gz7n) where Ha61 : Form, new()
		{
			if (Gz7n == null || ((Control)Gz7n).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Ha61)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Ha61), null);
				try
				{
					return new Ha61();
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
					m_FormBeingCreated.Remove(typeof(Ha61));
				}
			}
			return Gz7n;
		}

		[DebuggerHidden]
		private void Re47<j4MB>(ref j4MB q3RH) where j4MB : Form
		{
			((Component)q3RH).Dispose();
			q3RH = default(j4MB);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public d0F8()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool j3J8(object k9D3)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(k9D3));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int i9S6()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type n6HZ()
		{
			return typeof(d0F8);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string p7G9()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class c0W6
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool n0T3(object Yr5o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Yr5o));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Sf09()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Jz48()
		{
			return typeof(c0W6);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Df80()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Rj91 k9B7<Rj91>(Rj91 c6X8) where Rj91 : new()
		{
			if (c6X8 == null)
			{
				return new Rj91();
			}
			return c6X8;
		}

		[DebuggerHidden]
		private void Ey2e<t1RK>(ref t1RK Jo36)
		{
			Jo36 = default(t1RK);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public c0W6()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class g1EB<b8RA> where b8RA : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static b8RA m_ThreadStaticValue;

		internal b8RA GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new b8RA();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public g1EB()
		{
		}
	}

	private static readonly g1EB<x7KC> m_ComputerObjectProvider = new g1EB<x7KC>();

	private static readonly g1EB<o6TB> m_AppObjectProvider = new g1EB<o6TB>();

	private static readonly g1EB<User> m_UserObjectProvider = new g1EB<User>();

	private static g1EB<d0F8> m_MyFormsObjectProvider = new g1EB<d0F8>();

	private static readonly g1EB<c0W6> m_MyWebServicesObjectProvider = new g1EB<c0W6>();

	[HelpKeyword("My.Computer")]
	internal static x7KC Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static o6TB Application
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
	internal static d0F8 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static c0W6 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
