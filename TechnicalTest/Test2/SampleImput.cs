using Ocrus;
using Ocrus.Instances;
using Ocrus.Structuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class SampleInput : FieldUse
    {
        public SampleInput(string name) :
            base(
                name: name,
                fieldType: new StringFieldType(TypesNames.CHAINE,""),
                isMandatory: true,
                defaultCropZone: new RelativeCropZone(3, 83, 1, 55))
        {

        }

        protected override CheckTypeResult AdditionalChecks(FieldInstance instance)
        {
            int value = 0;
            int.TryParse(instance.Value, out value);
            if(value % 97 != 0)
            {
                CheckTypeResult.CreateInvalidResult("La clé n'est pas valide");
            }
            return base.AdditionalChecks(instance);
        }
    }
}
