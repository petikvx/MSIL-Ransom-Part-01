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
using Et0x;
using Fg19;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Pk7n;
using Px68;
using Sc0;
using Zj1;
using Zx3;
using a8T5;
using g8P;
using i0R;
using i7D;
using m3Y2;
using p6L;
using q2XB;
using q2Z4;
using z9MN;

namespace Fc96;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class r6W7
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class o7K6
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Eb46 m_AddmisionForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ca7 m_AddmisionForm1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w2R5 m_AddUser;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public o4G6 m_ClassDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qb2a m_ClassDetail1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Je5d m_Course;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public a0A m_Course1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Br2 m_LoginForm1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zq7 m_MENUS;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lf9 m_SearchForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Te5 m_Startup;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Mi8 m_Subject;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Rg0b m_Subject1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public e3G1 m_Viewer;

		public Eb46 AddmisionForm
		{
			[DebuggerHidden]
			get
			{
				m_AddmisionForm = k7A4(m_AddmisionForm);
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
					Mz9n(ref m_AddmisionForm);
				}
			}
		}

		public Ca7 AddmisionForm1
		{
			[DebuggerHidden]
			get
			{
				m_AddmisionForm1 = k7A4(m_AddmisionForm1);
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
					Mz9n(ref m_AddmisionForm1);
				}
			}
		}

		public w2R5 AddUser
		{
			[DebuggerHidden]
			get
			{
				m_AddUser = k7A4(m_AddUser);
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
					Mz9n(ref m_AddUser);
				}
			}
		}

		public o4G6 ClassDetail
		{
			[DebuggerHidden]
			get
			{
				m_ClassDetail = k7A4(m_ClassDetail);
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
					Mz9n(ref m_ClassDetail);
				}
			}
		}

		public Qb2a ClassDetail1
		{
			[DebuggerHidden]
			get
			{
				m_ClassDetail1 = k7A4(m_ClassDetail1);
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
					Mz9n(ref m_ClassDetail1);
				}
			}
		}

		public Je5d Course
		{
			[DebuggerHidden]
			get
			{
				m_Course = k7A4(m_Course);
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
					Mz9n(ref m_Course);
				}
			}
		}

		public a0A Course1
		{
			[DebuggerHidden]
			get
			{
				m_Course1 = k7A4(m_Course1);
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
					Mz9n(ref m_Course1);
				}
			}
		}

		public Br2 LoginForm1
		{
			[DebuggerHidden]
			get
			{
				m_LoginForm1 = k7A4(m_LoginForm1);
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
					Mz9n(ref m_LoginForm1);
				}
			}
		}

		public Zq7 MENUS
		{
			[DebuggerHidden]
			get
			{
				m_MENUS = k7A4(m_MENUS);
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
					Mz9n(ref m_MENUS);
				}
			}
		}

		public Lf9 SearchForm
		{
			[DebuggerHidden]
			get
			{
				m_SearchForm = k7A4(m_SearchForm);
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
					Mz9n(ref m_SearchForm);
				}
			}
		}

		public Te5 Startup
		{
			[DebuggerHidden]
			get
			{
				m_Startup = k7A4(m_Startup);
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
					Mz9n(ref m_Startup);
				}
			}
		}

		public Mi8 Subject
		{
			[DebuggerHidden]
			get
			{
				m_Subject = k7A4(m_Subject);
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
					Mz9n(ref m_Subject);
				}
			}
		}

		public Rg0b Subject1
		{
			[DebuggerHidden]
			get
			{
				m_Subject1 = k7A4(m_Subject1);
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
					Mz9n(ref m_Subject1);
				}
			}
		}

		public e3G1 Viewer
		{
			[DebuggerHidden]
			get
			{
				m_Viewer = k7A4(m_Viewer);
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
					Mz9n(ref m_Viewer);
				}
			}
		}

		[DebuggerHidden]
		private static Ng45 k7A4<Ng45>(Ng45 Ht28) where Ng45 : Form, new()
		{
			if (Ht28 == null || ((Control)Ht28).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Ng45)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Ng45), null);
				try
				{
					return new Ng45();
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
					m_FormBeingCreated.Remove(typeof(Ng45));
				}
			}
			return Ht28;
		}

		[DebuggerHidden]
		private void Mz9n<Fn1w>(ref Fn1w Bf7z) where Fn1w : Form
		{
			((Component)Bf7z).Dispose();
			Bf7z = default(Fn1w);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public o7K6()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool i3R5(object p2DK)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(p2DK));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int o9S8()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Zi50()
		{
			return typeof(o7K6);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string b3RS()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Do0m
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool s9PL(object w3EP)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(w3EP));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Mi84()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type k7P9()
		{
			return typeof(Do0m);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Sf7z()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static y3C4 c3MK<y3C4>(y3C4 Rq2d) where y3C4 : new()
		{
			if (Rq2d == null)
			{
				return new y3C4();
			}
			return Rq2d;
		}

		[DebuggerHidden]
		private void e9G4<Pp52>(ref Pp52 c1E5)
		{
			c1E5 = default(Pp52);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Do0m()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class i2K0<o6S0> where o6S0 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static o6S0 m_ThreadStaticValue;

		internal o6S0 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new o6S0();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public i2K0()
		{
		}
	}

	private static readonly i2K0<Tp4f> m_ComputerObjectProvider = new i2K0<Tp4f>();

	private static readonly i2K0<So0t> m_AppObjectProvider = new i2K0<So0t>();

	private static readonly i2K0<User> m_UserObjectProvider = new i2K0<User>();

	private static i2K0<o7K6> m_MyFormsObjectProvider = new i2K0<o7K6>();

	private static readonly i2K0<Do0m> m_MyWebServicesObjectProvider = new i2K0<Do0m>();

	[HelpKeyword("My.Computer")]
	internal static Tp4f Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static So0t Application
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
	internal static o7K6 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Do0m WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
