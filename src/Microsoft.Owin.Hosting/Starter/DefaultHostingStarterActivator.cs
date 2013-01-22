// <copyright file="DefaultHostingStarterActivator.cs" company="Katana contributors">
//   Copyright 2011-2013 Katana contributors
// </copyright>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Microsoft.Owin.Hosting.Services;

namespace Microsoft.Owin.Hosting.Starter
{
    public class DefaultHostingStarterActivator : IHostingStarterActivator
    {
        private readonly IServiceProvider _services;

        public DefaultHostingStarterActivator(IServiceProvider services)
        {
            _services = services;
        }

        public IHostingStarter Activate(Type type)
        {
            object starter = ActivatorUtilities.GetServiceOrCreateInstance(_services, type);
            return (IHostingStarter)starter;
        }
    }
}
