using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace dfb44QxstTvciGRseP;

internal class cJDeblxhRrLgUVplWqA
{
	private readonly string YEwMeqNyRp;

	private readonly object cscMGl5jWu;

	private readonly C1NbKbx1dJvOTKX6UO4 pPjMFUiADC;

	internal static cJDeblxhRrLgUVplWqA mU6AQGZNZvUtN9LIrYH;

	public cJDeblxhRrLgUVplWqA(string string_0, object object_0)
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		base._002Ector();
		YEwMeqNyRp = string_0;
		cscMGl5jWu = object_0;
		pPjMFUiADC = new C1NbKbx1dJvOTKX6UO4("Group", ".csv");
		if (!Directory.Exists(YEwMeqNyRp))
		{
			throw new Exception("Need an existing directory");
		}
	}

	public void uqFMrtTewb(List<iYU0STxvGcMmvnWTbLh<oPMer26JhO73WAJG4a>> list_0)
	{
		list_0.Sort(rjqMlnMbHH);
		bHmMJThJW4(list_0);
		QjcMcVFU3d(list_0);
	}

	private void QjcMcVFU3d(List<iYU0STxvGcMmvnWTbLh<oPMer26JhO73WAJG4a>> list_0)
	{
		list_0.ForEach(delegate(iYU0STxvGcMmvnWTbLh<oPMer26JhO73WAJG4a> iYU0STxvGcMmvnWTbLh_0)
		{
			UIuM7vu1G6(iYU0STxvGcMmvnWTbLh_0);
		});
	}

	private void UIuM7vu1G6(iYU0STxvGcMmvnWTbLh<oPMer26JhO73WAJG4a> iYU0STxvGcMmvnWTbLh_0)
	{
		StreamWriter streamWriter = new StreamWriter(File.Open(YEwMeqNyRp + "\\" + pPjMFUiADC.bXHMDV0kIg(), FileMode.Create));
		foreach (oPMer26JhO73WAJG4a item in iYU0STxvGcMmvnWTbLh_0.AuYMuVTa12())
		{
			streamWriter.WriteLine(XupMHEM8oX(item));
		}
		streamWriter.Close();
	}

	private string XupMHEM8oX(oPMer26JhO73WAJG4a oPMer26JhO73WAJG4a_0)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return $"{PJpIW7ZMKYbOTE0hUtK(oPMer26JhO73WAJG4a_0)},{string.Empty},{oPMer26JhO73WAJG4a_0.Type},{oPMer26JhO73WAJG4a_0.User},{string.Empty},{oPMer26JhO73WAJG4a_0.Source},{oPMer26JhO73WAJG4a_0.EventId},\"{N66MtLvobK(oPMer26JhO73WAJG4a_0)}\",{string.Empty},{w9XwVjZ6MnvWyBE3a8i(oPMer26JhO73WAJG4a_0)}";
	}

	private string N66MtLvobK(oPMer26JhO73WAJG4a oPMer26JhO73WAJG4a_0)
	{
		return ((string)FAoLS2Z54SJotthq3ba(oPMer26JhO73WAJG4a_0)).Replace("\"", "\"\"");
	}

	private int rjqMlnMbHH(iYU0STxvGcMmvnWTbLh<oPMer26JhO73WAJG4a> iYU0STxvGcMmvnWTbLh_0, iYU0STxvGcMmvnWTbLh<oPMer26JhO73WAJG4a> iYU0STxvGcMmvnWTbLh_1)
	{
		return iYU0STxvGcMmvnWTbLh_1.AuYMuVTa12().Count.CompareTo(iYU0STxvGcMmvnWTbLh_0.AuYMuVTa12().Count);
	}

	private void bHmMJThJW4(ICollection<iYU0STxvGcMmvnWTbLh<oPMer26JhO73WAJG4a>> icollection_0)
	{
		cINrIVxf2BcU6UCYMo3 cINrIVxf2BcU6UCYMo4 = new Pmw79ZxuQeedqQP0u0A(icollection_0, new C1NbKbx1dJvOTKX6UO4("Group", ".csv"));
		cINrIVxf2BcU6UCYMo4.Gr4FoXLNIK(YEwMeqNyRp);
	}

	[CompilerGenerated]
	private void XWPMAWk7w1(iYU0STxvGcMmvnWTbLh<oPMer26JhO73WAJG4a> iYU0STxvGcMmvnWTbLh_0)
	{
		UIuM7vu1G6(iYU0STxvGcMmvnWTbLh_0);
	}

	internal static bool kmPj5AZOX31sEvXvS1o()
	{
		return mU6AQGZNZvUtN9LIrYH == null;
	}

	internal static cJDeblxhRrLgUVplWqA nTFZEwZ0A3ukcDrtwKH()
	{
		return mU6AQGZNZvUtN9LIrYH;
	}

	internal static object PJpIW7ZMKYbOTE0hUtK(object object_0)
	{
		return ((oPMer26JhO73WAJG4a)object_0).Computer;
	}

	internal static DateTime w9XwVjZ6MnvWyBE3a8i(object object_0)
	{
		return ((oPMer26JhO73WAJG4a)object_0).GeneratedTime;
	}

	internal static object FAoLS2Z54SJotthq3ba(object object_0)
	{
		return ((oPMer26JhO73WAJG4a)object_0).Message;
	}
}
