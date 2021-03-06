﻿using System;

namespace Eval4.Core
{
    public enum TokenType
    {
        Undefined,
        Eof,
        OperatorPlus,
        OperatorMinus,
        OperatorMultiply,
        OperatorDivide,
        OperatorModulo,
        OperatorNE,
        OperatorGT,
        OperatorGE,
        OperatorEQ,
        OperatorLE,
        OperatorLT,
        OperatorAnd,
        OperatorAndAlso,
        OperatorOr,
        OperatorOrElse,
        OperatorXor,
        OperatorConcat,
        OperatorIf,
        OperatorColon,
        OperatorAssign,
        OperatorNot,
        OperatorTilde,
        ValueIdentifier,
        ValueTrue,
        ValueFalse,
        ValueInteger,
        ValueDecimal,
        ValueString,
        ValueDate,
        OpenBracket,
        CloseBracket,
        Comma,
        Dot,
        OpenParenthesis,
        CloseParenthesis,
        ShiftLeft,
        ShiftRight,
        New,
        BackSlash,
        Exponent,
        ImplicitCast,
        ExplicitCast,
        Custom,
        SyntaxError,
        SemiColon,
        UnrecognisedCharacter,
        OperatorPower
    }


    public enum CastCompatibility
    {
        Undefined,
        NoLoss,
        PossibleLoss,
        SureLoss
    }

    public enum CompatibilityLevel
    {
        Identical = 5,
        Assignable = 4,
        Cast_NoLoss = 3,
        Cast_PossibleLoss = 2,
        Cast_SureLoss = 1,
        Incompatible = 0
    }

    [Flags]
    public enum EvalMemberType
    {
        Field = 1,
        Method = 2,
        Property = 4,
        All = 7
    }

    [Flags]
    public enum EvaluatorOptions
    {
        None = 0,
        CaseSensitive = 1
    }
}
