using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab_exe
{
    [TestClass]
    public class MyCalcTest
    {
         [DataTestMethod]
         [DataRow(10,20,30)]
         [DataRow(25,18,43)]
         [DataRow(6,47,53)]
        public void TestDataAddMethod(double op1,double op2, double expresult)
        {
            double result=MyCalc.Add(op1,op2);
            Assert.AreEqual(expresult,result,"Add test is failed");
        }
         [DataTestMethod]
         [DataRow(10,20,10)]
         [DataRow(25,18,43)]
         [DataRow(6,47,53)]
        public void NegativeTestDataSubMethod(double op1,double op2, double expresult)
        {
            double result=MyCalc.Sub(op1,op2);
            Assert.AreNotEqual(expresult,result,"Sub test is failed");
        }
           [DataTestMethod]
           [DataRow(10,20,30)]
           [DataRow(25,18,43)]
           [DataRow(6,47,53)]
         public void NegativeTestDataMulMethod(double op1,double op2, double expresult)
        {
            double result=MyCalc.Mul(op1,op2);
            Assert.AreNotEqual(expresult,result,"Mul test is failed");
        }
        [DataTestMethod]
           [DataRow(10,20,30)]
           [DataRow(25,18,43)]
           [DataRow(6,47,53)]
         public void NegativeTestDataDivMethod(double op1,double op2, double expresult)
        {
            double result=MyCalc.Div(op1,op2);
            Assert.AreNotEqual(expresult,result,"Div test is failed");
        }
        [DataTestMethod]
           [DataRow(10,2,100)]
           [DataRow(5,3,125)]
           [DataRow(3,3,27)]
         public void TestDataPowMethod(double op1,double op2, double expresult)
        {
            double result=MyCalc.Pow(op1,op2);
            Assert.AreEqual(expresult,result,"Pow test is failed");
        }


    }
}
