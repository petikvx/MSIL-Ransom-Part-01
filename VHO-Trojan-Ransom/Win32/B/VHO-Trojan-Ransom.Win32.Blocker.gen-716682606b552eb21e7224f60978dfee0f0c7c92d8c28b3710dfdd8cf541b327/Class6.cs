using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using O;
using ns0;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Class6
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class7
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm1 gform1_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm0 gform0_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class7()
		{
		}

		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			if (gparam_0 != null && !((Control)gparam_0).get_IsDisposed())
			{
				return gparam_0;
			}
			if (hashtable_0 != null)
			{
				if (Class11.smethod_19(hashtable_0, (object)typeof(T), (short)884, (short)861))
				{
					throw new InvalidOperationException(Utils.GetResourceString(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uffd8￦￡\uffc9￠\ufffd￢￼\uffd0\uffdd￪￬\ufffa\ufffd￼￦\ufff9￪\uffc9￠\ufffd￢ￌ\ufffd￪￮\ufffb￪", 57892), 60133), 63305), new string[0]));
				}
			}
			else
			{
				hashtable_0 = new Hashtable();
			}
			Class14.smethod_9<object, Hashtable, object>(hashtable_0, typeof(T), null, 'Ō', 346);
			try
			{
				return new T();
			}
			catch (TargetInvocationException ex) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				GForm1.smethod_6((Exception)ex, 'π', (short)999);
				return Class11.smethod_20((Exception)ex, (short)483, 'ƹ') != null;
			}).Invoke())
			{
				throw new InvalidOperationException(Utils.GetResourceString(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue9a4\ue99a\ue99d\ue9b5\ue99c\ue981\ue99e\ue980\ue9ac\ue9a0\ue996\ue996\ue9ba\ue99d\ue99d\ue996\ue981\ue9b6\ue98b\ue990\ue996\ue983\ue987\ue99a\ue99c\ue99d", 59475), 62858), 62495), new string[1] { Class11.smethod_20((Exception)ex, (short)13, 'W').Message }), ex.InnerException);
			}
			finally
			{
				hashtable_0.Remove(typeof(T));
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(GForm1.smethod_18(obj, 813, 882));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return typeof(Class7);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[SpecialName]
		public GForm1 method_1()
		{
			gform1_0 = smethod_0(gform1_0);
			return gform1_0;
		}

		[SpecialName]
		public GForm0 method_2()
		{
			gform0_0 = smethod_0(gform0_0);
			return gform0_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class8
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class8()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(GForm1.smethod_18(obj, 832, 799));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return typeof(Class8);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class9<T> where T : new()
	{
		[ThreadStatic]
		private static T gparam_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class9()
		{
		}

		[SpecialName]
		internal T method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new T();
			}
			return gparam_0;
		}
	}

	private static readonly Class9<User> class9_0 = new Class9<User>();

	private static readonly Class9<Class4> class9_1 = new Class9<Class4>();

	private static Class9<Class7> class9_2 = new Class9<Class7>();

	private static readonly Class9<Class5> class9_3 = new Class9<Class5>();

	private static readonly Class9<Class8> class9_4 = new Class9<Class8>();

	[HelpKeyword("My.User")]
	internal static object Object_0 => class9_0.method_0();

	[HelpKeyword("My.Application")]
	internal static object Object_1 => class9_1.method_0();

	[HelpKeyword("My.Forms")]
	internal static object Object_2 => class9_2.method_0();

	[HelpKeyword("My.Computer")]
	internal static object Object_3 => class9_3.method_0();

	[HelpKeyword("My.WebServices")]
	internal static object Object_4 => class9_4.method_0();
}
