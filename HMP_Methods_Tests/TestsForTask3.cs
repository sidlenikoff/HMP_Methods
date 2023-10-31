using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMP_Methods_Task3;

namespace HMP_Methods_Tests
{
    [TestClass]
    public class TestsForTask3
    {
        [TestMethod]
        public void TestCorrectParentheses()
        {
            string text = "(7+3)/(1*2)*(3*9)";
            var result =
                HMP_Methods_Task3.Program.IsCorrectParentheses(text);

            Assert.AreEqual(HMP_Methods_Task3.Program.ParenthesesCheckResults.Correct,
                result.result);
        }

        [TestMethod]
        public void TestInCorrectParentheses()
        {
            string text = "((((7+3)/(1*2)*(3*9)";
            var result =
                HMP_Methods_Task3.Program.IsCorrectParentheses(text);

            Assert.AreEqual(HMP_Methods_Task3.Program.ParenthesesCheckResults.MoreOpening,
                result.result);
            Assert.AreEqual(3, result.info);

            text = "(7+3)/(1*2)*(3*9)))))";
            result =
                HMP_Methods_Task3.Program.IsCorrectParentheses(text);

            Assert.AreEqual(HMP_Methods_Task3.Program.ParenthesesCheckResults.MoreClosing,
                result.result);
            Assert.AreEqual(17, result.info);
        }
    }
}
