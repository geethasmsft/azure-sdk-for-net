// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Search.Documents.Models
{
    /// <summary> Response from a List Datasources request. If successful, it includes the full definitions of all datasources. </summary>
    internal partial class ListDataSourcesResult
    {
        /// <summary> Initializes a new instance of ListDataSourcesResult. </summary>
        /// <param name="dataSources"> The datasources in the Search service. </param>
        internal ListDataSourcesResult(IEnumerable<DataSource> dataSources)
        {
            if (dataSources == null)
            {
                throw new ArgumentNullException(nameof(dataSources));
            }

            DataSources = dataSources.ToArray();
        }

        /// <summary> Initializes a new instance of ListDataSourcesResult. </summary>
        /// <param name="dataSources"> The datasources in the Search service. </param>
        internal ListDataSourcesResult(IReadOnlyList<DataSource> dataSources)
        {
            DataSources = dataSources;
        }

        /// <summary> The datasources in the Search service. </summary>
        public IReadOnlyList<DataSource> DataSources { get; }
    }
}