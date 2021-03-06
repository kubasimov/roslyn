﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class BoundDelegateCreationExpression
    {
        protected override ImmutableArray<BoundNode> Children => ImmutableArray.Create<BoundNode>(this.Argument);
    }

    internal partial class BoundObjectCreationExpression
    {
        internal static ImmutableArray<BoundExpression> GetChildInitializers(BoundExpression objectOrCollectionInitializer)
        {
            var objectInitializerExpression = objectOrCollectionInitializer as BoundObjectInitializerExpression;
            if (objectInitializerExpression != null)
            {
                return objectInitializerExpression.Initializers;
            }

            var collectionInitializerExpresion = objectOrCollectionInitializer as BoundCollectionInitializerExpression;
            if (collectionInitializerExpresion != null)
            {
                return collectionInitializerExpresion.Initializers;
            }

            return ImmutableArray<BoundExpression>.Empty;
        }
    }

    internal sealed partial class BoundDeconstructionAssignmentOperator : BoundExpression
    {
        protected override ImmutableArray<BoundNode> Children => ImmutableArray.Create<BoundNode>(this.Left, this.Right);
    }

    internal partial class BoundBadExpression
    {
        protected override ImmutableArray<BoundNode> Children => StaticCast<BoundNode>.From(this.ChildBoundNodes);
    }

    internal partial class BoundDynamicIndexerAccess
    {
        protected override ImmutableArray<BoundNode> Children => StaticCast<BoundNode>.From(this.Arguments.Insert(0, this.ReceiverOpt));
    }

    internal partial class BoundUserDefinedConditionalLogicalOperator
    {
        protected override ImmutableArray<BoundNode> Children => ImmutableArray.Create<BoundNode>(this.Left, this.Right);
    }

    internal partial class BoundAnonymousObjectCreationExpression
    {
        protected override ImmutableArray<BoundNode> Children => StaticCast<BoundNode>.From(this.Arguments);
    }

    internal partial class BoundAttribute
    {
        protected override ImmutableArray<BoundNode> Children => StaticCast<BoundNode>.From(this.ConstructorArguments.AddRange(this.NamedArguments));
    }

    internal partial class BoundQueryClause
    {
        protected override ImmutableArray<BoundNode> Children => ImmutableArray.Create<BoundNode>(this.Value);
    }

    internal partial class BoundArgListOperator
    {
        protected override ImmutableArray<BoundNode> Children => StaticCast<BoundNode>.From(this.Arguments);
    }

    internal partial class BoundNameOfOperator
    {
        protected override ImmutableArray<BoundNode> Children => ImmutableArray.Create<BoundNode>(this.Argument);
    }

    internal partial class BoundPointerElementAccess
    {
        protected override ImmutableArray<BoundNode> Children => ImmutableArray.Create<BoundNode>(this.Expression, this.Index);
    }

    internal partial class BoundRefTypeOperator
    {
        protected override ImmutableArray<BoundNode> Children => ImmutableArray.Create<BoundNode>(this.Operand);
    }

    internal partial class BoundDynamicMemberAccess
    {
        protected override ImmutableArray<BoundNode> Children => ImmutableArray.Create<BoundNode>(this.Receiver);
    }

    internal partial class BoundMakeRefOperator
    {
        protected override ImmutableArray<BoundNode> Children => ImmutableArray.Create<BoundNode>(this.Operand);
    }

    internal partial class BoundRefValueOperator
    {
        protected override ImmutableArray<BoundNode> Children => ImmutableArray.Create<BoundNode>(this.Operand);
    }

    internal partial class BoundDynamicInvocation
    {
        protected override ImmutableArray<BoundNode> Children => StaticCast<BoundNode>.From(this.Arguments.Insert(0, this.Expression));
    }

    internal partial class BoundFixedLocalCollectionInitializer
    {
        protected override ImmutableArray<BoundNode> Children => ImmutableArray.Create<BoundNode>(this.Expression);
    }

    internal partial class BoundStackAllocArrayCreation
    {
        protected override ImmutableArray<BoundNode> Children => ImmutableArray.Create<BoundNode>(this.Count);
    }

    internal partial class BoundDynamicObjectCreationExpression
    {
        protected override ImmutableArray<BoundNode> Children => StaticCast<BoundNode>.From(this.Arguments.AddRange(BoundObjectCreationExpression.GetChildInitializers(this.InitializerExpressionOpt)));
    }

    internal partial class BoundNoPiaObjectCreationExpression
    {
        protected override ImmutableArray<BoundNode> Children => StaticCast<BoundNode>.From(BoundObjectCreationExpression.GetChildInitializers(this.InitializerExpressionOpt));
    }

    partial class BoundThrowExpression
    {
        protected override ImmutableArray<BoundNode> Children => ImmutableArray.Create<BoundNode>(this.Expression);
    }
}
