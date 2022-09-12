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
using Ak9;
using Ar7;
using Ek3;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Qf0;
using Re3;
using Yb6;
using e6AW;
using j7JG;
using o5T;
using p0J;

namespace Zc7;

[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
internal sealed class Dd8
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class b0A
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public a3Y m_frmAcercade;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t3T m_frmArmas;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q4H9 m_frmClase;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public n8A m_frmClosingServer;

		public a3Y frmAcercade
		{
			[DebuggerHidden]
			get
			{
				m_frmAcercade = Ht5(m_frmAcercade);
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
					g8A(ref m_frmAcercade);
				}
			}
		}

		public t3T frmArmas
		{
			[DebuggerHidden]
			get
			{
				m_frmArmas = Ht5(m_frmArmas);
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
					g8A(ref m_frmArmas);
				}
			}
		}

		public q4H9 frmClase
		{
			[DebuggerHidden]
			get
			{
				m_frmClase = Ht5(m_frmClase);
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
					g8A(ref m_frmClase);
				}
			}
		}

		public n8A frmClosingServer
		{
			[DebuggerHidden]
			get
			{
				m_frmClosingServer = Ht5(m_frmClosingServer);
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
					g8A(ref m_frmClosingServer);
				}
			}
		}

		[DebuggerHidden]
		private static r2W Ht5<r2W>(r2W j9X) where r2W : Form, new()
		{
			if (j9X == null || ((Control)j9X).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(r2W)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(r2W), null);
				try
				{
					return new r2W();
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
					m_FormBeingCreated.Remove(typeof(r2W));
				}
			}
			return j9X;
		}

		[DebuggerHidden]
		private void g8A<Sx6>(ref Sx6 r5T) where Sx6 : Form
		{
			((Component)r5T).Dispose();
			r5T = default(Sx6);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public b0A()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Tb1(object a5K)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(a5K));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Wa4()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type w2X()
		{
			return typeof(b0A);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Ke9()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Zq2
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Px4(object Xa1)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Xa1));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Ri2()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type r1K()
		{
			return typeof(Zq2);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string z6R()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Sy5 g3Z<Sy5>(Sy5 q5N) where Sy5 : new()
		{
			if (q5N == null)
			{
				return new Sy5();
			}
			return q5N;
		}

		[DebuggerHidden]
		private void Yj7<a3D>(ref a3D Ai9)
		{
			Ai9 = default(a3D);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zq2()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class g7Y<Dr1> where Dr1 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static Dr1 m_ThreadStaticValue;

		internal Dr1 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Dr1();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public g7Y()
		{
		}
	}

	private static readonly g7Y<Ry0> m_ComputerObjectProvider = new g7Y<Ry0>();

	private static readonly g7Y<Ab4> m_AppObjectProvider = new g7Y<Ab4>();

	private static readonly g7Y<User> m_UserObjectProvider = new g7Y<User>();

	private static g7Y<b0A> m_MyFormsObjectProvider = new g7Y<b0A>();

	private static readonly g7Y<Zq2> m_MyWebServicesObjectProvider = new g7Y<Zq2>();

	[HelpKeyword("My.Computer")]
	internal static Ry0 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Ab4 Application
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
	internal static b0A Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Zq2 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}

	static void y2Q()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num);
		if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
		{
			c0W c0W = c0W;
			c0W = c0W;
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = j6Q.Default;
			}
			else
			{
				_ = (Ry0)(object)j6Q.Default;
			}
		}
		j6Q j6Q = j6Q.Default;
		j6Q = j6Q;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		try
		{
			do
			{
				num = default(UIntPtr);
				nuint num2 = num;
				num = default(UIntPtr);
				if (checked(num2 * num) == 0)
				{
					_ = (Ry0)(object)j6Q.Default;
				}
				obj = obj;
			}
			while (obj != null);
		}
		finally
		{
			_ = j6Q.Default;
			goto IL_00b4;
		}
		IL_01e4:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xy3 xy);
		while (obj != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				xy = null;
				_ = (_003CModule_003E)(object)j6Q.Default;
				_ = (n8A)(object)j6Q.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q4H9 q4H);
		checked
		{
			while ((object)j6Q.Default != null)
			{
				try
				{
					_ = (t3T)(object)j6Q.Default;
				}
				catch
				{
					if (unchecked((nuint)(UIntPtr)j6Q.Default) - unchecked((nuint)(UIntPtr)j6Q.Default) * unchecked((nuint)(UIntPtr)j6Q.Default) == 0)
					{
						q4H = null;
					}
				}
			}
			j6Q = j6Q;
			_ = (d3D6)(object)j6Q.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t3T t3T);
		try
		{
			if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				c0W c0W = null;
			}
		}
		finally
		{
			t3T = t3T;
			t3T = null;
			goto IL_0265;
		}
		IL_00b4:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ry0 ry);
		try
		{
			do
			{
				try
				{
					Xy3 obj3 = (Xy3)(object)j6Q.Default;
					xy = xy;
					xy = obj3;
				}
				catch
				{
					ry = ry;
					ry = ry;
					_ = (n8A)(object)j6Q.Default;
				}
			}
			while (obj != null);
		}
		catch
		{
		}
		checked
		{
			try
			{
				if (num == 0)
				{
					ry = (Ry0)(object)j6Q.Default;
				}
			}
			catch
			{
				if (unchecked((nuint)(UIntPtr)j6Q.Default) + unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (Ab4)(object)j6Q.Default;
					_ = (t3T)(object)j6Q.Default;
					xy = xy;
				}
			}
		}
		if ((UIntPtr)j6Q.Default != (UIntPtr)(nuint)0u)
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ab4 ab);
		try
		{
			try
			{
				_ = (d3D6)(object)j6Q.Default;
				q4H = q4H;
				q4H = null;
				_ = (Xy3)(object)j6Q.Default;
				ab = ab;
				ab = ab;
			}
			finally
			{
				_ = (Ab4)(object)j6Q.Default;
				goto end_IL_0158;
			}
			end_IL_0158:;
		}
		finally
		{
			while ((object)j6Q.Default != null)
			{
				_ = (c0W)(object)j6Q.Default;
			}
			goto IL_01e4;
		}
		IL_0265:
		try
		{
			_ = (c0W)(object)j6Q.Default;
			_ = j6Q.Default;
			ry = (Ry0)(object)j6Q.Default;
		}
		catch
		{
			do
			{
				_ = (t3T)(object)j6Q.Default;
			}
			while (obj != null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			j6Q = j6Q;
		}
		_ = j6Q.Default;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (d3D6)(object)j6Q.Default;
		}
		_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)j6Q.Default;
		_003CModule_003E = _003CModule_003E;
		try
		{
			try
			{
				n8A n8A = n8A;
				n8A = null;
			}
			catch
			{
				_ = (_003CModule_003E)(object)j6Q.Default;
			}
		}
		catch
		{
			while (obj != null)
			{
				ry = (Ry0)(object)j6Q.Default;
			}
		}
		ab = ab;
		_ = (q4H9)(object)j6Q.Default;
		a3Y a3Y = a3Y;
		ry = ry;
		_ = (c0W)(object)j6Q.Default;
		_ = (Dd8)(object)j6Q.Default;
		try
		{
			do
			{
				_ = (d3D6)(object)j6Q.Default;
			}
			while (obj != null);
		}
		catch
		{
			if (num != (UIntPtr)(nuint)0u && (UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				t3T = t3T;
			}
		}
		if (num == (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (d3D6)(object)j6Q.Default;
				_ = (Ab4)(object)j6Q.Default;
				_ = (Xy3)(object)j6Q.Default;
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		q4H = q4H;
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)j6Q.Default;
			}
		}
		while (obj != null);
		if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
		{
			a3Y = a3Y;
		}
		else if (checked(unchecked((nuint)(UIntPtr)j6Q.Default) - unchecked((nuint)(UIntPtr)j6Q.Default)) == 0)
		{
			if ((nuint)(UIntPtr)j6Q.Default / unchecked((nuint)default(UIntPtr)) == 0)
			{
				_ = (d3D6)(object)j6Q.Default;
			}
			else
			{
				c0W c0W = null;
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				j6Q = j6Q;
			}
			else
			{
				_ = (_003CModule_003E)(object)j6Q.Default;
			}
		}
		catch
		{
			_ = (d3D6)(object)j6Q.Default;
		}
		finally
		{
			try
			{
				do
				{
					_ = (_003CModule_003E)(object)j6Q.Default;
				}
				while ((object)j6Q.Default != null);
				return;
			}
			finally
			{
				while (obj != null)
				{
					_ = (Ab4)(object)j6Q.Default;
				}
				return;
			}
		}
	}

	static void Le0()
	{
		Ab4 ab = null;
		ab = ab;
		nuint uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n8A n8A);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					n8A obj = (n8A)(object)j6Q.Default;
					n8A = null;
					n8A = obj;
				}
				else
				{
					d3D6 d3D = d3D;
					d3D = d3D;
					_ = (d3D6)(object)j6Q.Default;
				}
			}
			catch
			{
				while ((object)j6Q.Default != null)
				{
					d3D6 d3D = (d3D6)(object)j6Q.Default;
				}
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr - uIntPtr) / (nuint)(UIntPtr)j6Q.Default == 0)
			{
				do
				{
					_ = (d3D6)(object)j6Q.Default;
					ab = ab;
					d3D6 d3D = null;
					_ = (c0W)(object)j6Q.Default;
					_ = (c0W)(object)j6Q.Default;
					obj3 = j6Q.Default;
				}
				while (obj3 != null);
			}
		}
		_ = (a3Y)(object)j6Q.Default;
		while (obj3 != null)
		{
			do
			{
				if (default(UIntPtr) != (UIntPtr)(nuint)0u)
				{
					Xy3 xy = (Xy3)(object)j6Q.Default;
					xy = xy;
				}
				else
				{
					ab = null;
				}
			}
			while ((object)j6Q.Default != null);
		}
		_ = (Ab4)(object)j6Q.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j6Q j6Q);
		try
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (a3Y)(object)j6Q.Default;
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					j6Q = j6Q;
					j6Q = null;
				}
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					j6Q = j6Q.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)j6Q.Default;
					goto end_IL_017c;
				}
			}
			end_IL_017c:;
		}
		do
		{
			_ = (a3Y)(object)j6Q.Default;
		}
		while ((object)j6Q.Default != null);
		_ = (Ab4)(object)j6Q.Default;
		Dd8 obj6 = (Dd8)(object)j6Q.Default;
		Dd8 dd = null;
		dd = obj6;
		_ = (t3T)(object)j6Q.Default;
		_ = (d3D6)(object)j6Q.Default;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (a3Y)(object)j6Q.Default;
			dd = dd;
			goto IL_0274;
		}
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)j6Q.Default) * (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr))) == 0)
				{
					d3D6 d3D = (d3D6)(object)j6Q.Default;
				}
			}
			finally
			{
				try
				{
					t3T t3T = t3T;
					t3T = t3T;
				}
				finally
				{
					_003CModule_003E _003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					goto IL_0274;
				}
			}
		}
		IL_0274:
		j6Q = j6Q;
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr / uIntPtr == 0 && (UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
			{
				_ = (n8A)(object)j6Q.Default;
			}
		}
		while (obj3 != null);
		if (checked((uIntPtr - uIntPtr) * uIntPtr) == 0)
		{
			_ = (c0W)(object)j6Q.Default;
		}
		try
		{
			_ = (Xy3)(object)j6Q.Default;
		}
		catch
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Ry0)(object)j6Q.Default;
					_ = (q4H9)(object)j6Q.Default;
					_ = (Ry0)(object)j6Q.Default;
					dd = dd;
				}
			}
			finally
			{
				_ = (c0W)(object)j6Q.Default;
				Ry0 ry = null;
				ry = ry;
				goto end_IL_02df;
			}
			end_IL_02df:;
		}
		dd = dd;
		try
		{
			_ = (Ab4)(object)j6Q.Default;
		}
		finally
		{
			do
			{
				if ((UIntPtr)j6Q.Default != (UIntPtr)(nuint)0u)
				{
					Ry0 ry = (Ry0)(object)j6Q.Default;
				}
				else
				{
					_ = (d3D6)(object)j6Q.Default;
				}
			}
			while (obj3 != null);
			goto IL_0380;
		}
		IL_03ce:
		j6Q = null;
		j6Q = j6Q.Default;
		try
		{
			try
			{
				do
				{
					d3D6 d3D = null;
				}
				while ((object)j6Q.Default != null);
			}
			catch
			{
				do
				{
					_ = (a3Y)(object)j6Q.Default;
					_ = j6Q.Default;
				}
				while ((object)j6Q.Default != null);
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Ry0)(object)j6Q.Default;
					_ = (Dd8)(object)j6Q.Default;
				}
				catch
				{
					_ = (n8A)(object)j6Q.Default;
				}
			}
			else
			{
				Xy3 xy = (Xy3)(object)j6Q.Default;
			}
		}
		try
		{
			while ((object)j6Q.Default != null)
			{
				try
				{
					ab = null;
				}
				finally
				{
					_003CModule_003E _003CModule_003E = null;
					continue;
				}
			}
		}
		catch
		{
			while (true)
			{
				if (obj3 != null)
				{
					_ = j6Q.Default;
				}
				else if (obj3 == null)
				{
					break;
				}
			}
		}
		while (obj3 != null)
		{
			if (uIntPtr == 0)
			{
				n8A = null;
			}
		}
		try
		{
			_ = (Xy3)(object)j6Q.Default;
			return;
		}
		finally
		{
			while (obj3 != null)
			{
				while (obj3 != null)
				{
					n8A = n8A;
				}
			}
			return;
		}
		IL_0380:
		while (obj3 != null)
		{
			j6Q = j6Q;
		}
		try
		{
			do
			{
				_ = (a3Y)(object)j6Q.Default;
			}
			while ((object)j6Q.Default != null || obj3 != null);
		}
		finally
		{
			try
			{
				_ = j6Q.Default;
			}
			catch
			{
				if ((UIntPtr)j6Q.Default == (UIntPtr)(nuint)0u)
				{
					ab = null;
				}
			}
			goto IL_03ce;
		}
	}
}
