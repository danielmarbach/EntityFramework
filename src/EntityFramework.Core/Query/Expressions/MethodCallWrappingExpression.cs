// Copyright(c) .NET Foundation.All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq.Expressions;
using Microsoft.Data.Entity.Utilities;
using JetBrains.Annotations;
using Remotion.Linq.Clauses.Expressions;
using Remotion.Linq.Parsing;

namespace Microsoft.Data.Entity.Query.Expressions
{
    public class MethodCallWrappingExpression : ExtensionExpression
    {
        public virtual MethodCallExpression MethodCall { get; private set; }

        public MethodCallWrappingExpression([NotNull] MethodCallExpression argument)
            : base(argument.Type)
        {
            Check.NotNull(argument, nameof(argument));

            MethodCall = argument;
        }

        public override bool CanReduce
        {
            get
            {
                return true;
            }
        }

        public override Expression Reduce()
        {
            return MethodCall;
        }

        protected override Expression VisitChildren(ExpressionTreeVisitor visitor)
        {
            var newObject = visitor.VisitExpression(MethodCall.Object);
            var newArguments = visitor.VisitAndConvert(MethodCall.Arguments, "VisitChildren");

            if (newObject != MethodCall.Object
                || newArguments != MethodCall.Arguments)
            {
                return new MethodCallWrappingExpression(
                    Call(newObject, MethodCall.Method, newArguments));
            }

            return this;
        }
    }
}
