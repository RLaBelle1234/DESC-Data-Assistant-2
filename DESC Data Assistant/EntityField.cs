using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESC_Data_Assistant
{
    enum EntityFieldType {SingleLineOfText, OptionSet, TwoOptions, Image, WholeNumber,
                            FloatingPointNumber, DecimalNumber,  Currency, MultipleLinesOfText, DateAndTime, Customer, DateOnly};
    class EntityField
    {
        public bool IsValid = false;
        public string strEntityDisplayName { get; set; }
        public string strEntityFieldName { get; set; }
        public EntityFieldType _enumCRMFieldType { get; set; }
        public int nFieldSize { get; set; }
        

        public bool ParseFieldSQL(string strSQL, string strErrorMessage)
        {
            strErrorMessage = "";
            bool bValid = true;

           

            // split on whitespace
            string[] arrParams = strSQL.Split();

            // First is the fieldname
            string strProposedFieldName = arrParams.First();
            if (FixupFieldName(ref strProposedFieldName))
            {
                strEntityFieldName = strProposedFieldName;
            }
            

            // Display Name
            if (bValid)
            {
                this.strEntityDisplayName = strProposedFieldName.Replace("_", " ");
            }

            // Get the datatype
            string strSqlDatatype = arrParams[1];
            if(!ParseCRMDataType(strSqlDatatype, strErrorMessage))
            {
                bValid = false;
            }

            return bValid;

        }

        public bool FixupFieldName(ref string strFieldName)
        {
            // Todo = check for reserved words on Dynamics Names
            return true;
        }

        public bool ParseCRMDataType(string strDataType, string strError)
        {
            // This string is expected to be in this format:
            // EITHER OF "datatype" -- or -- "datatype(size)"

            // sized types are varchar or nvarchar

            bool bSizedType = false;
            int nFieldSize = 0;

            string[] arrStrings = strDataType.Split('(');

            // Handle a size, if any
            if(arrStrings.Count() > 1)
            {
                bSizedType = true;

                if(!int.TryParse(arrStrings[1].Replace(")", string.Empty), out nFieldSize))
                {
                    //To do = handle varchar max!  nvarchar(max)

                    strError = "Error getting field size on a sized type!";
                    this.IsValid = false;
                    return(false);
                }

                this.nFieldSize = nFieldSize;
            }

            if (bSizedType)
            {
                switch (arrStrings[0])
                {
                    case "varchar":
                    case "nvarchar":
                        this._enumCRMFieldType = EntityFieldType.SingleLineOfText;
                        break;

                    default:
                        strError = "Invalid sized type";
                        return false;
                }

            } else
            {

                // Unsized types

                switch (arrStrings[0])
                {

                    case "datetime":
                        this._enumCRMFieldType = EntityFieldType.DateAndTime;
                        break;
                    case "date":
                        this._enumCRMFieldType = EntityFieldType.DateOnly;
                        break;
                    case "bigint":
                        this._enumCRMFieldType = EntityFieldType.DecimalNumber;
                        break;
                    case "bit":
                        this._enumCRMFieldType = EntityFieldType.TwoOptions;
                        break;
                    case "money":
                        this._enumCRMFieldType = EntityFieldType.Currency;
                        break;

                    default:
                        strError = "Invalid unsized type";
                        return false;
                }
            }


            return true;
        }

    }
}
