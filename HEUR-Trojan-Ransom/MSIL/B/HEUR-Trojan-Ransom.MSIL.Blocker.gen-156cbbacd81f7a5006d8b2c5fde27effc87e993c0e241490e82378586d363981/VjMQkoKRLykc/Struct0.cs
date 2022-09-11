using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace VjMQkoKRLykc;

[StructLayout(LayoutKind.Auto)]
internal struct Struct0
{
	internal readonly xQoRcMH2TCyILSVUvs3GBcsOj2uEIms9JlJzHIcsb0AL[] gmhFU1TuZeJxtfCvAfouczUbNs1Hrtf7WvUlRWpkZ4AZ;

	internal int int_0;

	internal long ufIJTmEqa9rw63vLfPyhaSKmXJBv0YNdsoE8tBNYDauG;

	internal long long_0;

	internal readonly long long_1;

	internal readonly bool bool_0;

	internal static void smethod_0(byte[] byte_0)
	{
		Class10.smethod_0(byte_0);
	}

	internal bool method_0(out long long_2, out long long_3)
	{
		int num = gmhFU1TuZeJxtfCvAfouczUbNs1Hrtf7WvUlRWpkZ4AZ.Length;
		do
		{
			xQoRcMH2TCyILSVUvs3GBcsOj2uEIms9JlJzHIcsb0AL xQoRcMH2TCyILSVUvs3GBcsOj2uEIms9JlJzHIcsb0AL2 = gmhFU1TuZeJxtfCvAfouczUbNs1Hrtf7WvUlRWpkZ4AZ[int_0];
			if (xQoRcMH2TCyILSVUvs3GBcsOj2uEIms9JlJzHIcsb0AL2.z2eqmTWWhMEDG68oVEw6Gav8iGa5s5ppts9R3cDmHVbC == 0)
			{
				long num2 = 0L;
				if (IntPtr.Size != 4 || !bool_0)
				{
					num2 = Interlocked.Add(ref gmhFU1TuZeJxtfCvAfouczUbNs1Hrtf7WvUlRWpkZ4AZ[int_0].long_2, long_0) - long_0;
				}
				if (xQoRcMH2TCyILSVUvs3GBcsOj2uEIms9JlJzHIcsb0AL2.long_1 - xQoRcMH2TCyILSVUvs3GBcsOj2uEIms9JlJzHIcsb0AL2.long_0 > num2)
				{
					long_2 = xQoRcMH2TCyILSVUvs3GBcsOj2uEIms9JlJzHIcsb0AL2.long_0 + num2;
					long_3 = long_2 + long_0;
					if (long_3 > xQoRcMH2TCyILSVUvs3GBcsOj2uEIms9JlJzHIcsb0AL2.long_1 || long_3 < xQoRcMH2TCyILSVUvs3GBcsOj2uEIms9JlJzHIcsb0AL2.long_0)
					{
						long_3 = xQoRcMH2TCyILSVUvs3GBcsOj2uEIms9JlJzHIcsb0AL2.long_1;
					}
					if (long_0 < long_1)
					{
						long_0 *= 2L;
						if (long_0 > long_1)
						{
							long_0 = long_1;
						}
					}
					return true;
				}
				Interlocked.Exchange(ref gmhFU1TuZeJxtfCvAfouczUbNs1Hrtf7WvUlRWpkZ4AZ[int_0].z2eqmTWWhMEDG68oVEw6Gav8iGa5s5ppts9R3cDmHVbC, 1);
			}
			int_0 = (int_0 + 1) % gmhFU1TuZeJxtfCvAfouczUbNs1Hrtf7WvUlRWpkZ4AZ.Length;
			num--;
		}
		while (num > 0);
		long_2 = 0L;
		long_3 = 0L;
		return false;
	}

	internal bool method_1(out int int_1, out int int_2)
	{
		long long_;
		long long_2;
		bool result = method_0(out long_, out long_2);
		int_1 = (int)long_;
		int_2 = (int)long_2;
		return result;
	}
}
