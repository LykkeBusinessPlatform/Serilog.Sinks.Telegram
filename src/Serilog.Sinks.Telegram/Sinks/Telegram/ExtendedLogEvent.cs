﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExtendedLogEvent.cs" company="Haemmer Electronics">
// The project is licensed under the MIT license.
// </copyright>
// <summary>
//   Added a new class to store the first and last occurrence timestamps.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Serilog.Sinks.Telegram
{
    using System;

    using Serilog.Events;

    /// <summary>
    /// Added a new class to store the first and last occurrence timestamps.
    /// </summary>
    public class ExtendedLogEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedLogEvent"/> class.
        /// </summary>
        public ExtendedLogEvent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedLogEvent"/> class.
        /// </summary>
        /// <param name="firstOccurrence">The first occurrence.</param>
        /// <param name="lastOccurrence">The last occurrence.</param>
        /// <param name="logEvent">The log event.</param>
        // ReSharper disable once UnusedMember.Global
        public ExtendedLogEvent(DateTime firstOccurrence, DateTime lastOccurrence, LogEvent logEvent)
        {
            FirstOccurrence = firstOccurrence;
            LastOccurrence = lastOccurrence;
            LogEvent = logEvent;
        }

        /// <summary>
        /// Gets or sets the log event.
        /// </summary>
        public LogEvent LogEvent { get; set; }

        /// <summary>
        /// Gets or sets the first occurrence.
        /// </summary>
        public DateTimeOffset FirstOccurrence { get; set; }

        /// <summary>
        /// Gets or sets the last occurrence.
        /// </summary>
        public DateTimeOffset LastOccurrence { get; set; }
    }
}