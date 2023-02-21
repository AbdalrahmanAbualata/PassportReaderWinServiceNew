
//using Newtonsoft.Json;
//using Newtonsoft.Json.Converters;
//using Newtonsoft.Json.Linq;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Runtime.Serialization;
//using System.Text;
//namespace PassportReaderWinService.Classes
//{

//    [DataContract(Name = "passport")]
//    public class Passport
//    {


//        /// <summary>
//        /// Initializes a new instance of the <see cref="IdCard" /> class.
//        /// </summary>
//        /// <param name="side">side.</param>
//        /// <param name="ecard">ecard.</param>
//        /// <param name="dataPage">dataPage.</param>
//        public IdCard(IdCardSideEnum? side = default(IdCardSideEnum?), Ecard ecard = default(Ecard), DataPage dataPage = default(DataPage), Image image = default(Image))
//        {
//            this.Side = side;
//            this.Ecard = ecard;
//            this.DataPage = dataPage;
//            this.Image = image;
//            //this.MissingFingerprints = missingFingerprints;
//        }


//        /// <summary>
//        /// Enumeration of Hand positions.
//        /// </summary>
//        /// <value>Enumeration of Hand positions.</value>
//        [JsonConverter(typeof(StringEnumConverter))]
//        public enum IdCardSideEnum
//        {
//            /// <summary>
//            /// Enum RightHand for value: RightHand
//            /// </summary>
//            [EnumMember(Value = "FrontSide")]
//            FrontSide = 1,

//            /// <summary>
//            /// Enum LeftHand for value: LeftHand
//            /// </summary>
//            [EnumMember(Value = "BackSide")]
//            BackSide = 2
//        }



//        /// <summary>
//        /// Enumeration of IdCard Side.
//        /// </summary>
//        /// <value>Enumeration of IdCard Side.
//        [DataMember(Name = "side", EmitDefaultValue = false)]
//        public IdCardSideEnum? Side { get; set; }

//        /// <summary>
//        /// Gets or Sets dataPage
//        /// </summary>
//        [DataMember(Name = "dataPage", EmitDefaultValue = false)]
//        public DataPage DataPage { get; set; }


//        /// <summary>
//        /// Gets or Sets ecards
//        /// </summary>
//        [DataMember(Name = "ecard", EmitDefaultValue = false)]
//        public Ecard Ecard { get; set; }

//        /// <summary>
//        /// Gets or Sets Image
//        /// </summary>
//        [DataMember(Name = "image", EmitDefaultValue = false)]
//        public Image Image { get; set; }


//        /// <summary>
//        /// Returns the string presentation of the object
//        /// </summary>
//        /// <returns>String presentation of the object</returns>
//        public override string ToString()
//        {
//            StringBuilder sb = new StringBuilder();
//            sb.Append("class Hand {\n");
//            sb.Append("  Side: ").Append(Side).Append("\n");
//            sb.Append("  Ecard: ").Append(Ecard).Append("\n");
//            sb.Append("  DataPage: ").Append(DataPage).Append("\n");
//            sb.Append("}\n");
//            return sb.ToString();
//        }

//        /// <summary>
//        /// Returns the JSON string presentation of the object
//        /// </summary>
//        /// <returns>JSON string presentation of the object</returns>
//        public virtual string ToJson()
//        {
//            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
//        }




//        /// <summary>
//        /// To validate all properties of the instance
//        /// </summary>
//        /// <param name="validationContext">Validation context</param>
//        /// <returns>Validation Result</returns>
//        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
//        {
//            yield break;
//        }
//    }
//}
