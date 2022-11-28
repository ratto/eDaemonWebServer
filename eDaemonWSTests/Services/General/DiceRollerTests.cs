using eDaemonWS.Model.General;
using eDaemonWS.Model.General.Enum;

namespace eDaemonWS.Services.General
{
    [TestFixture]
    public class DiceRollerTests
    {
        DiceRollerService service = new DiceRollerService();
        const DiceType d4 = DiceType.d4;
        const DiceType d6 = DiceType.d6;
        const DiceType d8 = DiceType.d8;
        const DiceType d10 = DiceType.d10;
        const DiceType d12 = DiceType.d12;
        const DiceType d20 = DiceType.d20;
        const DiceType d100 = DiceType.d100;

        [Test]
        [TestCase(d4)]
        [TestCase(d6)]
        [TestCase(d8)]
        [TestCase(d10)]
        [TestCase(d12)]
        [TestCase(d20)]
        [TestCase(d100)]
        public void RollDice_RollDicesThousandTimes_GetOnlyIntResult(DiceType type)
        {
            bool actual = true;
            Dice dice = new Dice(type);

            for (int i = 0; i < 1000; i++)
            {
                var test = service.RollDice(dice, 1, 0);
                if (test.GetType() != typeof(int))
                {
                    actual = false;
                }
            }

            Assert.That(actual, Is.True);
        }

        [Test]
        [TestCase(d4)]
        [TestCase(d6)]
        [TestCase(d8)]
        [TestCase(d10)]
        [TestCase(d12)]
        [TestCase(d20)]
        [TestCase(d100)]
        public void RollDice_RollDicesThousandTimesThrownOnce_MinimumShouldBeOne(DiceType type)
        {
            bool actual = false;
            Dice dice = new Dice(type);

            for (int i = 0; i < 1000; i++)
            {
                if (service.RollDice(dice, 1, 0) == 1)
                {
                    actual = true;
                }
            }

            Assert.That(actual, Is.True);
        }

        [Test]
        [TestCase(d4)]
        [TestCase(d6)]
        [TestCase(d8)]
        [TestCase(d10)]
        [TestCase(d12)]
        [TestCase(d20)]
        [TestCase(d100)]
        public void RollDice_RollDicesThousandTimesThrownOnce_MaximumEqualsDiceFaceNumber(DiceType type)
        {
            bool actual = false;
            Dice dice = new Dice(type);

            for (int i = 0; i < 1000; i++)
            {
                if (service.RollDice(dice, 1, 0) == dice.GetFaceNumber())
                {
                    actual = true;
                }
            }

            Assert.That(actual, Is.True);
        }

        [Test]
        [TestCase(d4)]
        [TestCase(d6)]
        [TestCase(d8)]
        [TestCase(d10)]
        [TestCase(d12)]
        [TestCase(d20)]
        [TestCase(d100)]
        public void RollDice_RollDicesThousandTimesThrownOnce_ShouldNeverBeBelowZero(DiceType type)
        {
            bool actual = true;
            Dice dice = new Dice(type);

            for (int i = 0; i < 1000; i++)
            {
                if (service.RollDice(dice, 1, 0) < 1)
                {
                    actual = false;
                }
            }

            Assert.That(actual, Is.True);
        }

        [Test]
        [TestCase(d4)]
        [TestCase(d6)]
        [TestCase(d8)]
        [TestCase(d10)]
        [TestCase(d12)]
        [TestCase(d20)]
        [TestCase(d100)]
        public void RollDice_RollDicesThousandTimesThrownOnce_ShouldNeverExceedDicaFaceNumber(DiceType type)
        {
            bool actual = true;
            Dice dice = new Dice(type);

            for (int i = 0; i < 1000; i++)
            {
                if (service.RollDice(dice, 1, 0) > dice.GetFaceNumber())
                {
                    actual = false;
                }
            }

            Assert.That(actual, Is.True);
        }
    }
}
