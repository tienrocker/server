﻿namespace Photon.LoadBalancing.Custom.Common
{
    public class Rules
    {
        public const int MAX_USER_NUMBER = 6;
        public const int MIN_USER_NUMBER = 1;

        public const int TIME_WAIT_TO_PER_STEP = 1000; // 1s
        public const int TIME_WAIT_TO_DOWNLOAD = 10000; // 10s
        public const int TIME_WAIT_TO_START = 3000; // 3s

        public const int ROUND_1_SONG_NUMBER = 4;
        public const int ROUND_2_SONG_NUMBER = 4;
        public const int ROUND_3_SONG_NUMBER = 4;

        public const int TIME_WAIT_PER_ROUND = 20000; // 20s total
        public const int TIME_WAIT_PART_1 = 12000; // 12s - let user type
        public const int TIME_WAIT_PART_2 = 8000; // 8s - let user chose option results
    }
}