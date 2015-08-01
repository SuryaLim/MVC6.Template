﻿using MvcTemplate.Components.Mvc;
using MvcTemplate.Resources.Form;
using System;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace MvcTemplate.Tests.Unit.Components.Mvc
{
    public class RequiredAdapterTests
    {
        #region Constructor: RequiredAdapter(RequiredAttribute attribute)

        [Fact]
        public void RequiredAdapter_SetsRequiredErrorMessage()
        {
            RequiredAttribute attribute = new RequiredAttribute();
            new RequiredAdapter(attribute);

            String expected = Validations.FieldIsRequired;
            String actual = attribute.ErrorMessage;

            Assert.Equal(expected, actual);
        }

        #endregion
    }
}
