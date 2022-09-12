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
using Ej81;
using Ln70;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Rn4;
using So8;
using Xb1;
using Xz83;
using b5E;
using n5C;
using s5W;

namespace Pd73;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Cc9a
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class r6PJ
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Yb6r m_AddCTHD;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Td23 m_AddHD;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x7E m_AddKH;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xq1 m_AddLSP;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ye6 m_AddSp;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kb1 m_EditKH;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kq4 m_Form1;

		public Yb6r AddCTHD
		{
			[DebuggerHidden]
			get
			{
				m_AddCTHD = s0QZ(m_AddCTHD);
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
					Lg2q(ref m_AddCTHD);
				}
			}
		}

		public Td23 AddHD
		{
			[DebuggerHidden]
			get
			{
				m_AddHD = s0QZ(m_AddHD);
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
					Lg2q(ref m_AddHD);
				}
			}
		}

		public x7E AddKH
		{
			[DebuggerHidden]
			get
			{
				m_AddKH = s0QZ(m_AddKH);
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
					Lg2q(ref m_AddKH);
				}
			}
		}

		public Xq1 AddLSP
		{
			[DebuggerHidden]
			get
			{
				m_AddLSP = s0QZ(m_AddLSP);
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
					Lg2q(ref m_AddLSP);
				}
			}
		}

		public Ye6 AddSp
		{
			[DebuggerHidden]
			get
			{
				m_AddSp = s0QZ(m_AddSp);
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
					Lg2q(ref m_AddSp);
				}
			}
		}

		public Kb1 EditKH
		{
			[DebuggerHidden]
			get
			{
				m_EditKH = s0QZ(m_EditKH);
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
					Lg2q(ref m_EditKH);
				}
			}
		}

		public Kq4 Form1
		{
			[DebuggerHidden]
			get
			{
				m_Form1 = s0QZ(m_Form1);
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
					Lg2q(ref m_Form1);
				}
			}
		}

		[DebuggerHidden]
		private static k8R5 s0QZ<k8R5>(k8R5 Gf7x) where k8R5 : Form, new()
		{
			if (Gf7x == null || ((Control)Gf7x).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(k8R5)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(k8R5), null);
				try
				{
					return new k8R5();
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
					m_FormBeingCreated.Remove(typeof(k8R5));
				}
			}
			return Gf7x;
		}

		[DebuggerHidden]
		private void Lg2q<Ks5j>(ref Ks5j Ha9f) where Ks5j : Form
		{
			((Component)Ha9f).Dispose();
			Ha9f = default(Ks5j);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public r6PJ()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Kx07(object n0TF)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(n0TF));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Lr4i()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type j4RJ()
		{
			return typeof(r6PJ);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string An7i()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class k7K2
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool w4S0(object Ci63)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Ci63));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Gg5k()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Pm50()
		{
			return typeof(k7K2);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Rx3f()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Jk7c m1SJ<Jk7c>(Jk7c As12) where Jk7c : new()
		{
			if (As12 == null)
			{
				return new Jk7c();
			}
			return As12;
		}

		[DebuggerHidden]
		private void r7JT<Mr54>(ref Mr54 Mk2p)
		{
			Mk2p = default(Mr54);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public k7K2()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Br56<Zo54> where Zo54 : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static Zo54 m_ThreadStaticValue;

		internal Zo54 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Zo54();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Br56()
		{
		}
	}

	private static readonly Br56<s3J6> m_ComputerObjectProvider = new Br56<s3J6>();

	private static readonly Br56<Pb3p> m_AppObjectProvider = new Br56<Pb3p>();

	private static readonly Br56<User> m_UserObjectProvider = new Br56<User>();

	private static Br56<r6PJ> m_MyFormsObjectProvider = new Br56<r6PJ>();

	private static readonly Br56<k7K2> m_MyWebServicesObjectProvider = new Br56<k7K2>();

	[HelpKeyword("My.Computer")]
	internal static s3J6 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Pb3p Application
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
	internal static r6PJ Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static k7K2 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
