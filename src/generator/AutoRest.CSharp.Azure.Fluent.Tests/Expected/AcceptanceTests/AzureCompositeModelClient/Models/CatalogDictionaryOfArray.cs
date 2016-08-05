// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient.Models
{
    using System.Linq;

    public partial class CatalogDictionaryOfArray
    {
        /// <summary>
        /// Initializes a new instance of the CatalogDictionaryOfArray class.
        /// </summary>
        public CatalogDictionaryOfArray() { }

        /// <summary>
        /// Initializes a new instance of the CatalogDictionaryOfArray class.
        /// </summary>
        /// <param name="productDictionaryOfArray">Dictionary of Array of
        /// product</param>
        public CatalogDictionaryOfArray(System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<ProductInner>> productDictionaryOfArray = default(System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<ProductInner>>))
        {
            ProductDictionaryOfArray = productDictionaryOfArray;
        }

        /// <summary>
        /// Gets or sets dictionary of Array of product
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "productDictionaryOfArray")]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<ProductInner>> ProductDictionaryOfArray { get; set; }

    }
}
