using System;
using LivePortfolio.My;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

public class SettingsViewModel : ViewModelBase
{
	private string _VersionString;

	private string _DBVersionString;

	public string VersionString => _VersionString;

	public string DBVersionString => _DBVersionString;

	public SettingsViewModel()
	{
		PopulateSettings();
	}

	private void PopulateSettings()
	{
		DatabasePrimitives databasePrimitives = new DatabasePrimitives();
		Version version = MyWpfExtension.Application.Info.get_Version();
		_VersionString = $"{version.Major}.{version.Minor}.{version.Build}.{version.MajorRevision}.{version.MinorRevision}";
		version = null;
		_DBVersionString = Conversions.ToString(databasePrimitives.ExecuteScalar("SELECT Version FROM [Information]"));
	}
}
