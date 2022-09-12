using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Dc16;
using Fd5;
using Gz7;
using Jx0;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Nz1;
using c5Y2;
using j7M;
using w1R;
using w1T;
using y4G;
using y5B1;

namespace b1X;

[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
internal sealed class Qy2
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Qi8
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pn8 m_Form1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public n5L m_Form2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public e3S m_Form3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xs8 m_Form4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Mm0 m_Form5;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tw3o m_Form6;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Rq6k m_Form7;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Em8 m_Form8;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public p4QH m_Form9;

		private static e6E y7C<e6E>(e6E f2L) where e6E : Form, new()
		{
			if (f2L == null || ((Control)f2L).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(e6E)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(e6E), null);
				try
				{
					return new e6E();
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
					m_FormBeingCreated.Remove(typeof(e6E));
				}
			}
			return f2L;
		}

		private void Ft3<y5Z>(ref y5Z k4Z) where y5Z : Form
		{
			((Component)k4Z).Dispose();
			k4Z = default(y5Z);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qi8()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool k7Y(object d2N)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(d2N));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int r0R()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type i9H()
		{
			return typeof(Qi8);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Wg2()
		{
			return base.ToString();
		}

		[SpecialName]
		public Pn8 r3C()
		{
			m_Form1 = y7C(m_Form1);
			return m_Form1;
		}

		[SpecialName]
		public n5L Ja6()
		{
			m_Form2 = y7C(m_Form2);
			return m_Form2;
		}

		[SpecialName]
		public e3S Zg4()
		{
			m_Form3 = y7C(m_Form3);
			return m_Form3;
		}

		[SpecialName]
		public Xs8 x0D()
		{
			m_Form4 = y7C(m_Form4);
			return m_Form4;
		}

		[SpecialName]
		public Mm0 Fw2()
		{
			m_Form5 = y7C(m_Form5);
			return m_Form5;
		}

		[SpecialName]
		public Tw3o Qx3()
		{
			m_Form6 = y7C(m_Form6);
			return m_Form6;
		}

		[SpecialName]
		public Rq6k y7G()
		{
			m_Form7 = y7C(m_Form7);
			return m_Form7;
		}

		[SpecialName]
		public Em8 Je3()
		{
			m_Form8 = y7C(m_Form8);
			return m_Form8;
		}

		[SpecialName]
		public p4QH Sb3()
		{
			m_Form9 = y7C(m_Form9);
			return m_Form9;
		}

		[SpecialName]
		public void Cj4(Pn8 n1K)
		{
			if (n1K != m_Form1)
			{
				if (n1K != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ft3(ref m_Form1);
			}
		}

		[SpecialName]
		public void Bg5(n5L Gx6)
		{
			if (Gx6 != m_Form2)
			{
				if (Gx6 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ft3(ref m_Form2);
			}
		}

		[SpecialName]
		public void Ns2(e3S Yz3)
		{
			if (Yz3 != m_Form3)
			{
				if (Yz3 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ft3(ref m_Form3);
			}
		}

		[SpecialName]
		public void Sz5(Xs8 z7B)
		{
			if (z7B != m_Form4)
			{
				if (z7B != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ft3(ref m_Form4);
			}
		}

		[SpecialName]
		public void a4H(Mm0 Ln0)
		{
			if (Ln0 != m_Form5)
			{
				if (Ln0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ft3(ref m_Form5);
			}
		}

		[SpecialName]
		public void s1P(Tw3o Ls7)
		{
			if (Ls7 != m_Form6)
			{
				if (Ls7 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ft3(ref m_Form6);
			}
		}

		[SpecialName]
		public void s0Z(Rq6k Rt0)
		{
			if (Rt0 != m_Form7)
			{
				if (Rt0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ft3(ref m_Form7);
			}
		}

		[SpecialName]
		public void Ta0(Em8 Yq3)
		{
			if (Yq3 != m_Form8)
			{
				if (Yq3 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ft3(ref m_Form8);
			}
		}

		[SpecialName]
		public void Ss5(p4QH x4Y)
		{
			if (x4Y != m_Form9)
			{
				if (x4Y != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Ft3(ref m_Form9);
			}
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class i3W
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool y3B(object Sp3)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Sp3));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int d5T()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type s9Y()
		{
			return typeof(i3W);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string j1J()
		{
			return base.ToString();
		}

		private static x0E Jq1<x0E>(x0E Wx7) where x0E : new()
		{
			if (Wx7 == null)
			{
				return new x0E();
			}
			return Wx7;
		}

		private void Wn5<Dt0>(ref Dt0 Mw4)
		{
			Mw4 = default(Dt0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public i3W()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Bw1<c9D> where c9D : new()
	{
		[ThreadStatic]
		private static c9D m_ThreadStaticValue;

		[SpecialName]
		internal c9D Yi1()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new c9D();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bw1()
		{
		}
	}

	private static readonly Bw1<g4B> m_ComputerObjectProvider = new Bw1<g4B>();

	private static readonly Bw1<My2> m_AppObjectProvider = new Bw1<My2>();

	private static readonly Bw1<User> m_UserObjectProvider = new Bw1<User>();

	private static Bw1<Qi8> m_MyFormsObjectProvider = new Bw1<Qi8>();

	private static readonly Bw1<i3W> m_MyWebServicesObjectProvider = new Bw1<i3W>();

	[HelpKeyword("My.Computer")]
	internal static g4B Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static My2 Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static Qi8 Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static i3W WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
