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
using Jz67;
using Lz89;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Rp35;
using Yk48;
using i2B5;
using j0PK;
using p8X3;
using q3QC;
using r8L7;

namespace Ja8i;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Jt2b
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class y4N7
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gx38 m_AddCTHD;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s1W0 m_AddHD;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qj4i m_AddKH;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ey8s m_AddLSP;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t6J2 m_AddSp;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Aa2j m_EditKH;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t5G1 m_Form1;

		public Gx38 AddCTHD
		{
			[DebuggerHidden]
			get
			{
				m_AddCTHD = w9EG(m_AddCTHD);
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
					e4K2(ref m_AddCTHD);
				}
			}
		}

		public s1W0 AddHD
		{
			[DebuggerHidden]
			get
			{
				m_AddHD = w9EG(m_AddHD);
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
					e4K2(ref m_AddHD);
				}
			}
		}

		public Qj4i AddKH
		{
			[DebuggerHidden]
			get
			{
				m_AddKH = w9EG(m_AddKH);
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
					e4K2(ref m_AddKH);
				}
			}
		}

		public Ey8s AddLSP
		{
			[DebuggerHidden]
			get
			{
				m_AddLSP = w9EG(m_AddLSP);
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
					e4K2(ref m_AddLSP);
				}
			}
		}

		public t6J2 AddSp
		{
			[DebuggerHidden]
			get
			{
				m_AddSp = w9EG(m_AddSp);
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
					e4K2(ref m_AddSp);
				}
			}
		}

		public Aa2j EditKH
		{
			[DebuggerHidden]
			get
			{
				m_EditKH = w9EG(m_EditKH);
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
					e4K2(ref m_EditKH);
				}
			}
		}

		public t5G1 Form1
		{
			[DebuggerHidden]
			get
			{
				m_Form1 = w9EG(m_Form1);
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
					e4K2(ref m_Form1);
				}
			}
		}

		[DebuggerHidden]
		private static q8CM w9EG<q8CM>(q8CM To97) where q8CM : Form, new()
		{
			if (To97 == null || ((Control)To97).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(q8CM)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(q8CM), null);
				try
				{
					return new q8CM();
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
					m_FormBeingCreated.Remove(typeof(q8CM));
				}
			}
			return To97;
		}

		[DebuggerHidden]
		private void e4K2<e4HL>(ref e4HL p9XH) where e4HL : Form
		{
			((Component)p9XH).Dispose();
			p9XH = default(e4HL);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public y4N7()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Cc8k(object Bs12)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Bs12));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int b7R9()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type m9LC()
		{
			return typeof(y4N7);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Jg6a()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class d9F8
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Go95(object j9L1)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(j9L1));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Hd12()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Fw07()
		{
			return typeof(d9F8);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Re43()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static d0S1 w3G9<d0S1>(d0S1 Hb23) where d0S1 : new()
		{
			if (Hb23 == null)
			{
				return new d0S1();
			}
			return Hb23;
		}

		[DebuggerHidden]
		private void Qa6c<t3Z2>(ref t3Z2 q4M5)
		{
			q4M5 = default(t3Z2);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public d9F8()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Tr59<Tq7n> where Tq7n : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static Tq7n m_ThreadStaticValue;

		internal Tq7n GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Tq7n();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tr59()
		{
		}
	}

	private static readonly Tr59<q2N6> m_ComputerObjectProvider = new Tr59<q2N6>();

	private static readonly Tr59<Km7w> m_AppObjectProvider = new Tr59<Km7w>();

	private static readonly Tr59<User> m_UserObjectProvider = new Tr59<User>();

	private static Tr59<y4N7> m_MyFormsObjectProvider = new Tr59<y4N7>();

	private static readonly Tr59<d9F8> m_MyWebServicesObjectProvider = new Tr59<d9F8>();

	[HelpKeyword("My.Computer")]
	internal static q2N6 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Km7w Application
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
	internal static y4N7 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static d9F8 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
