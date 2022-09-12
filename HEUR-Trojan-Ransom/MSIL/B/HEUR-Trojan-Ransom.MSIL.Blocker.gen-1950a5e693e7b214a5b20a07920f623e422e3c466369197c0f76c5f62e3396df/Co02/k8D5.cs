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
using Bi7;
using Mb5q;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Nr2m;
using Nt1m;
using Re2r;
using Rk0g;
using Rp8;
using e8Z;
using y0D5;
using y5P;

namespace Co02;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class k8D5
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Yc29
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ht2 m_frmAcercade;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public i6A m_frmArmas;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Sk5 m_frmClase;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public n4R1 m_frmClosingServer;

		public Ht2 frmAcercade
		{
			[DebuggerHidden]
			get
			{
				m_frmAcercade = Wb7p(m_frmAcercade);
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
					Rk29(ref m_frmAcercade);
				}
			}
		}

		public i6A frmArmas
		{
			[DebuggerHidden]
			get
			{
				m_frmArmas = Wb7p(m_frmArmas);
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
					Rk29(ref m_frmArmas);
				}
			}
		}

		public Sk5 frmClase
		{
			[DebuggerHidden]
			get
			{
				m_frmClase = Wb7p(m_frmClase);
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
					Rk29(ref m_frmClase);
				}
			}
		}

		public n4R1 frmClosingServer
		{
			[DebuggerHidden]
			get
			{
				m_frmClosingServer = Wb7p(m_frmClosingServer);
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
					Rk29(ref m_frmClosingServer);
				}
			}
		}

		[DebuggerHidden]
		private static i9PC Wb7p<i9PC>(i9PC Ez13) where i9PC : Form, new()
		{
			if (Ez13 == null || ((Control)Ez13).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(i9PC)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(i9PC), null);
				try
				{
					return new i9PC();
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
					m_FormBeingCreated.Remove(typeof(i9PC));
				}
			}
			return Ez13;
		}

		[DebuggerHidden]
		private void Rk29<e3FE>(ref e3FE Dt5a) where e3FE : Form
		{
			((Component)Dt5a).Dispose();
			Dt5a = default(e3FE);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Yc29()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool y8DM(object n2DS)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(n2DS));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int w0PY()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Pf98()
		{
			return typeof(Yc29);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Rs07()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Ha9o
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Jp96(object p0S8)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(p0S8));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int Km9z()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Sa9r()
		{
			return typeof(Ha9o);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string n7B9()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Dj9x Xk8s<Dj9x>(Dj9x Yj7p) where Dj9x : new()
		{
			if (Yj7p == null)
			{
				return new Dj9x();
			}
			return Yj7p;
		}

		[DebuggerHidden]
		private void En4d<c8Z0>(ref c8Z0 z0BH)
		{
			z0BH = default(c8Z0);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ha9o()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Mm2r<q2Z7> where q2Z7 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static q2Z7 m_ThreadStaticValue;

		internal q2Z7 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new q2Z7();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Mm2r()
		{
		}
	}

	private static readonly Mm2r<a9PE> m_ComputerObjectProvider = new Mm2r<a9PE>();

	private static readonly Mm2r<Jt0m> m_AppObjectProvider = new Mm2r<Jt0m>();

	private static readonly Mm2r<User> m_UserObjectProvider = new Mm2r<User>();

	private static Mm2r<Yc29> m_MyFormsObjectProvider = new Mm2r<Yc29>();

	private static readonly Mm2r<Ha9o> m_MyWebServicesObjectProvider = new Mm2r<Ha9o>();

	[HelpKeyword("My.Computer")]
	internal static a9PE Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Jt0m Application
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
	internal static Yc29 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Ha9o WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}

	static void r3GZ()
	{
		_ = (i6A)(object)g5LW.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g5LW g5LW);
		try
		{
			_ = (n4R1)(object)g5LW.Default;
		}
		catch
		{
			try
			{
				n4R1 n4R = null;
				n4R = null;
			}
			catch
			{
				_ = (Jt0m)(object)g5LW.Default;
				_ = (Jt0m)(object)g5LW.Default;
				_ = (_003CModule_003E)(object)g5LW.Default;
				_ = (i6A)(object)g5LW.Default;
			}
		}
		finally
		{
			try
			{
				n4R1 n4R = (n4R1)(object)g5LW.Default;
			}
			catch
			{
				try
				{
					g5LW = null;
					g5LW = g5LW;
				}
				catch
				{
					_ = (Jt0m)(object)g5LW.Default;
				}
			}
			goto IL_008c;
		}
		IL_008c:
		Wx57 obj5 = (Wx57)(object)g5LW.Default;
		Wx57 wx = wx;
		wx = obj5;
		k8D5 obj6 = (k8D5)(object)g5LW.Default;
		k8D5 k8D6 = (k8D5)(object)g5LW.Default;
		k8D6 = obj6;
		object obj7;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8G6 k8G);
		try
		{
			k8G = (k8G6)(object)g5LW.Default;
			k8G = k8G;
		}
		finally
		{
			obj7 = null;
			goto IL_00dd;
		}
		IL_00dd:
		Ht2 ht = ht;
		ht = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		while (obj7 != null)
		{
			try
			{
				while (obj7 != null)
				{
					_003CModule_003E = (_003CModule_003E)(object)g5LW.Default;
					_003CModule_003E = _003CModule_003E;
				}
			}
			finally
			{
				try
				{
					_ = g5LW.Default;
				}
				finally
				{
					_ = (Wx57)(object)g5LW.Default;
					continue;
				}
			}
		}
		c2J c2J = (c2J)(object)g5LW.Default;
		c2J = c2J;
		c2J = null;
		a9PE obj8 = (a9PE)(object)g5LW.Default;
		a9PE a9PE = a9PE;
		a9PE = obj8;
		while (obj7 != null)
		{
			n4R1 n4R = null;
			_ = (Ht2)(object)g5LW.Default;
		}
		UIntPtr num = (UIntPtr)g5LW.Default;
		nuint num2 = default(UIntPtr);
		checked
		{
			num2 = unchecked((nuint)num) - unchecked(checked(num2 - num2 - unchecked((nuint)default(UIntPtr))) / (nuint)(UIntPtr)g5LW.Default);
			num2 = default(UIntPtr);
		}
		if (num2 == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = _003CModule_003E;
			a9PE = (a9PE)(object)g5LW.Default;
			_ = (Wx57)(object)g5LW.Default;
		}
		if (num2 == (UIntPtr)(nuint)0u)
		{
			_ = (a9PE)(object)g5LW.Default;
		}
		do
		{
			_ = (Wx57)(object)g5LW.Default;
		}
		while (obj7 != null);
		_ = (Ht2)(object)g5LW.Default;
		if (checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr))) == 0)
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				try
				{
					_003CModule_003E = null;
				}
				catch
				{
					_ = (k8G6)(object)g5LW.Default;
				}
			}
		}
		else
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (k8G6)(object)g5LW.Default;
				}
				finally
				{
					c2J = null;
					a9PE = a9PE;
					wx = wx;
					goto IL_0294;
				}
			}
		}
		goto IL_0294;
		IL_0294:
		if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					g5LW = g5LW;
				}
				while (obj7 != null);
			}
			finally
			{
				k8D6 = k8D6;
				_ = (Ht2)(object)g5LW.Default;
				goto IL_02d3;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sk5 sk);
		while (obj7 != null)
		{
			sk = sk;
			sk = null;
		}
		goto IL_02d3;
		IL_0413:
		try
		{
			try
			{
				_ = (i6A)(object)g5LW.Default;
			}
			finally
			{
				while ((object)g5LW.Default != null)
				{
					_ = (Sk5)(object)g5LW.Default;
				}
				goto end_IL_0414;
			}
			end_IL_0414:;
		}
		finally
		{
			try
			{
				_ = (i6A)(object)g5LW.Default;
				k8D6 = k8D6;
				_ = (_003CModule_003E)(object)g5LW.Default;
			}
			finally
			{
				try
				{
					_ = (a9PE)(object)g5LW.Default;
					_ = (i6A)(object)g5LW.Default;
					_ = (Wx57)(object)g5LW.Default;
				}
				catch
				{
					_ = (n4R1)(object)g5LW.Default;
				}
				goto IL_0497;
			}
		}
		IL_02d3:
		try
		{
			if (num2 == (UIntPtr)(nuint)0u)
			{
				_ = (i6A)(object)g5LW.Default;
			}
		}
		finally
		{
			try
			{
				try
				{
					_ = (a9PE)(object)g5LW.Default;
				}
				finally
				{
					_ = (a9PE)(object)g5LW.Default;
					k8D6 = (k8D5)(object)g5LW.Default;
					goto end_IL_02e8;
				}
				end_IL_02e8:;
			}
			catch
			{
				try
				{
					wx = wx;
				}
				catch
				{
					_ = (n4R1)(object)g5LW.Default;
				}
			}
			goto IL_0330;
		}
		IL_0497:
		try
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				try
				{
					c2J = c2J;
				}
				finally
				{
					_ = (i6A)(object)g5LW.Default;
					goto end_IL_0498;
				}
			}
			end_IL_0498:;
		}
		finally
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				k8G = k8G;
				_ = (i6A)(object)g5LW.Default;
				_ = (c2J)(object)g5LW.Default;
			}
			else
			{
				_ = g5LW.Default;
			}
			goto IL_04fa;
		}
		IL_04fa:
		try
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				_ = (_003CModule_003E)(object)g5LW.Default;
				_ = (_003CModule_003E)(object)g5LW.Default;
				i6A i6A = null;
				i6A = i6A;
				a9PE = a9PE;
			}
		}
		catch
		{
			sk = null;
		}
		try
		{
			_ = (a9PE)(object)g5LW.Default;
		}
		catch
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				_ = (k8D5)(object)g5LW.Default;
				_ = (_003CModule_003E)(object)g5LW.Default;
			}
			else
			{
				_ = g5LW.Default;
			}
		}
		checked
		{
			try
			{
				if (num2 == 0)
				{
					nuint num3 = num2 + (num2 + num2);
					num2 = default(UIntPtr);
					if (num3 * num2 == 0)
					{
						i6A i6A = null;
					}
					else
					{
						_ = (a9PE)(object)g5LW.Default;
					}
				}
			}
			catch
			{
				while (obj7 != null)
				{
					if (num2 == 0)
					{
						c2J = (c2J)(object)g5LW.Default;
					}
				}
			}
		}
		while (obj7 != null)
		{
			try
			{
				try
				{
					_ = (a9PE)(object)g5LW.Default;
				}
				finally
				{
					_ = (Jt0m)(object)g5LW.Default;
					i6A i6A = (i6A)(object)g5LW.Default;
					_ = (Jt0m)(object)g5LW.Default;
					goto end_IL_05e0;
				}
				end_IL_05e0:;
			}
			catch
			{
				if (unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)(UIntPtr)g5LW.Default) + unchecked((nuint)(UIntPtr)g5LW.Default)) == 0)
				{
					_ = (n4R1)(object)g5LW.Default;
					continue;
				}
				_ = (c2J)(object)g5LW.Default;
				n4R1 n4R = (n4R1)(object)g5LW.Default;
				n4R = n4R;
			}
		}
		return;
		IL_0330:
		try
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = null;
				}
			}
			else
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		catch
		{
			checked
			{
				while ((object)g5LW.Default != null)
				{
					if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)g5LW.Default) == 0)
					{
						n4R1 n4R = null;
					}
				}
			}
		}
		num2 = default(UIntPtr);
		if (num2 / num2 == 0)
		{
			try
			{
				while (obj7 != null)
				{
					n4R1 n4R = null;
				}
			}
			finally
			{
				try
				{
					_ = (a9PE)(object)g5LW.Default;
				}
				catch
				{
					_ = (k8D5)(object)g5LW.Default;
				}
				goto IL_03d2;
			}
		}
		goto IL_03d2;
		IL_03d2:
		try
		{
			while (obj7 != null)
			{
				_ = (Jt0m)(object)g5LW.Default;
			}
		}
		finally
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				n4R1 n4R = null;
			}
			else
			{
				while (obj7 != null)
				{
					_ = (_003CModule_003E)(object)g5LW.Default;
				}
			}
			goto IL_0413;
		}
	}

	static void Gj1p()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Jt0m jt0m);
		try
		{
			try
			{
				jt0m = jt0m;
				jt0m = null;
			}
			catch
			{
			}
		}
		catch
		{
			try
			{
				_ = (c2J)(object)g5LW.Default;
				obj2 = null;
			}
			finally
			{
				_003CModule_003E obj3 = (_003CModule_003E)(object)g5LW.Default;
				_003CModule_003E = (_003CModule_003E)(object)g5LW.Default;
				_003CModule_003E = obj3;
				goto end_IL_0015;
			}
			end_IL_0015:;
		}
		_ = (Wx57)(object)g5LW.Default;
		nuint uIntPtr = (UIntPtr)g5LW.Default;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i6A i6A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sk5 sk);
		if (uIntPtr == 0)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				nuint num = uIntPtr;
				nuint num2 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num / checked(num2 - uIntPtr) == 0)
				{
					_ = (c2J)(object)g5LW.Default;
				}
			}
			catch
			{
				_ = (a9PE)(object)g5LW.Default;
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				i6A obj6 = (i6A)(object)g5LW.Default;
				i6A = (i6A)(object)g5LW.Default;
				i6A = obj6;
				_ = (c2J)(object)g5LW.Default;
				sk = sk;
				sk = null;
				_ = (i6A)(object)g5LW.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a9PE a9PE);
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (i6A)(object)g5LW.Default;
			}
			catch
			{
				a9PE = null;
			}
		}
		else if (checked(unchecked((nuint)(UIntPtr)g5LW.Default) - unchecked((nuint)(UIntPtr)g5LW.Default)) == 0)
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				_ = (n4R1)(object)g5LW.Default;
				_ = (Wx57)(object)g5LW.Default;
				_ = (_003CModule_003E)(object)g5LW.Default;
			}
		}
		else
		{
			do
			{
				a9PE = a9PE;
			}
			while (obj2 != null);
		}
		if (uIntPtr == 0 && (UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
				_ = (Jt0m)(object)g5LW.Default;
			}
			finally
			{
				_ = (Sk5)(object)g5LW.Default;
				goto IL_01a8;
			}
		}
		goto IL_01a8;
		IL_01a8:
		nuint num3 = uIntPtr;
		uIntPtr = default(UIntPtr);
		n4R1 n4R;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8D5 k8D6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g5LW g5LW);
		checked
		{
			if (unchecked(num3 / uIntPtr) * uIntPtr == 0)
			{
				_ = (Ht2)(object)g5LW.Default;
			}
			else if (uIntPtr == 0 && uIntPtr == 0)
			{
				_ = (Jt0m)(object)g5LW.Default;
			}
			try
			{
				try
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						jt0m = null;
					}
					else
					{
						_ = (Ht2)(object)g5LW.Default;
						i6A = null;
						jt0m = jt0m;
						_ = (k8D5)(object)g5LW.Default;
					}
				}
				catch
				{
					_ = (Jt0m)(object)g5LW.Default;
				}
			}
			catch
			{
				jt0m = (Jt0m)(object)g5LW.Default;
			}
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					do
					{
						_ = (Sk5)(object)g5LW.Default;
					}
					while (obj2 != null);
				}
				else
				{
					do
					{
						i6A = (i6A)(object)g5LW.Default;
						_ = (c2J)(object)g5LW.Default;
						_ = (n4R1)(object)g5LW.Default;
						k8D5 obj10 = (k8D5)(object)g5LW.Default;
						k8D6 = k8D6;
						k8D6 = obj10;
					}
					while (obj2 != null);
				}
			}
			catch
			{
				try
				{
					_ = (_003CModule_003E)(object)g5LW.Default;
					_ = (Jt0m)(object)g5LW.Default;
				}
				catch
				{
					try
					{
						Wx57 wx = wx;
						wx = null;
						goto end_IL_02c4;
					}
					catch
					{
						_ = (k8D5)(object)g5LW.Default;
						goto end_IL_02c4;
					}
					end_IL_02c4:;
				}
			}
			_ = (n4R1)(object)g5LW.Default;
			while (obj2 != null)
			{
				_ = (k8G6)(object)g5LW.Default;
			}
			_ = (Wx57)(object)g5LW.Default;
			n4R = null;
			n4R = null;
			_ = (Wx57)(object)g5LW.Default;
			sk = sk;
			_ = (a9PE)(object)g5LW.Default;
			try
			{
				while (true)
				{
					if (obj2 != null)
					{
						_ = (a9PE)(object)g5LW.Default;
					}
					else if (obj2 == null)
					{
						break;
					}
				}
			}
			finally
			{
				if (uIntPtr == 0)
				{
					do
					{
						_ = (Ht2)(object)g5LW.Default;
						i6A = i6A;
						g5LW = g5LW;
						g5LW = null;
						_ = (k8D5)(object)g5LW.Default;
					}
					while ((object)g5LW.Default != null);
				}
				goto IL_0396;
			}
		}
		IL_0528:
		while ((object)g5LW.Default != null)
		{
			_ = (_003CModule_003E)(object)g5LW.Default;
			_ = (Wx57)(object)g5LW.Default;
			_ = g5LW.Default;
			_ = (Jt0m)(object)g5LW.Default;
		}
		try
		{
			_ = (_003CModule_003E)(object)g5LW.Default;
		}
		finally
		{
			try
			{
				_ = g5LW.Default;
			}
			catch
			{
				_ = (k8D5)(object)g5LW.Default;
				_ = (c2J)(object)g5LW.Default;
				_ = (Wx57)(object)g5LW.Default;
				c2J c2J = c2J;
			}
			goto IL_057d;
		}
		IL_057d:
		n4R = n4R;
		_ = (k8G6)(object)g5LW.Default;
		_ = (n4R1)(object)g5LW.Default;
		_ = (k8G6)(object)g5LW.Default;
		return;
		IL_0396:
		try
		{
			try
			{
				k8D6 = k8D6;
			}
			finally
			{
				while (obj2 != null)
				{
					g5LW = g5LW;
				}
				goto end_IL_0397;
			}
			end_IL_0397:;
		}
		finally
		{
			n4R = (n4R1)(object)g5LW.Default;
			n4R = n4R;
			sk = null;
			k8D6 = k8D6;
			goto IL_03dc;
		}
		IL_047c:
		if (uIntPtr / checked(unchecked((nuint)(UIntPtr)g5LW.Default) + unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)))) == 0)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					a9PE = a9PE;
					jt0m = jt0m;
					_ = (Ht2)(object)g5LW.Default;
				}
			}
			finally
			{
				while (obj2 != null)
				{
					_ = (c2J)(object)g5LW.Default;
					g5LW = g5LW.Default;
				}
				goto IL_0528;
			}
		}
		goto IL_0528;
		IL_03dc:
		try
		{
			if (uIntPtr == 0)
			{
				do
				{
					sk = null;
				}
				while ((object)g5LW.Default != null);
			}
			else
			{
				try
				{
					_ = (k8D5)(object)g5LW.Default;
				}
				catch
				{
					_ = (Ht2)(object)g5LW.Default;
				}
			}
		}
		finally
		{
			nuint num4 = uIntPtr / uIntPtr;
			uIntPtr = default(UIntPtr);
			checked
			{
				if (num4 * unchecked(checked(uIntPtr * uIntPtr - uIntPtr) / (nuint)(UIntPtr)g5LW.Default) == 0)
				{
					do
					{
						_ = (n4R1)(object)g5LW.Default;
					}
					while ((object)g5LW.Default != null);
				}
				else if (uIntPtr == 0)
				{
					i6A = i6A;
				}
				else
				{
					sk = (Sk5)(object)g5LW.Default;
				}
				goto IL_047c;
			}
		}
	}

	static void z8ZL()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr uIntPtr);
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			uIntPtr = uIntPtr;
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				while (true)
				{
					obj = obj;
					if (obj != null)
					{
						_ = (k8D5)(object)g5LW.Default;
						continue;
					}
					break;
				}
			}
			else
			{
				while (obj != null)
				{
					_ = (Ht2)(object)g5LW.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c2J c2J);
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				while ((object)g5LW.Default != null)
				{
					_ = (Wx57)(object)g5LW.Default;
				}
			}
			else
			{
				try
				{
					_ = (c2J)(object)g5LW.Default;
				}
				catch
				{
					c2J = c2J;
					c2J = c2J;
				}
			}
		}
		try
		{
		}
		catch
		{
			_ = (n4R1)(object)g5LW.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8G6 k8G);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a9PE a9PE);
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				a9PE obj4 = (a9PE)(object)g5LW.Default;
				a9PE = (a9PE)(object)g5LW.Default;
				a9PE = obj4;
				k8G = null;
				k8G = null;
			}
			else
			{
				c2J = c2J;
			}
		}
		catch
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				Jt0m obj5 = (Jt0m)(object)g5LW.Default;
				Jt0m jt0m = jt0m;
				jt0m = obj5;
				_ = (n4R1)(object)g5LW.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n4R1 n4R);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g5LW g5LW);
		checked
		{
			do
			{
				if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)g5LW.Default) - unchecked((nuint)(UIntPtr)g5LW.Default) == 0)
				{
					try
					{
						_ = (_003CModule_003E)(object)g5LW.Default;
					}
					catch
					{
						_ = (a9PE)(object)g5LW.Default;
					}
				}
			}
			while (obj != null);
			if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) != 0)
			{
				if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u))
				{
					try
					{
						_ = g5LW.Default;
					}
					catch
					{
						_ = (Wx57)(object)g5LW.Default;
						_ = (a9PE)(object)g5LW.Default;
						_ = (a9PE)(object)g5LW.Default;
						_ = (c2J)(object)g5LW.Default;
					}
				}
				else
				{
					g5LW = g5LW;
					g5LW = g5LW;
				}
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr - uIntPtr == 0)
			{
				_ = (i6A)(object)g5LW.Default;
				Sk5 sk = sk;
				sk = sk;
				c2J = c2J;
				_ = (k8G6)(object)g5LW.Default;
			}
			else
			{
				n4R = n4R;
				n4R = n4R;
			}
			_ = (a9PE)(object)g5LW.Default;
			_ = (Wx57)(object)g5LW.Default;
			try
			{
			}
			catch
			{
				if (unchecked((nuint)(UIntPtr)g5LW.Default / (nuint)(UIntPtr)g5LW.Default) + unchecked((nuint)(UIntPtr)g5LW.Default) == 0)
				{
					do
					{
						_ = g5LW.Default;
					}
					while (obj != null);
				}
				else
				{
					try
					{
						_ = (k8G6)(object)g5LW.Default;
					}
					catch
					{
						_ = (c2J)(object)g5LW.Default;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ht2 ht);
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				_ = (k8D5)(object)g5LW.Default;
			}
		}
		else
		{
			try
			{
				nuint num = (nuint)(UIntPtr)g5LW.Default / (nuint)(UIntPtr)g5LW.Default;
				uIntPtr = default(UIntPtr);
				if (num / uIntPtr == 0)
				{
					ht = ht;
					ht = ht;
					_ = (c2J)(object)g5LW.Default;
					_ = g5LW.Default;
				}
				else
				{
					_ = (Jt0m)(object)g5LW.Default;
				}
			}
			catch
			{
				try
				{
					_ = (k8G6)(object)g5LW.Default;
					_ = (c2J)(object)g5LW.Default;
				}
				catch
				{
					_ = g5LW.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wx57 wx);
		if (uIntPtr == 0)
		{
			try
			{
				_ = (Jt0m)(object)g5LW.Default;
				n4R = n4R;
				wx = wx;
				wx = wx;
			}
			catch
			{
				_ = (Wx57)(object)g5LW.Default;
			}
		}
		else
		{
			_ = (i6A)(object)g5LW.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8D5 k8D6);
		try
		{
			try
			{
				if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
				{
					_ = (a9PE)(object)g5LW.Default;
				}
			}
			finally
			{
				if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Wx57)(object)g5LW.Default;
				}
				goto end_IL_0380;
			}
			end_IL_0380:;
		}
		finally
		{
			while (obj != null)
			{
				try
				{
					k8D6 = null;
				}
				finally
				{
					_ = (i6A)(object)g5LW.Default;
					continue;
				}
			}
			goto IL_0425;
		}
		IL_0425:
		while (obj != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr / (nuint)(UIntPtr)g5LW.Default == 0)
			{
				if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
				{
					_ = (i6A)(object)g5LW.Default;
				}
				continue;
			}
			try
			{
				_ = (Jt0m)(object)g5LW.Default;
			}
			catch
			{
				_ = (k8D5)(object)g5LW.Default;
			}
		}
		try
		{
		}
		finally
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Jt0m)(object)g5LW.Default;
				}
				else
				{
					k8G = k8G;
					_ = (i6A)(object)g5LW.Default;
					c2J = c2J;
				}
			}
			finally
			{
				try
				{
					_ = (Ht2)(object)g5LW.Default;
					Jt0m jt0m = null;
				}
				catch
				{
					_ = (_003CModule_003E)(object)g5LW.Default;
				}
				goto IL_0483;
			}
		}
		IL_0483:
		uIntPtr = default(UIntPtr);
		if (uIntPtr != (UIntPtr)(nuint)0u)
		{
			_ = (Wx57)(object)g5LW.Default;
		}
		while (obj != null)
		{
			try
			{
				Sk5 sk = null;
			}
			finally
			{
				_ = (Sk5)(object)g5LW.Default;
				continue;
			}
		}
		while (obj != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (k8D5)(object)g5LW.Default;
				}
				while (obj != null);
			}
		}
		try
		{
			ht = null;
		}
		finally
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					k8D6 = k8D6;
				}
			}
			catch
			{
				do
				{
					_ = (Wx57)(object)g5LW.Default;
				}
				while (obj != null);
			}
			goto IL_0512;
		}
		IL_0512:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			ht = ht;
			_ = (c2J)(object)g5LW.Default;
		}
		else
		{
			try
			{
				_ = g5LW.Default;
				_ = (a9PE)(object)g5LW.Default;
			}
			catch
			{
				a9PE = a9PE;
			}
		}
		try
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				k8G = k8G;
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
				{
					a9PE = a9PE;
				}
				else
				{
					_ = (_003CModule_003E)(object)g5LW.Default;
					a9PE = a9PE;
				}
			}
			goto IL_05d5;
		}
		IL_05d5:
		while (obj != null)
		{
			try
			{
				_ = (_003CModule_003E)(object)g5LW.Default;
			}
			finally
			{
				do
				{
					_ = (Jt0m)(object)g5LW.Default;
				}
				while ((object)g5LW.Default != null);
				continue;
			}
		}
		try
		{
			do
			{
				Sk5 sk = (Sk5)(object)g5LW.Default;
			}
			while (obj != null);
		}
		catch
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					ht = ht;
				}
			}
			finally
			{
				try
				{
					_ = (Jt0m)(object)g5LW.Default;
				}
				catch
				{
					_ = (Ht2)(object)g5LW.Default;
					_ = (i6A)(object)g5LW.Default;
					_ = g5LW.Default;
				}
				goto end_IL_05f2;
			}
			end_IL_05f2:;
		}
		g5LW = g5LW;
		wx = null;
	}
}
