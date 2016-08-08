using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DESC_Data_Assistant
{
    class DescSqlParserForCrm
    {
        public bool ParseSQL(string strSql, Dictionary<string, object> dictEntityFields, string strErr)
        {
            bool bReturnValue = false;

            //We like pretty strings
            strSql = RemoveLineEndings(strSql);
            strSql = strSql.Replace("[", string.Empty).Replace("]", string.Empty);

            // Split the SQL at commas
            string[] strarrFieldsSQL = strSql.Split(',');

            // anything?
            if(strarrFieldsSQL.Count() == 0)
            {
                return bReturnValue;
            }

            //Parse each field
            foreach(string strField in strarrFieldsSQL)
            {
                EntityField entityfield = new EntityField();
                bool bResult = entityfield.ParseFieldSQL(strField, strErr);

                if(bResult)
                {
                    dictEntityFields.Add(entityfield.strEntityDisplayName, entityfield);
                }
                
            }

            bReturnValue = true;
            return bReturnValue;

        }

        public String RemoveLineEndings(String text)
        {
            StringBuilder newText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsControl(text, i))
                    newText.Append(text[i]);
            }
            return newText.ToString();
        }
    }
}
