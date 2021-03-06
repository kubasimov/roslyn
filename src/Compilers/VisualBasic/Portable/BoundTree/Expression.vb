﻿' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports System.Collections.Immutable
Imports Microsoft.CodeAnalysis.PooledObjects
Imports Microsoft.CodeAnalysis.Semantics
Imports Microsoft.CodeAnalysis.VisualBasic.Symbols

Namespace Microsoft.CodeAnalysis.VisualBasic
    Friend Partial Class BoundBadExpression
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return StaticCast(Of BoundNode).From(Me.ChildBoundNodes)
            End Get
        End Property
    End Class

    Partial Friend Class BoundDelegateCreationExpression
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return ImmutableArray.Create(Of BoundNode)(Me.ReceiverOpt)
            End Get
        End Property
    End Class

    Friend Partial Class BoundNullableIsTrueOperator
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return ImmutableArray.Create(Of BoundNode)(Me.Operand)
            End Get
        End Property
    End Class

    Partial Friend Class BoundAttribute
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return StaticCast(Of BoundNode).From(Me.ConstructorArguments.AddRange(Me.NamedArguments))
            End Get
        End Property
    End Class

    Friend Partial Class BoundLateInvocation
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return StaticCast(Of BoundNode).From(Me.ArgumentsOpt.Insert(0, Me.Member))
            End Get
        End Property
    End Class

    Friend Partial Class BoundLateAddressOfOperator
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return ImmutableArray.Create(Of BoundNode)(Me.MemberAccess)
            End Get
        End Property
    End Class

    Friend Partial Class BoundNoPiaObjectCreationExpression
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return If(InitializerOpt IsNot Nothing, StaticCast(Of BoundNode).From(InitializerOpt.Initializers), ImmutableArray(Of BoundNode).Empty)
            End Get
        End Property
    End Class

    Friend Partial Class BoundAnonymousTypeCreationExpression
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return StaticCast(Of BoundNode).From(Me.Arguments)
            End Get
        End Property
    End Class

    Partial Friend Class BoundAnonymousTypeFieldInitializer
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return ImmutableArray.Create(Of BoundNode)(Me.Value)
            End Get
        End Property
    End Class

    Friend Partial Class BoundArrayLiteral
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return StaticCast(Of BoundNode).From(Me.Bounds.Add(Me.Initializer))
            End Get
        End Property
    End Class

    Friend Partial Class BoundQueryExpression
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return ImmutableArray.Create(Of BoundNode)(Me.LastOperator)
            End Get
        End Property
    End Class

    Friend Partial Class BoundQueryPart
        Protected MustOverride Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
    End Class

    Friend Partial Class BoundQuerySource
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return ImmutableArray.Create(Of BoundNode)(Me.Expression)
            End Get
        End Property
    End Class

    Friend Partial Class BoundToQueryableCollectionConversion
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return ImmutableArray.Create(Of BoundNode)(Me.ConversionCall)
            End Get
        End Property
    End Class

    Friend Partial Class BoundQueryableSource
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return ImmutableArray.Create(Of BoundNode)(Me.Source)
            End Get
        End Property
    End Class

    Friend Partial Class BoundQueryClause
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return ImmutableArray.Create(Of BoundNode)(Me.UnderlyingExpression)
            End Get
        End Property
    End Class

    Friend Partial Class BoundOrdering
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return ImmutableArray.Create(Of BoundNode)(Me.UnderlyingExpression)
            End Get
        End Property
    End Class

    Friend Partial Class BoundQueryLambda
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return ImmutableArray.Create(Of BoundNode)(Me.Expression)
            End Get
        End Property
    End Class

    Friend Partial Class BoundRangeVariableAssignment
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return ImmutableArray.Create(Of BoundNode)(Me.Value)
            End Get
        End Property
    End Class

    Friend Partial Class BoundAggregateClause
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return ImmutableArray.Create(Of BoundNode)(Me.CapturedGroupOpt, Me.UnderlyingExpression)
            End Get
        End Property
    End Class

    Friend Partial Class BoundGroupAggregation
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return ImmutableArray.Create(Of BoundNode)(Me.Group)
            End Get
        End Property
    End Class

    Friend Partial Class BoundMidResult
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return ImmutableArray.Create(Of BoundNode)(Me.Original, Me.Start, Me.LengthOpt, Me.Source)
            End Get
        End Property
    End Class

    Partial Friend Class BoundNameOfOperator
        Protected Overrides ReadOnly Property Children As ImmutableArray(Of BoundNode)
            Get
                Return ImmutableArray.Create(Of BoundNode)(Me.Argument)
            End Get
        End Property
    End Class
End Namespace
