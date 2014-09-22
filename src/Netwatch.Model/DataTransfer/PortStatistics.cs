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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficStats.Model.Entities;

namespace TrafficStats.Model.DataTransfer
{
    public class PortStatistics
    {
        public SnmpTarget SnmpTarget { get; set; }

        public MonitoredPort MonitoredPort { get; set; }

        public long InboundTraffic { get; set; }

        public long OutboundTraffic { get; set; }

        public string EstimatedSpeed { get; set; }

        public string Comment { get; set; }
    }
}