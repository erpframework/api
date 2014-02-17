// Copyright (C) 2014 dot42
//
// Original filename: XmlArrayAttribute.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System.Xml.Schema;

namespace System.Xml.Serialization
{
    /// <summary>
    /// Specifies that the XmlSerializer must serialize a particular class member as an array of XML elements.
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = false)]
    public class XmlArrayAttribute : Attribute
    {
        private string elementName;
        private int order;

        /// <summary>
        /// Default ctor
        /// </summary>
        public XmlArrayAttribute()
        {            
        }

        /// <summary>
        /// Element name ctor
        /// </summary>
        public XmlArrayAttribute(string elementName)
        {
            this.elementName = elementName;
        }

        /// <summary>
        /// Gets/sets the XML element name given to the serialized array.
        /// </summary>
        public string ElementName
        {
            get { return elementName ?? string.Empty; }
            set { elementName = value; }
        }

        /// <summary>
        /// Gets/sets the namespace of the XML element.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Gets/sets whether the XML element name generated by the XmlSerializer is qualified or unqualified.
        /// </summary>
        public XmlSchemaForm Form { get; set; }

        /// <summary>
        /// Gets/sets whether the XmlSerializer must serialize a member as an empty XML tag with the xsi:nil attribute set to true.
        /// </summary>
        public bool IsNullable { get; set; }

        /// <summary>
        /// Gets/sets the explicit order in which elements are serialized/deserialized.
        /// </summary>
        public int Order
        {
            get { return order; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Negative values not allowed", "Order");
                order = value;
            }
        }
    }
}
