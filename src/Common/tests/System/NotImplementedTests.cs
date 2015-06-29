// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Xunit;

namespace System
{
    public class NotImplementedTests
    {
        [Fact]
        public void NotImplemented_ByDesign_Throws_NotImplemented_Exception()
        {
            Assert.Throws<NotImplementedException>(() => throw NotImplemented.ByDesign);
        }

        [Fact]
        public void NotImplemented_ByDesignWithMessage_Throws_NotImplementedException_With_Message()
        {
            const string message = "Will not be implemented.";

            Exception exception = Assert.Throws<NotImplementedException>(() => throw NotImplemented.ByDesignWithMessage(message));
            Assert.Equal(message, exception.Message);
        }
   }
}