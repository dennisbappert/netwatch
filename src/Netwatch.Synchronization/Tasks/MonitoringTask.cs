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

using FluentScheduler;
using Microsoft.Practices.Unity;
using Netwatch.ServiceLayer.Contracts;

namespace Netwatch.Synchronization.Tasks
{
    internal class MonitoringTask : ITask
    {
        private readonly IUnityContainer _container;

        public MonitoringTask(
            IUnityContainer container
            )
        {
            _container = container;
        }

        public void Execute()
        {
            using (var child = _container.CreateChildContainer())
            {
                var monitor = child.Resolve<IDeviceMonitorService>();
                monitor.ExecuteDeviceMonitoring().Wait();
            }
        }
    }
}