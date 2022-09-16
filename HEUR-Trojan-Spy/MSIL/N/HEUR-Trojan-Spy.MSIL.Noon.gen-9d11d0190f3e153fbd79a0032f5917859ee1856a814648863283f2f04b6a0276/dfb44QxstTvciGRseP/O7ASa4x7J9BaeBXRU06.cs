using System;
using System.Collections.Generic;
using System.IO;

namespace dfb44QxstTvciGRseP;

internal class O7ASa4x7J9BaeBXRU06 : cINrIVxf2BcU6UCYMo3
{
	private static O7ASa4x7J9BaeBXRU06 mX94PGZoxVdXVSXC4xb;

	public O7ASa4x7J9BaeBXRU06(ICollection<iYU0STxvGcMmvnWTbLh<oPMer26JhO73WAJG4a>> icollection_0, C1NbKbx1dJvOTKX6UO4 c1NbKbx1dJvOTKX6UO4_0)
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		base._002Ector(icollection_0, c1NbKbx1dJvOTKX6UO4_0);
	}

	public override void Gr4FoXLNIK(string string_0)
	{
		StreamWriter streamWriter = new StreamWriter(File.Open((string)T2Gb0kZjYGJTiFQCW6Q(string_0, "\\Summary.txt"), FileMode.Create));
		streamWriter.WriteLine("Analysis summary: {0}", DateTime.Now);
		int num = 0;
		if (!VVjaRXZditYdDWy7YdG())
		{
			int num2 = default(int);
			num = num2;
		}
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				do
				{
					JfrecmZE1fFy2gSDRxY(streamWriter, "No of groups: {0}", HRuM9LWGmi.Count);
					streamWriter.WriteLine();
					streamWriter.WriteLine("Grouping details");
					num = 1;
				}
				while (MLIJRHZpRrQ9p6MW7SB() != null);
				break;
			case 1:
				streamWriter.WriteLine("----------------------------------------------------------------");
				foreach (iYU0STxvGcMmvnWTbLh<oPMer26JhO73WAJG4a> item in HRuM9LWGmi)
				{
					streamWriter.WriteLine("Following message occurs {0} times", muFqcZZwH7B1gZvu1Os(item.AuYMuVTa12()));
					streamWriter.WriteLine();
					int num3 = 0;
					if (!VVjaRXZditYdDWy7YdG())
					{
						num3 = num4;
					}
					switch (num3)
					{
					}
					streamWriter.WriteLine(item.q9FMTnYdBd());
					streamWriter.WriteLine("############################################################################");
				}
				streamWriter.Close();
				return;
			}
		}
	}

	internal static object T2Gb0kZjYGJTiFQCW6Q(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static void JfrecmZE1fFy2gSDRxY(object object_0, object object_1, object object_2)
	{
		((TextWriter)object_0).WriteLine((string)object_1, object_2);
	}

	internal static int muFqcZZwH7B1gZvu1Os(object object_0)
	{
		return ((List<oPMer26JhO73WAJG4a>)object_0).Count;
	}

	internal static bool VVjaRXZditYdDWy7YdG()
	{
		return mX94PGZoxVdXVSXC4xb == null;
	}

	internal static O7ASa4x7J9BaeBXRU06 MLIJRHZpRrQ9p6MW7SB()
	{
		return mX94PGZoxVdXVSXC4xb;
	}
}
