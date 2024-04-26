﻿using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using FluentAssertions.Common;
using FluentAssertions.Equivalency;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;

namespace FluentAssertions;

public static class ObjectAssertionsExtensions
{
    /// <summary>
    /// Asserts that an object can be serialized and deserialized using the data contract serializer and that it stills retains
    /// the values of all members.
    /// </summary>
    /// <param name="assertions"></param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<ObjectAssertions> BeDataContractSerializable(this ObjectAssertions assertions,
        string because = "", params object[] becauseArgs)
    {
        return BeDataContractSerializable<object>(assertions, options => options, because, becauseArgs);
    }

    /// <summary>
    /// Asserts that an object can be serialized and deserialized using the data contract serializer and that it stills retains
    /// the values of all members.
    /// </summary>
    /// <param name="assertions"></param>
    /// <param name="options">
    /// A reference to the <see cref="EquivalencyOptions{TExpectation}"/> configuration object that can be used
    /// to influence the way the object graphs are compared. You can also provide an alternative instance of the
    /// <see cref="EquivalencyOptions{TExpectation}"/> class. The global defaults are determined by the
    /// <see cref="AssertionOptions"/> class.
    /// </param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    /// <exception cref="ArgumentNullException"><paramref name="options"/> is <see langword="null"/>.</exception>
    public static AndConstraint<ObjectAssertions> BeDataContractSerializable<T>(this ObjectAssertions assertions,
        Func<EquivalencyOptions<T>, EquivalencyOptions<T>> options, string because = "",
        params object[] becauseArgs)
    {
        Guard.ThrowIfArgumentIsNull(options);

        try
        {
            var deserializedObject = CreateCloneUsingDataContractSerializer(assertions.Subject);

            EquivalencyOptions<T> defaultOptions = AssertionOptions.CloneDefaults<T>()
                .RespectingRuntimeTypes().IncludingFields().IncludingProperties();

            ((T)deserializedObject).Should().BeEquivalentTo((T)assertions.Subject, _ => options(defaultOptions));
        }
        catch (Exception exc)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .FailWith(FluentAssertions.ObjectAssertions_BeDataContractSerializable_FailMessageFormat
                    + Environment.NewLine + Environment.NewLine + "{1}.",
                    assertions.Subject,
                    exc.Message);
        }

        return new AndConstraint<ObjectAssertions>(assertions);
    }

    private static object CreateCloneUsingDataContractSerializer(object subject)
    {
        using var stream = new MemoryStream();
        var serializer = new DataContractSerializer(subject.GetType());
        serializer.WriteObject(stream, subject);
        stream.Position = 0;
        return serializer.ReadObject(stream);
    }

    /// <summary>
    /// Asserts that an object can be serialized and deserialized using the XML serializer and that it stills retains
    /// the values of all members.
    /// </summary>
    /// <param name="assertions"></param>
    /// <param name="because">
    /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
    /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
    /// </param>
    /// <param name="becauseArgs">
    /// Zero or more objects to format using the placeholders in <paramref name="because" />.
    /// </param>
    public static AndConstraint<ObjectAssertions> BeXmlSerializable(this ObjectAssertions assertions, string because = "",
        params object[] becauseArgs)
    {
        try
        {
            object deserializedObject = CreateCloneUsingXmlSerializer(assertions.Subject);

            deserializedObject.Should().BeEquivalentTo(assertions.Subject,
                options => options.RespectingRuntimeTypes().IncludingFields().IncludingProperties());
        }
        catch (Exception exc)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .FailWith(FluentAssertions.ObjectAssertions_BeXmlSerializable_FailMessageFormat
                    + Environment.NewLine + Environment.NewLine + "{1}.",
                    assertions.Subject,
                    exc.Message);
        }

        return new AndConstraint<ObjectAssertions>(assertions);
    }

    private static object CreateCloneUsingXmlSerializer(object subject)
    {
        using var stream = new MemoryStream();
        var serializer = new XmlSerializer(subject.GetType());
        serializer.Serialize(stream, subject);

        stream.Position = 0;
        return serializer.Deserialize(stream);
    }
}
