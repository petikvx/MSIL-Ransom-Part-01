using System;
using System.Collections.Generic;
using System.Threading;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp;

internal interface ISftpSession : IDisposable, ISubsystemSession
{
	uint ProtocolVersion { get; }

	string WorkingDirectory { get; }

	void ChangeDirectory(string path);

	string GetCanonicalPath(string path);

	SftpFileAttributes RequestFStat(byte[] handle, bool nullOnError);

	SftpFileAttributes RequestStat(string path, bool nullOnError = false);

	SFtpStatAsyncResult BeginStat(string path, AsyncCallback callback, object state);

	SftpFileAttributes EndStat(SFtpStatAsyncResult asyncResult);

	SftpFileAttributes RequestLStat(string path);

	SFtpStatAsyncResult BeginLStat(string path, AsyncCallback callback, object state);

	SftpFileAttributes EndLStat(SFtpStatAsyncResult asyncResult);

	void RequestMkDir(string path);

	byte[] RequestOpen(string path, Flags flags, bool nullOnError = false);

	SftpOpenAsyncResult BeginOpen(string path, Flags flags, AsyncCallback callback, object state);

	byte[] EndOpen(SftpOpenAsyncResult asyncResult);

	byte[] RequestOpenDir(string path, bool nullOnError = false);

	void RequestPosixRename(string oldPath, string newPath);

	byte[] RequestRead(byte[] handle, ulong offset, uint length);

	SftpReadAsyncResult BeginRead(byte[] handle, ulong offset, uint length, AsyncCallback callback, object state);

	byte[] EndRead(SftpReadAsyncResult asyncResult);

	KeyValuePair<string, SftpFileAttributes>[] RequestReadDir(byte[] handle);

	SftpRealPathAsyncResult BeginRealPath(string path, AsyncCallback callback, object state);

	string EndRealPath(SftpRealPathAsyncResult asyncResult);

	void RequestRemove(string path);

	void RequestRename(string oldPath, string newPath);

	void RequestRmDir(string path);

	void RequestSetStat(string path, SftpFileAttributes attributes);

	SftpFileSytemInformation RequestStatVfs(string path, bool nullOnError = false);

	void RequestSymLink(string linkpath, string targetpath);

	void RequestFSetStat(byte[] handle, SftpFileAttributes attributes);

	void RequestWrite(byte[] handle, ulong serverOffset, byte[] data, int offset, int length, AutoResetEvent wait, Action<SftpStatusResponse> writeCompleted = null);

	void RequestClose(byte[] handle);

	SftpCloseAsyncResult BeginClose(byte[] handle, AsyncCallback callback, object state);

	void EndClose(SftpCloseAsyncResult asyncResult);

	uint CalculateOptimalReadLength(uint bufferSize);

	uint CalculateOptimalWriteLength(uint bufferSize, byte[] handle);

	ISftpFileReader CreateFileReader(byte[] handle, ISftpSession sftpSession, uint chunkSize, int maxPendingReads, long? fileSize);
}
