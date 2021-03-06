#region Copyright (C) 2014 Netwatch

// Copyright (C) 2014 Netwatch
// https://github.com/flumbee/netwatch

// This file is part of Netwatch

// Applified.NET is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.

// You should have received a copy of the GNU Affero General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

#endregion

using System.Collections.Generic;
using System.Web;

namespace Netwatch.Web.Common
{
    public static class Client
    {
        private static readonly List<string> AdminIps = new List<string>
        {
            //"134.93.50.212",
            "192.168.0.102",
            "127.0.0.1"
        };

        public static bool IsAdmin()
        {
            var context = HttpContext.Current;
            var remoteIp = context.Request.UserHostAddress;

            return AdminIps.Contains(remoteIp);
        }
    }
}