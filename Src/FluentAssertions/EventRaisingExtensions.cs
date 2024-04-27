using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using FluentAssertions.Common;
using FluentAssertions.Events;
using FluentAssertions.Execution;

namespace FluentAssertions;

/// <summary>
/// Provides extension methods for monitoring and querying events.
/// </summary>
public static class EventRaisingExtensions
{
    /// <summary>
    /// Asserts that all occurrences of the event originates from the <param name="expectedSender"/>.
    /// </summary>
    /// <returns>
    /// Returns only the events that comes from that sender.
    /// </returns>
    public static IEventRecording WithSender(this IEventRecording eventRecording, object expectedSender)
    {
        var eventsForSender = new List<OccurredEvent>();
        var otherSenders = new List<object>();

        foreach (OccurredEvent @event in eventRecording)
        {
            bool hasSender = Execute.Assertion
                .ForCondition(@event.Parameters.Length > 0)
                .FailWith(FluentAssertions.EventRaisingExtensions_WithSender_EveryEvent_FailMessageFormat, expectedSender, eventRecording.EventName);

            if (hasSender)
            {
                object sender = @event.Parameters[0];

                if (ReferenceEquals(sender, expectedSender))
                {
                    eventsForSender.Add(@event);
                }
                else
                {
                    otherSenders.Add(sender);
                }
            }
        }

        Execute.Assertion
            .ForCondition(eventsForSender.Count > 0)
            .FailWith(FluentAssertions.EventRaisingExtensions_WithSender_Senders_FailMessageFormat,
                () => expectedSender,
                () => otherSenders.Distinct());

        return new FilteredEventRecording(eventRecording, eventsForSender);
    }

    /// <summary>
    /// Asserts that at least one occurrence of the events has some argument of the expected
    /// type <typeparamref name="T"/> that matches the given predicate.
    /// </summary>
    /// <returns>
    /// Returns only the events having some argument matching both type and predicate.
    /// </returns>
    /// <exception cref="ArgumentNullException"><paramref name="predicate"/> is <see langword="null"/>.</exception>
    public static IEventRecording WithArgs<T>(this IEventRecording eventRecording, Expression<Func<T, bool>> predicate)
    {
        Guard.ThrowIfArgumentIsNull(predicate);

        Func<T, bool> compiledPredicate = predicate.Compile();

        var eventsWithMatchingPredicate = new List<OccurredEvent>();

        foreach (OccurredEvent @event in eventRecording)
        {
            IEnumerable<T> typedParameters = @event.Parameters.OfType<T>();

            if (typedParameters.Any(parameter => compiledPredicate(parameter)))
            {
                eventsWithMatchingPredicate.Add(@event);
            }
        }

        bool foundMatchingEvent = eventsWithMatchingPredicate.Count > 0;

        Execute.Assertion
            .ForCondition(foundMatchingEvent)
            .FailWith(FluentAssertions.EventRaisingExtensions_WithArgs_FailMessageFormat,
                typeof(T),
                predicate.Body);

        return new FilteredEventRecording(eventRecording, eventsWithMatchingPredicate);
    }

    /// <summary>
    /// Asserts that at least one occurrence of the events has arguments of the expected
    /// type <typeparamref name="T"/> that pairwise match all the given predicates.
    /// </summary>
    /// <returns>
    /// Returns only the events having arguments matching both type and all predicates.
    /// </returns>
    /// <remarks>
    /// If a <see langword="null"/> is provided as predicate argument, the corresponding event parameter value is ignored.
    /// </remarks>
    public static IEventRecording WithArgs<T>(this IEventRecording eventRecording, params Expression<Func<T, bool>>[] predicates)
    {
        Func<T, bool>[] compiledPredicates = predicates.Select(p => p?.Compile()).ToArray();

        var eventsWithMatchingPredicate = new List<OccurredEvent>();

        foreach (OccurredEvent @event in eventRecording)
        {
            var typedParameters = @event.Parameters.OfType<T>().ToArray();
            bool hasArgumentOfRightType = typedParameters.Length > 0;

            if (predicates.Length > typedParameters.Length)
            {

                throw new ArgumentException(
                    string.Format(FluentAssertions.EventRaisingExtensions_WithArgs_EventArgumentException_ExceptionMessageFormat,
                        predicates.Length, typeof(T), typedParameters.Length));
            }

            bool isMatch = hasArgumentOfRightType;

            for (int index = 0; index < predicates.Length && isMatch; index++)
            {
                isMatch = compiledPredicates[index]?.Invoke(typedParameters[index]) ?? true;
            }

            if (isMatch)
            {
                eventsWithMatchingPredicate.Add(@event);
            }
        }

        bool foundMatchingEvent = eventsWithMatchingPredicate.Count > 0;

        if (!foundMatchingEvent)
        {
            Execute.Assertion
                .FailWith(
                    FluentAssertions.EventRaisingExtensions_WithArgs_FoundMatchingEvent_FailMessageFormat,
                    typeof(T),
                    string.Join(" | ", predicates.Where(p => p is not null).Select(p => p.Body.ToString())));
        }

        return new FilteredEventRecording(eventRecording, eventsWithMatchingPredicate);
    }
}
