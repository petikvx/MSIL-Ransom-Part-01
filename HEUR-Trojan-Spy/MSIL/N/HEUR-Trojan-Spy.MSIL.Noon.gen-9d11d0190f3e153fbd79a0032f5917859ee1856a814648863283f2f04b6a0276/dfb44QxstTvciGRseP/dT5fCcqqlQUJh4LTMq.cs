using System.IO;

namespace dfb44QxstTvciGRseP;

public class dT5fCcqqlQUJh4LTMq : pa5jJ0nwqAWb49sMSj
{
	private readonly StreamReader hL42A3aot;

	internal static dT5fCcqqlQUJh4LTMq m0cWqyh7nSCjaTeDOu;

	public dT5fCcqqlQUJh4LTMq(string string_0)
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		base._002Ector(string_0);
		hL42A3aot = new StreamReader(lfvXq1OVn);
	}

	public override void Parse()
	{
		int num = 1;
		while (!hL42A3aot.EndOfStream)
		{
			while (true)
			{
				string string_ = hL42A3aot.ReadLine();
				if (!PXbF9IBBw(string_))
				{
					sbEbxl8id3Y3352lFX sbEbxl8id3Y3352lFX2 = sbEbxl8id3Y3352lFX.peHql9gAk(string_);
					sbEbxl8id3Y3352lFX2.FmNFFCZXVt(this);
					BhG9lk2Tw.Add(sbEbxl8id3Y3352lFX2);
					int num2 = 2;
					if (!NfxbiqC2lHar0ICDr7())
					{
						num2 = num;
					}
					switch (num2)
					{
					default:
						continue;
					case 1:
					case 2:
						break;
					}
				}
				break;
			}
		}
		ywF9u7qTNn3kevjJ1l(hL42A3aot);
	}

	private bool PXbF9IBBw(string string_0)
	{
		return string_0.Trim().StartsWith("#");
	}

	public override string ToString()
	{
		return Path.GetFileName(lfvXq1OVn);
	}

	public override void Dispose()
	{
		hL42A3aot.Dispose();
	}

	internal static bool NfxbiqC2lHar0ICDr7()
	{
		return m0cWqyh7nSCjaTeDOu == null;
	}

	internal static dT5fCcqqlQUJh4LTMq yP3XbSTNEWNZG8qahI()
	{
		return m0cWqyh7nSCjaTeDOu;
	}

	internal static void ywF9u7qTNn3kevjJ1l(object object_0)
	{
		((TextReader)object_0).Close();
	}
}
