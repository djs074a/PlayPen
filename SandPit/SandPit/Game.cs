
namespace SandPit
{
    class Game
    {
        private int score;
        private int[] rolls = new int[21];
        private int currentRoll = 0;
        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int score = 0;
            int rollCount = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (isStrike(rollCount))
                {
                    score += scoreStrike(rollCount);
                    rollCount += 1;
                }
                else if (isSpare(rollCount))
                {
                    score += scoreSpare(rollCount);
                    rollCount += 2;
                }
                else
                {
                    score += scoreFrame(rollCount);
                    rollCount += 2;
                }
            }
            return score;
        }

        private int scoreFrame(int rollCount)
        {
            return rolls[rollCount] + rolls[rollCount + 1];
        }

        private int scoreSpare(int rollCount)
        {
            return 10 + rolls[rollCount + 2];
        }

        private int scoreStrike(int rollCount)
        {
            return 10 + rolls[rollCount + 1] + rolls[rollCount + 2];
        }

        private bool isStrike(int rollCount)
        {
            return rolls[rollCount] == 10;
        }

        private bool isSpare(int rollCount)
        {
            return rolls[rollCount] + rolls[rollCount + 1] == 10;
        }
    }
}
