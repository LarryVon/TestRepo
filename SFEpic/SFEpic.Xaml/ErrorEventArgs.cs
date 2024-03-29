﻿//-----------------------------------------------------------------------
// <copyright file="ErrorEventArgs.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>Contains information about the error that</summary>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Xaml
{
    /// <summary>
    /// Contains information about the error that
    /// has occurred.
    /// </summary>
    public class ErrorEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the Exception object for the error
        /// that occurred.
        /// </summary>
        public Exception Error { get; internal set; }
    }
}