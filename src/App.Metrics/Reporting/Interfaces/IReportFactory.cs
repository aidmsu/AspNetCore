﻿// Copyright (c) Allan hardy. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using App.Metrics.Scheduling.Interfaces;

namespace App.Metrics.Reporting.Interfaces
{
    public interface IReportFactory
    {
        void AddProvider(IReporterProvider provider);

        IReporter CreateReporter(IScheduler scheduler);

        IReporter CreateReporter();
    }
}