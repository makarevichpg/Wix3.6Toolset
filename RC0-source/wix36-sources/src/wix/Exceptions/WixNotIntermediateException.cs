//-------------------------------------------------------------------------------------------------
// <copyright file="WixNotIntermediateException.cs" company="Microsoft">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
//    
//    The use and distribution terms for this software are covered by the
//    Common Public License 1.0 (http://opensource.org/licenses/cpl1.0.php)
//    which can be found in the file CPL.TXT at the root of this distribution.
//    By using this software in any fashion, you are agreeing to be bound by
//    the terms of this license.
//    
//    You must not remove this notice, or any other, from this software.
// </copyright>
// 
// <summary>
// Exception thrown when trying to create an intermediate from a source that is not an intermediate.
// </summary>
//-------------------------------------------------------------------------------------------------

namespace Microsoft.Tools.WindowsInstallerXml
{
    using System;

    /// <summary>
    /// Exception thrown when trying to create an intermediate from a source that is not an intermediate.
    /// </summary>
    [Serializable]
    public sealed class WixNotIntermediateException : WixException
    {
        /// <summary>
        /// Instantiate a new WixNotIntermediateException.
        /// </summary>
        /// <param name="error">Localized error information.</param>
        public WixNotIntermediateException(WixErrorEventArgs error)
            : base(error)
        {
        }
    }
}
