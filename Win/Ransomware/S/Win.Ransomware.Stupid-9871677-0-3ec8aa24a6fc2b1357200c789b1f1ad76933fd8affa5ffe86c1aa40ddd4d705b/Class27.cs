using System;
using System.IO;
using System.Text;
using Ionic.Zip;
using Ionic.Zlib;

internal class Class27
{
	private GClass9 gclass9_0;

	private GStream6 gstream6_0;

	private GStream5 gstream5_0;

	public GClass9 GClass9_0 => gclass9_0;

	public GStream6 GStream6_0 => gstream6_0;

	public string String_0
	{
		get
		{
			if (gclass9_0 != null)
			{
				return gclass9_0.String_1;
			}
			if (gstream5_0 != null)
			{
				throw new NotSupportedException();
			}
			return gstream6_0.String_1;
		}
	}

	public string String_1
	{
		get
		{
			if (gclass9_0 != null)
			{
				return gclass9_0.string_3;
			}
			if (gstream5_0 != null)
			{
				return gstream5_0.string_0;
			}
			return gstream6_0.string_0;
		}
	}

	public Zip64Option Zip64Option_0
	{
		get
		{
			if (gclass9_0 != null)
			{
				return gclass9_0.zip64Option_0;
			}
			if (gstream5_0 != null)
			{
				throw new NotSupportedException();
			}
			return gstream6_0.zip64Option_0;
		}
	}

	public int Int32_0
	{
		get
		{
			if (gclass9_0 != null)
			{
				return gclass9_0.Int32_0;
			}
			if (gstream5_0 != null)
			{
				throw new NotSupportedException();
			}
			return 0;
		}
	}

	public GStream2 GStream2_0
	{
		get
		{
			if (gclass9_0 != null)
			{
				return gclass9_0.gstream2_0;
			}
			if (gstream5_0 != null)
			{
				return null;
			}
			return gstream6_0.gstream2_0;
		}
		set
		{
			if (gclass9_0 != null)
			{
				gclass9_0.gstream2_0 = value;
			}
			else if (gstream6_0 != null)
			{
				gstream6_0.gstream2_0 = value;
			}
		}
	}

	public long Int64_0
	{
		get
		{
			if (gclass9_0 != null)
			{
				return gclass9_0.Int64_0;
			}
			return gstream6_0.Int64_0;
		}
	}

	public int Int32_1
	{
		get
		{
			if (gclass9_0 != null)
			{
				return gclass9_0.Int32_4;
			}
			return gstream6_0.Int32_1;
		}
	}

	public int Int32_2
	{
		get
		{
			if (gclass9_0 != null)
			{
				return gclass9_0.Int32_1;
			}
			if (gstream5_0 != null)
			{
				return gstream5_0.Int32_0;
			}
			return gstream6_0.Int32_0;
		}
	}

	public CompressionStrategy CompressionStrategy_0
	{
		get
		{
			if (gclass9_0 != null)
			{
				return gclass9_0.CompressionStrategy_0;
			}
			return gstream6_0.CompressionStrategy_0;
		}
	}

	public Zip64Option Zip64Option_1
	{
		get
		{
			if (gclass9_0 != null)
			{
				return gclass9_0.Zip64Option_0;
			}
			return gstream6_0.Zip64Option_0;
		}
	}

	public Encoding Encoding_0
	{
		get
		{
			if (gclass9_0 != null)
			{
				return gclass9_0.Encoding_1;
			}
			if (gstream6_0 != null)
			{
				return gstream6_0.Encoding_1;
			}
			return null;
		}
	}

	public Encoding Encoding_1
	{
		get
		{
			if (gclass9_0 != null)
			{
				return GClass9.Encoding_2;
			}
			if (gstream6_0 != null)
			{
				return GStream6.Encoding_2;
			}
			return null;
		}
	}

	public ZipOption ZipOption_0
	{
		get
		{
			if (gclass9_0 != null)
			{
				return gclass9_0.ZipOption_0;
			}
			if (gstream6_0 != null)
			{
				return gstream6_0.ZipOption_0;
			}
			return ZipOption.Default;
		}
	}

	public Stream Stream_0
	{
		get
		{
			if (gclass9_0 != null)
			{
				return gclass9_0.Stream_0;
			}
			return gstream5_0.Stream_0;
		}
	}

	public Class27(object o)
	{
		gclass9_0 = o as GClass9;
		gstream6_0 = o as GStream6;
		gstream5_0 = o as GStream5;
	}
}
