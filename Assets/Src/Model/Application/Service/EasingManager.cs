using Assets.Src.Model.Application.Value;
using System;
using UnityEngine;

namespace Assets.Src.Model.Application.Service
{
    /// <summary>
    /// イージング動作の実計算処理サービス
    /// </summary>
    public static class EasingManager
    {
        public static Fraction In(this Easing easing, int time, Fraction min, Fraction max)
            => In(easing, time, max - min) + min;
        public static Fraction SubIn(this Easing easing, int time, Fraction min, Fraction max)
            => SubIn(easing, time, max - min) + min;
        public static Fraction Out(this Easing easing, int time, Fraction min, Fraction max)
            => Out(easing, time, max - min) + min;
        public static Fraction SubOut(this Easing easing, int time, Fraction min, Fraction max)
            => SubOut(easing, time, max - min) + min;
        public static Fraction InOut(this Easing easing, int time, Fraction min, Fraction max)
            => InOut(easing, time, max - min) + min;
        public static Fraction SubInOut(this Easing easing, int time, Fraction min, Fraction max)
            => SubInOut(easing, time, max - min) + min;

        public static Fraction In(this Easing easing, int time, Fraction max = null)
            => In(easing.pattern, time, easing.timeRequired, max);
        public static Fraction SubIn(this Easing easing, int time, Fraction max = null)
            => SubIn(easing.pattern, time, easing.timeRequired, max);
        public static Fraction Out(this Easing easing, int time, Fraction max = null)
            => Out(easing.pattern, time, easing.timeRequired, max);
        public static Fraction SubOut(this Easing easing, int time, Fraction max = null)
            => SubOut(easing.pattern, time, easing.timeRequired, max);
        public static Fraction InOut(this Easing easing, int time, Fraction max = null)
            => InOut(easing.pattern, time, easing.timeRequired, max);
        public static Fraction SubInOut(this Easing easing, int time, Fraction max = null)
            => SubInOut(easing.pattern, time, easing.timeRequired, max);

        public static Fraction In(this Easing.Pattern easingType, int time, int limit, Fraction min, Fraction max)
            => In(easingType, time, limit, max - min) + min;
        public static Fraction SubIn(this Easing.Pattern easingType, int time, int limit, Fraction min, Fraction max)
            => SubIn(easingType, time, limit, max - min) + min;
        public static Fraction Out(this Easing.Pattern easingType, int time, int limit, Fraction min, Fraction max)
            => Out(easingType, time, limit, max - min) + min;
        public static Fraction SubOut(this Easing.Pattern easingType, int time, int limit, Fraction min, Fraction max)
            => SubOut(easingType, time, limit, max - min) + min;
        public static Fraction InOut(this Easing.Pattern easingType, int time, int limit, Fraction min, Fraction max)
            => InOut(easingType, time, limit, max - min) + min;
        public static Fraction SubInOut(this Easing.Pattern easingType, int time, int limit, Fraction min, Fraction max)
            => SubInOut(easingType, time, limit, max - min) + min;

        public static Fraction In(this Easing.Pattern easingType, int time, int limit, Fraction max = null)
            => easingType.CalcBase(time == limit ? 1 : time.DividedBy(limit), max);
        public static Fraction SubIn(this Easing.Pattern easingType, int time, int limit, Fraction max = null)
            => (max ?? 1f) - easingType.In(time, limit, max ?? 1f);

        public static Fraction Out(this Easing.Pattern easingType, int time, int limit, Fraction max = null)
            => (max ?? 1f) - easingType.CalcBase(time == limit ? 0 : (limit - time).DividedBy(limit), max ?? 1f);
        public static Fraction SubOut(this Easing.Pattern easingType, int time, int limit, Fraction max = null)
            => (max ?? 1f) - easingType.Out(time, limit, max ?? 1f);

        public static Fraction InOut(this Easing.Pattern easingType, int time, int limit, Fraction max = null)
            => time < limit / 2
            ? easingType.In(time, limit / 2, (max ?? 1f) / 2)
            : easingType.Out(time - limit / 2, limit / 2, (max ?? 1f) / 2) + (max ?? 1f) / 2;
        public static Fraction SubInOut(this Easing.Pattern easingType, int time, int limit, Fraction max = null)
            => (max ?? 1f) - easingType.InOut(time, limit, max ?? 1f);

        static Fraction CalcBase(this Easing.Pattern easingType, Fraction diameter, Fraction max = null)
        {
            var maxNonNull = max ?? 1f;
            switch(easingType)
            {
                case Easing.Pattern.Linear:
                    return maxNonNull * diameter;
                case Easing.Pattern.Quadratic:
                    return maxNonNull * diameter * diameter;
                case Easing.Pattern.Cubic:
                    return maxNonNull * diameter * diameter * diameter;
                case Easing.Pattern.Quartic:
                    return maxNonNull * diameter * diameter * diameter * diameter;
                case Easing.Pattern.Quintic:
                    return maxNonNull * diameter * diameter * diameter * diameter * diameter;
                case Easing.Pattern.Sinusoidal:
                    return maxNonNull * (1 - Mathf.Cos((diameter * Mathf.PI / 2).value));
                case Easing.Pattern.Exponential:
                    return maxNonNull * Mathf.Pow(2, (10 * (diameter - 1)).value);
                case Easing.Pattern.Circular:
                    return -maxNonNull * (Mathf.Sqrt((1 - diameter * diameter).value) - 1);
                default:
                    throw new ArgumentOutOfRangeException(nameof(easingType));
            }
        }
    }
}
