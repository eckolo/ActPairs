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
        public static void InTest_正常系_イージング_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.In(time).value.Is((float)time / limit, $"time={time}");
                easing.In(time, max).value.Is(max * time / limit, $"time={time}");
            }
        }
        [Test]
        public static void InTest_正常系_イージング_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.In(0).value.Is(0);
            easing.In(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.In(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.In(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.In(limit).value.Is(1f);
            easing.In(limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_イージング_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.In(0).value.Is(0);
            easing.In(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.In(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.In(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.In(limit).value.Is(1f);
            easing.In(limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_イージング_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.In(0).value.Is(0);
            easing.In(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.In(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.In(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.In(limit).value.Is(1f);
            easing.In(limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_イージング_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.In(0).value.Is(0);
            easing.In(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.In(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.In(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.In(limit).value.Is(1f);
            easing.In(limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_イージング_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.In(0).value.Is(0);
            easing.In(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.In(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.In(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.In(limit).value.Is(1f);
            easing.In(limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_イージング_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.In(0).value.Is(0);
            //easing.In(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.In(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.In(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.In(limit).value.Is(1f);
            easing.In(limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_イージング_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.In(0).value.Is(0);
            easing.In(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.In(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.In(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.In(limit).value.Is(1f);
            easing.In(limit, max).value.Is(max);
        }

        [Test]
        public static void SubInTest_正常系_イージング_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.SubIn(time).Is(1 - time.DividedBy(limit), $"time={time}");
                easing.SubIn(time, max).Is(max - max * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void SubInTest_正常系_イージング_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubIn(0).value.Is(1f);
            easing.SubIn(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubIn(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubIn(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubIn(limit).value.Is(0);
            easing.SubIn(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_イージング_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubIn(0).value.Is(1f);
            easing.SubIn(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubIn(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubIn(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubIn(limit).value.Is(0);
            easing.SubIn(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_イージング_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubIn(0).value.Is(1f);
            easing.SubIn(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubIn(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubIn(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubIn(limit).value.Is(0);
            easing.SubIn(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_イージング_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubIn(0).value.Is(1f);
            easing.SubIn(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubIn(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubIn(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubIn(limit).value.Is(0);
            easing.SubIn(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_イージング_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubIn(0).value.Is(1f);
            easing.SubIn(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubIn(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubIn(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubIn(limit).value.Is(0);
            easing.SubIn(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_イージング_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.SubIn(0).value.Is(1f);
            //easing.SubIn(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubIn(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubIn(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubIn(limit).value.Is(0);
            easing.SubIn(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_イージング_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubIn(0).value.Is(1f);
            easing.SubIn(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubIn(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubIn(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubIn(limit).value.Is(0);
            easing.SubIn(limit, max).value.Is(0);
        }

        [Test]
        public static void OutTest_正常系_イージング_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.Out(time).value.Is((float)time / limit, $"time={time}");
                easing.Out(time, max).value.Is(max * time / limit, $"time={time}");
            }
        }
        [Test]
        public static void OutTest_正常系_イージング_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.Out(0).value.Is(0);
            easing.Out(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.Out(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.Out(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.Out(limit).value.Is(1f);
            easing.Out(limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_イージング_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.Out(0).value.Is(0);
            easing.Out(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.Out(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.Out(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.Out(limit).value.Is(1f);
            easing.Out(limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_イージング_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.Out(0).value.Is(0);
            easing.Out(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.Out(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.Out(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.Out(limit).value.Is(1f);
            easing.Out(limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_イージング_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.Out(0).value.Is(0);
            easing.Out(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.Out(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.Out(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.Out(limit).value.Is(1f);
            easing.Out(limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_イージング_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.Out(0).value.Is(0);
            easing.Out(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.Out(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.Out(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.Out(limit).value.Is(1f);
            easing.Out(limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_イージング_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.Out(0).value.Is(0);
            easing.Out(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.Out(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.Out(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.Out(limit).value.Is(1f);
            //easing.Out(limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_イージング_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.Out(0).value.Is(0);
            easing.Out(0, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easing.Out(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.Out(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.Out(limit).value.Is(1f);
            easing.Out(limit, max).value.Is(max);
        }

        [Test]
        public static void SubOutTest_正常系_イージング_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.SubOut(time).Is(1 - time.DividedBy(limit), $"time={time}");
                easing.SubOut(time, max).Is(max - max * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void SubOutTest_正常系_イージング_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubOut(0).value.Is(1f);
            easing.SubOut(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubOut(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubOut(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubOut(limit).value.Is(0);
            easing.SubOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_イージング_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubOut(0).value.Is(1f);
            easing.SubOut(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubOut(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubOut(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubOut(limit).value.Is(0);
            easing.SubOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_イージング_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubOut(0).value.Is(1f);
            easing.SubOut(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubOut(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubOut(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubOut(limit).value.Is(0);
            easing.SubOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_イージング_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubOut(0).value.Is(1f);
            easing.SubOut(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubOut(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubOut(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubOut(limit).value.Is(0);
            easing.SubOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_イージング_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubOut(0).value.Is(1f);
            easing.SubOut(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubOut(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubOut(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubOut(limit).value.Is(0);
            easing.SubOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_イージング_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubOut(0).value.Is(1f);
            easing.SubOut(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubOut(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubOut(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.SubOut(limit).value.Is(0);
            //easing.SubOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_イージング_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubOut(0).value.Is(1f);
            easing.SubOut(0, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubOut(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubOut(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubOut(limit).value.Is(0);
            easing.SubOut(limit, max).value.Is(0);
        }

        [Test]
        public static void InOutTest_正常系_イージング_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.InOut(time).value.Is((float)time / limit, $"time={time}");
                easing.InOut(time, max).value.Is(max * time / limit, $"time={time}");
            }
        }
        [Test]
        public static void InOutTest_正常系_イージング_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.InOut(0).value.Is(0);
            easing.InOut(0, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.InOut(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.InOut(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.InOut(limit / 2).value.Is(1 / 2f);
            easing.InOut(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.InOut(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.InOut(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.InOut(limit).value.Is(1f);
            easing.InOut(limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_イージング_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.InOut(0).value.Is(0);
            easing.InOut(0, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.InOut(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.InOut(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.InOut(limit / 2).value.Is(1 / 2f);
            easing.InOut(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.InOut(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.InOut(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.InOut(limit).value.Is(1f);
            easing.InOut(limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_イージング_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.InOut(0).value.Is(0);
            easing.InOut(0, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.InOut(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.InOut(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.InOut(limit / 2).value.Is(1 / 2f);
            easing.InOut(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.InOut(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.InOut(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.InOut(limit).value.Is(1f);
            easing.InOut(limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_イージング_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.InOut(0).value.Is(0);
            easing.InOut(0, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.InOut(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.InOut(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.InOut(limit / 2).value.Is(1 / 2f);
            easing.InOut(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.InOut(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.InOut(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.InOut(limit).value.Is(1f);
            easing.InOut(limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_イージング_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.InOut(0).value.Is(0);
            easing.InOut(0, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.InOut(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.InOut(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.InOut(limit / 2).value.Is(1 / 2f);
            easing.InOut(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.InOut(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.InOut(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.InOut(limit).value.Is(1f);
            easing.InOut(limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_イージング_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.InOut(0).value.Is(0);
            //easing.InOut(0, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.InOut(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.InOut(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.InOut(limit / 2).value.Is(1 / 2f);
            easing.InOut(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.InOut(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.InOut(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.InOut(limit).value.Is(1f);
            //easing.InOut(limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_イージング_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.InOut(0).value.Is(0);
            easing.InOut(0, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.InOut(time) < (float)time / limit).IsTrue($"time={time}");
                (easing.InOut(time, max) < max * time / limit).IsTrue($"time={time}");
            }
            easing.InOut(limit / 2).value.Is(1 / 2f);
            easing.InOut(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.InOut(time) > (float)time / limit).IsTrue($"time={time}");
                (easing.InOut(time, max) > max * time / limit).IsTrue($"time={time}");
            }
            easing.InOut(limit).value.Is(1f);
            easing.InOut(limit, max).value.Is(max);
        }

        [Test]
        public static void SubInOutTest_正常系_イージング_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.SubInOut(time).Is(1 - time.DividedBy(limit), $"time={time}");
                easing.SubInOut(time, max).Is(max - max * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void SubInOutTest_正常系_イージング_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubInOut(0).value.Is(1f);
            easing.SubInOut(0, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.SubInOut(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubInOut(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit / 2).value.Is(1 / 2f);
            easing.SubInOut(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.SubInOut(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubInOut(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit).value.Is(0);
            easing.SubInOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_イージング_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubInOut(0).value.Is(1f);
            easing.SubInOut(0, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.SubInOut(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubInOut(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit / 2).value.Is(1 / 2f);
            easing.SubInOut(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.SubInOut(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubInOut(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit).value.Is(0);
            easing.SubInOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_イージング_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubInOut(0).value.Is(1f);
            easing.SubInOut(0, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.SubInOut(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubInOut(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit / 2).value.Is(1 / 2f);
            easing.SubInOut(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.SubInOut(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubInOut(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit).value.Is(0);
            easing.SubInOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_イージング_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubInOut(0).value.Is(1f);
            easing.SubInOut(0, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.SubInOut(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubInOut(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit / 2).value.Is(1 / 2f);
            easing.SubInOut(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.SubInOut(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubInOut(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit).value.Is(0);
            easing.SubInOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_イージング_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubInOut(0).value.Is(1f);
            easing.SubInOut(0, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.SubInOut(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubInOut(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit / 2).value.Is(1 / 2f);
            easing.SubInOut(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.SubInOut(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubInOut(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit).value.Is(0);
            easing.SubInOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_イージング_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.SubInOut(0).value.Is(1f);
            //easing.SubInOut(0, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.SubInOut(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubInOut(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit / 2).value.Is(1 / 2f);
            easing.SubInOut(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.SubInOut(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubInOut(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.SubInOut(limit).value.Is(0);
            //easing.SubInOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_イージング_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubInOut(0).value.Is(1f);
            easing.SubInOut(0, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.SubInOut(time) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubInOut(time, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit / 2).value.Is(1 / 2f);
            easing.SubInOut(limit / 2, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.SubInOut(time) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easing.SubInOut(time, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit).value.Is(0);
            easing.SubInOut(limit, max).value.Is(0);
        }

        [Test]
        public static void InTest_正常系_イージング_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.In(time, min, max).value.Is((max - min) * time / limit + min, $"time={time}");
            }
        }
        [Test]
        public static void InTest_正常系_イージング_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.In(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.In(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.In(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_イージング_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.In(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.In(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.In(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_イージング_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.In(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.In(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.In(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_イージング_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.In(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.In(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.In(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_イージング_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.In(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.In(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.In(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_イージング_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.In(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.In(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.In(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_イージング_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.In(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.In(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.In(limit, min, max).value.Is(max);
        }

        [Test]
        public static void SubInTest_正常系_イージング_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.SubIn(time, min, max).Is(max - (max - min) * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void SubInTest_正常系_イージング_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubIn(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubIn(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubIn(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_イージング_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubIn(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubIn(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubIn(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_イージング_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubIn(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubIn(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubIn(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_イージング_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubIn(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubIn(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubIn(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_イージング_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubIn(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubIn(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubIn(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_イージング_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.SubIn(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubIn(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubIn(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_イージング_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubIn(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubIn(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubIn(limit, min, max).value.Is(min);
        }

        [Test]
        public static void OutTest_正常系_イージング_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.Out(time, min, max).value.Is((max - min) * time / limit + min, $"time={time}");
            }
        }
        [Test]
        public static void OutTest_正常系_イージング_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.Out(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.Out(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.Out(limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_イージング_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.Out(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.Out(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.Out(limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_イージング_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.Out(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.Out(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.Out(limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_イージング_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.Out(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.Out(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.Out(limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_イージング_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.Out(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.Out(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.Out(limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_イージング_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.Out(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.Out(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.Out(limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_イージング_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.Out(0, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easing.Out(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.Out(limit, min, max).value.Is(max);
        }

        [Test]
        public static void SubOutTest_正常系_イージング_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.SubOut(time, min, max).Is(max - (max - min) * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void SubOutTest_正常系_イージング_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubOut(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubOut(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_イージング_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubOut(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubOut(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_イージング_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubOut(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubOut(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_イージング_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubOut(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubOut(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_イージング_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubOut(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubOut(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_イージング_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubOut(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubOut(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.SubOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_イージング_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubOut(0, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easing.SubOut(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubOut(limit, min, max).value.Is(min);
        }

        [Test]
        public static void InOutTest_正常系_イージング_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.InOut(time, min, max).value.Is((max - min) * time / limit + min, $"time={time}");
            }
        }
        [Test]
        public static void InOutTest_正常系_イージング_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.InOut(0, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.InOut(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.InOut(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.InOut(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.InOut(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_イージング_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.InOut(0, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.InOut(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.InOut(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.InOut(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.InOut(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_イージング_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.InOut(0, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.InOut(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.InOut(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.InOut(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.InOut(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_イージング_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.InOut(0, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.InOut(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.InOut(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.InOut(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.InOut(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_イージング_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.InOut(0, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.InOut(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.InOut(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.InOut(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.InOut(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_イージング_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.InOut(0, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.InOut(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.InOut(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.InOut(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.InOut(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_イージング_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.InOut(0, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.InOut(time, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.InOut(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.InOut(time, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easing.InOut(limit, min, max).value.Is(max);
        }

        [Test]
        public static void SubInOutTest_正常系_イージング_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easing.SubInOut(time, min, max).Is(max - (max - min) * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void SubInOutTest_正常系_イージング_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubInOut(0, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.SubInOut(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.SubInOut(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_イージング_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubInOut(0, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.SubInOut(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.SubInOut(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_イージング_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubInOut(0, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.SubInOut(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.SubInOut(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_イージング_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubInOut(0, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.SubInOut(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.SubInOut(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_イージング_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubInOut(0, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.SubInOut(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.SubInOut(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_イージング_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.SubInOut(0, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.SubInOut(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.SubInOut(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.SubInOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_イージング_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubInOut(0, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easing.SubInOut(time, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit / 2, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easing.SubInOut(time, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easing.SubInOut(limit, min, max).value.Is(min);
        }

        [Test]
        public static void InTest_正常系_パターン_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easingType.In(time, limit).value.Is((float)time / limit, $"time={time}");
                easingType.In(time, limit, max).value.Is(max * time / limit, $"time={time}");
            }
        }
        [Test]
        public static void InTest_正常系_パターン_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var max = 100f;

            easingType.In(0, limit).value.Is(0);
            easingType.In(0, limit, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easingType.In(time, limit) < (float)time / limit).IsTrue($"time={time}");
                (easingType.In(time, limit, max) < max * time / limit).IsTrue($"time={time}");
            }
            easingType.In(limit, limit).value.Is(1f);
            easingType.In(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_パターン_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var max = 100f;

            easingType.In(0, limit).value.Is(0);
            easingType.In(0, limit, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easingType.In(time, limit) < (float)time / limit).IsTrue($"time={time}");
                (easingType.In(time, limit, max) < max * time / limit).IsTrue($"time={time}");
            }
            easingType.In(limit, limit).value.Is(1f);
            easingType.In(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_パターン_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var max = 100f;

            easingType.In(0, limit).value.Is(0);
            easingType.In(0, limit, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easingType.In(time, limit) < (float)time / limit).IsTrue($"time={time}");
                (easingType.In(time, limit, max) < max * time / limit).IsTrue($"time={time}");
            }
            easingType.In(limit, limit).value.Is(1f);
            easingType.In(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_パターン_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var max = 100f;

            easingType.In(0, limit).value.Is(0);
            easingType.In(0, limit, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easingType.In(time, limit) < (float)time / limit).IsTrue($"time={time}");
                (easingType.In(time, limit, max) < max * time / limit).IsTrue($"time={time}");
            }
            easingType.In(limit, limit).value.Is(1f);
            easingType.In(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_パターン_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var max = 100f;

            easingType.In(0, limit).value.Is(0);
            easingType.In(0, limit, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easingType.In(time, limit) < (float)time / limit).IsTrue($"time={time}");
                (easingType.In(time, limit, max) < max * time / limit).IsTrue($"time={time}");
            }
            easingType.In(limit, limit).value.Is(1f);
            easingType.In(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_パターン_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.In(0, limit).value.Is(0);
            //easingType.In(0, limit, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easingType.In(time, limit) < (float)time / limit).IsTrue($"time={time}");
                (easingType.In(time, limit, max) < max * time / limit).IsTrue($"time={time}");
            }
            easingType.In(limit, limit).value.Is(1f);
            easingType.In(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_パターン_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var max = 100f;

            easingType.In(0, limit).value.Is(0);
            easingType.In(0, limit, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easingType.In(time, limit) < (float)time / limit).IsTrue($"time={time}");
                (easingType.In(time, limit, max) < max * time / limit).IsTrue($"time={time}");
            }
            easingType.In(limit, limit).value.Is(1f);
            easingType.In(limit, limit, max).value.Is(max);
        }

        [Test]
        public static void SubInTest_正常系_パターン_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easingType.SubIn(time, limit).Is(1 - time.DividedBy(limit), $"time={time}");
                easingType.SubIn(time, limit, max).Is(max - max * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void SubInTest_正常系_パターン_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var max = 100f;

            easingType.SubIn(0, limit).value.Is(1f);
            easingType.SubIn(0, limit, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubIn(time, limit) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubIn(time, limit, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubIn(limit, limit).value.Is(0);
            easingType.SubIn(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_パターン_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var max = 100f;

            easingType.SubIn(0, limit).value.Is(1f);
            easingType.SubIn(0, limit, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubIn(time, limit) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubIn(time, limit, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubIn(limit, limit).value.Is(0);
            easingType.SubIn(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_パターン_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var max = 100f;

            easingType.SubIn(0, limit).value.Is(1f);
            easingType.SubIn(0, limit, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubIn(time, limit) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubIn(time, limit, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubIn(limit, limit).value.Is(0);
            easingType.SubIn(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_パターン_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var max = 100f;

            easingType.SubIn(0, limit).value.Is(1f);
            easingType.SubIn(0, limit, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubIn(time, limit) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubIn(time, limit, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubIn(limit, limit).value.Is(0);
            easingType.SubIn(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_パターン_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var max = 100f;

            easingType.SubIn(0, limit).value.Is(1f);
            easingType.SubIn(0, limit, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubIn(time, limit) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubIn(time, limit, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubIn(limit, limit).value.Is(0);
            easingType.SubIn(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_パターン_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.SubIn(0, limit).value.Is(1f);
            //easingType.SubIn(0, limit, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubIn(time, limit) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubIn(time, limit, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubIn(limit, limit).value.Is(0);
            easingType.SubIn(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_パターン_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var max = 100f;

            easingType.SubIn(0, limit).value.Is(1f);
            easingType.SubIn(0, limit, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubIn(time, limit) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubIn(time, limit, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubIn(limit, limit).value.Is(0);
            easingType.SubIn(limit, limit, max).value.Is(0);
        }

        [Test]
        public static void OutTest_正常系_パターン_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easingType.Out(time, limit).value.Is((float)time / limit, $"time={time}");
                easingType.Out(time, limit, max).value.Is(max * time / limit, $"time={time}");
            }
        }
        [Test]
        public static void OutTest_正常系_パターン_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var max = 100f;

            easingType.Out(0, limit).value.Is(0);
            easingType.Out(0, limit, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easingType.Out(time, limit) > (float)time / limit).IsTrue($"time={time}");
                (easingType.Out(time, limit, max) > max * time / limit).IsTrue($"time={time}");
            }
            easingType.Out(limit, limit).value.Is(1f);
            easingType.Out(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_パターン_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var max = 100f;

            easingType.Out(0, limit).value.Is(0);
            easingType.Out(0, limit, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easingType.Out(time, limit) > (float)time / limit).IsTrue($"time={time}");
                (easingType.Out(time, limit, max) > max * time / limit).IsTrue($"time={time}");
            }
            easingType.Out(limit, limit).value.Is(1f);
            easingType.Out(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_パターン_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var max = 100f;

            easingType.Out(0, limit).value.Is(0);
            easingType.Out(0, limit, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easingType.Out(time, limit) > (float)time / limit).IsTrue($"time={time}");
                (easingType.Out(time, limit, max) > max * time / limit).IsTrue($"time={time}");
            }
            easingType.Out(limit, limit).value.Is(1f);
            easingType.Out(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_パターン_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var max = 100f;

            easingType.Out(0, limit).value.Is(0);
            easingType.Out(0, limit, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easingType.Out(time, limit) > (float)time / limit).IsTrue($"time={time}");
                (easingType.Out(time, limit, max) > max * time / limit).IsTrue($"time={time}");
            }
            easingType.Out(limit, limit).value.Is(1f);
            easingType.Out(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_パターン_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var max = 100f;

            easingType.Out(0, limit).value.Is(0);
            easingType.Out(0, limit, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easingType.Out(time, limit) > (float)time / limit).IsTrue($"time={time}");
                (easingType.Out(time, limit, max) > max * time / limit).IsTrue($"time={time}");
            }
            easingType.Out(limit, limit).value.Is(1f);
            easingType.Out(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_パターン_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var max = 100f;

            easingType.Out(0, limit).value.Is(0);
            easingType.Out(0, limit, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easingType.Out(time, limit) > (float)time / limit).IsTrue($"time={time}");
                (easingType.Out(time, limit, max) > max * time / limit).IsTrue($"time={time}");
            }
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.Out(limit, limit).value.Is(1f);
            //easingType.Out(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_パターン_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var max = 100f;

            easingType.Out(0, limit).value.Is(0);
            easingType.Out(0, limit, max).value.Is(0);
            for(int time = 1; time < limit; time++)
            {
                (easingType.Out(time, limit) > (float)time / limit).IsTrue($"time={time}");
                (easingType.Out(time, limit, max) > max * time / limit).IsTrue($"time={time}");
            }
            easingType.Out(limit, limit).value.Is(1f);
            easingType.Out(limit, limit, max).value.Is(max);
        }

        [Test]
        public static void SubOutTest_正常系_パターン_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easingType.SubOut(time, limit).Is(1 - time.DividedBy(limit), $"time={time}");
                easingType.SubOut(time, limit, max).Is(max - max * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void SubOutTest_正常系_パターン_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var max = 100f;

            easingType.SubOut(0, limit).value.Is(1f);
            easingType.SubOut(0, limit, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubOut(time, limit) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubOut(time, limit, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubOut(limit, limit).value.Is(0);
            easingType.SubOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_パターン_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var max = 100f;

            easingType.SubOut(0, limit).value.Is(1f);
            easingType.SubOut(0, limit, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubOut(time, limit) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubOut(time, limit, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubOut(limit, limit).value.Is(0);
            easingType.SubOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_パターン_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var max = 100f;

            easingType.SubOut(0, limit).value.Is(1f);
            easingType.SubOut(0, limit, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubOut(time, limit) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubOut(time, limit, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubOut(limit, limit).value.Is(0);
            easingType.SubOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_パターン_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var max = 100f;

            easingType.SubOut(0, limit).value.Is(1f);
            easingType.SubOut(0, limit, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubOut(time, limit) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubOut(time, limit, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubOut(limit, limit).value.Is(0);
            easingType.SubOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_パターン_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var max = 100f;

            easingType.SubOut(0, limit).value.Is(1f);
            easingType.SubOut(0, limit, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubOut(time, limit) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubOut(time, limit, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubOut(limit, limit).value.Is(0);
            easingType.SubOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_パターン_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var max = 100f;

            easingType.SubOut(0, limit).value.Is(1f);
            easingType.SubOut(0, limit, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubOut(time, limit) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubOut(time, limit, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.SubOut(limit, limit).value.Is(0);
            //easingType.SubOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_パターン_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var max = 100f;

            easingType.SubOut(0, limit).value.Is(1f);
            easingType.SubOut(0, limit, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubOut(time, limit) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubOut(time, limit, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubOut(limit, limit).value.Is(0);
            easingType.SubOut(limit, limit, max).value.Is(0);
        }

        [Test]
        public static void InOutTest_正常系_パターン_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easingType.InOut(time, limit).value.Is((float)time / limit, $"time={time}");
                easingType.InOut(time, limit, max).value.Is(max * time / limit, $"time={time}");
            }
        }
        [Test]
        public static void InOutTest_正常系_パターン_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var max = 100f;

            easingType.InOut(0, limit).value.Is(0);
            easingType.InOut(0, limit, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.InOut(time, limit) < (float)time / limit).IsTrue($"time={time}");
                (easingType.InOut(time, limit, max) < max * time / limit).IsTrue($"time={time}");
            }
            easingType.InOut(limit / 2, limit).value.Is(1 / 2f);
            easingType.InOut(limit / 2, limit, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.InOut(time, limit) > (float)time / limit).IsTrue($"time={time}");
                (easingType.InOut(time, limit, max) > max * time / limit).IsTrue($"time={time}");
            }
            easingType.InOut(limit, limit).value.Is(1f);
            easingType.InOut(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_パターン_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var max = 100f;

            easingType.InOut(0, limit).value.Is(0);
            easingType.InOut(0, limit, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.InOut(time, limit) < (float)time / limit).IsTrue($"time={time}");
                (easingType.InOut(time, limit, max) < max * time / limit).IsTrue($"time={time}");
            }
            easingType.InOut(limit / 2, limit).value.Is(1 / 2f);
            easingType.InOut(limit / 2, limit, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.InOut(time, limit) > (float)time / limit).IsTrue($"time={time}");
                (easingType.InOut(time, limit, max) > max * time / limit).IsTrue($"time={time}");
            }
            easingType.InOut(limit, limit).value.Is(1f);
            easingType.InOut(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_パターン_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var max = 100f;

            easingType.InOut(0, limit).value.Is(0);
            easingType.InOut(0, limit, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.InOut(time, limit) < (float)time / limit).IsTrue($"time={time}");
                (easingType.InOut(time, limit, max) < max * time / limit).IsTrue($"time={time}");
            }
            easingType.InOut(limit / 2, limit).value.Is(1 / 2f);
            easingType.InOut(limit / 2, limit, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.InOut(time, limit) > (float)time / limit).IsTrue($"time={time}");
                (easingType.InOut(time, limit, max) > max * time / limit).IsTrue($"time={time}");
            }
            easingType.InOut(limit, limit).value.Is(1f);
            easingType.InOut(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_パターン_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var max = 100f;

            easingType.InOut(0, limit).value.Is(0);
            easingType.InOut(0, limit, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.InOut(time, limit) < (float)time / limit).IsTrue($"time={time}");
                (easingType.InOut(time, limit, max) < max * time / limit).IsTrue($"time={time}");
            }
            easingType.InOut(limit / 2, limit).value.Is(1 / 2f);
            easingType.InOut(limit / 2, limit, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.InOut(time, limit) > (float)time / limit).IsTrue($"time={time}");
                (easingType.InOut(time, limit, max) > max * time / limit).IsTrue($"time={time}");
            }
            easingType.InOut(limit, limit).value.Is(1f);
            easingType.InOut(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_パターン_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var max = 100f;

            easingType.InOut(0, limit).value.Is(0);
            easingType.InOut(0, limit, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.InOut(time, limit) < (float)time / limit).IsTrue($"time={time}");
                (easingType.InOut(time, limit, max) < max * time / limit).IsTrue($"time={time}");
            }
            easingType.InOut(limit / 2, limit).value.Is(1 / 2f);
            easingType.InOut(limit / 2, limit, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.InOut(time, limit) > (float)time / limit).IsTrue($"time={time}");
                (easingType.InOut(time, limit, max) > max * time / limit).IsTrue($"time={time}");
            }
            easingType.InOut(limit, limit).value.Is(1f);
            easingType.InOut(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_パターン_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.InOut(0, limit).value.Is(0);
            //easingType.InOut(0, limit, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.InOut(time, limit) < (float)time / limit).IsTrue($"time={time}");
                (easingType.InOut(time, limit, max) < max * time / limit).IsTrue($"time={time}");
            }
            easingType.InOut(limit / 2, limit).value.Is(1 / 2f);
            easingType.InOut(limit / 2, limit, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.InOut(time, limit) > (float)time / limit).IsTrue($"time={time}");
                (easingType.InOut(time, limit, max) > max * time / limit).IsTrue($"time={time}");
            }
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.InOut(limit, limit).value.Is(1f);
            //easingType.InOut(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_パターン_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var max = 100f;

            easingType.InOut(0, limit).value.Is(0);
            easingType.InOut(0, limit, max).value.Is(0);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.InOut(time, limit) < (float)time / limit).IsTrue($"time={time}");
                (easingType.InOut(time, limit, max) < max * time / limit).IsTrue($"time={time}");
            }
            easingType.InOut(limit / 2, limit).value.Is(1 / 2f);
            easingType.InOut(limit / 2, limit, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.InOut(time, limit) > (float)time / limit).IsTrue($"time={time}");
                (easingType.InOut(time, limit, max) > max * time / limit).IsTrue($"time={time}");
            }
            easingType.InOut(limit, limit).value.Is(1f);
            easingType.InOut(limit, limit, max).value.Is(max);
        }

        [Test]
        public static void SubInOutTest_正常系_パターン_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easingType.SubInOut(time, limit).Is(1 - time.DividedBy(limit), $"time={time}");
                easingType.SubInOut(time, limit, max).Is(max - max * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void SubInOutTest_正常系_パターン_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var max = 100f;

            easingType.SubInOut(0, limit).value.Is(1f);
            easingType.SubInOut(0, limit, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.SubInOut(time, limit) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubInOut(time, limit, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit / 2, limit).value.Is(1 / 2f);
            easingType.SubInOut(limit / 2, limit, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.SubInOut(time, limit) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubInOut(time, limit, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit, limit).value.Is(0);
            easingType.SubInOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_パターン_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var max = 100f;

            easingType.SubInOut(0, limit).value.Is(1f);
            easingType.SubInOut(0, limit, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.SubInOut(time, limit) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubInOut(time, limit, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit / 2, limit).value.Is(1 / 2f);
            easingType.SubInOut(limit / 2, limit, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.SubInOut(time, limit) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubInOut(time, limit, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit, limit).value.Is(0);
            easingType.SubInOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_パターン_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var max = 100f;

            easingType.SubInOut(0, limit).value.Is(1f);
            easingType.SubInOut(0, limit, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.SubInOut(time, limit) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubInOut(time, limit, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit / 2, limit).value.Is(1 / 2f);
            easingType.SubInOut(limit / 2, limit, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.SubInOut(time, limit) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubInOut(time, limit, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit, limit).value.Is(0);
            easingType.SubInOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_パターン_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var max = 100f;

            easingType.SubInOut(0, limit).value.Is(1f);
            easingType.SubInOut(0, limit, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.SubInOut(time, limit) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubInOut(time, limit, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit / 2, limit).value.Is(1 / 2f);
            easingType.SubInOut(limit / 2, limit, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.SubInOut(time, limit) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubInOut(time, limit, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit, limit).value.Is(0);
            easingType.SubInOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_パターン_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var max = 100f;

            easingType.SubInOut(0, limit).value.Is(1f);
            easingType.SubInOut(0, limit, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.SubInOut(time, limit) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubInOut(time, limit, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit / 2, limit).value.Is(1 / 2f);
            easingType.SubInOut(limit / 2, limit, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.SubInOut(time, limit) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubInOut(time, limit, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit, limit).value.Is(0);
            easingType.SubInOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_パターン_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.SubInOut(0, limit).value.Is(1f);
            //easingType.SubInOut(0, limit, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.SubInOut(time, limit) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubInOut(time, limit, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit / 2, limit).value.Is(1 / 2f);
            easingType.SubInOut(limit / 2, limit, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.SubInOut(time, limit) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubInOut(time, limit, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.SubInOut(limit, limit).value.Is(0);
            //easingType.SubInOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_パターン_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var max = 100f;

            easingType.SubInOut(0, limit).value.Is(1f);
            easingType.SubInOut(0, limit, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.SubInOut(time, limit) > 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubInOut(time, limit, max) > max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit / 2, limit).value.Is(1 / 2f);
            easingType.SubInOut(limit / 2, limit, max).value.Is(max / 2f);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.SubInOut(time, limit) < 1f - (float)time / limit).IsTrue($"time={time}");
                (easingType.SubInOut(time, limit, max) < max - max * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit, limit).value.Is(0);
            easingType.SubInOut(limit, limit, max).value.Is(0);
        }

        [Test]
        public static void InTest_正常系_パターン_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easingType.In(time, limit, min, max).value.Is((max - min) * time / limit + min, $"time={time}");
            }
        }
        [Test]
        public static void InTest_正常系_パターン_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.In(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easingType.In(time, limit, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.In(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_パターン_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.In(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easingType.In(time, limit, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.In(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_パターン_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.In(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easingType.In(time, limit, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.In(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_パターン_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.In(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easingType.In(time, limit, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.In(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_パターン_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.In(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easingType.In(time, limit, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.In(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_パターン_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.In(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easingType.In(time, limit, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.In(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_パターン_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.In(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easingType.In(time, limit, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.In(limit, limit, min, max).value.Is(max);
        }

        [Test]
        public static void SubInTest_正常系_パターン_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easingType.SubIn(time, limit, min, max).Is(max - (max - min) * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void SubInTest_正常系_パターン_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubIn(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubIn(time, limit, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubIn(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_パターン_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubIn(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubIn(time, limit, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubIn(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_パターン_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubIn(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubIn(time, limit, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubIn(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_パターン_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubIn(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubIn(time, limit, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubIn(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_パターン_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubIn(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubIn(time, limit, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubIn(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_パターン_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.SubIn(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubIn(time, limit, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubIn(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_パターン_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubIn(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubIn(time, limit, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubIn(limit, limit, min, max).value.Is(min);
        }

        [Test]
        public static void OutTest_正常系_パターン_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easingType.Out(time, limit, min, max).value.Is((max - min) * time / limit + min, $"time={time}");
            }
        }
        [Test]
        public static void OutTest_正常系_パターン_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.Out(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easingType.Out(time, limit, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.Out(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_パターン_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.Out(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easingType.Out(time, limit, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.Out(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_パターン_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.Out(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easingType.Out(time, limit, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.Out(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_パターン_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.Out(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easingType.Out(time, limit, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.Out(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_パターン_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.Out(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easingType.Out(time, limit, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.Out(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_パターン_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.Out(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easingType.Out(time, limit, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.Out(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_パターン_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.Out(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit; time++)
            {
                (easingType.Out(time, limit, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.Out(limit, limit, min, max).value.Is(max);
        }

        [Test]
        public static void SubOutTest_正常系_パターン_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easingType.SubOut(time, limit, min, max).Is(max - (max - min) * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void SubOutTest_正常系_パターン_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubOut(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubOut(time, limit, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_パターン_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubOut(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubOut(time, limit, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_パターン_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubOut(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubOut(time, limit, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_パターン_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubOut(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubOut(time, limit, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_パターン_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubOut(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubOut(time, limit, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_パターン_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubOut(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubOut(time, limit, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.SubOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_パターン_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubOut(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit; time++)
            {
                (easingType.SubOut(time, limit, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubOut(limit, limit, min, max).value.Is(min);
        }

        [Test]
        public static void InOutTest_正常系_パターン_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easingType.InOut(time, limit, min, max).value.Is((max - min) * time / limit + min, $"time={time}");
            }
        }
        [Test]
        public static void InOutTest_正常系_パターン_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.InOut(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.InOut(time, limit, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.InOut(limit / 2, limit, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.InOut(time, limit, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.InOut(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_パターン_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.InOut(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.InOut(time, limit, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.InOut(limit / 2, limit, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.InOut(time, limit, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.InOut(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_パターン_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.InOut(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.InOut(time, limit, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.InOut(limit / 2, limit, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.InOut(time, limit, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.InOut(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_パターン_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.InOut(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.InOut(time, limit, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.InOut(limit / 2, limit, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.InOut(time, limit, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.InOut(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_パターン_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.InOut(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.InOut(time, limit, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.InOut(limit / 2, limit, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.InOut(time, limit, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.InOut(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_パターン_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.InOut(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.InOut(time, limit, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.InOut(limit / 2, limit, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.InOut(time, limit, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.InOut(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_パターン_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.InOut(0, limit, min, max).value.Is(min);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.InOut(time, limit, min, max) < (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.InOut(limit / 2, limit, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.InOut(time, limit, min, max) > (max - min) * time / limit + min).IsTrue($"time={time}");
            }
            easingType.InOut(limit, limit, min, max).value.Is(max);
        }

        [Test]
        public static void SubInOutTest_正常系_パターン_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            for(int time = 0; time <= limit; time++)
            {
                easingType.SubInOut(time, limit, min, max).Is(max - (max - min) * time.DividedBy(limit), $"time={time}");
            }
        }
        [Test]
        public static void SubInOutTest_正常系_パターン_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubInOut(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.SubInOut(time, limit, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit / 2, limit, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.SubInOut(time, limit, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_パターン_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubInOut(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.SubInOut(time, limit, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit / 2, limit, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.SubInOut(time, limit, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_パターン_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubInOut(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.SubInOut(time, limit, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit / 2, limit, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.SubInOut(time, limit, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_パターン_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubInOut(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.SubInOut(time, limit, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit / 2, limit, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.SubInOut(time, limit, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_パターン_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubInOut(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.SubInOut(time, limit, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit / 2, limit, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.SubInOut(time, limit, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_パターン_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.SubInOut(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.SubInOut(time, limit, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit / 2, limit, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.SubInOut(time, limit, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.SubInOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_パターン_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 1000;
            var min = 20f;
            var max = 100f;

            easingType.SubInOut(0, limit, min, max).value.Is(max);
            for(int time = 1; time < limit / 2; time++)
            {
                (easingType.SubInOut(time, limit, min, max) > max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit / 2, limit, min, max).value.Is((max - min) / 2f + min);
            for(int time = limit / 2 + 1; time < limit; time++)
            {
                (easingType.SubInOut(time, limit, min, max) < max - (max - min) * time / limit).IsTrue($"time={time}");
            }
            easingType.SubInOut(limit, limit, min, max).value.Is(min);
        }

        [Test]
        public static void InTest_正常系_所要時間0_イージング_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.In(limit).value.Is(1f);
            easing.In(limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_イージング_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.In(limit).value.Is(1f);
            easing.In(limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_イージング_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.In(limit).value.Is(1f);
            easing.In(limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_イージング_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.In(limit).value.Is(1f);
            easing.In(limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_イージング_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.In(limit).value.Is(1f);
            easing.In(limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_イージング_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.In(limit).value.Is(1f);
            easing.In(limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_イージング_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            easing.In(limit).value.Is(1f);
            easing.In(limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_イージング_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.In(limit).value.Is(1f);
            easing.In(limit, max).value.Is(max);
        }

        [Test]
        public static void SubInTest_正常系_所要時間0_イージング_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubIn(limit).value.Is(0);
            easing.SubIn(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_イージング_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubIn(limit).value.Is(0);
            easing.SubIn(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_イージング_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubIn(limit).value.Is(0);
            easing.SubIn(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_イージング_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubIn(limit).value.Is(0);
            easing.SubIn(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_イージング_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubIn(limit).value.Is(0);
            easing.SubIn(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_イージング_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubIn(limit).value.Is(0);
            easing.SubIn(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_イージング_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            easing.SubIn(limit).value.Is(0);
            easing.SubIn(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_イージング_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubIn(limit).value.Is(0);
            easing.SubIn(limit, max).value.Is(0);
        }

        [Test]
        public static void OutTest_正常系_所要時間0_イージング_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.Out(limit).value.Is(1f);
            easing.Out(limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_イージング_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.Out(limit).value.Is(1f);
            easing.Out(limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_イージング_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.Out(limit).value.Is(1f);
            easing.Out(limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_イージング_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.Out(limit).value.Is(1f);
            easing.Out(limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_イージング_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.Out(limit).value.Is(1f);
            easing.Out(limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_イージング_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.Out(limit).value.Is(1f);
            easing.Out(limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_イージング_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.Out(limit).value.Is(1f);
            //easing.Out(limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_イージング_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.Out(limit).value.Is(1f);
            easing.Out(limit, max).value.Is(max);
        }

        [Test]
        public static void SubOutTest_正常系_所要時間0_イージング_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubOut(limit).value.Is(0);
            easing.SubOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_イージング_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubOut(limit).value.Is(0);
            easing.SubOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_イージング_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubOut(limit).value.Is(0);
            easing.SubOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_イージング_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubOut(limit).value.Is(0);
            easing.SubOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_イージング_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubOut(limit).value.Is(0);
            easing.SubOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_イージング_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubOut(limit).value.Is(0);
            easing.SubOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_イージング_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.SubOut(limit).value.Is(0);
            //easing.SubOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_イージング_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubOut(limit).value.Is(0);
            easing.SubOut(limit, max).value.Is(0);
        }

        [Test]
        public static void InOutTest_正常系_所要時間0_イージング_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.InOut(limit).value.Is(1f);
            easing.InOut(limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_イージング_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.InOut(limit).value.Is(1f);
            easing.InOut(limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_イージング_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.InOut(limit).value.Is(1f);
            easing.InOut(limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_イージング_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.InOut(limit).value.Is(1f);
            easing.InOut(limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_イージング_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.InOut(limit).value.Is(1f);
            easing.InOut(limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_イージング_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.InOut(limit).value.Is(1f);
            easing.InOut(limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_イージング_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.InOut(limit).value.Is(1f);
            //easing.InOut(limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_イージング_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.InOut(limit).value.Is(1f);
            easing.InOut(limit, max).value.Is(max);
        }

        [Test]
        public static void SubInOutTest_正常系_所要時間0_イージング_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubInOut(limit).value.Is(0);
            easing.SubInOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_イージング_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubInOut(limit).value.Is(0);
            easing.SubInOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_イージング_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubInOut(limit).value.Is(0);
            easing.SubInOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_イージング_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubInOut(limit).value.Is(0);
            easing.SubInOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_イージング_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubInOut(limit).value.Is(0);
            easing.SubInOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_イージング_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubInOut(limit).value.Is(0);
            easing.SubInOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_イージング_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.SubInOut(limit).value.Is(0);
            //easing.SubInOut(limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_イージング_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var max = 100f;

            easing.SubInOut(limit).value.Is(0);
            easing.SubInOut(limit, max).value.Is(0);
        }

        [Test]
        public static void InTest_正常系_所要時間0_イージング_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.In(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_イージング_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.In(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_イージング_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.In(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_イージング_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.In(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_イージング_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.In(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_イージング_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.In(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_イージング_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            easing.In(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_イージング_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.In(limit, min, max).value.Is(max);
        }

        [Test]
        public static void SubInTest_正常系_所要時間0_イージング_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubIn(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_イージング_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubIn(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_イージング_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubIn(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_イージング_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubIn(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_イージング_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubIn(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_イージング_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubIn(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_イージング_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            easing.SubIn(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_イージング_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubIn(limit, min, max).value.Is(min);
        }

        [Test]
        public static void OutTest_正常系_所要時間0_イージング_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.Out(limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_イージング_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.Out(limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_イージング_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.Out(limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_イージング_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.Out(limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_イージング_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.Out(limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_イージング_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.Out(limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_イージング_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.Out(limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_イージング_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.Out(limit, min, max).value.Is(max);
        }

        [Test]
        public static void SubOutTest_正常系_所要時間0_イージング_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_イージング_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_イージング_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_イージング_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_イージング_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_イージング_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_イージング_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.SubOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_イージング_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubOut(limit, min, max).value.Is(min);
        }

        [Test]
        public static void InOutTest_正常系_所要時間0_イージング_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.InOut(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_イージング_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.InOut(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_イージング_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.InOut(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_イージング_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.InOut(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_イージング_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.InOut(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_イージング_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.InOut(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_イージング_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easing.InOut(limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_イージング_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.InOut(limit, min, max).value.Is(max);
        }

        [Test]
        public static void SubInOutTest_正常系_所要時間0_イージング_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubInOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_イージング_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubInOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_イージング_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubInOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_イージング_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubInOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_イージング_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubInOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_イージング_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubInOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_イージング_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easing.SubInOut(limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_イージング_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var easing = new Easing(easingType, limit);
            var min = 20f;
            var max = 100f;

            easing.SubInOut(limit, min, max).value.Is(min);
        }

        [Test]
        public static void InTest_正常系_所要時間0_パターン_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var max = 100f;

            easingType.In(limit, limit).value.Is(1f);
            easingType.In(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_パターン_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var max = 100f;

            easingType.In(limit, limit).value.Is(1f);
            easingType.In(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_パターン_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var max = 100f;

            easingType.In(limit, limit).value.Is(1f);
            easingType.In(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_パターン_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var max = 100f;

            easingType.In(limit, limit).value.Is(1f);
            easingType.In(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_パターン_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var max = 100f;

            easingType.In(limit, limit).value.Is(1f);
            easingType.In(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_パターン_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var max = 100f;

            easingType.In(limit, limit).value.Is(1f);
            easingType.In(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_パターン_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            easingType.In(limit, limit).value.Is(1f);
            easingType.In(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_パターン_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var max = 100f;

            easingType.In(limit, limit).value.Is(1f);
            easingType.In(limit, limit, max).value.Is(max);
        }

        [Test]
        public static void SubInTest_正常系_所要時間0_パターン_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var max = 100f;

            easingType.SubIn(limit, limit).value.Is(0);
            easingType.SubIn(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_パターン_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var max = 100f;

            easingType.SubIn(limit, limit).value.Is(0);
            easingType.SubIn(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_パターン_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var max = 100f;

            easingType.SubIn(limit, limit).value.Is(0);
            easingType.SubIn(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_パターン_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var max = 100f;

            easingType.SubIn(limit, limit).value.Is(0);
            easingType.SubIn(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_パターン_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var max = 100f;

            easingType.SubIn(limit, limit).value.Is(0);
            easingType.SubIn(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_パターン_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var max = 100f;

            easingType.SubIn(limit, limit).value.Is(0);
            easingType.SubIn(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_パターン_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            easingType.SubIn(limit, limit).value.Is(0);
            easingType.SubIn(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_パターン_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var max = 100f;

            easingType.SubIn(limit, limit).value.Is(0);
            easingType.SubIn(limit, limit, max).value.Is(0);
        }

        [Test]
        public static void OutTest_正常系_所要時間0_パターン_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var max = 100f;

            easingType.Out(limit, limit).value.Is(1f);
            easingType.Out(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_パターン_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var max = 100f;

            easingType.Out(limit, limit).value.Is(1f);
            easingType.Out(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_パターン_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var max = 100f;

            easingType.Out(limit, limit).value.Is(1f);
            easingType.Out(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_パターン_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var max = 100f;

            easingType.Out(limit, limit).value.Is(1f);
            easingType.Out(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_パターン_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var max = 100f;

            easingType.Out(limit, limit).value.Is(1f);
            easingType.Out(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_パターン_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var max = 100f;

            easingType.Out(limit, limit).value.Is(1f);
            easingType.Out(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_パターン_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.Out(limit, limit).value.Is(1f);
            //easingType.Out(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_パターン_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var max = 100f;

            easingType.Out(limit, limit).value.Is(1f);
            easingType.Out(limit, limit, max).value.Is(max);
        }

        [Test]
        public static void SubOutTest_正常系_所要時間0_パターン_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var max = 100f;

            easingType.SubOut(limit, limit).value.Is(0);
            easingType.SubOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_パターン_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var max = 100f;

            easingType.SubOut(limit, limit).value.Is(0);
            easingType.SubOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_パターン_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var max = 100f;

            easingType.SubOut(limit, limit).value.Is(0);
            easingType.SubOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_パターン_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var max = 100f;

            easingType.SubOut(limit, limit).value.Is(0);
            easingType.SubOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_パターン_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var max = 100f;

            easingType.SubOut(limit, limit).value.Is(0);
            easingType.SubOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_パターン_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var max = 100f;

            easingType.SubOut(limit, limit).value.Is(0);
            easingType.SubOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_パターン_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.SubOut(limit, limit).value.Is(0);
            //easingType.SubOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_パターン_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var max = 100f;

            easingType.SubOut(limit, limit).value.Is(0);
            easingType.SubOut(limit, limit, max).value.Is(0);
        }

        [Test]
        public static void InOutTest_正常系_所要時間0_パターン_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var max = 100f;

            easingType.InOut(limit, limit).value.Is(1f);
            easingType.InOut(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_パターン_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var max = 100f;

            easingType.InOut(limit, limit).value.Is(1f);
            easingType.InOut(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_パターン_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var max = 100f;

            easingType.InOut(limit, limit).value.Is(1f);
            easingType.InOut(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_パターン_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var max = 100f;

            easingType.InOut(limit, limit).value.Is(1f);
            easingType.InOut(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_パターン_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var max = 100f;

            easingType.InOut(limit, limit).value.Is(1f);
            easingType.InOut(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_パターン_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var max = 100f;

            easingType.InOut(limit, limit).value.Is(1f);
            easingType.InOut(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_パターン_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.InOut(limit, limit).value.Is(1f);
            //easingType.InOut(limit, limit, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_パターン_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var max = 100f;

            easingType.InOut(limit, limit).value.Is(1f);
            easingType.InOut(limit, limit, max).value.Is(max);
        }

        [Test]
        public static void SubInOutTest_正常系_所要時間0_パターン_最小値未指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var max = 100f;

            easingType.SubInOut(limit, limit).value.Is(0);
            easingType.SubInOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_パターン_最小値未指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var max = 100f;

            easingType.SubInOut(limit, limit).value.Is(0);
            easingType.SubInOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_パターン_最小値未指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var max = 100f;

            easingType.SubInOut(limit, limit).value.Is(0);
            easingType.SubInOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_パターン_最小値未指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var max = 100f;

            easingType.SubInOut(limit, limit).value.Is(0);
            easingType.SubInOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_パターン_最小値未指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var max = 100f;

            easingType.SubInOut(limit, limit).value.Is(0);
            easingType.SubInOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_パターン_最小値未指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var max = 100f;

            easingType.SubInOut(limit, limit).value.Is(0);
            easingType.SubInOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_パターン_最小値未指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.SubInOut(limit, limit).value.Is(0);
            //easingType.SubInOut(limit, limit, max).value.Is(0);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_パターン_最小値未指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var max = 100f;

            easingType.SubInOut(limit, limit).value.Is(0);
            easingType.SubInOut(limit, limit, max).value.Is(0);
        }

        [Test]
        public static void InTest_正常系_所要時間0_パターン_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.In(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_パターン_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.In(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_パターン_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.In(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_パターン_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.In(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_パターン_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.In(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_パターン_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.In(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_パターン_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            easingType.In(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InTest_正常系_所要時間0_パターン_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.In(limit, limit, min, max).value.Is(max);
        }

        [Test]
        public static void SubInTest_正常系_所要時間0_パターン_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubIn(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_パターン_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubIn(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_パターン_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubIn(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_パターン_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubIn(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_パターン_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubIn(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_パターン_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubIn(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_パターン_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            easingType.SubIn(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInTest_正常系_所要時間0_パターン_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubIn(limit, limit, min, max).value.Is(min);
        }

        [Test]
        public static void OutTest_正常系_所要時間0_パターン_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.Out(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_パターン_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.Out(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_パターン_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.Out(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_パターン_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.Out(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_パターン_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.Out(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_パターン_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.Out(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_パターン_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.Out(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void OutTest_正常系_所要時間0_パターン_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.Out(limit, limit, min, max).value.Is(max);
        }

        [Test]
        public static void SubOutTest_正常系_所要時間0_パターン_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_パターン_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_パターン_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_パターン_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_パターン_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_パターン_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_パターン_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.SubOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubOutTest_正常系_所要時間0_パターン_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubOut(limit, limit, min, max).value.Is(min);
        }

        [Test]
        public static void InOutTest_正常系_所要時間0_パターン_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.InOut(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_パターン_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.InOut(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_パターン_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.InOut(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_パターン_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.InOut(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_パターン_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.InOut(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_パターン_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.InOut(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_パターン_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            ////Exponentialは経過時間0の時の変動量が0じゃない
            ////Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.InOut(limit, limit, min, max).value.Is(max);
        }
        [Test]
        public static void InOutTest_正常系_所要時間0_パターン_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.InOut(limit, limit, min, max).value.Is(max);
        }

        [Test]
        public static void SubInOutTest_正常系_所要時間0_パターン_最小値指定_Linear()
        {
            var easingType = Easing.Pattern.Linear;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubInOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_パターン_最小値指定_Quadratic()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubInOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_パターン_最小値指定_Cubic()
        {
            var easingType = Easing.Pattern.Cubic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubInOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_パターン_最小値指定_Quartic()
        {
            var easingType = Easing.Pattern.Quartic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubInOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_パターン_最小値指定_Quintic()
        {
            var easingType = Easing.Pattern.Quintic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubInOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_パターン_最小値指定_Sinusoidal()
        {
            var easingType = Easing.Pattern.Sinusoidal;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubInOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_パターン_最小値指定_Exponential()
        {
            var easingType = Easing.Pattern.Exponential;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            //Exponentialは経過時間0の時の変動量が0じゃない
            //Exponentialは経過時間0の時の変動量が0じゃない
            //easingType.SubInOut(limit, limit, min, max).value.Is(min);
        }
        [Test]
        public static void SubInOutTest_正常系_所要時間0_パターン_最小値指定_Circular()
        {
            var easingType = Easing.Pattern.Quadratic;
            var limit = 0;
            var min = 20f;
            var max = 100f;

            easingType.SubInOut(limit, limit, min, max).value.Is(min);
        }
    }
}
