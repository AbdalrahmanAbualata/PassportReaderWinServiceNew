
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
namespace PassportReaderWinService.Classes
{

    [DataContract(Name = "DataPage")]
    public class DataPage
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="DataPage" /> class.
        /// </summary>
        /// <param name="passportFields">passportFields.</param>
        /// <param name="image">image.</param>
        public DataPage(List<PassportField> passportFields = default(List<PassportField>), Image image = default(Image))
        {

            this.Image = image;
            this.PassportFields = passportFields;

        }




        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public Image Image { get; set; }


        /// <summary>
        /// Gets or Sets passportFields
        /// </summary>
        [DataMember(Name = "passportFields", EmitDefaultValue = false)]
        public List<PassportField> PassportFields { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Hand {\n");
            sb.Append("  PassportFields: ").Append(PassportFields).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }




        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
