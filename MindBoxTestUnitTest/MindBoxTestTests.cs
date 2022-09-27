using Xunit;
using MindBoxTest;
using System;

namespace MindBoxTestUnitTest
{
    public class MindBoxTestTests
    {
        [Fact]
        public void CircleArea()
        {
            Circle cr = new Circle(4);
            Assert.Equal(Math.PI * 16, cr.GetArea());
        }


        [Fact]
        public void TriAngleArea()
        {
            TriAngle cr = new TriAngle(4,3,5);
            Assert.Equal(6, cr.GetArea());
        }


        [Fact]
        public void TriAngleIsStraight()
        {
            TriAngle cr = new TriAngle(4, 3, 5);
            Assert.True(cr.IsStraight());
        }
    }
}