﻿// <copyright file="AnonymousAuthenticator.cs" company="Zhaoquan Huang">
// Copyright (c) Zhaoquan Huang. All rights reserved
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace Zhaobang.FtpServer.Authenticate
{
    /// <summary>
    /// A simple authenticator that only allows anonymous authenticator
    /// </summary>
    public class AnonymousAuthenticator : IAuthenticator
    {
        /// <summary>
        /// Returns true
        /// </summary>
        /// <param name="userName">The user name user inputted</param>
        /// <param name="password">The password user inputted</param>
        /// <returns>True</returns>
        public bool Authenticate(string userName, string password)
        {
            return userName.ToUpper() == "ANONYMOUS";
        }
    }
}
