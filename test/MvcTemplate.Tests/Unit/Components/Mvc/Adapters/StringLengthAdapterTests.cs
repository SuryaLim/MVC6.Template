﻿using MvcTemplate.Components.Mvc;
using MvcTemplate.Resources.Form;
using System;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace MvcTemplate.Tests.Unit.Components.Mvc
{
    public class StringLengthAdapterTests
    {
        #region Constructor: StringLengthAdapter(StringLengthAttribute attribute)

        [Fact]
        public void StringLengthAdapter_SetsMaxLengthErrorMessage()
        {
            StringLengthAttribute attribute = new StringLengthAttribute(128);
            new StringLengthAdapter(attribute);

            String expected = Validations.FieldMustNotExceedLength;
            String actual = attribute.ErrorMessage;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StringLengthAdapter_SetsMinMaxLengthErrorMessage()
        {
            StringLengthAttribute attribute = new StringLengthAttribute(128) { MinimumLength = 4 };
            new StringLengthAdapter(attribute);

            String expected = Validations.FieldMustBeInRangeOfLength;
            String actual = attribute.ErrorMessage;

            Assert.Equal(expected, actual);
        }

        #endregion
    }
}
