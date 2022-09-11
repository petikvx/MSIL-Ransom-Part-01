using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PreEmptive.Analytics.Common;

public interface IOfflineStorageManager : IDisposable
{
	void MoveFile(string origin, string destination);

	IEnumerable<string> GetFilesEndingWith(string suffix, [Optional] string contains);

	void DeleteFile(string filename);

	void WriteToFile(string filename, string text);

	string ReadFile(string filename);
}
