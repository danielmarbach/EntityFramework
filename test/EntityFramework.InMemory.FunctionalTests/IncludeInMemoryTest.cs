// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Data.Entity.FunctionalTests;

namespace Microsoft.Data.Entity.InMemory.FunctionalTests
{
    public class IncludeInMemoryTest : IncludeTestBase<NorthwindQueryInMemoryFixture>
    {
        public IncludeInMemoryTest(NorthwindQueryInMemoryFixture fixture)
            : base(fixture)
        {
        }

        public override void Include_references_then_include_collection_multi_level_predicate()
        {
            base.Include_references_then_include_collection_multi_level_predicate();
        }

        public override void Include_collection_on_additional_from_clause2()
        {
            base.Include_collection_on_additional_from_clause2();
        }
    }
}
