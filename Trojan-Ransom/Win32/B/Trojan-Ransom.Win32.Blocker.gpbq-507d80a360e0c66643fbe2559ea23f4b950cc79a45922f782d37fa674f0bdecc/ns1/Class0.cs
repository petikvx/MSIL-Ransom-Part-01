using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using ns2;
using ns3;

namespace ns1;

internal static class Class0
{
	private static Assembly smethod_0(Package package_0, string string_0)
	{
		Uri uri_ = new Uri(string_0, UriKind.Relative);
		Stream stream = Delegate1.delegate1_1(Delegate0.delegate0_1(package_0, uri_));
		byte[] array;
		try
		{
			array = new byte[(int)Delegate2.delegate2_1(stream)];
			Delegate3.delegate3_1(stream, array, 0, array.Length);
		}
		finally
		{
			if (stream != null)
			{
				Delegate4.delegate4_1(stream);
			}
		}
		Assembly assembly = Delegate5.delegate5_0(array);
		if (Delegate6.delegate6_0(null, assembly))
		{
			throw new ArgumentException(Delegate7.delegate7_0(Class1.smethod_0(Class3.smethod_0(Class5.smethod_0(Class7.smethod_0(Class9.smethod_0(Class16.smethod_0(251), 60933), 58482), 61701), 62021), 61544), string_0));
		}
		return assembly;
	}

	[STAThread]
	private static void Main(string[] args)
	{
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		if (Delegate9.delegate9_0(Delegate8.delegate8_0(), new DateTime(635618784856250000L)))
		{
			throw new Exception();
		}
		if (Delegate9.delegate9_0(Delegate8.delegate8_0(), new DateTime(635618784792333984L)))
		{
			throw new Exception();
		}
		if (Delegate9.delegate9_0(Delegate8.delegate8_0(), new DateTime(635618784739121094L)))
		{
			throw new Exception();
		}
		if (Delegate9.delegate9_0(Delegate8.delegate8_0(), new DateTime(635618784676513672L)))
		{
			throw new Exception();
		}
		if (Delegate9.delegate9_0(Delegate8.delegate8_0(), new DateTime(635618784360800781L)))
		{
			throw new Exception();
		}
		try
		{
			Stream stream = Delegate12.delegate12_1(Delegate11.delegate11_1(Delegate10.delegate10_0(typeof(Class0).TypeHandle)), Class1.smethod_0(Class3.smethod_0(Class5.smethod_0(Class7.smethod_0(Class9.smethod_0(Class16.smethod_0(352), 59605), 61694), 58168), 60209), 63343));
			try
			{
				Package val = Delegate13.delegate13_0(stream, FileMode.Open, FileAccess.Read);
				try
				{
					Assembly object_ = smethod_0(val, Class1.smethod_0(Class3.smethod_0(Class5.smethod_0(Class7.smethod_0(Class9.smethod_0(Class16.smethod_0(373), 58803), 61190), 60790), 58366), 61946));
					Delegate15.delegate15_1(Delegate14.delegate14_1(object_), null, new object[0]);
				}
				finally
				{
					if (val != null)
					{
						Delegate4.delegate4_1(val);
					}
				}
			}
			finally
			{
				if (stream != null)
				{
					Delegate4.delegate4_1(stream);
				}
			}
		}
		catch (Exception object_2)
		{
			string[] string_ = new string[5]
			{
				Delegate17.delegate17_1(Delegate16.delegate16_1(object_2)),
				Delegate18.delegate18_0(),
				Delegate17.delegate17_3(object_2),
				Delegate18.delegate18_0(),
				Delegate17.delegate17_5(object_2)
			};
			Delegate20.delegate20_0(Delegate19.delegate19_0(string_));
		}
	}
}
