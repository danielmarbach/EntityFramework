// Copyright(c) .NET Foundation.All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq.Expressions;
using Microsoft.Data.Entity.Query.Expressions;
using Remotion.Linq.Clauses.Expressions;
using Remotion.Linq.Parsing;

namespace Microsoft.Data.Entity.Query.ExpressionTreeVisitors
{
    public class FunctionEvaluationEnablingVisitor : ExpressionTreeVisitor
    {
        protected override Expression VisitExtensionExpression(ExtensionExpression expression)
        {
            var methodCallWrapper = expression as MethodCallWrappingExpression;
            if (methodCallWrapper != null)
            {
                return VisitExpression(methodCallWrapper.MethodCall);
            }

            var propertyWrapper = expression as PropertyWrappingExpression;
            if (propertyWrapper != null)
            {
                return VisitExpression(propertyWrapper.MemberExpression);
            }

            return base.VisitExtensionExpression(expression);
        }

        protected override Expression VisitSubQueryExpression(SubQueryExpression expression)
        {
            expression.QueryModel.TransformExpressions(VisitExpression);

            return expression;
        }
    }
}
