using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using E21wpg6v;
using Microsoft.VisualBasic.CompilerServices;
using di1mqJMz;
using l2iEFwW1;
using p80hVGtz;
using sReLFYF2;

namespace qGIjTe0w;

internal class Class3
{
	public static bool lpYtrlPR<lFEs3heZ>(lFEs3heZ GUMM2ZjW, string string_0)
	{
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		bool result = default(bool);
		try
		{
			if (GUMM2ZjW == null)
			{
				throw new ArgumentNullException("instance");
			}
			binaryFormatter = new BinaryFormatter();
			FileStream stream_ = new FileStream(string_0, FileMode.Create);
			try
			{
				vRvDyS3Z.mdII4JVG(binaryFormatter, stream_, GUMM2ZjW, 19015);
			}
			catch (Exception ex)
			{
				m8meAX3U.L6HgMKrR(ex, 21003);
				Exception hz5sFQEo = ex;
				pn1IqBv9.mRZ0d05U(ref hz5sFQEo);
				FFXb5i9i.LfyQ8gZ7(12759);
			}
			vRvDyS3Z.oNl1lUma(stream_, 19282);
			result = true;
			return result;
		}
		catch (Exception ex2)
		{
			m8meAX3U.L6HgMKrR(ex2, 21003);
			Exception hz5sFQEo2 = ex2;
			pn1IqBv9.mRZ0d05U(ref hz5sFQEo2);
			FFXb5i9i.LfyQ8gZ7(12759);
			return result;
		}
	}

	public static bool v5tCcXlN<Jj8MGmOo>(ref Jj8MGmOo WU1zMLV4, string CzBh5Ebv)
	{
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		FileStream stream_ = null;
		bool result = default(bool);
		try
		{
			if (WU1zMLV4 == null)
			{
				throw new ArgumentNullException("instance");
			}
			if (!P4ylgCWg.smethod_0(CzBh5Ebv, 33853))
			{
				throw new FileNotFoundException("File not found", CzBh5Ebv);
			}
			binaryFormatter = new BinaryFormatter();
			stream_ = new FileStream(CzBh5Ebv, FileMode.OpenOrCreate);
			WU1zMLV4 = Conversions.ToGenericParameter<Jj8MGmOo>(vRvDyS3Z.smethod_3(binaryFormatter, stream_, 49228));
			vRvDyS3Z.oNl1lUma(stream_, 19282);
			return result;
		}
		catch (Exception ex)
		{
			m8meAX3U.L6HgMKrR(ex, 21003);
			Exception hz5sFQEo = ex;
			pn1IqBv9.mRZ0d05U(ref hz5sFQEo);
			vRvDyS3Z.oNl1lUma(stream_, 19282);
			FFXb5i9i.LfyQ8gZ7(12759);
			return result;
		}
	}
}
