using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Dc7;
using Fr1;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Tk89;
using a8G2;
using n1K;
using p0P5;
using w1H;
using x8H5;

namespace t0B;

[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
internal sealed class m2A
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Tf1
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w0T m_BookDetails;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dz8 m_Login;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pf0 m_MainPage;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kk03 m_RatingBookDetails;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zx0d m_StaffLogin;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fi7 m_StudentLogin;

		private static Yr2 a2A<Yr2>(Yr2 Mo9) where Yr2 : Form, new()
		{
			if (Mo9 == null || ((Control)Mo9).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Yr2)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Yr2), null);
				try
				{
					return new Yr2();
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
					m_FormBeingCreated.Remove(typeof(Yr2));
				}
			}
			return Mo9;
		}

		private void i9Z<f1Z>(ref f1Z Cd1) where f1Z : Form
		{
			((Component)Cd1).Dispose();
			Cd1 = default(f1Z);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tf1()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Ac9(object d0Z)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(d0Z));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int f2A()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type w1L()
		{
			return typeof(Tf1);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string b4S()
		{
			return base.ToString();
		}

		[SpecialName]
		public w0T He1()
		{
			m_BookDetails = a2A(m_BookDetails);
			return m_BookDetails;
		}

		[SpecialName]
		public Dz8 Ka0()
		{
			m_Login = a2A(m_Login);
			return m_Login;
		}

		[SpecialName]
		public Pf0 At0()
		{
			m_MainPage = a2A(m_MainPage);
			return m_MainPage;
		}

		[SpecialName]
		public Kk03 s1L()
		{
			m_RatingBookDetails = a2A(m_RatingBookDetails);
			return m_RatingBookDetails;
		}

		[SpecialName]
		public Zx0d y3X()
		{
			m_StaffLogin = a2A(m_StaffLogin);
			return m_StaffLogin;
		}

		[SpecialName]
		public Fi7 r0M()
		{
			m_StudentLogin = a2A(m_StudentLogin);
			return m_StudentLogin;
		}

		[SpecialName]
		public void j2F(w0T Ha1)
		{
			if (Ha1 != m_BookDetails)
			{
				if (Ha1 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				i9Z(ref m_BookDetails);
			}
		}

		[SpecialName]
		public void k0S(Dz8 Tj8)
		{
			if (Tj8 != m_Login)
			{
				if (Tj8 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				i9Z(ref m_Login);
			}
		}

		[SpecialName]
		public void f5M(Pf0 w0S)
		{
			if (w0S != m_MainPage)
			{
				if (w0S != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				i9Z(ref m_MainPage);
			}
		}

		[SpecialName]
		public void a1Q(Kk03 y5L)
		{
			if (y5L != m_RatingBookDetails)
			{
				if (y5L != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				i9Z(ref m_RatingBookDetails);
			}
		}

		[SpecialName]
		public void Sb0(Zx0d g5B)
		{
			if (g5B != m_StaffLogin)
			{
				if (g5B != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				i9Z(ref m_StaffLogin);
			}
		}

		[SpecialName]
		public void Pk7(Fi7 b4D)
		{
			if (b4D != m_StudentLogin)
			{
				if (b4D != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				i9Z(ref m_StudentLogin);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Xi2
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Rj5(object t0S)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(t0S));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Kz7()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type e1T()
		{
			return typeof(Xi2);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Ew7()
		{
			return base.ToString();
		}

		private static x0E f5Q<x0E>(x0E a4P) where x0E : new()
		{
			if (a4P == null)
			{
				return new x0E();
			}
			return a4P;
		}

		private void d0R<p1Y>(ref p1Y w9J)
		{
			w9J = default(p1Y);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xi2()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Nw9<Wo8> where Wo8 : new()
	{
		[ThreadStatic]
		private static Wo8 m_ThreadStaticValue;

		[SpecialName]
		internal Wo8 Bb4()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new Wo8();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nw9()
		{
		}
	}

	private static readonly Nw9<Po7j> m_ComputerObjectProvider = new Nw9<Po7j>();

	private static readonly Nw9<Ge6j> m_AppObjectProvider = new Nw9<Ge6j>();

	private static readonly Nw9<User> m_UserObjectProvider = new Nw9<User>();

	private static Nw9<Tf1> m_MyFormsObjectProvider = new Nw9<Tf1>();

	private static readonly Nw9<Xi2> m_MyWebServicesObjectProvider = new Nw9<Xi2>();

	[HelpKeyword("My.Computer")]
	internal static Po7j Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static Ge6j Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static Tf1 Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static Xi2 WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
