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
using Bn6;
using Dg4;
using Dg7r;
using Dw32;
using Ld9;
using Lk93;
using Lt45;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Pp36;
using Rj4;
using Wk8;
using Ws8;
using Zf87;
using m5C;
using p4RJ;
using w5E6;
using y0E;

namespace Po7y;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Yi20
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Dt30
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hr23 m_AddmisionForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qg32 m_AddmisionForm1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k7W1 m_AddUser;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c1SF m_ClassDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public f0X5 m_ClassDetail1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g8T2 m_Course;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public e3Y m_Course1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m7Q m_LoginForm1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Rj3 m_MENUS;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d9W m_SearchForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y7F m_Startup;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lj6 m_Subject;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gs7 m_Subject1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bn5 m_Viewer;

		public Hr23 AddmisionForm
		{
			[DebuggerHidden]
			get
			{
				m_AddmisionForm = Xc27(m_AddmisionForm);
				return m_AddmisionForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AddmisionForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					k4SR(ref m_AddmisionForm);
				}
			}
		}

		public Qg32 AddmisionForm1
		{
			[DebuggerHidden]
			get
			{
				m_AddmisionForm1 = Xc27(m_AddmisionForm1);
				return m_AddmisionForm1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AddmisionForm1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					k4SR(ref m_AddmisionForm1);
				}
			}
		}

		public k7W1 AddUser
		{
			[DebuggerHidden]
			get
			{
				m_AddUser = Xc27(m_AddUser);
				return m_AddUser;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AddUser)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					k4SR(ref m_AddUser);
				}
			}
		}

		public c1SF ClassDetail
		{
			[DebuggerHidden]
			get
			{
				m_ClassDetail = Xc27(m_ClassDetail);
				return m_ClassDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ClassDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					k4SR(ref m_ClassDetail);
				}
			}
		}

		public f0X5 ClassDetail1
		{
			[DebuggerHidden]
			get
			{
				m_ClassDetail1 = Xc27(m_ClassDetail1);
				return m_ClassDetail1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ClassDetail1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					k4SR(ref m_ClassDetail1);
				}
			}
		}

		public g8T2 Course
		{
			[DebuggerHidden]
			get
			{
				m_Course = Xc27(m_Course);
				return m_Course;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Course)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					k4SR(ref m_Course);
				}
			}
		}

		public e3Y Course1
		{
			[DebuggerHidden]
			get
			{
				m_Course1 = Xc27(m_Course1);
				return m_Course1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Course1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					k4SR(ref m_Course1);
				}
			}
		}

		public m7Q LoginForm1
		{
			[DebuggerHidden]
			get
			{
				m_LoginForm1 = Xc27(m_LoginForm1);
				return m_LoginForm1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_LoginForm1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					k4SR(ref m_LoginForm1);
				}
			}
		}

		public Rj3 MENUS
		{
			[DebuggerHidden]
			get
			{
				m_MENUS = Xc27(m_MENUS);
				return m_MENUS;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_MENUS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					k4SR(ref m_MENUS);
				}
			}
		}

		public d9W SearchForm
		{
			[DebuggerHidden]
			get
			{
				m_SearchForm = Xc27(m_SearchForm);
				return m_SearchForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_SearchForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					k4SR(ref m_SearchForm);
				}
			}
		}

		public y7F Startup
		{
			[DebuggerHidden]
			get
			{
				m_Startup = Xc27(m_Startup);
				return m_Startup;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Startup)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					k4SR(ref m_Startup);
				}
			}
		}

		public Lj6 Subject
		{
			[DebuggerHidden]
			get
			{
				m_Subject = Xc27(m_Subject);
				return m_Subject;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Subject)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					k4SR(ref m_Subject);
				}
			}
		}

		public Gs7 Subject1
		{
			[DebuggerHidden]
			get
			{
				m_Subject1 = Xc27(m_Subject1);
				return m_Subject1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Subject1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					k4SR(ref m_Subject1);
				}
			}
		}

		public Bn5 Viewer
		{
			[DebuggerHidden]
			get
			{
				m_Viewer = Xc27(m_Viewer);
				return m_Viewer;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Viewer)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					k4SR(ref m_Viewer);
				}
			}
		}

		[DebuggerHidden]
		private static Qf38 Xc27<Qf38>(Qf38 Zx1c) where Qf38 : Form, new()
		{
			if (Zx1c == null || ((Control)Zx1c).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Qf38)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Qf38), null);
				try
				{
					return new Qf38();
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
					m_FormBeingCreated.Remove(typeof(Qf38));
				}
			}
			return Zx1c;
		}

		[DebuggerHidden]
		private void k4SR<o0FX>(ref o0FX Dc0j) where o0FX : Form
		{
			((Component)Dc0j).Dispose();
			Dc0j = default(o0FX);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Dt30()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Fr8t(object b0S6)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(b0S6));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int p5L2()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type r4S0()
		{
			return typeof(Dt30);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string q1BH()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Nq81
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool c1A8(object Fq7f)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Fq7f));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Xf10()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type k1JK()
		{
			return typeof(Nq81);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string k0YQ()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static g3B5 Jw35<g3B5>(g3B5 Xy61) where g3B5 : new()
		{
			if (Xy61 == null)
			{
				return new g3B5();
			}
			return Xy61;
		}

		[DebuggerHidden]
		private void p0L6<Tx8f>(ref Tx8f d5D0)
		{
			d5D0 = default(Tx8f);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Nq81()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Da8o<a9Z0> where a9Z0 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static a9Z0 m_ThreadStaticValue;

		internal a9Z0 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new a9Z0();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Da8o()
		{
		}
	}

	private static readonly Da8o<Mw05> m_ComputerObjectProvider = new Da8o<Mw05>();

	private static readonly Da8o<Qw2p> m_AppObjectProvider = new Da8o<Qw2p>();

	private static readonly Da8o<User> m_UserObjectProvider = new Da8o<User>();

	private static Da8o<Dt30> m_MyFormsObjectProvider = new Da8o<Dt30>();

	private static readonly Da8o<Nq81> m_MyWebServicesObjectProvider = new Da8o<Nq81>();

	[HelpKeyword("My.Computer")]
	internal static Mw05 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Qw2p Application
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
	internal static Dt30 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Nq81 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
