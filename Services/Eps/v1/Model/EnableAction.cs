using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eps.v1.Model
{
    /// <summary>
    /// 停用启用企业项目操作
    /// </summary>
    public class EnableAction 
    {
        /// <summary>
        /// 启用操作
        /// </summary>
        /// <value>启用操作</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum ENABLE for value: enable
            /// </summary>
            public static readonly ActionEnum ENABLE = new ActionEnum("enable");

            public static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                {"enable", ENABLE},
            };

            private string Value;

            public ActionEnum(string Value)
            {
                this.Value = Value;
            }

            public static ActionEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 启用操作
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnableAction {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnableAction);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnableAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                return hashCode;
            }
        }
    }
}
