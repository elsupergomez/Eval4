﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eval4.Tests
{
    [TestClass]
    public class CSharpTests : BaseTest<CSharpEvaluator>
    {
        public class TestContext
        {
            // fields
            public byte @byte = 1;
            public sbyte @sbyte = 2;
            public short @short = 3;
            public int @int = 4;
            public uint @uint = 5;
            public long @long = 6;
            public ulong @ulong = 7;
            public float @float = 8;
            public double @double = 9;
            public decimal @decimal = 10;
        }


        public CSharpTests()
        {
            ev.SetVariable("context", new TestContext());
        }

        [TestMethod]
        public void CSharp_FieldTypes()
        {
            var context = new TestContext();
            TestFormula("context.byte", context.@byte);
            TestFormula("context.decimal", context.@decimal);
            TestFormula("context.double", context.@double);
            TestFormula("context.float", context.@float);
            TestFormula("context.int", context.@int);
            TestFormula("context.long", context.@long);
            TestFormula("context.sbyte", context.@sbyte);
            TestFormula("context.short", context.@short);
            TestFormula("context.uint", context.@uint);
            TestFormula("context.ulong", context.@ulong);
        }

        [TestMethod]
        public void CSharp_FieldCalculation()
        {
            var context = new TestContext();
            // those are returning int32 (like in C#)
            TestFormula("context.byte * 2", context.@byte * 2);
            TestFormula("context.sbyte * 2", context.@sbyte * 2);
            TestFormula("context.short * 2", context.@short * 2);
            TestFormula("context.int * 2", context.@int * 2);

            // those are return double (like in C#)
            TestFormula("context.double * 2", context.@double * 2);

            // those types are not working like C# and revert return doubles
            TestFormula("context.uint * 2", context.@uint * 2);
            TestFormula("context.long * 2", context.@long * 2);
            TestFormula("context.ulong * 2", context.@ulong * 2);
            TestFormula("context.float * 2", context.@float * 2);

            // decimal are not supported
            TestFormula("context.decimal * 2", context.@decimal * 2);

        }



        [TestMethod]
        public void CSharp_Modulo()
        {
            TestFormula("23 % 10", 3);
        }

        [TestMethod]
        public void CSharp_BitwiseAnd()
        {
            TestFormula("3 & 254", 2);
        }

        [TestMethod]
        public void CSharp_BooleanAnd()
        {
            TestFormula("false && true", false);
        }

        [TestMethod]
        public void CSharp_EqOperator()
        {
            TestFormula("1 == 2", false);
        }

        [TestMethod]
        public void CSharp_NEOperator()
        {
            TestFormula("1 != 2", true);
        }

        [TestMethod]
        public void CSharp_NotOperator()
        {
            TestFormula("! true", false);
        }

        [TestMethod]
        public void CSharp_BitwiseOr()
        {
            TestFormula("1 | 255", 255);
        }

        [TestMethod]
        public void CSharp_BooleanOr()
        {
            TestFormula("false || true", true);
        }

        [TestMethod]
        public void CSharp_If()
        {
            TestFormula("true ?  1:0", 1);
            TestFormula("false ?  1:0", 0);
        }

        [TestMethod]
        public void CSharp_Numerics()
        {
            TestFormula("1", 1);
            TestFormula("-1", -1);
            TestFormula("1e0", 1e0);
            TestFormula("1e1", 1e1);
            TestFormula("1e-10", 1e-10);
            TestFormula("1.2345e-2", 1.2345e-2);
        }

        //Accounts accountInstance = new Accounts();
        //int[] pascal = new int[] { 1, 8, 28, 56, 70, 56, 28, 8, 1 };

        //private void CSharp_InitEvaluator(IEvaluator ev)
        //{
        //    ev.SetVariable("pascal", pascal);
        //    ev.SetVariable("fibonacci", new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34 });
        //    ev.SetVariable("mult", new int[,] { { 0, 0, 0, 0 }, { 0, 1, 2, 3 }, { 0, 2, 4, 6 }, { 0, 3, 6, 9 } });
        //    ev.SetVariable("accounts", accountInstance);
        //}

        //public class Accounts
        //{
        //    public double Credit { get { return 150.00; } }
        //    public double Vat { get { return 20.0; } }
        //    public byte ByteValue { get { return 123; } }
        //    public Single SingleValue { get { return 123; } }
        //    public Decimal DecimalValue { get { return 123; } }
        //    public readonly Int16 Int16Value = 123;
        //    public double CreditWithVat()
        //    {
        //        return AddVat(Vat, Credit);
        //    }

        //    public static double AddVat(double vat, double value)
        //    {
        //        return value * ((100 + vat) / 100.0);
        //    }
        //}

        //[TestMethod]
        //public void CSharp_AccessArrayVariables()
        //{
        //    TestCSFormula("pascal", pascal);
        //    TestCSFormula("pascal[0]", 1);
        //    TestCSFormula("pascal[2]", 28);
        //    TestCSFormula("pascal[2]*2", 56);
        //    TestCSFormula("mult[1,0]", 0);
        //    TestCSFormula("mult[1,2]", 2);
        //    TestCSFormula("mult[2,3]", 6);
        //    TestCSFormula("mult[3,3]", 9);

        //    TestVBFormula("pascal(0)", 1);
        //    TestVBFormula("pascal(2)", 28);
        //    TestVBFormula("pascal(2)*2", 56);
        //    TestVBFormula("mult(1,0)", 0);
        //    TestVBFormula("mult(1,2)", 2);
        //    TestVBFormula("mult(2,3)", 6);
        //    TestVBFormula("mult(3,3)", 9);
        //}

        //[TestMethod]
        //public void CSharp_AccessObjectMethodsAndFields()
        //{
        //    TestVbAndCsFormula("accounts.Credit", 150.00);
        //    TestVbAndCsFormula("accounts.Vat", 20.00);
        //    TestVbAndCsFormula("accounts.CreditWithVat", 180.0);
        //    TestVbAndCsFormula("accounts.AddVat(20,100)", 120.0);

        //    TestVbAndCsFormula("accounts.ByteValue", (byte)123);
        //    TestVbAndCsFormula("accounts.SingleValue", (Single)123);
        //    TestVbAndCsFormula("accounts.DecimalValue", (decimal)123);
        //    TestVbAndCsFormula("accounts.Int16Value", (Int16)123);

        //    TestVbAndCsFormula("accounts.ByteValue * 1.0", 123.0);
        //    TestVbAndCsFormula("accounts.SingleValue  * 1.0", 123.0);
        //    TestVbAndCsFormula("accounts.Int16Value * 1.0", 123.0);
        //    //TestVbAndCsFormula("accounts.DecimalValue * 1.0", accountInstance.DecimalValue * 1.0);
        //    //TestVbAndCsFormula("accounts.Sum(1,2,3,4)", (decimal)10.0);
        //}
        //[TestMethod]
        //public void CSharp_NumberLiterals()
        //{
        //    TestVbAndCsFormula("1.5", 1.5);
        //    TestVbAndCsFormula("0.5", 0.5);
        //    TestVbAndCsFormula(".5", .5);
        //    TestVbAndCsFormula("-.5", -.5);
        //    TestVbAndCsFormula("-0.5", -0.5);
        //}

        //[TestMethod]
        //public void CSharp_Priorities()
        //{
        //    TestVbAndCsFormula("-1.5*-2.5", -1.5 * -2.5);
        //}

        //[TestMethod]
        //public void CSharp_Template()
        //{
        //    //   TestTemplate("<p>Hello</p>", "<p>Hello</p>");
        //}    }
        //[TestClass]
        //public class TestEnvironmentFunctions //: BaseTest
        //{
        //public TestEnvironmentFunctions()
        //{
        //    evVB.AddEnvironmentFunctions(typeof(EnvironmentFunctions));
        //}


        //[TestMethod]
        //public void CSharp_Environment()
        //{
        //    TestVBFormula("avg(2,3,5)", 10 / 3.0);
        //}
        //}

        //public static class EnvironmentFunctions
        //{
        //    public static double avg(double a, double b, double c)
        //    {
        //        return (a + b + c) / 3.0;
        //    }
        //}
    }
}
