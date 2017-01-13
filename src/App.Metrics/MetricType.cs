﻿// Copyright (c) Allan hardy. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace App.Metrics
{
    /// <summary>
    ///     Available metric types
    /// </summary>
    public enum MetricType
    {
        /// <summary>
        ///     A <see href="https://alhardy.github.io/app-metrics-docs/getting-started/metric-types/gauges.html">Gauge</see> Metric
        /// </summary>
        Gauge,

        /// <summary>
        ///     A <see href="https://alhardy.github.io/app-metrics-docs/getting-started/metric-types/counters.html">Counter</see> Metric
        /// </summary>
        Counter,

        /// <summary>
        ///     A <see href="https://alhardy.github.io/app-metrics-docs/getting-started/metric-types/meters.html">Meter</see> Metric
        /// </summary>
        Meter,

        /// <summary>
        ///     A <see href="https://alhardy.github.io/app-metrics-docs/getting-started/metric-types/histograms.html">Histogram</see> Metric
        /// </summary>
        Histogram,

        /// <summary>
        ///     A <see href="https://alhardy.github.io/app-metrics-docs/getting-started/metric-types/timers.html">Timer</see> Metric
        /// </summary>
        Timer,

        /// <summary>
        ///     An <see href="https://alhardy.github.io/app-metrics-docs/getting-started/metric-types/apdex.html">Apdex</see> Metric
        /// </summary>
        Apdex
    }
}