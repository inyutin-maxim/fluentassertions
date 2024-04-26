using System;
using FluentAssertions.Common;
using FluentAssertions.Execution;
using FluentAssertions.Numeric;

namespace FluentAssertions;

/// <summary>
/// Contains a number of extension methods for floating point <see cref="NumericAssertions{T}"/>.
/// </summary>
public static class NumericAssertionsExtensions
{
    #region BeCloseTo

    /// <summary>
    /// Asserts an integral value is close to another value within a specified value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="nearbyValue">
    /// The nearby value to compare the actual value with.
    /// </param>
    /// <param name="delta">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<sbyte>> BeCloseTo(this NumericAssertions<sbyte> parent,
        sbyte nearbyValue, byte delta, string because = "",
        params object[] becauseArgs)
    {
        sbyte actualValue = parent.Subject.Value;
        sbyte minValue = (sbyte)(nearbyValue - delta);

        if (minValue > nearbyValue)
        {
            minValue = sbyte.MinValue;
        }

        sbyte maxValue = (sbyte)(nearbyValue + delta);

        if (maxValue < nearbyValue)
        {
            maxValue = sbyte.MaxValue;
        }

        FailIfValueOutsideBounds(minValue <= actualValue && actualValue <= maxValue, nearbyValue, delta, actualValue, because,
            becauseArgs);

        return new AndConstraint<NumericAssertions<sbyte>>(parent);
    }

    /// <summary>
    /// Asserts an integral value is close to another value within a specified value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="nearbyValue">
    /// The nearby value to compare the actual value with.
    /// </param>
    /// <param name="delta">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<byte>> BeCloseTo(this NumericAssertions<byte> parent,
        byte nearbyValue, byte delta, string because = "",
        params object[] becauseArgs)
    {
        byte actualValue = parent.Subject.Value;
        byte minValue = (byte)(nearbyValue - delta);

        if (minValue > nearbyValue)
        {
            minValue = byte.MinValue;
        }

        byte maxValue = (byte)(nearbyValue + delta);

        if (maxValue < nearbyValue)
        {
            maxValue = byte.MaxValue;
        }

        FailIfValueOutsideBounds(minValue <= actualValue && actualValue <= maxValue, nearbyValue, delta, actualValue, because,
            becauseArgs);

        return new AndConstraint<NumericAssertions<byte>>(parent);
    }

    /// <summary>
    /// Asserts an integral value is close to another value within a specified value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="nearbyValue">
    /// The nearby value to compare the actual value with.
    /// </param>
    /// <param name="delta">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<short>> BeCloseTo(this NumericAssertions<short> parent,
        short nearbyValue, ushort delta, string because = "",
        params object[] becauseArgs)
    {
        short actualValue = parent.Subject.Value;
        short minValue = (short)(nearbyValue - delta);

        if (minValue > nearbyValue)
        {
            minValue = short.MinValue;
        }

        short maxValue = (short)(nearbyValue + delta);

        if (maxValue < nearbyValue)
        {
            maxValue = short.MaxValue;
        }

        FailIfValueOutsideBounds(minValue <= actualValue && actualValue <= maxValue, nearbyValue, delta, actualValue, because,
            becauseArgs);

        return new AndConstraint<NumericAssertions<short>>(parent);
    }

    /// <summary>
    /// Asserts an integral value is close to another value within a specified value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="nearbyValue">
    /// The nearby value to compare the actual value with.
    /// </param>
    /// <param name="delta">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<ushort>> BeCloseTo(this NumericAssertions<ushort> parent,
        ushort nearbyValue, ushort delta, string because = "",
        params object[] becauseArgs)
    {
        ushort actualValue = parent.Subject.Value;
        ushort minValue = (ushort)(nearbyValue - delta);

        if (minValue > nearbyValue)
        {
            minValue = ushort.MinValue;
        }

        ushort maxValue = (ushort)(nearbyValue + delta);

        if (maxValue < nearbyValue)
        {
            maxValue = ushort.MaxValue;
        }

        FailIfValueOutsideBounds(minValue <= actualValue && actualValue <= maxValue, nearbyValue, delta, actualValue, because,
            becauseArgs);

        return new AndConstraint<NumericAssertions<ushort>>(parent);
    }

    /// <summary>
    /// Asserts an integral value is close to another value within a specified value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="nearbyValue">
    /// The nearby value to compare the actual value with.
    /// </param>
    /// <param name="delta">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<int>> BeCloseTo(this NumericAssertions<int> parent,
        int nearbyValue, uint delta, string because = "",
        params object[] becauseArgs)
    {
        int actualValue = parent.Subject.Value;
        int minValue = (int)(nearbyValue - delta);

        if (minValue > nearbyValue)
        {
            minValue = int.MinValue;
        }

        int maxValue = (int)(nearbyValue + delta);

        if (maxValue < nearbyValue)
        {
            maxValue = int.MaxValue;
        }

        FailIfValueOutsideBounds(minValue <= actualValue && actualValue <= maxValue, nearbyValue, delta, actualValue, because,
            becauseArgs);

        return new AndConstraint<NumericAssertions<int>>(parent);
    }

    /// <summary>
    /// Asserts an integral value is close to another value within a specified value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="nearbyValue">
    /// The nearby value to compare the actual value with.
    /// </param>
    /// <param name="delta">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<uint>> BeCloseTo(this NumericAssertions<uint> parent,
        uint nearbyValue, uint delta, string because = "",
        params object[] becauseArgs)
    {
        uint actualValue = parent.Subject.Value;
        uint minValue = nearbyValue - delta;

        if (minValue > nearbyValue)
        {
            minValue = uint.MinValue;
        }

        uint maxValue = nearbyValue + delta;

        if (maxValue < nearbyValue)
        {
            maxValue = uint.MaxValue;
        }

        FailIfValueOutsideBounds(minValue <= actualValue && actualValue <= maxValue, nearbyValue, delta, actualValue, because,
            becauseArgs);

        return new AndConstraint<NumericAssertions<uint>>(parent);
    }

    /// <summary>
    /// Asserts an integral value is close to another value within a specified value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="nearbyValue">
    /// The nearby value to compare the actual value with.
    /// </param>
    /// <param name="delta">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<long>> BeCloseTo(this NumericAssertions<long> parent,
        long nearbyValue, ulong delta, string because = "",
        params object[] becauseArgs)
    {
        long actualValue = parent.Subject.Value;
        long minValue = GetMinValue(nearbyValue, delta);
        long maxValue = GetMaxValue(nearbyValue, delta);

        FailIfValueOutsideBounds(minValue <= actualValue && actualValue <= maxValue, nearbyValue, delta, actualValue, because,
            becauseArgs);

        return new AndConstraint<NumericAssertions<long>>(parent);
    }

    /// <summary>
    /// Asserts an integral value is close to another value within a specified value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="nearbyValue">
    /// The nearby value to compare the actual value with.
    /// </param>
    /// <param name="delta">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<ulong>> BeCloseTo(this NumericAssertions<ulong> parent,
        ulong nearbyValue, ulong delta, string because = "",
        params object[] becauseArgs)
    {
        ulong actualValue = parent.Subject.Value;
        ulong minValue = nearbyValue - delta;

        if (minValue > nearbyValue)
        {
            minValue = ulong.MinValue;
        }

        ulong maxValue = nearbyValue + delta;

        if (maxValue < nearbyValue)
        {
            maxValue = ulong.MaxValue;
        }

        FailIfValueOutsideBounds(minValue <= actualValue && actualValue <= maxValue, nearbyValue, delta, actualValue, because,
            becauseArgs);

        return new AndConstraint<NumericAssertions<ulong>>(parent);
    }

    private static void FailIfValueOutsideBounds<TValue, TDelta>(bool valueWithinBounds,
        TValue nearbyValue, TDelta delta, TValue actualValue,
        string because, object[] becauseArgs)
    {
        Execute.Assertion
            .ForCondition(valueWithinBounds)
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NumericAssertions_FailIfValueOutsideBounds_FailMessageFormat,
                delta, nearbyValue, actualValue);
    }

    #endregion

    #region NotBeCloseTo

    /// <summary>
    /// Asserts an integral value is not within another value by a specified value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="distantValue">
    /// The nearby value to compare the actual value with.
    /// </param>
    /// <param name="delta">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<sbyte>> NotBeCloseTo(this NumericAssertions<sbyte> parent,
        sbyte distantValue, byte delta, string because = "",
        params object[] becauseArgs)
    {
        sbyte actualValue = parent.Subject.Value;
        sbyte minValue = (sbyte)(distantValue - delta);

        if (minValue > distantValue)
        {
            minValue = sbyte.MinValue;
        }

        sbyte maxValue = (sbyte)(distantValue + delta);

        if (maxValue < distantValue)
        {
            maxValue = sbyte.MaxValue;
        }

        FailIfValueInsideBounds(!(minValue <= actualValue && actualValue <= maxValue), distantValue, delta, actualValue, because,
            becauseArgs);

        return new AndConstraint<NumericAssertions<sbyte>>(parent);
    }

    /// <summary>
    /// Asserts an integral value is not within another value by a specified value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="distantValue">
    /// The nearby value to compare the actual value with.
    /// </param>
    /// <param name="delta">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<byte>> NotBeCloseTo(this NumericAssertions<byte> parent,
        byte distantValue, byte delta, string because = "",
        params object[] becauseArgs)
    {
        byte actualValue = parent.Subject.Value;
        byte minValue = (byte)(distantValue - delta);

        if (minValue > distantValue)
        {
            minValue = byte.MinValue;
        }

        byte maxValue = (byte)(distantValue + delta);

        if (maxValue < distantValue)
        {
            maxValue = byte.MaxValue;
        }

        FailIfValueInsideBounds(!(minValue <= actualValue && actualValue <= maxValue), distantValue, delta, actualValue, because,
            becauseArgs);

        return new AndConstraint<NumericAssertions<byte>>(parent);
    }

    /// <summary>
    /// Asserts an integral value is not within another value by a specified value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="distantValue">
    /// The nearby value to compare the actual value with.
    /// </param>
    /// <param name="delta">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<short>> NotBeCloseTo(this NumericAssertions<short> parent,
        short distantValue, ushort delta, string because = "",
        params object[] becauseArgs)
    {
        short actualValue = parent.Subject.Value;
        short minValue = (short)(distantValue - delta);

        if (minValue > distantValue)
        {
            minValue = short.MinValue;
        }

        short maxValue = (short)(distantValue + delta);

        if (maxValue < distantValue)
        {
            maxValue = short.MaxValue;
        }

        FailIfValueInsideBounds(!(minValue <= actualValue && actualValue <= maxValue), distantValue, delta, actualValue, because,
            becauseArgs);

        return new AndConstraint<NumericAssertions<short>>(parent);
    }

    /// <summary>
    /// Asserts an integral value is not within another value by a specified value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="distantValue">
    /// The nearby value to compare the actual value with.
    /// </param>
    /// <param name="delta">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<ushort>> NotBeCloseTo(this NumericAssertions<ushort> parent,
        ushort distantValue, ushort delta, string because = "",
        params object[] becauseArgs)
    {
        ushort actualValue = parent.Subject.Value;
        ushort minValue = (ushort)(distantValue - delta);

        if (minValue > distantValue)
        {
            minValue = ushort.MinValue;
        }

        ushort maxValue = (ushort)(distantValue + delta);

        if (maxValue < distantValue)
        {
            maxValue = ushort.MaxValue;
        }

        FailIfValueInsideBounds(!(minValue <= actualValue && actualValue <= maxValue), distantValue, delta, actualValue, because,
            becauseArgs);

        return new AndConstraint<NumericAssertions<ushort>>(parent);
    }

    /// <summary>
    /// Asserts an integral value is not within another value by a specified value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="distantValue">
    /// The nearby value to compare the actual value with.
    /// </param>
    /// <param name="delta">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<int>> NotBeCloseTo(this NumericAssertions<int> parent,
        int distantValue, uint delta, string because = "",
        params object[] becauseArgs)
    {
        int actualValue = parent.Subject.Value;
        int minValue = (int)(distantValue - delta);

        if (minValue > distantValue)
        {
            minValue = int.MinValue;
        }

        int maxValue = (int)(distantValue + delta);

        if (maxValue < distantValue)
        {
            maxValue = int.MaxValue;
        }

        FailIfValueInsideBounds(!(minValue <= actualValue && actualValue <= maxValue), distantValue, delta, actualValue, because,
            becauseArgs);

        return new AndConstraint<NumericAssertions<int>>(parent);
    }

    /// <summary>
    /// Asserts an integral value is not within another value by a specified value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="distantValue">
    /// The nearby value to compare the actual value with.
    /// </param>
    /// <param name="delta">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<uint>> NotBeCloseTo(this NumericAssertions<uint> parent,
        uint distantValue, uint delta, string because = "",
        params object[] becauseArgs)
    {
        uint actualValue = parent.Subject.Value;
        uint minValue = distantValue - delta;

        if (minValue > distantValue)
        {
            minValue = uint.MinValue;
        }

        uint maxValue = distantValue + delta;

        if (maxValue < distantValue)
        {
            maxValue = uint.MaxValue;
        }

        FailIfValueInsideBounds(!(minValue <= actualValue && actualValue <= maxValue), distantValue, delta, actualValue, because,
            becauseArgs);

        return new AndConstraint<NumericAssertions<uint>>(parent);
    }

    /// <summary>
    /// Asserts an integral value is not within another value by a specified value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="distantValue">
    /// The nearby value to compare the actual value with.
    /// </param>
    /// <param name="delta">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<long>> NotBeCloseTo(this NumericAssertions<long> parent,
        long distantValue, ulong delta, string because = "",
        params object[] becauseArgs)
    {
        long actualValue = parent.Subject.Value;
        long minValue = GetMinValue(distantValue, delta);
        long maxValue = GetMaxValue(distantValue, delta);

        FailIfValueInsideBounds(!(minValue <= actualValue && actualValue <= maxValue), distantValue, delta, actualValue, because,
            becauseArgs);

        return new AndConstraint<NumericAssertions<long>>(parent);
    }

    /// <summary>
    /// Asserts an integral value is not within another value by a specified value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="distantValue">
    /// The nearby value to compare the actual value with.
    /// </param>
    /// <param name="delta">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<ulong>> NotBeCloseTo(this NumericAssertions<ulong> parent,
        ulong distantValue, ulong delta, string because = "",
        params object[] becauseArgs)
    {
        ulong actualValue = parent.Subject.Value;
        ulong minValue = distantValue - delta;

        if (minValue > distantValue)
        {
            minValue = ulong.MinValue;
        }

        ulong maxValue = distantValue + delta;

        if (maxValue < distantValue)
        {
            maxValue = ulong.MaxValue;
        }

        FailIfValueInsideBounds(!(minValue <= actualValue && actualValue <= maxValue), distantValue, delta, actualValue, because,
            becauseArgs);

        return new AndConstraint<NumericAssertions<ulong>>(parent);
    }

    private static void FailIfValueInsideBounds<TValue, TDelta>(
        bool valueOutsideBounds,
        TValue distantValue, TDelta delta, TValue actualValue,
        string because, object[] becauseArgs)
    {
        Execute.Assertion
            .ForCondition(valueOutsideBounds)
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NumericAssertions_FailIfValueInsideBounds_FailMessageFormat,
                delta, distantValue, actualValue);
    }

    #endregion

    #region BeApproximately

    /// <summary>
    /// Asserts a floating point value approximates another value as close as possible.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="expectedValue">
    /// The expected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NullableNumericAssertions<float>> BeApproximately(this NullableNumericAssertions<float> parent,
        float expectedValue, float precision, string because = "",
        params object[] becauseArgs)
    {
        Guard.ThrowIfArgumentIsNegative(precision);

        bool success = Execute.Assertion
            .ForCondition(parent.Subject is not null)
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NullableNumericAssertionsOfFloat_BeApproximatelyWhenValueIsNull_FailMessageFormat, expectedValue,
                precision);

        if (success)
        {
            var nonNullableAssertions = new SingleAssertions(parent.Subject.Value);
            nonNullableAssertions.BeApproximately(expectedValue, precision, because, becauseArgs);
        }

        return new AndConstraint<NullableNumericAssertions<float>>(parent);
    }

    /// <summary>
    /// Asserts a floating point value approximates another value as close as possible.
    /// Does not throw if null subject value approximates null <paramref name="expectedValue"/> value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="expectedValue">
    /// The expected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NullableNumericAssertions<float>> BeApproximately(this NullableNumericAssertions<float> parent,
        float? expectedValue, float precision, string because = "",
        params object[] becauseArgs)
    {
        Guard.ThrowIfArgumentIsNegative(precision);

        if (parent.Subject is null && expectedValue is null)
        {
            return new AndConstraint<NullableNumericAssertions<float>>(parent);
        }

        bool succeeded = Execute.Assertion
            .ForCondition(expectedValue is not null)
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NullableNumericAssertionsOfFloat_BeApproximately_FailMessageFormat, expectedValue, precision,
                parent.Subject);

        if (succeeded)
        {
            // ReSharper disable once PossibleInvalidOperationException
            parent.BeApproximately(expectedValue.Value, precision, because, becauseArgs);
        }

        return new AndConstraint<NullableNumericAssertions<float>>(parent);
    }

    /// <summary>
    /// Asserts a floating point value approximates another value as close as possible.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="expectedValue">
    /// The expected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NumericAssertions<float>> BeApproximately(this NumericAssertions<float> parent,
        float expectedValue, float precision, string because = "",
        params object[] becauseArgs)
    {
        if (float.IsNaN(expectedValue))
        {
            throw new ArgumentException("Cannot determine approximation of a float to NaN", nameof(expectedValue));
        }

        Guard.ThrowIfArgumentIsNegative(precision);

        if (float.IsPositiveInfinity(expectedValue))
        {
            FailIfDifferenceOutsidePrecision(float.IsPositiveInfinity(parent.Subject.Value), parent, expectedValue, precision,
                float.NaN, because, becauseArgs);
        }
        else if (float.IsNegativeInfinity(expectedValue))
        {
            FailIfDifferenceOutsidePrecision(float.IsNegativeInfinity(parent.Subject.Value), parent, expectedValue, precision,
                float.NaN, because, becauseArgs);
        }
        else
        {
            float actualDifference = Math.Abs(expectedValue - parent.Subject.Value);

            FailIfDifferenceOutsidePrecision(actualDifference <= precision, parent, expectedValue, precision, actualDifference,
                because, becauseArgs);
        }

        return new AndConstraint<NumericAssertions<float>>(parent);
    }

    /// <summary>
    /// Asserts a double value approximates another value as close as possible.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="expectedValue">
    /// The expected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NullableNumericAssertions<double>> BeApproximately(this NullableNumericAssertions<double> parent,
        double expectedValue, double precision, string because = "",
        params object[] becauseArgs)
    {
        Guard.ThrowIfArgumentIsNegative(precision);

        bool success = Execute.Assertion
            .ForCondition(parent.Subject is not null)
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NullableNumericAssertionsOfDouble_BeApproximatelyWhenValueIsNull_FailMessageFormat, expectedValue,
                precision);

        if (success)
        {
            var nonNullableAssertions = new DoubleAssertions(parent.Subject.Value);
            BeApproximately(nonNullableAssertions, expectedValue, precision, because, becauseArgs);
        }

        return new AndConstraint<NullableNumericAssertions<double>>(parent);
    }

    /// <summary>
    /// Asserts a double value approximates another value as close as possible.
    /// Does not throw if null subject value approximates null <paramref name="expectedValue"/> value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="expectedValue">
    /// The expected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NullableNumericAssertions<double>> BeApproximately(this NullableNumericAssertions<double> parent,
        double? expectedValue, double precision, string because = "",
        params object[] becauseArgs)
    {
        Guard.ThrowIfArgumentIsNegative(precision);

        if (parent.Subject is null && expectedValue is null)
        {
            return new AndConstraint<NullableNumericAssertions<double>>(parent);
        }

        bool succeeded = Execute.Assertion
            .ForCondition(expectedValue is not null)
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NullableNumericAssertionsOfDouble_BeApproximately_FailMessageFormat, expectedValue, precision,
                parent.Subject);

        if (succeeded)
        {
            // ReSharper disable once PossibleInvalidOperationException
            parent.BeApproximately(expectedValue.Value, precision, because, becauseArgs);
        }

        return new AndConstraint<NullableNumericAssertions<double>>(parent);
    }

    /// <summary>
    /// Asserts a double value approximates another value as close as possible.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="expectedValue">
    /// The expected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NumericAssertions<double>> BeApproximately(this NumericAssertions<double> parent,
        double expectedValue, double precision, string because = "",
        params object[] becauseArgs)
    {
        if (double.IsNaN(expectedValue))
        {
            throw new ArgumentException("Cannot determine approximation of a double to NaN", nameof(expectedValue));
        }

        Guard.ThrowIfArgumentIsNegative(precision);

        if (double.IsPositiveInfinity(expectedValue))
        {
            FailIfDifferenceOutsidePrecision(double.IsPositiveInfinity(parent.Subject.Value), parent, expectedValue, precision,
                double.NaN, because, becauseArgs);
        }
        else if (double.IsNegativeInfinity(expectedValue))
        {
            FailIfDifferenceOutsidePrecision(double.IsNegativeInfinity(parent.Subject.Value), parent, expectedValue, precision,
                double.NaN, because, becauseArgs);
        }
        else
        {
            double actualDifference = Math.Abs(expectedValue - parent.Subject.Value);

            FailIfDifferenceOutsidePrecision(actualDifference <= precision, parent, expectedValue, precision, actualDifference,
                because, becauseArgs);
        }

        return new AndConstraint<NumericAssertions<double>>(parent);
    }

    /// <summary>
    /// Asserts a decimal value approximates another value as close as possible.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="expectedValue">
    /// The expected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NullableNumericAssertions<decimal>> BeApproximately(
        this NullableNumericAssertions<decimal> parent,
        decimal expectedValue, decimal precision, string because = "",
        params object[] becauseArgs)
    {
        Guard.ThrowIfArgumentIsNegative(precision);

        bool success = Execute.Assertion
            .ForCondition(parent.Subject is not null)
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NullableNumericAssertionsOfDecimal_BeApproximatelyWhenValueIsNull_FailMessageFormat, expectedValue,
                precision);

        if (success)
        {
            var nonNullableAssertions = new DecimalAssertions(parent.Subject.Value);
            BeApproximately(nonNullableAssertions, expectedValue, precision, because, becauseArgs);
        }

        return new AndConstraint<NullableNumericAssertions<decimal>>(parent);
    }

    /// <summary>
    /// Asserts a decimal value approximates another value as close as possible.
    /// Does not throw if null subject value approximates null <paramref name="expectedValue"/> value.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="expectedValue">
    /// The expected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NullableNumericAssertions<decimal>> BeApproximately(
        this NullableNumericAssertions<decimal> parent,
        decimal? expectedValue, decimal precision, string because = "",
        params object[] becauseArgs)
    {
        Guard.ThrowIfArgumentIsNegative(precision);

        if (parent.Subject is null && expectedValue is null)
        {
            return new AndConstraint<NullableNumericAssertions<decimal>>(parent);
        }

        bool succeeded = Execute.Assertion
            .ForCondition(expectedValue is not null)
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NullableNumericAssertionsOfDecimal_BeApproximately_FailMessageFormat, expectedValue, precision,
                parent.Subject);

        if (succeeded)
        {
            // ReSharper disable once PossibleInvalidOperationException
            parent.BeApproximately(expectedValue.Value, precision, because, becauseArgs);
        }

        return new AndConstraint<NullableNumericAssertions<decimal>>(parent);
    }

    /// <summary>
    /// Asserts a decimal value approximates another value as close as possible.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="expectedValue">
    /// The expected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The maximum amount of which the two values may differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NumericAssertions<decimal>> BeApproximately(this NumericAssertions<decimal> parent,
        decimal expectedValue, decimal precision, string because = "",
        params object[] becauseArgs)
    {
        Guard.ThrowIfArgumentIsNegative(precision);

        decimal actualDifference = Math.Abs(expectedValue - parent.Subject.Value);

        FailIfDifferenceOutsidePrecision(actualDifference <= precision, parent, expectedValue, precision, actualDifference,
            because, becauseArgs);

        return new AndConstraint<NumericAssertions<decimal>>(parent);
    }

    private static void FailIfDifferenceOutsidePrecision<T>(
        bool differenceWithinPrecision,
        NumericAssertions<T> parent, T expectedValue, T precision, T actualDifference,
        string because, object[] becauseArgs)
        where T : struct, IComparable<T>
    {
        Execute.Assertion
            .ForCondition(differenceWithinPrecision)
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NumericAssertionsOfT_FailIfDifferenceOutsidePrecision_FailMessageFormat,
                parent.Subject, expectedValue, precision, actualDifference);
    }

    #endregion

    #region NotBeApproximately

    /// <summary>
    /// Asserts a floating point value does not approximate another value by a given amount.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="unexpectedValue">
    /// The unexpected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The minimum exclusive amount of which the two values should differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NullableNumericAssertions<float>> NotBeApproximately(this NullableNumericAssertions<float> parent,
        float unexpectedValue, float precision, string because = "",
        params object[] becauseArgs)
    {
        Guard.ThrowIfArgumentIsNegative(precision);

        if (parent.Subject is not null)
        {
            var nonNullableAssertions = new SingleAssertions(parent.Subject.Value);
            nonNullableAssertions.NotBeApproximately(unexpectedValue, precision, because, becauseArgs);
        }

        return new AndConstraint<NullableNumericAssertions<float>>(parent);
    }

    /// <summary>
    /// Asserts a floating point value does not approximate another value by a given amount.
    /// Throws if both subject and <paramref name="unexpectedValue"/> are null.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="unexpectedValue">
    /// The unexpected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The minimum exclusive amount of which the two values should differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NullableNumericAssertions<float>> NotBeApproximately(this NullableNumericAssertions<float> parent,
        float? unexpectedValue, float precision, string because = "",
        params object[] becauseArgs)
    {
        Guard.ThrowIfArgumentIsNegative(precision);

        if (parent.Subject is null != unexpectedValue is null)
        {
            return new AndConstraint<NullableNumericAssertions<float>>(parent);
        }

        bool succeeded = Execute.Assertion
            .ForCondition(parent.Subject is not null && unexpectedValue is not null)
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NullableNumericAssertionsOfFloat_NotBeApproximately_FailMessageFormat, unexpectedValue,
                precision, parent.Subject);

        if (succeeded)
        {
            // ReSharper disable once PossibleInvalidOperationException
            parent.NotBeApproximately(unexpectedValue.Value, precision, because, becauseArgs);
        }

        return new AndConstraint<NullableNumericAssertions<float>>(parent);
    }

    /// <summary>
    /// Asserts a floating point value does not approximate another value by a given amount.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="unexpectedValue">
    /// The unexpected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The minimum exclusive amount of which the two values should differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NumericAssertions<float>> NotBeApproximately(this NumericAssertions<float> parent,
        float unexpectedValue, float precision, string because = "",
        params object[] becauseArgs)
    {
        if (float.IsNaN(unexpectedValue))
        {
            throw new ArgumentException("Cannot determine approximation of a float to NaN", nameof(unexpectedValue));
        }

        Guard.ThrowIfArgumentIsNegative(precision);

        if (float.IsPositiveInfinity(unexpectedValue))
        {
            FailIfDifferenceWithinPrecision(parent, !float.IsPositiveInfinity(parent.Subject.Value), unexpectedValue, precision,
                float.NaN, because, becauseArgs);
        }
        else if (float.IsNegativeInfinity(unexpectedValue))
        {
            FailIfDifferenceWithinPrecision(parent, !float.IsNegativeInfinity(parent.Subject.Value), unexpectedValue, precision,
                float.NaN, because, becauseArgs);
        }
        else
        {
            float actualDifference = Math.Abs(unexpectedValue - parent.Subject.Value);

            FailIfDifferenceWithinPrecision(parent, actualDifference > precision, unexpectedValue, precision, actualDifference,
                because, becauseArgs);
        }

        return new AndConstraint<NumericAssertions<float>>(parent);
    }

    /// <summary>
    /// Asserts a double value does not approximate another value by a given amount.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="unexpectedValue">
    /// The unexpected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The minimum exclusive amount of which the two values should differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NullableNumericAssertions<double>> NotBeApproximately(
        this NullableNumericAssertions<double> parent,
        double unexpectedValue, double precision, string because = "",
        params object[] becauseArgs)
    {
        Guard.ThrowIfArgumentIsNegative(precision);

        if (parent.Subject is not null)
        {
            var nonNullableAssertions = new DoubleAssertions(parent.Subject.Value);
            nonNullableAssertions.NotBeApproximately(unexpectedValue, precision, because, becauseArgs);
        }

        return new AndConstraint<NullableNumericAssertions<double>>(parent);
    }

    /// <summary>
    /// Asserts a double value does not approximate another value by a given amount.
    /// Throws if both subject and <paramref name="unexpectedValue"/> are null.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="unexpectedValue">
    /// The unexpected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The minimum exclusive amount of which the two values should differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NullableNumericAssertions<double>> NotBeApproximately(
        this NullableNumericAssertions<double> parent,
        double? unexpectedValue, double precision, string because = "",
        params object[] becauseArgs)
    {
        Guard.ThrowIfArgumentIsNegative(precision);

        if (parent.Subject is null != unexpectedValue is null)
        {
            return new AndConstraint<NullableNumericAssertions<double>>(parent);
        }

        bool succeeded = Execute.Assertion
            .ForCondition(parent.Subject is not null && unexpectedValue is not null)
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NullableNumericAssertionsOfDouble_NotBeApproximately_FailMessageFormat, unexpectedValue,
                precision, parent.Subject);

        if (succeeded)
        {
            // ReSharper disable once PossibleInvalidOperationException
            parent.NotBeApproximately(unexpectedValue.Value, precision, because, becauseArgs);
        }

        return new AndConstraint<NullableNumericAssertions<double>>(parent);
    }

    /// <summary>
    /// Asserts a double value does not approximate another value by a given amount.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="unexpectedValue">
    /// The unexpected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The minimum exclusive amount of which the two values should differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NumericAssertions<double>> NotBeApproximately(this NumericAssertions<double> parent,
        double unexpectedValue, double precision, string because = "",
        params object[] becauseArgs)
    {
        if (double.IsNaN(unexpectedValue))
        {
            throw new ArgumentException("Cannot determine approximation of a double to NaN", nameof(unexpectedValue));
        }

        Guard.ThrowIfArgumentIsNegative(precision);

        if (double.IsPositiveInfinity(unexpectedValue))
        {
            FailIfDifferenceWithinPrecision(parent, !double.IsPositiveInfinity(parent.Subject.Value), unexpectedValue, precision,
                double.NaN, because, becauseArgs);
        }
        else if (double.IsNegativeInfinity(unexpectedValue))
        {
            FailIfDifferenceWithinPrecision(parent, !double.IsNegativeInfinity(parent.Subject.Value), unexpectedValue, precision,
                double.NaN, because, becauseArgs);
        }
        else
        {
            double actualDifference = Math.Abs(unexpectedValue - parent.Subject.Value);

            FailIfDifferenceWithinPrecision(parent, actualDifference > precision, unexpectedValue, precision, actualDifference,
                because, becauseArgs);
        }

        return new AndConstraint<NumericAssertions<double>>(parent);
    }

    /// <summary>
    /// Asserts a decimal value does not approximate another value by a given amount.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="unexpectedValue">
    /// The unexpected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The minimum exclusive amount of which the two values should differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NullableNumericAssertions<decimal>> NotBeApproximately(
        this NullableNumericAssertions<decimal> parent,
        decimal unexpectedValue, decimal precision, string because = "",
        params object[] becauseArgs)
    {
        Guard.ThrowIfArgumentIsNegative(precision);

        if (parent.Subject is not null)
        {
            var nonNullableAssertions = new DecimalAssertions(parent.Subject.Value);
            NotBeApproximately(nonNullableAssertions, unexpectedValue, precision, because, becauseArgs);
        }

        return new AndConstraint<NullableNumericAssertions<decimal>>(parent);
    }

    /// <summary>
    /// Asserts a decimal value does not approximate another value by a given amount.
    /// Throws if both subject and <paramref name="unexpectedValue"/> are null.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="unexpectedValue">
    /// The unexpected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The minimum exclusive amount of which the two values should differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NullableNumericAssertions<decimal>> NotBeApproximately(
        this NullableNumericAssertions<decimal> parent,
        decimal? unexpectedValue, decimal precision, string because = "",
        params object[] becauseArgs)
    {
        Guard.ThrowIfArgumentIsNegative(precision);

        if (parent.Subject is null != unexpectedValue is null)
        {
            return new AndConstraint<NullableNumericAssertions<decimal>>(parent);
        }

        bool succeeded = Execute.Assertion
            .ForCondition(parent.Subject is not null && unexpectedValue is not null)
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NullableNumericAssertionsOfDecimal_NotBeApproximately_FailMessageFormat, unexpectedValue,
                precision, parent.Subject);

        if (succeeded)
        {
            // ReSharper disable once PossibleInvalidOperationException
            parent.NotBeApproximately(unexpectedValue.Value, precision, because, becauseArgs);
        }

        return new AndConstraint<NullableNumericAssertions<decimal>>(parent);
    }

    /// <summary>
    /// Asserts a decimal value does not approximate another value by a given amount.
    /// </summary>
    /// <param name="parent">The <see cref="NumericAssertions{T}"/> object that is being extended.</param>
    /// <param name="unexpectedValue">
    /// The unexpected value to compare the actual value with.
    /// </param>
    /// <param name="precision">
    /// The minimum exclusive amount of which the two values should differ.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])"/> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is negative.</exception>
    public static AndConstraint<NumericAssertions<decimal>> NotBeApproximately(this NumericAssertions<decimal> parent,
        decimal unexpectedValue, decimal precision, string because = "",
        params object[] becauseArgs)
    {
        Guard.ThrowIfArgumentIsNegative(precision);

        decimal actualDifference = Math.Abs(unexpectedValue - parent.Subject.Value);

        FailIfDifferenceWithinPrecision(parent, actualDifference > precision, unexpectedValue, precision, actualDifference,
            because, becauseArgs);

        return new AndConstraint<NumericAssertions<decimal>>(parent);
    }

    private static void FailIfDifferenceWithinPrecision<T>(
        NumericAssertions<T> parent, bool differenceOutsidePrecision,
        T unexpectedValue, T precision, T actualDifference,
        string because, object[] becauseArgs)
        where T : struct, IComparable<T>
    {
        Execute.Assertion
            .ForCondition(differenceOutsidePrecision)
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NumericAssertions_FailIfDifferenceWithinPrecision_FailMessageFormat,
                parent.Subject, unexpectedValue, precision, actualDifference);
    }

    #endregion

    #region BeNaN

    /// <summary>
    /// Asserts that the number is seen as not a number (NaN).
    /// </summary>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<float>> BeNaN(this NumericAssertions<float> parent,
        string because = "",
        params object[] becauseArgs)
    {
        float actualValue = parent.Subject.Value;

        Execute.Assertion
            .ForCondition(float.IsNaN(actualValue))
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NumericAssertionsOfFloat_BeNaN_FailMessageFormat, actualValue);

        return new AndConstraint<NumericAssertions<float>>(parent);
    }

    /// <summary>
    /// Asserts that the number is seen as not a number (NaN).
    /// </summary>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<double>> BeNaN(this NumericAssertions<double> parent,
        string because = "",
        params object[] becauseArgs)
    {
        double actualValue = parent.Subject.Value;

        Execute.Assertion
            .ForCondition(double.IsNaN(actualValue))
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NumericAssertionsOfDouble_BeNaN_FailMessageFormat, actualValue);

        return new AndConstraint<NumericAssertions<double>>(parent);
    }

    /// <summary>
    /// Asserts that the number is seen as not a number (NaN).
    /// </summary>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NullableNumericAssertions<float>> BeNaN(this NullableNumericAssertions<float> parent,
        string because = "",
        params object[] becauseArgs)
    {
        float? actualValue = parent.Subject;

        Execute.Assertion
            .ForCondition(actualValue is { } value && float.IsNaN(value))
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NullableNumericAssertionsOfFloat_BeNaN_FailMessageFormat, actualValue);

        return new AndConstraint<NullableNumericAssertions<float>>(parent);
    }

    /// <summary>
    /// Asserts that the number is seen as not a number (NaN).
    /// </summary>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NullableNumericAssertions<double>> BeNaN(this NullableNumericAssertions<double> parent,
        string because = "",
        params object[] becauseArgs)
    {
        double? actualValue = parent.Subject;

        Execute.Assertion
            .ForCondition(actualValue is { } value && double.IsNaN(value))
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NullableNumericAssertionsOfDouble_BeNaN_FailMessageFormat, actualValue);

        return new AndConstraint<NullableNumericAssertions<double>>(parent);
    }

    #endregion

    #region NotBeNaN

    /// <summary>
    /// Asserts that the number is not seen as the special value not a number (NaN).
    /// </summary>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<float>> NotBeNaN(this NumericAssertions<float> parent,
        string because = "",
        params object[] becauseArgs)
    {
        float actualValue = parent.Subject.Value;

        Execute.Assertion
            .ForCondition(!float.IsNaN(actualValue))
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NumericAssertionsOfFloat_NotBeNaN_FailMessageFormat);

        return new AndConstraint<NumericAssertions<float>>(parent);
    }

    /// <summary>
    /// Asserts that the number is not seen as the special value not a number (NaN).
    /// </summary>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NumericAssertions<double>> NotBeNaN(this NumericAssertions<double> parent,
        string because = "",
        params object[] becauseArgs)
    {
        double actualValue = parent.Subject.Value;

        Execute.Assertion
            .ForCondition(!double.IsNaN(actualValue))
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NumericAssertionsOfDouble_NotBeNaN_FailMessageFormat);

        return new AndConstraint<NumericAssertions<double>>(parent);
    }

    /// <summary>
    /// Asserts that the number is not seen as the special value not a number (NaN).
    /// </summary>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NullableNumericAssertions<float>> NotBeNaN(this NullableNumericAssertions<float> parent,
        string because = "",
        params object[] becauseArgs)
    {
        float? actualValue = parent.Subject;
        bool actualValueIsNaN = actualValue is { } value && float.IsNaN(value);

        Execute.Assertion
            .ForCondition(!actualValueIsNaN)
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NullableNumericAssertionsOfFloat_NotBeNaN_FailMessageFormat);

        return new AndConstraint<NullableNumericAssertions<float>>(parent);
    }

    /// <summary>
    /// Asserts that the number is not seen as the special value not a number (NaN).
    /// </summary>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<NullableNumericAssertions<double>> NotBeNaN(this NullableNumericAssertions<double> parent,
        string because = "",
        params object[] becauseArgs)
    {
        double? actualValue = parent.Subject;
        bool actualValueIsNaN = actualValue is { } value && double.IsNaN(value);

        Execute.Assertion
            .ForCondition(!actualValueIsNaN)
            .BecauseOf(because, becauseArgs)
            .FailWith(FluentAssertions.NullableNumericAssertionsOfDouble_NotBeNaN_FailMessageFormat);

        return new AndConstraint<NullableNumericAssertions<double>>(parent);
    }

    #endregion

    private static long GetMinValue(long value, ulong delta)
    {
        long minValue;

        if (delta <= (ulong.MaxValue / 2))
        {
            minValue = value - (long)delta;
        }
        else if (value < 0)
        {
            minValue = long.MinValue;
        }
        else
        {
            minValue = -(long)(delta - (ulong)value);
        }

        if (minValue > value)
        {
            minValue = long.MinValue;
        }

        return minValue;
    }

    private static long GetMaxValue(long value, ulong delta)
    {
        long maxValue;

        if (delta <= (ulong.MaxValue / 2))
        {
            maxValue = value + (long)delta;
        }
        else if (value >= 0)
        {
            maxValue = long.MaxValue;
        }
        else
        {
            maxValue = (long)((ulong)value + delta);
        }

        if (maxValue < value)
        {
            maxValue = long.MaxValue;
        }

        return maxValue;
    }
}
