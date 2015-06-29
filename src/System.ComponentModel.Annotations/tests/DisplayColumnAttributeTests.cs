// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Xunit;

namespace System.ComponentModel.DataAnnotations
{
    public class DisplayColumnAttributeTests
    {

        [Theory]
        [InlineData("ColumnOne")]
        public void Can_construct_and_get_DisplayColumn(string displayColumn)
        {
            var attribute = new DisplayColumnAttribute(displayColumn);
            
            Assert.Equal(displayColumn, attribute.DisplayColumn);
            Assert.Equal(null, attribute.SortColumn);
            Assert.Equal(false, attribute.SortDescending);
        }

        [Theory]
        [InlineData("ColumnOne", "ColumnTwo")]
        public void Can_construct_and_get_DisplayColumn_and_SortColumn(string displayColumn, string sortColumn)
        {
            var attribute = new DisplayColumnAttribute(displayColumn, sortColumn);
            
            Assert.Equal(displayColumn, attribute.DisplayColumn);
            Assert.Equal(sortColumn, attribute.SortColumn);
            Assert.Equal(false, attribute.SortDescending);
        }
        
        [Theory]
        [InlineData("ColumnOne", "ColumnTwo", true)]
        [InlineData("ColumnOne", "ColumnTwo", false)]
        public void Can_construct_and_get_DisplayColumn_and_SortColumn_and_SortDescending(string displayColumn, string sortColumn, bool sortDescending)
        {
            var attribute = new DisplayColumnAttribute(displayColumn, sortColumn, sortDescending);
            
            Assert.Equal(displayColumn, attribute.DisplayColumn);
            Assert.Equal(sortColumn, attribute.SortColumn);
            Assert.Equal(sortDescending, attribute.SortDescending);
        }
    }
}
