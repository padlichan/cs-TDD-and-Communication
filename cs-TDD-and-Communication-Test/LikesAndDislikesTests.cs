using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs_TDD_and_Communication;
using FluentAssertions;

namespace cs_TDD_and_Communication_Test
{
    public class LikesAndDislikesTests
    {
        //single input tests
        [Test]
        [TestCase(new Reactions[] {Reactions.LIKE}, Reactions.LIKE)]
        [TestCase(new Reactions[] { Reactions.DISLIKE }, Reactions.DISLIKE)]
        [TestCase(new Reactions[] { Reactions.NEUTRAL }, Reactions.NEUTRAL)]        //n.b. shouldn't be able to input this
        [TestCase(new Reactions[] {}, Reactions.NEUTRAL)]

        public void TestReaction(Reactions[] inputReactions, Reactions expectedResult )
        {
            expectedResult.Should().Be( LikesAndDislikes.CalculateReaction(inputReactions) );
        }

        //multiple input tests
        [Test]
        [TestCase(new Reactions[] { Reactions.LIKE, Reactions.LIKE }, Reactions.NEUTRAL)]
        [TestCase(new Reactions[] { Reactions.DISLIKE, Reactions.DISLIKE }, Reactions.NEUTRAL)]
        [TestCase(new Reactions[] { Reactions.LIKE, Reactions.DISLIKE }, Reactions.NEUTRAL)]
        [TestCase(new Reactions[] { Reactions.LIKE, Reactions.LIKE, Reactions.LIKE }, Reactions.LIKE, TestName = "three likes")]
        [TestCase(new Reactions[] { Reactions.DISLIKE, Reactions.DISLIKE, Reactions.DISLIKE }, Reactions.DISLIKE)]
        [TestCase(new Reactions[] { Reactions.LIKE, Reactions.LIKE, Reactions.DISLIKE }, Reactions.DISLIKE)]
        [TestCase(new Reactions[] { Reactions.LIKE, Reactions.DISLIKE, Reactions.DISLIKE }, Reactions.LIKE)]

        public void TestMultipleReactions(Reactions[] inputReactions, Reactions expectedResult)
        {
            expectedResult.Should().Be(LikesAndDislikes.CalculateReaction(inputReactions));
        }


        //edge cases
    }
}
