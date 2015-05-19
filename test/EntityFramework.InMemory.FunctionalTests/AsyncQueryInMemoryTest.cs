// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.Data.Entity.FunctionalTests;

namespace Microsoft.Data.Entity.InMemory.FunctionalTests
{
    public class AsyncQueryInMemoryTest : AsyncQueryTestBase<NorthwindQueryInMemoryFixture>
    {
        public AsyncQueryInMemoryTest(NorthwindQueryInMemoryFixture fixture)
            : base(fixture)
        {
        }

        public override Task GroupBy_with_two_part_key()
        {
            return base.GroupBy_with_two_part_key();
        }
    }
}
