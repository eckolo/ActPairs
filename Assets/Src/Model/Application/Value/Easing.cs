﻿using Assets.Src.Model.Application.Repository;
using Assets.Src.Model.Application.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Model.Application.Value
{
    /// <summary>
    /// 物体の2点間移動に関する挙動パターンデータクラス
    /// </summary>
    public partial class Easing
    {
        public Easing(Pattern pattern, int? timeRequired = null)
        {
            this.pattern = pattern;
            this.timeRequired = timeRequired?.LimitLower(0) ?? this.timeRequired;
        }

        /// <summary>
        /// イージング種別
        /// </summary>
        public Pattern pattern { get; }
        /// <summary>
        /// 所要時間
        /// </summary>
        public int timeRequired { get; } = EasingProperties.DEFAULT_TIME_REQUIRED;
    }
}
