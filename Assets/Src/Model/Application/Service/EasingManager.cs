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
        /// <summary>
        /// イージングの途中経過取得
        /// </summary>
        /// <param name="easing">イージング処理定義パラメータ</param>
        /// <param name="time">経過時間</param>
        /// <param name="min">最小値</param>
        /// <param name="max">最大値</param>
        /// <returns>途中経過値</returns>
        public static Fraction GetProgress(
            this Easing easing,
            int time,
            Fraction min,
            Fraction max)
            => easing.GetProgress(time, max - min) + min;
        /// <summary>
        /// イージングの途中経過取得
        /// </summary>
        /// <param name="easing">イージング処理定義パラメータ</param>
        /// <param name="time">経過時間</param>
        /// <param name="max">最大値</param>
        /// <returns>途中経過値</returns>
        public static Fraction GetProgress(
            this Easing easing,
            int time,
            Fraction max = null)
            => (easing.pattern, easing.bias).GetProgress(time, easing.timeRequired, max, easing.isIncrease);
        /// <summary>
        /// イージングの途中経過取得
        /// </summary>
        /// <param name="easingType">イージングの挙動タイプ</param>
        /// <param name="time">経過時間</param>
        /// <param name="limit">所要時間</param>
        /// <param name="min">最小値</param>
        /// <param name="max">最大値</param>
        /// <param name="isIncrease">値が増加するか否か</param>
        /// <returns>途中経過値</returns>
        public static Fraction GetProgress(
            this (Easing.Pattern pattern, Easing.Bias bias) easingType,
            int time,
            int limit,
            Fraction min,
            Fraction max,
            bool isIncrease = false)
            => easingType.GetProgress(time, limit, max - min, isIncrease) + min;
        /// <summary>
        /// イージングの途中経過取得
        /// </summary>
        /// <param name="easingType">イージングの挙動タイプ</param>
        /// <param name="time">経過時間</param>
        /// <param name="limit">所要時間</param>
        /// <param name="max">最大値</param>
        /// <param name="isIncrease">値が増加するか否か</param>
        /// <returns>途中経過値</returns>
        public static Fraction GetProgress(
            this (Easing.Pattern pattern, Easing.Bias bias) easingType,
            int time,
            int limit,
            Fraction max = null,
            bool isIncrease = false)
        {
            var increased = easingType.ClacProgress(time, limit, max);
            var maxNonNull = max ?? 1f;

            var progress = isIncrease ? increased : maxNonNull - increased;
            return progress;
        }
        /// <summary>
        /// イージングの途中経過取得
        /// </summary>
        /// <param name="easingType">イージングの挙動タイプ</param>
        /// <param name="time">経過時間</param>
        /// <param name="limit">所要時間</param>
        /// <param name="isIncrease">値が増加するか否か</param>
        /// <returns>途中経過値</returns>
        public static Fraction GetProgress(
            this (Easing.Pattern pattern, Easing.Bias bias) easingType,
            int time,
            int limit,
            bool isIncrease)
            => easingType.GetProgress(time, limit, null, isIncrease);

        /// <summary>
        /// イージングの途中経過値をパターン毎に計算する
        /// </summary>
        /// <param name="easingType">イージングの挙動タイプ</param>
        /// <param name="time">経過時間</param>
        /// <param name="limit">所要時間</param>
        /// <param name="max">最大値</param>
        /// <returns>0スタートでの増加量途中経過値</returns>
        static Fraction ClacProgress(
            this (Easing.Pattern pattern, Easing.Bias bias) easingType,
            int time,
            int limit,
            Fraction max)
        {
            var pattern = easingType.pattern;
            var maxNonNull = max ?? 1f;
            var timeExpired = time == limit;

            switch(easingType.bias)
            {
                case Easing.Bias.In:
                    return pattern.CalcPattern(timeExpired ? 1 : time.DividedBy(limit), maxNonNull);
                case Easing.Bias.Out:
                    return maxNonNull - pattern.CalcPattern(timeExpired ? 0 : (limit - time).DividedBy(limit), maxNonNull);
                case Easing.Bias.InOut:
                    var halfLimit = limit / 2;
                    var halfMax = maxNonNull / 2;

                    return time < halfLimit
                        ? (pattern, Easing.Bias.In).ClacProgress(time, halfLimit, halfMax)
                        : (pattern, Easing.Bias.Out).ClacProgress(time - halfLimit, halfLimit, halfMax) + halfMax;
                default:
                    throw new ArgumentOutOfRangeException(nameof(easingType.bias));
            }
        }
        /// <summary>
        /// イージングパターン毎の増加差分計算
        /// </summary>
        /// <param name="pattern">イージングパターン</param>
        /// <param name="diameter">時間経過割合</param>
        /// <param name="max">最大値</param>
        /// <returns>所定の時間経過割合における増加量</returns>
        static Fraction CalcPattern(this Easing.Pattern pattern, Fraction diameter, Fraction max)
        {
            var maxNonNull = max ?? 1f;
            switch(pattern)
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
                    throw new ArgumentOutOfRangeException(nameof(pattern));
            }
        }
    }
}
