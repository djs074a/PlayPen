
namespace SandPit
{
    class Game
    {
        private int[] rolls = new int[21];
        private int _currentRoll;
        public void Roll(int pins)
        {
            rolls[_currentRoll++] = pins;
        }

        public int Score()
        {
            var score = 0;
            var rollCount = 0;
            for (var frame = 0; frame < 10; frame++)
            {
                if (IsStrike(rollCount))
                {
                    score += ScoreStrike(rollCount);
                    rollCount += 1;
                }
                else if (IsSpare(rollCount))
                {
                    score += ScoreSpare(rollCount);
                    rollCount += 2;
                }
                else
                {
                    score += ScoreFrame(rollCount);
                    rollCount += 2;
                }
            }
            return score;
        }

        private int ScoreFrame(int rollCount)
        {
            return rolls[rollCount] + rolls[rollCount + 1];
        }

        private int ScoreSpare(int rollCount)
        {
            return 10 + rolls[rollCount + 2];
        }

        private int ScoreStrike(int rollCount)
        {
            return 10 + rolls[rollCount + 1] + rolls[rollCount + 2];
        }

        private bool IsStrike(int rollCount)
        {
            return rolls[rollCount] == 10;
        }

        private bool IsSpare(int rollCount)
        {
            return rolls[rollCount] + rolls[rollCount + 1] == 10;
        }
    }
}
