using Xunit;

namespace MasterMind {
    public class FuncTest {
        [Fact]
        public void checkIfEqualTest() {
            var program = new Program();
            Assert.True(program.checkIfEqual(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 }));
        }

        [Fact]
        public void checkIfEqualNotEqualTest() {
            var program = new Program();
            Assert.False(program.checkIfEqual(new int[] { 1, 0, 0, 0 }, new int[] { 0, 0, 0, 0 }));
        }

        [Fact]
        public void giveFeedbackTest() {
            var program = new Program();
            Assert.Equal(new int[] { 0, 2, 2, 2 }, program.giveFeedback(new int[] { 0, 0, 0, 0 }, new int[] { 1, 0, 0, 0 }));
        }
        [Fact]
        public void giveFeedbackTest2() {
            var program = new Program();
            Assert.Equal(new int[] { 1, 2, 1, 0 }, program.giveFeedback(new int[] { 1, 2, 3, 4 }, new int[] { 3, 2, 1, 0 }));
        }
        [Fact]
        public void giveFeedbackTest3() {
            var program = new Program();
            Assert.Equal(new int[] { 0, 0, 0, 0 }, program.giveFeedback(new int[] { 1, 2, 3, 4 }, new int[] { 0, 0, 0, 0 }));
        }
        [Fact]
        public void giveFeedbackTest4() {
            var program = new Program();
            Assert.Equal(new int[] { 2, 2, 2, 2 }, program.giveFeedback(new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }));
        }
    }
}