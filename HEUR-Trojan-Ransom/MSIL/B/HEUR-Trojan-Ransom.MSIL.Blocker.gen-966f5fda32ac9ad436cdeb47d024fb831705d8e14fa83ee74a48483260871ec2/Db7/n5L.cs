using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bb9w;
using Cb4;
using Ht3;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Pp27;
using Sn2;
using e8T6;
using j3WH;
using n9D;
using r9JD;

namespace Db7;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class n5L
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class a2M
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public f3N m_AddCTHD;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public j1C m_AddHD;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zb4q m_AddKH;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public a0M7 m_AddLSP;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nt0w m_AddSp;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lp07 m_EditKH;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dt07 m_Form1;

		private static Qf9 Gj7<Qf9>(Qf9 Pe1) where Qf9 : Form, new()
		{
			if (Pe1 == null || ((Control)Pe1).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Qf9)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Qf9), null);
				try
				{
					return new Qf9();
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
					m_FormBeingCreated.Remove(typeof(Qf9));
				}
			}
			return Pe1;
		}

		private void Lg1<Fa3>(ref Fa3 b9Q) where Fa3 : Form
		{
			((Component)b9Q).Dispose();
			b9Q = default(Fa3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public a2M()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Zg6(object Kj9)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Kj9));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Dm2()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type t2E()
		{
			return typeof(a2M);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Ws1()
		{
			return base.ToString();
		}

		[SpecialName]
		public f3N k2A()
		{
			m_AddCTHD = Gj7(m_AddCTHD);
			return m_AddCTHD;
		}

		[SpecialName]
		public j1C g6E()
		{
			m_AddHD = Gj7(m_AddHD);
			return m_AddHD;
		}

		[SpecialName]
		public Zb4q s9N()
		{
			m_AddKH = Gj7(m_AddKH);
			return m_AddKH;
		}

		[SpecialName]
		public a0M7 p4R()
		{
			m_AddLSP = Gj7(m_AddLSP);
			return m_AddLSP;
		}

		[SpecialName]
		public Nt0w p1C()
		{
			m_AddSp = Gj7(m_AddSp);
			return m_AddSp;
		}

		[SpecialName]
		public Lp07 Kp9()
		{
			m_EditKH = Gj7(m_EditKH);
			return m_EditKH;
		}

		[SpecialName]
		public Dt07 q9T()
		{
			m_Form1 = Gj7(m_Form1);
			return m_Form1;
		}

		[SpecialName]
		public void Nb5(f3N Af4)
		{
			if (Af4 != m_AddCTHD)
			{
				if (Af4 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Lg1(ref m_AddCTHD);
			}
		}

		[SpecialName]
		public void Ex5(j1C w9B)
		{
			if (w9B != m_AddHD)
			{
				if (w9B != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Lg1(ref m_AddHD);
			}
		}

		[SpecialName]
		public void p1Z(Zb4q m8Q)
		{
			if (m8Q != m_AddKH)
			{
				if (m8Q != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Lg1(ref m_AddKH);
			}
		}

		[SpecialName]
		public void Ds6(a0M7 Fc6)
		{
			if (Fc6 != m_AddLSP)
			{
				if (Fc6 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Lg1(ref m_AddLSP);
			}
		}

		[SpecialName]
		public void Qr2(Nt0w Ps4)
		{
			if (Ps4 != m_AddSp)
			{
				if (Ps4 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Lg1(ref m_AddSp);
			}
		}

		[SpecialName]
		public void y8B(Lp07 i5D)
		{
			if (i5D != m_EditKH)
			{
				if (i5D != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Lg1(ref m_EditKH);
			}
		}

		[SpecialName]
		public void a5L(Dt07 Ss7)
		{
			if (Ss7 != m_Form1)
			{
				if (Ss7 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Lg1(ref m_Form1);
			}
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Ak1
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool f0X(object Zm4)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Zm4));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Eq2()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type o4C()
		{
			return typeof(Ak1);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string o0M()
		{
			return base.ToString();
		}

		private static Ns4 Ni9<Ns4>(Ns4 Jo3) where Ns4 : new()
		{
			if (Jo3 == null)
			{
				return new Ns4();
			}
			return Jo3;
		}

		private void i5P<d0J>(ref d0J Xm4)
		{
			Xm4 = default(d0J);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ak1()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class n3M<Tb8> where Tb8 : new()
	{
		[ThreadStatic]
		private static Tb8 m_ThreadStaticValue;

		[SpecialName]
		internal Tb8 r7S()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new Tb8();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public n3M()
		{
		}
	}

	private static readonly n3M<Xs9> m_ComputerObjectProvider = new n3M<Xs9>();

	private static readonly n3M<x1L> m_AppObjectProvider = new n3M<x1L>();

	private static readonly n3M<User> m_UserObjectProvider = new n3M<User>();

	private static n3M<a2M> m_MyFormsObjectProvider = new n3M<a2M>();

	private static readonly n3M<Ak1> m_MyWebServicesObjectProvider = new n3M<Ak1>();

	[HelpKeyword("My.Computer")]
	internal static Xs9 Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static x1L Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static a2M Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static Ak1 WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
