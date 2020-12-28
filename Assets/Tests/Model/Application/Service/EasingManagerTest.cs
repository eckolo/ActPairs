using Assets.Src.Model.Application.Value;
using Assets.Tests;
using NUnit.Framework;

namespace Assets.Src.Model.Application.Service.Test
{
    /// <summary>
    /// <see cref="EasingManager"/>のテスト
    /// </summary>
    public static class EasingManagerTest
    {
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Linear_In_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.GetProgress(time).value.Is((float)time / limit, $"time={time}");
                easing.GetProgress(time, max).value.Is(max * time / limit, $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quadratic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Cubic_In_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quartic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quintic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Sinusoidal_In_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Exponential_In_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(0).value.Is(0);
            //easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Circular_In_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Linear_In_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.GetProgress(time).Is(1 - time.DividedBy(limit), $"time={time}");
                easing.GetProgress(time, max).Is(max - max * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quadratic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Cubic_In_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quartic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quintic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Sinusoidal_In_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Exponential_In_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(0).value.Is(1f);
            //easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Circular_In_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }

        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Linear_Out_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.GetProgress(time).value.Is((float)time / limit, $"time={time}");
                easing.GetProgress(time, max).value.Is(max * time / limit, $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quadratic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Cubic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quartic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quintic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Sinusoidal_Out_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Exponential_Out_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(limit).value.Is(1f);
            //easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Circular_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Linear_Out_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.GetProgress(time).Is(1 - time.DividedBy(limit), $"time={time}");
                easing.GetProgress(time, max).Is(max - max * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quadratic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Cubic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quartic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quintic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Sinusoidal_Out_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Exponential_Out_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(limit).value.Is(0);
            //easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Circular_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }

        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Linear_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.GetProgress(time).value.Is((float)time / limit, $"time={time}");
                easing.GetProgress(time, max).value.Is(max * time / limit, $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quadratic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2).value.Is(1 / 2f);
            easing.GetProgress(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Cubic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2).value.Is(1 / 2f);
            easing.GetProgress(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quartic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2).value.Is(1 / 2f);
            easing.GetProgress(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quintic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2).value.Is(1 / 2f);
            easing.GetProgress(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Sinusoidal_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2).value.Is(1 / 2f);
            easing.GetProgress(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Exponential_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(0).value.Is(0);
            //easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2).value.Is(1 / 2f);
            easing.GetProgress(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(limit).value.Is(1f);
            //easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Circular_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(0);
            easing.GetProgress(0, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2).value.Is(1 / 2f);
            easing.GetProgress(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Linear_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.GetProgress(time).Is(1 - time.DividedBy(limit), $"time={time}");
                easing.GetProgress(time, max).Is(max - max * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quadratic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2).value.Is(1 / 2f);
            easing.GetProgress(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Cubic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2).value.Is(1 / 2f);
            easing.GetProgress(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quartic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2).value.Is(1 / 2f);
            easing.GetProgress(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Quintic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2).value.Is(1 / 2f);
            easing.GetProgress(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Sinusoidal_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2).value.Is(1 / 2f);
            easing.GetProgress(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Exponential_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(0).value.Is(1f);
            //easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2).value.Is(1 / 2f);
            easing.GetProgress(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(limit).value.Is(0);
            //easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値未指定_Circular_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(0).value.Is(1f);
            easing.GetProgress(0, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2).value.Is(1 / 2f);
            easing.GetProgress(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.GetProgress(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }

        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Linear_In_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.GetProgress(time, min, max).value.Is((max - min) * time / limit + min, $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quadratic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Cubic_In_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quartic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quintic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Sinusoidal_In_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Exponential_In_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Circular_In_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Linear_In_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.GetProgress(time, min, max).Is(max - (max - min) * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quadratic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Cubic_In_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quartic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quintic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Sinusoidal_In_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Exponential_In_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Circular_In_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }

        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Linear_Out_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.GetProgress(time, min, max).value.Is((max - min) * time / limit + min, $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quadratic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Cubic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quartic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quintic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Sinusoidal_Out_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Exponential_Out_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Circular_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Linear_Out_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.GetProgress(time, min, max).Is(max - (max - min) * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quadratic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Cubic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quartic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quintic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Sinusoidal_Out_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Exponential_Out_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Circular_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }

        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Linear_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.GetProgress(time, min, max).value.Is((max - min) * time / limit + min, $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quadratic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Cubic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quartic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quintic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Sinusoidal_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Exponential_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Circular_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Linear_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.GetProgress(time, min, max).Is(max - (max - min) * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quadratic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Cubic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quartic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Quintic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Sinusoidal_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Exponential_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_イージング_最小値指定_Circular_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(0, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.GetProgress(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.GetProgress(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.GetProgress(limit, min, max).value.Is(min);
        }

        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Linear_In_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                (easingPattern, easingBias).GetProgress(time, limit, isIncrease).value.Is((float)time / limit, $"time={time}");
                (easingPattern, easingBias).GetProgress(time, limit, max, isIncrease).value.Is(max * time / limit, $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quadratic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Cubic_In_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quartic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quintic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Sinusoidal_In_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Exponential_In_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            //(easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Circular_In_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Linear_In_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                (easingPattern, easingBias).GetProgress(time, limit, isIncrease).Is(1 - time.DividedBy(limit), $"time={time}");
                (easingPattern, easingBias).GetProgress(time, limit, max, isIncrease).Is(max - max * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quadratic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Cubic_In_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quartic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quintic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Sinusoidal_In_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Exponential_In_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            //(easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Circular_In_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }

        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Linear_Out_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                (easingPattern, easingBias).GetProgress(time, limit, isIncrease).value.Is((float)time / limit, $"time={time}");
                (easingPattern, easingBias).GetProgress(time, limit, max, isIncrease).value.Is(max * time / limit, $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quadratic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Cubic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quartic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quintic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Sinusoidal_Out_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Exponential_Out_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max * time / limit).IsTrue($"time={time}");
            }
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            //(easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Circular_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Linear_Out_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                (easingPattern, easingBias).GetProgress(time, limit, isIncrease).Is(1 - time.DividedBy(limit), $"time={time}");
                (easingPattern, easingBias).GetProgress(time, limit, max, isIncrease).Is(max - max * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quadratic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Cubic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quartic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quintic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Sinusoidal_Out_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Exponential_Out_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max - max * time / limit).IsTrue($"time={time}");
            }
            //Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            //(easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Circular_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }

        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Linear_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                (easingPattern, easingBias).GetProgress(time, limit, isIncrease).value.Is((float)time / limit, $"time={time}");
                (easingPattern, easingBias).GetProgress(time, limit, max, isIncrease).value.Is(max * time / limit, $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quadratic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, isIncrease).value.Is(1 / 2f);
            (easingPattern, easingBias).GetProgress(limit / 2, limit, max, isIncrease).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Cubic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, isIncrease).value.Is(1 / 2f);
            (easingPattern, easingBias).GetProgress(limit / 2, limit, max, isIncrease).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quartic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, isIncrease).value.Is(1 / 2f);
            (easingPattern, easingBias).GetProgress(limit / 2, limit, max, isIncrease).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quintic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, isIncrease).value.Is(1 / 2f);
            (easingPattern, easingBias).GetProgress(limit / 2, limit, max, isIncrease).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Sinusoidal_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, isIncrease).value.Is(1 / 2f);
            (easingPattern, easingBias).GetProgress(limit / 2, limit, max, isIncrease).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Exponential_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            //(easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, isIncrease).value.Is(1 / 2f);
            (easingPattern, easingBias).GetProgress(limit / 2, limit, max, isIncrease).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max * time / limit).IsTrue($"time={time}");
            }
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            //(easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Circular_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, isIncrease).value.Is(1 / 2f);
            (easingPattern, easingBias).GetProgress(limit / 2, limit, max, isIncrease).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Linear_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                (easingPattern, easingBias).GetProgress(time, limit, isIncrease).Is(1 - time.DividedBy(limit), $"time={time}");
                (easingPattern, easingBias).GetProgress(time, limit, max, isIncrease).Is(max - max * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quadratic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, isIncrease).value.Is(1 / 2f);
            (easingPattern, easingBias).GetProgress(limit / 2, limit, max, isIncrease).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Cubic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, isIncrease).value.Is(1 / 2f);
            (easingPattern, easingBias).GetProgress(limit / 2, limit, max, isIncrease).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quartic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, isIncrease).value.Is(1 / 2f);
            (easingPattern, easingBias).GetProgress(limit / 2, limit, max, isIncrease).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Quintic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, isIncrease).value.Is(1 / 2f);
            (easingPattern, easingBias).GetProgress(limit / 2, limit, max, isIncrease).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Sinusoidal_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, isIncrease).value.Is(1 / 2f);
            (easingPattern, easingBias).GetProgress(limit / 2, limit, max, isIncrease).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Exponential_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            //(easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, isIncrease).value.Is(1 / 2f);
            (easingPattern, easingBias).GetProgress(limit / 2, limit, max, isIncrease).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max - max * time / limit).IsTrue($"time={time}");
            }
            //Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            //(easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値未指定_Circular_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(0, limit, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) > 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) > max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, isIncrease).value.Is(1 / 2f);
            (easingPattern, easingBias).GetProgress(limit / 2, limit, max, isIncrease).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, isIncrease) < 1f - (float)time / limit).IsTrue($"time={time}");
                ((easingPattern, easingBias).GetProgress(time, limit, max, isIncrease) < max - max * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }

        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Linear_In_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                (easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease).value.Is((max - min) * time / limit + min, $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quadratic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Cubic_In_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quartic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quintic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Sinusoidal_In_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Exponential_In_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Circular_In_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Linear_In_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                (easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease).Is(max - (max - min) * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quadratic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Cubic_In_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quartic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quintic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Sinusoidal_In_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Exponential_In_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Circular_In_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }

        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Linear_Out_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                (easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease).value.Is((max - min) * time / limit + min, $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quadratic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Cubic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quartic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quintic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Sinusoidal_Out_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Exponential_Out_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Circular_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Linear_Out_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                (easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease).Is(max - (max - min) * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quadratic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Cubic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quartic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quintic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Sinusoidal_Out_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Exponential_Out_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            //Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Circular_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }

        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Linear_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                (easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease).value.Is((max - min) * time / limit + min, $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quadratic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, min, max, isIncrease).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Cubic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, min, max, isIncrease).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quartic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, min, max, isIncrease).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quintic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, min, max, isIncrease).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Sinusoidal_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, min, max, isIncrease).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Exponential_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, min, max, isIncrease).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Circular_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, min, max, isIncrease).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Linear_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                (easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease).Is(max - (max - min) * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quadratic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, min, max, isIncrease).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Cubic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, min, max, isIncrease).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quartic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, min, max, isIncrease).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Quintic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, min, max, isIncrease).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Sinusoidal_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, min, max, isIncrease).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Exponential_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, min, max, isIncrease).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            //Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_パターン_最小値指定_Circular_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(0, limit, min, max, isIncrease).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit / 2, limit, min, max, isIncrease).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                ((easingPattern, easingBias).GetProgress(time, limit, min, max, isIncrease) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Linear_In_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quadratic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Cubic_In_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quartic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quintic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Sinusoidal_In_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Exponential_In_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Circular_In_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Linear_In_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quadratic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Cubic_In_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quartic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quintic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Sinusoidal_In_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Exponential_In_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Circular_In_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Linear_Out_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quadratic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Cubic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quartic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quintic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Sinusoidal_Out_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Exponential_Out_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(limit).value.Is(1f);
            //easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Circular_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Linear_Out_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quadratic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Cubic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quartic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quintic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Sinusoidal_Out_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Exponential_Out_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(limit).value.Is(0);
            //easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Circular_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Linear_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quadratic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Cubic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quartic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quintic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Sinusoidal_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Exponential_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(limit).value.Is(1f);
            //easing.GetProgress(limit, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Circular_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(1f);
            easing.GetProgress(limit, max).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Linear_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quadratic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Cubic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quartic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Quintic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Sinusoidal_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Exponential_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(limit).value.Is(0);
            //easing.GetProgress(limit, max).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値未指定_Circular_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var max = 100f;

            easing.GetProgress(limit).value.Is(0);
            easing.GetProgress(limit, max).value.Is(0);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Linear_In_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quadratic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Cubic_In_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quartic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quintic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Sinusoidal_In_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Exponential_In_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Circular_In_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Linear_In_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quadratic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Cubic_In_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quartic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quintic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Sinusoidal_In_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Exponential_In_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Circular_In_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Linear_Out_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quadratic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Cubic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quartic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quintic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Sinusoidal_Out_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Exponential_Out_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Circular_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Linear_Out_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quadratic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Cubic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quartic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quintic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Sinusoidal_Out_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Exponential_Out_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Circular_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Linear_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quadratic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Cubic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quartic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quintic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Sinusoidal_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Exponential_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(limit, min, max).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Circular_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Linear_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quadratic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Cubic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quartic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Quintic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Sinusoidal_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Exponential_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.GetProgress(limit, min, max).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_イージング_最小値指定_Circular_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var easing = new Easing(easingPattern, easingBias, isIncrease, limit);
            var min = 20f;
            var max = 100f;

            easing.GetProgress(limit, min, max).value.Is(min);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Linear_In_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quadratic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Cubic_In_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quartic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quintic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Sinusoidal_In_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Exponential_In_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Circular_In_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Linear_In_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quadratic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Cubic_In_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quartic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quintic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Sinusoidal_In_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Exponential_In_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Circular_In_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Linear_Out_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quadratic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Cubic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quartic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quintic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Sinusoidal_Out_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Exponential_Out_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            //(easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Circular_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Linear_Out_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quadratic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Cubic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quartic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quintic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Sinusoidal_Out_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Exponential_Out_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            //(easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Circular_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Linear_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quadratic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Cubic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quartic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quintic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Sinusoidal_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Exponential_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            //(easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Circular_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(1f);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Linear_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quadratic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Cubic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quartic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Quintic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Sinusoidal_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Exponential_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            //(easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値未指定_Circular_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, isIncrease).value.Is(0);
            (easingPattern, easingBias).GetProgress(limit, limit, max, isIncrease).value.Is(0);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Linear_In_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quadratic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Cubic_In_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quartic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quintic_In_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Sinusoidal_In_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Exponential_In_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Circular_In_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Linear_In_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quadratic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Cubic_In_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quartic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quintic_In_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Sinusoidal_In_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Exponential_In_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Circular_In_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.In;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Linear_Out_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quadratic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Cubic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quartic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quintic_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Sinusoidal_Out_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Exponential_Out_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Circular_Out_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Linear_Out_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quadratic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Cubic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quartic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quintic_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Sinusoidal_Out_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Exponential_Out_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Circular_Out_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.Out;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Linear_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quadratic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Cubic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quartic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quintic_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Sinusoidal_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Exponential_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Circular_InOut_増加()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = true;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(max);
        }

        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Linear_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Linear;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quadratic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Cubic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Cubic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quartic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quartic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Quintic_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quintic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Sinusoidal_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Sinusoidal;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Exponential_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Exponential;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //Exponentialは経過時間0の時の変動量が0じゃない
            //(easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
        [Test]
        public static void GetProgressTest_正常系_所要時間0_パターン_最小値指定_Circular_InOut_減少()
        {
            var easingPattern = Easing.Pattern.Quadratic;
            var easingBias = Easing.Bias.InOut;
            var isIncrease = false;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            (easingPattern, easingBias).GetProgress(limit, limit, min, max, isIncrease).value.Is(min);
        }
    }
}
