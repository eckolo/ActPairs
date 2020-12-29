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
            var maxOne = max ?? 1f;

            var progress = isIncrease ? increased : maxOne - increased;
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
            var maxOne = max ?? 1f;
            var onLimit = time == limit;
            var halfLimit = limit / 2;
            var halfMax = maxOne / 2;

            var increased = easingType.bias switch
            {
                Easing.Bias.In => pattern.CalcPattern(onLimit ? 1 : time.DividedBy(limit), maxOne),
                Easing.Bias.Out => maxOne - pattern.CalcPattern(onLimit ? 0 : (limit - time).DividedBy(limit), maxOne),
                Easing.Bias.InOut => time < halfLimit
                    ? (pattern, Easing.Bias.In).ClacProgress(time, halfLimit, halfMax)
                    : (pattern, Easing.Bias.Out).ClacProgress(time - halfLimit, halfLimit, halfMax) + halfMax,
                _ => throw new ArgumentOutOfRangeException(nameof(easingType.bias)),
            };
            return increased;
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
            var maxOne = max ?? 1f;
            var increased = pattern switch
            {
                Easing.Pattern.Linear => maxOne * diameter,
                Easing.Pattern.Quadratic => maxOne * diameter * diameter,
                Easing.Pattern.Cubic => maxOne * diameter * diameter * diameter,
                Easing.Pattern.Quartic => maxOne * diameter * diameter * diameter * diameter,
                Easing.Pattern.Quintic => maxOne * diameter * diameter * diameter * diameter * diameter,
                Easing.Pattern.Sinusoidal => maxOne * (1 - Mathf.Cos((diameter * Mathf.PI / 2).value)),
                Easing.Pattern.Exponential => maxOne * Mathf.Pow(2, (10 * (diameter - 1)).value),
                Easing.Pattern.Circular => -maxOne * (Mathf.Sqrt((1 - diameter * diameter).value) - 1),
                _ => throw new ArgumentOutOfRangeException(nameof(pattern)),
            };
            return increased;
        }
    }
}
