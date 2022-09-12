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
using Ha03;
using Kw6;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Pp74;
using Wo0y;
using Wo29;
using Xi7s;
using d2G3;
using i1H7;
using y6N2;
using z2FR;

namespace b1T3;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class Cc9k
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class o6E5
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ao56 m_frmAcercade;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public o3HG m_frmArmas;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s2ZW m_frmClase;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m0PK m_frmClosingServer;

		public Ao56 frmAcercade
		{
			[DebuggerHidden]
			get
			{
				m_frmAcercade = Nq6s(m_frmAcercade);
				return m_frmAcercade;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmAcercade)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					n4E2(ref m_frmAcercade);
				}
			}
		}

		public o3HG frmArmas
		{
			[DebuggerHidden]
			get
			{
				m_frmArmas = Nq6s(m_frmArmas);
				return m_frmArmas;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmArmas)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					n4E2(ref m_frmArmas);
				}
			}
		}

		public s2ZW frmClase
		{
			[DebuggerHidden]
			get
			{
				m_frmClase = Nq6s(m_frmClase);
				return m_frmClase;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmClase)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					n4E2(ref m_frmClase);
				}
			}
		}

		public m0PK frmClosingServer
		{
			[DebuggerHidden]
			get
			{
				m_frmClosingServer = Nq6s(m_frmClosingServer);
				return m_frmClosingServer;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmClosingServer)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					n4E2(ref m_frmClosingServer);
				}
			}
		}

		[DebuggerHidden]
		private static b1B6 Nq6s<b1B6>(b1B6 Hm05) where b1B6 : Form, new()
		{
			if (Hm05 == null || ((Control)Hm05).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(b1B6)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(b1B6), null);
				try
				{
					return new b1B6();
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
					m_FormBeingCreated.Remove(typeof(b1B6));
				}
			}
			return Hm05;
		}

		[DebuggerHidden]
		private void n4E2<g0M2>(ref g0M2 r2Z4) where g0M2 : Form
		{
			((Component)r2Z4).Dispose();
			r2Z4 = default(g0M2);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public o6E5()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool k1K3(object k5FJ)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(k5FJ));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Yz53()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type r1F8()
		{
			return typeof(o6E5);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string c9TY()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Lf2s
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool o1F6(object t7BH)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(t7BH));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int w3ZN()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type Jf4p()
		{
			return typeof(Lf2s);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string j2D0()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static c8W0 d3GY<c8W0>(c8W0 Ai78) where c8W0 : new()
		{
			if (Ai78 == null)
			{
				return new c8W0();
			}
			return Ai78;
		}

		[DebuggerHidden]
		private void At6r<i8XM>(ref i8XM g4WQ)
		{
			g4WQ = default(i8XM);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Lf2s()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Ze21<s4C5> where s4C5 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static s4C5 m_ThreadStaticValue;

		internal s4C5 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new s4C5();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Ze21()
		{
		}
	}

	private static readonly Ze21<y9CZ> m_ComputerObjectProvider = new Ze21<y9CZ>();

	private static readonly Ze21<Hj2y> m_AppObjectProvider = new Ze21<Hj2y>();

	private static readonly Ze21<User> m_UserObjectProvider = new Ze21<User>();

	private static Ze21<o6E5> m_MyFormsObjectProvider = new Ze21<o6E5>();

	private static readonly Ze21<Lf2s> m_MyWebServicesObjectProvider = new Ze21<Lf2s>();

	[HelpKeyword("My.Computer")]
	internal static y9CZ Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Hj2y Application
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
	internal static o6E5 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Lf2s WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}

	static void r4Y3()
	{
		_ = (Nb4n)(object)t8TR.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t8TR t8TR);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s2ZW s2ZW);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9CA p9CA);
		UIntPtr uIntPtr;
		try
		{
			do
			{
				y9CZ y9CZ = null;
				y9CZ = y9CZ;
				obj = t8TR.Default;
			}
			while (obj != null);
		}
		finally
		{
			try
			{
				uIntPtr = (UIntPtr)t8TR.Default;
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					s2ZW obj2 = (s2ZW)(object)t8TR.Default;
					s2ZW = s2ZW;
					s2ZW = obj2;
					_ = (o3HG)(object)t8TR.Default;
					t8TR = t8TR;
					t8TR = t8TR;
					p9CA = null;
					p9CA = null;
				}
			}
			finally
			{
				_ = (Nb4n)(object)t8TR.Default;
				goto IL_009a;
			}
		}
		IL_009a:
		checked
		{
			nuint num = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)t8TR.Default) * unchecked((nuint)(UIntPtr)t8TR.Default);
			uIntPtr = default(UIntPtr);
			if (num + uIntPtr != 0)
			{
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s0T s0T);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o3HG o3HG);
		if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					s2ZW = null;
					o3HG = o3HG;
					_ = (Ao56)(object)t8TR.Default;
				}
			}
			else if (uIntPtr == 0)
			{
				s0T = (s0T)(object)t8TR.Default;
				s0T = s0T;
			}
		}
		m0PK m0PK = null;
		m0PK = m0PK;
		p9CA = p9CA;
		m0PK = m0PK;
		try
		{
			checked
			{
				try
				{
					if (unchecked(uIntPtr / (nuint)(UIntPtr)t8TR.Default) * uIntPtr == 0)
					{
						_ = (Hj2y)(object)t8TR.Default;
					}
					else
					{
						_ = (Hj2y)(object)t8TR.Default;
					}
				}
				finally
				{
					try
					{
						t8TR = t8TR;
					}
					finally
					{
						_ = (o3HG)(object)t8TR.Default;
						goto end_IL_0146;
					}
				}
			}
			end_IL_0146:;
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				s0T = s0T;
				Nb4n nb4n = nb4n;
				nb4n = nb4n;
				_ = (p9CA)(object)t8TR.Default;
				_ = (m0PK)(object)t8TR.Default;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				_ = (s2ZW)(object)t8TR.Default;
			}
			finally
			{
				_ = (Nb4n)(object)t8TR.Default;
				goto IL_01ff;
			}
		}
		goto IL_01ff;
		IL_049b:
		_ = (Ao56)(object)t8TR.Default;
		Cc9k cc9k = cc9k;
		o3HG = o3HG;
		s2ZW = s2ZW;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hj2y hj2y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		do
		{
			try
			{
				y9CZ y9CZ = null;
			}
			catch
			{
				_ = (o3HG)(object)t8TR.Default;
				hj2y = null;
				_003CModule_003E = null;
				_ = (m0PK)(object)t8TR.Default;
			}
			finally
			{
				do
				{
					_ = (m0PK)(object)t8TR.Default;
				}
				while (obj != null);
				continue;
			}
		}
		while (obj != null);
		try
		{
			try
			{
				if (uIntPtr == 0)
				{
					cc9k = cc9k;
					y9CZ y9CZ = (y9CZ)(object)t8TR.Default;
					Nb4n nb4n = null;
				}
				return;
			}
			finally
			{
				_003CModule_003E = (_003CModule_003E)(object)t8TR.Default;
				return;
			}
		}
		finally
		{
			_ = (Nb4n)(object)t8TR.Default;
			return;
		}
		IL_01ff:
		_ = (p9CA)(object)t8TR.Default;
		p9CA = p9CA;
		try
		{
			do
			{
				try
				{
					o3HG = (o3HG)(object)t8TR.Default;
				}
				finally
				{
					m0PK = null;
					_003CModule_003E = (_003CModule_003E)(object)t8TR.Default;
					_003CModule_003E = null;
					cc9k = (Cc9k)(object)t8TR.Default;
					cc9k = cc9k;
					continue;
				}
			}
			while (obj != null);
		}
		finally
		{
			try
			{
				s2ZW = (s2ZW)(object)t8TR.Default;
			}
			finally
			{
				goto IL_0271;
			}
		}
		IL_0271:
		try
		{
			while ((object)t8TR.Default != null)
			{
				while (obj != null)
				{
					_ = (Hj2y)(object)t8TR.Default;
				}
			}
		}
		catch
		{
			Nb4n nb4n = (Nb4n)(object)t8TR.Default;
		}
		if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)t8TR.Default != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Nb4n)(object)t8TR.Default;
				}
			}
		}
		else
		{
			_ = (Nb4n)(object)t8TR.Default;
		}
		if (uIntPtr / (nuint)(UIntPtr)t8TR.Default == 0)
		{
			while (obj != null)
			{
				hj2y = (Hj2y)(object)t8TR.Default;
				hj2y = hj2y;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ao56 ao);
		do
		{
			ao = ao;
			ao = ao;
		}
		while ((object)t8TR.Default != null);
		nuint num2 = uIntPtr;
		checked
		{
			nuint num3 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr));
			nuint num4 = unchecked((nuint)(UIntPtr)t8TR.Default / (nuint)(UIntPtr)t8TR.Default);
			uIntPtr = default(UIntPtr);
			UIntPtr num5 = uIntPtr;
			UIntPtr num6 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num2 + (num3 - unchecked(num4 / checked(unchecked((nuint)num5) - (unchecked((nuint)num6) - (unchecked((nuint)default(UIntPtr)) - uIntPtr))))) * uIntPtr == 0)
			{
				_ = (Cc9k)(object)t8TR.Default;
			}
			else
			{
				nuint num7 = unchecked(uIntPtr / uIntPtr);
				uIntPtr = default(UIntPtr);
				if (num7 + (unchecked((nuint)default(UIntPtr)) - uIntPtr) == 0)
				{
					while (obj != null)
					{
						_ = (Hj2y)(object)t8TR.Default;
					}
				}
				else
				{
					_ = (m0PK)(object)t8TR.Default;
					_003CModule_003E = _003CModule_003E;
					o3HG = o3HG;
				}
			}
		}
		if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				t8TR = t8TR;
			}
		}
		else
		{
			do
			{
				_003CModule_003E = null;
			}
			while (obj != null);
		}
		if (uIntPtr == 0)
		{
			try
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
					_ = (s0T)(object)t8TR.Default;
				}
			}
			finally
			{
				while ((object)t8TR.Default != null)
				{
					hj2y = hj2y;
					o3HG = o3HG;
					cc9k = (Cc9k)(object)t8TR.Default;
					cc9k = cc9k;
				}
				goto IL_049b;
			}
		}
		_ = (_003CModule_003E)(object)t8TR.Default;
		goto IL_049b;
	}
}
