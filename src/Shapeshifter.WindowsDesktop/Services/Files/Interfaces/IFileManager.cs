﻿namespace Shapeshifter.WindowsDesktop.Services.Files.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Infrastructure.Dependencies.Interfaces;

    public interface IFileManager
        : ISingleInstance,
          IDisposable
    {
        void WriteBytesToFile(
            string path,
            byte[] bytes);

        void AppendLineToFile(
            string path,
            string line);

        string WriteBytesToTemporaryFile(
            string relativePath,
            byte[] bytes);

        string AppendLineToTemporaryFile(
            string relativePath,
            string line);

        string PrepareTemporaryFolder(
            string relativePath);

        string PrepareIsolatedFolder(
            string relativePath = null);

        string PrepareNewIsolatedFolder(
            string relativePath);

        string PrepareFolder(
            string path);

        Task DeleteDirectoryIfExistsAsync(
            string path);

        Task DeleteFileIfExistsAsync(
            string path);

        Task DeleteIsolatedFileIfExistsAsync(
            string relativePath);

        Task DeleteIsolatedDirectoryIfExistsAsync(
            string relativePath);

        string FindCommonFolderFromPaths(
            IReadOnlyCollection<string> paths);
    }
}