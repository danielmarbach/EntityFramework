//// Copyright(c) .NET Foundation.All rights reserved.
//// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

//using JetBrains.Annotations;
//using Remotion.Linq.Clauses.Expressions;
//using Remotion.Linq.Parsing;
//using System.Linq.Expressions;

//namespace Microsoft.Data.Entity.Query.Expressions
//{
//    public class PropertyWrappingExpression : ExtensionExpression
//    {
//        public virtual MemberExpression MemberExpression { get; private set; }

//        public PropertyWrappingExpression([NotNull] MemberExpression argument)
//            : base(argument.Type)
//        {
//            MemberExpression = argument;
//        }

//        public override bool CanReduce
//        {
//            get
//            {
//                return true;
//            }
//        }

//        public override Expression Reduce()
//        {
//            return MemberExpression;
//        }

//        protected override Expression VisitChildren(ExpressionTreeVisitor visitor)
//        {
//            var newExpression = visitor.VisitExpression(MemberExpression.Expression);

//            if (newExpression != MemberExpression.Expression)
//            {
//                return new PropertyWrappingExpression(
//                    Property(newExpression, MemberExpression.Member.Name));
//            }

//            return this;
//        }
//    }
//}
