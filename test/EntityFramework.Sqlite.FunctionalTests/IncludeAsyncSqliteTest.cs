// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.Data.Entity.FunctionalTests;

namespace Microsoft.Data.Entity.Sqlite.FunctionalTests
{
    public class IncludeAsyncSqliteTest : IncludeAsyncTestBase<NorthwindQuerySqliteFixture>
    {
        public IncludeAsyncSqliteTest(NorthwindQuerySqliteFixture fixture)
            : base(fixture)
        {
        }

        public override Task Include_collection_then_include_collection_then_include_reference()
        {
            return base.Include_collection_then_include_collection_then_include_reference();
        }

        public override Task Include_collection_order_by_non_key()
        {
            return base.Include_collection_order_by_non_key();
        }

        public override Task Include_collection()
        {
            return base.Include_collection();
        }
    }
}
