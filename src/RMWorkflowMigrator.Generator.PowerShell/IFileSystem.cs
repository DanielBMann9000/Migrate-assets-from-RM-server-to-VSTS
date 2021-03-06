﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFileSystem.cs" company="Microsoft Corporation">
//   Copyright Microsoft Corporation. All Rights Reserved. This code released under the terms of the MIT License (MIT, https://github.com/ALM-Rangers/Migrate-assets-from-RM-server-to-VSO/blob/master/License.txt). This is sample code only, do not use in production environments.
// </copyright>
// <summary>
//   Defines the IFileSystem type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Microsoft.ALMRangers.RMWorkflowMigrator.Generator.PowerShell
{
    public interface IFileSystem
    {
        void CreateDirectory(string path);

        void WriteAllText(string path, string contents);

        bool Exists(string path);
    }
}
