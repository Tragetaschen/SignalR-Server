// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Extensions.Internal;

namespace Microsoft.Extensions.DependencyInjection
{
    public class SignalRServicesBuilder
    {
        private readonly IServiceCollection _serviceCollection;

        public SignalRServicesBuilder([NotNull] IServiceCollection serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }

        public virtual IServiceCollection ServiceCollection
        {
            get { return _serviceCollection; }
        }
    }
}